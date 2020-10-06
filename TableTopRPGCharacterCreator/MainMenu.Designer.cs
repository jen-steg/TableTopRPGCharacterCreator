namespace TableTopRPGCharacterCreator
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonCreateCharacter = new System.Windows.Forms.Button();
            this.ButtonCredits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelTitle.Location = new System.Drawing.Point(89, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(617, 43);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Table-top RPG Character Creator";
            // 
            // ButtonCreateCharacter
            // 
            this.ButtonCreateCharacter.BackColor = System.Drawing.Color.Maroon;
            this.ButtonCreateCharacter.Font = new System.Drawing.Font("Arial Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreateCharacter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonCreateCharacter.Location = new System.Drawing.Point(254, 341);
            this.ButtonCreateCharacter.Name = "ButtonCreateCharacter";
            this.ButtonCreateCharacter.Size = new System.Drawing.Size(327, 59);
            this.ButtonCreateCharacter.TabIndex = 1;
            this.ButtonCreateCharacter.Text = "Create Character";
            this.ButtonCreateCharacter.UseVisualStyleBackColor = false;
            this.ButtonCreateCharacter.Click += new System.EventHandler(this.ButtonCreateCharacter_Click);
            // 
            // ButtonCredits
            // 
            this.ButtonCredits.BackColor = System.Drawing.Color.Maroon;
            this.ButtonCredits.Font = new System.Drawing.Font("Arial Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCredits.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonCredits.Location = new System.Drawing.Point(336, 496);
            this.ButtonCredits.Name = "ButtonCredits";
            this.ButtonCredits.Size = new System.Drawing.Size(151, 47);
            this.ButtonCredits.TabIndex = 2;
            this.ButtonCredits.Text = "Credits";
            this.ButtonCredits.UseVisualStyleBackColor = false;
            this.ButtonCredits.Click += new System.EventHandler(this.ButtonCredits_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 658);
            this.Controls.Add(this.ButtonCredits);
            this.Controls.Add(this.ButtonCreateCharacter);
            this.Controls.Add(this.LabelTitle);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormMenu";
            this.Text = "Table-top RPG Character Creator Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonCreateCharacter;
        private System.Windows.Forms.Button ButtonCredits;
    }
}

