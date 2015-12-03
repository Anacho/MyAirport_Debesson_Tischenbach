using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service.Host
{
    public partial class Form1 : Form
    {
        private ServiceHost host = null;
        
        public Form1()
        {
            InitializeComponent();
            host_StateChanged(this, null);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(MyAirport.Serveur.Service));
            host.Closed += host_StateChanged;
            host.Closing += host_StateChanged;
            host.Faulted += host_StateChanged;
            host.Opening += host_StateChanged;
            host.Opened += host_StateChanged;

            this.textBox1.Text = host.State.ToString();
            LogLB.Items.Clear();
            LogLB.Items.Add("Création du service. ");
            host_StateChanged(this, null);

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (this.host.State == CommunicationState.Created)
            {
                try
                {
                    host.Open();
                    LogLB.Items.Clear();
                    foreach (var ep in this.host.Description.Endpoints)
                    {
                        this.LogLB.Items.Add(ep.Address);
                    }
                    this.textBox1.Text = host.State.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }   
            }
            else if (this.host.State == CommunicationState.Opened)
            {
                try
                {
                    host.Close();
                    LogLB.Items.Clear();
                    textBox1.Text = host.State.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            
        }

        void host_StateChanged(object sender, EventArgs e)
        {
            if (host != null)
            {
                switch (host.State)
                {
                    case CommunicationState.Opened:
                    {
                        this.OpenButton.Text = "Close";
                        this.OpenButton.Enabled = true;
                        break;
                    }
                       
                    case CommunicationState.Created:
                    {
                        this.OpenButton.Text = "Open";
                        this.OpenButton.Enabled = true;
                        break;
                    }

                    default:
                    {
                        this.OpenButton.Enabled = false;
                        break;
                    }
                }
                this.textBox1.Text = this.host.State.ToString();
                this.LogLB.Items.Add("Changement d'état : " + this.host.State);
            }
            else
            {
                this.OpenButton.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
