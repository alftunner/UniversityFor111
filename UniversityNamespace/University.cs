namespace UniversityNamespace;

public class University
{
    public static string[] facultets = {"Физический", "Математический", "Экономический"};
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Student> StudentsList { get; set; }

    public University()
    {
        UniversityConsoleManager.UniversityInit(this);
        StudentsList = new List<Student>();
    }

    public void addStudent()
    {
        StudentsList.Add(UniversityConsoleManager.addStudent(this));
    }

    public void printInfo()
    {
        UniversityConsoleManager.printUniversityInfo(this);
    }
}