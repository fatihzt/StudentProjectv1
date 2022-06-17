using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    public class program
    {
        public static List<Course> courses = new();
        public static List<Student> students = new();

        static void Main(string[] args)
        {

            Course math = new Course();
            math.Id = 1;
            math.Name = "Mathematic";
            Course chem = new Course();
            chem.Id = 2;
            chem.Name = "Chemistry";
            Course phy = new Course();
            phy.Id = 3;
            phy.Name = "Physics";
            courses.Add(chem);
            courses.Add(phy);
            courses.Add(math);

            Student Yasin = new Student(1,180201001,"Yasin İlkalp","Arabacı");
            
            List<Notes> YasinNotes = new List<Notes>();
            YasinNotes.Add(new Notes() { Note = 50, Course = math });
            Yasin.Note = YasinNotes;


            Student Bedirhan = new Student(2,180201002,"Bedirhan","Horoz");
            
            List<Notes> BedirhanNotes = new List<Notes>();
            BedirhanNotes.Add(new Notes() { Note = 80, Course = math });
            Bedirhan.Note = BedirhanNotes;

            Student Canan = new Student(3,180201002,"Canan","Abla");
            
            List<Notes> CananNotes = new List<Notes>();
            CananNotes.Add(new Notes() { Note = 70, Course = phy });
            Canan.Note = CananNotes;

            Student Ugurcan = new Student(4,180201004,"Ugurcan","Ucar");
            
            List<Notes> UgurcanNotes = new List<Notes>();
            UgurcanNotes.Add(new Notes() { Note = 90, Course = phy });
            Ugurcan.Note = UgurcanNotes;


            Student Berke = new Student(5,180201005,"Hakkı Berke","Akgun");
           
            List<Notes> BerkeNotes = new List<Notes>();
            BerkeNotes.Add(new Notes() { Note = 70, Course = chem });
            Berke.Note = BerkeNotes;

            Student Fatih = new Student(6,180201006,"Muhammet Fatih","Ozata");
            
            List<Notes> FatihNotes = new List<Notes>();
            FatihNotes.Add(new Notes() { Note = 40, Course = chem });
            Fatih.Note = FatihNotes;


            students.Add(Yasin);
            students.Add(Bedirhan);
            students.Add(Canan);
            students.Add(Ugurcan);
            students.Add(Berke);
            students.Add(Fatih);

            Console.WriteLine("----------------------");
            Console.WriteLine("Student's Informations");
            Console.WriteLine("----------------------");

            foreach(Student i in students)
            {
                Console.WriteLine(i.Id + " " + i.Name + " " + i.Surname + " " + i.Department + " " + i.No  );
                foreach(Notes a in i.Note)
                {
                    Console.WriteLine( a.Course.Name+"'s Grade is : "+a.Note + " Course ID is :" + a.Course.Id + " ");
                }
                
            }
            


        }
    }
}
