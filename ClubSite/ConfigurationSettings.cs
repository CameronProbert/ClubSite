namespace ClubSite
{
    public class ConfigurationSettings
    {
        public string ConnectionString { get; set; }
        public SpaSettings Spa { get; set; }
        public CorsSettings Cors { get; set; }

        public class SpaSettings
        {
            public string SourcePath { get; set; }
        }

        public class CorsSettings
        {
            public string PolicyName { get; set; }
        }
    }
}
