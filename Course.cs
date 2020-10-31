using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Course
    {
        string courseName;
        string courseCode;
        int courseCredit;
        string CourseName
        {
            set { courseName = value; }
            get { return courseName; }
        }
        string CourseCode
        {
            set { courseCode = value; }
            get { return courseCodee; }
        }

        int CourseCredit
        {
            set { courseCredit courseCredit = value; }
            get { return courseCredit; }
        }
        public Course()
        {
        }
        public Course(string courseName, string courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }
        void ShowInfo()
        {
            CourseName = "C #";
            CourseCode = "Rahim";
            CourseCredit = 3;
        }
    }
}
