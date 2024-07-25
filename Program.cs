void SarkiSozu()
{
    Console.WriteLine("You know more folks that's most afraid of the wolf" +
        "\nIf you really stop and think\nThroughout time, between a wolf and a shepherd\n" +
        "Who do you think has killed more sheep?" +
        "\nSaint of Lost Causes.");

}
SarkiSozu();


int TamSayiDonduren()
{
    Random rnd = new Random();
    int sayi = rnd.Next();
    int sonuc = sayi % 2;
    Console.WriteLine(sonuc);
    return
        sonuc;
}
TamSayiDonduren();
Console.WriteLine("Lutfen sirasiyla, carpilmasini istediginiz iki sayi giriniz.");
Console.Write("Sayi 1:");
int ilkSayi= Convert.ToInt32(Console.ReadLine());
Console.Write("Sayi 2:");
int ikinciSayi = Convert.ToInt32(Console.ReadLine());

int Carpim(int A,int B)
{
    int sonuc = A * B;
    Console.WriteLine(sonuc);
    return
    sonuc;
       
}
Carpim(ilkSayi, ikinciSayi);

Console.WriteLine("Lutfen ad ve soyadinizi giriniz.");
Console.Write("Ad:");
string ad = Console.ReadLine();
Console.Write("Soyad: ");
string soyad = Console.ReadLine();


string IsimSoyisim(string A,string B)
{
    Console.WriteLine("Hos geldiniz, {0}, {1}", A, B);
    return
        A + B;
}

IsimSoyisim(ad, soyad);








