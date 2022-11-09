namespace BestOilMVP
{
    partial class Form1
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
            this.calcBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.priceTxtB = new System.Windows.Forms.TextBox();
            this.priceRadioBtn = new System.Windows.Forms.RadioButton();
            this.literTxtB = new System.Windows.Forms.TextBox();
            this.literRadioBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fuelTypeComboB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fuelTypePriceTxtB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.Color.Yellow;
            this.calcBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calcBtn.Location = new System.Drawing.Point(547, 609);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(231, 73);
            this.calcBtn.TabIndex = 7;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.priceTxtB);
            this.groupBox1.Controls.Add(this.priceRadioBtn);
            this.groupBox1.Controls.Add(this.literTxtB);
            this.groupBox1.Controls.Add(this.literRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 184);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // priceTxtB
            // 
            this.priceTxtB.Location = new System.Drawing.Point(156, 111);
            this.priceTxtB.Multiline = true;
            this.priceTxtB.Name = "priceTxtB";
            this.priceTxtB.Size = new System.Drawing.Size(125, 34);
            this.priceTxtB.TabIndex = 9;
            // 
            // priceRadioBtn
            // 
            this.priceRadioBtn.AutoSize = true;
            this.priceRadioBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceRadioBtn.Location = new System.Drawing.Point(18, 103);
            this.priceRadioBtn.Name = "priceRadioBtn";
            this.priceRadioBtn.Size = new System.Drawing.Size(102, 42);
            this.priceRadioBtn.TabIndex = 7;
            this.priceRadioBtn.Text = "Price";
            this.priceRadioBtn.UseVisualStyleBackColor = true;
            // 
            // literTxtB
            // 
            this.literTxtB.Enabled = false;
            this.literTxtB.Location = new System.Drawing.Point(156, 42);
            this.literTxtB.Multiline = true;
            this.literTxtB.Name = "literTxtB";
            this.literTxtB.Size = new System.Drawing.Size(125, 34);
            this.literTxtB.TabIndex = 10;
            this.literTxtB.TextChanged += new System.EventHandler(this.literTxtB_TextChanged);
            // 
            // literRadioBtn
            // 
            this.literRadioBtn.AutoSize = true;
            this.literRadioBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.literRadioBtn.Location = new System.Drawing.Point(18, 34);
            this.literRadioBtn.Name = "literRadioBtn";
            this.literRadioBtn.Size = new System.Drawing.Size(97, 42);
            this.literRadioBtn.TabIndex = 8;
            this.literRadioBtn.Text = "Liter";
            this.literRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "AYDINOIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fuel Types";
            // 
            // fuelTypeComboB
            // 
            this.fuelTypeComboB.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.fuelTypeComboB.FormattingEnabled = true;
            this.fuelTypeComboB.Location = new System.Drawing.Point(184, 110);
            this.fuelTypeComboB.Name = "fuelTypeComboB";
            this.fuelTypeComboB.Size = new System.Drawing.Size(151, 39);
            this.fuelTypeComboB.TabIndex = 2;
            this.fuelTypeComboB.SelectedIndexChanged += new System.EventHandler(this.fuelTypeComboB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // fuelTypePriceTxtB
            // 
            this.fuelTypePriceTxtB.Enabled = false;
            this.fuelTypePriceTxtB.Location = new System.Drawing.Point(184, 213);
            this.fuelTypePriceTxtB.Multiline = true;
            this.fuelTypePriceTxtB.Name = "fuelTypePriceTxtB";
            this.fuelTypePriceTxtB.Size = new System.Drawing.Size(98, 45);
            this.fuelTypePriceTxtB.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(801, 732);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.fuelTypePriceTxtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fuelTypeComboB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button calcBtn;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private ComboBox fuelTypeComboB;
        private Label label3;
        private TextBox fuelTypePriceTxtB;
        public TextBox priceTxtB;
        public RadioButton priceRadioBtn;
        public TextBox literTxtB;
        private RadioButton literRadioBtn;
    }
}