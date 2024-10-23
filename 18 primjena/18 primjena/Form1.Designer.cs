namespace _18_primjena
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRunProgram = new System.Windows.Forms.Button();
            this.checkBoxShowProgramAction = new System.Windows.Forms.CheckBox();
            this.textBoxProgramName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProgramDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxPrograms = new System.Windows.Forms.ComboBox();
            this.groupBoxRunProgram = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxRunProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnRunProgram
            // 
            this.btnRunProgram.Location = new System.Drawing.Point(203, 36);
            this.btnRunProgram.Name = "btnRunProgram";
            this.btnRunProgram.Size = new System.Drawing.Size(117, 38);
            this.btnRunProgram.TabIndex = 2;
            this.btnRunProgram.Text = "Run program";
            this.btnRunProgram.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowProgramAction
            // 
            this.checkBoxShowProgramAction.AutoSize = true;
            this.checkBoxShowProgramAction.Checked = true;
            this.checkBoxShowProgramAction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowProgramAction.Location = new System.Drawing.Point(46, 216);
            this.checkBoxShowProgramAction.Name = "checkBoxShowProgramAction";
            this.checkBoxShowProgramAction.Size = new System.Drawing.Size(182, 24);
            this.checkBoxShowProgramAction.TabIndex = 4;
            this.checkBoxShowProgramAction.Text = "show program action";
            this.checkBoxShowProgramAction.UseVisualStyleBackColor = true;
            // 
            // textBoxProgramName
            // 
            this.textBoxProgramName.Location = new System.Drawing.Point(10, 67);
            this.textBoxProgramName.Name = "textBoxProgramName";
            this.textBoxProgramName.Size = new System.Drawing.Size(142, 26);
            this.textBoxProgramName.TabIndex = 6;
            this.textBoxProgramName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(232, 39);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 35);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Program description:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxProgramDescription
            // 
            this.textBoxProgramDescription.Location = new System.Drawing.Point(10, 145);
            this.textBoxProgramDescription.Multiline = true;
            this.textBoxProgramDescription.Name = "textBoxProgramDescription";
            this.textBoxProgramDescription.Size = new System.Drawing.Size(177, 117);
            this.textBoxProgramDescription.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxPrograms);
            this.groupBox1.Controls.Add(this.btnRunProgram);
            this.groupBox1.Location = new System.Drawing.Point(41, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 102);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run a program";
            // 
            // comboBoxPrograms
            // 
            this.comboBoxPrograms.FormattingEnabled = true;
            this.comboBoxPrograms.Items.AddRange(new object[] {
            "Notepad",
            "Paint"});
            this.comboBoxPrograms.Location = new System.Drawing.Point(20, 36);
            this.comboBoxPrograms.Name = "comboBoxPrograms";
            this.comboBoxPrograms.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPrograms.TabIndex = 3;
            this.comboBoxPrograms.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrograms_SelectedIndexChanged);
            // 
            // groupBoxRunProgram
            // 
            this.groupBoxRunProgram.Controls.Add(this.label1);
            this.groupBoxRunProgram.Controls.Add(this.textBoxProgramName);
            this.groupBoxRunProgram.Controls.Add(this.label4);
            this.groupBoxRunProgram.Controls.Add(this.textBoxProgramDescription);
            this.groupBoxRunProgram.Controls.Add(this.btnClear);
            this.groupBoxRunProgram.Location = new System.Drawing.Point(41, 264);
            this.groupBoxRunProgram.Name = "groupBoxRunProgram";
            this.groupBoxRunProgram.Size = new System.Drawing.Size(430, 289);
            this.groupBoxRunProgram.TabIndex = 12;
            this.groupBoxRunProgram.TabStop = false;
            this.groupBoxRunProgram.Text = "Program control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Program name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 612);
            this.Controls.Add(this.groupBoxRunProgram);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxShowProgramAction);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxRunProgram.ResumeLayout(false);
            this.groupBoxRunProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnRunProgram;
        private System.Windows.Forms.CheckBox checkBoxShowProgramAction;
        private System.Windows.Forms.TextBox textBoxProgramName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProgramDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxPrograms;
        private System.Windows.Forms.GroupBox groupBoxRunProgram;
        private System.Windows.Forms.Label label1;
    }
}

