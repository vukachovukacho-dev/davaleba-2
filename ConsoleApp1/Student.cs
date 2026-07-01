using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba11
{
    public class Student : Person, IPrintable
{
        public int Id { get; set; }
        public double Grade { get; set; }

        
        public Student(int id, string name, int age, double grade) : base(name, age)
        {
            Id = id;
            Grade = grade;
        }

        
        public void PrintInfo()
        {
            System.Console.WriteLine($"ID: {Id} | name: {Name} | age: {Age} | score: {Grade}");
        }
    }
}
