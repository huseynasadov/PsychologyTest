namespace Psychology.Core.Models
{
    public class TestingAnswer : BaseEntity
    {
        public long TestingId { get; set; }
        public long AnswerId { get; set; }
        public virtual Testing Testing { get; set; }
        public virtual Answer Answer { get; set; }
    }
}
