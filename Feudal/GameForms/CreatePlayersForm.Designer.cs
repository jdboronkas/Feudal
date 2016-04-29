namespace Feudal.GameForms
{
    partial class CreatePlayersForm
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
            this.NamesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NamesTextBox
            // 
            this.NamesTextBox.Location = new System.Drawing.Point(12, 25);
            this.NamesTextBox.Multiline = true;
            this.NamesTextBox.Name = "NamesTextBox";
            this.NamesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NamesTextBox.Size = new System.Drawing.Size(188, 230);
            this.NamesTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter player and ai names, one per line.";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(12, 261);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(188, 46);
            this.DoneButton.TabIndex = 3;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // CreatePlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 319);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NamesTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreatePlayersForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Create Players";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NamesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DoneButton;
    }
}