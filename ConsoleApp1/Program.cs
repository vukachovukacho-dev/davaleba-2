using davaleba11;

namespace ConsoleApp1
{
    internal class Program
    {
        
        private static Student[] students = new Student[100];
        private static int studentCount = 0;
        static void Main(string[] args)
        {
            
            RunTestScenario();

           
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n--- student marvis system ---");
                Console.WriteLine("1.adding a student");
                Console.WriteLine("2.deleting a student");
                Console.WriteLine("3. finding student with ID");
                Console.WriteLine("4.showing all students");
                Console.WriteLine("5. calculating avarege score");
                Console.WriteLine("6. showing best student");
                Console.WriteLine("7. gamosvla");
                Console.Write("pick action (1-7): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1": AddStudentFromConsole(); break;
                    case "2": DeleteStudentFromConsole(); break;
                    case "3": SearchStudentFromConsole(); break;
                    case "4": PrintAllStudents(); break;
                    case "5": ShowAverageGrade(); break;
                    case "6": ShowBestStudent(); break;
                    case "7": running = false; break;
                    default: Console.WriteLine("invalid choice!"); break;
                }
            }
        }

        
        static void AddStudent(int id, string name, int age, double grade)
        {
            if (studentCount >= students.Length)
            {
                Console.WriteLine("massive is full!");
                return;
            }
            students[studentCount] = new Student(id, name, age, grade);
            studentCount++;
            Console.WriteLine($"student {name} add.");
        }

       
        static void DeleteStudent(int id)
        {
            int index = -1;
            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].Id == id) { index = i; break; }
            }

            if (index == -1)
            {
                Console.WriteLine("student wasent found.");
                return;
            }

           
            for (int i = index; i < studentCount - 1; i++)
            {
                students[i] = students[i + 1];
            }
            students[studentCount - 1] = null;
            studentCount--;
            Console.WriteLine($"student ID: {id} was deleted.");
        }

        
        static Student FindStudentById(int id)
        {
            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].Id == id) return students[i];
            }
            return null;
        }

        
        static double CalculateAverage()
        {
            if (studentCount == 0) return 0;
            double sum = 0;
            for (int i = 0; i < studentCount; i++) sum += students[i].Grade;
            return sum / studentCount;
        }

        
        static Student GetBestStudent()
        {
            if (studentCount == 0) return null;
            Student best = students[0];
            for (int i = 1; i < studentCount; i++)
            {
                if (students[i].Grade > best.Grade) best = students[i];
            }
            return best;
        }

        
        static void PrintAllStudents()
        {
            if (studentCount == 0) { Console.WriteLine("list is empty."); return; }
            for (int i = 0; i < studentCount; i++) students[i].PrintInfo();
        }

        
        static void AddStudentFromConsole()
        {
            Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
            Console.Write("name: "); string name = Console.ReadLine();
            Console.Write("age: "); int age = int.Parse(Console.ReadLine());
            Console.Write("score: "); double grade = double.Parse(Console.ReadLine());
            AddStudent(id, name, age, grade);
        }

        static void DeleteStudentFromConsole()
        {
            Console.Write("needs to be deleted ID: "); int id = int.Parse(Console.ReadLine());
            DeleteStudent(id);
        }

        static void SearchStudentFromConsole()
        {
            Console.Write("need to find ID: "); int id = int.Parse(Console.ReadLine());
            Student s = FindStudentById(id);
            if (s != null) s.PrintInfo(); else Console.WriteLine("couldent be found.");
        }

        static void ShowAverageGrade() => Console.WriteLine($"averege score: {CalculateAverage()}");

        static void ShowBestStudent()
        {
            Student b = GetBestStudent();
            if (b != null) { Console.Write("best: "); b.PrintInfo(); }
        }

        
        static void RunTestScenario()
        {
            Console.WriteLine("=== testing ===");
            AddStudent(1, "giorgi", 20, 85);
            AddStudent(2, "ani", 21, 95);
            AddStudent(3, "nika", 19, 70); 
            AddStudent(4, "mari", 22, 90);
            AddStudent(5, "luka", 20, 88);

            Console.WriteLine("\nbefore deleting:"); PrintAllStudents();
            DeleteStudent(3); 
            Console.WriteLine("\nafter deleting:"); PrintAllStudents();

            Console.WriteLine("\nfinding ID 4:");
            Student s = FindStudentById(4); if (s != null) s.PrintInfo();

            ShowAverageGrade();
            ShowBestStudent();
           
        }
    }
}

