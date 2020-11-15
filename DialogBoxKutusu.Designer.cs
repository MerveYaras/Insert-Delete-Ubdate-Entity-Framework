namespace Ürün_CRUD
{
    partial class DialogBoxKutusu
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
            this.lblHata = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnEvet = new System.Windows.Forms.Button();
            this.btnHayır = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHata.Location = new System.Drawing.Point(12, 19);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(109, 39);
            this.lblHata.TabIndex = 0;
            this.lblHata.Text = "label1";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(55, 88);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(35, 13);
            this.lblMesaj.TabIndex = 1;
            this.lblMesaj.Text = "label1";
            // 
            // btnEvet
            // 
            this.btnEvet.Location = new System.Drawing.Point(19, 135);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(75, 23);
            this.btnEvet.TabIndex = 2;
            this.btnEvet.Text = "Evet";
            this.btnEvet.UseVisualStyleBackColor = true;
            this.btnEvet.Click += new System.EventHandler(this.btnEvet_Click);
            // 
            // btnHayır
            // 
            this.btnHayır.Location = new System.Drawing.Point(100, 135);
            this.btnHayır.Name = "btnHayır";
            this.btnHayır.Size = new System.Drawing.Size(75, 23);
            this.btnHayır.TabIndex = 3;
            this.btnHayır.Text = "Hayır";
            this.btnHayır.UseVisualStyleBackColor = true;
            this.btnHayır.Click += new System.EventHandler(this.btnHayır_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 229);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHayır);
            this.Controls.Add(this.btnEvet);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblHata);
            this.Name = "DialogBox";
            this.Text = "DialogBox";
            this.Load += new System.EventHandler(this.DialogBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnEvet;
        private System.Windows.Forms.Button btnHayır;
        private System.Windows.Forms.Button btnCancel;
    }
}