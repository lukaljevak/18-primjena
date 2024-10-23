using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_primjena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnRunProgram_Click(object sender, EventArgs e)
        {
            string selectedProgram = comboBoxPrograms.SelectedItem.ToString();
            if (selectedProgram == "Notepad")
            {
                System.Diagnostics.Process.Start("notepad.exe");
            }
            else if (selectedProgram == "Paint")
            {
                System.Diagnostics.Process.Start("mspaint.exe");
            }
        }
        private void checkBoxShowProgramAction_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxRunProgram.Visible = checkBoxShowProgramAction.Checked;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxProgramName.Clear();
            textBoxProgramDescription.Clear();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FormaText formaText = new FormaText();
            formaText.ShowDialog();
            textBoxProgramName.Text = formaText.ProgramName;
            textBoxProgramDescription.Text = formaText.ProgramDescription;
        }

        private void comboBoxPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
