public class Student
{
    string FirstName {get; set;}
    string LastName {get; set;}
    string Email {get; set;}

    public Student(string firstname, string lastname, string email)
    {
        FirstName = firstname;
        LastName = lastname;
        Email = email;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} | {Email}";
    }

}