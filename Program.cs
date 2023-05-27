// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int num1 = num/10000;
// int num2 = (num/1000)%10;
// int num4 = (num/10)%10;
// int num5 = num%10;

// bool T1 = Math.Equals (num1, num5);
// bool T2 = Math.Equals (num2, num4);

// if ((T1 == true)&&(T2 == true))
// {
//     Console.WriteLine("Полиндром");
// }
// else
// {
//     Console.WriteLine("Нет");
// }




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



// Console.WriteLine("Введите координату");
// int AX = Convert.ToInt32(Console.ReadLine());
// int AY = Convert.ToInt32(Console.ReadLine());
// int AZ = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату");
// int BX = Convert.ToInt32(Console.ReadLine());
// int BY = Convert.ToInt32(Console.ReadLine());
// int BZ = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow((AX-BX),2)+ Math.Pow((AY-BY),2)+Math.Pow((AZ-BZ),2));

// Console.WriteLine(d);



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int numKube = 1;

int ind = 1;

while (ind<num+1)
{
    numKube = Convert.ToInt16(Math.Pow(ind,3));
    ind++;
    Console.WriteLine(numKube);
}
