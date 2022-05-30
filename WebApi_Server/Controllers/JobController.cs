using Microsoft.AspNetCore.Mvc;
using System;
using WebApi_Common.Models;
using WebApi_Server.Repositories;


namespace WebApi_Server.Controllers
{
    [Route("api/job")]
    [ApiController]
    public class JobController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Job>> Get()
        {
            var job = JobRepository.GetJobs();
            return Ok(job);
        }

        [HttpGet("{id}")]
        public ActionResult<Job> Get(long id)
        {
           var job = JobRepository.GetJob(id);

            if (job != null)
            {
                return Ok(job);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult Post(Job job)
        {
            JobRepository.AddJob(job);

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(Job job, long id)
        {
            var dbjob = JobRepository.GetJob(id);

            if (dbjob != null)
            {
                JobRepository.UpdateJob(job);
                return Ok();
            }


            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var job = JobRepository.GetJob(id);

            if (job != null)
            {
                JobRepository.DeleteJob(job);
                return Ok();
            }

            return NotFound();
        }
    }
}