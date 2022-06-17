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

            Student Yasin = new Student();
            Yasin.Id = 1;
            Yasin.No = 180201001;
            Yasin.Name = "Yasin İlkalp";
            Yasin.Surname = "Arabacı";
            Yasin.Department = "Computer Engineering";
            List<Notes> YasinNotes = new List<Notes>();
            YasinNotes.Add(new Notes() { Note = 50, Course = math });
            Yasin.Note = YasinNotes;


            Student Bedirhan = new Student();
            Bedirhan.Id = 2;
            Bedirhan.No = 180201002;
            Bedirhan.Name = "Bedirhan";
            Bedirhan.Surname = "Horoz";
            Bedirhan.Department = "Computer Engineering";
            List<Notes> BedirhanNotes = new List<Notes>();
            BedirhanNotes.Add(new Notes() { Note = 80, Course = math });
            Bedirhan.Note = BedirhanNotes;

            Student Canan = new Student();
            Canan.Id = 3;
            Canan.No = 180201003;
            Canan.Name = "Canan";
            Canan.Surname = "Abla";
            Canan.Department = "Computer Engineering";
            List<Notes> CananNotes = new List<Notes>();
            CananNotes.Add(new Notes() { Note = 70, Course = phy });
            Canan.Note = CananNotes;

            Student Ugurcan = new Student();
            Ugurcan.Id = 4;
            Ugurcan.No = 180201004;
            Ugurcan.Name = "Uğurcan";
            Ugurcan.Surname = "Uçar";
            Ugurcan.Department = "Computer Engineering";
            List<Notes> UgurcanNotes = new List<Notes>();
            UgurcanNotes.Add(new Notes() { Note = 90, Course = phy });
            Ugurcan.Note = UgurcanNotes;


            Student Berke = new Student();
            Berke.Id = 5;
            Berke.No = 180201005;
            Berke.Name = "Hakkı Berke";
            Berke.Surname = "Akgün";
            Berke.Department = "Computer Engineering";
            List<Notes> BerkeNotes = new List<Notes>();
            BerkeNotes.Add(new Notes() { Note = 70, Course = chem });
            Berke.Note = BerkeNotes;

            Student Fatih = new Student();
            Fatih.Id = 6;
            Fatih.No = 180201006;
            Fatih.Name = "Muhammet Fatih";
            Fatih.Surname = "Özata";
            Fatih.Department = "Computer Engineering";
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
