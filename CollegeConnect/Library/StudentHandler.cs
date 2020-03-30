using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Configuration;
using Microsoft.Extensions.Configuration;

using DataModels.Models;

namespace Library.BusinessLogic
{
    public class StudentHandler
    {
        public StudentHandler()
        { }
        private IConfiguration _configuration;



        public StudentHandler(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }


        public Student[] GetAllStudent()
        {

            DataAccess db = new DataAccess(_configuration);
            var contacts = db.GetAllContactsFromDatabase();
            return contacts;
        }
        public Student[] GetAllStudentSearch(Student r)
        {

            DataAccess db = new DataAccess(_configuration);
            var contacts = db.GetAllContactsFromDatabaseSearch(r);
            return contacts;
        }

        public object AddStudent(Student student)
        {
            DataAccess db = new DataAccess(_configuration);
            var contacts = db.ContactToDatabase(student);
            return contacts;
        }
        public object AddRideFinder(RideFinder r)
        {
            DataAccess db = new DataAccess(_configuration);
            var contacts = db.ContactToDatabaseR(r);
            return contacts;
        }
    }

}

