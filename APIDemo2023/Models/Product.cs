namespace APIDemo2023.Models
{
    public class Product
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }    
        public double Price { get; set; }   
        public int CategoryID { get; set; }
        public Category? Category { get; set; }

    }
}
