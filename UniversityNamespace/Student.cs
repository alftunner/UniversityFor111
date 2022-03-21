namespace UniversityNamespace;

public class Student
{
    private static int id = 0;
    public int StudentId { get; set; }
    public string Fio { get; set; }
    public DateTime Birthday { get; set; }
    public string Facultet { get; set; }
    public string Group { get; set; }
    public int Term { get; set; }

    public Student()
    {
        id++;
        this.StudentId = id;
        UniversityConsoleManager.studentInit(this);
    }
}