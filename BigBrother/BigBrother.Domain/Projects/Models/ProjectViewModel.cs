using System.Collections.Generic;
using BigBrother.Domain.SubProjects.Models;

namespace BigBrother.Domain.Projects.Models
{
    public class ProjectViewModel
    {
        public string Name { get; set; }

        public IList<SubProjectViewModel> SubProjects { get; set; }
    }
}
