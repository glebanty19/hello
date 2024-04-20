using System;

class Program
{
    static void Main(string[] args)
    {
        // Введення радіусу та центрального кута у градусах
        Console.WriteLine("Введіть радіус кола:");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть центральний кут у градусах:");
        double centralAngle = Convert.ToDouble(Console.ReadLine());

        // Переведення кута в радіани
        double centralAngleRadians = centralAngle * Math.PI / 180;

        // Обчислення довжини дуги кола
        double arcLength = 2 * Math.PI * radius * (centralAngle / 360);

        // Виведення результату
        Console.WriteLine("Довжина дуги кола: " + arcLength);
    }
}
