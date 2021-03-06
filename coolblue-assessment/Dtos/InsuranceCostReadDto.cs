using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coolblue_assesment.Dtos
{
    public class InsuranceCostReadDto
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string? name  {get; set;}

        [Required]
        public decimal salesPrice {get; set;}

        [Required]
        public bool canBeInsured {get; set;}

        [Required]
        public decimal insuranceCost {get; set;}   
    }
}