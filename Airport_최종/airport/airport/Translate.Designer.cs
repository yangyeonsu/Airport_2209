
namespace airport
{
    partial class Translate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Translate));
            this.btnReservation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChild = new System.Windows.Forms.TextBox();
            this.txtAdult = new System.Windows.Forms.TextBox();
            this.lblChild = new System.Windows.Forms.Label();
            this.lblAdult = new System.Windows.Forms.Label();
            this.gvPassenger = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbLeave = new System.Windows.Forms.ComboBox();
            this.lblArrive = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLeave = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cbArrive = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPassenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReservation
            // 
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReservation.Location = new System.Drawing.Point(1, 12);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(189, 38);
            this.btnReservation.TabIndex = 50;
            this.btnReservation.Text = "Translate ▼";
            this.btnReservation.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(702, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtChild);
            this.groupBox1.Controls.Add(this.txtAdult);
            this.groupBox1.Controls.Add(this.lblChild);
            this.groupBox1.Controls.Add(this.lblAdult);
            this.groupBox1.Controls.Add(this.gvPassenger);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbLeave);
            this.groupBox1.Controls.Add(this.lblArrive);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblLeave);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.cbArrive);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(32, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 331);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservation Change";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(142, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "(ex.01012345678)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(487, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "승객";
            // 
            // txtChild
            // 
            this.txtChild.AllowDrop = true;
            this.txtChild.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtChild.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChild.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtChild.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtChild.Location = new System.Drawing.Point(617, 215);
            this.txtChild.Name = "txtChild";
            this.txtChild.Size = new System.Drawing.Size(39, 21);
            this.txtChild.TabIndex = 60;
            this.txtChild.Visible = false;
            // 
            // txtAdult
            // 
            this.txtAdult.AllowDrop = true;
            this.txtAdult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAdult.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAdult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAdult.Location = new System.Drawing.Point(617, 182);
            this.txtAdult.Name = "txtAdult";
            this.txtAdult.Size = new System.Drawing.Size(39, 21);
            this.txtAdult.TabIndex = 59;
            this.txtAdult.Visible = false;
            // 
            // lblChild
            // 
            this.lblChild.AutoSize = true;
            this.lblChild.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblChild.Location = new System.Drawing.Point(525, 202);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(29, 13);
            this.lblChild.TabIndex = 55;
            this.lblChild.Text = "소인";
            // 
            // lblAdult
            // 
            this.lblAdult.AutoSize = true;
            this.lblAdult.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAdult.Location = new System.Drawing.Point(488, 202);
            this.lblAdult.Name = "lblAdult";
            this.lblAdult.Size = new System.Drawing.Size(29, 13);
            this.lblAdult.TabIndex = 54;
            this.lblAdult.Text = "대인";
            // 
            // gvPassenger
            // 
            this.gvPassenger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvPassenger.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.gvPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPassenger.Location = new System.Drawing.Point(6, 70);
            this.gvPassenger.Name = "gvPassenger";
            this.gvPassenger.ReadOnly = true;
            this.gvPassenger.RowHeadersVisible = false;
            this.gvPassenger.RowTemplate.Height = 23;
            this.gvPassenger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPassenger.Size = new System.Drawing.Size(471, 255);
            this.gvPassenger.TabIndex = 52;
            this.gvPassenger.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPassenger_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(190, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 25);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbLeave
            // 
            this.cbLeave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbLeave.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbLeave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeave.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbLeave.FormattingEnabled = true;
            this.cbLeave.Items.AddRange(new object[] {
            "ICN 서울/인천",
            "CJU 제주",
            "NGO 나고야",
            "NRT 도쿄/나리타",
            "MFM 마카오",
            "PEK 베이징/서우두",
            "HKG 홍콩",
            "FUK 후쿠오카",
            "DAD 다낭",
            "MNL 마닐라",
            "BKK 방콕",
            "CEB 세부",
            "LAX 로스앤젤레스",
            "YVR 벤쿠버",
            "BOS 보스턴",
            "SFO 샌프란시스코",
            "SEA 시애틀/타코마",
            "CDG 파리",
            "PRG 프라하",
            "MXP 밀라노/말펜사",
            "BCN 바르셀로나",
            "BUD 부다페스트"});
            this.cbLeave.Location = new System.Drawing.Point(486, 89);
            this.cbLeave.Name = "cbLeave";
            this.cbLeave.Size = new System.Drawing.Size(85, 23);
            this.cbLeave.TabIndex = 49;
            // 
            // lblArrive
            // 
            this.lblArrive.AutoSize = true;
            this.lblArrive.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblArrive.Location = new System.Drawing.Point(483, 71);
            this.lblArrive.Name = "lblArrive";
            this.lblArrive.Size = new System.Drawing.Size(43, 15);
            this.lblArrive.TabIndex = 48;
            this.lblArrive.Text = "출발지";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(7, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "이름";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPhone.Location = new System.Drawing.Point(96, 26);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(51, 13);
            this.lblPhone.TabIndex = 35;
            this.lblPhone.Text = "전화번호";
            // 
            // lblLeave
            // 
            this.lblLeave.AutoSize = true;
            this.lblLeave.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLeave.Location = new System.Drawing.Point(483, 119);
            this.lblLeave.Name = "lblLeave";
            this.lblLeave.Size = new System.Drawing.Size(43, 15);
            this.lblLeave.TabIndex = 37;
            this.lblLeave.Text = "도착지";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.Location = new System.Drawing.Point(603, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(55, 20);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtName
            // 
            this.txtName.AllowDrop = true;
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtName.Location = new System.Drawing.Point(8, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(85, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhone.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(99, 43);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(85, 22);
            this.txtPhone.TabIndex = 2;
            // 
            // cbArrive
            // 
            this.cbArrive.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbArrive.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbArrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArrive.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbArrive.FormattingEnabled = true;
            this.cbArrive.Items.AddRange(new object[] {
            "ICN 서울/인천",
            "CJU 제주",
            "NGO 나고야",
            "NRT 도쿄/나리타",
            "MFM 마카오",
            "PEK 베이징/서우두",
            "HKG 홍콩",
            "FUK 후쿠오카",
            "DAD 다낭",
            "MNL 마닐라",
            "BKK 방콕",
            "CEB 세부",
            "LAX 로스앤젤레스",
            "YVR 벤쿠버",
            "BOS 보스턴",
            "SFO 샌프란시스코",
            "SEA 시애틀/타코마",
            "CDG 파리",
            "PRG 프라하",
            "MXP 밀라노/말펜사",
            "BCN 바르셀로나",
            "BUD 부다페스트"});
            this.cbArrive.Location = new System.Drawing.Point(486, 137);
            this.cbArrive.Name = "cbArrive";
            this.cbArrive.Size = new System.Drawing.Size(85, 23);
            this.cbArrive.TabIndex = 41;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBack.Location = new System.Drawing.Point(603, 306);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 20);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(280, 366);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(184, 75);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 44;
            this.picLogo.TabStop = false;
            // 
            // Translate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(727, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.picLogo);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Translate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPassenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblArrive;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLeave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbLeave;
        private System.Windows.Forms.ComboBox cbArrive;
        private System.Windows.Forms.DataGridView gvPassenger;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.Label lblAdult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChild;
        private System.Windows.Forms.TextBox txtAdult;
        private System.Windows.Forms.Label label3;
    }
}