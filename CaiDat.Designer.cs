namespace PBL3
{
    partial class CaiDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaiDat));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::PBL3.Properties.Resources.images__2_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(49, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "         Thoát";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDMK
            // 
            this.buttonDMK.BackColor = System.Drawing.Color.White;
            this.buttonDMK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDMK.ForeColor = System.Drawing.Color.Black;
            this.buttonDMK.Image = global::PBL3.Properties.Resources.unnamed;
            this.buttonDMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDMK.Location = new System.Drawing.Point(49, 31);
            this.buttonDMK.Name = "buttonDMK";
            this.buttonDMK.Size = new System.Drawing.Size(231, 54);
            this.buttonDMK.TabIndex = 1;
            this.buttonDMK.Text = "   Đổi mật khẩu";
            this.buttonDMK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDMK.UseVisualStyleBackColor = false;
            this.buttonDMK.Click += new System.EventHandler(this.buttonDMK_Click);
            // 
            // CaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(325, 197);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDMK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaiDat";
            this.Text = "CaiDat";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDMK;
        private System.Windows.Forms.Button button1;
    }
}