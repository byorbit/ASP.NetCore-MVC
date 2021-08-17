using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using OrnekProje.Models.ModelMetadataTypes;

namespace OrnekProje.Models
{
    [ModelMetadataType(typeof(ProductMetadata))]
    public class Product
    {
        public string ProductName { get; set; }
    
        public int Quantity { get; set; }

        public string Email { get; set;}

    }
}
