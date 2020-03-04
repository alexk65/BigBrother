using System.Collections.Generic;
using System.Linq;
using BigBrother.Domain.Configuration;
using BigBrother.Domain.Projects.Models;
using BigBrother.Domain.SubProjects.Services;
using Microsoft.Extensions.Options;

namespace BigBrother.Domain.Projects.Services
{
    public class ProjectService : IProjectService
    {
        private readonly ProjectSettings projectSettings;
        private readonly ISubProjectBuilder subProjectBuilder;

        public ProjectService(
            IOptions<ProjectSettings> options,
            ISubProjectBuilder subProjectBuilder)
        {
            projectSettings = options.Value;
            this.subProjectBuilder = subProjectBuilder;
        }

        public IList<ProjectViewModel> GetAll()
        {
            return projectSettings.ProjectConfigurations.Select(BuildProject).ToList();
        }

        private ProjectViewModel BuildProject(ProjectConfiguration projectConfiguration)
        {
            return new ProjectViewModel
            {
                Name = projectConfiguration.Name,
                SubProjects = subProjectBuilder.BuildAll(projectConfiguration)
            };
        }
    }
}
