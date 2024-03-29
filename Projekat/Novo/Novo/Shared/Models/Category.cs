﻿namespace Novo.Shared.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? Image { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;

        // Establishing One to many relationship
        public List<Product>? Products { get; set; }

    }
}
