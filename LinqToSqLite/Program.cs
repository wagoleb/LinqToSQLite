﻿using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using System.Data.Linq;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSqLite
{

    class Program
    {
        static void Main(string[] args)
        {
            PersonDataBase baza = new PersonDataBase(@"C:\Users\bonow\source\repos\LinqToSQLite\LinqToSqLite\bin\Debug\mydvds.mdf");
            baza.Initialize();
        }
    }
}
