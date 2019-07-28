namespace RuleEngineApp
{
    partial class Form1
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
            this.btnbrowse = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.dlgOpenInputFile = new System.Windows.Forms.OpenFileDialog();
            this.grpbxRunRule = new System.Windows.Forms.GroupBox();
            this.btnGetAllData = new System.Windows.Forms.Button();
            this.dgRuleResult = new System.Windows.Forms.DataGridView();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.grpbxSetRule = new System.Windows.Forms.GroupBox();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.lstRuleList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRuleRelation = new System.Windows.Forms.ComboBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.cmbValueTypes = new System.Windows.Forms.ComboBox();
            this.tbSignalID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetRule = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnremoveRule = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.grpbxRunRule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRuleResult)).BeginInit();
            this.grpbxSetRule.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(16, 34);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(108, 27);
            this.btnbrowse.TabIndex = 0;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(13, 73);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(0, 17);
            this.lblFilePath.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(483, 131);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(142, 42);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply Rule to Stream";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // dlgOpenInputFile
            // 
            this.dlgOpenInputFile.Filter = "*.json|*.JSON";
            // 
            // grpbxRunRule
            // 
            this.grpbxRunRule.Controls.Add(this.lblCount);
            this.grpbxRunRule.Controls.Add(this.label5);
            this.grpbxRunRule.Controls.Add(this.btnGetAllData);
            this.grpbxRunRule.Controls.Add(this.dgRuleResult);
            this.grpbxRunRule.Controls.Add(this.pbStatus);
            this.grpbxRunRule.Controls.Add(this.btnbrowse);
            this.grpbxRunRule.Controls.Add(this.btnApply);
            this.grpbxRunRule.Controls.Add(this.lblFilePath);
            this.grpbxRunRule.Location = new System.Drawing.Point(12, 12);
            this.grpbxRunRule.Name = "grpbxRunRule";
            this.grpbxRunRule.Size = new System.Drawing.Size(641, 561);
            this.grpbxRunRule.TabIndex = 3;
            this.grpbxRunRule.TabStop = false;
            this.grpbxRunRule.Text = "Stream";
            // 
            // btnGetAllData
            // 
            this.btnGetAllData.Location = new System.Drawing.Point(16, 140);
            this.btnGetAllData.Name = "btnGetAllData";
            this.btnGetAllData.Size = new System.Drawing.Size(142, 42);
            this.btnGetAllData.TabIndex = 6;
            this.btnGetAllData.Text = "Get All Stream Data";
            this.btnGetAllData.UseVisualStyleBackColor = true;
            this.btnGetAllData.Click += new System.EventHandler(this.btnGetAllData_Click);
            // 
            // dgRuleResult
            // 
            this.dgRuleResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRuleResult.Location = new System.Drawing.Point(6, 241);
            this.dgRuleResult.Name = "dgRuleResult";
            this.dgRuleResult.ReadOnly = true;
            this.dgRuleResult.RowTemplate.Height = 24;
            this.dgRuleResult.Size = new System.Drawing.Size(619, 273);
            this.dgRuleResult.TabIndex = 5;
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(6, 197);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(619, 23);
            this.pbStatus.TabIndex = 4;
            // 
            // grpbxSetRule
            // 
            this.grpbxSetRule.Controls.Add(this.btnremoveRule);
            this.grpbxSetRule.Controls.Add(this.btnAddRule);
            this.grpbxSetRule.Controls.Add(this.lstRuleList);
            this.grpbxSetRule.Controls.Add(this.label4);
            this.grpbxSetRule.Controls.Add(this.label3);
            this.grpbxSetRule.Controls.Add(this.cmbRuleRelation);
            this.grpbxSetRule.Controls.Add(this.tbValue);
            this.grpbxSetRule.Controls.Add(this.cmbValueTypes);
            this.grpbxSetRule.Controls.Add(this.tbSignalID);
            this.grpbxSetRule.Controls.Add(this.label2);
            this.grpbxSetRule.Controls.Add(this.label1);
            this.grpbxSetRule.Controls.Add(this.btnSetRule);
            this.grpbxSetRule.Controls.Add(this.dateTimePicker1);
            this.grpbxSetRule.Location = new System.Drawing.Point(659, 12);
            this.grpbxSetRule.Name = "grpbxSetRule";
            this.grpbxSetRule.Size = new System.Drawing.Size(601, 561);
            this.grpbxSetRule.TabIndex = 4;
            this.grpbxSetRule.TabStop = false;
            this.grpbxSetRule.Text = "Rule";
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(433, 160);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(162, 42);
            this.btnAddRule.TabIndex = 10;
            this.btnAddRule.Text = "Add Rule";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // lstRuleList
            // 
            this.lstRuleList.FormattingEnabled = true;
            this.lstRuleList.ItemHeight = 16;
            this.lstRuleList.Location = new System.Drawing.Point(6, 241);
            this.lstRuleList.Name = "lstRuleList";
            this.lstRuleList.Size = new System.Drawing.Size(586, 244);
            this.lstRuleList.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Value ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rule";
            // 
            // cmbRuleRelation
            // 
            this.cmbRuleRelation.FormattingEnabled = true;
            this.cmbRuleRelation.Location = new System.Drawing.Point(290, 105);
            this.cmbRuleRelation.Name = "cmbRuleRelation";
            this.cmbRuleRelation.Size = new System.Drawing.Size(121, 24);
            this.cmbRuleRelation.TabIndex = 6;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(438, 107);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(157, 22);
            this.tbValue.TabIndex = 5;
            // 
            // cmbValueTypes
            // 
            this.cmbValueTypes.FormattingEnabled = true;
            this.cmbValueTypes.Location = new System.Drawing.Point(149, 105);
            this.cmbValueTypes.Name = "cmbValueTypes";
            this.cmbValueTypes.Size = new System.Drawing.Size(121, 24);
            this.cmbValueTypes.TabIndex = 4;
            this.cmbValueTypes.SelectedIndexChanged += new System.EventHandler(this.cbValueTypes_SelectedIndexChanged);
            // 
            // tbSignalID
            // 
            this.tbSignalID.Location = new System.Drawing.Point(9, 105);
            this.tbSignalID.Name = "tbSignalID";
            this.tbSignalID.Size = new System.Drawing.Size(120, 22);
            this.tbSignalID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Siganl";
            // 
            // btnSetRule
            // 
            this.btnSetRule.Location = new System.Drawing.Point(433, 499);
            this.btnSetRule.Name = "btnSetRule";
            this.btnSetRule.Size = new System.Drawing.Size(162, 42);
            this.btnSetRule.TabIndex = 0;
            this.btnSetRule.Text = "Set Rule";
            this.btnSetRule.UseVisualStyleBackColor = true;
            this.btnSetRule.Click += new System.EventHandler(this.btnSetRule_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(438, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btnremoveRule
            // 
            this.btnremoveRule.Location = new System.Drawing.Point(9, 491);
            this.btnremoveRule.Name = "btnremoveRule";
            this.btnremoveRule.Size = new System.Drawing.Size(105, 23);
            this.btnremoveRule.TabIndex = 12;
            this.btnremoveRule.Text = "Remove Rule";
            this.btnremoveRule.UseVisualStyleBackColor = true;
            this.btnremoveRule.Click += new System.EventHandler(this.btnremoveRule_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Count: ";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(65, 525);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 17);
            this.lblCount.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 613);
            this.Controls.Add(this.grpbxSetRule);
            this.Controls.Add(this.grpbxRunRule);
            this.Name = "Form1";
            this.Text = "Rule Engine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbxRunRule.ResumeLayout(false);
            this.grpbxRunRule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRuleResult)).EndInit();
            this.grpbxSetRule.ResumeLayout(false);
            this.grpbxSetRule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.OpenFileDialog dlgOpenInputFile;
        private System.Windows.Forms.GroupBox grpbxRunRule;
        private System.Windows.Forms.GroupBox grpbxSetRule;
        private System.Windows.Forms.Button btnSetRule;
        private System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.DataGridView dgRuleResult;
        private System.Windows.Forms.ComboBox cmbRuleRelation;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.ComboBox cmbValueTypes;
        private System.Windows.Forms.TextBox tbSignalID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.ListBox lstRuleList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetAllData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnremoveRule;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label5;
    }
}

