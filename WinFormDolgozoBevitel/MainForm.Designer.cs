
namespace WinFormDolgozoBevitel
{
    partial class MainForm
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
            this.lbDolgozok = new System.Windows.Forms.ListBox();
            this.btnBevitelForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDolgozok
            // 
            this.lbDolgozok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDolgozok.FormattingEnabled = true;
            this.lbDolgozok.Location = new System.Drawing.Point(0, 0);
            this.lbDolgozok.Name = "lbDolgozok";
            this.lbDolgozok.Size = new System.Drawing.Size(165, 257);
            this.lbDolgozok.TabIndex = 0;
            // 
            // btnBevitelForm
            // 
            this.btnBevitelForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBevitelForm.Location = new System.Drawing.Point(0, 234);
            this.btnBevitelForm.Name = "btnBevitelForm";
            this.btnBevitelForm.Size = new System.Drawing.Size(165, 23);
            this.btnBevitelForm.TabIndex = 1;
            this.btnBevitelForm.Text = "Bevitel";
            this.btnBevitelForm.UseVisualStyleBackColor = true;
            this.btnBevitelForm.Click += new System.EventHandler(this.btnBevitelForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 257);
            this.Controls.Add(this.btnBevitelForm);
            this.Controls.Add(this.lbDolgozok);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDolgozok;
        private System.Windows.Forms.Button btnBevitelForm;
    }
}

