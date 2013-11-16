namespace BroachingAnalysis
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();


#if DEBUG
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();

                        // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";

            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
#endif


            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.portConnection = new System.IO.Ports.SerialPort(this.components);
            this.workerConnection = new System.ComponentModel.BackgroundWorker();
            this.pbLower = new System.Windows.Forms.ProgressBar();
            this.pbUpper = new System.Windows.Forms.ProgressBar();
            this.pbInLower = new System.Windows.Forms.ProgressBar();
            this.pbInUpper = new System.Windows.Forms.ProgressBar();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.lblSlotnoMax = new System.Windows.Forms.Label();
            this.lblSteelnoMax = new System.Windows.Forms.Label();
            this.lblSlotnoOutof = new System.Windows.Forms.Label();
            this.lblSteelnoOutof = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.lblSerialnoValue = new System.Windows.Forms.Label();
            this.lblSlotnoValue = new System.Windows.Forms.Label();
            this.lblSteelnoValue = new System.Windows.Forms.Label();
            this.lblPartnoValue = new System.Windows.Forms.Label();
            this.lblSerialno = new System.Windows.Forms.Label();
            this.lblSlotno = new System.Windows.Forms.Label();
            this.lblSteelno = new System.Windows.Forms.Label();
            this.lblPartno = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(302, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(475, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Broaching Analysis Software";
            // 
            // btnAdvance
            // 
            this.btnAdvance.Enabled = false;
            this.btnAdvance.Location = new System.Drawing.Point(547, 129);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(207, 63);
            this.btnAdvance.TabIndex = 2;
            this.btnAdvance.Text = "Start";
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(547, 235);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(207, 63);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(105, 17);
            this.tsStatus.Text = "No known status...";
            // 
            // portConnection
            // 
            this.portConnection.PortName = "NULL";
            this.portConnection.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.portConnection_DataReceived);
            // 
            // pbLower
            // 
            this.pbLower.ForeColor = System.Drawing.Color.Red;
            this.pbLower.Location = new System.Drawing.Point(12, 398);
            this.pbLower.Name = "pbLower";
            this.pbLower.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pbLower.RightToLeftLayout = true;
            this.pbLower.Size = new System.Drawing.Size(108, 49);
            this.pbLower.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbLower.TabIndex = 5;
            // 
            // pbUpper
            // 
            this.pbUpper.ForeColor = System.Drawing.Color.Red;
            this.pbUpper.Location = new System.Drawing.Point(644, 398);
            this.pbUpper.Name = "pbUpper";
            this.pbUpper.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pbUpper.Size = new System.Drawing.Size(128, 49);
            this.pbUpper.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbUpper.TabIndex = 8;
            // 
            // pbInLower
            // 
            this.pbInLower.ForeColor = System.Drawing.Color.Lime;
            this.pbInLower.Location = new System.Drawing.Point(126, 398);
            this.pbInLower.Name = "pbInLower";
            this.pbInLower.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pbInLower.Size = new System.Drawing.Size(264, 49);
            this.pbInLower.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbInLower.TabIndex = 6;
            // 
            // pbInUpper
            // 
            this.pbInUpper.ForeColor = System.Drawing.Color.Lime;
            this.pbInUpper.Location = new System.Drawing.Point(396, 398);
            this.pbInUpper.Name = "pbInUpper";
            this.pbInUpper.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pbInUpper.RightToLeftLayout = true;
            this.pbInUpper.Size = new System.Drawing.Size(242, 49);
            this.pbInUpper.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbInUpper.TabIndex = 7;

            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.trackBar.Enabled = false;
            this.trackBar.Location = new System.Drawing.Point(12, 343);
            this.trackBar.Maximum = 38;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(760, 45);
            this.trackBar.TabIndex = 4;
            this.trackBar.Value = 19;

            // 
            // lblSlotnoMax
            // 
            this.lblSlotnoMax.AutoSize = true;
            this.lblSlotnoMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlotnoMax.Location = new System.Drawing.Point(410, 216);
            this.lblSlotnoMax.Name = "lblSlotnoMax";
            this.lblSlotnoMax.Size = new System.Drawing.Size(38, 31);
            this.lblSlotnoMax.TabIndex = 28;
            this.lblSlotnoMax.Text = "...";
            // 
            // lblSteelnoMax
            // 
            this.lblSteelnoMax.AutoSize = true;
            this.lblSteelnoMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteelnoMax.Location = new System.Drawing.Point(410, 175);
            this.lblSteelnoMax.Name = "lblSteelnoMax";
            this.lblSteelnoMax.Size = new System.Drawing.Size(38, 31);
            this.lblSteelnoMax.TabIndex = 27;
            this.lblSteelnoMax.Text = "...";
            // 
            // lblSlotnoOutof
            // 
            this.lblSlotnoOutof.AutoSize = true;
            this.lblSlotnoOutof.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlotnoOutof.Location = new System.Drawing.Point(373, 216);
            this.lblSlotnoOutof.Name = "lblSlotnoOutof";
            this.lblSlotnoOutof.Size = new System.Drawing.Size(22, 31);
            this.lblSlotnoOutof.TabIndex = 26;
            this.lblSlotnoOutof.Text = "/";
            // 
            // lblSteelnoOutof
            // 
            this.lblSteelnoOutof.AutoSize = true;
            this.lblSteelnoOutof.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteelnoOutof.Location = new System.Drawing.Point(373, 175);
            this.lblSteelnoOutof.Name = "lblSteelnoOutof";
            this.lblSteelnoOutof.Size = new System.Drawing.Size(22, 31);
            this.lblSteelnoOutof.TabIndex = 24;
            this.lblSteelnoOutof.Text = "/";
            // 
            // txtSerial
            // 
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(179, 258);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(305, 38);
            this.txtSerial.TabIndex = 29;
            this.txtSerial.TextChanged += new System.EventHandler(this.txtSerial_TextChanged);
            this.txtSerial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerial_KeyPress);
            // 
            // lblSerialnoValue
            // 
            this.lblSerialnoValue.AutoSize = true;
            this.lblSerialnoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialnoValue.Location = new System.Drawing.Point(173, 258);
            this.lblSerialnoValue.Name = "lblSerialnoValue";
            this.lblSerialnoValue.Size = new System.Drawing.Size(38, 31);
            this.lblSerialnoValue.TabIndex = 25;
            this.lblSerialnoValue.Text = "...";
            // 
            // lblSlotnoValue
            // 
            this.lblSlotnoValue.AutoSize = true;
            this.lblSlotnoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlotnoValue.Location = new System.Drawing.Point(173, 216);
            this.lblSlotnoValue.Name = "lblSlotnoValue";
            this.lblSlotnoValue.Size = new System.Drawing.Size(38, 31);
            this.lblSlotnoValue.TabIndex = 23;
            this.lblSlotnoValue.Text = "...";
            // 
            // lblSteelnoValue
            // 
            this.lblSteelnoValue.AutoSize = true;
            this.lblSteelnoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteelnoValue.Location = new System.Drawing.Point(173, 175);
            this.lblSteelnoValue.Name = "lblSteelnoValue";
            this.lblSteelnoValue.Size = new System.Drawing.Size(38, 31);
            this.lblSteelnoValue.TabIndex = 22;
            this.lblSteelnoValue.Text = "...";
            // 
            // lblPartnoValue
            // 
            this.lblPartnoValue.AutoSize = true;
            this.lblPartnoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartnoValue.Location = new System.Drawing.Point(173, 129);
            this.lblPartnoValue.Name = "lblPartnoValue";
            this.lblPartnoValue.Size = new System.Drawing.Size(38, 31);
            this.lblPartnoValue.TabIndex = 21;
            this.lblPartnoValue.Text = "...";
            // 
            // lblSerialno
            // 
            this.lblSerialno.AutoSize = true;
            this.lblSerialno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialno.Location = new System.Drawing.Point(36, 258);
            this.lblSerialno.Name = "lblSerialno";
            this.lblSerialno.Size = new System.Drawing.Size(128, 31);
            this.lblSerialno.TabIndex = 20;
            this.lblSerialno.Text = "Serial no:";
            // 
            // lblSlotno
            // 
            this.lblSlotno.AutoSize = true;
            this.lblSlotno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlotno.Location = new System.Drawing.Point(36, 216);
            this.lblSlotno.Name = "lblSlotno";
            this.lblSlotno.Size = new System.Drawing.Size(106, 31);
            this.lblSlotno.TabIndex = 19;
            this.lblSlotno.Text = "Slot no:";
            // 
            // lblSteelno
            // 
            this.lblSteelno.AutoSize = true;
            this.lblSteelno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteelno.Location = new System.Drawing.Point(36, 175);
            this.lblSteelno.Name = "lblSteelno";
            this.lblSteelno.Size = new System.Drawing.Size(121, 31);
            this.lblSteelno.TabIndex = 18;
            this.lblSteelno.Text = "Steel no:";
            // 
            // lblPartno
            // 
            this.lblPartno.AutoSize = true;
            this.lblPartno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartno.Location = new System.Drawing.Point(36, 129);
            this.lblPartno.Name = "lblPartno";
            this.lblPartno.Size = new System.Drawing.Size(109, 31);
            this.lblPartno.TabIndex = 17;
            this.lblPartno.Text = "Part no:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 486);
            this.label5.MaximumSize = new System.Drawing.Size(750, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 31;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(28, 486);
            this.lblInstructions.MaximumSize = new System.Drawing.Size(750, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(0, 20);
            this.lblInstructions.TabIndex = 32;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::BroachingAnalysis.Properties.Resources.logo_final;
            this.pbLogo.Location = new System.Drawing.Point(-5, -28);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(316, 172);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSlotnoMax);
            this.Controls.Add(this.lblSteelnoMax);
            this.Controls.Add(this.lblSlotnoOutof);
            this.Controls.Add(this.lblSteelnoOutof);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.lblSerialnoValue);
            this.Controls.Add(this.lblSlotnoValue);
            this.Controls.Add(this.lblSteelnoValue);
            this.Controls.Add(this.lblPartnoValue);
            this.Controls.Add(this.lblSerialno);
            this.Controls.Add(this.lblSlotno);
            this.Controls.Add(this.lblSteelno);
            this.Controls.Add(this.lblPartno);
            this.Controls.Add(this.pbInUpper);
            this.Controls.Add(this.pbInLower);
            this.Controls.Add(this.pbUpper);
            this.Controls.Add(this.pbLower);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnAdvance);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.trackBar);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Broaching Analysis Software";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.IO.Ports.SerialPort portConnection;
        private System.ComponentModel.BackgroundWorker workerConnection;
        private System.Windows.Forms.ProgressBar pbLower;
        private System.Windows.Forms.ProgressBar pbUpper;
        private System.Windows.Forms.ProgressBar pbInLower;
        private System.Windows.Forms.ProgressBar pbInUpper;
#if DEBUG
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
#endif
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label lblSlotnoMax;
        private System.Windows.Forms.Label lblSteelnoMax;
        private System.Windows.Forms.Label lblSlotnoOutof;
        private System.Windows.Forms.Label lblSteelnoOutof;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label lblSerialnoValue;
        private System.Windows.Forms.Label lblSlotnoValue;
        private System.Windows.Forms.Label lblSteelnoValue;
        private System.Windows.Forms.Label lblPartnoValue;
        private System.Windows.Forms.Label lblSerialno;
        private System.Windows.Forms.Label lblSlotno;
        private System.Windows.Forms.Label lblSteelno;
        private System.Windows.Forms.Label lblPartno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInstructions;
    }
}

