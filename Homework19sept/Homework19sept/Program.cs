using System;

namespace Homework19sept
{
    class Program
    {
                #region First Task
            //int mark;
            //while (true)
            //{
            //    try
            //    {
            //        Console.Write("Enter student's score: ");
            //        mark = Convert.ToInt32(Console.ReadLine());

            //        if (mark >= 91 && mark <= 100)
            //        {
            //            Console.WriteLine("A");
            //        }
            //        if (mark >= 81 && mark <= 90)
            //        {
            //            Console.WriteLine("B");
            //        }
            //        if (mark >= 71 && mark <= 80)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        if (mark >= 61 && mark <= 70)
            //        {
            //            Console.WriteLine("D");
            //        }
            //        if (mark >= 51 && mark <= 60)
            //        {
            //            Console.WriteLine("E");
            //        }
            //        if (mark >= 0 && mark <= 51)
            //        {
            //            Console.WriteLine("Fail :(");
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Invalid Score. Please, try again.");

            //    }
                #endregion
                #region Second Task
                //int number;
                //int divider=1;

                //Console.Write("Enter a number: ");
                //number = Convert.ToInt32(Console.ReadLine());
                //for (int i = 1; i <= number; i++, divider++)
                //{

                //    if (number % divider == 0)
                //    {
                //        Console.WriteLine(divider);
                //    }

                //}

                #endregion
                #region Third Task
                //int number;
                //int i=0;
                //Console.Write("Enter a number: ");
                //number = Convert.ToInt32(Console.ReadLine());

                //while (number >= 1)
                //{
                //    number /= 10;
                //    i++;
                //}
                //Console.WriteLine(i);
                #endregion
                #region Fourth Task
                //int number;
                //int result = 0;
                //Console.Write("Enter a number: ");
                //number = Convert.ToInt32(Console.ReadLine());
                //while (number >= 1)
                //{
                //    result += number % 10;
                //    number = (number - (number % 10)) / 10;

                //}
                //Console.WriteLine(result);
                #endregion
                #region Fifth Task
                //int number;
                //int i;

                //Console.Write("Enter a number: ");
                //number = Convert.ToInt32(Console.ReadLine());

                //DefineNum(number);

                //static void DefineNum(int number, int i = 2)
                //{

                //    if (number % i != 0)
                //    {

                //        Console.WriteLine("True");
                //    }
                //    else
                //    {
                //        Console.WriteLine("False");
                //    }
                //    while (i < number)
                //    {
                //        i++;
                //    }

                //}
                #endregion
                #region Sixth Task
                //    int number, result;
                //    Console.Write("Enter a number: ");
                //    number = Convert.ToInt32(Console.ReadLine());

                //    Factorial(number);

                //static void Factorial(int number, int result = 1)
                //{

                //    while (number >= 1)
                //    {
                //        result *= number;
                //        number--;
                //    }
                //    Console.WriteLine(result);
                //}

                #endregion
                #region Seventh Task
                //int[] numbers = { 12, 234, 43, 56, 78 };
                //Console.WriteLine(GetMinMax(numbers));
                //static int GetMinMax(int[] arr)
                //{
                //    try
                //    {
                //        int min = arr[0], max = arr[0];
                //        for (int i = 0; i < arr.Length; i++)
                //        {
                //            if (arr[i] < min)
                //            {
                //                min = arr[i];

                //            }
                //            if (arr[i] > max)
                //            {
                //                max = arr[i];
                //            }
                //        }
                //        return min+max;

                //    }
                //    catch (Exception)
                //    {

                //        Console.WriteLine("Array is empty.");
                //        return 0;

                //    }



                //}
                #endregion
                #region Eights Task
            //string[] seasonOfTheYear = { "Spring", "Summer", "Winter", "Autumn" };
            //int number;
            //Console.Write("Enter a number between 1 and 4: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //if (number >= 1 && number <= 4)
            //{
            //    switch (number)
            //    {
            //        case 1:
            //            Console.WriteLine(seasonOfTheYear[0]);
            //            break;
            //        case 2:
            //            Console.WriteLine(seasonOfTheYear[1]);
            //            break;
            //        case 3:
            //            Console.WriteLine(seasonOfTheYear[2]);
            //            break;
            //        case 4:
            //            Console.WriteLine(seasonOfTheYear[3]);
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Number is not correct");
            //}
            #endregion
                #region Ninth Task
                //    string[] names = { "Ali", "Kamran", "Kamal", "Mohammed" };
                //    Console.WriteLine(GetMaxString(names));

                //static string GetMaxString(string[] arr)
                //{

                //    string result = "";
                //    for (int i = 0; i < arr.Length; i++)

                //    {
                //        if (arr[i].Length > result.Length)
                //        {
                //            result = arr[i];

                //        }

                //    }
                //    return result;
                //}





                #endregion
                #region Tenth Task
                //int num;
                //int result = 1;
                //Console.Write("Enter a number: ");
                //num = Convert.ToInt32(Console.ReadLine());

                //try
                //{

                //    if (num == 1)
                //    {

                //        for (int i = 1; i <= 10; i++)
                //        {
                //            result = num * i;
                //            Console.WriteLine(num + "*" + i + "=" + result);
                //        }

                //    }

                //    if (num == 2)
                //    {

                //        for (int i = 1; i <= 10; i++)
                //        {
                //            result = num * i;
                //            Console.WriteLine(num + "*" + i + "=" + result);
                //        }

                //    }

                //    if (num == 3)
                //    {

                //        for (int i = 1; i <= 10; i++)
                //        {
                //            result = num * i;
                //            Console.WriteLine(num + "*" + i + "=" + result);
                //        }

                //    }


                //    if (num == 4)
                //    {

                //        for (int i = 1; i <= 10; i++)
                //        {
                //            result = num * i;
                //            Console.WriteLine(num + "*" + i + "=" + result);
                //        }

                //    }

                //    if (num == 5)
                //    {

                //        for (int i = 1; i <= 10; i++)
                //        {
                //            result = num * i;
                //            Console.WriteLine(num + "*" + i + "=" + result);
                //        }

                //    }

                //    if (num == 6)
                //    {

                //        for (int i = 1; i <= 10; i++)
                //        {
                //            result = num * i;
                //            Console.WriteLine(num + "*" + i + "=" + result);
                //        }

                //        if (num == 7)
                //        {

                //            for (int i = 1; i <= 10; i++)
                //            {
                //                result = num * i;
                //                Console.WriteLine(num + "*" + i + "=" + result);
                //            }

                //        }
                //    }
                //    if (num == 8)
                //    {

                //        for (int i = 1; i <= 10; i++)
                //        {
                //            result = num * i;
                //            Console.WriteLine(num + "*" + i + "=" + result);
                //        }

                //    }

                //    if (num == 9)
                //    {

                //        for (int i = 1; i <= 10; i++)
                //        {
                //            result = num * i;
                //            Console.WriteLine(num + "*" + i + "=" + result);
                //        }

                //    }

                //    if (num == 10)
                //    {

                //        for (int i = 1; i <= 10; i++)
                //        {
                //            result = num * i;
                //            Console.WriteLine(num + "*" + i + "=" + result);
                //        }

                //    }
                //}
                //catch (Exception)
                //{
                //    Console.WriteLine("Number is not correct.");
                //}
                #endregion
                #region *bonus* Calculator (without methods)
                //int result;
                //int num1;
                //int num2;
                //string oper;
                //int errorCount = 100;

                //while (errorCount > 1)
                //{


                //    try
                //    {
                //        Console.Write("Enter first number: ");
                //        num1 = Convert.ToInt32(Console.ReadLine());
                //        Console.Write("Enter second number: ");
                //        num2 = Convert.ToInt32(Console.ReadLine());
                //        Console.Write("Enter operator: ");
                //        oper = Console.ReadLine();

                //        if (oper == "+")
                //        {
                //            result = num1 + num2;
                //            Console.WriteLine(result);
                //        }

                //        if (oper == "-")
                //        {
                //            result = num1 - num2;
                //            Console.WriteLine(result);
                //        }

                //        if (oper == "*")
                //        {
                //            result = num1 * num2;
                //            Console.WriteLine(result);
                //        }
                //        if (oper == "/")
                //        {
                //            result = num1 / num2;
                //            Console.WriteLine(result);
                //        }

                //    }
                //    catch (Exception)
                //    {
                //        Console.WriteLine("Invalid operator: ");

                //    }
                #endregion
                #region *bonus* Calculator (with methods)
                //    int result;
                //    int num1;
                //    int num2;
                //    string oper;
                //    int errorCount = 100;

                //    while (errorCount > 1)
                //    {


                //        try
                //        {
                //            Console.Write("Enter first number: ");
                //            num1 = Convert.ToInt32(Console.ReadLine());
                //            Console.Write("Enter second number: ");
                //            num2 = Convert.ToInt32(Console.ReadLine());
                //            Console.Write("Enter operator: ");
                //            oper = Console.ReadLine();

                //            if (oper == "+")
                //            {
                //                Console.WriteLine(Add(num1, num2));
                //            }

                //            if (oper == "-")
                //            {
                //                Console.WriteLine(Subtract(num1, num2));
                //            }

                //            if (oper == "*")
                //            {
                //                Console.WriteLine(Multiply(num1, num2));
                //            }
                //            if (oper == "/")
                //            {
                //                Console.WriteLine(Divide(num1, num2));
                //            }

                //        }
                //        catch (Exception)
                //        {
                //            Console.WriteLine("Invalid operator: ");

                //        }
                //    }

                //}
                //static int Add(int num1, int num2, int result = 0)
                //{
                //    return result = num1 + num2;
                //}

                //static int Subtract(int num1, int num2, int result = 0)
                //{
                //    return result = num1 - num2;
                //}

                //static int Divide(int num1, int num2, int result = 0)
                //{
                //    return result = num1 / num2;
                //}
                //static int Multiply(int num1, int num2, int result = 0)
                //{
                //    return result = num1 * num2;
                #endregion

        static void Main(string[] args)

        {






        }





        
    }
}

    





