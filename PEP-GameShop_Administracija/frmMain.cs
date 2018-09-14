using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PEP_GameShop_Administracija.Korisnik;
using PEP_GameShop_Administracija.UlazRobe;
namespace PEP_GameShop_Administracija
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
          
        }

        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnikNovi frm = new frmKorisnikNovi(null);
            frm.Show();
        }

        private void poImenuIPrezimenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPretraga frm = new frmPretraga();
            frm.Show();
        }

        private void noviProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProizvodi frm = new frmProizvodi();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string prijavljeniKOrisnik = global.prijavljenKorisnik.Ime + " " + global.prijavljenKorisnik.Prezime;
            PrijavljeniKorisnikLabel.Text = prijavljeniKOrisnik;

            
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPretragaProizvoda frm = new frmPretragaProizvoda();
            frm.ShowDialog();
        }

        private void nabavkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UlazRobe.FrmUlazRobe frm = new FrmUlazRobe();
            frm.ShowDialog();
        }

        private void prodajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Izvještaji.frmProdaja frm = new Izvještaji.frmProdaja();

            //frm.Show();
        }

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pregledSkladištaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSkladistePregled frm = new frmSkladistePregled();
            frm.ShowDialog();
        }

        private void izvještajiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proizvodiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Izvještaji.frmProizvodiIzvjestaj frm = new Izvještaji.frmProizvodiIzvjestaj();
            frm.ShowDialog();
        }

        private void dodajNovuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recenzije.frmDodajRecenziju frm = new Recenzije.frmDodajRecenziju();
            frm.ShowDialog();
        }

        private void dodajAukcijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aukcija.frmDodajAukciju frm = new Aukcija.frmDodajAukciju();
            frm.ShowDialog();
        }

        private void pretražiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recenzije.frmPretragaRecenzija frm = new Recenzije.frmPretragaRecenzija();
            frm.ShowDialog();
        }

        private void pretragaPoCijeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UlazRobe.frmPretragaPoCijeni frm = new frmPretragaPoCijeni();
            frm.ShowDialog();
        }

        private void pretragaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Aukcija.frmAukcijePretragaPoDatumu frm = new Aukcija.frmAukcijePretragaPoDatumu();
            frm.ShowDialog();
        }

        private void pretragaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Zahtjevi.frmPretragaZahtjevaNaziv frm = new Zahtjevi.frmPretragaZahtjevaNaziv();
            frm.ShowDialog();
        }

        private void pregledSkladištaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSkladistePregled frm = new frmSkladistePregled();
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Izlaz.frmIzlaz frm = new Izlaz.frmIzlaz();
            frm.ShowDialog();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        

        private void sviProizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvještaji.frmProizvodiIzvjestaj frm = new Izvještaji.frmProizvodiIzvjestaj();
            frm.ShowDialog();
        }

        private void poVrstiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvještaji.frmIgreVrsta frm = new Izvještaji.frmIgreVrsta();
            frm.ShowDialog();
        }

        private void poDatumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvještaji.frmProdajaPoDatumu frm = new Izvještaji.frmProdajaPoDatumu();
            frm.ShowDialog();
        }

        private void brojGlasovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvještaji.frmZahtjeviGlasovi frm = new Izvještaji.frmZahtjeviGlasovi();
            frm.ShowDialog();
        }

        private void ponudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aukcija.frmPonude frm = new Aukcija.frmPonude();
            frm.ShowDialog();
        }

        
    }
}
