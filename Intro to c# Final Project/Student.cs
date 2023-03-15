//Creates the Student class
public class Student
{
//Making variables for students name and email to be set and retrieved outside of the class
    string FirstName {get; set;}
    string LastName {get; set;}
    string Email {get; set;}

//Method to and information for a new student
    public Student(string firstname, string lastname, string email)
    {
        FirstName = firstname;
        LastName = lastname;
        Email = email;
    }

// override ToString() method to allow for customized string to be returned
    public override string ToString()
    {
        return $"{FirstName} {LastName} | {Email}";
    }

}