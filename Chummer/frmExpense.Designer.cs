namespace Chummer
{
    public sealed partial class frmExpense
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
            this.lblKarma = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.chkRefund = new System.Windows.Forms.CheckBox();
            this.datDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.nudPercent = new System.Windows.Forms.NumericUpDown();
            this.lblPercent = new System.Windows.Forms.Label();
            this.chkKarmaNuyenExchange = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercent)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKarma
            // 
            this.lblKarma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKarma.AutoSize = true;
            this.lblKarma.Location = new System.Drawing.Point(38, 6);
            this.lblKarma.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblKarma.Name = "lblKarma";
            this.lblKarma.Size = new System.Drawing.Size(79, 14);
            this.lblKarma.TabIndex = 0;
            this.lblKarma.Tag = "Label_Expense_KarmaAmount";
            this.lblKarma.Text = "Karma Amount:";
            // 
            // nudAmount
            // 
            this.nudAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAmount.Location = new System.Drawing.Point(123, 3);
            this.nudAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(84, 20);
            this.nudAmount.TabIndex = 1;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(54, 58);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 14);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Tag = "Label_Expense_Description";
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(123, 55);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(474, 20);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Text = "Mission Reward";
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(456, 166);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 10;
            this.cmdCancel.Tag = "String_Cancel";
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(537, 166);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 9;
            this.cmdOK.Tag = "String_OK";
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // chkRefund
            // 
            this.chkRefund.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkRefund, 3);
            this.chkRefund.Location = new System.Drawing.Point(123, 82);
            this.chkRefund.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkRefund.Name = "chkRefund";
            this.chkRefund.Size = new System.Drawing.Size(275, 17);
            this.chkRefund.TabIndex = 8;
            this.chkRefund.Tag = "Checkbox_Expense_Refund";
            this.chkRefund.Text = "Refund (does not count towards Total Career Karma)";
            this.chkRefund.UseVisualStyleBackColor = true;
            // 
            // datDate
            // 
            this.datDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.SetColumnSpan(this.datDate, 3);
            this.datDate.CustomFormat = "ddddd, MMMM dd, yyyy hh:mm tt";
            this.datDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datDate.Location = new System.Drawing.Point(123, 29);
            this.datDate.Name = "datDate";
            this.datDate.Size = new System.Drawing.Size(251, 20);
            this.datDate.TabIndex = 5;
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Location = new System.Drawing.Point(84, 32);
            this.lblDateLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(33, 14);
            this.lblDateLabel.TabIndex = 4;
            this.lblDateLabel.Tag = "Label_Expense_Date";
            this.lblDateLabel.Text = "Date:";
            // 
            // nudPercent
            // 
            this.nudPercent.DecimalPlaces = 2;
            this.nudPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudPercent.Location = new System.Drawing.Point(213, 3);
            this.nudPercent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPercent.Name = "nudPercent";
            this.nudPercent.Size = new System.Drawing.Size(84, 20);
            this.nudPercent.TabIndex = 2;
            this.nudPercent.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPercent.Visible = false;
            // 
            // lblPercent
            // 
            this.lblPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(303, 6);
            this.lblPercent.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(15, 14);
            this.lblPercent.TabIndex = 3;
            this.lblPercent.Text = "%";
            this.lblPercent.Visible = false;
            // 
            // chkKarmaNuyenExchange
            // 
            this.chkKarmaNuyenExchange.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkKarmaNuyenExchange, 3);
            this.chkKarmaNuyenExchange.Location = new System.Drawing.Point(123, 107);
            this.chkKarmaNuyenExchange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkKarmaNuyenExchange.Name = "chkKarmaNuyenExchange";
            this.chkKarmaNuyenExchange.Size = new System.Drawing.Size(161, 17);
            this.chkKarmaNuyenExchange.TabIndex = 11;
            this.chkKarmaNuyenExchange.Tag = "String_WorkingForTheManPeople";
            this.chkKarmaNuyenExchange.Text = "Working for the Man/People";
            this.chkKarmaNuyenExchange.UseVisualStyleBackColor = true;
            this.chkKarmaNuyenExchange.CheckedChanged += new System.EventHandler(this.chkKarmaNuyenExchange_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.nudPercent, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkKarmaNuyenExchange, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.nudAmount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblKarma, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDateLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkRefund, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPercent, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.datDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 148);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // frmExpense
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(624, 201);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExpense";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Title_Expense_Karma";
            this.Text = "Karmic Change";
            this.Load += new System.EventHandler(this.frmExpanse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercent)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKarma;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.CheckBox chkRefund;
        private System.Windows.Forms.DateTimePicker datDate;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.NumericUpDown nudPercent;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.CheckBox chkKarmaNuyenExchange;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
