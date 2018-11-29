namespace csharpRestClient
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
            this.txtRestURI = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.cmdGo = new System.Windows.Forms.Button();
            this.requestURI = new System.Windows.Forms.Label();
            this.response = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboVerb = new System.Windows.Forms.ComboBox();
            this.txtPOSTData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRestURI
            // 
            this.txtRestURI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRestURI.Location = new System.Drawing.Point(184, 68);
            this.txtRestURI.Name = "txtRestURI";
            this.txtRestURI.Size = new System.Drawing.Size(606, 26);
            this.txtRestURI.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(184, 289);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(841, 196);
            this.txtResponse.TabIndex = 1;
            this.txtResponse.TextChanged += new System.EventHandler(this.txtResponse_TextChanged);
            // 
            // cmdGo
            // 
            this.cmdGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGo.Location = new System.Drawing.Point(956, 68);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(69, 29);
            this.cmdGo.TabIndex = 2;
            this.cmdGo.Text = "Go!";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // requestURI
            // 
            this.requestURI.AutoSize = true;
            this.requestURI.Location = new System.Drawing.Point(39, 68);
            this.requestURI.Name = "requestURI";
            this.requestURI.Size = new System.Drawing.Size(96, 20);
            this.requestURI.TabIndex = 3;
            this.requestURI.Text = "request URI";
            this.requestURI.Click += new System.EventHandler(this.requestURI_Click);
            // 
            // response
            // 
            this.response.AutoSize = true;
            this.response.Location = new System.Drawing.Point(39, 294);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(75, 20);
            this.response.TabIndex = 4;
            this.response.Text = "response";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(628, 249);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(222, 26);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(271, 246);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(214, 26);
            this.txtUsername.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username";
            // 
            // cboVerb
            // 
            this.cboVerb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVerb.FormattingEnabled = true;
            this.cboVerb.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.cboVerb.Location = new System.Drawing.Point(811, 68);
            this.cboVerb.Name = "cboVerb";
            this.cboVerb.Size = new System.Drawing.Size(121, 28);
            this.cboVerb.TabIndex = 11;
            this.cboVerb.Text = "GET";
            // 
            // txtPOSTData
            // 
            this.txtPOSTData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPOSTData.Location = new System.Drawing.Point(184, 115);
            this.txtPOSTData.Multiline = true;
            this.txtPOSTData.Name = "txtPOSTData";
            this.txtPOSTData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPOSTData.Size = new System.Drawing.Size(841, 101);
            this.txtPOSTData.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Request Body";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 563);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPOSTData);
            this.Controls.Add(this.cboVerb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.response);
            this.Controls.Add(this.requestURI);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtRestURI);
            this.Name = "Form1";
            this.Text = "c# REST Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRestURI;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.Label requestURI;
        private System.Windows.Forms.Label response;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboVerb;
        private System.Windows.Forms.TextBox txtPOSTData;
        private System.Windows.Forms.Label label3;
    }
}

