namespace login
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(15, 15, 15);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.DimGray;
            textBox1.Location = new Point(323, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(370, 20);
            textBox1.TabIndex = 1;
            textBox1.Text = "USUARIO";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(15, 15, 15);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.DimGray;
            textBox2.Location = new Point(323, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(370, 20);
            textBox2.TabIndex = 2;
            textBox2.Text = "USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(429, 24);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 40, 40);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(285, 243);
            button1.Name = "button1";
            button1.Size = new Size(408, 40);
            button1.TabIndex = 4;
            button1.Text = "ACCEDER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(458, 304);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(179, 17);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Olvidaste tu contraseña?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}