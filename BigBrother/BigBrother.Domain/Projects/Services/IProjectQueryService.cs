using System.Collections.Generic;
using BigBrother.Domain.Projects.Models;

namespace BigBrother.Domain.Projects.Services
{
    public interface IProjectService
    {
        IList<ProjectViewModel> GetAll();
    }
}
