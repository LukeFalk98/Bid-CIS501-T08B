namespace Bid501
{
    partial class BidForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.Label();
            this.TimeRemaining = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusColor = new System.Windows.Forms.Label();
            this.BidBox = new System.Windows.Forms.TextBox();
            this.MinBid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(401, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 284);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(53, 67);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(96, 24);
            this.ItemName.TabIndex = 2;
            this.ItemName.Text = "ItemName";
            // 
            // TimeRemaining
            // 
            this.TimeRemaining.AutoSize = true;
            this.TimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeRemaining.Location = new System.Drawing.Point(53, 107);
            this.TimeRemaining.Name = "TimeRemaining";
            this.TimeRemaining.Size = new System.Drawing.Size(149, 24);
            this.TimeRemaining.TabIndex = 3;
            this.TimeRemaining.Text = "Time Remaining";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status: ";
            // 
            // StatusColor
            // 
            this.StatusColor.AutoSize = true;
            this.StatusColor.BackColor = System.Drawing.Color.White;
            this.StatusColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusColor.Location = new System.Drawing.Point(130, 147);
            this.StatusColor.Name = "StatusColor";
            this.StatusColor.Size = new System.Drawing.Size(50, 24);
            this.StatusColor.TabIndex = 5;
            this.StatusColor.Text = "        ";
            // 
            // BidBox
            // 
            this.BidBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BidBox.Location = new System.Drawing.Point(57, 243);
            this.BidBox.Name = "BidBox";
            this.BidBox.Size = new System.Drawing.Size(100, 26);
            this.BidBox.TabIndex = 6;
            // 
            // MinBid
            // 
            this.MinBid.AutoSize = true;
            this.MinBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBid.Location = new System.Drawing.Point(53, 216);
            this.MinBid.Name = "MinBid";
            this.MinBid.Size = new System.Drawing.Size(168, 24);
            this.MinBid.TabIndex = 7;
            this.MinBid.Text = "Minimum bid: $--.--";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(57, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 76);
            this.button1.TabIndex = 8;
            this.button1.Text = "Place Bid";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MinBid);
            this.Controls.Add(this.BidBox);
            this.Controls.Add(this.StatusColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeRemaining);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "BidForm";
            this.Text = "BidForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.Label TimeRemaining;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StatusColor;
        private System.Windows.Forms.TextBox BidBox;
        private System.Windows.Forms.Label MinBid;
        private System.Windows.Forms.Button button1;
    }
}