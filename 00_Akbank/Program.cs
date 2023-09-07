using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Metin girin: ");
        string metin = Console.ReadLine();

        string duzeltilmisMetin = DuzeltMetin(metin);

        Console.WriteLine("Düzeltilmiş Metin: " + duzeltilmisMetin);
    }

    static string DuzeltMetin(string metin)
    {
        // "." karakterlerinin pozisyonlarını bulun
        int index = metin.IndexOf('.');

        while (index != -1)
        {
            // "." karakterinden sonraki pozisyona boşluk ekleyin
            metin = metin.Insert(index + 1, " ");

            // Bir sonraki "." karakterini arayın
            index = metin.IndexOf('.', index + 2);
        }

        // Birden fazla boşluğu tek bir boşluğa çevirin
        metin = Regex.Replace(metin, @"\s+", " ");

        return metin;
    }
}