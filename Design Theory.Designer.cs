namespace FavCat_Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FavCategoryBG = new System.Windows.Forms.Panel();
            this.TopBar = new System.Windows.Forms.Panel();
            this.GoToEndButton = new System.Windows.Forms.Panel();
            this.GoToEndLabel = new System.Windows.Forms.Label();
            this.GoToStartButton = new System.Windows.Forms.Panel();
            this.GoToStartLabel = new System.Windows.Forms.Label();
            this.MinusButton = new System.Windows.Forms.Panel();
            this.MinusButtonLabel = new System.Windows.Forms.Label();
            this.PlusButton = new System.Windows.Forms.Panel();
            this.PlusButtonLabel = new System.Windows.Forms.Label();
            this.SButton = new System.Windows.Forms.Panel();
            this.SButtonLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FavButtonBar = new System.Windows.Forms.Panel();
            this.FavButtonLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.FavButton = new System.Windows.Forms.Panel();
            this.TextBG1 = new System.Windows.Forms.Panel();
            this.FavText = new System.Windows.Forms.Label();
            this.LayoutPanel.SuspendLayout();
            this.FavCategoryBG.SuspendLayout();
            this.TopBar.SuspendLayout();
            this.GoToEndButton.SuspendLayout();
            this.GoToStartButton.SuspendLayout();
            this.MinusButton.SuspendLayout();
            this.PlusButton.SuspendLayout();
            this.SButton.SuspendLayout();
            this.FavButtonBar.SuspendLayout();
            this.FavButtonLayout.SuspendLayout();
            this.FavButton.SuspendLayout();
            this.TextBG1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.ColumnCount = 1;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutPanel.Controls.Add(this.FavCategoryBG, 0, 0);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 1;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.Size = new System.Drawing.Size(747, 590);
            this.LayoutPanel.TabIndex = 3;
            // 
            // FavCategoryBG
            // 
            this.FavCategoryBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.FavCategoryBG.Controls.Add(this.TopBar);
            this.FavCategoryBG.Controls.Add(this.FavButtonBar);
            this.FavCategoryBG.ForeColor = System.Drawing.Color.White;
            this.FavCategoryBG.Location = new System.Drawing.Point(3, 3);
            this.FavCategoryBG.Name = "FavCategoryBG";
            this.FavCategoryBG.Size = new System.Drawing.Size(742, 183);
            this.FavCategoryBG.TabIndex = 3;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.TopBar.Controls.Add(this.GoToEndButton);
            this.TopBar.Controls.Add(this.GoToStartButton);
            this.TopBar.Controls.Add(this.MinusButton);
            this.TopBar.Controls.Add(this.PlusButton);
            this.TopBar.Controls.Add(this.SButton);
            this.TopBar.Controls.Add(this.label2);
            this.TopBar.Controls.Add(this.label1);
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(742, 45);
            this.TopBar.TabIndex = 1;
            // 
            // GoToEndButton
            // 
            this.GoToEndButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.GoToEndButton.Controls.Add(this.GoToEndLabel);
            this.GoToEndButton.Location = new System.Drawing.Point(704, 6);
            this.GoToEndButton.Name = "GoToEndButton";
            this.GoToEndButton.Size = new System.Drawing.Size(32, 32);
            this.GoToEndButton.TabIndex = 7;
            // 
            // GoToEndLabel
            // 
            this.GoToEndLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoToEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToEndLabel.Location = new System.Drawing.Point(0, 0);
            this.GoToEndLabel.Name = "GoToEndLabel";
            this.GoToEndLabel.Padding = new System.Windows.Forms.Padding(5);
            this.GoToEndLabel.Size = new System.Drawing.Size(32, 32);
            this.GoToEndLabel.TabIndex = 0;
            this.GoToEndLabel.Text = ">>";
            this.GoToEndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoToStartButton
            // 
            this.GoToStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.GoToStartButton.Controls.Add(this.GoToStartLabel);
            this.GoToStartButton.Location = new System.Drawing.Point(666, 6);
            this.GoToStartButton.Name = "GoToStartButton";
            this.GoToStartButton.Size = new System.Drawing.Size(32, 32);
            this.GoToStartButton.TabIndex = 6;
            // 
            // GoToStartLabel
            // 
            this.GoToStartLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoToStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToStartLabel.Location = new System.Drawing.Point(0, 0);
            this.GoToStartLabel.Name = "GoToStartLabel";
            this.GoToStartLabel.Padding = new System.Windows.Forms.Padding(5);
            this.GoToStartLabel.Size = new System.Drawing.Size(32, 32);
            this.GoToStartLabel.TabIndex = 0;
            this.GoToStartLabel.Text = "<<";
            this.GoToStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.MinusButton.Controls.Add(this.MinusButtonLabel);
            this.MinusButton.Location = new System.Drawing.Point(6, 6);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(32, 32);
            this.MinusButton.TabIndex = 5;
            // 
            // MinusButtonLabel
            // 
            this.MinusButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButtonLabel.Location = new System.Drawing.Point(0, 0);
            this.MinusButtonLabel.Name = "MinusButtonLabel";
            this.MinusButtonLabel.Padding = new System.Windows.Forms.Padding(5);
            this.MinusButtonLabel.Size = new System.Drawing.Size(32, 32);
            this.MinusButtonLabel.TabIndex = 0;
            this.MinusButtonLabel.Text = "-";
            this.MinusButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.PlusButton.Controls.Add(this.PlusButtonLabel);
            this.PlusButton.Location = new System.Drawing.Point(44, 6);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(32, 32);
            this.PlusButton.TabIndex = 4;
            // 
            // PlusButtonLabel
            // 
            this.PlusButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButtonLabel.Location = new System.Drawing.Point(0, 0);
            this.PlusButtonLabel.Name = "PlusButtonLabel";
            this.PlusButtonLabel.Padding = new System.Windows.Forms.Padding(5);
            this.PlusButtonLabel.Size = new System.Drawing.Size(32, 32);
            this.PlusButtonLabel.TabIndex = 0;
            this.PlusButtonLabel.Text = "+";
            this.PlusButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SButton
            // 
            this.SButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.SButton.Controls.Add(this.SButtonLabel);
            this.SButton.Location = new System.Drawing.Point(82, 6);
            this.SButton.Name = "SButton";
            this.SButton.Size = new System.Drawing.Size(32, 32);
            this.SButton.TabIndex = 3;
            // 
            // SButtonLabel
            // 
            this.SButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SButtonLabel.Location = new System.Drawing.Point(0, 0);
            this.SButtonLabel.Name = "SButtonLabel";
            this.SButtonLabel.Padding = new System.Windows.Forms.Padding(5);
            this.SButtonLabel.Size = new System.Drawing.Size(32, 32);
            this.SButtonLabel.TabIndex = 0;
            this.SButtonLabel.Text = "S";
            this.SButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(476, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "0 / 00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // FavButtonBar
            // 
            this.FavButtonBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.FavButtonBar.Controls.Add(this.FavButtonLayout);
            this.FavButtonBar.ForeColor = System.Drawing.Color.White;
            this.FavButtonBar.Location = new System.Drawing.Point(0, 45);
            this.FavButtonBar.Name = "FavButtonBar";
            this.FavButtonBar.Size = new System.Drawing.Size(742, 138);
            this.FavButtonBar.TabIndex = 2;
            // 
            // FavButtonLayout
            // 
            this.FavButtonLayout.Controls.Add(this.FavButton);
            this.FavButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FavButtonLayout.Location = new System.Drawing.Point(0, 0);
            this.FavButtonLayout.Name = "FavButtonLayout";
            this.FavButtonLayout.Padding = new System.Windows.Forms.Padding(2);
            this.FavButtonLayout.Size = new System.Drawing.Size(742, 138);
            this.FavButtonLayout.TabIndex = 0;
            // 
            // FavButton
            // 
            this.FavButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.FavButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FavButton.BackgroundImage")));
            this.FavButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FavButton.Controls.Add(this.TextBG1);
            this.FavButton.Location = new System.Drawing.Point(5, 5);
            this.FavButton.Name = "FavButton";
            this.FavButton.Size = new System.Drawing.Size(128, 128);
            this.FavButton.TabIndex = 5;
            // 
            // TextBG1
            // 
            this.TextBG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.TextBG1.Controls.Add(this.FavText);
            this.TextBG1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBG1.Location = new System.Drawing.Point(0, 104);
            this.TextBG1.Name = "TextBG1";
            this.TextBG1.Size = new System.Drawing.Size(128, 24);
            this.TextBG1.TabIndex = 1;
            // 
            // FavText
            // 
            this.FavText.BackColor = System.Drawing.Color.Transparent;
            this.FavText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FavText.Location = new System.Drawing.Point(0, 0);
            this.FavText.Name = "FavText";
            this.FavText.Padding = new System.Windows.Forms.Padding(5);
            this.FavText.Size = new System.Drawing.Size(128, 24);
            this.FavText.TabIndex = 0;
            this.FavText.Text = "Avatar Name";
            this.FavText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(747, 590);
            this.Controls.Add(this.LayoutPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LayoutPanel.ResumeLayout(false);
            this.FavCategoryBG.ResumeLayout(false);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.GoToEndButton.ResumeLayout(false);
            this.GoToStartButton.ResumeLayout(false);
            this.MinusButton.ResumeLayout(false);
            this.PlusButton.ResumeLayout(false);
            this.SButton.ResumeLayout(false);
            this.FavButtonBar.ResumeLayout(false);
            this.FavButtonLayout.ResumeLayout(false);
            this.FavButton.ResumeLayout(false);
            this.TextBG1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private System.Windows.Forms.Panel FavCategoryBG;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Panel GoToEndButton;
        private System.Windows.Forms.Label GoToEndLabel;
        private System.Windows.Forms.Panel GoToStartButton;
        private System.Windows.Forms.Label GoToStartLabel;
        private System.Windows.Forms.Panel MinusButton;
        private System.Windows.Forms.Label MinusButtonLabel;
        private System.Windows.Forms.Panel PlusButton;
        private System.Windows.Forms.Label PlusButtonLabel;
        private System.Windows.Forms.Panel SButton;
        private System.Windows.Forms.Label SButtonLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel FavButtonBar;
        private System.Windows.Forms.FlowLayoutPanel FavButtonLayout;
        private System.Windows.Forms.Panel FavButton;
        private System.Windows.Forms.Panel TextBG1;
        private System.Windows.Forms.Label FavText;
    }
}