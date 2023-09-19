
namespace airport
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnLReservation = new System.Windows.Forms.Button();
            this.btnRefund1 = new System.Windows.Forms.Button();
            this.btnTranslate1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLRefund = new System.Windows.Forms.Button();
            this.btnLTranslate = new System.Windows.Forms.Button();
            this.btnReservation1 = new System.Windows.Forms.Button();
            this.btnTranslate2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(-2, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(159, 109);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // btnLReservation
            // 
            this.btnLReservation.FlatAppearance.BorderSize = 0;
            this.btnLReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLReservation.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLReservation.Location = new System.Drawing.Point(184, 36);
            this.btnLReservation.Name = "btnLReservation";
            this.btnLReservation.Size = new System.Drawing.Size(104, 31);
            this.btnLReservation.TabIndex = 1;
            this.btnLReservation.Text = "예매 ▼";
            this.btnLReservation.UseVisualStyleBackColor = true;
            this.btnLReservation.Click += new System.EventHandler(this.btnLReservation_Click);
            // 
            // btnRefund1
            // 
            this.btnRefund1.FlatAppearance.BorderSize = 0;
            this.btnRefund1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefund1.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefund1.Location = new System.Drawing.Point(457, 75);
            this.btnRefund1.Name = "btnRefund1";
            this.btnRefund1.Size = new System.Drawing.Size(77, 30);
            this.btnRefund1.TabIndex = 7;
            this.btnRefund1.Text = "항공권 환불";
            this.btnRefund1.UseVisualStyleBackColor = true;
            this.btnRefund1.Visible = false;
            this.btnRefund1.Click += new System.EventHandler(this.btnRefund1_Click);
            // 
            // btnTranslate1
            // 
            this.btnTranslate1.FlatAppearance.BorderSize = 0;
            this.btnTranslate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslate1.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTranslate1.Location = new System.Drawing.Point(316, 75);
            this.btnTranslate1.Name = "btnTranslate1";
            this.btnTranslate1.Size = new System.Drawing.Size(104, 27);
            this.btnTranslate1.TabIndex = 5;
            this.btnTranslate1.Text = "항공권 확인/변경";
            this.btnTranslate1.UseVisualStyleBackColor = true;
            this.btnTranslate1.Visible = false;
            this.btnTranslate1.Click += new System.EventHandler(this.btnTranslate1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(556, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(24, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "x";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnLRefund
            // 
            this.btnLRefund.FlatAppearance.BorderSize = 0;
            this.btnLRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLRefund.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLRefund.Location = new System.Drawing.Point(448, 36);
            this.btnLRefund.Name = "btnLRefund";
            this.btnLRefund.Size = new System.Drawing.Size(104, 31);
            this.btnLRefund.TabIndex = 3;
            this.btnLRefund.Text = "환불 ▼";
            this.btnLRefund.UseVisualStyleBackColor = true;
            this.btnLRefund.Click += new System.EventHandler(this.btnLRefund_Click);
            // 
            // btnLTranslate
            // 
            this.btnLTranslate.FlatAppearance.BorderSize = 0;
            this.btnLTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLTranslate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLTranslate.Location = new System.Drawing.Point(316, 36);
            this.btnLTranslate.Name = "btnLTranslate";
            this.btnLTranslate.Size = new System.Drawing.Size(104, 31);
            this.btnLTranslate.TabIndex = 2;
            this.btnLTranslate.Text = "확인 및 변경 ▼";
            this.btnLTranslate.UseVisualStyleBackColor = true;
            this.btnLTranslate.Click += new System.EventHandler(this.btnLTranslate_Click);
            // 
            // btnReservation1
            // 
            this.btnReservation1.FlatAppearance.BorderSize = 0;
            this.btnReservation1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation1.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReservation1.Location = new System.Drawing.Point(196, 75);
            this.btnReservation1.Name = "btnReservation1";
            this.btnReservation1.Size = new System.Drawing.Size(75, 28);
            this.btnReservation1.TabIndex = 4;
            this.btnReservation1.Text = "항공권 예매";
            this.btnReservation1.UseVisualStyleBackColor = true;
            this.btnReservation1.Visible = false;
            this.btnReservation1.Click += new System.EventHandler(this.btnReservation1_Click);
            // 
            // btnTranslate2
            // 
            this.btnTranslate2.FlatAppearance.BorderSize = 0;
            this.btnTranslate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslate2.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTranslate2.Location = new System.Drawing.Point(311, 108);
            this.btnTranslate2.Name = "btnTranslate2";
            this.btnTranslate2.Size = new System.Drawing.Size(115, 26);
            this.btnTranslate2.TabIndex = 6;
            this.btnTranslate2.Text = "회원정보 확인/변경";
            this.btnTranslate2.UseVisualStyleBackColor = true;
            this.btnTranslate2.Visible = false;
            this.btnTranslate2.Click += new System.EventHandler(this.btnTranslate2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(577, 437);
            this.Controls.Add(this.btnReservation1);
            this.Controls.Add(this.btnLTranslate);
            this.Controls.Add(this.btnLRefund);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTranslate1);
            this.Controls.Add(this.btnRefund1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnLReservation);
            this.Controls.Add(this.btnTranslate2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnLReservation;
        private System.Windows.Forms.Button btnRefund1;
        private System.Windows.Forms.Button btnTranslate1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLRefund;
        private System.Windows.Forms.Button btnLTranslate;
        private System.Windows.Forms.Button btnReservation1;
        private System.Windows.Forms.Button btnTranslate2;
    }
}