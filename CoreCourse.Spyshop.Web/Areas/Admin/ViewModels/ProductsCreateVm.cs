﻿using CoreCourse.Spyshop.Domain.Catalog;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreCourse.Spyshop.Web.Areas.Admin.ViewModels
{
    public class ProductsCreateVm
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(5000)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        [MaxLength(250)]
        public string PhotoUrl { get; set; }

        [Display(Name = "Sort number")]
        public int? SortNumber { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Please pick a category", AllowEmptyStrings = false)]
        public long? CategoryId { get; set; }

        public IEnumerable<Category> AvailableCategories { get; set; }

        [UploadedImage(maxLength: 500)]
        public IFormFile UploadedImage { get; set; }

    }
}
