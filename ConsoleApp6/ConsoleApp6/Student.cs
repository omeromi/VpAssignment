using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication10
{
    public class Student
    {

        string name;
        int id;
        int sem;
        double cgpa;
        string dep;
        string uni;
        string pathStudent, pathAttend;
        public void getPath(string p1, string p2)
        {
            pathStudent = p1;
            pathAttend = p2;
        }
        public void profile()
        {
            Console.WriteLine("Enter Student Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Student ID: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Semester: ");
            sem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student CGPA: ");
            cgpa = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Departement: ");
            dep = Console.ReadLine();
            Console.WriteLine("Enter Student Unniversityy: ");
            uni = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(pathStudent, true))
            {
                sw.WriteLine(name);
                sw.WriteLine(id);
                sw.WriteLine(sem);
                sw.WriteLine(cgpa);
                sw.WriteLine(dep);
                sw.WriteLine(uni);

            }
            Console.WriteLine("File Written Successfully\n");
        }

        public void searchById(int ID)
        {
            int linesCount = File.ReadAllLines(pathStudent).Length;
            string[] name1= new string[linesCount / 6];
            string[] department1 = new string[linesCount / 6];
            string[] uni1 = new string[linesCount / 6];
            int[] id1 = new int[linesCount / 6];
            int[] sem1 = new int[linesCount / 6];
            double[] cgpa1 = new double[linesCount / 6];
            for (int i=0;i<linesCount/6;i++)
            {
                using(StreamReader sr=new StreamReader(pathStudent))
                {
                    name1[i] = sr.ReadLine();
                    id1[i] = Convert.ToInt32(sr.ReadLine());
                    sem1[i] =Convert.ToInt32( sr.ReadLine());
                    cgpa1[i] =Convert.ToDouble( sr.ReadLine());
                    department1[i] = sr.ReadLine();
                    uni1[i] = sr.ReadLine();

                }
            }
            bool check = false;
            for(int i=0;i<linesCount/6;i++)
            {
                if(id1[i]==ID)
                {
                    Console.WriteLine("File Found Data is :");
                    Console.WriteLine(name1[i]+" "+ id1[i] + " "+sem1[i] + " "+cgpa1[i] + " "+department1[i] + " "+uni1[i] );
                    check = true;
                }
            }
            if(check==false)
            {
                Console.WriteLine("FIle not foud\n");
            }

        }
        public void searchByName(string nam)
        {

            int linesCount = File.ReadAllLines(pathStudent).Length;
            string[] name1 = new string[linesCount / 6];
            string[] department1 = new string[linesCount / 6];
            string[] uni1 = new string[linesCount / 6];
            int[] id1 = new int[linesCount / 6];
            int[] sem1 = new int[linesCount / 6];
            double[] cgpa1 = new double[linesCount / 6];
            for (int i = 0; i < linesCount / 6; i++)
            {
                using (StreamReader sr = new StreamReader(pathStudent))
                {
                    name1[i] = sr.ReadLine();
                    id1[i] = Convert.ToInt32(sr.ReadLine());
                    sem1[i] = Convert.ToInt32(sr.ReadLine());
                    cgpa1[i] = Convert.ToDouble(sr.ReadLine());
                    department1[i] = sr.ReadLine();
                    uni1[i] = sr.ReadLine();

                }
            }
            bool check = false;
            for (int i = 0; i < linesCount / 6; i++)
            {
                if (name1[i] == nam)
                {
                    Console.WriteLine("File Found Data is :");
                    Console.WriteLine(name1[i] + " " + id1[i] + " " + sem1[i] + " " + cgpa1[i] + " " + department1[i] + " " + uni1[i]);
                    check = true;
                }
            }
            if (check == false)
            {
                Console.WriteLine("FIle not foud\n");
            }
        }
        public void SearchAll()
        {

            int linesCount = File.ReadAllLines(pathStudent).Length;
            string[] name1 = new string[linesCount / 6];
            string[] department1 = new string[linesCount / 6];
            string[] uni1 = new string[linesCount / 6];
            int[] id1 = new int[linesCount / 6];
            int[] sem1 = new int[linesCount / 6];
            double[] cgpa1 = new double[linesCount / 6];
            using (StreamReader sr = new StreamReader(pathStudent))
            for (int i = 0; i < linesCount / 6; i++)
            {
                {
                    name1[i] = sr.ReadLine();
                    id1[i] = Convert.ToInt32(sr.ReadLine());
                    sem1[i] = Convert.ToInt32(sr.ReadLine());
                    cgpa1[i] = Convert.ToDouble(sr.ReadLine());
                    department1[i] = sr.ReadLine();
                    uni1[i] = sr.ReadLine();

                }
            }
            for (int i = 0; i < linesCount / 6; i++)
            {
                    Console.WriteLine(name1[i] + " " + id1[i] + " " + sem1[i] + " " + cgpa1[i] + " " + department1[i] + " " + uni1[i]);

            }
           
        }
        public void delete(int ID)
        {
            int linesCount = File.ReadAllLines(pathStudent).Length;
            string[] name1 = new string[linesCount / 6];
            string[] department1 = new string[linesCount / 6];
            string[] uni1 = new string[linesCount / 6];
            int[] id1 = new int[linesCount / 6];
            int[] sem1 = new int[linesCount / 6];
            double[] cgpa1 = new double[linesCount / 6];
                using (StreamReader sr = new StreamReader(pathStudent))
                {
            for (int i = 0; i < linesCount / 6; i++)
            {
                    name1[i] = sr.ReadLine();
                    id1[i] = Convert.ToInt32(sr.ReadLine());
                    sem1[i] = Convert.ToInt32(sr.ReadLine());
                    cgpa1[i] = Convert.ToDouble(sr.ReadLine());
                    department1[i] = sr.ReadLine();
                    uni1[i] = sr.ReadLine();

                }
            }
            bool check = false;
            for (int i = 0; i < linesCount / 6; i++)
            {
                if (id1[i] == ID)
                {
                    id1[i] = 0;
                    check = true;
                }
            }
            if (check == false)
            {
                Console.WriteLine("FIle not foud\n");
            }
            else
            {
                File.WriteAllText(pathStudent, String.Empty);
                    using (StreamWriter sr = new StreamWriter(pathStudent))
                    {
                for (int i = 0; i < linesCount / 6; i++)
                {
                        if(id1[i]==0)
                        {

                        }
                        else
                        {
                           
                            sr.WriteLine(name1[i]);
                            sr.WriteLine(id1[i]);
                            sr.WriteLine(sem1[i]);
                            sr.WriteLine(cgpa1[i]);
                            sr.WriteLine(department1[i]);
                            sr.WriteLine(uni1[i]);
                        }

                    }
                }
            }
        }
        public void top_3()
        {
            var lineCount = File.ReadAllLines(pathStudent).Length;
            string[] id1 = new string[lineCount / 6];
            string[] name1 = new string[lineCount / 6];
            int[] semester1 = new int[lineCount / 6];
            string[] dept = new string[lineCount / 6];
            string[] university = new string[lineCount / 6];
            float[] cgpa = new float[lineCount / 6];

            using (StreamReader sw = new StreamReader(pathStudent))
            {
                for (int i = 0; i < lineCount / 6; i++)
                {
                    if (i == 0 || (lineCount % 6 == 0))
                    {
                        id1[i] = sw.ReadLine();
                        name1[i] = sw.ReadLine();
                        dept[i] = sw.ReadLine();
                        university[i] = sw.ReadLine();
                        semester1[i] = Convert.ToInt32(sw.ReadLine());
                        cgpa[i] = float.Parse(sw.ReadLine());

                    }
                }
            }



            for (int i = 0; i < lineCount / 6; i++)
            {

                for (int j = 0; j < lineCount/6; j++)
                {
                    if (cgpa[i] > cgpa[j])
                    {
                        float tem = 0;


                        tem = cgpa[i];
                        cgpa[i] = cgpa[j];
                        cgpa[j] = cgpa[i];

                        string temp;
                        temp = name1[i];
                        name1[i] = name1[j];
                        name1[j] = name1[i];

                        temp = dept[i];
                        dept[i] = dept[j];
                        dept[j] = dept[i];

                        temp = university[i];
                        university[i] = university[j];
                        university[j] = university[i];

                        temp = id1[i];
                        id1[i] = id1[j];
                        id1[j] = id1[i];


                        int temp1;
                        temp1 = semester1[i];
                        semester1[i] = semester1[j];
                        semester1[j] = semester1[i];



                    }
                }



                Console.WriteLine("Complete data of student is following\n\n");


                Console.WriteLine($"Stuent # {0}");
                Console.WriteLine($"ID :{id1[0]}");
                Console.WriteLine($"Name :{name1[0]}");
                Console.WriteLine($"Department :{dept[0]}");
                Console.WriteLine($"University :{university[0]}");
                Console.WriteLine($"Semester :{semester1[0]}");
                Console.WriteLine($"CGPA :{cgpa[0]}");


                Console.WriteLine($"Stuent #{1}");
                Console.WriteLine($"ID :{id1[1]}");
                Console.WriteLine($"Name :{name1[1]}");
                Console.WriteLine($"Department :{dept[1]}");
                Console.WriteLine($"University :{university[1]}");
                Console.WriteLine($"Semester :{semester1[1]}");
                Console.WriteLine($"CGPA :{cgpa[1]}");


                Console.WriteLine($"Stuent #{2}");
                Console.WriteLine($"ID :{id1[2]}");
                Console.WriteLine($"Name :{name1[2]}");
                Console.WriteLine($"Department :{dept[2]}");
                Console.WriteLine($"University :{university[2]}");
                Console.WriteLine($"Semester :{semester1[2]}");
                Console.WriteLine($"CGPA :{cgpa[2]}");

            }



        }
        public void markAttend()
        {
            var linesCount = File.ReadAllLines(pathStudent).Length;
            
            string[] name1 = new string[linesCount / 6];
            string[] department1 = new string[linesCount / 6];
            string[] uni1 = new string[linesCount / 6];
            int[] id1 = new int[linesCount / 6];
            int[] sem1 = new int[linesCount / 6];
            double[] cgpa1 = new double[linesCount / 6];
               using (StreamReader sr = new StreamReader(pathStudent))
            for (int i = 0; i < linesCount / 6; i++)

            {
                
                    if (i == 0 || (linesCount % 6 == 0))
                    {
                            name1[i] = sr.ReadLine();
                            id1[i] = Convert.ToInt32(sr.ReadLine());
                            sem1[i] = Convert.ToInt32(sr.ReadLine());
                            cgpa1[i] = Convert.ToDouble(sr.ReadLine());
                            department1[i] = sr.ReadLine();
                            uni1[i] = sr.ReadLine();

                        }
                
            }
            File.WriteAllText(pathAttend, String.Empty);
            Console.WriteLine("Enter Present/Absent for Student\n\n");
            string[] presence = new string[linesCount / 6];
            Console.WriteLine("Name\tAttendance");

            for (int i = 0; i < linesCount / 6; i++)
            {



                Console.WriteLine($"Name :{name1[i]}");
                presence[i] = Convert.ToString(Console.ReadLine());


                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@pathAttend, true))
                {
                    file.WriteLine($"{name1[i]}\t{presence[i]}");

                }

            }
            Console.WriteLine("Data Written Successfully for attendance\n");


        }
        public void viewAttend()
        {
            var lineCount = File.ReadAllLines(pathAttend).Length;
            string[] atend = new string[lineCount];


            using (StreamReader sw = new StreamReader(pathAttend))
            {
                for (int i = 0; i < lineCount; i++)
                {

                    atend[i] = sw.ReadLine();


                }
            }

            Console.WriteLine("Complete data of student is following\n\n");
            for (int i = 0; i < lineCount; i++)
            {


                Console.WriteLine($"Stuent #{i + 1}");
                Console.WriteLine($"{atend[i]}");


            }


        }


    }
   

}

