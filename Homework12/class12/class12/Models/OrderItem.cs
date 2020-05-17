using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace class12.Models
{
    public class OrderItem
    {
        [Key]
        public int ItemNumber { get; set; }
        [Required]
        public double ItemPrice { get; set; }
        [Required]
        public int ItemQuantity { get; set; }
        [Required]
        public string ItemKind { get; set; }
        public string ItemProducer { get; set; }

        public int OrderID { get; set; }

    }
}
