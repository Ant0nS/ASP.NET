﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.ASP.NET.MVC.Lab1.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() 
        { 
            string s = FirstName + " " + LastName; 
            return s; 
        }
    }
}