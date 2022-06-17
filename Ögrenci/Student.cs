using StudentProject;
using System;
public class Student
{
    public Student()
    {

    }
    public Student(int ıd, long no, string name, string surname)
    {
        Id = ıd;
        No = no;
        Name = name;
        Surname = surname;
        Department = "Computer Engineering";
    }
    
    public int Id { get; set; }
    public long No { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Department { get; set; }
    public List<Notes> Note { get; set; }

}