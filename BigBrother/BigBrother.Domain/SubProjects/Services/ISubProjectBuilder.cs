using System.Collections.Generic;
using BigBrother.Domain.Configuration;
using BigBrother.Domain.SubProjects.Models;

namespace BigBrother.Domain.SubProjects.Services
{
    public interface ISubProjectBuilder
    {
        IList<SubProjectViewModel> BuildAll(ProjectConfiguration projectConfiguration);
    }
}
