
namespace Bron
{
    partial class BronForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginu = new System.Windows.Forms.TextBox();
            this.rateu = new System.Windows.Forms.ComboBox();
            this.houru = new System.Windows.Forms.ComboBox();
            this.placeu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя пользователя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите тариф";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(168, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Забронировать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(53, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выберите кол-во часов";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(57, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Выберите место";
            // 
            // loginu
            // 
            this.loginu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginu.Location = new System.Drawing.Point(57, 56);
            this.loginu.Multiline = true;
            this.loginu.Name = "loginu";
            this.loginu.Size = new System.Drawing.Size(206, 27);
            this.loginu.TabIndex = 6;
            // 
            // rateu
            // 
            this.rateu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rateu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rateu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rateu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateu.FormattingEnabled = true;
            this.rateu.Items.AddRange(new object[] {
            "Standart",
            "Pro",
            "Vip"});
            this.rateu.Location = new System.Drawing.Point(57, 120);
            this.rateu.Name = "rateu";
            this.rateu.Size = new System.Drawing.Size(206, 27);
            this.rateu.TabIndex = 7;
            this.rateu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // houru
            // 
            this.houru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.houru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.houru.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.houru.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.houru.FormattingEnabled = true;
            this.houru.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.houru.Location = new System.Drawing.Point(57, 210);
            this.houru.Name = "houru";
            this.houru.Size = new System.Drawing.Size(206, 27);
            this.houru.TabIndex = 8;
            this.houru.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // placeu
            // 
            this.placeu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.placeu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.placeu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.placeu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeu.FormattingEnabled = true;
            this.placeu.Items.AddRange(new object[] {
            "1-Standart",
            "2-Standart",
            "3-Standart",
            "4-Standart",
            "5-Standart",
            "6-Pro",
            "7-Pro",
            "8-Pro",
            "9-Pro",
            "10-Vip",
            "11-Vip",
            "12-Vip",
            "13-Vip",
            "14-Vip",
            "15-Vip"});
            this.placeu.Location = new System.Drawing.Point(57, 287);
            this.placeu.Name = "placeu";
            this.placeu.Size = new System.Drawing.Size(206, 27);
            this.placeu.TabIndex = 9;
            // 
            // BronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(449, 459);
            this.Controls.Add(this.placeu);
            this.Controls.Add(this.houru);
            this.Controls.Add(this.rateu);
            this.Controls.Add(this.loginu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "BronForm";
            this.Text = "BronForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginu;
        private System.Windows.Forms.ComboBox rateu;
        private System.Windows.Forms.ComboBox houru;
        private System.Windows.Forms.ComboBox placeu;
    }
}