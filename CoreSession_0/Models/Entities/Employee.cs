using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CoreSession_0.Models.Entities;

[Serializable]
public partial class Employee
{
    [JsonProperty("EmployeeID")]
    public int EmployeeId { get; set; }

    [JsonProperty("LastName")]

    public string LastName { get; set; } = null!;

    [JsonProperty("FirstName")]

    public string FirstName { get; set; } = null!;

    [JsonIgnore]
    public string? Title { get; set; }

    [JsonIgnore]

    public string? TitleOfCourtesy { get; set; }
    [JsonIgnore]

    public DateTime? BirthDate { get; set; }
    [JsonIgnore]

    public DateTime? HireDate { get; set; }
    [JsonIgnore]

    public string? Address { get; set; }
    [JsonIgnore]

    public string? City { get; set; }
    [JsonIgnore]

    public string? Region { get; set; }
    [JsonIgnore]

    public string? PostalCode { get; set; }
    [JsonIgnore]

    public string? Country { get; set; }
    [JsonIgnore]

    public string? HomePhone { get; set; }
    [JsonIgnore]

    public string? Extension { get; set; }
    [JsonIgnore]

    public byte[]? Photo { get; set; }
    [JsonIgnore]

    public string? Notes { get; set; }
    [JsonIgnore]

    public int? ReportsTo { get; set; }
    [JsonIgnore]

    public string? PhotoPath { get; set; }
    [JsonIgnore]

    public string? Email { get; set; }
    [JsonIgnore]

    public string? Gender { get; set; }
    [JsonIgnore]

    public string? Password { get; set; }
    [JsonIgnore]

    public bool? IsDeleted { get; set; }
    [JsonIgnore]

    public virtual ICollection<Employee> InverseReportsToNavigation { get; set; } = new List<Employee>();
    [JsonIgnore]

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    [JsonIgnore]

    public virtual Employee? ReportsToNavigation { get; set; }
}
