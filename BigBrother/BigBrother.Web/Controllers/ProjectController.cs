using System.Diagnostics;
using BigBrother.Domain.Projects.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BigBrother.Web.Models;

namespace BigBrother.Web.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ILogger<ProjectController> logger;
        private readonly IProjectService projectQueryService;

        public ProjectController(ILogger<ProjectController> logger, IProjectService projectQueryService)
        {
            this.logger = logger;
            this.projectQueryService = projectQueryService;
        }

        [HttpGet]
        public IActionResult Projects()
        {
            var projects = projectQueryService.GetAll();

            return View(projects);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
