namespace SignalR.EntityLayer.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; } //Açıklama 
        public decimal Price { get; set; } //Fiyat 
        public string ImageUrl { get; set; } //Görsel
        public bool ProductStatus { get; set; } 

        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<OrderDetail> Orderdetails { get; set; }
        public List<Basket> Baskets { get; set; }

    }
}
