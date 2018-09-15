namespace Chummer
{
    partial class frmSelectMentorSpirit
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
            if (disposing)
            {
                components?.Dispose();
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
            this.lblDisadvantage = new System.Windows.Forms.Label();
            this.lblDisadvantageLabel = new System.Windows.Forms.Label();
            this.lblAdvantage = new System.Windows.Forms.Label();
            this.lblAdvantageLabel = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.lstMentor = new System.Windows.Forms.ListBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblSourceLabel = new System.Windows.Forms.Label();
            this.lblChoice1 = new System.Windows.Forms.Label();
            this.lblChoice2 = new System.Windows.Forms.Label();
            this.cboChoice1 = new System.Windows.Forms.ComboBox();
            this.cboChoice2 = new System.Windows.Forms.ComboBox();
            this.chkMentorMask = new System.Windows.Forms.CheckBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisadvantage
            // 
            this.lblDisadvantage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDisadvantage.AutoSize = true;
            this.lblDisadvantage.Location = new System.Drawing.Point(88, 186);
            this.lblDisadvantage.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDisadvantage.MaximumSize = new System.Drawing.Size(270, 0);
            this.lblDisadvantage.Name = "lblDisadvantage";
            this.lblDisadvantage.Size = new System.Drawing.Size(79, 13);
            this.lblDisadvantage.TabIndex = 10;
            this.lblDisadvantage.Text = "[Disadvantage]";
            // 
            // lblDisadvantageLabel
            // 
            this.lblDisadvantageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDisadvantageLabel.AutoSize = true;
            this.lblDisadvantageLabel.Location = new System.Drawing.Point(3, 186);
            this.lblDisadvantageLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDisadvantageLabel.Name = "lblDisadvantageLabel";
            this.lblDisadvantageLabel.Size = new System.Drawing.Size(76, 13);
            this.lblDisadvantageLabel.TabIndex = 9;
            this.lblDisadvantageLabel.Tag = "Label_SelectMetamagic_Disadvantage";
            this.lblDisadvantageLabel.Text = "Disadvantage:";
            // 
            // lblAdvantage
            // 
            this.lblAdvantage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAdvantage.AutoSize = true;
            this.lblAdvantage.Location = new System.Drawing.Point(88, 32);
            this.lblAdvantage.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAdvantage.MaximumSize = new System.Drawing.Size(270, 0);
            this.lblAdvantage.Name = "lblAdvantage";
            this.lblAdvantage.Size = new System.Drawing.Size(65, 13);
            this.lblAdvantage.TabIndex = 4;
            this.lblAdvantage.Text = "[Advantage]";
            // 
            // lblAdvantageLabel
            // 
            this.lblAdvantageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAdvantageLabel.AutoSize = true;
            this.lblAdvantageLabel.Location = new System.Drawing.Point(3, 32);
            this.lblAdvantageLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAdvantageLabel.Name = "lblAdvantageLabel";
            this.lblAdvantageLabel.Size = new System.Drawing.Size(62, 13);
            this.lblAdvantageLabel.TabIndex = 3;
            this.lblAdvantageLabel.Tag = "Label_SelectMentorSpirit_Advantage";
            this.lblAdvantageLabel.Text = "Advantage:";
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(537, 406);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 13;
            this.cmdOK.Tag = "String_OK";
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // lstMentor
            // 
            this.lstMentor.FormattingEnabled = true;
            this.lstMentor.Location = new System.Drawing.Point(12, 12);
            this.lstMentor.Name = "lstMentor";
            this.lstMentor.Size = new System.Drawing.Size(300, 420);
            this.lstMentor.TabIndex = 0;
            this.lstMentor.SelectedIndexChanged += new System.EventHandler(this.lstMentor_SelectedIndexChanged);
            this.lstMentor.DoubleClick += new System.EventHandler(this.lstMentor_DoubleClick);
            // 
            // lblSource
            // 
            this.lblSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(88, 211);
            this.lblSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(47, 171);
            this.lblSource.TabIndex = 12;
            this.lblSource.Text = "[Source]";
            this.lblSource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // lblSourceLabel
            // 
            this.lblSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSourceLabel.AutoSize = true;
            this.lblSourceLabel.Location = new System.Drawing.Point(3, 211);
            this.lblSourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSourceLabel.Name = "lblSourceLabel";
            this.lblSourceLabel.Size = new System.Drawing.Size(44, 171);
            this.lblSourceLabel.TabIndex = 11;
            this.lblSourceLabel.Tag = "Label_Source";
            this.lblSourceLabel.Text = "Source:";
            // 
            // lblChoice1
            // 
            this.lblChoice1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChoice1.AutoSize = true;
            this.lblChoice1.Location = new System.Drawing.Point(3, 57);
            this.lblChoice1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblChoice1.Name = "lblChoice1";
            this.lblChoice1.Size = new System.Drawing.Size(69, 13);
            this.lblChoice1.TabIndex = 5;
            this.lblChoice1.Tag = "Label_SelectMentor_ChooseOne";
            this.lblChoice1.Text = "Choose One:";
            this.lblChoice1.Visible = false;
            // 
            // lblChoice2
            // 
            this.lblChoice2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChoice2.AutoSize = true;
            this.lblChoice2.Location = new System.Drawing.Point(3, 109);
            this.lblChoice2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblChoice2.Name = "lblChoice2";
            this.lblChoice2.Size = new System.Drawing.Size(69, 13);
            this.lblChoice2.TabIndex = 7;
            this.lblChoice2.Tag = "Label_SelectMentor_ChooseOne";
            this.lblChoice2.Text = "Choose One:";
            this.lblChoice2.Visible = false;
            // 
            // cboChoice1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cboChoice1, 2);
            this.cboChoice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChoice1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoice1.FormattingEnabled = true;
            this.cboChoice1.Location = new System.Drawing.Point(3, 79);
            this.cboChoice1.Name = "cboChoice1";
            this.cboChoice1.Size = new System.Drawing.Size(288, 21);
            this.cboChoice1.TabIndex = 6;
            this.cboChoice1.Visible = false;
            // 
            // cboChoice2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cboChoice2, 2);
            this.cboChoice2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChoice2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoice2.FormattingEnabled = true;
            this.cboChoice2.Location = new System.Drawing.Point(3, 131);
            this.cboChoice2.Name = "cboChoice2";
            this.cboChoice2.Size = new System.Drawing.Size(288, 21);
            this.cboChoice2.TabIndex = 8;
            this.cboChoice2.Visible = false;
            // 
            // chkMentorMask
            // 
            this.chkMentorMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkMentorMask.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkMentorMask, 2);
            this.chkMentorMask.Location = new System.Drawing.Point(3, 159);
            this.chkMentorMask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkMentorMask.Name = "chkMentorMask";
            this.chkMentorMask.Size = new System.Drawing.Size(117, 17);
            this.chkMentorMask.TabIndex = 14;
            this.chkMentorMask.Text = "Use Mentor\'s Mask";
            this.chkMentorMask.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(456, 406);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 15;
            this.cmdCancel.Tag = "String_Cancel";
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSearchLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAdvantageLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkMentorMask, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblAdvantage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDisadvantage, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblSource, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblDisadvantageLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblChoice2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSourceLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.cboChoice2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblChoice1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboChoice1, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(318, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 388);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(88, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(203, 20);
            this.txtSearch.TabIndex = 72;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearchLabel
            // 
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Location = new System.Drawing.Point(3, 6);
            this.lblSearchLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Size = new System.Drawing.Size(44, 13);
            this.lblSearchLabel.TabIndex = 69;
            this.lblSearchLabel.Tag = "Label_Search";
            this.lblSearchLabel.Text = "&Search:";
            // 
            // frmSelectMentorSpirit
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.lstMentor);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectMentorSpirit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Title_SelectMentorSpirit";
            this.Text = "Select a Mentor Spirit";
            this.Load += new System.EventHandler(this.frmSelectMentorSpirit_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisadvantage;
        private System.Windows.Forms.Label lblDisadvantageLabel;
        private System.Windows.Forms.Label lblAdvantage;
        private System.Windows.Forms.Label lblAdvantageLabel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.ListBox lstMentor;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblSourceLabel;
        private System.Windows.Forms.Label lblChoice1;
        private System.Windows.Forms.Label lblChoice2;
        private System.Windows.Forms.ComboBox cboChoice1;
        private System.Windows.Forms.ComboBox cboChoice2;
        private System.Windows.Forms.CheckBox chkMentorMask;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
