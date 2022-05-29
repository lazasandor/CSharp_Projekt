using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Common.Models
{
    public class Job
    {
        public long Id { get; set; }

        public string Customer { get; set; }

        public string CarType { get; set; }

        public string LicensePlateNumber { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

    }
}
