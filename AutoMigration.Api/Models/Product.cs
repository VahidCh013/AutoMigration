namespace AutoMigration.Api.Models;

public class Product
{
    public int Id { get; set; }
    public string ModelCode { get; set; }
    public Category Category { get; set; }
}