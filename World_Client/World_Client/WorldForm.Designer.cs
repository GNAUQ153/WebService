namespace World_Client
{
    partial class WorldForm
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
            cboChoices = new ComboBox();
            txtName = new TextBox();
            txtCountryCode = new TextBox();
            lblChoices = new Label();
            lblName = new Label();
            lblCountryCode = new Label();
            btnView = new Button();
            dgvInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInfo).BeginInit();
            SuspendLayout();
            // 
            // cboChoices
            // 
            cboChoices.FormattingEnabled = true;
            cboChoices.Location = new Point(112, 13);
            cboChoices.Name = "cboChoices";
            cboChoices.Size = new Size(267, 28);
            cboChoices.TabIndex = 2;
            cboChoices.SelectedIndexChanged += cboChoices_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(267, 27);
            txtName.TabIndex = 3;
            // 
            // txtCountryCode
            // 
            txtCountryCode.Location = new Point(549, 76);
            txtCountryCode.Name = "txtCountryCode";
            txtCountryCode.Size = new Size(79, 27);
            txtCountryCode.TabIndex = 6;
            // 
            // lblChoices
            // 
            lblChoices.AutoSize = true;
            lblChoices.Location = new Point(18, 16);
            lblChoices.Name = "lblChoices";
            lblChoices.Size = new Size(88, 20);
            lblChoices.TabIndex = 5;
            lblChoices.Text = "Choose opt:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(18, 79);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 6;
            lblName.Text = "Name:";
            // 
            // lblCountryCode
            // 
            lblCountryCode.AutoSize = true;
            lblCountryCode.Location = new Point(417, 79);
            lblCountryCode.Name = "lblCountryCode";
            lblCountryCode.Size = new Size(102, 20);
            lblCountryCode.TabIndex = 7;
            lblCountryCode.Text = "Country Code:";
            // 
            // btnView
            // 
            btnView.Location = new Point(257, 122);
            btnView.Name = "btnView";
            btnView.Size = new Size(283, 31);
            btnView.TabIndex = 8;
            btnView.Text = "VIEW INFORMATION";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // dgvInfo
            // 
            dgvInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfo.Location = new Point(15, 162);
            dgvInfo.Name = "dgvInfo";
            dgvInfo.RowHeadersWidth = 51;
            dgvInfo.Size = new Size(772, 283);
            dgvInfo.TabIndex = 9;
            // 
            // WorldForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvInfo);
            Controls.Add(btnView);
            Controls.Add(lblCountryCode);
            Controls.Add(lblName);
            Controls.Add(lblChoices);
            Controls.Add(txtCountryCode);
            Controls.Add(txtName);
            Controls.Add(cboChoices);
            Name = "WorldForm";
            Text = "World Cities";
            Load += WorldForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
            }

        #endregion

        private ComboBox cboChoices;
        private TextBox txtName;
        private TextBox txtCountryCode;
        private Label lblChoices;
        private Label lblName;
        private Label lblCountryCode;
        private Button btnView;
        private DataGridView dgvInfo;
        }
}
