namespace hackathon_net_products_service_vs.entity
{
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public string sku { get; set; }
        public double price { get; set; }
        public double discount { get; set; }
        public string currency { get; set; }
        public int stock { get; set; }
        public double weight { get; set;}
        public string dimensions { get; set; }
    }
}
