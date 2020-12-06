using System.Collections.Generic;

namespace shopapp.entity {
    public class Product : IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string  Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }

    }
}