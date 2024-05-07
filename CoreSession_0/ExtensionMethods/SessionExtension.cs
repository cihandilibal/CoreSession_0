using Newtonsoft.Json;

namespace CoreSession_0.ExtensionMethods
{
    public static class SessionExtension
    {
        //Bir metodun Extension method olabilmesi icin ilk parametresini cok özel alması gerekir...Bu ilk parametre verilirken this keyword'u ile baslanmalıdır...Ve entegre edilmek istedigi tip secilmelidir ki o tip icerisinde o metot yer alsın.
        //Sonra diger parametreler normal bir şekilde verilir...


        public static void SetObject(this ISession session, string key, object value)
        {//ISession tipine oyle birsey entegre etmek istiyruz ki yine strnig key alsin ama her türde
         //referans tipte veri de alabilsin.
         //biz aslinda category controller daki httpcontexteki session in tipine metod gömmek istiyoruz.
            string serializedObject = JsonConvert.SerializeObject(value);//isteyen her teknoloji bu nesneyi alirken kalibini istedigi isimde olusturabilir, yeter ki
            //property ayni olsun.
            //veri serialize olur.
            //nesneyi temsil eden jsonstring deger dondurur.
            session.SetString(key, serializedObject); //serialize edilmis string session da saklanir.
           //Anonym tipin serializesi boyledir. 
            

        }

        public static T GetObject<T>(this ISession session,string key) where T : class
            //yapi cast edilir.
        {//metoda generic verilir.hangi tipi cagirirsak o tip doner.
            string serializedObject = session.GetString(key);//cast etmek istenilen yapi yakalanir.
            if(string.IsNullOrEmpty(serializedObject))
            {
                return null;
            }
            T deserializedObject = JsonConvert.DeserializeObject<T>(serializedObject);
            return deserializedObject;
        }
    }
}
