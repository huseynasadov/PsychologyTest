using System.Collections.Generic;

namespace Psychology.Core.Models
{
    public class Question : BaseEntity
    {
        public string Description { get; set; }
        public virtual IList<Answer> Answers { get; set; }
    }
}
