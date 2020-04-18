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


        public Student[] GetAllStudent() //Get all ride details
        {

            DataAccess db = new DataAccess(_configuration);
            var contacts = db.GetAllContactsFromDatabase();
            return contacts;
        }

        public Student[] GetAllStudentSearch(Student r) //Gets all the ride details of the search done
        {

            DataAccess db = new DataAccess(_configuration);
            var contacts = db.GetAllContactsFromDatabaseSearch(r);
            return contacts;
        }
        public Student[] GetAllStudentHistory(String email) //Gets all the ride search done by the user
        {

            DataAccess db = new DataAccess(_configuration);
            var contacts = db.GetAllContactsFromDatabaseHistory(email);
            return contacts;
        }

        public object AddStudent(Student student)  //Add student to the database
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

