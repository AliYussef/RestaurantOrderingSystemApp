﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Employess
    {
        public int employeeID { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public Position position { get; set; }

        public string EmployeeName
        {
            get
            {
                return $"{name} {lastName}"; // string interpolation $
            }
        }

        public Employess(int employeeID, string name, string lastName, Position position)
        {
            this.employeeID = employeeID;
            this.name = name;
            this.lastName = lastName;
            this.position = position;
        }

        public Employess()
        {

        }

    }



}
