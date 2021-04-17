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

        //[DatabaseGenerated()]
        [Required]
        //генерация даты?
        public string Date { get; set; }
    }
}
