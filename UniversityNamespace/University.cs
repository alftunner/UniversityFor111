using System.Reflection;

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

    public void searchParams()
    {
        Type studentType = typeof(Student);
        PropertyInfo[] myPropertyInfo = studentType.GetProperties();
        Console.WriteLine("Сейчас будем осуществлять поиск студентов по разным признакам!");
        Console.WriteLine("Введите порядковый номер признака, по которому будет осуществляться поиск, нужно выбрать из списка: ");
        var i = 1;
        foreach (var prop in myPropertyInfo)
        {
            Console.WriteLine($"{i}. {prop.Name}");
            i++;
        }
        var propName = myPropertyInfo[Convert.ToInt32(Console.ReadLine()) - 1].Name;
        Console.WriteLine("Введите значение признака, например имя студента, или номер группы: ");
        var propValue = Console.ReadLine();
        Console.WriteLine("Результаты поиска: ");
        switch (propName)
        {
            case "StudentId" :
                var id = Convert.ToInt32(propValue);
                foreach (var student in this.StudentsList)
                {
                    if (student.StudentId == id)
                    {
                        UniversityConsoleManager.printStudentInfo(student);
                    }
                }
                break;
        }
        switch (propName)
        {
            case "Facultet" :
                foreach (var student in this.StudentsList)
                {
                    if (student.Facultet == propValue)
                    {
                        UniversityConsoleManager.printStudentInfo(student);
                    }
                }
                break;
        }
        
    }

    public void printInfo()
    {
        UniversityConsoleManager.printUniversityInfo(this);
    }
}