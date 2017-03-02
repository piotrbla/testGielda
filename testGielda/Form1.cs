using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;

namespace testGielda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ICSharpCode.SharpZipLib.Zip.u
            //System.IO.Compression.ZipFile.ExtractToDirectory("omegacgl.zip", "exctract");
            FastZip fz = new FastZip();
            fz.ExtractZip("omegacgl.zip", "extract", null);
        }
    }
}
