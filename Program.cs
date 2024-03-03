using System;
namespace PatikaEnum{
    class Program{
        public static void Main(string[] args){
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 25;

            if(sicaklik <= (int)HavaDurumu.Normal){
                Console.WriteLine("Disariya cikmak icin havanin isinmasini bekleyin");
            }
            else if(sicaklik >= (int)HavaDurumu.Sicak){
                Console.WriteLine("Disariya cikmak icin cok sicak");
            }
            else if(sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak){
                Console.WriteLine("Hdi disariya cikalim");
            }
        }
    }
    enum Gunler{
        Pazartesi,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu{
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}