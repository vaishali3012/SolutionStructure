using Microsoft.AspNetCore.Mvc;

namespace Hcmrh.Msvc.JobPostings.Api.JobSeeker.Controller
{
    public class JobSearchController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
