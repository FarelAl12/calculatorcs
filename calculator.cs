using System;

namespace Calculatorapp
{
  class PROGRAM
  {
    static void Main(string[] args)
    {
      float pilihan, a, b;

      menu:
      Console.WriteLine();
      Console.WriteLine("Pilihan menu calculator : ");
      Console.WriteLine();

      Console.WriteLine("1.PENAMBAHAN");
      Console.WriteLine("2.PENGURANGAN");
      Console.WriteLine("3.PERKALIAN");
      Console.WriteLine("4.PEMBAGIAN");
      Console.WriteLine();

      Console.Write("Input pilihan : ");
      pilihan = int.Parse(Console.ReadLine());
      Console.WriteLine();

      if (pilihan == 1)
      {
        Console.Write("Masukkan nilai a : ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Masukkan nilai b : ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Hasil penambahan " + a + " + " + b + " = " + (a + b));
        Console.WriteLine();
        Console.WriteLine("Program selesai");
        Console.ReadKey();
        Environment.Exit(0);
      }

      if (pilihan == 2)
      {
        Console.Write("Masukkan nilai a : ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Masukkan nilai b : ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + (a - b));
        Console.WriteLine();
        Console.WriteLine("Program selesai");
        Console.ReadKey();
        Environment.Exit(0);
      }

      if (pilihan == 3)
      {
        Console.Write("Masukkan nilai a : ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Masukkan nilai b : ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Hasil perkalian " + a + " x " + b + " = " + (a * b));
        Console.WriteLine();
        Console.WriteLine("Program selesai");
        Console.ReadKey();
        Environment.Exit(0);
      }

      if (pilihan == 4)
      {
        Console.Write("Masukkan nilai a : ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Masukkan nilai b : ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Hasil pembagian " + a + " : " + b + " = " + (a / b));
        Console.WriteLine();
        Console.WriteLine("Program selesai");
        Console.ReadKey();
        Environment.Exit(0);
      }

      else
      {
        Console.WriteLine("Pilihan salah!");
        goto menu;
      }
    }
  }
}
