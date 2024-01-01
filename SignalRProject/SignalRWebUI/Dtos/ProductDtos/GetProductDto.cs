namespace SignalRWebUI.Dtos.ProductDtos
{
	public class GetProductDto
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public string Description { get; set; } //Açıklama 
		public decimal Price { get; set; } //Fiyat 
		public string ImageUrl { get; set; } //Görsel
		public bool ProductStatus { get; set; }
        public int CategoryID { get; set; }
    }
}
