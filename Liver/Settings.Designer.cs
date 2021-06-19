using System.ComponentModel;

namespace Liver
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
	        this.groupBox1 = new System.Windows.Forms.GroupBox();
	        this.perPageMinus = new System.Windows.Forms.Button();
	        this.perPageLabel = new System.Windows.Forms.Label();
	        this.perPagePlus = new System.Windows.Forms.Button();
	        this.label6 = new System.Windows.Forms.Label();
	        this.collageColorButton = new System.Windows.Forms.Button();
	        this.collageColorPanel = new System.Windows.Forms.Panel();
	        this.label4 = new System.Windows.Forms.Label();
	        this.frameColorButton = new System.Windows.Forms.Button();
	        this.frameColorPanel = new System.Windows.Forms.Panel();
	        this.label3 = new System.Windows.Forms.Label();
	        this.groupBox1.SuspendLayout();
	        this.SuspendLayout();
	        // 
	        // groupBox1
	        // 
	        this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
	        this.groupBox1.Controls.Add(this.perPageMinus);
	        this.groupBox1.Controls.Add(this.perPageLabel);
	        this.groupBox1.Controls.Add(this.perPagePlus);
	        this.groupBox1.Controls.Add(this.label6);
	        this.groupBox1.Controls.Add(this.collageColorButton);
	        this.groupBox1.Controls.Add(this.collageColorPanel);
	        this.groupBox1.Controls.Add(this.label4);
	        this.groupBox1.Controls.Add(this.frameColorButton);
	        this.groupBox1.Controls.Add(this.frameColorPanel);
	        this.groupBox1.Controls.Add(this.label3);
	        this.groupBox1.Location = new System.Drawing.Point(12, 12);
	        this.groupBox1.Name = "groupBox1";
	        this.groupBox1.Size = new System.Drawing.Size(176, 206);
	        this.groupBox1.TabIndex = 1;
	        this.groupBox1.TabStop = false;
	        this.groupBox1.Text = "Настройки коллажа";
	        // 
	        // perPageMinus
	        // 
	        this.perPageMinus.Location = new System.Drawing.Point(54, 159);
	        this.perPageMinus.Name = "perPageMinus";
	        this.perPageMinus.Size = new System.Drawing.Size(23, 23);
	        this.perPageMinus.TabIndex = 14;
	        this.perPageMinus.Text = "-";
	        this.perPageMinus.UseVisualStyleBackColor = true;
	        this.perPageMinus.Click += new System.EventHandler(this.perPageMinus_Click);
	        // 
	        // perPageLabel
	        // 
	        this.perPageLabel.Location = new System.Drawing.Point(6, 164);
	        this.perPageLabel.Name = "perPageLabel";
	        this.perPageLabel.Size = new System.Drawing.Size(19, 23);
	        this.perPageLabel.TabIndex = 13;
	        this.perPageLabel.Text = "0";
	        // 
	        // perPagePlus
	        // 
	        this.perPagePlus.Location = new System.Drawing.Point(83, 159);
	        this.perPagePlus.Name = "perPagePlus";
	        this.perPagePlus.Size = new System.Drawing.Size(23, 23);
	        this.perPagePlus.TabIndex = 12;
	        this.perPagePlus.Text = "+";
	        this.perPagePlus.UseVisualStyleBackColor = true;
	        this.perPagePlus.Click += new System.EventHandler(this.perPagePlus_Click);
	        // 
	        // label6
	        // 
	        this.label6.Location = new System.Drawing.Point(6, 141);
	        this.label6.Name = "label6";
	        this.label6.Size = new System.Drawing.Size(100, 23);
	        this.label6.TabIndex = 11;
	        this.label6.Text = "Фото на странице";
	        // 
	        // collageColorButton
	        // 
	        this.collageColorButton.Location = new System.Drawing.Point(35, 105);
	        this.collageColorButton.Name = "collageColorButton";
	        this.collageColorButton.Size = new System.Drawing.Size(75, 23);
	        this.collageColorButton.TabIndex = 10;
	        this.collageColorButton.Text = "Выбрать";
	        this.collageColorButton.UseVisualStyleBackColor = true;
	        this.collageColorButton.Click += new System.EventHandler(this.collageColorButton_Click);
	        // 
	        // collageColorPanel
	        // 
	        this.collageColorPanel.Location = new System.Drawing.Point(6, 105);
	        this.collageColorPanel.Name = "collageColorPanel";
	        this.collageColorPanel.Size = new System.Drawing.Size(23, 23);
	        this.collageColorPanel.TabIndex = 9;
	        // 
	        // label4
	        // 
	        this.label4.Location = new System.Drawing.Point(6, 79);
	        this.label4.Name = "label4";
	        this.label4.Size = new System.Drawing.Size(100, 23);
	        this.label4.TabIndex = 8;
	        this.label4.Text = "Цвет фона";
	        // 
	        // frameColorButton
	        // 
	        this.frameColorButton.Location = new System.Drawing.Point(35, 42);
	        this.frameColorButton.Name = "frameColorButton";
	        this.frameColorButton.Size = new System.Drawing.Size(75, 23);
	        this.frameColorButton.TabIndex = 7;
	        this.frameColorButton.Text = "Выбрать";
	        this.frameColorButton.UseVisualStyleBackColor = true;
	        this.frameColorButton.Click += new System.EventHandler(this.frameColorButton_Click);
	        // 
	        // frameColorPanel
	        // 
	        this.frameColorPanel.Location = new System.Drawing.Point(6, 42);
	        this.frameColorPanel.Name = "frameColorPanel";
	        this.frameColorPanel.Size = new System.Drawing.Size(23, 23);
	        this.frameColorPanel.TabIndex = 6;
	        // 
	        // label3
	        // 
	        this.label3.Location = new System.Drawing.Point(6, 16);
	        this.label3.Name = "label3";
	        this.label3.Size = new System.Drawing.Size(100, 23);
	        this.label3.TabIndex = 5;
	        this.label3.Text = "Цвет рамки";
	        // 
	        // Settings
	        // 
	        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	        this.ClientSize = new System.Drawing.Size(200, 230);
	        this.Controls.Add(this.groupBox1);
	        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
	        this.Name = "Settings";
	        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
	        this.Text = "Настройки";
	        this.groupBox1.ResumeLayout(false);
	        this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button collageColorButton;
        private System.Windows.Forms.Panel collageColorPanel;
        private System.Windows.Forms.Button frameColorButton;
        private System.Windows.Forms.Panel frameColorPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label perPageLabel;
        private System.Windows.Forms.Button perPageMinus;
        private System.Windows.Forms.Button perPagePlus;

        #endregion
    }
}