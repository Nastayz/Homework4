/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

int longText = 0;

int GetNumber(string message) {
    int result = 0;

    while(true) {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result)) {
            break;
        }
        else {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return Math.Abs(result);
}


void GetLong(int GetNumber) {
    string GetText = GetNumber.ToString();
    longText = GetText.Length;
}


int SummInd (int number1) {
    int num = number1;
    int summ = 0;
    for (int i = 0; i < longText; i++) {
        summ = summ + num % 10;
        num  = num / 10;
    }
    return summ;
}

int number = GetNumber("Введите число");
GetLong(number);
Console.WriteLine(SummInd(number));