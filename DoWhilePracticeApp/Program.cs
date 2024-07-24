Console.WriteLine("Selam Patikalı! Haydi kaç defa Patikalı olduğunu göster tüm dünyaya :)");
Console.WriteLine("Oyunumuzda bize bir değer sayısı ver, senin Patikalı olduğunu o değer sayısı kadar haykıralım.");            //Girişde kullanıcıya oyun ile ilgili bilgi vermek için detaylı açıklama yapılmıştır.
Console.WriteLine("Sayacımız 0 dan başlıyor.");                                                             
Console.WriteLine("Oyunumuzun şartlarından biri:( Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) oyunu bu şarta göre düzenleyip oynamalısın. )");
Console.WriteLine("Haydi bakalım başla!!!");

int sayac = 0;
Console.WriteLine("Bir limit değeri giriniz");
int limit = Convert.ToInt32(Console.ReadLine());

//While Döngüsü

if (limit > 0)
{
    while (sayac <= limit)
    {
        Console.WriteLine("Ben bir Patika'lıyım.");
        sayac++;
    }
}
else
{
    Console.WriteLine("Oyun şartlarımıza bakman gerekliydi.Negatif bir sayı girdin!!");
    Console.WriteLine("Sayacımız 0'dan başlayıp artarak ilerlemeliydi ve ( Sayac <= Limit ) olmalıydı. Bu Kurala uymadın.");
    Console.WriteLine("Seni tanımak güzeldi:(");
}

//Do-While Döngüsü 

if (limit > 0)
{
    do
    {
        Console.WriteLine("Ben bir Patika'lıyım.");
        sayac++;
    } while (sayac <= limit);
}
else
{
    Console.WriteLine("Oyun şartlarımıza bakman gerekliydi.Negatif bir sayı girdin!!");
    Console.WriteLine("Sayacımız 0'dan başlayıp artarak ilerlemeliydi ve ( Sayac <= Limit ) olmalıydı. Bu Kurala uymadın.");
    Console.WriteLine("Seni tanımak güzeldi:(");
}

// while ve do-while arasındaki fark do-while döngüsü için başlangıçta kontrol sağlamayarak içinde bulunan döngüyü çalıştırması.
// Bu nedenle, bir döngünün en az bir kez çalışmasını istediğiniz durumlarda do-while döngüsü kullanılabilir.