List<Student> students = new List<Student>();

bool loop1 = true;
bool loop2 = false;
bool loop3 = false;
int num = 0;
int count = 1;
string fName;
string lName;
string eMail;



while(loop1)
{
    Console.WriteLine("Student Club Management");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Delete Student");
    Console.WriteLine("3. Edit Student");
    Console.WriteLine("4. List Student");
    Console.WriteLine("5. Exit");

    string answer = Console.ReadLine();
    if (answer == "1" || answer == "2" || answer == "3" || answer == "4" || answer == "5")
    {
        num = Convert.ToInt32(answer);

        switch(num)
        {
            case 1:
            {
                Console.WriteLine("Enter First Name: ");
                fName = Console.ReadLine();
                Console.WriteLine("Enter Last Name: ");
                lName = Console.ReadLine();
                Console.WriteLine("Enter Email Address: ");
                eMail = Console.ReadLine();
                students.Add(new Student(fName, lName, eMail));
                Console.WriteLine("Student Added Successfully\n");
                break;
            }
            case 2:
            {
                
                loop2 = true;
                            
                while (loop2)
                {
                    count = 1;
                    foreach(Student s in students)
                        { 
                            Console.WriteLine(count + ". " + s);
                            count++;
                        }
                    Console.WriteLine("Enter a Student to Delete: ");
                    int pick = Convert.ToInt32(Console.ReadLine());
                    if (pick >= 0 && pick <= students.Count)
                        {
                            students.RemoveAt(pick - 1);
                            
                            loop2 = false;
                        }
                    else
                        {
                            Console.WriteLine("That is not an answer");
                        }
                }
                        
                break;Console.WriteLine("Student Deleted Successfully\n");
            }
            case 3:
            {
                loop3 = true;
                            
                while (loop3)
                {
                    count = 1;
                    foreach(Student s in students)
                        { 
                            Console.WriteLine(count + ". " + s);
                            count++;
                        }
                    Console.WriteLine("Enter a # to edit");
                    int pick = Convert.ToInt32(Console.ReadLine());
                    if (pick >= 0 && pick <= students.Count)
                        {
                            students.RemoveAt(pick - 1);
                            Console.WriteLine("Enter First Name: ");
                            fName = Console.ReadLine();
                            Console.WriteLine("Enter Last Name: ");
                            lName = Console.ReadLine();
                            Console.WriteLine("Enter Email Address: ");
                            eMail = Console.ReadLine();
                            students.Insert(pick - 1, new Student(fName, lName, eMail));
                            Console.WriteLine("Student Editted Successfully\n");
                            loop3 = false;
                        }
                    else
                        {
                            Console.WriteLine("That is not an answer");
                        }
                }
                break;
            }
            case 4:
            {
                foreach(Student s in students)
                    {
                        Console.WriteLine(s);
                    }
                Console.WriteLine("\n");
                break;
            }
            case 5:
            {
                Console.WriteLine("\nExiting the Programm...\n");
                loop1 = false;
                break;
            }
        }
    }
    else   
    {
        Console.WriteLine("That is not an option, please choose again.");
    }

    
}
