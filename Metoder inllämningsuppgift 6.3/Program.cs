using System;
namespace inllämningsuppgidt
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine(" ");
            Console.WriteLine("1. addera tre tal");
            Console.WriteLine("2. största talet av två tal");
            Console.WriteLine("3. avsluta programet");
            Console.WriteLine(" ");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1":
                    Console.WriteLine("skriv in de tre talen du vill addera separerade av ett + tecken");
                    Console.WriteLine(" ");
                   string b = Console.ReadLine();
                    string[] c = b.Split('+');
                    int d = int.Parse(c[0]);
                    int e = int.Parse(c[1]);
                    int f =int.Parse(c[2]);
                    Console.WriteLine(" ");
                    Console.WriteLine("Summan blir: " + MenyvalAddera(d,e,f));
                    break;
                    
                        case "2":
                    Console.WriteLine("Skriv in de talen som du vill jämföra separerade med ett mellanslag");
                    Console.WriteLine(" ");
                    string g = Console.ReadLine();
                    string[] h = g.Split(' ');
                    int k =int.Parse(h[0]);
                    int l = int.Parse(h[1]);
                    Console.WriteLine(" ");
                    Console.WriteLine("Det dtörsta talet är " + (Menyvalstörstatalet(k,l)));
                    break;

                case "3":

                    break;

                default:
                    Console.WriteLine(" ");
                    Console.WriteLine( "oaccepterat svar");
                    break;

            }


        }
        static int MenyvalAddera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }
        static int Menyvalstörstatalet(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else if (tal1 < tal2)
            {
                return tal2;
            }
            else 
            {
                return tal1;
            }

                
        }

    }
}