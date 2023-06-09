﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromaShop.Models
{
    [PrimaryKey(nameof(ProductId), nameof(ColorId))]
    public class ProductColor
    {
        public string? ImagePath { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product? Product { get; set; }

        public int ColorId { get; set; }

        [ForeignKey("ColorId")]
        public Color? Color { get; set; }
    }
}
