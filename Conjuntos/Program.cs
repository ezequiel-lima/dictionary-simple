Dictionary<int, int> listStudents = new Dictionary<int, int>();

Console.Write("Fow many students for course A? ");
int numberStudents = int.Parse(Console.ReadLine());
CountRegisteredStudents(numberStudents);

Console.Write("Fow many students for course B? ");
numberStudents = int.Parse(Console.ReadLine());
CountRegisteredStudents(numberStudents);

Console.Write("Fow many students for course C? ");
numberStudents = int.Parse(Console.ReadLine());
CountRegisteredStudents(numberStudents);

Console.WriteLine($"Total students: {listStudents.Count}");

void CountRegisteredStudents(int numberStudents)
{
    while (numberStudents > 0)
    {
        int idStudent = int.Parse(Console.ReadLine());

        if (!listStudents.ContainsKey(idStudent))
        {
            listStudents.Add(idStudent, 1);
        }
        else
        {
            listStudents[idStudent]++;
        }

        numberStudents--;
    }
}