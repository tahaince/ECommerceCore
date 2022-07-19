namespace ECommerceCore.Models.JsonModels
{
    public class ProductResult
    {
       
            public int ProductId { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public int Stock { get; set; }
            public int categoryId { get; set; }
            public string pictureUrl2 { get; set; }
            public string description { get; set; }
            public object category { get; set; }
            public int brandId { get; set; }
            public object brand { get; set; }
            public string pictureUrl { get; set; }
            public object orderSepets { get; set; }
            public object sliders { get; set; }
            public object features { get; set; }
            public object comments { get; set; }
        


    }

    public class ProductJson
    {
        public bool Success { get; set; }
        public List<ProductResult> ProductListe { get; set; }
    }
}
