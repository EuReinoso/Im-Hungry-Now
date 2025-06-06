using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table("product")]
public class Product
{
    [Key]
    public int id { get; set; }

    [Required]
    [MaxLength(100)]
    public string name { get; set; }

    [MaxLength(200)]
    public string description { get; set; }

    public string image { get; set; }

    public double price { get; set; }
}