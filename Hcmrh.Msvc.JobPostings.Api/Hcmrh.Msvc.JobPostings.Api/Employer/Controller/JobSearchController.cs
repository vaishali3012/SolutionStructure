using Microsoft.AspNetCore.Mvc;

namespace Hcmrh.Msvc.JobPostings.Api.Employer.Controller
{
    public class JobSearchController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
