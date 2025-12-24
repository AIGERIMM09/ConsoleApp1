using System;
    
    Random random = new Random();
bool playAgain = true;
while (playAgain)
{
    int secretNum = random.Next(1, 101);

    Console.WriteLine("--- игра: Угадай число от 1 до 100 ---");
    // и так далее...
    int userGuess = 0;
    int count = 0;
    int maxAttempts = 10; //
    do
    {
        Console.ResetColor(); // Сбрасываем цвет в начале каждого круга
        Console.WriteLine($"\nУ тебя осталось попыток: {maxAttempts - count}");
        // 2. Спрашиваем ответ у игрока
        Console.Write("Введи свой вариант: ");
        userGuess =
            Convert.ToInt32(Console.ReadLine());
        count++;

        // 3. Сравниваем числа с подсказками
        if (userGuess == secretNum)
        {
            Console.ForegroundColor =
            ConsoleColor.Yellow; // Сделает текст золотым

            Console.WriteLine($"УРА! Ты БОЛЬШАЯ молодец, угадала за {count} попыток! Это было число {secretNum}");
            break;
        }
        else if (userGuess < secretNum)
        {
            Console.ForegroundColor =
            ConsoleColor.Cyan; // Голубой цвет      
            Console.WriteLine($"К сожелению не угадала...Моё число БОЛЬШЕ, чем {userGuess}");
        }
        else
        {
            Console.ForegroundColor =
            ConsoleColor.Red; // Красный цвет
            Console.WriteLine($"Жаль... Ты не угадала... Моё число МЕНЬШЕ, чем {userGuess}");
        }
        if (count >= maxAttempts && userGuess != secretNum)
        {
            Console.ForegroundColor =
                ConsoleColor.Magenta; // Фиолетовый цвет
            Console.WriteLine($"\nПОПЫТКИ ЗАКОНЧИЛИСЬ! ТЫ ПРОИГРАЛА...Жаль! На самом деле я загадала число {secretNum}");
        }
    } while (userGuess != secretNum);

    Console.ResetColor();
    Console.Write("\nХочешь сыграть еще раз? (д/н): ");
    string? answer =
    Console.ReadLine()?.ToLower();

    if (answer == "д") //Проверяем ответ "д"
    {
        count = 0;    // Сбрасываем счетчик новой для новой игры
        Console.Clear(); // Очищаем  экран
    }
    else
    { 
        playAgain = false; // Останавливаем цикл, если Не нажали "д"
        Console.WriteLine("Спасибо за игру!");
    }
   } //

Console.WriteLine("\nНажми любую клавишу, чтобы выйти...");
    Console.ReadKey();






    






