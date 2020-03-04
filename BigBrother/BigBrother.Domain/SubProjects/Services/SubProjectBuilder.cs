using System;
using System.Collections.Generic;
using System.Linq;
using BigBrother.Domain.Configuration;
using BigBrother.Domain.SubProjects.Models;
using Flurl.Http;

namespace BigBrother.Domain.SubProjects.Services
{
    public class SubProjectBuilder : ISubProjectBuilder
    {
        public IList<SubProjectViewModel> BuildAll(ProjectConfiguration projectConfiguration)
        {
            return projectConfiguration.SubProjectConfigurations.Select(Build).ToList();
        }

        private SubProjectViewModel Build(SubProjectConfiguration subProjectConfiguration)
        {
            var healthCheckUrl = subProjectConfiguration.HealthCheckUrl;
            var isRun = GetRunState(healthCheckUrl);

            return new SubProjectViewModel(
                subProjectConfiguration.Name,
                healthCheckUrl,
                subProjectConfiguration.IsRequiredForSpa,
                isRun);
        }

        private bool GetRunState(string url)
        {
            var isRun = true;
            try
            {
                _ = url.AllowAnyHttpStatus().GetAsync().Result;
            }
            catch (Exception)
            {
                isRun = false;
            }

            return isRun;
        }
    }
}
