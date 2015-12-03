using System;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using Client.FormIhm.ServiceBagage;

namespace Client.FormIhm
{
    public partial class Form1 : Form
    {
        private readonly IService _service;
        public Form1()
        {
            _service = new ServiceClient();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (codeIATATB.Text != null)
            {
                try
                {
                    var bagage = _service.GetBagageByCodeIata(codeIATATB.Text);
                    if (bagage != null)
                    {
                        CompagnieTB.Text = bagage.Compagnie;
                        CompagnieTB.Enabled = false;
                        Ligne1TB.Text = bagage.Ligne;
                        Ligne1TB.Enabled = false;
                        Ligne2TB.Text = bagage.LigneAlpha.ToString();
                        Ligne2TB.Enabled = false;
                        JourExploitTB.Text = bagage.JourExploitation.ToString();
                        JourExploitTB.Enabled = false;
                        ItineraireTB.Text = bagage.Itineraire;
                        ItineraireTB.Enabled = false;
                        ClasseBagageTB.Text = bagage.ClasseBagage;
                        ClasseBagageTB.Enabled = false;
                        ContinuationCB.Checked = bagage.Continuation;
                        ContinuationCB.Enabled = false;
                        RushCB.Checked = bagage.Rush;
                        RushCB.Enabled = false;

                        AjouterBtn.Enabled = false;
                    }
                }
                catch (FaultException<MultiBagageException> mbe)
                {
                    string results = "Plusieurs bagages ont été trouvés. Voici les détails :\n\n" + mbe.Detail.resBagages.Aggregate<BagageDefinition, string>(null, (current, bagage) => current + printBagage(bagage));
                    MessageBox.Show(results, "Plusieurs bagages trouvés !", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (ApplicationException appEx)
                {
                    ContinuationCB.Checked = RushCB.Checked = false;
                    CompagnieTB.Enabled =
                        Ligne1TB.Enabled = Ligne2TB.Enabled = JourExploitTB.Enabled = ItineraireTB.Enabled =
                            ClasseBagageTB.Enabled = ContinuationCB.Enabled = RushCB.Enabled = true;
                    codeIATATB.Enabled = false;

                    CompagnieTB.Text =
                        Ligne1TB.Text =
                            Ligne2TB.Text = JourExploitTB.Text = ItineraireTB.Text = ClasseBagageTB.Text = "";

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Une erreur s’est produite.\nMerci de bien vouloir réessayer ultérieurement ou de contacter votre administrateur.", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            var bagage = new BagageDefinition();
            try
            {
                bagage.Compagnie = CompagnieTB.Text;
                bagage.ClasseBagage = ClasseBagageTB.Text;
                bagage.CodeIata = codeIATATB.Text;
                bagage.Rush = RushCB.Checked;
                bagage.Continuation = ContinuationCB.Checked;
                bagage.JourExploitation = short.Parse(JourExploitTB.Text);
                bagage.Ligne = string.IsNullOrEmpty(Ligne1TB.Text) ? Ligne2TB.Text : Ligne1TB.Text;
                bagage.Itineraire = ItineraireTB.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans la consistance des données. Les données saisies ne correspondent pas avec ce qui est attendu.", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            try
            { 
                int nbLignes = _service.CreateBagage(bagage);
                if (nbLignes == 1)
                {
                    MessageBox.Show("Bagage enregistré !", "Sauvegarde réussie", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else if (nbLignes == 0)
                {
                    MessageBox.Show("Une erreur est survenue lors de la création du bagage.", "Erreur !",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(
                        "Une action inattendue s'est produite. Contactez un administrateur de toute urgence.\n" +
                        nbLignes + " lignes ont été ajoutées.", "?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s’est produite.\nMerci de bien vouloir réessayer ultérieurement ou de contacter votre administrateur.", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            ContinuationCB.Checked = RushCB.Checked = false;
            CompagnieTB.Enabled = Ligne1TB.Enabled = Ligne2TB.Enabled = JourExploitTB.Enabled = ItineraireTB.Enabled = codeIATATB.Enabled =
                ClasseBagageTB.Enabled = ContinuationCB.Enabled = RushCB.Enabled = true;

            CompagnieTB.Text =
                       Ligne1TB.Text =
                           Ligne2TB.Text = JourExploitTB.Text = ItineraireTB.Text = ClasseBagageTB.Text = codeIATATB.Text = "";

            AjouterBtn.Enabled = true;
            AnnulerBtn.Enabled = true;
        }

        public string printBagage(BagageDefinition bag)
        {
            string str = "Code IATA : " + (NullIfEmpty(bag.CodeIata) ?? "N/D") + "\n";
            str += "ID bagage : " + (NullIfEmpty(bag.IdBagage.ToString()) ?? "N/D") + "\n";
            str += "Compagnie : " + (NullIfEmpty(bag.Compagnie) ?? "N/D") + "\n";
            str += "Ligne : " + ((NullIfEmpty(bag.Ligne) ?? NullIfEmpty(bag.LigneAlpha.ToString())) ?? "N/D") + "\n";
            str += "Date du vol : " + (NullIfEmpty(bag.DateVol.ToString(CultureInfo.CurrentCulture)) ?? "N/D") + "\n";
            str += "Itinéraire : " + (NullIfEmpty(bag.Itineraire) ?? "N/D") + "\n";
            str += "Classe bagage : " + (NullIfEmpty(bag.ClasseBagage) ?? "N/D") + "\n";
            str += "Continuation : " + (NullIfEmpty(bag.Continuation.ToString()) ?? "N/D") + "\n";
            str += "Rush : " + (NullIfEmpty(bag.Rush.ToString()) ?? "N/D") + "\n";
            str += "Jour d'exploitation : " + (NullIfEmpty(bag.JourExploitation.ToString()) ?? "N/D") + "\n\n";

            return str;
        }

        private string NullIfEmpty(string str)
        {
            return string.IsNullOrEmpty(str) ? null : str;
        }

    }
}
