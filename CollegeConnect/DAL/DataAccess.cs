using System;
using DataModels.Models;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
namespace DAL
{
    public class DataAccess
    {
        private readonly string DALconnectionString = "DefaultConnection";
        private IConfiguration configuration;


        public DataAccess() { }
        public DataAccess(IConfiguration Configuration)
        {
            configuration = Configuration;
        }

        public Student[] GetAllContactsFromDatabase()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.BlogConnectionStringValue(configuration, DALconnectionString)))
            {
                string querystring = "select * from Student where Student.SType='" + "P" + "' order by DateCreated;";
                Student[] students = connection.Query<Student>(querystring).ToArray();
                return students;
            }
        }
        public Student[] GetAllContactsFromDatabaseSearch(Student ride)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.BlogConnectionStringValue(configuration, DALconnectionString)))
            {
                string querystring = "select * from Student where Student.Start='" + ride.Start + "' and Student.Dest= '" + ride.Dest + "' and Student.SType='" + "P" + "' and Student.Email!= '"+ride.Email+"'order by DateCreated;";
                Student[] contacts = connection.Query<Student>(querystring).ToArray();
                return contacts;
            }
        }
        public Student[] GetAllContactsFromDatabaseHistory(String email)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.BlogConnectionStringValue(configuration, DALconnectionString)))
            {
                string querystring = "select * from Student where Student.SType='" + "S" + "' and Student.Email= '" + email + "'order by DateCreated;";
                Student[] contacts = connection.Query<Student>(querystring).ToArray();
                return contacts;
            }
        }

        public object ContactToDatabase(Student student)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.BlogConnectionStringValue(configuration, DALconnectionString)))
            {
                //string queryString = "insert into Student(Email,From,To,DateCreated)Values('" + student.Email + "','" + student.From + "','" + student.To + "','" + student.DateCreated + "');";
                string queryString = "insert into Student Values('" + student.Email + "','" + student.Start + "','" + student.Dest + "','" + student.DateCreated + "','" + student.SType + "');";
                Student[] contacts = connection.Query<Student>(queryString).ToArray();
                return contacts;
            }
        }
        public object ContactToDatabaseR(RideFinder student)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.BlogConnectionStringValue(configuration, DALconnectionString)))
            {
                //string queryString = "insert into Student(Email,From,To,DateCreated)Values('" + student.Email + "','" + student.From + "','" + student.To + "','" + student.DateCreated + "');";
                string queryString = "insert into RideFinder Values('" + student.Email + "','" + student.From + "','" + student.To + "');";
                RideFinder[] contacts = connection.Query<RideFinder>(queryString).ToArray();
                return contacts;
            }
        }
    }
}
