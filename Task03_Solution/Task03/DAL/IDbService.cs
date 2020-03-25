using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task03.Models;

namespace Task03.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
