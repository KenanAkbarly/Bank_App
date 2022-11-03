
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
      
            int mebleg = 0;
            int ayliodenis = 0;
            int chossen = 0;
            int cavab = 0;
            int odenilecekmebleg = 0;
            int Qalanborc = 0;
            int Qalanay = 0;
            int ay = 0;
            int Faiz = 0;
            string correctusername = "Admin";
            string correctpassword = "Admin";
            tryagain:
            Console.Write("Usename:");
            string username = Console.ReadLine();
            Console.Write("Password:");
            string password = Console.ReadLine();

            if (correctusername == username && correctpassword == password)
            {
            again:
                Console.WriteLine($"\t\t\t\t\t\t\tWelcome {username}");
                Console.WriteLine("\t\t\t\t\t----------------------------------------------");
                Console.WriteLine("1.Kredit goturmek");
                Console.WriteLine("2.Kredit odemek ");
                Console.WriteLine("3.Hesabat");
                Console.WriteLine("Menu ya qayitmaq ucun 4 secin.");

                Console.Write("\nEmeliyyati secin:");
                chossen = Convert.ToInt32(Console.ReadLine());
                if (chossen == 1)
                {
                    Console.Write("Ay daxil edin: ");
                    ay = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Mebleg daxil edin: ");
                    mebleg = Convert.ToInt32(Console.ReadLine());
                    Faiz = 12;
                    odenilecekmebleg = mebleg + mebleg / 100 * Faiz;
                    ayliodenis = odenilecekmebleg / ay;
                    if (ay <= 12 && ay>1)
                    {
                        Console.WriteLine($"Umumi mebleg:{odenilecekmebleg}");
                    }
                    else if(ay >12 )
                    {
                        Faiz = 18; 
                        odenilecekmebleg = mebleg + mebleg / 100 * Faiz;
                        Console.WriteLine($"Umumi mebleg:{odenilecekmebleg}");
                    }

                    Console.WriteLine($"Ayliq odenis:{ayliodenis}");

                    Console.WriteLine("Razisiniz? ");
                    Console.WriteLine("1.Beli \n2.Xeyir");
                    cavab = Convert.ToInt32(Console.ReadLine());
                    if (cavab == 1)
                    {
                        Console.WriteLine($"Emeliyyat ugurlu oldu!");
                        Console.WriteLine($" Indiki borcunuz: {odenilecekmebleg} AZN");
                        Qalanborc = odenilecekmebleg;
                        Qalanay = ay;
                    }
                    goto again;

                }
                else if (chossen == 2)
                {
                    Console.WriteLine($"Ayliq odenis: {ayliodenis} azn");
                payagain:
                    Console.WriteLine("Odemek ucun 1 basin");
                    int paymentnum = Convert.ToInt32(Console.ReadLine());
                    if (paymentnum == 1)
                    {
                        Console.WriteLine("Odenis ugurlu oldu !");

                        Qalanborc = Qalanborc - ayliodenis;
                        Qalanay = Qalanay - 1;
                        Console.WriteLine($"Qalan borc:{Qalanborc} azn\n Qalan ay:{Qalanay} ay");
                        goto again;
                    }
                    else
                    {
                        Console.WriteLine("Odenis alinmadi,yeniden cehd edin.");
                        goto payagain;
                    }
                }

                else if (chossen == 3)
                {
                    Console.WriteLine($"Qalan borc:{Qalanborc} azn");
                    Console.WriteLine($"Qalan ay:{Qalanay} ay ");
                    goto again;
                }
                else if(chossen == 4)
                {
                    goto tryagain;
                }
            }
            else
            {
                Console.WriteLine("Username ve ya Password yanlisdir,yeniden cehd edin");
                goto tryagain;
            }

                    }
                }
            }