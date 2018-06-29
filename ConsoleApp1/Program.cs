using ConsoleApp1.Controllers;
using ConsoleApp1.Models;
using ConsoleApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentController _studentController = new StudentController();
            while (true)
            {
                int choice = _studentController.menu();
                _studentController.operate(choice);
            }
            
        }
    }
}
