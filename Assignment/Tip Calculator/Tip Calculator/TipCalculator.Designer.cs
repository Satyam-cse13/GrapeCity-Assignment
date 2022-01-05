namespace Tip_Calculator
{
    partial class tipCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tipCalc));
            this.calc = new System.Windows.Forms.Button();
            this.tipTotal = new System.Windows.Forms.Label();
            this.peopleAmt = new System.Windows.Forms.NumericUpDown();
            this.tipAmt = new System.Windows.Forms.NumericUpDown();
            this.biLLBox = new System.Windows.Forms.TextBox();
            this.tip = new System.Windows.Forms.TextBox();
            this.nop = new System.Windows.Forms.TextBox();
            this.billAmt = new System.Windows.Forms.TextBox();
            this.tip_textbox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.billtotal = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.peopleAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // calc
            // 
            resources.ApplyResources(this.calc, "calc");
            this.calc.Name = "calc";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // tipTotal
            // 
            this.tipTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.tipTotal, "tipTotal");
            this.tipTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tipTotal.Name = "tipTotal";
            // 
            // peopleAmt
            // 
            this.peopleAmt.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.peopleAmt, "peopleAmt");
            this.peopleAmt.ForeColor = System.Drawing.SystemColors.Info;
            this.peopleAmt.Name = "peopleAmt";
            // 
            // tipAmt
            // 
            this.tipAmt.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.tipAmt, "tipAmt");
            this.tipAmt.ForeColor = System.Drawing.SystemColors.Info;
            this.tipAmt.Name = "tipAmt";
            this.tipAmt.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // biLLBox
            // 
            this.biLLBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.biLLBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.biLLBox, "biLLBox");
            this.biLLBox.Name = "biLLBox";
            this.biLLBox.ReadOnly = true;
            // 
            // tip
            // 
            this.tip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tip, "tip");
            this.tip.Name = "tip";
            this.tip.ReadOnly = true;
            // 
            // nop
            // 
            this.nop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.nop, "nop");
            this.nop.Name = "nop";
            this.nop.ReadOnly = true;
            // 
            // billAmt
            // 
            this.billAmt.BackColor = System.Drawing.SystemColors.InfoText;
            resources.ApplyResources(this.billAmt, "billAmt");
            this.billAmt.ForeColor = System.Drawing.SystemColors.Info;
            this.billAmt.Name = "billAmt";
            this.billAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.billAmt_KeyPress);
            // 
            // tip_textbox
            // 
            this.tip_textbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tip_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tip_textbox, "tip_textbox");
            this.tip_textbox.Name = "tip_textbox";
            this.tip_textbox.ReadOnly = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            // 
            // billtotal
            // 
            this.billtotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.billtotal, "billtotal");
            this.billtotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.billtotal.Name = "billtotal";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tipCalc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.billtotal);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tip_textbox);
            this.Controls.Add(this.billAmt);
            this.Controls.Add(this.nop);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.biLLBox);
            this.Controls.Add(this.tipAmt);
            this.Controls.Add(this.peopleAmt);
            this.Controls.Add(this.tipTotal);
            this.Controls.Add(this.calc);
            this.Name = "tipCalc";
            ((System.ComponentModel.ISupportInitialize)(this.peopleAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label tipTotal;
        private System.Windows.Forms.NumericUpDown peopleAmt;
        private System.Windows.Forms.NumericUpDown tipAmt;
        private System.Windows.Forms.TextBox biLLBox;
        private System.Windows.Forms.TextBox tip;
        private System.Windows.Forms.TextBox nop;
        private System.Windows.Forms.TextBox billAmt;
        private System.Windows.Forms.TextBox tip_textbox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label billtotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
    }
}

