using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task03.Models;

namespace Task03.DAL
{
    public class MockDbService : IDbService
    {
        private static List<Student> _students;
        static MockDbService()
        {
            _students = new List<Student>
            {
                new Student {IdStudent = 1, FirstName="Jan",LastName="Kowalski"},
                new Student {IdStudent = 2, FirstName= "John", LastName="Pawel"},
                new Student {IdStudent =3, FirstName="Duke",LastName="Williams"}

            };
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }

       
           
        
    }
}
