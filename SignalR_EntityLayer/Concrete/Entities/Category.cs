namespace SignalR.EntityLayer.Concrete.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }

        //Creating Relations between Product and Category Table
        public List<Product> Products { get; set;}
    }
}
