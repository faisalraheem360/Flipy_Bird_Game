
namespace FlopyBirdFRB
{
    partial class FlopyBirdSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlopyBirdSetup));
            this.scoreLBL = new System.Windows.Forms.Label();
            this.TopPipePB = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flopybirdPB = new System.Windows.Forms.PictureBox();
            this.BottompipePB = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ScoreTimer = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TopPipePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flopybirdPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottompipePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLBL
            // 
            this.scoreLBL.AutoSize = true;
            this.scoreLBL.BackColor = System.Drawing.Color.Black;
            this.scoreLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLBL.ForeColor = System.Drawing.Color.Transparent;
            this.scoreLBL.Location = new System.Drawing.Point(699, 9);
            this.scoreLBL.Name = "scoreLBL";
            this.scoreLBL.Size = new System.Drawing.Size(125, 33);
            this.scoreLBL.TabIndex = 0;
            this.scoreLBL.Text = "Score: 0";
            this.scoreLBL.Click += new System.EventHandler(this.scoreLBL_Click);
            // 
            // TopPipePB
            // 
            this.TopPipePB.Image = ((System.Drawing.Image)(resources.GetObject("TopPipePB.Image")));
            this.TopPipePB.Location = new System.Drawing.Point(227, -9);
            this.TopPipePB.Name = "TopPipePB";
            this.TopPipePB.Size = new System.Drawing.Size(100, 134);
            this.TopPipePB.TabIndex = 1;
            this.TopPipePB.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-177, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // flopybirdPB
            // 
            this.flopybirdPB.Image = ((System.Drawing.Image)(resources.GetObject("flopybirdPB.Image")));
            this.flopybirdPB.Location = new System.Drawing.Point(109, 287);
            this.flopybirdPB.Name = "flopybirdPB";
            this.flopybirdPB.Size = new System.Drawing.Size(87, 58);
            this.flopybirdPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flopybirdPB.TabIndex = 1;
            this.flopybirdPB.TabStop = false;
            // 
            // BottompipePB
            // 
            this.BottompipePB.Image = ((System.Drawing.Image)(resources.GetObject("BottompipePB.Image")));
            this.BottompipePB.Location = new System.Drawing.Point(506, 386);
            this.BottompipePB.Name = "BottompipePB";
            this.BottompipePB.Size = new System.Drawing.Size(117, 194);
            this.BottompipePB.TabIndex = 1;
            this.BottompipePB.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-192, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "label1";
            // 
            // ScoreTimer
            // 
            this.ScoreTimer.Enabled = true;
            this.ScoreTimer.Interval = 20;
            this.ScoreTimer.Tick += new System.EventHandler(this.ScoreTimerrrr);
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-12, 559);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1427, 221);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // FlopyBirdSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.BottompipePB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flopybirdPB);
            this.Controls.Add(this.TopPipePB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FlopyBirdSetup";
            this.Text = "Flopy Bird FRB";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.downkey);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.upkey);
            ((System.ComponentModel.ISupportInitialize)(this.TopPipePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flopybirdPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottompipePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLBL;
        private System.Windows.Forms.PictureBox TopPipePB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox flopybirdPB;
        private System.Windows.Forms.PictureBox BottompipePB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer ScoreTimer;
        private System.Windows.Forms.PictureBox ground;
    }
}

