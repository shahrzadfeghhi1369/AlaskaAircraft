using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace AlaskaAircraft.Models
{
    public class Aircraft
    {
        [Required(ErrorMessage = "Tail Number is required.")]

        [StringLength(6, MinimumLength = 6, ErrorMessage = "Invalid Tail Number.")]
        public int Id { get; set; }
        public string Tail_Number { get; set; }
        public string LRU_Name { get; set; }
        public string LRU_Part_Number { get; set; }
        public string Software_Name { get; set; }
        public string Software_Part_Number { get; set; }
        public string EC_Number { get; set; }
        public string Pre_Post_Condition { get; set; }
        public Aircraft()

        {

        }
    }
}
