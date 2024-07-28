using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // SortedList - Key'e göre otomatik sıralar
        var list = new SortedList()
        {
            {67, "Zonguldak" },
            {31, "Hatay" },
            {15, "Burdur" },
            {2, "Adıyaman" }
        };
        list.Add(3, "Afyon");
        list.Add(1, "Adana");

        Console.WriteLine("Otomatik sıralanmış anahtar ve değer listesi:");
        foreach (DictionaryEntry sehir in list)
        {
            Console.WriteLine(sehir.Key + " " + sehir.Value);
        }
        Console.WriteLine();

        Console.WriteLine("Eleman Sayısı:" + list.Count);
        Console.WriteLine();

        Console.WriteLine("Kapasitesi : " + list.Capacity);
        list.TrimToSize();
        Console.WriteLine();

        Console.WriteLine(".TrimToSize() sonrası Kapasitesi : " + list.Capacity);
        Console.WriteLine();

        Console.Write("Anahtara göre değer getirme : ");
        Console.WriteLine(list[15]);
        Console.WriteLine();

        Console.Write("Sıralama öncesi İndise göre değer getirme : ");
        Console.WriteLine(list.GetByIndex(4));
        Console.WriteLine();

        Console.Write("Sıralama öncesi İndise göre Anahtarı getirme : ");
        Console.WriteLine(list.GetKey(4));
        Console.WriteLine();

        Console.Write("Liste sonundaki değeri getirme : ");
        Console.WriteLine(list.GetByIndex( list.Count - 1 ));
        Console.WriteLine();

        Console.WriteLine("------------------------");
        Console.WriteLine();

        // UYGULAMA
        Console.WriteLine("SortedList UYGULAMASI:");
        var kitapIcerigi = new SortedList();
        kitapIcerigi.Add(1, "Önsöz");
        kitapIcerigi.Add(50, "Değişkenler");
        kitapIcerigi.Add(40, "Operatörler");
        kitapIcerigi.Add(30, "Döngüler");
        kitapIcerigi.Add(45, "İlişkisel operatörler");

        Console.WriteLine("İçindekiler:");

        Console.WriteLine(new string('-', 40));

        Console.WriteLine($"{"Konular", -30} {"Sayfalar", 5}");
        foreach (DictionaryEntry konu in kitapIcerigi)
        {
            Console.WriteLine($"{konu.Value, -30} {konu.Key, -5}");
        }
    }

}