using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class Person
    {
        private DataType dateOfBirth1;

        public string firstName
        {
            get;
            set;
        }

        public string lastName
        {
            get;
            set;
        }
        public int age
        {
            get;
            set;
        }

        public string emailAddress
        {
            get;
            set;
        }

        public DataType dateOfBirth
        {
            get => dateOfBirth1;
            set => dateOfBirth1 = value;
        }

        public string password
        {
            get;
            set;
        }

        public string description
        {
            get;
            set;
        }
    }
}
