using System.Collections.Generic;

namespace BigBrother.Domain.Configuration
{
    public class ProjectConfiguration
    {
        public string Name { get; set; }

        public List<SubProjectConfiguration> SubProjectConfigurations { get; set; }
    }
}
