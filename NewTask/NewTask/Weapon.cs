using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    internal class Weapon
    {
        public byte Tutum {  get; set; }
        public byte Hazirkigulle {  get; set; }
        public bool Mood;
       
            


        public Weapon(byte tutum, byte hazirkigulle)
        {
            Tutum = tutum;
            Hazirkigulle = hazirkigulle;
        }

        public void ShowWeaponInfo()
        {
            Console.WriteLine($"Silahin tutumu: {this.Tutum}\n Hazirki gulle sayi: {this.Hazirkigulle}");
            if (Mood) Console.WriteLine("Hazirki atis modu: Avtomatik");
            else Console.WriteLine("Hazirki atis modu: Tekli");
            

        }
        public void Shoot()
        {
            if (Hazirkigulle >  0)
            {
                if (!Mood)
                {
                    Hazirkigulle--;
                    Console.WriteLine($"Ates edildi! \n Silah avtomatikde idiSilah teklide idi! \n");
                }
                else 
                {
                    Hazirkigulle = 0;
                    Console.WriteLine($"Butun gulleler ateslendi! \n !");
                }
            }
            else Console.WriteLine("Silah bosdur!");


        }
        
        

        public byte GetRemainBulletCount()
        {
            if (Tutum == Hazirkigulle) Console.WriteLine("Silah tam doludur! ");
            else Console.WriteLine("Daragin tam dolmasi ucun lazimli  gulle sayi: ");
            return (byte)(Tutum - Hazirkigulle);
        }

        public void Reload()
        {
            if (Hazirkigulle < Tutum)
            {
                Hazirkigulle = Tutum;
                Console.WriteLine("Silah dolduruldu! \n");
            }
            else Console.WriteLine("Silah zaten doludur!\n");
        }

        public void ChangeFireMode()
        {
            Mood = !Mood;
            if (Mood) Console.WriteLine(" Atis modu Teklidenden Avtomatike deyisdi");
            else Console.WriteLine("Atis modu Avtomatikden Tekliye deyisdi");
        }


    }
}
