using Microsoft.Win32;
using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Diagnostics;
//using System.Drawing;
using System.IO;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace XAMPP_FixAriaError
{
    public partial class frmAriaRepair : Form
    {
        // 2 variabelen aanmaken voor controle geldigheid installatie
        private bool validInstallFound = false;
        private string validInstallLocation = "";
        public frmAriaRepair()
        {
            InitializeComponent();
        }
        private void checkInstallLocation(string installLocation, bool showMessage = true)
        {
            string uninstallLocation = installLocation + "\\uninstall.exe";
            string controlLocation = installLocation + "\\xampp-control.exe";
            lblXAMPPLocation.Text = installLocation;
            if (!File.Exists(controlLocation))
            {
                // Ongeldige installatie!
                validInstallFound = false;
                validInstallLocation = "";
                btnRepair.Enabled = false;
                lblXAMPPLocation.ForeColor = System.Drawing.Color.Red;
                btnEditLocation.Enabled = true;
                btnEditLocation.Visible = true;
                lblXAMPPVersion.Text = "<< niet gevonden >>";
                if (showMessage)
                {
                    MessageBox.Show("Geen geldige installatie gevonden!\nHeb je XAMPP verplaatst?\n\nKlik dadelijk op ✏️ om de juiste locatie van xampp-control.exe te kiezen.", "Kies een map", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                // Geldige installatie!
                validInstallFound = true;
                validInstallLocation = installLocation;
                RegistryKey fixKey = Registry.CurrentUser.CreateSubKey(@"Software\MartyMcVry\XAMPPFix");
                fixKey.SetValue("InstallLocation", installLocation);
                btnRepair.Enabled = true;
                lblXAMPPLocation.ForeColor = System.Drawing.Color.Black;
                btnEditLocation.Enabled = false;
                btnEditLocation.Visible = false;
                if (File.Exists(uninstallLocation))
                {
                    lblXAMPPVersion.Text = FileVersionInfo.GetVersionInfo(uninstallLocation).ProductVersion;
                }
                else
                {
                    lblXAMPPVersion.Text = "<< kan versie niet ophalen >>";
                }
            }
        }
        private void frmAriaRepair_Load(object sender, EventArgs e)
        {
            // Eerst kijken we in de registersleutel van dit programma
            RegistryKey fixKey = Registry.CurrentUser.OpenSubKey(@"Software\MartyMcVry\XAMPPFix");
            // Er is ook de sleutel van XAMPP zelf
            // 64bit modus! (compileren met 32bits geeft een onleesbare sleutel)
            RegistryKey xamppKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\xampp");

            // Nonsens-waarde voor locatie, die sowieso een foutmelding zal geven
            string checkLocation = @"M:\DezeMapBestaatNietTenzijJeDieManueelHebtGemaaktMaarDatIsCompleetNutteloos";
            lblXAMPPVersion.Text = "<< niet gevonden >>";
            lblXAMPPLocation.Text = "<< niet gevonden >>";

            // Cascade: eerst kijken in eigen sleutel
            if (fixKey != null)
            {
                // XAMPP kan verplaatst zijn sinds de vorige keer;
                // installatie nog verifiëren ZONDER foutmelding (bool showMessage = false)
                // want er volgt hoe dan ook een tweede controle als deze niet slaagt
                checkLocation = fixKey.GetValue("InstallLocation").ToString();
                checkInstallLocation(checkLocation, false);
            }

            // Als er nog geen geldige installatie gevonden is, ga verder
            // Dit stukje wordt dus ook uitgevoerd als de eigen sleutel niet gevonden is (fixKey == null).
            if (!validInstallFound)
            {
                // Maar als de XAMPP-sleutel toch gevonden is, controleer die sleutel
                if (xamppKey != null)
                {
                    checkLocation = xamppKey.GetValue("InstallLocation").ToString();
                }

                // Wat is op dit punt de waarde van checkLocation?
                // - fixKey gevonden? --> locatie uit register van dit programma, maar geen probleem want
                //                        als die zou bestaan, zou dit stukje code niet worden uitgevoerd
                // - fixKey niet gevonden maar wel de xamppKey? --> locatie uit register van XAMPP
                // - fixKey niet gevonden en xamppKey niet gevonden? --> nonsens-locatie van eerder
                // Dit keer wél met foutmelding
                checkInstallLocation(checkLocation);
            }
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            // Toon dialoogvenster en kijk of op "ok" werd geklikt
            if (fbdInstallFolder.ShowDialog() == DialogResult.OK)
            {
                // controleer dan de locatie en geef indien nodig foutmelding
                checkInstallLocation(fbdInstallFolder.SelectedPath);
            }
        }

        private void fbdInstallFolder_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("You're on your own, bro. Good luck!", "T.U.P.");
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            string folder = validInstallLocation + "\\mysql\\data";
            // Controleer of de map bestaat
            if (Directory.Exists(folder))
            {
                // zoek naar de log-bestanden van ARIA
                string[] logFiles = Directory.GetFiles(folder, "aria_log*");
                MessageBox.Show(logFiles.Count().ToString() + " bestand(en) gevonden.","Bezig met reparatie...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (string logFilename in logFiles)
                {
                    File.Delete(logFilename);
                }
            }
            else
            {
                MessageBox.Show("De map waarin de ARIA-bestanden moeten staan, bestaat niet.\nInstalleer XAMPP gewoon opnieuw, dat is het makkelijkste!", "Oeps...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Programma mag gesloten worden nu
            Application.Exit();
        }
    }
}

