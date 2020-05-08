using System;
using System.Windows.Forms;

namespace Factory01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string telefonmodeli;
        Fabrika fabrika = new Fabrika();
        private void ozellikleriGetir_Click(object sender, EventArgs e)
        {
            telefonmodeli = comboBoxTel.Text;
            Telefon telefon = fabrika.TelefonOlustur(telefonmodeli);
            listBoxTel.Items.Add(telefon.BilgiGoster());
        }

        
    }
}
