//Creates a list of Class instances
List<Student> students = new List<Student>();

//Variables for the program
//Multiple loop booleans for entering or breaking the loop
bool loop1 = true;
bool loop2 = false;
bool loop3 = false;
int num = 0;
int count = 1;
string fName;
string lName;
string eMail;


//Main loop
while(loop1)
{
//Lists Club name and options for user input
    Console.WriteLine("Student Club Management");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Delete Student");
    Console.WriteLine("3. Edit Student");
    Console.WriteLine("4. List Student");
    Console.WriteLine("5. Exit");

//Reads input as a string and if it equals one of the options it converts it to an int
//If input does not equal an options it loops back and asks question again
    string answer = Console.ReadLine();
    if (answer == "1" || answer == "2" || answer == "3" || answer == "4" || answer == "5")
    {
        num = Convert.ToInt32(answer);
//Uses input in switch statement
        switch(num)
        {
//Case 1 adds person to the List
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
//Case 2 Deletes students
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
//Case 3 edits existing student
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
//Case 4 exits the program by breaking the loop
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
