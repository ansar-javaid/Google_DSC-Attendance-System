using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GDSC.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }


        [Required]
        [MaxLength(40, ErrorMessage = "Please Enter Correct Name."), MinLength(4)]
        public string Name { get; set; }

        [Required]
        public string RegistrationNumber { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [MaxLength(11, ErrorMessage = "Phone Number Must be 11 digits."), MinLength(11)]
        public string PhoneNumber { get; set; }


        [Required]
        public double TicketPrice { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }




    }
}
