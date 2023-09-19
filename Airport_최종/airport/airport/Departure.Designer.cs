
namespace airport
{
    partial class Departure
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
            this.btnDeparture = new System.Windows.Forms.Button();
            this.pnDeparture1 = new System.Windows.Forms.Panel();
            this.cbArrive = new System.Windows.Forms.ComboBox();
            this.cbLeave = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnDeparture2 = new System.Windows.Forms.Panel();
            this.cbChild = new System.Windows.Forms.ComboBox();
            this.cbAdult = new System.Windows.Forms.ComboBox();
            this.lblChild = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblAdult = new System.Windows.Forms.Label();
            this.lblPassenger = new System.Windows.Forms.Label();
            this.btnCost = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnDeparture1.SuspendLayout();
            this.pnDeparture2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeparture
            // 
            this.btnDeparture.FlatAppearance.BorderSize = 0;
            this.btnDeparture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeparture.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeparture.Location = new System.Drawing.Point(22, 49);
            this.btnDeparture.Name = "btnDeparture";
            this.btnDeparture.Size = new System.Drawing.Size(126, 42);
            this.btnDeparture.TabIndex = 51;
            this.btnDeparture.Text = "항공권 예매";
            this.btnDeparture.UseVisualStyleBackColor = true;
            // 
            // pnDeparture1
            // 
            this.pnDeparture1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnDeparture1.Controls.Add(this.cbArrive);
            this.pnDeparture1.Controls.Add(this.cbLeave);
            this.pnDeparture1.Controls.Add(this.label2);
            this.pnDeparture1.Controls.Add(this.label1);
            this.pnDeparture1.Controls.Add(this.dateTimePicker1);
            this.pnDeparture1.Location = new System.Drawing.Point(21, 129);
            this.pnDeparture1.Name = "pnDeparture1";
            this.pnDeparture1.Size = new System.Drawing.Size(437, 184);
            this.pnDeparture1.TabIndex = 52;
            // 
            // cbArrive
            // 
            this.cbArrive.AccessibleName = "";
            this.cbArrive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbArrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArrive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbArrive.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.cbArrive.Location = new System.Drawing.Point(257, 87);
            this.cbArrive.Name = "cbArrive";
            this.cbArrive.Size = new System.Drawing.Size(126, 21);
            this.cbArrive.TabIndex = 16;
            // 
            // cbLeave
            // 
            this.cbLeave.AccessibleName = "";
            this.cbLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLeave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbLeave.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.cbLeave.Location = new System.Drawing.Point(61, 87);
            this.cbLeave.Name = "cbLeave";
            this.cbLeave.Size = new System.Drawing.Size(130, 21);
            this.cbLeave.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(287, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "도착지";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(102, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "출발지";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 114);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 11, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // pnDeparture2
            // 
            this.pnDeparture2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnDeparture2.Controls.Add(this.cbChild);
            this.pnDeparture2.Controls.Add(this.cbAdult);
            this.pnDeparture2.Controls.Add(this.lblChild);
            this.pnDeparture2.Controls.Add(this.btnCheck);
            this.pnDeparture2.Controls.Add(this.lblAdult);
            this.pnDeparture2.Controls.Add(this.lblPassenger);
            this.pnDeparture2.Location = new System.Drawing.Point(21, 319);
            this.pnDeparture2.Name = "pnDeparture2";
            this.pnDeparture2.Size = new System.Drawing.Size(437, 41);
            this.pnDeparture2.TabIndex = 53;
            // 
            // cbChild
            // 
            this.cbChild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChild.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbChild.FormattingEnabled = true;
            this.cbChild.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbChild.Location = new System.Drawing.Point(345, 11);
            this.cbChild.Name = "cbChild";
            this.cbChild.Size = new System.Drawing.Size(38, 21);
            this.cbChild.TabIndex = 4;
            // 
            // cbAdult
            // 
            this.cbAdult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdult.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbAdult.FormattingEnabled = true;
            this.cbAdult.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbAdult.Location = new System.Drawing.Point(263, 11);
            this.cbAdult.Name = "cbAdult";
            this.cbAdult.Size = new System.Drawing.Size(39, 21);
            this.cbAdult.TabIndex = 3;
            // 
            // lblChild
            // 
            this.lblChild.AutoSize = true;
            this.lblChild.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblChild.Location = new System.Drawing.Point(312, 13);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(31, 15);
            this.lblChild.TabIndex = 2;
            this.lblChild.Text = "소인";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.Location = new System.Drawing.Point(391, 10);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(37, 22);
            this.btnCheck.TabIndex = 57;
            this.btnCheck.Text = "확인";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblAdult
            // 
            this.lblAdult.AutoSize = true;
            this.lblAdult.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAdult.Location = new System.Drawing.Point(227, 13);
            this.lblAdult.Name = "lblAdult";
            this.lblAdult.Size = new System.Drawing.Size(31, 15);
            this.lblAdult.TabIndex = 1;
            this.lblAdult.Text = "대인";
            // 
            // lblPassenger
            // 
            this.lblPassenger.AutoSize = true;
            this.lblPassenger.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPassenger.Location = new System.Drawing.Point(85, 11);
            this.lblPassenger.Name = "lblPassenger";
            this.lblPassenger.Size = new System.Drawing.Size(59, 20);
            this.lblPassenger.TabIndex = 0;
            this.lblPassenger.Text = "승객 수";
            // 
            // btnCost
            // 
            this.btnCost.BackColor = System.Drawing.Color.Navy;
            this.btnCost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCost.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCost.Location = new System.Drawing.Point(22, 403);
            this.btnCost.Name = "btnCost";
            this.btnCost.Size = new System.Drawing.Size(436, 40);
            this.btnCost.TabIndex = 54;
            this.btnCost.Text = "결제하기";
            this.btnCost.UseVisualStyleBackColor = false;
            this.btnCost.Click += new System.EventHandler(this.btnCost_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(434, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(248, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "최종 결제 금액";
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.SkyBlue;
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCost.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCost.ForeColor = System.Drawing.Color.Red;
            this.txtCost.Location = new System.Drawing.Point(347, 376);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(111, 16);
            this.txtCost.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeparture);
            this.panel1.Controls.Add(this.txtCost);
            this.panel1.Controls.Add(this.pnDeparture1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pnDeparture2);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnCost);
            this.panel1.Location = new System.Drawing.Point(516, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 497);
            this.panel1.TabIndex = 59;
            // 
            // Departure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1126, 660);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Departure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departure";
            this.pnDeparture1.ResumeLayout(false);
            this.pnDeparture1.PerformLayout();
            this.pnDeparture2.ResumeLayout(false);
            this.pnDeparture2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeparture;
        private System.Windows.Forms.Panel pnDeparture1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnDeparture2;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.Label lblAdult;
        private System.Windows.Forms.Label lblPassenger;
        private System.Windows.Forms.Button btnCost;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.ComboBox cbLeave;
        public System.Windows.Forms.ComboBox cbChild;
        public System.Windows.Forms.ComboBox cbAdult;
        public System.Windows.Forms.ComboBox cbArrive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Panel panel1;
    }
}