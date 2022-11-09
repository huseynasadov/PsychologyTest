using System;
using System.ComponentModel.DataAnnotations;

namespace Psychology.Core.Models
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
