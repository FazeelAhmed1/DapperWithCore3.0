using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWithDepper.Models
{
	public class Student
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter student name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter father name!")]
        public string FatherName { get; set; }

        public int Age { get; set; }



    }
}
