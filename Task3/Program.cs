/*Задача 29: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

int [] CreatArray() {
    int [] Array = new int[8];
    Random rnd = new Random();              //выделяется адрес
    for (int i=0; i < Array.Length; i++) {
        Array[i] = rnd.Next();              //можно задать границы
    }
    return Array;
}

int [] mass = CreatArray();
Console.Write("[");
for (int i = 0; i<8;i++) {
    if (i != 7) Console.Write($"{mass[i]}, ");
    else        Console.Write($"{mass[i]}");
}
Console.Write("]");