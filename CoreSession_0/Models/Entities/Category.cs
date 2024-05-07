using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CoreSession_0.Models.Entities;

[Serializable]
public partial class Category
{
    [JsonProperty("CategoryID")]
    public int CategoryId { get; set; }

    [JsonProperty("CategoryName")]
    public string CategoryName { get; set; } = null!;


    [JsonProperty("Description")]
    public string? Description { get; set; }

    [JsonIgnore]
    public byte[]? Picture { get; set; }

    [JsonIgnore]
    public bool? Isdeleted { get; set; }

    [JsonIgnore]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
