using StudentProject;
using System;
public class Student
{
    public int Id { get; set; }
    public long No { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Department { get; set; }
    public List<Notes> Note { get; set; }
}