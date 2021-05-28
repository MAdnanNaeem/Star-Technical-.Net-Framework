
namespace Star_Technical.Forms
{
    partial class FormAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_searchadmin = new System.Windows.Forms.TextBox();
            this.btn_addAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_searchadmin
            // 
            this.txt_searchadmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchadmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_searchadmin.Location = new System.Drawing.Point(788, 27);
            this.txt_searchadmin.Multiline = true;
            this.txt_searchadmin.Name = "txt_searchadmin";
            this.txt_searchadmin.Size = new System.Drawing.Size(246, 40);
            this.txt_searchadmin.TabIndex = 2;
            // 
            // btn_addAdmin
            // 
            this.btn_addAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addAdmin.FlatAppearance.BorderSize = 0;
            this.btn_addAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addAdmin.Image = global::Star_Technical.Properties.Resources.add_admin;
            this.btn_addAdmin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_addAdmin.Location = new System.Drawing.Point(1135, 24);
            this.btn_addAdmin.Name = "btn_addAdmin";
            this.btn_addAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_addAdmin.Size = new System.Drawing.Size(181, 43);
            this.btn_addAdmin.TabIndex = 1;
            this.btn_addAdmin.Text = "    Add Admin";
            this.btn_addAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addAdmin.UseVisualStyleBackColor = true;
            this.btn_addAdmin.Click += new System.EventHandler(this.btn_addAdmin_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 744);
            this.Controls.Add(this.txt_searchadmin);
            this.Controls.Add(this.btn_addAdmin);
            this.Controls.Add(this.label1);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addAdmin;
        private System.Windows.Forms.TextBox txt_searchadmin;
    }
}