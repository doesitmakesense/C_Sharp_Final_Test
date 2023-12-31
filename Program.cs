﻿// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//  выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintNewArray(string[] collection)
{
    Console.Write("[");
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i].Length <= 3 & i != collection.Length - 1)
        {
            Console.Write(collection[i]);
            Console.Write(", ");
        }
        if (i == collection.Length - 1)
        {
            Console.Write(collection[i] + "]");
        }
    }
}

void PrintArray(string[] collection)
{
    Console.Write("[");
    for (int i = 0; i < collection.Length; i++)
    {
        if (i < collection.Length - 1)
        {
            Console.Write(collection[i]);
            Console.Write(", ");
        }
        else if (i == collection.Length - 1)
        {
            Console.Write(collection[i] + "]");
        }
    }
}

string[] array = new string[4] { "Hello", "2", "world", ":-)" };
PrintArray(array);
Console.Write("->");
PrintNewArray(array);