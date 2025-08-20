using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Customer
{
    [Key]
    public int customer_id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public int phone { get; set; }
    public string address { get; set; }
    public string email { get; set; }
    public int code { get; set; }
    public bool active { get; set; }
}
public class Movie
{
    [Key]
    public int movie_od { get; set; }
}
public class Order
{
    [Key]
    public int order_id { get; set; }
    public string notes { get; set; }
    public Guid credit_card { get; set; }
}
public class OrderDetail
{
    [Key]
    public int orderDetail_id { get; set; }
    public string type { get; set; }
}