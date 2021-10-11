
namespace Estudo
{
    partial class frenteCaixa
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
            this.label1 = new System.Windows.Forms.Label();
            this.listProd = new System.Windows.Forms.ListBox();
            this.picProd = new System.Windows.Forms.PictureBox();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.tbnomeProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo do Produto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listProd
            // 
            this.listProd.FormattingEnabled = true;
            this.listProd.ItemHeight = 15;
            this.listProd.Location = new System.Drawing.Point(356, 45);
            this.listProd.Name = "listProd";
            this.listProd.Size = new System.Drawing.Size(423, 334);
            this.listProd.TabIndex = 1;
            // 
            // picProd
            // 
            this.picProd.Location = new System.Drawing.Point(37, 174);
            this.picProd.Name = "picProd";
            this.picProd.Size = new System.Drawing.Size(256, 241);
            this.picProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProd.TabIndex = 3;
            this.picProd.TabStop = false;
            // 
            // tbcodigo
            // 
            this.tbcodigo.Location = new System.Drawing.Point(144, 45);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(125, 23);
            this.tbcodigo.TabIndex = 4;
            this.tbcodigo.TextChanged += new System.EventHandler(this.tbcodigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(423, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total";
            // 
            // tbtotal
            // 
            this.tbtotal.Location = new System.Drawing.Point(484, 392);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(160, 23);
            this.tbtotal.TabIndex = 6;
            // 
            // tbnomeProd
            // 
            this.tbnomeProd.Location = new System.Drawing.Point(144, 92);
            this.tbnomeProd.Name = "tbnomeProd";
            this.tbnomeProd.Size = new System.Drawing.Size(125, 23);
            this.tbnomeProd.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome do Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(494, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lista de Produtos";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(37, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 259);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagem do Produto";
            // 
            // frenteCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(842, 508);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbnomeProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.picProd);
            this.Controls.Add(this.listProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frenteCaixa";
            this.Text = "Frente de Caixa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listProd;
        private System.Windows.Forms.PictureBox picProd;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.TextBox tbnomeProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

