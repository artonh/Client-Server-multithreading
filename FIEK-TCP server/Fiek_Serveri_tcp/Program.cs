using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;             //Shtojm kete Namespace per te munduar me shum klient njekohesish

namespace Fiek_Serveri_tcp
{
    class Program
    {

        static List<string> listeKlientash = new List<string>();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;           //ndryshim ngjyre i tesktit
            Console.WriteLine("~_____________________________-  Serveri -__________________________~\n");
            Console.ResetColor();

            Socket socketiMirseardhes;
            Socket serverSocket;                                               //obj i soketit
            IPEndPoint ip;   
       perseri:

            ip = new IPEndPoint(IPAddress.Any, 7000);//Krijimi i nje pike fundore me ip dhe port numer
            socketiMirseardhes = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //Krijimi i nje socketi dhe inicializimi i tij
            socketiMirseardhes.Bind(ip);
            socketiMirseardhes.Listen(10);
            serverSocket = socketiMirseardhes.Accept();

            KlientiRi klienti = new KlientiRi(serverSocket);

            socketiMirseardhes.Close();//Mbyllet socketiMirseardhes
            goto perseri;
        }

        class KlientiRi
        {
            Socket serverSocket;
            Metodat objMetoda = new Metodat();
            IPEndPoint objipEndpoint;

            public KlientiRi(Socket serverSocket)
            {
                this.serverSocket = serverSocket;
                this.objipEndpoint = (IPEndPoint)serverSocket.RemoteEndPoint;//Marrja e ip dhe portit
                Thread cThread = new Thread(Komunikimi);
                if (!listeKlientash.Contains(objipEndpoint.Address.ToString()))
                    listeKlientash.Add(objipEndpoint.Address.ToString());
                cThread.Start();
            }

            public void Komunikimi()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Serveri u lidh me klientin {0} me nr: {1} ne portin {2}", objipEndpoint.Address, (listeKlientash.IndexOf(objipEndpoint.Address.ToString()) + 1).ToString(), objipEndpoint.Port);
                Console.ResetColor();
                try
                {
                    byte[] edhenap = new byte[128];                                 //deklarim i bajtit me vlere max 128
                    int gjatsia = serverSocket.Receive(edhenap);//Leximi i gjatesise mesazhit nga klienti permes serversocket
                    string EDhenaPranuese = Encoding.ASCII.GetString(edhenap, 0, gjatsia);//ruajtja e rezultatit te kthyer nga serveri ne stringun 'EDhenaPranuese'

                    string pergjigjja = "";                                         //nje string fillestar pergjigja NULL, ne te do ta ruajm rezultatin
                    EDhenaPranuese = EDhenaPranuese.Trim();
                    if (EDhenaPranuese.ToLower() == "ip")                           //Nese klienti ka kerkuar "ip" thirret metoda IP(objEndpoint)
                        pergjigjja = objMetoda.IP(objipEndpoint);
                    else if (EDhenaPranuese.ToLower() == "port")                    //Nese klienti ka kerkuar "port" thirret metoda PORT(objEndpoint)
                        pergjigjja = objMetoda.PORT(objipEndpoint);
                    else if (EDhenaPranuese.ToLower() == "time")                    //Nese klienti ka kerkuar "ora" thirret metoda TIME()
                        pergjigjja = objMetoda.TIME();
                    else if (EDhenaPranuese.ToLower() == "host")                    //Nese klienti ka kerkuar "ip" thirret metoda HOST()
                        pergjigjja = objMetoda.HOST();
                    else if (EDhenaPranuese.ToLower().IndexOf("zanore") == 0)         //Nese kerkesa e fillon me "ZANORE " thirret metoda ZANORE(edhena.ToLower())
                        pergjigjja = objMetoda.ZANORE(EDhenaPranuese.ToLower());
                    else if (EDhenaPranuese.ToLower().IndexOf("printo") == 0)       //Nese kerkesa e fillon me "printo " thirret metoda PRINTO(edhena.ToLower())
                        pergjigjja = objMetoda.PRINTO(EDhenaPranuese.ToLower());
                    else if (EDhenaPranuese.ToLower().IndexOf("konverto") == 0)     //Nese kerkesa e fillon me "konverto " thirret metoda KONVERTO(EDhena.ToLower())
                        pergjigjja = objMetoda.KONVERTO(EDhenaPranuese.ToLower());
                    else if (EDhenaPranuese.ToLower() == "keno")                    //Nese klienti ka kerkuar "keno " thirret metoda KENO();
                        pergjigjja = objMetoda.KENO();
                    else if (EDhenaPranuese.ToLower().IndexOf("faktoriel") == 0)    //Nese kerkesa e fillon me "faktoriel " thirret metodaFAKTORIEL(EDhena.ToLower())
                        pergjigjja = objMetoda.FAKTORIEL(EDhenaPranuese.ToLower());
                    else
                    {
                        pergjigjja = "Kerkese E Pa Definuar Mire!!!";               //ne raste gabimi
                    }

                    byte[] edhenaDerguese = new byte[128];                          //nje bajt me 128max       
                    edhenaDerguese = Encoding.ASCII.GetBytes(pergjigjja);           //pergjigjen e encodojm/kthejm ne bajta
                    serverSocket.SendTo(edhenaDerguese, objipEndpoint);               //ja dergojme klientit

                    Console.WriteLine("Klienti : " + EDhenaPranuese);               //ne anen e serverit shtypet kerkesa e klientit
                    Console.WriteLine("Serveri: " + pergjigjja);                    //ne anen e serviert shtypet pergjigja e serverit
                }
                catch (Exception err)
                {
                    Console.WriteLine("Gabim: " + err);                             //Nese ndodh ndonje gabim, shtypet
                }
            }
        }

            //Metodat per pergjigjejn e ne kerkesat e e klintit
       class Metodat
       {
                public string IP(IPEndPoint objIPEP) //metode per kthim te ip
                {
                    return "Ip addres e klientit eshte: " + objIPEP.Address; //kthe ip
                }

                public string PORT(IPEndPoint objIPEP) //metode per tregim te portit
                {
                    return "Klienti eshte duke perdorur portin: " + objIPEP.Port;     //kthe portin
                }

                public string ZANORE(string eardhura) //metode per zanore
                {
                    int VendiHapsires = eardhura.IndexOf(' ');                       //me gjet indeksin e hapsires
                    string text = eardhura.Substring(VendiHapsires + 1, eardhura.Length - VendiHapsires - 1);//Merr tekstin qe ka shkruar klienti

                    int total = text.Count(k => "aeiouy".Contains(Char.ToLower(k))); //numero nese ne 'text' ka ndoje nga kto shkronja   
                    return "Teksti i pranuar permban " + total + " zanore";          //shtyp nr total      
                }

                public string PRINTO(string eardhura) //metode per printimin e tekstit qe ka shkruajtur klienti
                {
                    int hapsire = eardhura.IndexOf(' ');                                            //gjej hapsiren
                    string text = eardhura.Substring(hapsire + 1, eardhura.Length - hapsire - 1);   //mere ate qe ka shkruajt
                    return "" + text;                                                               //kthe
                }

                public string HOST() //metode per tregim te 
                {
                    if (Dns.GetHostName() == null)
                        return "Emri i Hostit nuk dihet!\n";
                    else
                        return "Emri i Hostit eshte: " + Dns.GetHostName();
                }

                public string TIME() //koha
                {
                    return "Ora eshte :" + DateTime.Now;
                }

                public string KENO() //metode qe kthen 20nr random nga 1-80
                {
                    List<int> nrKeno = new List<int>();         //list qe me vone e mbushim
                    Random rnd = new Random();                  //obj i random-it
                    string x = "";                              //x per fillim i zbrazt
                    do
                    {
                        int numeri = rnd.Next(1, 81);           //numri barazohet me nr random mes kti diapazoni
                        nrKeno.Add(numeri);                     //shto kete numer ne list
                    }
                    while (nrKeno.Count < 20);                  //kjo vazhdon derisa te behet 20her

                    for (int i = 0; i < 19; i++)                //tani do t'i shtypim antaret me presje
                    {
                        x += nrKeno[i] + ",";
                    }
                    x = x + nrKeno[19];                         //plus antari i fundit pa presje
                    return x;                                   //kthe kete x
                }

                public string FAKTORIEL(string eardhura) //metod per faktoriel
                {
                    int hapsire = eardhura.IndexOf(' ');        //me gjet indeksin e hapsires
                    string text = eardhura.Substring(hapsire + 1, eardhura.Length - hapsire - 1);//Merr tekstin qe ka shkruar klienti

                    double numri = 0;
                    double Rezultati = 1;
                    try
                    {
                        numri = Convert.ToDouble(text);                                      // teksti qe ka ardh me u konvertu ne nr
                    }
                    catch (Exception gab)
                    {
                        return "Gabim ne konvertim numri. Ju lutem shkruani nje numer" + gab;
                    }
                    for (int i = 1; i <= numri; i++) { Rezultati *= i; }  //faktorieli
                    return Rezultati.ToString();                                                //kthena ne string sepse ky ishte nr
                }

                public string KONVERTO(string eardhura) //metod per konvertime
                {
                    string[] ardhja = eardhura.Split(' ');//e ndan tekstin hyres ne 3 pjes permes ' '   
                    int vlera = 0;
                    double Rezultati = 0;
                    string kerkimi = "";
                    try
                    {
                        vlera = Convert.ToInt32(ardhja[2]);
                    }
                    catch (Exception error)
                    {
                        return "Formati i numrit nuk eshte ne rregull" + error;
                    }

                    switch (ardhja[1])    //ardhja[1] permban numrin e operacionit
                    {
                        case "fahrenheittocelsius": Rezultati = ((vlera - 32) * (5.0 / 9)); kerkimi = "Fahrenheit To Celsius "+vlera; break;
                        case "celsiustofahrenheit": Rezultati = vlera * 9 / 5 + 32; kerkimi = "Celsius To Fahrenheit " + vlera; break;
                        case "celsiustokelvin": Rezultati = vlera + 273.15; kerkimi = "Celsius To Kelvin " + vlera; break;
                        case "kelvintofahrenheit": Rezultati = vlera * 9 / 5 - 459.67; kerkimi = "Kelvin To Fahrenheit " + vlera; break;
                        case "kelvintocelsius": Rezultati = vlera - 273.15; kerkimi = "Kelvin To Celsius " + vlera; break;
                        case "fahrenheittokelvin": Rezultati = (vlera + 459.67) * 5 / 9; kerkimi = "Fahrenheit To Kelvin " + vlera; break;
                        case "poundtokilogram": Rezultati = vlera / 2.2046; kerkimi = "Pound To Kilogram " + vlera; break;       //ktu njesia temperatura = lb
                        case "kilogramtopound": Rezultati = vlera * 2.2046; kerkimi = "Kilogram To Pound " + vlera; break;       //ktu njesia temperatura = kg
                        default: return "Nuk eshte i definuar ky konvertues!";
                    }
                    return kerkimi + Rezultati;
                }
        }
    }
}
