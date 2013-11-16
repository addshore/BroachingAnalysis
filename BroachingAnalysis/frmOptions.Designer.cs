namespace BroachingAnalysis
{
    partial class frmOptions
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
            this.cbPartNo = new System.Windows.Forms.ComboBox();
            this.btnZero = new System.Windows.Forms.Button();
            this.llblOptionsAdv = new System.Windows.Forms.LinkLabel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.gbAdvanced = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbPartSelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPartno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSteel = new System.Windows.Forms.TextBox();
            this.txtTolerance = new System.Windows.Forms.TextBox();
            this.txtSlots = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtRingcount = new System.Windows.Forms.TextBox();
            this.btnUnzero = new System.Windows.Forms.Button();
            this.gbOptions.SuspendLayout();
            this.gbAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPartNo
            // 
            this.cbPartNo.FormattingEnabled = true;
            this.cbPartNo.Location = new System.Drawing.Point(6, 19);
            this.cbPartNo.Name = "cbPartNo";
            this.cbPartNo.Size = new System.Drawing.Size(121, 21);
            this.cbPartNo.TabIndex = 0;
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(23, 58);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 23);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "Zero Value";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // llblOptionsAdv
            // 
            this.llblOptionsAdv.AutoSize = true;
            this.llblOptionsAdv.Location = new System.Drawing.Point(12, 282);
            this.llblOptionsAdv.Name = "llblOptionsAdv";
            this.llblOptionsAdv.Size = new System.Drawing.Size(107, 13);
            this.llblOptionsAdv.TabIndex = 1;
            this.llblOptionsAdv.TabStop = true;
            this.llblOptionsAdv.Text = "Advanced Options ...";
            this.llblOptionsAdv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblOptionsAdv_LinkClicked);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(219, 273);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(300, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.cbPartNo);
            this.gbOptions.Controls.Add(this.btnZero);
            this.gbOptions.Location = new System.Drawing.Point(12, 12);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(136, 255);
            this.gbOptions.TabIndex = 0;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // gbAdvanced
            // 
            this.gbAdvanced.Controls.Add(this.btnAdd);
            this.gbAdvanced.Controls.Add(this.btnDelete);
            this.gbAdvanced.Controls.Add(this.cbPartSelect);
            this.gbAdvanced.Controls.Add(this.label5);
            this.gbAdvanced.Controls.Add(this.label4);
            this.gbAdvanced.Controls.Add(this.txtPartno);
            this.gbAdvanced.Controls.Add(this.label3);
            this.gbAdvanced.Controls.Add(this.label2);
            this.gbAdvanced.Controls.Add(this.label1);
            this.gbAdvanced.Controls.Add(this.txtSteel);
            this.gbAdvanced.Controls.Add(this.txtTolerance);
            this.gbAdvanced.Controls.Add(this.txtSlots);
            this.gbAdvanced.Controls.Add(this.lblCount);
            this.gbAdvanced.Controls.Add(this.txtRingcount);
            this.gbAdvanced.Controls.Add(this.btnUnzero);
            this.gbAdvanced.Location = new System.Drawing.Point(154, 12);
            this.gbAdvanced.Name = "gbAdvanced";
            this.gbAdvanced.Size = new System.Drawing.Size(227, 255);
            this.gbAdvanced.TabIndex = 4;
            this.gbAdvanced.TabStop = false;
            this.gbAdvanced.Text = "Advanced";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(65, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(146, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbPartSelect
            // 
            this.cbPartSelect.FormattingEnabled = true;
            this.cbPartSelect.Location = new System.Drawing.Point(75, 84);
            this.cbPartSelect.Name = "cbPartSelect";
            this.cbPartSelect.Size = new System.Drawing.Size(121, 21);
            this.cbPartSelect.TabIndex = 5;
            this.cbPartSelect.SelectedIndexChanged += new System.EventHandler(this.cbPartSelect_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select..";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Part No";
            // 
            // txtPartno
            // 
            this.txtPartno.Location = new System.Drawing.Point(75, 113);
            this.txtPartno.Name = "txtPartno";
            this.txtPartno.Size = new System.Drawing.Size(100, 20);
            this.txtPartno.TabIndex = 7;
            this.txtPartno.TextChanged += new System.EventHandler(this.txtPart_TextChanged);
            this.txtPartno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartno_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Steels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tolerance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Slots";
            // 
            // txtSteel
            // 
            this.txtSteel.Location = new System.Drawing.Point(76, 191);
            this.txtSteel.Name = "txtSteel";
            this.txtSteel.Size = new System.Drawing.Size(100, 20);
            this.txtSteel.TabIndex = 13;
            this.txtSteel.TextChanged += new System.EventHandler(this.txtPart_TextChanged);
            this.txtSteel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSteel_KeyPress);
            // 
            // txtTolerance
            // 
            this.txtTolerance.Location = new System.Drawing.Point(76, 165);
            this.txtTolerance.Name = "txtTolerance";
            this.txtTolerance.Size = new System.Drawing.Size(100, 20);
            this.txtTolerance.TabIndex = 11;
            this.txtTolerance.TextChanged += new System.EventHandler(this.txtPart_TextChanged);
            this.txtTolerance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTolerance_KeyPress);
            // 
            // txtSlots
            // 
            this.txtSlots.Location = new System.Drawing.Point(76, 139);
            this.txtSlots.Name = "txtSlots";
            this.txtSlots.Size = new System.Drawing.Size(100, 20);
            this.txtSlots.TabIndex = 9;
            this.txtSlots.TextChanged += new System.EventHandler(this.txtPart_TextChanged);
            this.txtSlots.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSlots_KeyPress);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(6, 22);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(63, 13);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "Ring Count:";
            // 
            // txtRingcount
            // 
            this.txtRingcount.Location = new System.Drawing.Point(75, 19);
            this.txtRingcount.Name = "txtRingcount";
            this.txtRingcount.Size = new System.Drawing.Size(100, 20);
            this.txtRingcount.TabIndex = 1;
            this.txtRingcount.Text = "944000";
            this.txtRingcount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRingcount_KeyPress);
            // 
            // btnUnzero
            // 
            this.btnUnzero.Location = new System.Drawing.Point(6, 45);
            this.btnUnzero.Name = "btnUnzero";
            this.btnUnzero.Size = new System.Drawing.Size(75, 23);
            this.btnUnzero.TabIndex = 3;
            this.btnUnzero.Text = "Un-Zero";
            this.btnUnzero.UseVisualStyleBackColor = true;
            this.btnUnzero.Click += new System.EventHandler(this.btnUnzero_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 312);
            this.Controls.Add(this.gbAdvanced);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.llblOptionsAdv);
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.gbOptions.ResumeLayout(false);
            this.gbAdvanced.ResumeLayout(false);
            this.gbAdvanced.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPartNo;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.LinkLabel llblOptionsAdv;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.GroupBox gbAdvanced;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtRingcount;
        private System.Windows.Forms.Button btnUnzero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPartno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSteel;
        private System.Windows.Forms.TextBox txtTolerance;
        private System.Windows.Forms.TextBox txtSlots;
        private System.Windows.Forms.ComboBox cbPartSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}