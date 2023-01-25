/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

int GetNumber(string message)
{
    int result = 0;

    while (true) {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 1) {
            break;
        }
        else {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return result;
}



int Exponentiation (int num, int deg)
{
    int exp = num;
    for (int i = 2; i <= deg; i++) {
        exp = exp * exp;
    }
    return exp;
}

int number = GetNumber("Введите число A больше 1");
int degree = GetNumber("Введите степень B больше 1");
int result = Exponentiation(number, degree);
Console.WriteLine($"Число {number} в степени {degree} равно {result}");