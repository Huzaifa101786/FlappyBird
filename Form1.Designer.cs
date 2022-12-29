namespace FlappyBird
{
    partial class FlappyBird
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
            this.Score = new System.Windows.Forms.Label();
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipe_up = new System.Windows.Forms.PictureBox();
            this.pipe_down = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(12, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(51, 19);
            this.Score.TabIndex = 0;
            this.Score.Text = "Score: ";
            this.Score.Click += new System.EventHandler(this.label1_Click);
            // 
            // game_timer
            // 
            this.game_timer.Enabled = true;
            this.game_timer.Interval = 20;
            this.game_timer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-15, 642);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(464, 111);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 4;
            this.ground.TabStop = false;
            // 
            // pipe_up
            // 
            this.pipe_up.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pipe_up.Location = new System.Drawing.Point(362, -58);
            this.pipe_up.Name = "pipe_up";
            this.pipe_up.Size = new System.Drawing.Size(75, 277);
            this.pipe_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_up.TabIndex = 3;
            this.pipe_up.TabStop = false;
            // 
            // pipe_down
            // 
            this.pipe_down.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pipe_down.Location = new System.Drawing.Point(211, 413);
            this.pipe_down.Name = "pipe_down";
            this.pipe_down.Size = new System.Drawing.Size(75, 236);
            this.pipe_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_down.TabIndex = 2;
            this.pipe_down.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::FlappyBird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(37, 112);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(84, 60);
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(439, 743);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipe_up);
            this.Controls.Add(this.pipe_down);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.Score);
            this.MaximizeBox = false;
            this.Name = "FlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlappyBird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipe_down;
        private System.Windows.Forms.PictureBox pipe_up;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer game_timer;
    }
}

