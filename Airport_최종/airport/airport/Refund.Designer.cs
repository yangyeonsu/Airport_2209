
namespace airport
{
    partial class Refund
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Refund));
            this.gbRefund = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.gvRefund = new System.Windows.Forms.DataGridView();
            this.lblChild = new System.Windows.Forms.Label();
            this.txtChild = new System.Windows.Forms.TextBox();
            this.lblAdult = new System.Windows.Forms.Label();
            this.txtAdult = new System.Windows.Forms.TextBox();
            this.lblArrive = new System.Windows.Forms.Label();
            this.txtArrive = new System.Windows.Forms.TextBox();
            this.btnRefund = new System.Windows.Forms.Button();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.txtLeave = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbRefund.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRefund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRefund
            // 
            this.gbRefund.AutoSize = true;
            this.gbRefund.Controls.Add(this.label2);
            this.gbRefund.Controls.Add(this.btnCheck);
            this.gbRefund.Controls.Add(this.label1);
            this.gbRefund.Controls.Add(this.txtCost);
            this.gbRefund.Controls.Add(this.gvRefund);
            this.gbRefund.Controls.Add(this.lblChild);
            this.gbRefund.Controls.Add(this.txtChild);
            this.gbRefund.Controls.Add(this.lblAdult);
            this.gbRefund.Controls.Add(this.txtAdult);
            this.gbRefund.Controls.Add(this.lblArrive);
            this.gbRefund.Controls.Add(this.txtArrive);
            this.gbRefund.Controls.Add(this.btnRefund);
            this.gbRefund.Controls.Add(this.lblDeparture);
            this.gbRefund.Controls.Add(this.txtLeave);
            this.gbRefund.Controls.Add(this.lblName);
            this.gbRefund.Controls.Add(this.txtName);
            this.gbRefund.Controls.Add(this.lblPhone);
            this.gbRefund.Controls.Add(this.txtPhone);
            this.gbRefund.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbRefund.Location = new System.Drawing.Point(15, 49);
            this.gbRefund.Name = "gbRefund";
            this.gbRefund.Size = new System.Drawing.Size(441, 399);
            this.gbRefund.TabIndex = 58;
            this.gbRefund.TabStop = false;
            this.gbRefund.Text = "환불창";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(77, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "(ex.01012345678)";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Navy;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheck.Location = new System.Drawing.Point(334, 149);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(70, 29);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "확인";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(313, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "원";
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.SkyBlue;
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCost.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCost.ForeColor = System.Drawing.Color.Red;
            this.txtCost.Location = new System.Drawing.Point(243, 353);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(70, 15);
            this.txtCost.TabIndex = 63;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gvRefund
            // 
            this.gvRefund.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.gvRefund.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvRefund.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvRefund.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.gvRefund.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvRefund.GridColor = System.Drawing.Color.SkyBlue;
            this.gvRefund.Location = new System.Drawing.Point(32, 171);
            this.gvRefund.Name = "gvRefund";
            this.gvRefund.ReadOnly = true;
            this.gvRefund.RowHeadersVisible = false;
            this.gvRefund.RowTemplate.Height = 23;
            this.gvRefund.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvRefund.Size = new System.Drawing.Size(372, 55);
            this.gvRefund.TabIndex = 62;
            this.gvRefund.Visible = false;
            // 
            // lblChild
            // 
            this.lblChild.AutoSize = true;
            this.lblChild.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblChild.Location = new System.Drawing.Point(92, 331);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(29, 13);
            this.lblChild.TabIndex = 60;
            this.lblChild.Text = "소인";
            // 
            // txtChild
            // 
            this.txtChild.AllowDrop = true;
            this.txtChild.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtChild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChild.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChild.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtChild.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtChild.Location = new System.Drawing.Point(93, 346);
            this.txtChild.Name = "txtChild";
            this.txtChild.Size = new System.Drawing.Size(54, 23);
            this.txtChild.TabIndex = 61;
            // 
            // lblAdult
            // 
            this.lblAdult.AutoSize = true;
            this.lblAdult.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAdult.Location = new System.Drawing.Point(31, 331);
            this.lblAdult.Name = "lblAdult";
            this.lblAdult.Size = new System.Drawing.Size(29, 13);
            this.lblAdult.TabIndex = 58;
            this.lblAdult.Text = "대인";
            // 
            // txtAdult
            // 
            this.txtAdult.AllowDrop = true;
            this.txtAdult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAdult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdult.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAdult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAdult.Location = new System.Drawing.Point(32, 346);
            this.txtAdult.Name = "txtAdult";
            this.txtAdult.Size = new System.Drawing.Size(54, 23);
            this.txtAdult.TabIndex = 59;
            // 
            // lblArrive
            // 
            this.lblArrive.AutoSize = true;
            this.lblArrive.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblArrive.Location = new System.Drawing.Point(31, 282);
            this.lblArrive.Name = "lblArrive";
            this.lblArrive.Size = new System.Drawing.Size(40, 13);
            this.lblArrive.TabIndex = 56;
            this.lblArrive.Text = "도착지";
            // 
            // txtArrive
            // 
            this.txtArrive.AllowDrop = true;
            this.txtArrive.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtArrive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArrive.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArrive.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtArrive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtArrive.Location = new System.Drawing.Point(32, 298);
            this.txtArrive.Name = "txtArrive";
            this.txtArrive.Size = new System.Drawing.Size(372, 23);
            this.txtArrive.TabIndex = 11;
            // 
            // btnRefund
            // 
            this.btnRefund.BackColor = System.Drawing.Color.Navy;
            this.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefund.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefund.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefund.Location = new System.Drawing.Point(334, 345);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(70, 29);
            this.btnRefund.TabIndex = 4;
            this.btnRefund.Text = "환불하기";
            this.btnRefund.UseVisualStyleBackColor = false;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDeparture.Location = new System.Drawing.Point(31, 233);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(40, 13);
            this.lblDeparture.TabIndex = 54;
            this.lblDeparture.Text = "출발지";
            // 
            // txtLeave
            // 
            this.txtLeave.AllowDrop = true;
            this.txtLeave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtLeave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLeave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLeave.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLeave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtLeave.Location = new System.Drawing.Point(32, 249);
            this.txtLeave.Name = "txtLeave";
            this.txtLeave.Size = new System.Drawing.Size(372, 23);
            this.txtLeave.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(31, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 52;
            this.lblName.Text = "승객 이름";
            // 
            // txtName
            // 
            this.txtName.AllowDrop = true;
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtName.Location = new System.Drawing.Point(32, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(372, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPhone.Location = new System.Drawing.Point(31, 94);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(51, 13);
            this.lblPhone.TabIndex = 35;
            this.lblPhone.Text = "전화번호";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(32, 110);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(372, 23);
            this.txtPhone.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(140, 442);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(449, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Refund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(471, 500);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbRefund);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Refund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay";
            this.gbRefund.ResumeLayout(false);
            this.gbRefund.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRefund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRefund;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnCheck;
        public System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Label lblChild;
        public System.Windows.Forms.TextBox txtChild;
        private System.Windows.Forms.Label lblAdult;
        public System.Windows.Forms.TextBox txtAdult;
        private System.Windows.Forms.Label lblArrive;
        public System.Windows.Forms.TextBox txtArrive;
        private System.Windows.Forms.Label lblDeparture;
        public System.Windows.Forms.TextBox txtLeave;
        private System.Windows.Forms.DataGridView gvRefund;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}