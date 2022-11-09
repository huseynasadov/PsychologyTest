using System.Collections.Generic;

namespace Psychology.Core.Models
{
    public class Answer : BaseEntity
    {
        public long QuestionId { get; set; }
        public string Description { get; set; }
        public int PercentageIntrovert { get; set; }
        public int PercentageExtrovert { get { return (100 - PercentageIntrovert); } }
        public virtual Question Question { get; set; }
        public virtual List<TestingAnswer> TestingAnswers { get; set; }
    }
}
