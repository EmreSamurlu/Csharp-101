using System;

namespace console_programming
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("İsminizi girin:");
      string name = Console.ReadLine();
      Console.WriteLine("Soyadınızı Girin!");
      string surname = Console.ReadLine();

      Console.WriteLine("Merhaba " + name + " " + surname);
    }
  }
}
