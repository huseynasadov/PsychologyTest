using System.Collections.Generic;

namespace Psychology.Core.Models
{
    public class Testing : BaseEntity
    {
        public int QuestionCount { get; set; }
        public int PersentageIntrovert { get; set; }
        public int PercentageExtrovert { get; set; }
        public List<TestingAnswer> TestingAnswers { get; set; }
    }
}
