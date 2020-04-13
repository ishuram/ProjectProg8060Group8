using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DataModels.Models
{
    public class Student
    {

        public string Email { get; set; }
    public string Start { get; set; }
        public string Dest { get; set; }
        public DateTime DateCreated { get; set; }
        public string SType { get; set; }

        public bool CheckNotEmpty()
        {
            bool result = true;
            if (Start.Contains('@')|| Start.Contains('!')|| Start.Contains('*')|| Start.Contains('#'))
            {
                result = false;
            }
            return result;
        }
        public bool CheckDestNotEmpty()
        {
            bool result = true;
            if (Dest.Contains('@') || Dest.Contains('!') || Dest.Contains('*') || Dest.Contains('#'))
            {
                result = false;
            }
            return result;
        }
    }
}