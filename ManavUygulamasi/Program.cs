using System;

namespace ManavUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write($"Hangi meyveyi almak istersiniz?Lütfen Türkçe karakter kullanmayiniz");
            string fruit=Console.ReadLine().ToLower();


            if (fruit == "elma")
            {
                Console.WriteLine("Elma=2 TL");
            }
            else if (fruit == "armut") {
                Console.WriteLine("Armut = 3 TL");
            }
            else if (fruit == "cilek")
            {
                Console.WriteLine("Çilek = 2 TL");
            }
            else if (fruit == "muz")
            {

                Console.WriteLine("Muz= 3TL")
            }

            else {
                Console.WriteLine("Diğer bütün meyveler = 4 TL"); }

            //switchcase yapısı kullanmamız daha mantıklıdır çünkü if else yapısında gereksiz kontrol yaparken switch case yapısında yalnız gerekli conditiona girer ve çıkar.


                //switch (fruit) {

                //    case "elma":
                //        Console.WriteLine("Elma=2 TL");
                //        break;
                //    case "armut":
                //        Console.WriteLine("Armut = 3 TL");
                //        break;
                //    case "cilek":
                //        Console.WriteLine("Çilek = 2 TL");
                //        break;
                //    case "muz":
                //        Console.WriteLine("Muz = 3 TL");
                //        break;
                //        default:
                //        Console.WriteLine("Diğer bütün meyveler = 4 TL");
                //        break;

                //}



            }
    }
}
