namespace Circular_List
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
            lblValue = new Label();
            txtValue = new TextBox();
            lstNodes = new ListBox();
            ibtnAdd = new FontAwesome.Sharp.IconButton();
            ibtnRemove = new FontAwesome.Sharp.IconButton();
            ibtnCount = new FontAwesome.Sharp.IconButton();
            ibtnContains = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Bernard MT Condensed", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblValue.ForeColor = Color.FromArgb(255, 128, 128);
            lblValue.Location = new Point(5, 37);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(76, 31);
            lblValue.TabIndex = 1;
            lblValue.Text = "Value";
            // 
            // txtValue
            // 
            txtValue.BackColor = Color.FromArgb(255, 192, 192);
            txtValue.Font = new Font("Agency FB", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtValue.ForeColor = Color.FromArgb(255, 128, 128);
            txtValue.Location = new Point(91, 37);
            txtValue.Multiline = true;
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(143, 38);
            txtValue.TabIndex = 2;
            // 
            // lstNodes
            // 
            lstNodes.BackColor = Color.FromArgb(255, 192, 192);
            lstNodes.Font = new Font("Agency FB", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lstNodes.ForeColor = Color.FromArgb(255, 128, 128);
            lstNodes.FormattingEnabled = true;
            lstNodes.ItemHeight = 34;
            lstNodes.Location = new Point(365, 37);
            lstNodes.Name = "lstNodes";
            lstNodes.Size = new Size(235, 310);
            lstNodes.TabIndex = 3;
            // 
            // ibtnAdd
            // 
            ibtnAdd.BackColor = Color.FromArgb(255, 192, 192);
            ibtnAdd.ForeColor = Color.FromArgb(255, 128, 128);
            ibtnAdd.IconChar = FontAwesome.Sharp.IconChar.Save;
            ibtnAdd.IconColor = Color.FromArgb(255, 128, 128);
            ibtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnAdd.Location = new Point(265, 37);
            ibtnAdd.Name = "ibtnAdd";
            ibtnAdd.Size = new Size(78, 71);
            ibtnAdd.TabIndex = 7;
            ibtnAdd.Text = "Add";
            ibtnAdd.TextAlign = ContentAlignment.BottomCenter;
            ibtnAdd.UseVisualStyleBackColor = false;
            ibtnAdd.Click += ibtnAdd_Click;
            // 
            // ibtnRemove
            // 
            ibtnRemove.BackColor = Color.FromArgb(255, 192, 192);
            ibtnRemove.ForeColor = Color.FromArgb(255, 128, 128);
            ibtnRemove.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            ibtnRemove.IconColor = Color.FromArgb(255, 128, 128);
            ibtnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnRemove.Location = new Point(265, 114);
            ibtnRemove.Name = "ibtnRemove";
            ibtnRemove.Size = new Size(78, 71);
            ibtnRemove.TabIndex = 8;
            ibtnRemove.Text = "Remove";
            ibtnRemove.TextAlign = ContentAlignment.BottomCenter;
            ibtnRemove.UseVisualStyleBackColor = false;
            ibtnRemove.Click += ibtnRemove_Click;
            // 
            // ibtnCount
            // 
            ibtnCount.BackColor = Color.FromArgb(255, 192, 192);
            ibtnCount.ForeColor = Color.FromArgb(255, 128, 128);
            ibtnCount.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            ibtnCount.IconColor = Color.FromArgb(255, 128, 128);
            ibtnCount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCount.Location = new Point(265, 268);
            ibtnCount.Name = "ibtnCount";
            ibtnCount.Size = new Size(78, 71);
            ibtnCount.TabIndex = 9;
            ibtnCount.Text = "Count";
            ibtnCount.TextAlign = ContentAlignment.BottomCenter;
            ibtnCount.UseVisualStyleBackColor = false;
            ibtnCount.Click += ibtnCount_Click;
            // 
            // ibtnContains
            // 
            ibtnContains.BackColor = Color.FromArgb(255, 192, 192);
            ibtnContains.ForeColor = Color.FromArgb(255, 128, 128);
            ibtnContains.IconChar = FontAwesome.Sharp.IconChar.Search;
            ibtnContains.IconColor = Color.FromArgb(255, 128, 128);
            ibtnContains.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnContains.Location = new Point(265, 191);
            ibtnContains.Name = "ibtnContains";
            ibtnContains.Size = new Size(78, 71);
            ibtnContains.TabIndex = 10;
            ibtnContains.Text = "Contains";
            ibtnContains.TextAlign = ContentAlignment.BottomCenter;
            ibtnContains.UseVisualStyleBackColor = false;
            ibtnContains.Click += ibtnContains_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(629, 370);
            Controls.Add(ibtnContains);
            Controls.Add(ibtnCount);
            Controls.Add(ibtnRemove);
            Controls.Add(ibtnAdd);
            Controls.Add(lstNodes);
            Controls.Add(txtValue);
            Controls.Add(lblValue);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblValue;
        private TextBox txtValue;
        private ListBox lstNodes;
        private FontAwesome.Sharp.IconButton ibtnAdd;
        private FontAwesome.Sharp.IconButton ibtnRemove;
        private FontAwesome.Sharp.IconButton ibtnCount;
        private FontAwesome.Sharp.IconButton ibtnContains;
    }
}
