using System;
using lab10ex1;

namespace lab10ex1.Models
{
    public class Student
	{
        

        public int Id { get; set; }
        public string Last { get; set; }
        public string First { get; set; }
        public int Age { get; set; }
        public Degree Degree { get; set; }
       


       /* public Student(int id,  string first, string last, int age, Degree degree)

        {

            this.Id = id;
            this.Last = last;
            this.First = first;
            this.Age = age;
            this.Degree = degree;
           
        }
       */
       

        public override string ToString()

            => $"{First}|{Last}|{Age}|{Degree}";
        
    }
}

