using ConsoleApp1.Models;
using ConsoleApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controllers
{
    class StudentController
    {
        public int menu()
        {
            Console.WriteLine("1. Add ");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. get by id");
            Console.WriteLine("4. show all");
            Console.WriteLine("5. Exit");
            Console.WriteLine("enter your choice");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void operate(int choice)
        {
        
                newinterface _srep = new StudentRepository();
                switch (choice)
                {


                    case 1:
                    start:
                        Student _student = new Student();
                        Console.Write("enter id:");
                        _student.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("enter first name");
                        _student.Firstname = Console.ReadLine();
                        Console.Write("enter last name");
                        _student.Lastname = Console.ReadLine();
                        Console.Write("enter email");
                        _student.Email = Console.ReadLine();
                        Console.Write("enter status");
                        _student.Status = Convert.ToBoolean(Console.ReadLine());

                        _srep.Insert(_student);
                        Console.WriteLine("do you want to add more?[y/n]");
                        if (Console.ReadLine().ToUpper().Equals("Y"))
                        {
                            goto start;
                        }
                        break;

                    case 2:
                        Console.WriteLine("enter id");
                        int del_id = Convert.ToInt32(Console.ReadLine());
                        _srep.Delete(del_id);
                        break;

                    case 3:
                        Console.Write("enter data id to fetch");
                        int get_id = Convert.ToInt32(Console.ReadLine());
                        Student s = _srep.GetById(get_id);
                        if (s != null)
                        {
                            Console.WriteLine("Id:{0}\r\n Firstname:{1}", s.Id, s.Firstname);
                        }
                        else
                            Console.WriteLine("list is empty");
                        break;

                    case 4:
                        Console.WriteLine("printing data" +
                            "\n ==========================================");
                        foreach (Student ss in _srep.GetAll())
                        {
                            if (ss != null)
                            {
                                Console.WriteLine("Id:{0}\r\n Firstname:{1}", ss.Id, ss.Firstname);
                            }
                            else
                                Console.WriteLine("empty list");
                        }
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("invalid choice");
                        break;

                }            

        }
    }
}
