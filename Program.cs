using System;

namespace diziler_
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanimlama
            string[] renkler = new string[5];
            string[] hayvanlar={"kedi","kopek","kus","maymun"};
            
            int[] dizi;
            dizi= new int[5];

            //dizilere deger atama ve erisim
            renkler[0]="mavi";
            Console.WriteLine(hayvanlar[0]);
            dizi[3]=10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //dongulerle dizi kullanimi
            //kalvyeden girilen n tane sayinin ortalamasini hesaplayan program
            
            Console.WriteLine("lutfen dizinin eleman sayisini giriniz:");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayidizisi=new int[diziuzunlugu];

            for(int i=0; i<diziuzunlugu; i++)
            {
                Console.WriteLine("lutfen{0}.sayiyi giriniz", i+1);
                sayidizisi[i]=int.Parse(Console.ReadLine());
            }

            int toplam=0;
            foreach(var sayi in sayidizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("ortalama: "+ toplam/diziuzunlugu);

        }
    }
    
}
