namespace Pomodoro.CSharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnsim = new System.Windows.Forms.Button();
            this.btnnao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "        Bom Dia\r\n\r\nVamos Começar !!!";
            // 
            // btnsim
            // 
            this.btnsim.Location = new System.Drawing.Point(223, 362);
            this.btnsim.Name = "btnsim";
            this.btnsim.Size = new System.Drawing.Size(75, 23);
            this.btnsim.TabIndex = 1;
            this.btnsim.Text = "Sim";
            this.btnsim.UseVisualStyleBackColor = true;
            this.btnsim.Click += new System.EventHandler(this.btnsim_Click);
            // 
            // btnnao
            // 
            this.btnnao.Location = new System.Drawing.Point(348, 362);
            this.btnnao.Name = "btnnao";
            this.btnnao.Size = new System.Drawing.Size(75, 23);
            this.btnnao.TabIndex = 2;
            this.btnnao.Text = "Não";
            this.btnnao.UseVisualStyleBackColor = true;
            this.btnnao.Click += new System.EventHandler(this.btnnao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pomodoro.CSharp.Properties.Resources.productivity_pomodoro;
            this.pictureBox1.Location = new System.Drawing.Point(93, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(680, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnnao);
            this.Controls.Add(this.btnsim);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsim;
        private System.Windows.Forms.Button btnnao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

