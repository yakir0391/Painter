
namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_square = new System.Windows.Forms.Button();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.btn_square);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.btn_rect);
            this.panel1.Controls.Add(this.btn_ellipse);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Controls.Add(this.btn_pencil);
            this.panel1.Controls.Add(this.btn_fill);
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 152);
            this.panel1.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(340, 98);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 37);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.White;
            this.btn_line.Location = new System.Drawing.Point(1019, 55);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(77, 80);
            this.btn_line.TabIndex = 11;
            this.btn_line.Text = "Line";
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_square
            // 
            this.btn_square.BackColor = System.Drawing.Color.White;
            this.btn_square.Location = new System.Drawing.Point(936, 55);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(77, 80);
            this.btn_square.TabIndex = 10;
            this.btn_square.Text = "square";
            this.btn_square.UseVisualStyleBackColor = false;
            this.btn_square.Click += new System.EventHandler(this.btn_square_Click);
            // 
            // color_picker
            // 
            this.color_picker.BackColor = System.Drawing.Color.White;
            this.color_picker.Image = global::WindowsFormsApp1.Properties.Resources.smoothfbx__1_;
            this.color_picker.Location = new System.Drawing.Point(12, 12);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(286, 123);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 3;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.Color.White;
            this.btn_rect.Location = new System.Drawing.Point(838, 55);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(92, 80);
            this.btn_rect.TabIndex = 9;
            this.btn_rect.Text = "rectangle";
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.Color.White;
            this.btn_ellipse.Location = new System.Drawing.Point(759, 55);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(73, 80);
            this.btn_ellipse.TabIndex = 8;
            this.btn_ellipse.Text = "ellipse";
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.Color.White;
            this.btn_eraser.Location = new System.Drawing.Point(679, 55);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(74, 80);
            this.btn_eraser.TabIndex = 7;
            this.btn_eraser.Text = "eraser";
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.Color.White;
            this.btn_pencil.Location = new System.Drawing.Point(592, 55);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(81, 80);
            this.btn_pencil.TabIndex = 6;
            this.btn_pencil.Text = "pencil";
            this.btn_pencil.UseVisualStyleBackColor = false;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.White;
            this.btn_fill.Location = new System.Drawing.Point(507, 55);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(79, 80);
            this.btn_fill.TabIndex = 5;
            this.btn_fill.Text = "fill";
            this.btn_fill.UseVisualStyleBackColor = false;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.White;
            this.btn_color.Location = new System.Drawing.Point(421, 55);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(80, 80);
            this.btn_color.TabIndex = 4;
            this.btn_color.Text = "color";
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(304, 12);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(38, 38);
            this.pic_color.TabIndex = 3;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btn_Load);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 606);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 63);
            this.panel2.TabIndex = 1;
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.White;
            this.btn_Load.Location = new System.Drawing.Point(936, 14);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(76, 37);
            this.btn_Load.TabIndex = 14;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(1019, 14);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(76, 37);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 152);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1111, 454);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.BackgroundImageChanged += new System.EventHandler(this.btn_Load_Click);
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 669);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.PictureBox pic;
    }
}

