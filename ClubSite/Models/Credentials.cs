namespace ClubSite.Models
{
    public interface ICredentials
    {
        string userName { get; set; }
        string password { get; set; }
        bool rememberMe { get; set; }
    }

    public class Credentials : ICredentials
    {
        public string userName   { get; set; }
        public string password   { get; set; }
        public bool rememberMe { get; set; }
    }
}