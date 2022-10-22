
namespace FlairFrameworkCreatePropertiesApp
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
            this.lbBlockSize = new System.Windows.Forms.ListBox();
            this.lbPropertyDefinition = new System.Windows.Forms.ListBox();
            this.lbPropertyVariable = new System.Windows.Forms.ListBox();
            this.btnRender = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.cbImportant = new System.Windows.Forms.CheckBox();
            this.cbPrecize = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbProperty = new System.Windows.Forms.ListBox();
            this.psFrom = new System.Windows.Forms.TextBox();
            this.mainStep = new System.Windows.Forms.TextBox();
            this.mainTo = new System.Windows.Forms.TextBox();
            this.mainFrom = new System.Windows.Forms.TextBox();
            this.psStep = new System.Windows.Forms.TextBox();
            this.psTo = new System.Windows.Forms.TextBox();
            this.cbFileType = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbBlockSize
            // 
            this.lbBlockSize.FormattingEnabled = true;
            this.lbBlockSize.Items.AddRange(new object[] {
            "xs",
            "s",
            "m",
            "l",
            "xl"});
            this.lbBlockSize.Location = new System.Drawing.Point(63, 62);
            this.lbBlockSize.Name = "lbBlockSize";
            this.lbBlockSize.Size = new System.Drawing.Size(84, 511);
            this.lbBlockSize.TabIndex = 0;
            // 
            // lbPropertyDefinition
            // 
            this.lbPropertyDefinition.FormattingEnabled = true;
            this.lbPropertyDefinition.Items.AddRange(new object[] {
            "width",
            "width",
            "height",
            "height",
            "font-size",
            "border-width",
            "border-top-width",
            "border-right-width",
            "border-bottom-width",
            "border-left-width",
            "border-left-width|border-right-width",
            "border-top-width|border-bottom-width",
            "border-top-width",
            "border-right-width",
            "border-bottom-width",
            "border-left-width",
            "border-left-width|border-right-width",
            "border-top-width|border-bottom-width",
            "border-top-width",
            "border-right-width",
            "border-bottom-width",
            "border-left-width",
            "border-left-width|border-right-width",
            "border-top-width|border-bottom-width",
            "margin",
            "margin-top",
            "margin-right",
            "margin-bottom",
            "margin-left",
            "margin-left|margin-right",
            "margin-top|margin-bottom",
            "margin-top",
            "margin-right",
            "margin-bottom",
            "margin-left",
            "margin-left|margin-right",
            "margin-top|margin-bottom",
            "margin-top",
            "margin-right",
            "margin-bottom",
            "margin-left",
            "margin-left|margin-right",
            "margin-top|margin-bottom",
            "padding",
            "padding-top",
            "padding-right",
            "padding-bottom",
            "padding-left",
            "padding-left|padding-right",
            "padding-top|padding-bottom",
            "padding-top",
            "padding-right",
            "padding-bottom",
            "padding-left",
            "padding-left|padding-right",
            "padding-top|padding-bottom",
            "padding-top",
            "padding-right",
            "padding-bottom",
            "padding-left",
            "padding-left|padding-right",
            "padding-top|padding-bottom",
            "position: relative; top",
            "position: relative; right",
            "position: relative; bottom",
            "position: relative; left",
            "position: relative; top",
            "position: relative; right",
            "position: relative; bottom",
            "position: relative; left",
            "position: relative; top",
            "position: relative; right",
            "position: relative; bottom",
            "position: relative; left",
            "border-radius",
            "border-top-left-radius",
            "border-top-right-radius",
            "border-bottom-left-radius",
            "border-bottom-right-radius",
            "border-top-left-radius|border-bottom-left-radius",
            "border-top-right-radius|border-bottom-right-radius",
            "border-top-left-radius|border-top-right-radius",
            "border-bottom-left-radius|border-bottom-right-radius",
            "border-top-left-radius|border-bottom-right-radius",
            "border-top-right-radius|border-bottom-left-radius"});
            this.lbPropertyDefinition.Location = new System.Drawing.Point(440, 62);
            this.lbPropertyDefinition.Name = "lbPropertyDefinition";
            this.lbPropertyDefinition.Size = new System.Drawing.Size(320, 511);
            this.lbPropertyDefinition.TabIndex = 2;
            // 
            // lbPropertyVariable
            // 
            this.lbPropertyVariable.FormattingEnabled = true;
            this.lbPropertyVariable.Items.AddRange(new object[] {
            "--xswunit1_00",
            "--swunit1_00",
            "--mwunit1_00",
            "--lwunit1_00",
            "--xlwunit1_00"});
            this.lbPropertyVariable.Location = new System.Drawing.Point(810, 62);
            this.lbPropertyVariable.Name = "lbPropertyVariable";
            this.lbPropertyVariable.Size = new System.Drawing.Size(194, 511);
            this.lbPropertyVariable.TabIndex = 3;
            // 
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(63, 605);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(941, 52);
            this.btnRender.TabIndex = 4;
            this.btnRender.Text = "Render properties";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(194, 698);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(810, 20);
            this.tbFileName.TabIndex = 5;
            // 
            // cbImportant
            // 
            this.cbImportant.AutoSize = true;
            this.cbImportant.Location = new System.Drawing.Point(1099, 62);
            this.cbImportant.Name = "cbImportant";
            this.cbImportant.Size = new System.Drawing.Size(94, 17);
            this.cbImportant.TabIndex = 6;
            this.cbImportant.Text = "Important CSS";
            this.cbImportant.UseVisualStyleBackColor = true;
            // 
            // cbPrecize
            // 
            this.cbPrecize.AutoSize = true;
            this.cbPrecize.Location = new System.Drawing.Point(1099, 85);
            this.cbPrecize.Name = "cbPrecize";
            this.cbPrecize.Size = new System.Drawing.Size(86, 17);
            this.cbPrecize.TabIndex = 7;
            this.cbPrecize.Text = "Precize Start";
            this.cbPrecize.UseVisualStyleBackColor = true;
            this.cbPrecize.CheckedChanged += new System.EventHandler(this.cbPrecize_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1096, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1096, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1097, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Step";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1097, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Step";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1096, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1096, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1096, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Main part";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Block SIze";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Property";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Property Definition";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(807, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Property Variable";
            // 
            // lbProperty
            // 
            this.lbProperty.FormattingEnabled = true;
            this.lbProperty.Items.AddRange(new object[] {
            "w",
            "wi&I",
            "h",
            "hi&I",
            "t",
            "b",
            "bt",
            "br",
            "bb",
            "bl",
            "bh",
            "bv",
            "bti&I",
            "bri&I",
            "bbi&I",
            "bli&I",
            "bhi&I",
            "bvi&I",
            "bthi&HI",
            "brhi&HI",
            "bbhi&HI",
            "blhi&HI",
            "bhhi&HI",
            "bvhi&HI",
            "m",
            "mt",
            "mr",
            "mb",
            "ml",
            "mh",
            "mv",
            "mti&I",
            "mri&I",
            "mbi&I",
            "mli&I",
            "mhi&I",
            "mvi&I",
            "mthi&HI",
            "mrhi&HI",
            "mbhi&HI",
            "mlhi&HI",
            "mhhi&HI",
            "mvhi&HI",
            "p",
            "pt",
            "pr",
            "pb",
            "pl",
            "ph",
            "pv",
            "pti&I",
            "pri&I",
            "pbi&I",
            "pli&I",
            "phi&I",
            "pvi&I",
            "pthi&HI",
            "prhi&HI",
            "pbhi&HI",
            "plhi&HI",
            "phhi&HI",
            "pvhi&HI",
            "lt",
            "lr",
            "lb",
            "ll",
            "lti&I",
            "lri&I",
            "lbi&I",
            "lli&I",
            "lthi&HI",
            "lrhi&HI",
            "lbhi&HI",
            "llhi&HI",
            "r",
            "rtl",
            "rtr",
            "rbl",
            "rbr",
            "rvl",
            "rvr",
            "rht",
            "rhb",
            "rpd",
            "rsd"});
            this.lbProperty.Location = new System.Drawing.Point(194, 62);
            this.lbProperty.Name = "lbProperty";
            this.lbProperty.Size = new System.Drawing.Size(195, 511);
            this.lbProperty.TabIndex = 26;
            // 
            // psFrom
            // 
            this.psFrom.Location = new System.Drawing.Point(1139, 112);
            this.psFrom.Name = "psFrom";
            this.psFrom.Size = new System.Drawing.Size(54, 20);
            this.psFrom.TabIndex = 27;
            // 
            // mainStep
            // 
            this.mainStep.Location = new System.Drawing.Point(1139, 347);
            this.mainStep.Name = "mainStep";
            this.mainStep.Size = new System.Drawing.Size(54, 20);
            this.mainStep.TabIndex = 28;
            // 
            // mainTo
            // 
            this.mainTo.Location = new System.Drawing.Point(1139, 318);
            this.mainTo.Name = "mainTo";
            this.mainTo.Size = new System.Drawing.Size(54, 20);
            this.mainTo.TabIndex = 29;
            // 
            // mainFrom
            // 
            this.mainFrom.Location = new System.Drawing.Point(1139, 289);
            this.mainFrom.Name = "mainFrom";
            this.mainFrom.Size = new System.Drawing.Size(54, 20);
            this.mainFrom.TabIndex = 30;
            // 
            // psStep
            // 
            this.psStep.Location = new System.Drawing.Point(1139, 170);
            this.psStep.Name = "psStep";
            this.psStep.Size = new System.Drawing.Size(54, 20);
            this.psStep.TabIndex = 31;
            // 
            // psTo
            // 
            this.psTo.Location = new System.Drawing.Point(1139, 141);
            this.psTo.Name = "psTo";
            this.psTo.Size = new System.Drawing.Size(54, 20);
            this.psTo.TabIndex = 32;
            // 
            // cbFileType
            // 
            this.cbFileType.AutoSize = true;
            this.cbFileType.Location = new System.Drawing.Point(63, 700);
            this.cbFileType.Name = "cbFileType";
            this.cbFileType.Size = new System.Drawing.Size(89, 17);
            this.cbFileType.TabIndex = 33;
            this.cbFileType.Text = "File type CSS";
            this.cbFileType.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 752);
            this.Controls.Add(this.cbFileType);
            this.Controls.Add(this.psTo);
            this.Controls.Add(this.psStep);
            this.Controls.Add(this.mainFrom);
            this.Controls.Add(this.mainTo);
            this.Controls.Add(this.mainStep);
            this.Controls.Add(this.psFrom);
            this.Controls.Add(this.lbProperty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPrecize);
            this.Controls.Add(this.cbImportant);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.lbPropertyVariable);
            this.Controls.Add(this.lbPropertyDefinition);
            this.Controls.Add(this.lbBlockSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBlockSize;
        private System.Windows.Forms.ListBox lbPropertyDefinition;
        private System.Windows.Forms.ListBox lbPropertyVariable;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.CheckBox cbImportant;
        private System.Windows.Forms.CheckBox cbPrecize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbProperty;
        private System.Windows.Forms.TextBox psFrom;
        private System.Windows.Forms.TextBox mainStep;
        private System.Windows.Forms.TextBox mainTo;
        private System.Windows.Forms.TextBox mainFrom;
        private System.Windows.Forms.TextBox psStep;
        private System.Windows.Forms.TextBox psTo;
        private System.Windows.Forms.CheckBox cbFileType;
    }
}

