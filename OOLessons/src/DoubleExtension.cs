using System;

namespace OOLessons.test
{
    public static class DoubleExtension
    {
         public static bool Equal(this double number, double other)
         {
             return Math.Abs(number - other) < 0.1E-10;
         }
    }
}