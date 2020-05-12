using CoreWithDepper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWithDepper.DAL.Interface
{
	public interface IStudenManager
	{
		 IEnumerable<Student> GetStudent(); 
		 int AddStudent(Student student);
	}
}
