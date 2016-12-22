using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace FIEK_TCP_klienti_WFORM
{
    public partial class Klienti : Form
    {
        public Klienti()
        {
            InitializeComponent();
        }
        string localhost = "127.0.0.1";                     // localhost i nenkuptuar/ perveq kur shfrytezuesi deshiron ta ndyrshoje ate
        int porti = 7000;                                   //porti i nenkuptuar
        METODATSHTESE objMetodShtese = new METODATSHTESE();
        char a = 'ë';

        public Klienti(string lh, string p)   
        {
             IPAddress address;
             if (IPAddress.TryParse(lh, out address))     //validimi i ip      
                 this.localhost = lh;
             else MessageBox.Show("Gabim në konvertim të IP-s", "Njoftim", MessageBoxButtons.OK, MessageBoxIcon.Error);
             this.porti = Convert.ToInt32(p);           
             InitializeComponent();
             timer1.Start();
        }   

        private void btnPastro_Click(object sender, EventArgs e)
        {
            txtKerkesa.Clear();                             //te fshihet kerkesa
            cboZgjedheMetoden.SelectedIndex=-1;             //te fshihet zgjedhe metoden
        }
        string sTekstiHyres = "", ndihma = "";
        private void cboZgjedheMetoden_SelectedIndexChanged(object sender, EventArgs e)
        {
            info.Visible = true;
            if (cboZgjedheMetoden.SelectedIndex == 0)
            {
                txtKerkesa.Enabled = false;                //txtkerkesa slejohet
                sTekstiHyres = "ip";                       //dhe teksti hyres te shkoje IP
                txtKerkesa.Clear();                        //kerkessa duhet te jete e fshire
                ndihma = "Info: Metoda IP ju kthen IP-in e Hostit \r\nJu duhet të shtypni Dergo!";
            }
            else if (cboZgjedheMetoden.SelectedIndex == 1)
            {
                txtKerkesa.Enabled = false;               //kerkesa slejohet
                sTekstiHyres = "port";                    //duhet te shkoj fjala port
                txtKerkesa.Clear();                       //duhet te fhsihet kerkesa
                ndihma = "Info: Metoda PORT kthen PORT-in e Hostit \r\nJu duhet të shtypni Dergo!";
            }
            else if (cboZgjedheMetoden.SelectedIndex == 2)
            {
                txtKerkesa.Enabled = true;              //kerkesa lejohet
                sTekstiHyres = "zanore";                //dhe duhet te shkoj fjala zanore
                ndihma = "Info: Metoda ZANORE numron zanoret e fjalisë që shkruani ju. \r\nJu duhet të shkruani tek 'Kërkesa' fjalinë dhe pastaj të shtypni Dergo!";
            }
            else if (cboZgjedheMetoden.SelectedIndex == 3)
            {
                txtKerkesa.Enabled = true;             //lejohet kerekesa
                sTekstiHyres = "printo";                //dhe fjala printo
                ndihma = "Info: Metoda PRINTO bënë shtypjen e tekstit tuaj që shkruani, pastaj ju duhet të shtypni Dergo!";
            }
            else if (cboZgjedheMetoden.SelectedIndex == 4)
            {
                txtKerkesa.Enabled = false;
                sTekstiHyres = "host";                  //duhet te shkoj fjala host
                txtKerkesa.Clear();
                ndihma = "Info: Metoda HOST kthen emrin e HOSTit tuaj, shtypni Dergo!";
            }
            else if (cboZgjedheMetoden.SelectedIndex == 5)
            {
                txtKerkesa.Enabled = false;            //nuk lejohet kerkesa
                sTekstiHyres = "time";                  //dhe shkonfjala time
                txtKerkesa.Clear();
                ndihma = "Info: Metoda TIME kthen kohen aktuale, shtypni Dergo!";
            }
            else if (cboZgjedheMetoden.SelectedIndex == 6)
            {
                txtKerkesa.Enabled = false;
                sTekstiHyres = "keno";
                txtKerkesa.Clear();
                ndihma = "Info: Metoda KENO bënë shtypjen e 20 nr. random nga 1-80. Shtypni Dergo!";
            }
            else if (cboZgjedheMetoden.SelectedIndex == 7)
            {
                txtKerkesa.Enabled = true;
                sTekstiHyres = "konverto";
                ndihma = "Info: Metoda KONVERTO bënë konvertimin në fahrenheittocelsius, celsiustofahrenheit, celsiustokelvin... shtypni këtë kërkese dhe Dergo!";
            }
            else if (cboZgjedheMetoden.SelectedIndex == 8)
            {
                txtKerkesa.Enabled = true;
                sTekstiHyres = "faktoriel";
                ndihma = "Info: Metoda FAKTORIEL gjenë faktorielin e nr. Shkruani në 'kërkesë' nr. që dëshironi, pastaj Dergo!";
            }
            else if (cboZgjedheMetoden.SelectedIndex == 9)
            {
                txtKerkesa.Enabled = true;
                sTekstiHyres = "mesatarja";
                 ndihma="Info: Metoda MESATARJA gjenë mesataren e nr. Në 'kërkesë' shkruani nr. me presje që dëshironi t'i dini mesataren dhe shtyp Dergo!";
            }
            else if (cboZgjedheMetoden.SelectedIndex == 10)
            {
                txtKerkesa.Enabled = true;
                sTekstiHyres = "rendit";
                ndihma="Info: Metoda RENDIT rendit A-Z, në kërkesë shkruaj fjalët me presje(pazbrastire) dhe shtyp Dergo";
            }
            else if (cboZgjedheMetoden.SelectedIndex == 11)
            {
                txtKerkesa.Enabled = true;
                sTekstiHyres = "renditr";
                ndihma="Info: Metoda RENDITR rendit Z-A, në kërkesë shkruaj fjalët me presje(pazbrastire) dhe shtyp Dergo";
            }
            else if (cboZgjedheMetoden.SelectedIndex == 12)
            {
                txtKerkesa.Enabled = true;
                sTekstiHyres = "fiek";
                ndihma="Info: Metoda FIEK ka kto mundësi, në kërkesë shkruaj orari ose sems ose sollabusi ose rezultatet dhe shtyp Dergo";
            }
            txtInfo.Text = ndihma;
        }
        
        private void txtKerkesa_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (sTekstiHyres == "zanore" || sTekstiHyres == "fiek"
                        || sTekstiHyres == "rendit" || sTekstiHyres == "renditr")
            {
                //karakteret qe nuk jane shkronja kane kodin:
                //backspace = 8     //space 32
                //presja = 44
                if (((e.KeyChar < 65 || e.KeyChar > 90) && ( e.KeyChar < 96 || e.KeyChar > 122))
                                && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 32)
                {
                    e.Handled = true;
                }
            }
            else if (sTekstiHyres == "faktoriel")
            {
                //karakteret qe nuk jane numra kane kodin:
                // <48 dhe >57
                //backspace = 8
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
            else if (sTekstiHyres == "mesatarja") 
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44)
                {
                    e.Handled = true;
                }
            }
            
        }

        private void info_MouseHover(object sender, EventArgs e)
        {
            txtInfo.Visible = true;                 //info te behet e dukshme kur kalohet me maus permbi
        }

        private void info_MouseLeave(object sender, EventArgs e)
        {
            txtInfo.Visible = false;                //info te behet e padukshme kur largohet mausi
        }

        private void btnDergo_Click(object sender, EventArgs e)
        {
            Funksioni();                            //thirret funksioni
        }
        
        private void Funksioni()
        {
            sTekstiHyres += " "+txtKerkesa.Text.Trim();    //merr string-un(pa zbrastira para,mbrapa) se cilin operacion po e zgjedh
            if (txtPergjigja.Text != "")
                txtPergjigja.Text += "\r\n";
            txtPergjigja.Text += "KLIENTI kërkoi: " + sTekstiHyres;
            int dyHpasira = sTekstiHyres.IndexOf("  ");         //gjene indeksin nese ka ndonje karakter 2 zbrastira apo 3 apo 4...            
            if (sTekstiHyres == "")                             //nese tekstihyres eshte i pambushur, dmth kur ai vetem shtyp enter   
            {
                MessageBox.Show("Ju lutemi, shkruani diqka");  //paralajmrojme klientin 
                txtKerkesa.Focus();
            }
            else if (dyHpasira > 0)                             //nese ka gjete "  " sbashku ose me shume zbras. te stringu hyres ateher kete s'do ta lejojme
            {
                int sa = 2;
                MessageBox.Show(String.Format("Teksti juaj ka {0} zbrastira(sebashku). Ju lutemi shkruani me vetem 1(nje) zbrastire\n", sa),"Njoftim",MessageBoxButtons.OK,MessageBoxIcon.Information); //ilustrimi i shtypjes se formatizuar
                txtKerkesa.Focus();
            }
            ////--------------------------------------------------------------------------------------------------------------////
            //             këtu fillojnë METOAT SHTESE të cilat nuk varen nga Serveri, kthehen nga Klienti                      //
            ////--------------------------------------------------------------------------------------------------------------////

            else if (sTekstiHyres.ToLower().IndexOf("mesatarja") == 0)   // nsese indeksi 0 i stringut sTekstihyres eshte 'mesatarja' (pra nese fillon me te) 
            {     // -------- ne kemi metoden e cila duhet te shkruhet mesatarja {hapsire} numri1 {presje,} numri2... dhe mundemi pakufi numra 
                
                int zbrastire = sTekstiHyres.Count(c => " ".Contains(Char.ToLower(c)));     //1
                if (zbrastire > 1)              //nje lloje validimi se sa zbrastira lejohen, sepse ketu nuk guxon te kete zbrastire mes notave
                    MessageBox.Show("Teksti juaj ka " + zbrastire + " zbrastira. Ju lutemi shkruani me vetem 1(nje) zbrastire\n");
                else
                    txtPergjigja.Text += "\r\nMesatarja është " + objMetodShtese.MESATARJA(sTekstiHyres);    //kthehet pergjigja me ndihmen e metodes mesatarja
                
                goto fundi;
            }
            else if (sTekstiHyres.ToLower().IndexOf("rendit") == 0)  //nese fillon fjala me 'rendit'... 
            {    // --------- TE KJO METODE KA 2 MUNDESI, renditje A-Z dhe Z-A (nese shkruaj 'renditr')            
                int zbrastire = sTekstiHyres.Count(c => " ".Contains(Char.ToLower(c)));     //ktu nuk guxon te kete ndarje tjera perpos nje mes tekstit rendit {haps} 1,3,2
                if (zbrastire > 1)                                                          //Sa zbrastira ka! Ky eshte nje lloje validimi se sa zbrastira lejohen
                    MessageBox.Show("Teksti juaj ka " + zbrastire + " zbrastira. Ju lutemi shkruani me vetem 1(nje) zbrastire\n");
                else
                    txtPergjigja.Text += "\r\nRenditja është: " + objMetodShtese.RENDIT(sTekstiHyres) + "\n";  //thirre metoden                
                
                goto fundi;
            }
            else if (sTekstiHyres.ToLower().IndexOf("fiek") == 0)
            {
                string linku = objMetodShtese.FIEK(sTekstiHyres);       //metoda na kthen tipin string, ne e barazojme ate me str. linkun 
                System.Diagnostics.Process.Start(linku);                //me kete komande ne fillojme nje proces, meqenese parametri eshte link hapet ne browser default te pc-s
                goto fundi;
            }

            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(localhost), porti);     //krijimi i obj. IP PIKE FUNDORE dhe inicializimi
            Socket socketKlienti = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //Krijimi i nje socketi dhe inicializimi i tij

            try                                                 //per gabime, nese nuk mundet te konektohet do te behet 'catch' 
            {
                socketKlienti.Connect(ip);                      //me u konektu me at IP
            }
            catch (SocketException Errorex)                     //nese hyn kodi ketu, atehere tek 'TRY' eshte kthyer vlere false
            {
                MessageBox.Show("Dështoj lidhja me serverin, ka ndodhë ky gabim (" + Errorex + ")", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);  //tregon gabimin premes konsole-s
                return;                                         //dhe puna duhet te perfundoj ketu
            }

            socketKlienti.Send(Encoding.ASCII.GetBytes(sTekstiHyres));  //Dergimi i Kerkeses permes socketKlienti, kthehet ne bajta 
            
            ////--------------------------------------------------------------------------------------------------------------////
            //|                               Ktu fillon pranimi i pergjigjes nga serveri                                      |//
            ////--------------------------------------------------------------------------------------------------------------////
            byte[] data = new byte[128];                                    //bajt maximal 128
            try
            {
                int recivedDataLength = socketKlienti.Receive(data);        //gjatesia e mesazhit
                string edhenangaserveri = Encoding.ASCII.GetString(data, 0, recivedDataLength);//ruajtja e rezultatit te kthyer nga serveri ne stringun 'edhenangaserveri'
                txtPergjigja.Text += "\r\n" + edhenangaserveri;       //shtypet pergjigja e serverit
               
            }
            catch (SocketException ErrorExep)
            {
                MessageBox.Show("Gjatë komunikimit me Server ka ndodhë ky gabim: \n" + ErrorExep, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
            socketKlienti.Shutdown(SocketShutdown.Both);                    //Nderprerja e dergimi,pranimit nepermes socketKlientit
            socketKlienti.Close();                                          //Mbyllja e 'scoketKlienti' lidhjes
        fundi: txtPergjigja.Text += " ";                                       //vetem sa per perfundim te puneve te metodave te klientit
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
                int VarguIArritur = nrPresjeve + 1;       // emri1,aemri2,emri3     me i marr aq sa eshte vargu me emrime
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


        private void tstInfo_Click(object sender, EventArgs e)
        {
            if (menuInfo.Visible==true)            
                menuInfo.Visible = false;            
            else menuInfo.Visible = true;
        }

        private void tsdmbyll_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ngjyra1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMbushjaETedhenave.BackColor = Color.LightSteelBlue;
            pnlButonat.BackColor = Color.LightSteelBlue;
            pnlButonat2.BackColor = Color.LightSteelBlue;
            pnlPergjigja.BackColor = Color.LightSteelBlue;
        }

        private void mundesia2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMbushjaETedhenave.BackColor = Color.LightSkyBlue;
            pnlButonat.BackColor = Color.LightSkyBlue;
            pnlButonat2.BackColor = Color.LightSkyBlue;
            pnlPergjigja.BackColor = Color.LightSkyBlue;
        }

        private void mundesia3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMbushjaETedhenave.BackColor = Color.PaleGreen;
            pnlButonat.BackColor = Color.PaleGreen;
            pnlButonat2.BackColor = Color.PaleGreen;
            pnlPergjigja.BackColor = Color.PaleGreen;
        }

        private void mundesia4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMbushjaETedhenave.BackColor = Color.Orchid;
            pnlButonat.BackColor = Color.Orchid;
            pnlButonat2.BackColor = Color.Orchid;
            pnlPergjigja.BackColor = Color.Orchid;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tstKohaaktuale.Text = DateTime.Now.ToString("HH:mm:ss ");
        }
        int s = 0, m = 0, h = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            s++;
            if (s == 60)
            {
                m++;
                s = 0;
            }
            if (m == 60)
            {
                m = 0;
                h++;
            }
            if (h == 24)
            {
                timer2.Stop();       //this.Close()
            }
            string _s = Convert.ToString(s); string _m = Convert.ToString(m); string _h = Convert.ToString(h);
            //sepse konvertimi drejt  i nr.Tostring() nuk e jep gjithmon numrin por jep shkronjen ne vend nr
            tstKohaStartuese.Text = h + " : " + m + " : " + s;
        }







    }
}
