using System;
using System.Collections.Generic;

namespace HumanResource.Models
{
    public interface IPerson
    {
        String Firstnmae { get; set; }

        String LastName { get; set; }

        DateTime BirthDate { get; set; }

        DateTime? PassedAway { get; set; }

        String ExtraInfo { get; set; }

        List<IEducation> Educations { get; set; }

        String Notes { get; set;  }
    }
}