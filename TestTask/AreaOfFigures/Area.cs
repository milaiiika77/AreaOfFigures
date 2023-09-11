using System;

namespace AreaOfFigures
{
    public class Area
    {
        /// <summary>
        /// Вычисляет площадь круга по радиусу
        /// </summary>
        /// <param name="radius">значение радиуса</param>
        /// <returns>Площадь круга</returns>
        public static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        /// <summary>
        /// Вычисление площади треугольника по трём сторонам + проверка на прямоугольность
        /// </summary>
        /// <param name="a">Сторона треугольника a </param>
        /// <param name="b">Сторона треугольника b</param>
        /// <param name="c">Сторона треугольника c</param>
        /// <returns>Площадь треугольника + прямоугольный ли треугольник</returns>
        public static string TriangleArea(double a, double b, double c)
        {
            var arr = new[] { a, b, c };
            Array.Sort(arr);
            string check;
            if (!(a + b > c && a + c > b && b + c > a))
                return "Треугольник не существует";
            if (Math.Pow(arr[0], 2) + Math.Pow(arr[1], 2) == Math.Pow(arr[2], 2))
                check = "прямоугольный";
            else
                check = "не прямоугольный";
            var p = (a + b + c) / 2;
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return $"Ответ: {s}. Треугольник {check}";
        }
    }
}