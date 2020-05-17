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

    public class Order
    {

        [Key]
        public int OrderNumber { get; set; }
        [Required]
        public string OrderOwner { get; set; }
        public bool OrderFinished { get; set; }
        public DateTime OrderTime { get; set; }
        [Required]
        public List<OrderItem> ItemList { get; set; }
      

    }

  
}
