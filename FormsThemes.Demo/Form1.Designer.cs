using FormsThemes.Controls;

namespace FormsThemes.Demo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1=new GroupBox();
            checkBox1=new ThemedCheckBox();
            radioButton1=new ThemedRadioButton();
            listBox1=new ThemedListBox();
            comboBox2=new ThemedComboBox();
            textBox1=new ThemedTextBox();
            textBox2=new ThemedTextBox();
            textBox3=new ThemedTextBox();
            themedButton1=new ThemedButton();
            themedButton2=new ThemedButton();
            themedButton3=new ThemedButton();
            tabControl1=new TabControl();
            tabPage1=new TabPage();
            tabPage2=new TabPage();
            themedRadioButton1=new ThemedRadioButton();
            flowLayoutPanel1=new FlowLayoutPanel();
            themedButton4=new ThemedButton();
            tabControl1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location=new Point(598, 19);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new Size(190, 100);
            groupBox1.TabIndex=2;
            groupBox1.TabStop=false;
            groupBox1.Text="groupBox1";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize=true;
            checkBox1.Checked=true;
            checkBox1.CheckState=CheckState.Checked;
            checkBox1.Location=new Point(12, 12);
            checkBox1.Name="checkBox1";
            checkBox1.Size=new Size(83, 19);
            checkBox1.TabIndex=3;
            checkBox1.Text="checkBox1";
            checkBox1.UseVisualStyleBackColor=true;
            checkBox1.CheckedChanged+=checkBox1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize=true;
            radioButton1.Location=new Point(3, 3);
            radioButton1.Name="radioButton1";
            radioButton1.Size=new Size(94, 19);
            radioButton1.TabIndex=4;
            radioButton1.TabStop=true;
            radioButton1.Text="radioButton1";
            radioButton1.UseVisualStyleBackColor=true;
            // 
            // listBox1
            // 
            listBox1.DrawMode=DrawMode.OwnerDrawFixed;
            listBox1.FormattingEnabled=true;
            listBox1.ItemHeight=15;
            listBox1.Items.AddRange(new object[] { "a", "b", "c", "d", "a", "b", "c", "d", "a", "b", "c", "d", "a", "b", "c", "d", "a", "b", "c", "d", "a", "b", "c", "d", "a", "b", "c", "d", "a", "b", "c", "d", "a", "b", "c", "d", "a", "b", "c", "d", "a", "b", "c", "d" });
            listBox1.Location=new Point(598, 125);
            listBox1.Name="listBox1";
            listBox1.Size=new Size(190, 199);
            listBox1.TabIndex=7;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled=true;
            comboBox2.Items.AddRange(new object[] { "item A", "item B", "item C" });
            comboBox2.Location=new Point(3, 28);
            comboBox2.Name="comboBox2";
            comboBox2.Size=new Size(121, 24);
            comboBox2.TabIndex=9;
            // 
            // textBox1
            // 
            textBox1.BackColor=Color.Transparent;
            textBox1.Location=new Point(130, 28);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(100, 23);
            textBox1.TabIndex=10;
            // 
            // textBox2
            // 
            textBox2.BackColor=Color.Transparent;
            textBox2.Location=new Point(3, 58);
            textBox2.Multiline=true;
            textBox2.Name="textBox2";
            textBox2.Size=new Size(205, 41);
            textBox2.TabIndex=11;
            // 
            // textBox3
            // 
            textBox3.BackColor=Color.Transparent;
            textBox3.Location=new Point(3, 105);
            textBox3.Name="textBox3";
            textBox3.ReadOnly=true;
            textBox3.Size=new Size(205, 23);
            textBox3.TabIndex=12;
            textBox3.Text="abcasdased";
            // 
            // themedButton1
            // 
            themedButton1.Location=new Point(97, 113);
            themedButton1.Name="themedButton1";
            themedButton1.Size=new Size(149, 23);
            themedButton1.TabIndex=13;
            themedButton1.Text="Windows 7";
            themedButton1.UseVisualStyleBackColor=true;
            themedButton1.Click+=themedButton1_Click;
            // 
            // themedButton2
            // 
            themedButton2.Location=new Point(97, 142);
            themedButton2.Name="themedButton2";
            themedButton2.Size=new Size(149, 23);
            themedButton2.TabIndex=14;
            themedButton2.Text="Windows 10";
            themedButton2.UseVisualStyleBackColor=true;
            themedButton2.Click+=themedButton2_Click;
            // 
            // themedButton3
            // 
            themedButton3.Location=new Point(97, 171);
            themedButton3.Name="themedButton3";
            themedButton3.Size=new Size(149, 23);
            themedButton3.TabIndex=15;
            themedButton3.Text="Windows 11";
            themedButton3.UseVisualStyleBackColor=true;
            themedButton3.Click+=themedButton3_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location=new Point(252, 215);
            tabControl1.Name="tabControl1";
            tabControl1.SelectedIndex=0;
            tabControl1.Size=new Size(340, 183);
            tabControl1.TabIndex=16;
            // 
            // tabPage1
            // 
            tabPage1.Location=new Point(4, 24);
            tabPage1.Name="tabPage1";
            tabPage1.Padding=new Padding(3);
            tabPage1.Size=new Size(332, 155);
            tabPage1.TabIndex=0;
            tabPage1.Text="tabPage1";
            tabPage1.UseVisualStyleBackColor=true;
            // 
            // tabPage2
            // 
            tabPage2.Location=new Point(4, 24);
            tabPage2.Name="tabPage2";
            tabPage2.Padding=new Padding(3);
            tabPage2.Size=new Size(332, 155);
            tabPage2.TabIndex=1;
            tabPage2.Text="tabPage2";
            tabPage2.UseVisualStyleBackColor=true;
            // 
            // themedRadioButton1
            // 
            themedRadioButton1.AutoSize=true;
            themedRadioButton1.Location=new Point(103, 3);
            themedRadioButton1.Name="themedRadioButton1";
            themedRadioButton1.Size=new Size(138, 19);
            themedRadioButton1.TabIndex=0;
            themedRadioButton1.TabStop=true;
            themedRadioButton1.Text="themedRadioButton1";
            themedRadioButton1.UseVisualStyleBackColor=true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(radioButton1);
            flowLayoutPanel1.Controls.Add(themedRadioButton1);
            flowLayoutPanel1.Controls.Add(comboBox2);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(textBox2);
            flowLayoutPanel1.Controls.Add(textBox3);
            flowLayoutPanel1.Location=new Point(252, 19);
            flowLayoutPanel1.Name="flowLayoutPanel1";
            flowLayoutPanel1.Size=new Size(340, 175);
            flowLayoutPanel1.TabIndex=17;
            // 
            // themedButton4
            // 
            themedButton4.Location=new Point(97, 200);
            themedButton4.Name="themedButton4";
            themedButton4.Size=new Size(149, 23);
            themedButton4.TabIndex=18;
            themedButton4.Text="Windows 10 Dark";
            themedButton4.UseVisualStyleBackColor=true;
            themedButton4.Click+=themedButton4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(themedButton4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tabControl1);
            Controls.Add(themedButton3);
            Controls.Add(themedButton2);
            Controls.Add(themedButton1);
            Controls.Add(listBox1);
            Controls.Add(checkBox1);
            Controls.Add(groupBox1);
            Name="Form1";
            Text="Form1";
            tabControl1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private ThemedCheckBox checkBox1;
        private ThemedRadioButton radioButton1;
        private ThemedListBox listBox1;
        private ThemedComboBox comboBox2;
        private ThemedTextBox textBox1;
        private ThemedTextBox textBox2;
        private ThemedTextBox textBox3;
        private ThemedButton themedButton1;
        private ThemedButton themedButton2;
        private ThemedButton themedButton3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ThemedRadioButton themedRadioButton1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ThemedButton themedButton4;
    }
}