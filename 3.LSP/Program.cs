using _3.LSP.BadExample.Concretes;
using _3.LSP.BadExample.Interfaces;
using _3.LSP.GoodExample.ConcreteGood;
using _3.LSP.GoodExample.InterfaceGood;

namespace _3.LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bad
            //UcakA ucakA = new UcakA();
            //UcakB ucakB = new UcakB();
            //UcakC ucakC = new UcakC();

            //List<IUcak> ucaklar = new List<IUcak>() { ucakA, ucakB, ucakC };

            //Console.WriteLine("Keşifler");
            //foreach (var ucak in ucaklar)
            //{
            //    ucak.KesifYap();
            //}

            //Console.WriteLine("Ataklar");
            //foreach (var ucak in ucaklar)
            //{
            //    ucak.HedefiVur();
            //}
            #endregion

            #region Good
            UcakAGood ucakA = new UcakAGood();
            UcakBGood ucakB = new UcakBGood();
            UcakCGood ucakC = new UcakCGood();


            Console.WriteLine("Keşifler: ");
            List<IKesifYap> kesifYapanlar = new List<IKesifYap> { ucakA, ucakB, ucakC };
            foreach (var ucak in kesifYapanlar)
            {
                ucak.KesifYap();
            }

            Console.WriteLine("Ataklar: ");
            List<IHedefiVur> hedefiVuranlar = new List<IHedefiVur> { ucakA, ucakB };
            foreach (var ucak in hedefiVuranlar)
            {
                ucak.HedefiVur();
            }
            #endregion
        }
    }
}