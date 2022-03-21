namespace UniversityNamespace;

public class UniversityConsoleManager
{
    public static void UniversityInit(University university)
    {
        Console.Write("Введите название университета: ");
        university.Name = Console.ReadLine();
        Console.Write("Введите адрес университета: ");
        university.Address = Console.ReadLine();
    }
    public static void studentInit(Student student)
    {
        Console.Write("введите ФИО студента: ");
        student.Fio = Console.ReadLine();
        Console.Write("введите дату рождения студента dd.mm.yyyy: ");
        student.Birthday = Convert.ToDateTime(Console.ReadLine());
        student.Facultet = University.facultets[chooseFacultet()];
    }

    public static int chooseFacultet()
    {
        Console.WriteLine("Выберите один из факультетов, введя его порядковый номер:");
        int index = 1;
        foreach (var facultet in University.facultets)
        {
            Console.WriteLine($"{index}. {facultet}");
            index++;
        }

        return Convert.ToInt32(Console.ReadLine()) - 1;
    }

    public static Student addStudent(University university)
    {
        Student student = new Student();
        Console.Write("Введите курс студента: ");
        student.Term = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите группу студента: ");
        student.Group = Console.ReadLine();
        return student;
    }

    public static void printUniversityInfo(University university)
    {
        Console.WriteLine($"Название: {university.Name}");
        Console.WriteLine($"Адрес: {university.Address}");
        Console.WriteLine("Студенты: ");
        foreach (var student in university.StudentsList)
        {
            Console.WriteLine("---------------");
            Console.WriteLine($"ID: {student.StudentId}");
            Console.WriteLine($"Фио: {student.Fio}");
            Console.WriteLine($"Факультет: {student.Facultet}");
            Console.WriteLine($"Группа: {student.Group}");
        }
    }
    
}