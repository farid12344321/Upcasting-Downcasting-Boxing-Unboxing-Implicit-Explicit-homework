using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interface
{
    public interface IStudentServices
    {
        int ShowingTheNumberOfStudents();

        int MumericalMean();
        int EmailStartingWithTheLetter();
        int WithTheWordEhmedliInTheAddress();

        int ShowTheList();
        int WithTheSameNames();
    }
}
