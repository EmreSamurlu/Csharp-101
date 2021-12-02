using System;

namespace _002_variables
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      byte b = 1;
      sbyte sb = 2;
      short s = 4;
      ushort u = 0;

      // Tam sayı tutan veri tipleri
      Int16 i = 0;
      int i2 = 0;
      Int32 i3 = 0;
      Int64 i4 = 0;
      uint u2 = 0;
      long l = 0;
      ulong l2 = 0;

      // Reel sayı tutan veri tipleri
      float f = 0;
      double d = 0;
      decimal d2 = 0;

      // Karakter tutan veri tipleri
      char c = 'a'; // char tek tırnak
      string st = "emre"; // string çift tırnak

      // Boolean veri
      bool bl = true;
      bool fl = false;

      // Tarih tutan veri tipi
      DateTime dt = DateTime.Now;
      Console.WriteLine(dt);

      // Object veri türleri
      object o = 'x';
      object o1 = "y";
      object o2 = 2;
      object o3 = 4.3;

      // String ifadeler

      string str1 = string.Empty; // Boş string - null veya "" şeklinde de kullanılabilir
      str1 = "Emre Samurlu";
      string name = "Emre";
      string surname = "Samurlu";
      string fullname = name + " " + surname;

      // Değişken Dönüşümleri
      string st1 = "20";
      int int1 = 20;
      string newValue = st1 + int1.ToString();
      Console.WriteLine(newValue);

      int int21 = int1 + Convert.ToInt32(st1); // Convert.To ile birçok dönüşüm yapabiliriz !!
      Console.WriteLine(int21);

      int int22 = int1 + int.Parse(st1); // Console da 40 döner. Parse komutu string'den dönüşüm yapmak için kullanılır.

      // datetime

      string datetime = DateTime.Now.ToString("dd.MM.yyyy");
      Console.WriteLine(datetime);

      string hour = DateTime.Now.ToString("HH:mm");
      Console.WriteLine(hour);
    }
  }
}
