//Напишите библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по 
//радиусу и треугольника по трем сторонам.Дополнительно к работоспособности оценим:
//Юнит-тесты
//Легкость добавления других фигур
//Вычисление площади фигуры без знания типа фигуры
//Проверку на то, является ли треугольник прямоугольным

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllForClient
{
    public static class DllForClient
    {
        public static double SquareTriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        }
        public static double SquareCircle(double r)
        {
           return Math.PI * Math.Pow(r, 2);
        }

    }
}
