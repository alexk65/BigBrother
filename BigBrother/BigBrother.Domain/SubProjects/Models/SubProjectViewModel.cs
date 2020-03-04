namespace BigBrother.Domain.SubProjects.Models
{
    public class SubProjectViewModel
    {
        public SubProjectViewModel(
            string name, 
            string healthCheckUrl, 
            bool isRequiredForSpa, 
            bool isRun)
        {
            Name = name;
            HealthCheckUrl = healthCheckUrl;
            IsRequiredForSpa = isRequiredForSpa;
            IsRun = isRun;
        }

        public string Name { get; set; }

        public string HealthCheckUrl { get; set; }

        public bool IsRequiredForSpa { get; set; }

        public bool IsRun { get; set; }
    }
}
