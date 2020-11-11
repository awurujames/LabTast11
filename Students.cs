using System;
namespace UniversityLibrary
{
    public class Students 
    {
        public string StudentName{get;set;}
        public string StudentID{get;set;}
        public string YearStudy{get;set;}

        public Students(string studentname, string studentid, string yearstudy)
        {
            StudentName = studentname;
            StudentID = studentid;
            YearStudy = yearstudy;
        }
    }
}