using Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Crypto.Hash;

namespace Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "MD5 : " + Hash.Generate(Algorithm.MD5, @"123") + Environment.NewLine;
            textBox1.Text = textBox1.Text + "RIPEMD160 : " + Hash.Generate(Algorithm.RIPEMD160, @"123") + Environment.NewLine;
            textBox1.Text = textBox1.Text + "SHA1 : " + Hash.Generate(Algorithm.SHA1, @"123") + Environment.NewLine;
            textBox1.Text = textBox1.Text + "SHA256 : " + Hash.Generate(Algorithm.SHA256, @"123") + Environment.NewLine;
            textBox1.Text = textBox1.Text + "SHA384 : " + Hash.Generate(Algorithm.SHA384, @"123") + Environment.NewLine;
            textBox1.Text = textBox1.Text + "SHA512 : " + Hash.Generate(Algorithm.SHA512, @"123") + Environment.NewLine;
            textBox1.Text = textBox1.Text + "CRC32 : " + Hash.Generate(Algorithm.CRC32, @"123") + Environment.NewLine;
            textBox1.Text = textBox1.Text + "CRC32Slice16 : " + Hash.Generate(Algorithm.CRC32Slice16, @"123") + Environment.NewLine;
            textBox1.Text = textBox1.Text + "CRC32Slice8 : " + Hash.Generate(Algorithm.CRC32Slice8, @"123") + Environment.NewLine;
         //   textBox1.Text = textBox1.Text + "CRC64 : " + Hash.Generate(Algorithm.CRC64, @"123") + Environment.NewLine;
            textBox1.Text = textBox1.Text + "Elf32 : " + Hash.Generate(Algorithm.Elf32, @"123") + Environment.NewLine;

            textBox1.Text = textBox1.Text + "Fnv1a64 : " + Hash.Generate(Algorithm.Fnv1a64, @"123") + Environment.NewLine;
            textBox1.Text = textBox1.Text + "Fnv1a32 : " + Hash.Generate(Algorithm.Fnv1a32, @"123") + Environment.NewLine;
            textBox1.Text = textBox1.Text + "adler32 : " + Hash.Generate(Algorithm.Adler32, @"123") + Environment.NewLine;
            textBox1.Text = textBox1.Text + "Tiger : " + Hash.Generate(Algorithm.Tiger, @"123") + Environment.NewLine;
            textBox1.Text = textBox1.Text + "CRC16 : " + Hash.Generate(Algorithm.CRC16, @"123") + Environment.NewLine;
            textBox1.Text = textBox1.Text + "whirpool : " + Hash.Generate(Algorithm.whirpool, @"123") + Environment.NewLine;

         
        }
    }
}
