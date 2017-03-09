namespace CarpetCostCalculator
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.widthText = new System.Windows.Forms.TextBox();
            this.lengthText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.irregRadio = new System.Windows.Forms.RadioButton();
            this.installList = new System.Windows.Forms.ListBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.installFeeLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.costList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(87, 51);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(448, 37);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Sean\'s Carpet Cost Calculator";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaLabel.Location = new System.Drawing.Point(94, 161);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(57, 25);
            this.areaLabel.TabIndex = 2;
            this.areaLabel.Text = "Area";
            // 
            // widthText
            // 
            this.widthText.Location = new System.Drawing.Point(99, 210);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(111, 20);
            this.widthText.TabIndex = 3;
            this.widthText.TextChanged += new System.EventHandler(this.widthText_TextChanged);
            // 
            // lengthText
            // 
            this.lengthText.Location = new System.Drawing.Point(99, 252);
            this.lengthText.Name = "lengthText";
            this.lengthText.Size = new System.Drawing.Size(111, 20);
            this.lengthText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Width";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Length";
            // 
            // irregRadio
            // 
            this.irregRadio.AutoSize = true;
            this.irregRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irregRadio.Location = new System.Drawing.Point(99, 297);
            this.irregRadio.Name = "irregRadio";
            this.irregRadio.Size = new System.Drawing.Size(86, 24);
            this.irregRadio.TabIndex = 9;
            this.irregRadio.TabStop = true;
            this.irregRadio.Text = "Irregular";
            this.irregRadio.UseVisualStyleBackColor = true;
            // 
            // installList
            // 
            this.installList.FormattingEnabled = true;
            this.installList.Location = new System.Drawing.Point(415, 210);
            this.installList.Name = "installList";
            this.installList.Size = new System.Drawing.Size(120, 95);
            this.installList.TabIndex = 10;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(263, 161);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(56, 25);
            this.costLabel.TabIndex = 12;
            this.costLabel.Text = "Cost";
            // 
            // installFeeLabel
            // 
            this.installFeeLabel.AutoSize = true;
            this.installFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installFeeLabel.Location = new System.Drawing.Point(410, 161);
            this.installFeeLabel.Name = "installFeeLabel";
            this.installFeeLabel.Size = new System.Drawing.Size(162, 25);
            this.installFeeLabel.TabIndex = 13;
            this.installFeeLabel.Text = "After Install Fee";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(99, 378);
            this.calcButton.Name = "calcButton";
            this.calcButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 15;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(268, 378);
            this.clearButton.Name = "clearButton";
            this.clearButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(460, 378);
            this.exitButton.Name = "exitButton";
            this.exitButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // costList
            // 
            this.costList.FormattingEnabled = true;
            this.costList.Location = new System.Drawing.Point(268, 210);
            this.costList.Name = "costList";
            this.costList.Size = new System.Drawing.Size(120, 95);
            this.costList.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 465);
            this.Controls.Add(this.costList);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.installFeeLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.installList);
            this.Controls.Add(this.irregRadio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lengthText);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.TextBox widthText;
        private System.Windows.Forms.TextBox lengthText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton irregRadio;
        private System.Windows.Forms.ListBox installList;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label installFeeLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox costList;
    }
}

