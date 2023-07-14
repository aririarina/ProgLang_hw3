
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


void Task19()
{
    // Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    // 14212->нет
    // 12821->да
    // 23432->да

    int number = Input("введите пятизначное число: ");
    if(number > 9999 & number < 1000000)
    {
        int first_digit = number / 10000;
        int second_digit = (number - first_digit*10000) / 1000;
        int third_digit = (number - first_digit*10000 - second_digit*1000) / 100;
        int fourth_digit = (number - first_digit*10000 - second_digit*1000 - third_digit*100) / 10;
        int fifth_digit = number % 10;

        if(first_digit == fifth_digit && second_digit == fourth_digit)
        {
            Console.WriteLine($"число {number} является палиндромом");
        }
        else 
        {
            Console.WriteLine($"число {number} не является палиндромом");
        }

    }
    else Console.WriteLine("ошибка ввода");
    


}


void Task21()
{
    // Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    // A (3,6,8); B (2,1,-7), -> 15.84
    // A (7,-5, 0); B (1,-1,9) -> 11.53

    int x1 = Input("введите x первой точки: ");
    int y1 = Input("введите y первой точки: ");
    int z1 = Input("введите z первой точки: ");
    int x2 = Input("введите x второй точки: ");
    int y2 = Input("введите y второй точки: ");
    int z2 = Input("введите z второй точки: ");

    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    result = Math.Round(result, 2);

    Console.WriteLine($"расстоние между точками: {result}");
    
}

void Task23()
{
    // Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    // 3 -> 1, 8, 27
    // 5 -> 1, 8, 27, 64, 125

    int number = Input("введите число: ");
    for(int i = 1; i <= number ; i++ )
    {
         Console.WriteLine(Math.Pow(i, 3));
    }
}





