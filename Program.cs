// Шаг 1

// string subject = "Программирование";

// foreach (char letter in subject) {
//     Console.WriteLine(letter);
// }   
// Console.WriteLine($"Общее колличество букв: {subject.Length}");






// Шаг 2

// int[] grades = {4, 5, 3, 5, 4};
// double n = 0;

// foreach (int grade in grades)
// {
//     n += grade;
//     Console.WriteLine(grade);
// }
// double average = n / grades.Length;
// Console.WriteLine($"Средний балл: {average}");







// Шаг 3

// string[] students = {"Аня", "Ярослав", "Вика"};
// int n = 0;

// foreach (string student in students)
// {
//     Console.WriteLine(student);
//     n++;
// }
// Console.WriteLine($"Всего учеников: {n}");










// Шаг 4

int[] points = {10, 20, 15};

for (int i = 0; i < points.Length; i++)
{
    points[i] = points[i] + 5;
}

foreach (int point in points)
{
    Console.WriteLine(point);
}