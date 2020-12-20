
using System;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace Herramientas_Discord
{
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
        }

        public static void sendWebHook(string URL, string msg, string username)
        {
            Http.Post(URL, new NameValueCollection()
            {
                {
                    "username",
                    username
                },
                {
                    "content",
                    msg
                }
            });
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                if (textBox2.Text == "")
                    MessageBox.Show("Coloca el Nombre!");
                if (textBox3.Text == "")
                    MessageBox.Show("Coloca el Mensaje!");
                else if (textBox1.Text == "")
                    MessageBox.Show("Coloca tu WebHook!");
                else
                {
                    sendWebHook(textBox1.Text, textBox3.Text, textBox2.Text);
                    MessageBox.Show("Mensaje Enviado correctamente!");

                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abriendose Ayuda! Cierra este Mensaje para que se abra Correctamente");
            Form Ayuda = new Ayuda();
            Ayuda.Show();
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abriendose Creditos! Cierra este Mensaje para que se abra Correctamente");
            Form Creditos = new Creditos();
            Creditos.Show();
        }

        private void embedsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Embeds Proximamente...");
        }
    }
}
