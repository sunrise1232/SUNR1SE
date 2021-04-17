using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Storage.Entity
{
    public class Order
    {
<<<<<<< HEAD
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int TourId { get; set; }
        [ForeignKey(nameof(TourId))]
        public Tour Tour { get; set; }

        [Required]
        public int ClientId { get; set; }
        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; }

        [Required]
        public int StaffId { get; set; }
        [ForeignKey(nameof(StaffId))]
        public Staff Staff { get; set; }

        [DatabaseGenerated()]
        public string Date { get; set; }
=======
        public int Id { get; set; }

        public int TourId { get; set; }
        public Tour Tour { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        public string AcceptDate { get; set; }


>>>>>>> 7c37840c5fe9cf25b38322331773461adae01be2
    }
}
