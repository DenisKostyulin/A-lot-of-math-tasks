using System;
using System.Globalization;
using System.Numerics;

namespace COMPLEX123
{
    class Cmplex
    {
        static void Main(string[] args)
        {
            #region Поля
            Console.WriteLine("ImaginaryOne");
            Complex value = Complex.ImaginaryOne;//ImaginaryOne
            Console.WriteLine(value.ToString());
            Complex value1 = new Complex(0, 1);
            Console.WriteLine(value.Equals(value1));
            Console.WriteLine("One");
            Complex value2 = Complex.One;//One
            Console.WriteLine(value2.ToString());
            Complex value3 = new Complex(1, 0);
            Console.WriteLine(value2.Equals(value3));
            Console.WriteLine("Zero");
            Complex value4 = Complex.Zero;//Zero
            Console.WriteLine(value4.ToString());
            Complex value5 = new Complex(0, 0);
            Console.WriteLine(value4.Equals(value5));
            #endregion
            #region Свойства
            Random rnd= new Random();      //задаю два произвольных комплексных числа    
            double a1 =rnd.Next(-100, 100);
            double b1 = rnd.Next(-100, 100);
            double a2 = rnd.Next(-100, 100);
            double b2 = rnd.Next(-100, 100);
            Complex c2 = new Complex(a2, b2);
            Complex c1 = new Complex(a1,b1);//Imagionary, Real
                if (c1.Real == 0)//ставлю условие на вывод 
                { Console.WriteLine("{0}i", c1.Imaginary); }
                if (c1.Imaginary == 0)
                { Console.WriteLine("{0}", c1.Real); }
                if (c1.Imaginary < 0)
                { Console.WriteLine("{0}{1}i", c1.Real, c1.Imaginary); }
                else
                { Console.WriteLine("{0} + {1}i", c1.Real, c1.Imaginary); }
            Console.WriteLine("Magnitude: |{0}|={1}", c1.ToString(),c1.Magnitude);//Magnitude
            Console.WriteLine("Phase: {0}={1}", c1.ToString(), c1.Phase);//Phase
            #endregion
            #region Методы
            double x = 5;
            Console.WriteLine("Abs: |{0}| = {1}", c1, Complex.Abs(c1));//модуль 

            Console.WriteLine("Acos: ACos{0} = {1}", c1.ToString(),Complex.Cos(Complex.Acos(c1)));//арккосинус

            Console.WriteLine("Asin: ASin{0} = {1}", c1.ToString(), Complex.Sin(Complex.Asin(c1)));//арксинус

            Console.WriteLine("Add(complex,complex): {0} + {1} = {2}", c1, c2, Complex.Add(c1, c2));//сумма
            Console.WriteLine("Add(complex,double): {0} + {1} = {2}", c1, x, Complex.Add(c1, x));

            Console.WriteLine("Atan: Atan({0}) = {1}",c1, Complex.Tan(Complex.Atan(c1)));//арктангенс

            Console.WriteLine("Conjugate: {0}",Complex.Conjugate(c1).ToString());//комплексно-сопряженное

            Console.WriteLine("Cos: Cos(ACos({0})) = {1}",c1,Complex.Cos(Complex.Acos(c1)));//косинус

            Console.WriteLine("Sin: Sin(ASin({0})) = {1}", c1, Complex.Sin(Complex.Asin(c1)));//синус

            Console.WriteLine("Cosh: Cosh{0}) = {1}", c1, Complex.Cosh(c1));//гип косинус

            Console.WriteLine("Sinh: Sinh{0}) = {1}", c1, Complex.Sinh(c1));//гип синус

            Console.WriteLine("Divide(complex,complex): {0} / {1} = {2:N2}", c1, c2,Complex.Divide(c1, c2));///деление
            Console.WriteLine("Divide(complex,double): {0} / {1} = {2:N2}", c1, x, Complex.Divide(c1, x));
            Console.WriteLine("Divide(double,complex): {0} / {1} = {2:N2}", x, c2, Complex.Divide(x, c2));

            Console.WriteLine("Equals",c1.Equals(x));//сравнение
            Console.WriteLine("Equals",c2.Equals(x));

            Console.WriteLine("Exp: Exp(Log({0}) = {1}", c1,Complex.Exp(Complex.Log(c1)));//эксопоненета

            Complex c3 = Complex.FromPolarCoordinates(10, 60 * Math.PI / 180);//комплекс из координат
            Console.WriteLine("FromPolarCoordinates: {0}:", c3);
            Console.WriteLine("Magnitude: {0}", Complex.Abs(c3));
            Console.WriteLine("Phase:     {0} radians", c3.Phase);
            Console.WriteLine("Phase      {0} degrees", c3.Phase * 180 / Math.PI);
            Console.WriteLine("Atan(b/a): {0}", Math.Atan(c3.Imaginary / c3.Real));

            Console.WriteLine("Hash Code {0}:  {1}", c1,c1.GetHashCode());//Хеш-код

            Console.WriteLine("IsFinite: {0} is finite? -  {1}", c1, c1);//принадлежность к множествам
            Console.WriteLine("IsInfinity: {0} is infinite? -  {1}", c1,c1);
            Console.WriteLine("IsNaN: {0} is NaN? -  {1}", c1, c1 == Double.NaN);

            Console.WriteLine("Log({0}) = {1}", c2,Complex.Exp(Complex.Log(c2)));//логарифмы
            Console.WriteLine("Log x({0}) = {1}", c2, Complex.Exp(Complex.Log(c2,x)));
            Console.WriteLine("Log 10({0}) = {1}", c2, Complex.Exp(Complex.Log10(c2)));

            Console.WriteLine("Multiply(complex,complex): {0} x {1} = {2}", c1, c2, Complex.Multiply(c1, c2));// умножение
            Console.WriteLine("Multiply(complex,double): {0} x {1} = {2}", c1, x, Complex.Multiply(c1, x));
            Console.WriteLine("Multiply(double,complex): {0} x {1} = {2}", x, c2, Complex.Multiply(x, c2));

            Console.WriteLine("Negate: {0} --> {1}", c1, Complex.Negate(c1));//аддитивная инверсия
            Console.WriteLine("{0} --> {1}", c2, Complex.Negate(c2));

            Console.WriteLine("Pow(complex,complex): {0} ^ {1} = {2}", c1,c2,Complex.Pow(c1,c2 ));//возведение в степень
            Console.WriteLine("Pow(complex,double){0} ^ {1} = {2}", c1, x, Complex.Pow(c1, x));

            Complex r1 = Complex.Reciprocal(c1);//обратное комлексное
            Console.WriteLine("Reciprocal check: {0:N0} x {1:N2} = {2:N2}",c1, r1, c1 * r1);

            Console.WriteLine("Sqrt: {0}^0,5= {1}",c1,Complex.FromPolarCoordinates(Math.Sqrt(c1.Magnitude), c1.Phase / 2));//корень квадратный

            Console.WriteLine("Subtract: {0} - {1} = {2}", c1, c2,Complex.Subtract(c1, c2));//вычитание
            Console.WriteLine("{0} - {1} = {2}", c1, x, Complex.Subtract(c1, x));
            Console.WriteLine("{0} - {1} = {2}", x, c2, Complex.Subtract(x, c2));

            Console.WriteLine("Tan: Tan(Atan({0})) = {1}",c1, Complex.Tan(Complex.Atan(c1)));//тангенс

            Console.WriteLine("Tath: Tanh(0)) = {1}",c1, Complex.Sin(Complex.Asin(c1))/ Complex.Cos(Complex.Acos(c1)));//гип тангенс

                CultureInfo culture = new CultureInfo("en-US");//преобразование строки
            Console.WriteLine("ToString(): {0}= {1}",c1,c1.ToString());
            Console.WriteLine("ToString(IFormatProvider): {0}= {1}",c1,c1.ToString("F2"));
            Console.WriteLine("ToString(String): {0}= {1}({2})",c1,c1.ToString(culture),culture.Name);
            Console.WriteLine("ToString(String,IFormatProvider): {0}= {1}({2})",c1,c1.ToString("F5",culture),culture.Name);
            #endregion
            #region Операторы
            Console.WriteLine("Addition(complex,complex): {0} + {1} = {2}", c1, c2, c1 + c2);//сложение
            Console.WriteLine("Addition(double,complex): {0} + {1} = {2}", x, c2, x + c2);
            Console.WriteLine("Addition(complex, double): {0} + {1} = {2}", c1, x, c1 + x);

            Console.WriteLine("Division(complex,complex): {0} / {1} = {2}", c1, c2, c1 / c2);//деление
            Console.WriteLine("Division(double,complex): {0} / {1} = {2}", x, c2, x / c2);
            Console.WriteLine("Division(complex, double): {0} / {1} = {2}", c1, x, c1 / x);

            Console.WriteLine("Equality: {0} == {1} => {2}", c1, c2,c1==c2);//равенство

            decimal number = 17.7m;//явное преобразование
            Complex c4 = (Complex)number;
            Console.WriteLine("Explicit(decimal to complex): {0,30}-->{1}", number, c4);

            ulong longValue = 432546789;//неявное преобраование
            Complex c5 =longValue;
            Console.WriteLine("Implicit(ulong to complex):{0,30}-->{1} ",longValue, c5);

            Console.WriteLine("Inequality: {0} != {1} => {2}", c1, c2, c1 != c2);//неравенство

            Console.WriteLine("Multiply(complex,complex): {0} * {1} = {2}", c1, c2, c1 * c2);//умножение
            Console.WriteLine("Multiply(complex,double): {0} * {1} = {2}", c1, x, c1 * x);
            Console.WriteLine("Multiply(double,complex): {0} * {1} = {2}", x, c2, x * c2);

            Console.WriteLine("Subtraction(complex,complex): {0} - {1} = {2}", c1, c2, c1 - c2);//вычитание
            Console.WriteLine("Subtraction(double,complex): {0} - {1} = {2}", x, c2, x - c2);
            Console.WriteLine("Subtraction(complex, double): {0} - {1} = {2}", c1, x, c1 - x);

            Complex c6 = -c1;
            Console.WriteLine("UnaryNegation: ",c6);//аддитивная инверсия
            #endregion
            Console.ReadLine();
        }
    }
}
