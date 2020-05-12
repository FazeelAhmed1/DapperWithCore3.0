using CoreWithDepper.DAL.Interface;
using CoreWithDepper.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWithDepper.DAL
{
	public class StudenManager: IStudenManager
    {
        public IConfiguration configuration { get; set; }
        string DbString = string.Empty;
        public StudenManager(IConfiguration iConfig)
        {
            configuration = iConfig;
            DbString = configuration.GetSection("ConnectionString").Value.Trim();
        }


        public IEnumerable<Student> GetStudent()
        {
            List<Student> StudentsList = new List<Student>();

            using (IDbConnection con = new SqlConnection(DbString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                StudentsList = con.Query<Student>("Select * from Student").ToList();
            }

            return StudentsList;
        }

        public int AddStudent(Student obj)
        {
            using (IDbConnection con = new SqlConnection(DbString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
              return  con.Execute("INSERT INTO Student (EventName, EventDate, DateCreated) VALUES( "+obj.Name+","+obj.FatherName+","+obj.Age +"");
            }
        }
    }

}
