﻿using System;
using DocumentFormat.OpenXml.Office.CoverPageProps;
using DocumentFormat.OpenXml.Wordprocessing;
using Lab4_Induvidual_Database_Project;
using Lab4_Induvidual_Database_Project.Data;
using Microsoft.VisualBasic;
using Spectre.Console;


namespace Labb4_Individual_Database_project
{
    public class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            school.ShowSchoolStart();
            HashPassword hash = new HashPassword();
            //hash.LoginSchool();
           //hash.AddUserInfo();
        }
    }
}   
