using System;

namespace HavaDurumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hava durumu uygulamasına hoşgeldiniz. Devam etmek için lütfen enter'a basınız.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hava durumunu giriniz: ");

            int havaDurumu = int.Parse(Console.ReadLine());

            if (havaDurumu <= 10)
            {
                Console.WriteLine("Hava çok soğuk. Kıyafetinizin üstünüze kaban/palto alıp ardından atkınızı ve şapkanızı takabilirsiniz.");
            }
            else if (havaDurumu <= 20)
            {
                Console.WriteLine("Hava esiyor. Dış giyimde kaban/palto yerine daha ince ceketler tercih edebilirsiniz. Trençkot vb.");
            }
            else
            {
                Console.WriteLine("Hava sıcak. Havalar sıcakken en çok tercih edilen keten kumaşlardan kıyafetler tercih edebilirsiniz. Aksesuarlarınızı da unutmayın. Şapka, güneş gözlüğü...");
            }

            Console.ReadLine();
        }
    }
}
