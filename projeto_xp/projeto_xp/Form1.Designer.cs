namespace projeto_xp
{
    partial class Form
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
            this.Cor = new System.Windows.Forms.Button();
            this.TT = new System.Windows.Forms.TextBox();
            this.BoxT = new System.Windows.Forms.TextBox();
            this.Del = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cor
            // 
            this.Cor.Location = new System.Drawing.Point(12, 72);
            this.Cor.Name = "Cor";
            this.Cor.Size = new System.Drawing.Size(75, 23);
            this.Cor.TabIndex = 0;
            this.Cor.Text = "Corfirm";
            this.Cor.UseVisualStyleBackColor = true;
            this.Cor.Click += new System.EventHandler(this.Cor_Click);
            // 
            // TT
            // 
            this.TT.Location = new System.Drawing.Point(12, 30);
            this.TT.Name = "TT";
            this.TT.Size = new System.Drawing.Size(100, 20);
            this.TT.TabIndex = 1;
            // 
            // BoxT
            // 
            this.BoxT.Location = new System.Drawing.Point(143, 30);
            this.BoxT.Multiline = true;
            this.BoxT.Name = "BoxT";
            this.BoxT.Size = new System.Drawing.Size(100, 114);
            this.BoxT.TabIndex = 2;
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(12, 101);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(57, 24);
            this.Del.TabIndex = 3;
            this.Del.Text = "Delete";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(207, 1);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(36, 23);
            this.test.TabIndex = 4;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 157);
            this.Controls.Add(this.test);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.BoxT);
            this.Controls.Add(this.TT);
            this.Controls.Add(this.Cor);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto XP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cor;
        private System.Windows.Forms.TextBox TT;
        private System.Windows.Forms.TextBox BoxT;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button test;
    }
}

