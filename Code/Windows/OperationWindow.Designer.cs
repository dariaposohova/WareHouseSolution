namespace WareHouseSpace.Windows
{
    partial class OperationWindow
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbUnits = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAccept);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 193);
            this.panel5.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(225, 20, 225, 20);
            this.panel5.Size = new System.Drawing.Size(559, 85);
            this.panel5.TabIndex = 8;
            // 
            // btnAccept
            // 
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccept.Location = new System.Drawing.Point(225, 20);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(150, 5, 150, 5);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(109, 45);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Зберегти";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbDescription);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 79);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(559, 38);
            this.panel4.TabIndex = 7;
            // 
            // tbDescription
            // 
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescription.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbDescription.Location = new System.Drawing.Point(152, 5);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(402, 30);
            this.tbDescription.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Опис";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbUnits);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(559, 41);
            this.panel2.TabIndex = 6;
            // 
            // tbUnits
            // 
            this.tbUnits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUnits.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbUnits.Location = new System.Drawing.Point(152, 5);
            this.tbUnits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUnits.Name = "tbUnits";
            this.tbUnits.ReadOnly = true;
            this.tbUnits.Size = new System.Drawing.Size(402, 30);
            this.tbUnits.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Одиниця виміру";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(559, 38);
            this.panel1.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbName.Location = new System.Drawing.Point(152, 5);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(402, 30);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbPrice);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 117);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(559, 38);
            this.panel3.TabIndex = 9;
            // 
            // tbPrice
            // 
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbPrice.Location = new System.Drawing.Point(152, 5);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(402, 30);
            this.tbPrice.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ціна";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbAmount);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 155);
            this.panel6.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(559, 38);
            this.panel6.TabIndex = 10;
            // 
            // tbAmount
            // 
            this.tbAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAmount.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbAmount.Location = new System.Drawing.Point(152, 5);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(402, 30);
            this.tbAmount.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Кількість";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OperationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 278);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OperationWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label5;
    }
}