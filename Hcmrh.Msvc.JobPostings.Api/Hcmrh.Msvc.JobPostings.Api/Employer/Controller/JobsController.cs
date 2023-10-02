using Microsoft.AspNetCore.Mvc;

namespace Hcmrh.Msvc.JobPostings.Api.Employer.Controller
{
    public class JobsController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
