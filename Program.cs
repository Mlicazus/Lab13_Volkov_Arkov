// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();
// void PrintHeader()
// {
//     Console.WriteLine("12.10.2026 10:36");
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("0_0");
// }
// void PrintFooter()
// {
//     Console.WriteLine(">_<");
//     Console.WriteLine("     Конец программы");
//     Console.WriteLine("Х_Х");
// }

// void PrintStudentCard(string name, int age, string number)
// {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы: {number}");
// }
// PrintStudentCard("Егор", 18, "252");
// PrintStudentCard("Валерия", 17, "241");

// double CalculateScholarship(double baseAmount, double bonusPercent)
// {
//     bool IsEligibleForBonus(double averageGrade)
//     {
//         return averageGrade >= 4.5;
//     }
//     double ball = 3;
//     if (IsEligibleForBonus(ball))
//     {
//         return (baseAmount + baseAmount * bonusPercent / 100) + ball;
//     } else
//     {
//         return baseAmount + baseAmount * bonusPercent / 100;
//     }
// }
// double result = CalculateScholarship(2000, 15);
// Console.WriteLine(result);

// double CalculateAverageGrade(int[] grades)
// {
//     int sum = 0;
//     foreach (int grade in grades)
//     {
//         sum += grade;
//     }
//     return (double)sum / grades.Length;
// }
// int CountFives(int[] grades)
// {
//     int count = 0;
//     foreach (int five in grades)
//     {
//         if (five == 5)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// int[] grades = { 4, 5, 3, 5, 4 };
// double average = CalculateAverageGrade(grades);
// double fives = CountFives(grades);
// Console.WriteLine(average);
// Console.WriteLine(fives);

// class Program {
//     static void Main() {
//         Console.WriteLine(Add(2, 3)); // вызовет первый вариант: int Add(int, int) → 5
//         Console.WriteLine(Add(2.5, 3.5)); // вызовет второй вариант: double Add(double, double) → 6.0
//         Console.WriteLine(Add(2, 3, 4)); // вызовет третий вариант: int Add(int, int, int) → 9
//     }
//     static int Add(int a, int b) {
//         return a + b;
//     }
//     static double Add(double a, double b) {
//         return a + b;
//     }
//     static int Add(int a, int b, int c) {
//         return a + b + c;
//     }
// }

// // Задача А
// void PrintDivider(string probel)
// {
//     Console.WriteLine(probel);
//     Console.WriteLine();
// }
// PrintDivider("Ярик");
// PrintDivider("Игорь");
// PrintDivider("Влад");
// PrintDivider("Святослав");

// // Задача Б
// void PrintPerson(string name, int age)
// {
//     Console.WriteLine($"Человек: {name}, возраст: {age}");
// }
// PrintPerson("Игорь", 24);
// PrintPerson("Алиса", 52);

// Задача В
// bool IsEven(int number)
// {
//     if (number % 2 == 0)
//     {
//         return true;
//     }
//     else {
//         return false;
//     }
// }
// Console.WriteLine(IsEven(11));

// // Задача Г
// int FindMax(int[] numbers)

// {
//     int max = 0;
//     foreach (int elem in numbers)
//     {
//         if (elem > max)
//         {
//             max = elem;
//         }
//     }
//     return max;
// }
// int[] grades = { 4, 5, 3, 9, 7 };
// Console.WriteLine($"Максимально число {FindMax(grades)}");
