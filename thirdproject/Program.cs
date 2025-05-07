class Program
{
    static void Main()
    {
        //// Adlardan ibarət massiv təyin edilir
        //string[] adlar = { "Əli", "Leyla", "Rauf", "Zəhra", "Tunar" };

        //// for döngüsü ilə ekrana çıxarılır
        //Console.WriteLine("for döngüsü ilə:");
        //for (int i = 0; i < adlar.Length; i++)
        //{
        //    Console.WriteLine(adlar[i]);
        //}

        //// foreach döngüsü ilə ekrana çıxarılır
        //Console.WriteLine("\nforeach döngüsü ilə:");
        //foreach (string ad in adlar)
        //{
        //    Console.WriteLine(ad);
        //}


        //Console.WriteLine("Adinizi daxil edin"); //task 3
        //string daxilOlunmaliAD = Console.ReadLine();

        //string[] adlar = { "Farid", "Shahin", "Parviz", "Isa" };

        //bool dogruCavab = false;

        //for (int i = 0; i < adlar.Length; i++)
        //{
        //    if (daxilOlunmaliAD == adlar[i])
        //    {
        //        dogruCavab = true;
        //        break;
        //    }
        //}
        //if (dogruCavab)
        //{
        //    Console.WriteLine("Adınız sistemdə tapıldı.");
        //}
        //else
        //{
        //    Console.WriteLine("Daxil etdiyiniz ad sistemdə yoxdur.");
        //}

        //int number = 1;
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine(i);
        //}


        string[] name = { "Farid", "Isa", "Parviz", "Sahin" };
        foreach (string adlar in name)
        {
            Console.WriteLine(adlar);
        }
    }
}