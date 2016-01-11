using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildTable.Models
{
    public class MainViewModel
    {
        public List<Student> Students { get; set; }
        public int SelectedState = 0;
        public int SelectedCity = 0;
    }

    public class Student
    {
        public int ID = 0;
        public string Name = "";
        public int StateID = 0;
        public int CityID = 0;
        public List<States> States { get; set; }
        public List<Cities> Cities { get; set; }

    }

    public class States
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Cities
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}