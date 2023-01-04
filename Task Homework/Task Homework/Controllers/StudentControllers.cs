using ServiceLayer.Services;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Homework.Controllers
{
    internal class StudentControllers
    {
        private readonly IStudentServices _service;


        public StudentControllers()
        {
            _service = new StudentServices();
        }

        public void EmailStartingWithTheLetter()
        {
            Console.WriteLine(_service.EmailStartingWithTheLetter());
        }

        public void ShowingTheNumberOfStudents()
        {
            Console.WriteLine(_service.ShowingTheNumberOfStudents());
        }

        public void MumericalMean()
        {
            Console.WriteLine(_service.ShowingTheNumberOfStudents());
        }

        public void ShowTheList()
        {
            Console.WriteLine(_service.ShowTheList());
        }

        public void WithTheSameNames()
        {
            Console.WriteLine(_service.WithTheSameNames());
        }

        public void WithTheWordEhmedliInTheAddress()
        {
            Console.WriteLine(_service.WithTheWordEhmedliInTheAddress());
        }
    }
}
