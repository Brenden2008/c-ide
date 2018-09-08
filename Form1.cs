using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using Microsoft.CSharp;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter objWriter;
            objWriter = new System.IO.StreamWriter("code.txt", true);
            objWriter.WriteLine(textBox1.Text);
            objWriter.Close();
            var csc = new CSharpCodeProvider();
            string programPath = @"C:\Users\Valued Customer\Documents\Visual Studio 2017\Projects\WindowsFormsApp2\WindowsFormsApp2";
            var parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll" }, programPath, true)
            {
                GenerateExecutable = true
            };
            var code = @"code.txt";
            CompilerResults result = csc.CompileAssemblyFromSource(parameters, code);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
