using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GDSC.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required]
        [MaxLength(40, ErrorMessage = "please Enter Valid Event Name"), MinLength(8)]
        public string EventName { get; set; }

        [Required]
        public DateTime EventStarting { get; set; }

        [Required]
        public DateTime EventEnding { get; set; }

        [NotMapped]
        public IFormFile EventBanner { get; set; }

        public ICollection<Member> Member { get; set; }
    }
}
