namespace Psychology.Core.Models
{
    public class Admin : BaseEntity
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePhoto { get; set; }
        public string Token { get; set; }
        public string InvitedToken { get; set; }
        public byte AdminStatus { get; set; }
    }
}
