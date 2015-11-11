﻿using System;
using System.Windows.Forms;
using MyAirport.Pim.Entities;
using MyAirport.Pim.Model;

namespace Client.FormIhm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (codeIATATB.Text != null)
            {
                try
                {
                    var bagage = Factory.Model.GetBagage(codeIATATB.Text);
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
                        ClasseBagageTB.Enabled = false;;
                        ContinuationCB.Checked = bagage.Continuation;
                        ContinuationCB.Enabled = false;
                        RushCB.Checked = bagage.Rush;
                        RushCB.Enabled = false;

                        AjouterBtn.Enabled = false;
                    }
                }
                catch (ApplicationException appEx)
                {
                    CompagnieTB.Text =
                        Ligne1TB.Text =
                            Ligne2TB.Text = JourExploitTB.Text = ItineraireTB.Text = ClasseBagageTB.Text = "";

                    ContinuationCB.Checked = RushCB.Checked = false;
                    CompagnieTB.Enabled = Ligne1TB.Enabled = Ligne2TB.Enabled = JourExploitTB.Enabled = ItineraireTB.Enabled =
                        ClasseBagageTB.Enabled = ContinuationCB.Enabled = RushCB.Enabled = true;
                    codeIATATB.Enabled = false;
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
            try
            {
                var bagage = new BagageDefinition
                {
                    Compagnie = CompagnieTB.Text,
                    ClasseBagage = ClasseBagageTB.Text,
                    CodeIata = codeIATATB.Text,
                    Rush = RushCB.Checked,
                    Continuation = ContinuationCB.Checked,
                    JourExploitation = short.Parse(JourExploitTB.Text),
                    Ligne = string.IsNullOrEmpty(Ligne1TB.Text) ? Ligne2TB.Text : Ligne1TB.Text,
                    Itineraire = ItineraireTB.Text
                };
                int nbLignes = Factory.Model.CreateBagage(bagage);
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
            finally
            {
                //CompagnieTB.Text =
                //           Ligne1TB.Text =
                //               Ligne2TB.Text = JourExploitTB.Text = ItineraireTB.Text = ClasseBagageTB.Text = codeIATATB.Text = "";

                //ContinuationCB.Checked = RushCB.Checked = false;
                //CompagnieTB.Enabled = Ligne1TB.Enabled = Ligne2TB.Enabled = JourExploitTB.Enabled = ItineraireTB.Enabled = codeIATATB.Enabled = 
                //    ClasseBagageTB.Enabled = ContinuationCB.Enabled = RushCB.Enabled = true;
            }
        }
    }
}