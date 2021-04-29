using System;
namespace HomeWork2
{
    class task1
    //Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
    {
        [Flags]
        public enum day
        { 
            monday = 0b_1000000,
            tuesday = 0b_0100000,
            wednesday = 0b_0010000,
            thursday = 0b_0001000,
            friday = 0b_0000100,
            suturday = 0b_0000010,
            sunday = 0b_0000001,

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача1");
            Console.WriteLine("Введите минимальную температуру за сутки");
            var tempMin = Console.ReadLine();
            double min = Convert.ToDouble(tempMin);
            Console.WriteLine("Введите максимальную температуру за сутки");
            var tempMax = Console.ReadLine();
            double max = Convert.ToDouble(tempMax);
            var tempAvg = (max + min) / 2;
            Math.Round(tempAvg);
            Console.WriteLine($"Средняя температура за сутки:{tempAvg}");


            {//Запросить у пользователя порядковый номер текущего месяца и вывести его название
                Console.WriteLine("Задача2");
                Console.WriteLine("Введите порядковый номер текущего месяца");
                var infoIn = Console.ReadLine();
                int monthNumb = Convert.ToInt32(infoIn);
                string month = "";
                switch (monthNumb)
                {
                    case 1:
                        month = "Январь";
                        if (tempAvg > 0)
                        {
                            Console.WriteLine("Дождливая зима");
                        }
                        break;
                    case 2:
                        month = "Феварль";
                        if (tempAvg > 0)
                        {
                            Console.WriteLine("Дождливая зима");
                        }
                        break;
                    case 3:
                        month = "Март";
                        break;
                    case 4:
                        month = "Апрель";
                        break;
                    case 5:
                        month = "Май";
                        break;
                    case 6:
                        month = "Июнь";
                        break;
                    case 7:
                        month = "Июль";
                        break;
                    case 8:
                        month = "Август";
                        break;
                    case 9:
                        month = "Сентябрь";
                        break;
                    case 10:
                        month = "Октябрь";
                        break;
                    case 11:
                        month = "Ноябрь";
                        break;
                    case 12:
                        month = "Декабрь";
                        if (tempAvg > 0)
                        {
                            Console.WriteLine("Дождливая зима");
                        }
                        break;
                    default:
                        Console.WriteLine("Укажите значение от 1 до 12(всего 12 месяцев существует..)");
                        break;
                }
                Console.WriteLine(month);
            }
            Console.WriteLine("Задача 3");//Определить, является ли введённое пользователем число чётным.
            Console.WriteLine("Введите число");
            string checkNum = Console.ReadLine();
            int numToCheck = Convert.ToInt32(checkNum);
            if (numToCheck % 2 == 0)
            {
                Console.WriteLine($"Число {checkNum} является четным");
            }
            else
            {
                Console.WriteLine($"Число {checkNum} является нечетным");
            }


            Console.WriteLine("Задача 4");
            Console.WriteLine("Введите название магазина ");
            DateTime thisDay = DateTime.Now;
            string shop = Console.ReadLine();

            Console.WriteLine("Введите цену на сыр");
            var a=  Console.ReadLine();
            int d = Convert.ToInt32(a);
            Console.WriteLine("Введите цену на пироженое");
            var b = Console.ReadLine();
            int e = Convert.ToInt32(b);
            Console.WriteLine("Введите цену на молоко");
            var c = Console.ReadLine();
            int f = Convert.ToInt32(c);
            var sum = d + e + f;
            Console.WriteLine($"{shop} \n ООО Городской супермаркет\n 119192,г. Москва\n КАССОВЫЙ ЧЕК №12312\n 1.Cыр*1 {a}\n 2.Пироженое*1 {b}\n" +
                $"3.Молоко*1 {c}\n Cумма покупок:{sum}\n {thisDay}");//Задание отвратительное(неприятное)

            day office1 = (day)0b0111100;
            day office2 = (day)0b1111111;
            day office3 = (day)0b1010101;
            day office4 = (day)0b0101010;
            day office5 = (day)0b1110000;
           
            Console.WriteLine("Есть 5 офисов,введите номер офиса,чтобы узнать его расписание.");
            var n = Console.ReadLine();
            int officeNumber = Convert.ToInt32(n);
          
            if (officeNumber == 1)
            {
                Console.WriteLine($"Workind days of office1 are: {office1}");
            }
            if (officeNumber == 2)
            {
                Console.WriteLine($"Workind days of office2 are: {office2}");
            }
            if (officeNumber == 3)
            {
                Console.WriteLine($"Workind days of office3 are: {office3}");
            }
            if (officeNumber == 4)
            {
                Console.WriteLine($"Workind days of office4 are: {office4}.");
            }
            if (officeNumber == 5)
            {
                Console.WriteLine($"Workind days of office5 are: {office5}.");
            }

            Console.ReadLine();

        }
    }
}
