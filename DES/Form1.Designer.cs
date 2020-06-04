namespace DES
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
            this.shifrButton = new System.Windows.Forms.Button();
            this.shifrInputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shifrOutputTextBox = new System.Windows.Forms.TextBox();
            this.deshifrOutputTextBox = new System.Windows.Forms.TextBox();
            this.deshifrInputTextBox = new System.Windows.Forms.TextBox();
            this.deshifrButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cnLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьЗашифрованныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.kNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kNumericUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // shifrButton
            // 
            this.shifrButton.Location = new System.Drawing.Point(35, 6);
            this.shifrButton.Name = "shifrButton";
            this.shifrButton.Size = new System.Drawing.Size(101, 23);
            this.shifrButton.TabIndex = 0;
            this.shifrButton.Text = "Шифровать";
            this.shifrButton.UseVisualStyleBackColor = true;
            this.shifrButton.Click += new System.EventHandler(this.shifrButton_Click);
            // 
            // shifrInputTextBox
            // 
            this.shifrInputTextBox.AcceptsReturn = true;
            this.shifrInputTextBox.AcceptsTab = true;
            this.shifrInputTextBox.AllowDrop = true;
            this.shifrInputTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shifrInputTextBox.Location = new System.Drawing.Point(9, 48);
            this.shifrInputTextBox.Multiline = true;
            this.shifrInputTextBox.Name = "shifrInputTextBox";
            this.shifrInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.shifrInputTextBox.Size = new System.Drawing.Size(299, 323);
            this.shifrInputTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Входные данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выходные данные";
            // 
            // shifrOutputTextBox
            // 
            this.shifrOutputTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shifrOutputTextBox.Location = new System.Drawing.Point(314, 48);
            this.shifrOutputTextBox.Multiline = true;
            this.shifrOutputTextBox.Name = "shifrOutputTextBox";
            this.shifrOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.shifrOutputTextBox.Size = new System.Drawing.Size(302, 323);
            this.shifrOutputTextBox.TabIndex = 1;
            this.shifrOutputTextBox.TextChanged += new System.EventHandler(this.shifrOutputTextBox_TextChanged);
            // 
            // deshifrOutputTextBox
            // 
            this.deshifrOutputTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deshifrOutputTextBox.Location = new System.Drawing.Point(319, 48);
            this.deshifrOutputTextBox.Multiline = true;
            this.deshifrOutputTextBox.Name = "deshifrOutputTextBox";
            this.deshifrOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.deshifrOutputTextBox.Size = new System.Drawing.Size(300, 323);
            this.deshifrOutputTextBox.TabIndex = 1;
            // 
            // deshifrInputTextBox
            // 
            this.deshifrInputTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deshifrInputTextBox.Location = new System.Drawing.Point(6, 48);
            this.deshifrInputTextBox.Multiline = true;
            this.deshifrInputTextBox.Name = "deshifrInputTextBox";
            this.deshifrInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.deshifrInputTextBox.Size = new System.Drawing.Size(307, 323);
            this.deshifrInputTextBox.TabIndex = 1;
            // 
            // deshifrButton
            // 
            this.deshifrButton.Location = new System.Drawing.Point(35, 6);
            this.deshifrButton.Name = "deshifrButton";
            this.deshifrButton.Size = new System.Drawing.Size(90, 23);
            this.deshifrButton.TabIndex = 0;
            this.deshifrButton.Text = "Дешифровать";
            this.deshifrButton.UseVisualStyleBackColor = true;
            this.deshifrButton.Click += new System.EventHandler(this.deshifrButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выходные данные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Входные данные";
            // 
            // cnLabel
            // 
            this.cnLabel.AutoSize = true;
            this.cnLabel.Location = new System.Drawing.Point(48, 34);
            this.cnLabel.Name = "cnLabel";
            this.cnLabel.Size = new System.Drawing.Size(0, 13);
            this.cnLabel.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(17, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.toolStripComboBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 27);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьЗашифрованныйToolStripMenuItem});
            this.файлToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.файлToolStripMenuItem.Text = "Режим";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьЗашифрованныйToolStripMenuItem
            // 
            this.сохранитьЗашифрованныйToolStripMenuItem.Name = "сохранитьЗашифрованныйToolStripMenuItem";
            this.сохранитьЗашифрованныйToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.сохранитьЗашифрованныйToolStripMenuItem.Text = "Сохранить зашифрованный";
            this.сохранитьЗашифрованныйToolStripMenuItem.Click += new System.EventHandler(this.сохранитьЗашифрованныйToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "ECB",
            "CBC",
            "CFB",
            "OFB"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 496);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.kNumericUpDown);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.shifrOutputTextBox);
            this.tabPage1.Controls.Add(this.shifrButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.shifrInputTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1076, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шифровка";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "K:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // kNumericUpDown
            // 
            this.kNumericUpDown.Location = new System.Drawing.Point(380, 399);
            this.kNumericUpDown.Name = "kNumericUpDown";
            this.kNumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.kNumericUpDown.TabIndex = 5;
            this.kNumericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.kNumericUpDown.ValueChanged += new System.EventHandler(this.kNumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ключ:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(516, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deshifrOutputTextBox);
            this.tabPage2.Controls.Add(this.deshifrButton);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.deshifrInputTextBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1076, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дешифровка";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            this.tabPage2.Validated += new System.EventHandler(this.tabPage2_Validated);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 508);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.cnLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kNumericUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shifrButton;
        private System.Windows.Forms.TextBox shifrInputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shifrOutputTextBox;
        private System.Windows.Forms.TextBox deshifrOutputTextBox;
        private System.Windows.Forms.TextBox deshifrInputTextBox;
        private System.Windows.Forms.Button deshifrButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cnLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьЗашифрованныйToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown kNumericUpDown;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

