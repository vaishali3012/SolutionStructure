using Microsoft.AspNetCore.Mvc;

namespace Hcmrh.Msvc.JobPostings.Api.JobSeeker.Controller
{
    public class JobsController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
