using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    static class TempConverter
    {
        public static double FarenheitToCelsius(double f){
            return (f - 32) * 5.0 / 9.0;
}
        public static double CelsiusToFarenheit(double c) {
            return (c * 9.0 / 5.0) + 32;
        }
    }
}
