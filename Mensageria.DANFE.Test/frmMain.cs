using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Mensageria.DANFE.Class.SchemaXML.XML310;

namespace Mensageria.DANFE.Test
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFileName_Click(object sender, EventArgs e)
        {
            var res = openFileDialog1.ShowDialog();
            switch (res)
            {
                case DialogResult.OK:
                    txtFileName.Text = openFileDialog1.FileName;
                    break;
                default:
                    MessageBox.Show("Please choose a xml file");
                    break;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnDanfe_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFileName.Text))
            {
                var fs = new FileStream(txtFileName.Text, FileMode.Open);
                TextReader reader = new StreamReader(fs);
                var pdfFile = Path.GetFileNameWithoutExtension(txtFileName.Text) + ".pdf";
                var service = new Danfe(reader, false);
                var pdf = service.GetPdfBytes();
                var generatedFile = string.Format(Path.Combine(Environment.CurrentDirectory, pdfFile ));
                File.WriteAllBytes(generatedFile, pdf);
                fs.Close();
                Process.Start(generatedFile);
            }
        }
    }
}
