using System;
using WebApi_Common.Models;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;




namespace WebApi_Server.Repositories
{
    public static class JobRepository
    {
        public static IList<Job> GetJobs()
        {
            using (var database = new JobContext())
            {
                var jobs = database.Jobs.ToList();

                return jobs;
            }
        }

        public static Job GetJob(long id)
        {
            using (var database = new JobContext())
            {
                var jobid = database.Jobs.Where(j => j.Id == id).FirstOrDefault();

                return jobid;
            }
        }

        public static void AddJob(Job job)
        {
            using (var database = new JobContext())
            {
                database.Jobs.Add(job);

                database.SaveChanges();
            }

        }

        public static void UpdateJob(Job job)
        {
            using (var database = new JobContext())
            {
                
               database.Jobs.Update(job);

               database.SaveChanges();
            }

        }

        public static void DeleteJob(Job job)
        {
            using (var database = new JobContext())
            {
                database.Jobs.Remove(job);

                database.SaveChanges();
            }
        }



    }

}