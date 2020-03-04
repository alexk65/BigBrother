namespace BigBrother.Domain.Configuration
{
    public class SubProjectConfiguration
    {
        public string Name { get; set; }

        public bool IsRequiredForSpa { get; set; }

        public string HealthCheckUrl { get; set; }
    }
}
