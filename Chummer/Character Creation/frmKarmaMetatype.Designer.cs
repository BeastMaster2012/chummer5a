using System;
using System.Windows;
using System.Windows.Forms;

namespace Chummer
{
    partial class frmKarmaMetatype
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
            this.pnlMetatypes = new System.Windows.Forms.Panel();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.lstMetatypes = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCHALabel = new System.Windows.Forms.Label();
            this.lblCHA = new System.Windows.Forms.Label();
            this.lblSTRLabel = new System.Windows.Forms.Label();
            this.nudForce = new System.Windows.Forms.NumericUpDown();
            this.lblSTR = new System.Windows.Forms.Label();
            this.lblForceLabel = new System.Windows.Forms.Label();
            this.lblINI = new System.Windows.Forms.Label();
            this.lblINILabel = new System.Windows.Forms.Label();
            this.lblWIL = new System.Windows.Forms.Label();
            this.lblLOG = new System.Windows.Forms.Label();
            this.lblLOGLabel = new System.Windows.Forms.Label();
            this.lblWILLabel = new System.Windows.Forms.Label();
            this.lblREA = new System.Windows.Forms.Label();
            this.lblREALabel = new System.Windows.Forms.Label();
            this.lblAGILabel = new System.Windows.Forms.Label();
            this.lblAGI = new System.Windows.Forms.Label();
            this.lblINT = new System.Windows.Forms.Label();
            this.lblINTLabel = new System.Windows.Forms.Label();
            this.lblBODLabel = new System.Windows.Forms.Label();
            this.lblBOD = new System.Windows.Forms.Label();
            this.cboMetavariant = new System.Windows.Forms.ComboBox();
            this.lblKarma = new System.Windows.Forms.Label();
            this.lblQualities = new System.Windows.Forms.Label();
            this.lblMetavariantLabel = new System.Windows.Forms.Label();
            this.lblKarmaLabel = new System.Windows.Forms.Label();
            this.lblQualitiesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chkBloodSpirit = new System.Windows.Forms.CheckBox();
            this.chkPossessionBased = new System.Windows.Forms.CheckBox();
            this.cboPossessionMethod = new System.Windows.Forms.ComboBox();
            this.pnlMetatypes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudForce)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMetatypes
            // 
            this.pnlMetatypes.Controls.Add(this.cboCategory);
            this.pnlMetatypes.Controls.Add(this.cmdCancel);
            this.pnlMetatypes.Controls.Add(this.cmdOK);
            this.pnlMetatypes.Controls.Add(this.lstMetatypes);
            this.pnlMetatypes.Controls.Add(this.tableLayoutPanel1);
            this.pnlMetatypes.Controls.Add(this.tableLayoutPanel2);
            this.pnlMetatypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetatypes.Location = new System.Drawing.Point(0, 0);
            this.pnlMetatypes.Name = "pnlMetatypes";
            this.pnlMetatypes.Size = new System.Drawing.Size(624, 441);
            this.pnlMetatypes.TabIndex = 35;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(12, 12);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(200, 21);
            this.cboCategory.TabIndex = 66;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(460, 408);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 68;
            this.cmdCancel.Tag = "String_Cancel";
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.Location = new System.Drawing.Point(541, 408);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 67;
            this.cmdOK.Tag = "String_OK";
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // lstMetatypes
            // 
            this.lstMetatypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstMetatypes.FormattingEnabled = true;
            this.lstMetatypes.Location = new System.Drawing.Point(12, 39);
            this.lstMetatypes.Name = "lstMetatypes";
            this.lstMetatypes.Size = new System.Drawing.Size(200, 394);
            this.lstMetatypes.Sorted = true;
            this.lstMetatypes.TabIndex = 35;
            this.lstMetatypes.SelectedIndexChanged += new System.EventHandler(this.lstMetatypes_SelectedIndexChanged);
            this.lstMetatypes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMetatypes_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.Controls.Add(this.lblCHALabel, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCHA, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSTRLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudForce, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSTR, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblForceLabel, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblINI, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblINILabel, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblWIL, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblLOG, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblLOGLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblWILLabel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblREA, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblREALabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAGILabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAGI, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblINT, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblINTLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBODLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBOD, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboMetavariant, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblKarma, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblQualities, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblMetavariantLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblKarmaLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblQualitiesLabel, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(218, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 332);
            this.tableLayoutPanel1.TabIndex = 70;
            // 
            // lblCHALabel
            // 
            this.lblCHALabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCHALabel.AutoSize = true;
            this.lblCHALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCHALabel.Location = new System.Drawing.Point(322, 6);
            this.lblCHALabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCHALabel.Name = "lblCHALabel";
            this.lblCHALabel.Size = new System.Drawing.Size(32, 13);
            this.lblCHALabel.TabIndex = 46;
            this.lblCHALabel.Tag = "String_AttributeCHAShort";
            this.lblCHALabel.Text = "CHA";
            // 
            // lblCHA
            // 
            this.lblCHA.AutoSize = true;
            this.lblCHA.Location = new System.Drawing.Point(322, 31);
            this.lblCHA.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCHA.Name = "lblCHA";
            this.lblCHA.Size = new System.Drawing.Size(51, 13);
            this.lblCHA.TabIndex = 47;
            this.lblCHA.Text = "2/12 (18)";
            // 
            // lblSTRLabel
            // 
            this.lblSTRLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSTRLabel.AutoSize = true;
            this.lblSTRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTRLabel.Location = new System.Drawing.Point(247, 6);
            this.lblSTRLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSTRLabel.Name = "lblSTRLabel";
            this.lblSTRLabel.Size = new System.Drawing.Size(32, 13);
            this.lblSTRLabel.TabIndex = 44;
            this.lblSTRLabel.Tag = "String_AttributeSTRShort";
            this.lblSTRLabel.Text = "STR";
            // 
            // nudForce
            // 
            this.nudForce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudForce.Location = new System.Drawing.Point(322, 78);
            this.nudForce.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudForce.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudForce.Name = "nudForce";
            this.nudForce.Size = new System.Drawing.Size(73, 20);
            this.nudForce.TabIndex = 57;
            this.nudForce.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudForce.Visible = false;
            // 
            // lblSTR
            // 
            this.lblSTR.AutoSize = true;
            this.lblSTR.Location = new System.Drawing.Point(247, 31);
            this.lblSTR.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSTR.Name = "lblSTR";
            this.lblSTR.Size = new System.Drawing.Size(51, 13);
            this.lblSTR.TabIndex = 45;
            this.lblSTR.Text = "2/12 (18)";
            // 
            // lblForceLabel
            // 
            this.lblForceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblForceLabel.AutoSize = true;
            this.lblForceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForceLabel.Location = new System.Drawing.Point(322, 56);
            this.lblForceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblForceLabel.Name = "lblForceLabel";
            this.lblForceLabel.Size = new System.Drawing.Size(48, 13);
            this.lblForceLabel.TabIndex = 56;
            this.lblForceLabel.Tag = "String_Force";
            this.lblForceLabel.Text = "FORCE";
            this.lblForceLabel.Visible = false;
            // 
            // lblINI
            // 
            this.lblINI.AutoSize = true;
            this.lblINI.Location = new System.Drawing.Point(247, 81);
            this.lblINI.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblINI.Name = "lblINI";
            this.lblINI.Size = new System.Drawing.Size(51, 13);
            this.lblINI.TabIndex = 55;
            this.lblINI.Text = "2/12 (18)";
            // 
            // lblINILabel
            // 
            this.lblINILabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblINILabel.AutoSize = true;
            this.lblINILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINILabel.Location = new System.Drawing.Point(247, 56);
            this.lblINILabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblINILabel.Name = "lblINILabel";
            this.lblINILabel.Size = new System.Drawing.Size(24, 13);
            this.lblINILabel.TabIndex = 54;
            this.lblINILabel.Tag = "String_AttributeINIShort";
            this.lblINILabel.Text = "INI";
            // 
            // lblWIL
            // 
            this.lblWIL.AutoSize = true;
            this.lblWIL.Location = new System.Drawing.Point(172, 81);
            this.lblWIL.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWIL.Name = "lblWIL";
            this.lblWIL.Size = new System.Drawing.Size(51, 13);
            this.lblWIL.TabIndex = 53;
            this.lblWIL.Text = "2/12 (18)";
            // 
            // lblLOG
            // 
            this.lblLOG.AutoSize = true;
            this.lblLOG.Location = new System.Drawing.Point(97, 81);
            this.lblLOG.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLOG.Name = "lblLOG";
            this.lblLOG.Size = new System.Drawing.Size(51, 13);
            this.lblLOG.TabIndex = 51;
            this.lblLOG.Text = "2/12 (18)";
            // 
            // lblLOGLabel
            // 
            this.lblLOGLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLOGLabel.AutoSize = true;
            this.lblLOGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOGLabel.Location = new System.Drawing.Point(97, 56);
            this.lblLOGLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLOGLabel.Name = "lblLOGLabel";
            this.lblLOGLabel.Size = new System.Drawing.Size(32, 13);
            this.lblLOGLabel.TabIndex = 50;
            this.lblLOGLabel.Tag = "String_AttributeLOGShort";
            this.lblLOGLabel.Text = "LOG";
            // 
            // lblWILLabel
            // 
            this.lblWILLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWILLabel.AutoSize = true;
            this.lblWILLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWILLabel.Location = new System.Drawing.Point(172, 56);
            this.lblWILLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWILLabel.Name = "lblWILLabel";
            this.lblWILLabel.Size = new System.Drawing.Size(30, 13);
            this.lblWILLabel.TabIndex = 52;
            this.lblWILLabel.Tag = "String_AttributeWILShort";
            this.lblWILLabel.Text = "WIL";
            // 
            // lblREA
            // 
            this.lblREA.AutoSize = true;
            this.lblREA.Location = new System.Drawing.Point(172, 31);
            this.lblREA.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblREA.Name = "lblREA";
            this.lblREA.Size = new System.Drawing.Size(51, 13);
            this.lblREA.TabIndex = 43;
            this.lblREA.Text = "2/12 (18)";
            // 
            // lblREALabel
            // 
            this.lblREALabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblREALabel.AutoSize = true;
            this.lblREALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREALabel.Location = new System.Drawing.Point(172, 6);
            this.lblREALabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblREALabel.Name = "lblREALabel";
            this.lblREALabel.Size = new System.Drawing.Size(32, 13);
            this.lblREALabel.TabIndex = 42;
            this.lblREALabel.Tag = "String_AttributeREAShort";
            this.lblREALabel.Text = "REA";
            // 
            // lblAGILabel
            // 
            this.lblAGILabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAGILabel.AutoSize = true;
            this.lblAGILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAGILabel.Location = new System.Drawing.Point(97, 6);
            this.lblAGILabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAGILabel.Name = "lblAGILabel";
            this.lblAGILabel.Size = new System.Drawing.Size(28, 13);
            this.lblAGILabel.TabIndex = 40;
            this.lblAGILabel.Tag = "String_AttributeAGIShort";
            this.lblAGILabel.Text = "AGI";
            // 
            // lblAGI
            // 
            this.lblAGI.AutoSize = true;
            this.lblAGI.Location = new System.Drawing.Point(97, 31);
            this.lblAGI.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAGI.Name = "lblAGI";
            this.lblAGI.Size = new System.Drawing.Size(51, 13);
            this.lblAGI.TabIndex = 41;
            this.lblAGI.Text = "2/12 (18)";
            // 
            // lblINT
            // 
            this.lblINT.AutoSize = true;
            this.lblINT.Location = new System.Drawing.Point(22, 81);
            this.lblINT.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblINT.Name = "lblINT";
            this.lblINT.Size = new System.Drawing.Size(51, 13);
            this.lblINT.TabIndex = 49;
            this.lblINT.Text = "2/12 (18)";
            // 
            // lblINTLabel
            // 
            this.lblINTLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblINTLabel.AutoSize = true;
            this.lblINTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINTLabel.Location = new System.Drawing.Point(22, 56);
            this.lblINTLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblINTLabel.Name = "lblINTLabel";
            this.lblINTLabel.Size = new System.Drawing.Size(28, 13);
            this.lblINTLabel.TabIndex = 48;
            this.lblINTLabel.Tag = "String_AttributeINTShort";
            this.lblINTLabel.Text = "INT";
            // 
            // lblBODLabel
            // 
            this.lblBODLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBODLabel.AutoSize = true;
            this.lblBODLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBODLabel.Location = new System.Drawing.Point(22, 6);
            this.lblBODLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBODLabel.Name = "lblBODLabel";
            this.lblBODLabel.Size = new System.Drawing.Size(33, 13);
            this.lblBODLabel.TabIndex = 38;
            this.lblBODLabel.Tag = "String_AttributeBODShort";
            this.lblBODLabel.Text = "BOD";
            // 
            // lblBOD
            // 
            this.lblBOD.AutoSize = true;
            this.lblBOD.Location = new System.Drawing.Point(22, 31);
            this.lblBOD.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBOD.Name = "lblBOD";
            this.lblBOD.Size = new System.Drawing.Size(51, 13);
            this.lblBOD.TabIndex = 39;
            this.lblBOD.Text = "2/12 (18)";
            // 
            // cboMetavariant
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cboMetavariant, 4);
            this.cboMetavariant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMetavariant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetavariant.FormattingEnabled = true;
            this.cboMetavariant.Location = new System.Drawing.Point(97, 104);
            this.cboMetavariant.Name = "cboMetavariant";
            this.cboMetavariant.Size = new System.Drawing.Size(298, 21);
            this.cboMetavariant.TabIndex = 59;
            this.cboMetavariant.SelectedIndexChanged += new System.EventHandler(this.cboMetavariant_SelectedIndexChanged);
            // 
            // lblKarma
            // 
            this.lblKarma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKarma.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblKarma, 4);
            this.lblKarma.Location = new System.Drawing.Point(97, 134);
            this.lblKarma.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblKarma.Name = "lblKarma";
            this.lblKarma.Size = new System.Drawing.Size(13, 13);
            this.lblKarma.TabIndex = 61;
            this.lblKarma.Text = "0";
            // 
            // lblQualities
            // 
            this.lblQualities.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblQualities, 4);
            this.lblQualities.Location = new System.Drawing.Point(97, 159);
            this.lblQualities.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblQualities.Name = "lblQualities";
            this.lblQualities.Size = new System.Drawing.Size(33, 13);
            this.lblQualities.TabIndex = 63;
            this.lblQualities.Tag = "String_None";
            this.lblQualities.Text = "None";
            // 
            // lblMetavariantLabel
            // 
            this.lblMetavariantLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMetavariantLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMetavariantLabel, 2);
            this.lblMetavariantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetavariantLabel.Location = new System.Drawing.Point(3, 107);
            this.lblMetavariantLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMetavariantLabel.Name = "lblMetavariantLabel";
            this.lblMetavariantLabel.Size = new System.Drawing.Size(78, 15);
            this.lblMetavariantLabel.TabIndex = 58;
            this.lblMetavariantLabel.Tag = "Label_Metavariant";
            this.lblMetavariantLabel.Text = "Metavariant:";
            // 
            // lblKarmaLabel
            // 
            this.lblKarmaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKarmaLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblKarmaLabel, 2);
            this.lblKarmaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKarmaLabel.Location = new System.Drawing.Point(3, 134);
            this.lblKarmaLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblKarmaLabel.Name = "lblKarmaLabel";
            this.lblKarmaLabel.Size = new System.Drawing.Size(46, 13);
            this.lblKarmaLabel.TabIndex = 60;
            this.lblKarmaLabel.Tag = "Label_Karma";
            this.lblKarmaLabel.Text = "Karma:";
            // 
            // lblQualitiesLabel
            // 
            this.lblQualitiesLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblQualitiesLabel, 2);
            this.lblQualitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualitiesLabel.Location = new System.Drawing.Point(3, 159);
            this.lblQualitiesLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblQualitiesLabel.Name = "lblQualitiesLabel";
            this.lblQualitiesLabel.Size = new System.Drawing.Size(60, 13);
            this.lblQualitiesLabel.TabIndex = 62;
            this.lblQualitiesLabel.Tag = "String_Qualities";
            this.lblQualitiesLabel.Text = "Qualities:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.chkBloodSpirit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkPossessionBased, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboPossessionMethod, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(218, 350);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(398, 52);
            this.tableLayoutPanel2.TabIndex = 70;
            // 
            // chkBloodSpirit
            // 
            this.chkBloodSpirit.AutoSize = true;
            this.chkBloodSpirit.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkBloodSpirit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkBloodSpirit.Location = new System.Drawing.Point(3, 4);
            this.chkBloodSpirit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBloodSpirit.Name = "chkBloodSpirit";
            this.chkBloodSpirit.Size = new System.Drawing.Size(73, 44);
            this.chkBloodSpirit.TabIndex = 69;
            this.chkBloodSpirit.Tag = "Checkbox_Metatype_BloodSpirit";
            this.chkBloodSpirit.Text = "Blood Spirit";
            this.chkBloodSpirit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkBloodSpirit.UseVisualStyleBackColor = true;
            this.chkBloodSpirit.Visible = false;
            // 
            // chkPossessionBased
            // 
            this.chkPossessionBased.AutoSize = true;
            this.chkPossessionBased.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkPossessionBased.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPossessionBased.Location = new System.Drawing.Point(82, 4);
            this.chkPossessionBased.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkPossessionBased.Name = "chkPossessionBased";
            this.chkPossessionBased.Size = new System.Drawing.Size(153, 44);
            this.chkPossessionBased.TabIndex = 64;
            this.chkPossessionBased.Tag = "Checkbox_Metatype_PossessionTradition";
            this.chkPossessionBased.Text = "Summoned by Possess-based Tradition";
            this.chkPossessionBased.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkPossessionBased.UseVisualStyleBackColor = true;
            this.chkPossessionBased.Visible = false;
            this.chkPossessionBased.CheckedChanged += new System.EventHandler(this.chkPossessionBased_CheckedChanged);
            // 
            // cboPossessionMethod
            // 
            this.cboPossessionMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPossessionMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPossessionMethod.Enabled = false;
            this.cboPossessionMethod.FormattingEnabled = true;
            this.cboPossessionMethod.Location = new System.Drawing.Point(241, 3);
            this.cboPossessionMethod.Name = "cboPossessionMethod";
            this.cboPossessionMethod.Size = new System.Drawing.Size(154, 21);
            this.cboPossessionMethod.TabIndex = 65;
            this.cboPossessionMethod.Visible = false;
            // 
            // frmKarmaMetatype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMetatypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKarmaMetatype";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Title_Metatype";
            this.Text = "Select a Metatype";
            this.Load += new System.EventHandler(this.frmMetatype_Load);
            this.pnlMetatypes.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudForce)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Panel pnlMetatypes;
        private System.Windows.Forms.CheckBox chkBloodSpirit;
        private System.Windows.Forms.ComboBox cboPossessionMethod;
        private System.Windows.Forms.CheckBox chkPossessionBased;
        private System.Windows.Forms.NumericUpDown nudForce;
        private System.Windows.Forms.Label lblForceLabel;
        private System.Windows.Forms.ComboBox cboCategory;
        internal System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label lblQualities;
        private System.Windows.Forms.Label lblQualitiesLabel;
        internal System.Windows.Forms.Label lblKarma;
        internal System.Windows.Forms.Label lblKarmaLabel;
        private System.Windows.Forms.Label lblMetavariantLabel;
        private System.Windows.Forms.ComboBox cboMetavariant;
        internal System.Windows.Forms.Button cmdOK;
        internal System.Windows.Forms.Label lblINILabel;
        internal System.Windows.Forms.Label lblINI;
        internal System.Windows.Forms.Label lblWILLabel;
        internal System.Windows.Forms.Label lblWIL;
        internal System.Windows.Forms.Label lblLOGLabel;
        internal System.Windows.Forms.Label lblLOG;
        internal System.Windows.Forms.Label lblINTLabel;
        internal System.Windows.Forms.Label lblINT;
        internal System.Windows.Forms.Label lblCHALabel;
        internal System.Windows.Forms.Label lblCHA;
        internal System.Windows.Forms.Label lblSTR;
        internal System.Windows.Forms.Label lblSTRLabel;
        internal System.Windows.Forms.Label lblREA;
        internal System.Windows.Forms.Label lblREALabel;
        internal System.Windows.Forms.Label lblAGI;
        internal System.Windows.Forms.Label lblAGILabel;
        internal System.Windows.Forms.Label lblBOD;
        internal System.Windows.Forms.Label lblBODLabel;
        internal System.Windows.Forms.ListBox lstMetatypes;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
