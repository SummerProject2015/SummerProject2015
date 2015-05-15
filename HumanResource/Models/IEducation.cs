using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResource.Models
{
    public interface IEducation
    {
        String SchoolName { get; set; }
        String Degree { get; set;  }
        DateTime StartDate { get; set; }
        DateTime? EndDate { get; set; }

        String Notes { get; set; }
    }
}
