using Microsoft.VisualBasic;

namespace NewTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte tutum = 50;
            byte gullesayi = 50;

            Weapon weapon = new Weapon(tutum, gullesayi);

            string choice;
            bool check = true;
            do
            {
                Console.WriteLine("\n--------------------------------------------------------\n" +
                    "Etmek istediyiniz emeliyeti secin\n " +
                    "0 - Informasiya \n" +
                    "1 - Shoot \n" +
                    "2 - Remain Bullet Count \n" +
                    "3 - Reload \n" +
                    "4 - Change Fire Mode \n" +
                    "5 - Exit \n" +
                    "6 - Edit \n" +
                    "\n----------------------------------------------------------\n");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        weapon.ShowWeaponInfo();
                        break;

                    case "1":
                        weapon.Shoot();
                        break;

                    case "2":
                        Console.WriteLine(weapon.GetRemainBulletCount());
                        break;

                    case "3":
                        weapon.Reload();
                        break;

                    case "4":
                        weapon.ChangeFireMode();
                        break;

                    case "5":
                        Console.WriteLine("\n Program dayandirildi! ");
                        check = false;
                        break;

                    case "6":
                        bool exit = true;
                        do
                        {
                            Console.WriteLine("\n----------------------------------------------------------\n" +
                                     "\n Edit etmek istediyinizi secin \n " +
                                     "7 - Tutum deyismesi \n" +
                                     "8 - Gulle sayi deyisin \n" +
                                     "9 - Ana Menuye qayit" +
                                     "\n----------------------------------------------------------\n");

                            string edit = Console.ReadLine();

                            switch (edit)
                            {
                                case "7":
                                    byte newTutum;
                                    do
                                    {
                                        Console.WriteLine("Yeni tutumu daxil edin: \n");
                                    } while (!byte.TryParse(Console.ReadLine(), out newTutum) && newTutum >= 0);
                                    weapon.Tutum = newTutum;
                                    break;

                                case "8":
                                bullet:
                                    byte gulle;
                                    do
                                    {
                                        Console.WriteLine("Yeni gulle sayi daxil edin: \n");
                                    } while (!byte.TryParse(Console.ReadLine(), out gulle) && gulle >= 0);
                                    if (gulle <= weapon.Tutum) weapon.Hazirkigulle = gulle;
                                    else
                                    {
                                        Console.WriteLine("Duzgun say daxil edin!!");
                                        goto bullet;
                                    }
                                    break;

                                case "9":
                                    Console.WriteLine("\n Menyuya qayitdiq ");
                                    exit = false;
                                    break;

                                default:
                                    Console.WriteLine(" Bu secim yoxdur! ");
                                    break;
                            }
                        } while (exit);
                        break;
                    default :
                        Console.WriteLine("\n Bu secim yoxdur! \n");
                        break;
                }
            } while (check);
        }
    }
}
