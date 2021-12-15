namespace College_Management_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.user = new Guna.UI.WinForms.GunaCircleButton();
            this.department = new Guna.UI.WinForms.GunaCircleButton();
            this.fees = new Guna.UI.WinForms.GunaCircleButton();
            this.teacher = new Guna.UI.WinForms.GunaCircleButton();
            this.student = new Guna.UI.WinForms.GunaCircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(263, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 79);
            this.label1.TabIndex = 11;
            this.label1.Text = "College Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 100);
            this.panel1.TabIndex = 10;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Silver;
            this.logout.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(570, 532);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(120, 48);
            this.logout.TabIndex = 17;
            this.logout.Text = "LogOut";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // user
            // 
            this.user.AnimationHoverSpeed = 0.07F;
            this.user.AnimationSpeed = 0.03F;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.BaseColor = System.Drawing.Color.Silver;
            this.user.BorderColor = System.Drawing.Color.Black;
            this.user.DialogResult = System.Windows.Forms.DialogResult.None;
            this.user.FocusedColor = System.Drawing.Color.Empty;
            this.user.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.Black;
            this.user.Image = null;
            this.user.ImageSize = new System.Drawing.Size(52, 52);
            this.user.Location = new System.Drawing.Point(570, 282);
            this.user.Name = "user";
            this.user.OnHoverBaseColor = System.Drawing.Color.Crimson;
            this.user.OnHoverBorderColor = System.Drawing.Color.Black;
            this.user.OnHoverForeColor = System.Drawing.Color.White;
            this.user.OnHoverImage = null;
            this.user.OnPressedColor = System.Drawing.Color.Black;
            this.user.Size = new System.Drawing.Size(120, 120);
            this.user.TabIndex = 16;
            this.user.Text = "Users";
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // department
            // 
            this.department.AnimationHoverSpeed = 0.07F;
            this.department.AnimationSpeed = 0.03F;
            this.department.BackColor = System.Drawing.Color.Transparent;
            this.department.BaseColor = System.Drawing.Color.Silver;
            this.department.BorderColor = System.Drawing.Color.Black;
            this.department.DialogResult = System.Windows.Forms.DialogResult.None;
            this.department.FocusedColor = System.Drawing.Color.Empty;
            this.department.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.ForeColor = System.Drawing.Color.Black;
            this.department.Image = null;
            this.department.ImageSize = new System.Drawing.Size(52, 52);
            this.department.Location = new System.Drawing.Point(313, 401);
            this.department.Name = "department";
            this.department.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.department.OnHoverBorderColor = System.Drawing.Color.Black;
            this.department.OnHoverForeColor = System.Drawing.Color.White;
            this.department.OnHoverImage = null;
            this.department.OnPressedColor = System.Drawing.Color.Black;
            this.department.Size = new System.Drawing.Size(120, 120);
            this.department.TabIndex = 15;
            this.department.Text = "Department";
            this.department.Click += new System.EventHandler(this.department_Click);
            // 
            // fees
            // 
            this.fees.AnimationHoverSpeed = 0.07F;
            this.fees.AnimationSpeed = 0.03F;
            this.fees.BackColor = System.Drawing.Color.Transparent;
            this.fees.BaseColor = System.Drawing.Color.Silver;
            this.fees.BorderColor = System.Drawing.Color.Black;
            this.fees.DialogResult = System.Windows.Forms.DialogResult.None;
            this.fees.FocusedColor = System.Drawing.Color.Empty;
            this.fees.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fees.ForeColor = System.Drawing.Color.Black;
            this.fees.Image = null;
            this.fees.ImageSize = new System.Drawing.Size(52, 52);
            this.fees.Location = new System.Drawing.Point(784, 401);
            this.fees.Name = "fees";
            this.fees.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.fees.OnHoverBorderColor = System.Drawing.Color.Black;
            this.fees.OnHoverForeColor = System.Drawing.Color.White;
            this.fees.OnHoverImage = null;
            this.fees.OnPressedColor = System.Drawing.Color.Black;
            this.fees.Size = new System.Drawing.Size(120, 120);
            this.fees.TabIndex = 14;
            this.fees.Text = "Fees";
            this.fees.Click += new System.EventHandler(this.fees_Click);
            // 
            // teacher
            // 
            this.teacher.AnimationHoverSpeed = 0.07F;
            this.teacher.AnimationSpeed = 0.03F;
            this.teacher.BackColor = System.Drawing.Color.Transparent;
            this.teacher.BaseColor = System.Drawing.Color.Silver;
            this.teacher.BorderColor = System.Drawing.Color.Black;
            this.teacher.DialogResult = System.Windows.Forms.DialogResult.None;
            this.teacher.FocusedColor = System.Drawing.Color.Empty;
            this.teacher.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher.ForeColor = System.Drawing.Color.Black;
            this.teacher.Image = null;
            this.teacher.ImageSize = new System.Drawing.Size(52, 52);
            this.teacher.Location = new System.Drawing.Point(784, 128);
            this.teacher.Name = "teacher";
            this.teacher.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.teacher.OnHoverBorderColor = System.Drawing.Color.Black;
            this.teacher.OnHoverForeColor = System.Drawing.Color.White;
            this.teacher.OnHoverImage = null;
            this.teacher.OnPressedColor = System.Drawing.Color.Black;
            this.teacher.Size = new System.Drawing.Size(120, 120);
            this.teacher.TabIndex = 13;
            this.teacher.Text = "Teachers";
            this.teacher.Click += new System.EventHandler(this.teacher_Click);
            // 
            // student
            // 
            this.student.AnimationHoverSpeed = 0.07F;
            this.student.AnimationSpeed = 0.03F;
            this.student.BackColor = System.Drawing.Color.Transparent;
            this.student.BaseColor = System.Drawing.Color.Silver;
            this.student.BorderColor = System.Drawing.Color.Black;
            this.student.DialogResult = System.Windows.Forms.DialogResult.None;
            this.student.FocusedColor = System.Drawing.Color.Empty;
            this.student.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.ForeColor = System.Drawing.Color.Black;
            this.student.Image = null;
            this.student.ImageSize = new System.Drawing.Size(52, 52);
            this.student.Location = new System.Drawing.Point(313, 128);
            this.student.Name = "student";
            this.student.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.student.OnHoverBorderColor = System.Drawing.Color.Black;
            this.student.OnHoverForeColor = System.Drawing.Color.White;
            this.student.OnHoverImage = null;
            this.student.OnPressedColor = System.Drawing.Color.Black;
            this.student.Size = new System.Drawing.Size(120, 120);
            this.student.TabIndex = 12;
            this.student.Text = "Student";
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 530);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(248, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "VIEW DASHBORD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1164, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 630);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.user);
            this.Controls.Add(this.department);
            this.Controls.Add(this.fees);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.student);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
          
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logout;
        private Guna.UI.WinForms.GunaCircleButton user;
        private Guna.UI.WinForms.GunaCircleButton department;
        private Guna.UI.WinForms.GunaCircleButton fees;
        private Guna.UI.WinForms.GunaCircleButton teacher;
        private Guna.UI.WinForms.GunaCircleButton student;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}