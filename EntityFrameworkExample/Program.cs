using EntityFrameworkExample;

using StudentContext dbContext = new StudentContext();

// Add with EF Core
Student s = new Student()
{
    FullName = "Aaron Kornish",
    EmailAddress = "slkldsjf@gmail.com",
    DateOfBirth = new DateTime(2000, 1, 1)
};
Student s2 = new Student()
{
    FullName = "Jim Halpert",
    EmailAddress = "JHalpert@gmail.com",
    DateOfBirth = new DateTime(2000, 1, 1)
};

dbContext.Students.Add(s); //Prepare the Student insert statement
dbContext.SaveChanges(); // Executes pending insert. (In actuallity: Execute any pending inserts)

dbContext.Students.Add(s2);
dbContext.SaveChanges();

// Retrieve Students from DB
List<Student> allStudents = dbContext.Students.ToList(); // Method syntax
// allStudents = (from stu in dbContext.Students
//               select stu).ToList(); // Query syntax

foreach (Student stu in allStudents)
{
    Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
    Console.WriteLine();
}
