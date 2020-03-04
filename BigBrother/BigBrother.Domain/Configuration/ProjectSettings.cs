using System.Collections.Generic;

namespace BigBrother.Domain.Configuration
{
    public class ProjectSettings
    {
        public string RootPath { get; set; }

        public List<ProjectConfiguration> ProjectConfigurations { get; set; }
    }
}
