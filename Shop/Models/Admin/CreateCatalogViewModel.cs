﻿using Shop.DAL.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class CreateCatalogViewModel
    {
        [Required]
        public string? Name { get; set; }
        public List<NumberFormData>? numbers { get; set; }
        public List<StringFormData>? strings { get; set; }
        public List<DateFormData>? dates { get; set; }
    }
    public record NumberFormData (string name, List<double> values);
    public record StringFormData(string name, List<string> values);
    public record DateFormData(string name, List<DateTime> values);
}
