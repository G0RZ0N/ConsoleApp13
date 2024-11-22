using ConsoleApp13;
//Екатерина Николаевна, у меня была проблема с отправками файлами на githab и я скинул через ноут Помелова.
Student student = new Student("Арсений Квятковский", Education.Bachelor, 291);
Console.WriteLine(student.ToShortString());


Console.WriteLine($"Specialist: {student.IsEducationEqual(Education.Specialist)}");
Console.WriteLine($"Bachelor: {student.IsEducationEqual(Education.Bachelor)}");
Console.WriteLine($"SecondEducation: {student.IsEducationEqual(Education.SecondEducation)}");

student.Person = "Казунко Владислав";
student.Group = 291;
student.Education = Education.SecondEducation;
Console.WriteLine(student.ToString());

student.AddExams(new Exam("Афроамериканский Язык", 90, DateTime.Now), new Exam("Нигерийский язык", 121, DateTime.Now.AddDays(-255)));
Console.WriteLine(student.ToString());


const int size = 100000;
Exam[] mass1 = new Exam[size];
Exam[,] mass2 = new Exam[size, 1];
Exam[][] mass3 = new Exam[size][];
for (int i = 0; i < size; i++)
{
    mass1[i] = new Exam("Лепеш", 291, DateTime.Now);
    mass2[i, 0] = new Exam("Лепеш", 291, DateTime.Now);
    mass3[i] = new Exam[] { new Exam("Лепеш", 291, DateTime.Now) };
}

DateTime startTime = DateTime.Now;
for (int i = 0; i < size; i++)
{
    var temp = mass1[i];
}
DateTime endTime = DateTime.Now;
Console.WriteLine($"Одномерный массив: {(endTime - startTime).TotalMilliseconds} мс");

startTime = DateTime.Now;
for (int i = 0; i < size; i++)
{
    var temp = mass2[i, 0];
}
endTime = DateTime.Now;
Console.WriteLine($"Двухмерный Прямоугольный массив: {(endTime - startTime).TotalMilliseconds} мс");

startTime = DateTime.Now;
for (int i = 0; i < size; i++)
{
    var temp = mass3[i][0];
}
endTime = DateTime.Now;
Console.WriteLine($"Ступенчатый массив: {(endTime - startTime).TotalMilliseconds} мс");
enum Education
{
    Specialist,
    SecondEducation,
    Bachelor
}
