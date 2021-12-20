using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GDSC.Models
{
    public class Attendence
    {
        [Key]
        public int Id { get; set; }

        public Member Member { get; set; }
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }

        public Event Event { get; set; }
        public int EventId { get; set; }
       

        [Required]
        public bool Present { get; set; }

        [Required]
        [Column("Current Time", TypeName = "DateTime")]
        public DateTime currentTime = DateTime.Now;
}
}
