using System;

namespace LABVar2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString = "";
            do
            {
                //Приглашение пользователю
                Console.Write("Введите 1 если это расчет площади правильного многоугольника или 2 для расчета суммы положительных чисел: ");


                /*
                * Получение веденной с клавиатуры строки,
                * введенная строка сохраняется в переменную userString
                */
                userString = Console.ReadLine();

                if (userString == "1") regularPolygonAreaCounter();
                if (userString == "2") numberCounter();

                Console.Write("Введите 'выход' для выхода из программы\n");
            } while (userString != "выход");

        }
        public static void regularPolygonAreaCounter()
        {
            Console.WriteLine($"Длина стороны: ");
            Double sidesLong = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Количество сторон: ");
            int sidesNumber = Convert.ToInt32(Console.ReadLine());
            Double regularPolygonArea = sidesNumber * Math.Pow(sidesLong, 2) / (4 * Math.Tan(Math.PI / sidesNumber));
            Console.WriteLine($"Длина стороны: {sidesLong}  Количество сторон: {sidesNumber}");
            Console.WriteLine($"Площадь многоугольника: {regularPolygonArea}");
        }

        public static void numberCounter()
        {
            Console.WriteLine($"Число: ");
            int sidesLong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ответ");
            int answer = (sidesLong * (sidesLong + 1)) / 2;
            Console.WriteLine($"Сумма положительных чисел: {answer}");
        }

    }
}
