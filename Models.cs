using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Customer
{
    [Key]
    public int customer_id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public int phone { get; set; }
}