 // Задача 19

 Console.Clear();

 Console.WriteLine("Введите пятизначное число: ");

	int n = Convert.ToInt32(Console.ReadLine());

 	int a = 0;

 	int b = 0;

 	while (n < 10000 || n > 99999)

 {
 	    Console.WriteLine("Вы ошиблись! Введите пятизначное число: ");

 	    n = Convert.ToInt32(Console.ReadLine());
 }

 	a = n / 100;

 	b = (((n%10)*100)+(((n%100)/10)*10)+((n%1000)/100));

 	if (a==b)

      Console.WriteLine("Число является палиндромом");

 	else
    
     Console.WriteLine("Число не является палиндромом");