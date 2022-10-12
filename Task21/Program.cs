 // Задача 21

 Console.Clear();
 Console.Write("Введите первую координату х: ");

    double x = Convert.ToDouble(Console.ReadLine());

 Console.Write("Введите первую координату у: ");

    double y = Convert.ToDouble(Console.ReadLine());

 Console.Write("Введите первую координату z: ");

    double z = Convert.ToDouble(Console.ReadLine());

 Console.Write("Введите вторую координату x: ");

    double x1 = Convert.ToDouble(Console.ReadLine());

 Console.Write("Введите вторую координату у: ");

    double y1 = Convert.ToDouble(Console.ReadLine());
    
 Console.Write("Введите вторую координату z: ");

    double z1 = Convert.ToDouble(Console.ReadLine());

    double s =(Math.Round(Math.Sqrt(Math.Pow(x1 - x , 2) + Math.Pow(y1 - y , 2)+ Math.Pow(z1 - z, 2)), 3));

 Console.WriteLine($"Расстояние между точками: {s}");
