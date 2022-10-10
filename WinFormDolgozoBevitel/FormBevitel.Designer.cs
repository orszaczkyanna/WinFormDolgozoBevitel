
namespace WinFormDolgozoBevitel
{
    partial class FormBevitel
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
            this.tbNev = new System.Windows.Forms.TextBox();
            this.dtSzulIdo = new System.Windows.Forms.DateTimePicker();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolgozó neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolgozó születési ideje:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(175, 46);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(134, 20);
            this.tbNev.TabIndex = 2;
            // 
            // dtSzulIdo
            // 
            this.dtSzulIdo.Location = new System.Drawing.Point(175, 81);
            this.dtSzulIdo.Name = "dtSzulIdo";
            this.dtSzulIdo.Size = new System.Drawing.Size(187, 20);
            this.dtSzulIdo.TabIndex = 3;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(175, 137);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(92, 32);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Bevitel";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // FormBevitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 219);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dtSzulIdo);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBevitel";
            this.Text = "FormBevitel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.DateTimePicker dtSzulIdo;
        private System.Windows.Forms.Button btnInsert;
    }
}