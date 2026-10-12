// Шаг 1

// string subject = "Программирование";

// foreach (char letter in subject) {
//     Console.WriteLine(letter);
// }   
// Console.WriteLine($"Общее колличество букв: {subject.Length}");






// Шаг 2

int[] grades = {4, 5, 3, 5, 4};
double n = 0;

foreach (int grade in grades)
{
    n += grade;
    Console.WriteLine(grade);
}
double average = n / grades.Length;
Console.WriteLine($"Средний балл: {average}");