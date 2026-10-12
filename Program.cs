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

// int[] points = {10, 20, 15};

// for (int i = 0; i < points.Length; i++)
// {
//     points[i] = points[i] + 5;
// }

// foreach (int point in points)
// {
//     Console.WriteLine(point);
// }







// Шаг 5

// string[] students = {"Аня", "Борис", "Вика"};
// int number = 1;

// foreach (string student in students)
// {
//     Console.WriteLine($"{number}. {student}");
//     number++;
// }






// Самотоятельные задания

// Задача А

// int[] numbers = {1, 2, 3, 4, 5};
// int n = 0;

// foreach (int number in numbers)
// {
//     Console.WriteLine(number);
//     n += number;
// }
// Console.WriteLine($"Сумма всех элементов: {n}");






// Задача Б

// string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

// foreach (string day in days)
// {
//     Console.WriteLine($"{day}!");
// }





Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname)) {
Console.WriteLine("Фамилия не введена. Завершение работы.");
return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");