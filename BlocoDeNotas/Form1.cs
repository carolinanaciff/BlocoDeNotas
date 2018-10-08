using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocoDeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveClick(object sender, EventArgs e)
        {
            
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog1.ShowDialog();

            string varExtensao = System.IO.Path.GetExtension(saveFileDialog1.FileName);

            MessageBox.Show("Salvo com sucesso.");
        }

        private void SaveOk(object sender, CancelEventArgs e)
        {
            string caminho = saveFileDialog1.FileName;
            File.WriteAllText(caminho, textBox1.Text);
            
        }

        private void AbrirClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.ShowDialog();
        }

        private void OpenOk(object sender, CancelEventArgs e)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
            textBox1.Paste(sr.ReadToEnd());
        }
    }
}
