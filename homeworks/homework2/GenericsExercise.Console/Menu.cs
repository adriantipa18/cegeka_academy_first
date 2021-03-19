using GenericsExercise.Console.Given.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExercise.Console
{
    class Menu
    {
        private ApplicationService<Student> studService = new ApplicationService<Student>();
        private ApplicationService<University> uniService = new ApplicationService<University>();

        public void mainMenu()
        {
            System.Console.WriteLine("Welcome!\n" + "In order to see students/university write command: getAllStudents/getAllUniversities!\n" + "In order to add a new student/university write command: addStudent/addUniversity");
            System.Console.Write("command = ");
            string input = System.Console.ReadLine();
            while (!input.Equals("exit"))
            {
                if (input.ToLower().Equals("getallstudents"))
                {
                    System.Console.WriteLine(studService.getUsers());
                }
                else
                {
                    if (input.ToLower().Equals("getalluniversities"))
                    {
                        System.Console.WriteLine(uniService.getUsers());
                    }
                    else
                    {
                        if (input.ToLower().Equals("addstudent"))
                        {
                            string id, firstName, lastName;
                            System.Console.Write("id = ");
                            id = System.Console.ReadLine();
                            System.Console.Write("firstName = ");
                            firstName = System.Console.ReadLine();
                            System.Console.Write("lastName = ");
                            lastName = System.Console.ReadLine();
                            Student tempStudent = new Student() { Id = id, FisrtName = firstName, LastName = lastName};

                            System.Console.WriteLine(studService.insertUser(tempStudent));
                        }
                        else
                        {
                            if (input.ToLower().Equals("adduniversity"))
                            {
                                string id, adress, name;
                                System.Console.Write("id = ");
                                id = System.Console.ReadLine();
                                System.Console.Write("adress = ");
                                adress = System.Console.ReadLine();
                                System.Console.Write("name = ");
                                name = System.Console.ReadLine();
                                University tempUniversity = new University() { Id = id, Address = adress, Name = name };

                                System.Console.WriteLine(uniService.insertUser(tempUniversity));
                            }
                            else
                            {
                                System.Console.WriteLine("Invalid command!");
                            }
                        }
                    }
                }
                System.Console.Write("command = ");
                input = System.Console.ReadLine();
            }
        }
    }
}
