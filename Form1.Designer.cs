namespace Racingcar1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.over = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.Obstacle3 = new System.Windows.Forms.PictureBox();
            this.Obstacle2 = new System.Windows.Forms.PictureBox();
            this.Obstacle1 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.BackColor = System.Drawing.Color.Yellow;
            this.over.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.ForeColor = System.Drawing.Color.Red;
            this.over.Location = new System.Drawing.Point(139, 209);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(133, 29);
            this.over.TabIndex = 10;
            this.over.Text = "Gameover";
            this.over.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "coins =0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(278, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "speed = 0";
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.SystemColors.GrayText;
            this.coin1.Image = global::Racingcar1.Properties.Resources.coin;
            this.coin1.Location = new System.Drawing.Point(42, 209);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(27, 27);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 11;
            this.coin1.TabStop = false;
            // 
            // Obstacle3
            // 
            this.Obstacle3.Image = global::Racingcar1.Properties.Resources.car_top_view_vehicle_overhead_260nw_1251380068;
            this.Obstacle3.Location = new System.Drawing.Point(249, 319);
            this.Obstacle3.Name = "Obstacle3";
            this.Obstacle3.Size = new System.Drawing.Size(46, 65);
            this.Obstacle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obstacle3.TabIndex = 9;
            this.Obstacle3.TabStop = false;
            // 
            // Obstacle2
            // 
            this.Obstacle2.Image = global::Racingcar1.Properties.Resources.car_top_view_vehicle_overhead_260nw_1251380068;
            this.Obstacle2.Location = new System.Drawing.Point(270, 90);
            this.Obstacle2.Name = "Obstacle2";
            this.Obstacle2.Size = new System.Drawing.Size(46, 56);
            this.Obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obstacle2.TabIndex = 8;
            this.Obstacle2.TabStop = false;
            // 
            // Obstacle1
            // 
            this.Obstacle1.Image = global::Racingcar1.Properties.Resources.car_top_view_vehicle_overhead_260nw_1251380068;
            this.Obstacle1.Location = new System.Drawing.Point(42, 90);
            this.Obstacle1.Name = "Obstacle1";
            this.Obstacle1.Size = new System.Drawing.Size(46, 56);
            this.Obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obstacle1.TabIndex = 7;
            this.Obstacle1.TabStop = false;
            this.Obstacle1.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // car
            // 
            this.car.Image = global::Racingcar1.Properties.Resources.police_car_top_view_solid_flat_color_style_design_illustrated_vector_police_car_top_view_solid_flat_color_style_109135279;
            this.car.Location = new System.Drawing.Point(42, 328);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(46, 56);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 6;
            this.car.TabStop = false;
            this.car.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Car_PreviewKeyDown);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox6.Location = new System.Drawing.Point(173, 366);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(8, 94);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(8, 460);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox4.Location = new System.Drawing.Point(373, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(8, 460);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox3.Location = new System.Drawing.Point(173, 233);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(8, 94);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox2.Location = new System.Drawing.Point(173, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(8, 94);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(173, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // coin2
            // 
            this.coin2.BackColor = System.Drawing.SystemColors.GrayText;
            this.coin2.Image = global::Racingcar1.Properties.Resources.coin;
            this.coin2.Location = new System.Drawing.Point(259, 167);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(27, 27);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 17;
            this.coin2.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.BackColor = System.Drawing.SystemColors.GrayText;
            this.coin3.Image = global::Racingcar1.Properties.Resources.coin;
            this.coin3.Location = new System.Drawing.Point(74, 42);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(27, 27);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 18;
            this.coin3.TabStop = false;
            // 
            // coin4
            // 
            this.coin4.BackColor = System.Drawing.SystemColors.GrayText;
            this.coin4.Image = global::Racingcar1.Properties.Resources.coin;
            this.coin4.Location = new System.Drawing.Point(249, 57);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(27, 27);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin4.TabIndex = 20;
            this.coin4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.over);
            this.Controls.Add(this.Obstacle3);
            this.Controls.Add(this.Obstacle2);
            this.Controls.Add(this.Obstacle1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox Obstacle1;
        private System.Windows.Forms.PictureBox Obstacle2;
        private System.Windows.Forms.PictureBox Obstacle3;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin4;


    }
}

