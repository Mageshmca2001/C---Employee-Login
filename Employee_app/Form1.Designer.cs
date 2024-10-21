namespace Employee_app
{
    partial class Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            header = new Guna.UI2.WinForms.Guna2GradientPanel();
            textBox1 = new TextBox();
            min = new Button();
            Exit = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            Username = new TextBox();
            Password = new TextBox();
            button1 = new Button();
            button2 = new Button();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(textBox1);
            header.Controls.Add(min);
            header.Controls.Add(Exit);
            header.Controls.Add(pictureBox1);
            header.CustomizableEdges = customizableEdges7;
            header.Dock = DockStyle.Top;
            header.ForeColor = Color.White;
            header.Location = new Point(0, 0);
            header.Margin = new Padding(4);
            header.Name = "header";
            header.ShadowDecoration.CustomizableEdges = customizableEdges8;
            header.Size = new Size(831, 35);
            header.TabIndex = 0;
            header.Paint += header_Paint;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(282, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 31);
            textBox1.TabIndex = 3;
            textBox1.Text = "Employee Management System";
            // 
            // min
            // 
            min.BackColor = Color.Red;
            min.BackgroundImageLayout = ImageLayout.Center;
            min.Dock = DockStyle.Right;
            min.Font = new Font("Lucida Bright", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            min.ForeColor = SystemColors.ButtonHighlight;
            min.Location = new Point(751, 0);
            min.Name = "min";
            min.Size = new Size(40, 35);
            min.TabIndex = 2;
            min.Text = "-";
            min.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Red;
            Exit.Dock = DockStyle.Right;
            Exit.ForeColor = SystemColors.ButtonHighlight;
            Exit.Location = new Point(791, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(40, 35);
            Exit.TabIndex = 1;
            Exit.Text = "X";
            Exit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(269, 174);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(269, 237);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(61, 4);
            // 
            // Username
            // 
            Username.BackColor = Color.White;
            Username.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(335, 178);
            Username.Name = "Username";
            Username.Size = new Size(211, 27);
            Username.TabIndex = 4;
            // 
            // Password
            // 
            Password.BackColor = Color.White;
            Password.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(335, 240);
            Password.Name = "Password";
            Password.Size = new Size(211, 27);
            Password.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(351, 299);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 6;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(448, 299);
            button2.Name = "button2";
            button2.Size = new Size(75, 27);
            button2.TabIndex = 7;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(831, 430);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(header);
            Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            Text = "Login";
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel header;
        private PictureBox pictureBox1;
        private Button min;
        private Button Exit;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private TextBox Username;
        private TextBox Password;
        private Button button1;
        private Button button2;
    }
}
