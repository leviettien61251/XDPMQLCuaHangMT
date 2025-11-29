namespace XDPMQLCuaHangMT
{
    partial class FormTest
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
            this.buttonTestAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTestAdd = new System.Windows.Forms.TextBox();
            this.textBoxTestPass = new System.Windows.Forms.TextBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.textBoxEmployee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTestAdd
            // 
            this.buttonTestAdd.Location = new System.Drawing.Point(376, 117);
            this.buttonTestAdd.Name = "buttonTestAdd";
            this.buttonTestAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonTestAdd.TabIndex = 0;
            this.buttonTestAdd.Text = "Add";
            this.buttonTestAdd.UseVisualStyleBackColor = true;
            this.buttonTestAdd.Click += new System.EventHandler(this.buttonTestAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // textBoxTestAdd
            // 
            this.textBoxTestAdd.Location = new System.Drawing.Point(80, 6);
            this.textBoxTestAdd.Name = "textBoxTestAdd";
            this.textBoxTestAdd.Size = new System.Drawing.Size(386, 20);
            this.textBoxTestAdd.TabIndex = 3;
            // 
            // textBoxTestPass
            // 
            this.textBoxTestPass.Location = new System.Drawing.Point(80, 32);
            this.textBoxTestPass.Name = "textBoxTestPass";
            this.textBoxTestPass.Size = new System.Drawing.Size(386, 20);
            this.textBoxTestPass.TabIndex = 4;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(80, 60);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(386, 20);
            this.textBoxRole.TabIndex = 5;
            // 
            // textBoxEmployee
            // 
            this.textBoxEmployee.Location = new System.Drawing.Point(80, 83);
            this.textBoxEmployee.Name = "textBoxEmployee";
            this.textBoxEmployee.Size = new System.Drawing.Size(386, 20);
            this.textBoxEmployee.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "RoleID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "EmpoyeeID";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEmployee);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.textBoxTestPass);
            this.Controls.Add(this.textBoxTestAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTestAdd);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTestAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTestAdd;
        private System.Windows.Forms.TextBox textBoxTestPass;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.TextBox textBoxEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}