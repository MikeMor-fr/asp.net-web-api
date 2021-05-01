namespace SelfieAWookies.Core.Selfies.Domain
{
    public class Selfie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }

        public int WookieId { get; set; }
        public Wookie Wookie { get; set; }
    }
}