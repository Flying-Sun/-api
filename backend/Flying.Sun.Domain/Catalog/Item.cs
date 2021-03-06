using System.Collections.Generic;
using System;

namespace Flying.Sun.Domain.Catalog
{
    public class Item
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Brand { get; set; }
		public decimal Price { get; set; }
        public List<Rating> Ratings { get; set; }
        public Item(string name, string description, string brand, decimal price)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Item name cannot be null.");
            }
            
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Item description cannot be null.");
            }
            
            if (string.IsNullOrEmpty(brand))
            {
                throw new ArgumentException("Item brand cannot be null.");
            }
            
            if (price < 0.00m || price > 100.00m)
            {
                throw new ArgumentException(
            "Item price must be a positive amount less than $100.00");
            }
            
            this.Name = name;
            this.Description = description;
            this.Brand = brand;
            this.Price = price;
        }
        public void AddRating(Rating rating)
        {
            this.Ratings.Add(rating);
        }

    }
}