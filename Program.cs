
    using System;


    Console.WriteLine("--- Мини-калькулятор возраста ---");

Console.Write("Как тебя зовут? ");
string name = Console.ReadLine();

Console.Write("В каком году вы родились? ");
int birthYear =
Convert.ToInt32(Console.ReadLine());

int currentYear = DateTime.Now.Year;
int age = currentYear - birthYear;

Console.WriteLine($"{name}, тебе примерно {age} лет!");
if (age < 18)
{
    Console.WriteLine("Ого, ты еще совсем молодая оказываеться, отлично мне посебедовать с молодым разработчиком, всё впереди! У тебя отлично получаеться!");
}
else
{
    Console.WriteLine("Ты уже взрослый и самостоятельный человек! Здорово! Рад познокомиться!Хорошего дня!");
}    
Console.ReadKey();






