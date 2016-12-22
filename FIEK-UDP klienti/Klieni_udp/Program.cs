using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Klietni_udp
{
    class Program
    {
        static void Main(string[] args)
        {
            METODATSHTESE objMetodShtese = new METODATSHTESE();    //krijimi i objektit te klases Metodatshtese            
            char a = 'ë';
            Console.ForegroundColor = ConsoleColor.Cyan;           //ndryshim ngjyre i tesktit
            Console.WriteLine("~____________________________________________- Klienti -_____________________________________________~\n");
            Console.ResetColor();                                  //kthimi i ngjyres default
            string localhost = "127.0.0.1"; // localhost i nenkuptuar/ perveq kur shfrytezuesi deshiron ta ndyrshoje ate
                  
            int porti = 7000;       //porti i nenkuptuar
            Console.ForegroundColor = ConsoleColor.White;          //ndryshim ngjyre i tesktit
            // dhe ta mbyllniii punen me PO
            Console.Write("A dëshironi të modifikoni emrin e serverit dhe portin?[Po/Ndonjë] "); 
            Console.ForegroundColor = ConsoleColor.Cyan;           //e ndryshojme ngjyren sa here qe shfrytezuesi do te shkruaj
            string pergjigja = Console.ReadLine().Trim();
            if (pergjigja == "po")                                 //nese shfrytezuesi deshiron te modifikoj emrin dhe portin
            {
                Console.ResetColor();                       
                Console.Write("Shkruani ip e serverit: ");       
                Console.ForegroundColor = ConsoleColor.Cyan;
                string ipadd = Console.ReadLine();                 //string [per lexim te ipadreses qe do te jep shfrytezuesi
                IPAddress address;
                if (IPAddress.TryParse(ipadd, out address))        //validimi i ip      
                    localhost = ipadd;                
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ju keni dhënë IpAddress në format të gabuar!\n");
                    goto fundi;
                }
                Console.ResetColor();
                Console.Write("Shkruani portin e serverit: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sPorti = Console.ReadLine();              //stringu sPorti qe do te jepet nga shfrytezuesi
                if (sPorti == "")  { }                           //nese nuk jep asgje, ateher porti do te jet ai i nenkuptuar
                else   porti = Convert.ToInt32(sPorti);          //e modifikojme portin, duke e konvertuara ne int stringun sPorti
                Console.ResetColor();                       
            }
            else if (pergjigja == "dil") { return; }
      perseri:                                                   //nje etiket, e perdorim ne raste gabimi per tu kthyer te kjo pjese  
         //  Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(localhost), porti);     //krijimi i obj. IP PIKE FUNDORE dhe inicializimi
            Socket socketKlienti = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);//obj soketi & inicia.            
            string PergjigjePerMbyllje = "";                    //deklarimi i stringut, e perdorim per mbyllje te aplikacionit
            try                                                 //per gabime, nese nuk mundet te konektohet do te behet 'catch' 
            {
                socketKlienti.Connect(ip);                      //me u konektu me at IP
            }
            catch (SocketException Errorex)                     //nese hyn kodi ketu, atehere tek 'TRY' eshte kthyer vlere false
            {
                Console.WriteLine("Dështoj lidhja me serverin, ka ndodhë ky gabim (" + Errorex + ")");  //tregon gabimin premes konsole-s
                return;                                         //dhe puna duhet te perfundoj ketu
            }
            
            Console.Write("Operacioni (IP, PORT, ZANORE, PRINTO, HOST, TIME, KENO, KONVERTO, FAKTORIEL, MESATARJA, RENDIT, FIEK)? ");  //na shfaqe operimet
            Console.ForegroundColor = ConsoleColor.Cyan;        //kur te shkruan tani shfrytezuesi te behete ngjyra Cyan
            string sTekstiHyres = Console.ReadLine().Trim();    //merr string-un(pa zbrastira para,mbrapa) se cilin operacion po e zgjedh
            
            int dyHpasira = sTekstiHyres.IndexOf("  ");         //gjene indeksin nese ka ndonje karakter 2 zbrastira apo 3 apo 4...            
            if (sTekstiHyres == "")                             //nese tekstihyres eshte i pambushur, dmth kur ai vetem shtyp enter   
            {
                Console.ForegroundColor = ConsoleColor.Red;      //i qasemi klases Console nepermes emrit dhe kalojme ne vetin e saj pastaj ja ndyshojm ngjyren
                Console.WriteLine("Ju lutemi, shkruani diqka");  //paralajmrojme klientin 
                Console.ResetColor();                            //e kthejme ngjyren ashtu siq eshte default nga konsola
                goto perseri;                                    //do te thote, detyrohet te shkoje te etiketa 'perseri'
            }
            else if (dyHpasira > 0)                             //nese ka gjete "  " sbashku ose me shume zbras. te stringu hyres ateher kete s'do ta lejojme
            {
                int sa = 2;                                      //nje variabel ndihmese vetem sa per ilustrim
                Console.ForegroundColor = ConsoleColor.Red;      //ndryshim ngjyre te parapvijes se tekstit
                Console.WriteLine("Teksti juaj ka {0} zbrastira(sebashku). Ju lutemi shkruani me vetem 1(nje) zbrastire\n", sa); //ilustrimi i shtypjes se formatizuar
                Console.ResetColor();                            //kgthe ngjyren
                goto perseri;                                    //dergo te 'perseri' dhe jepi mundesi prape te zgjedhe opsionin
            }
            ////--------------------------------------------------------------------------------------------------------------////
            //                                                                                                                  //
            //             këtu fillojnë METOAT SHTESE të cilat nuk varen nga Serveri, kthehen nga Klienti                      //
            //                                                                                                                  //
            ////--------------------------------------------------------------------------------------------------------------////

            else if (sTekstiHyres.ToLower().IndexOf("mesatarja") == 0)   // nsese indeksi 0 i stringut sTekstihyres eshte 'mesatarja' (pra nese fillon me te) 
            {     // -------- ne server kemi metoden e cila duhet te shkruhet mesatarja {hapsire} numri1 {presje,} numri2... dhe mundemi pakufi numra 
                int zbrastire = sTekstiHyres.Count(c => " ".Contains(Char.ToLower(c)));     //1
                if (zbrastire > 1)              //nje lloje validimi se sa zbrastira lejohen, sepse ketu nuk guxon te kete zbrastire mes notave
                    Console.WriteLine("Teksti juaj ka " + zbrastire + " zbrastira. Ju lutemi shkruani me vetem 1(nje) zbrastire\n");
                else
                    Console.WriteLine("Pergjigja: " + objMetodShtese.MESATARJA(sTekstiHyres));    //kthehet pergjigja me ndihmen e metodes mesatarja
                goto fundi;                                                                       //shko ne fund
            }
            else if (sTekstiHyres.ToLower().IndexOf("rendit") == 0)  //nese fillon fjala me 'rendit'... 
            {    // --------- TE KJO METODE KA 2 MUNDESI, renditje A-Z dhe Z-A (nese shkruaj 'renditr')            
                int zbrastire = sTekstiHyres.Count(c => " ".Contains(Char.ToLower(c)));     //ktu nuk guxon te kete ndarje tjera perpos nje mes tekstit rendit {haps} 1,3,2
                if (zbrastire > 1)                                                          //Sa zbrastira ka! Ky eshte nje lloje validimi se sa zbrastira lejohen
                    Console.WriteLine("Teksti juaj ka " + zbrastire + " zbrastira. Ju lutemi shkruani me vetem 1(nje) zbrastire\n");
                else
                    Console.WriteLine("Renditja eshte: " + objMetodShtese.RENDIT(sTekstiHyres) + "\n");  //thirre metoden
                goto fundi;
            }
            else if (sTekstiHyres.ToLower().IndexOf("fiek") == 0)
            {
                string linku = objMetodShtese.FIEK(sTekstiHyres);       //metoda na kthen tipin string, ne e barazojme ate me str. linkun 
                System.Diagnostics.Process.Start(linku);                //me kete komande ne fillojme nje proces, meqenese parametri eshte link hapet ne browser default te pc-s

               goto fundi;
            }

            socketKlienti.Send(Encoding.ASCII.GetBytes(sTekstiHyres));  //Dergimi i Kerkeses permes socketKlientit            


            ////--------------------------------------------------------------------------------------------------------------////
            //|                                                                                                                |//
            //|                               Ktu fillon pranimi i pergjigjes nga serveri                                      |//
            //|                                                                                                                |//
            ////--------------------------------------------------------------------------------------------------------------////
            byte[] data = new byte[128];                                    //bajt maximal 128
            try
            {
                int recivedDataLength = socketKlienti.Receive(data);        //gjatesia e mesazhit
                string edhenangaserveri = Encoding.ASCII.GetString(data, 0, recivedDataLength);//ruajtja e rezultatit te kthyer nga serveri ne stringun 'edhenangaserveri'
                Console.ForegroundColor = ConsoleColor.Yellow;              //pergjigjet do te na vine me ngjyre te verdhe
                Console.WriteLine("Përgjigjja: " + edhenangaserveri);       //shtypet pergjigja e serverit
            }
            catch (SocketException ErrorExep)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Gjatë komunikimit me Server ka ndodhë ky gabim: \n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ErrorExep);
                Console.ResetColor();
            }
            socketKlienti.Shutdown(SocketShutdown.Both);                    //Nderprerja e dergimi,pranimit nepermes socketKlientit
            socketKlienti.Close();                                          //Mbyllja e 'scoketKlienti' lidhjes

     fundi: Console.ForegroundColor = ConsoleColor.Blue;            //ndryshim ngjyre te tekstit
            Console.Write("A keni perfunduar?[Po/Ndonjë] "); //Mundesi per ta nderprer punen e kilientit
            Console.ResetColor();                                   //kthimi i ngjyres default te consoles

            PergjigjePerMbyllje = Console.ReadLine();               //lexo fjalen qe shkruan klienti
            if (PergjigjePerMbyllje.ToLower() != "po")
                goto perseri;//Mundson qe te kthehemi n e fillim te kodit, nese klienti nuk ka shtypur "po"            
            else return;
        }
        ////-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-\////
        //\\                                                                                                              //\\
        //                      KLASA  METODATSHTES  E  CILA  PERMBANE  METODAT  E  PAVARURA  NGA  SERVERI                  //
        //\\                                                                                                              //\\
        ////-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-/\-\////
        class METODATSHTESE
        {
            public string MESATARJA(string edhena)         //Metoda pranon numra te pafundem (aq sa shkruan shfrytezuesi ',')  
            {
                string[] hyrja = edhena.Split(' ');        //le te ndahet stekstihyres ne 2pjes,  hyrja[0]=mesatarja,  hyrja[1]=notat me presje
                string[] nota = hyrja[1].Split(',');       //te ndahet hyrja[1] ne aq pjese sa ka presje 
                double t = 0, mes;                         //var. ndihmese
                int nrPresjeve = hyrja[1].Count(c => ",".Contains(Char.ToLower(c)));   //numro presjet qe jane brenda ksaj
                int numrat = nrPresjeve + 1;               // 1,2,3     me i marr aq sa jane numra
                for (int i = 0; i < numrat; i++)
                {
                    try
                    {
                        t += Convert.ToDouble(nota[i]);    //provo me kthy ne double pjesen e notave dhe shtoja variables 't'
                    }
                    catch (Exception gabim)                //nese prova deshton ateher shfaqet gabimi
                    {
                        return "Gabim gjatë konvertimit të notes " + gabim;
                    }
                }
                mes = t / numrat;                           //mesatarja eshte shuma nda per pjeset
                return mes.ToString();                      //kthe si vlere kthyese string kete mesatare
            }

            public string RENDIT(string edhena)            //Metoda ka 2 mundesi renditje revers dhe A-Z
            {
                List<string> Vargu = new List<string>();   //Obj liste per shkak manipulimit me lehte me te, e perdorim me mbushe me radhen qe na jep klienti
                string[] hyrja = edhena.Split(' ');        //le te ndahet stekstihyres ne 2pjes,  hyrja[0]=rendit,  hyrja[1]=radhitja me presje
                string[] radha = hyrja[1].Split(',');      //te ndahet hyrja[1] ne aq pjese sa ka presje 
                string kerkesa = "";
                int nrPresjeve = hyrja[1].Count(c => ",".Contains(Char.ToLower(c)));   //numro presjet qe jane brenda ksaj
                int VarguIArritur = nrPresjeve + 1;       // emri1,aemri2,gemri3     me i marr aq sa eshte vargu me emrime
                for (int i = 0; i < VarguIArritur; i++)
                {
                    Vargu.Add(radha[i]);                  //mbushe vargun me fjalet qe klienti deshiron t'i radhise
                }
                if (hyrja[0] == "rendit")                //nese klienti ka shkruajtur vetem 'rendit'
                    Vargu.Sort();                        //sortohet nga A-Z
                else if (hyrja[0] == "renditr")          //nese klienti ka shkruajtur fjalen 'renditr' ateher rendit mbrapsht Z-A
                { Vargu.Sort(); Vargu.Reverse(); }       //sortohet nga Z-A,, por nuk mundet drejtperdrejti, njehere duhet A-Z pastaj Z-A

                for (int i = 0; i < nrPresjeve; i++)     //me kete for tani e shtypim
                {
                    kerkesa += Vargu[i] + ",";
                }
                kerkesa = kerkesa + Vargu[nrPresjeve];
                return kerkesa.ToString();               //te kthehet kjjo pergjigje ne klinet
            }

            public string FIEK(string edhena)              //kjo metode eshte krijuar per qellim te hapjes se faqes se fakultetit me lehte, me shpejte
            {
                string url = "";
                string[] ardhja = edhena.Split(' ');            //ndaje te dhenen te ne (ne kete rast) dy pjese te cilat jane: ardhja[0] ardhja[1]

                if (ardhja[1] == "rezultatet")
                    url = "http://fiek.uni-pr.edu/Shpallje-dhe-rezultate-%281%29/Bachelor/Rezultatet.aspx";
                else if (ardhja[1] == "sems")
                    url = "https://notimi.uni-pr.edu";
                else if (ardhja[1] == "orari")
                    url = "http://fiek.uni-pr.edu/Shpallje-dhe-rezultate-%281%29/Bachelor/Orari-i-ligjeratave-%281%29.aspx";
                else if (ardhja[1] == "syllabusi")
                    url = "http://fiek.uni-pr.edu/Shpallje-dhe-rezultate-%281%29/Bachelor/Syllabuset.aspx";
                else
                    url = "www.fiek.uni-pr.edu";

                return url.ToString();
            }

        }
    }
}

