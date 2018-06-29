using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repository
{
    public interface newinterface
    {
        void Insert(Student s);
        bool Delete(int id);
        Student GetById(int id);
        IList<Student> GetAll();
    }

    

    public class StudentRepository : newinterface
    {
        private static IList<Student> _studentlist = new List<Student>();
        
        public bool Delete(int id)
        {
            Student s = GetById(id);
            if (s != null)
            {
    
               return _studentlist.Remove(s);
              
            }
                return false;
        }

        public IList<Student> GetAll()
        {
            return _studentlist;
        }

        public Student GetById(int id)
        {
            foreach(Student s in _studentlist)
            {
                if (s.Id == id)
                {
                    Console.Write(id);
                    return s;
                }
                
            }
            return null;
        }

        public void Insert(Student s)
        {
            Console.WriteLine("data added successfully");
            _studentlist.Add(s);
            
        }
    }
}
