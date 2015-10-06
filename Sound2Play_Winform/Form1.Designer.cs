namespace Sound2Play_Winform
{
    partial class Sound2Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sound2Play));
            this.ufo = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbUfoHeight = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbSoundValue = new System.Windows.Forms.Label();
            this.rbKeepGoing = new System.Windows.Forms.RadioButton();
            this.rbManulPlay = new System.Windows.Forms.RadioButton();
            this.canvas = new System.Windows.Forms.Panel();
            this.btnVoiceControl = new System.Windows.Forms.Button();
            this.lbCompositUpForce = new System.Windows.Forms.Label();
            this.lbGravity = new System.Windows.Forms.Label();
            this.lbSoundThreshold = new System.Windows.Forms.Label();
            this.lbSoundDivisor = new System.Windows.Forms.Label();
            this.sbGravity = new System.Windows.Forms.VScrollBar();
            this.lbUfoGravity = new System.Windows.Forms.Label();
            this.lbSThreshold = new System.Windows.Forms.Label();
            this.lbSDivisor = new System.Windows.Forms.Label();
            this.sbSoundThreshold = new System.Windows.Forms.VScrollBar();
            this.sbSoundDivisor = new System.Windows.Forms.VScrollBar();
            this.btnGo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbKeepGoing2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            this.canvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ufo
            // 
            this.ufo.BackColor = System.Drawing.Color.Transparent;
            this.ufo.Image = ((System.Drawing.Image)(resources.GetObject("ufo.Image")));
            this.ufo.Location = new System.Drawing.Point(545, 277);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(100, 84);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ufo.TabIndex = 0;
            this.ufo.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbUfoHeight
            // 
            this.lbUfoHeight.AutoSize = true;
            this.lbUfoHeight.BackColor = System.Drawing.Color.Transparent;
            this.lbUfoHeight.Location = new System.Drawing.Point(9, 608);
            this.lbUfoHeight.Name = "lbUfoHeight";
            this.lbUfoHeight.Size = new System.Drawing.Size(89, 20);
            this.lbUfoHeight.TabIndex = 1;
            this.lbUfoHeight.Text = "Ufo\' Height";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(469, 247);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(220, 114);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "result";
            this.lbResult.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 41);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(351, 39);
            this.progressBar1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(351, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // lbSoundValue
            // 
            this.lbSoundValue.AutoSize = true;
            this.lbSoundValue.BackColor = System.Drawing.Color.Transparent;
            this.lbSoundValue.Location = new System.Drawing.Point(362, 51);
            this.lbSoundValue.Name = "lbSoundValue";
            this.lbSoundValue.Size = new System.Drawing.Size(101, 20);
            this.lbSoundValue.TabIndex = 5;
            this.lbSoundValue.Text = "Sound Value";
            // 
            // rbKeepGoing
            // 
            this.rbKeepGoing.AutoSize = true;
            this.rbKeepGoing.BackColor = System.Drawing.Color.Transparent;
            this.rbKeepGoing.Checked = true;
            this.rbKeepGoing.Location = new System.Drawing.Point(215, 131);
            this.rbKeepGoing.Name = "rbKeepGoing";
            this.rbKeepGoing.Size = new System.Drawing.Size(118, 24);
            this.rbKeepGoing.TabIndex = 6;
            this.rbKeepGoing.TabStop = true;
            this.rbKeepGoing.Text = "Keep Going";
            this.rbKeepGoing.UseVisualStyleBackColor = false;
            this.rbKeepGoing.CheckedChanged += new System.EventHandler(this.rbKeepGoing_CheckedChanged);
            // 
            // rbManulPlay
            // 
            this.rbManulPlay.AutoSize = true;
            this.rbManulPlay.BackColor = System.Drawing.Color.Transparent;
            this.rbManulPlay.Location = new System.Drawing.Point(215, 164);
            this.rbManulPlay.Name = "rbManulPlay";
            this.rbManulPlay.Size = new System.Drawing.Size(110, 24);
            this.rbManulPlay.TabIndex = 7;
            this.rbManulPlay.Text = "Manul Play";
            this.rbManulPlay.UseVisualStyleBackColor = false;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.canvas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("canvas.BackgroundImage")));
            this.canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.canvas.Controls.Add(this.rbKeepGoing2);
            this.canvas.Controls.Add(this.btnVoiceControl);
            this.canvas.Controls.Add(this.lbCompositUpForce);
            this.canvas.Controls.Add(this.lbGravity);
            this.canvas.Controls.Add(this.lbSoundThreshold);
            this.canvas.Controls.Add(this.lbSoundDivisor);
            this.canvas.Controls.Add(this.sbGravity);
            this.canvas.Controls.Add(this.lbUfoGravity);
            this.canvas.Controls.Add(this.lbSThreshold);
            this.canvas.Controls.Add(this.lbSDivisor);
            this.canvas.Controls.Add(this.sbSoundThreshold);
            this.canvas.Controls.Add(this.sbSoundDivisor);
            this.canvas.Controls.Add(this.btnGo);
            this.canvas.Controls.Add(this.ufo);
            this.canvas.Controls.Add(this.progressBar1);
            this.canvas.Controls.Add(this.comboBox1);
            this.canvas.Controls.Add(this.rbManulPlay);
            this.canvas.Controls.Add(this.lbResult);
            this.canvas.Controls.Add(this.rbKeepGoing);
            this.canvas.Controls.Add(this.lbUfoHeight);
            this.canvas.Controls.Add(this.lbSoundValue);
            this.canvas.Controls.Add(this.pictureBox1);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(978, 744);
            this.canvas.TabIndex = 8;
            // 
            // btnVoiceControl
            // 
            this.btnVoiceControl.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnVoiceControl.FlatAppearance.BorderSize = 0;
            this.btnVoiceControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnVoiceControl.ForeColor = System.Drawing.Color.Black;
            this.btnVoiceControl.Location = new System.Drawing.Point(215, 302);
            this.btnVoiceControl.Name = "btnVoiceControl";
            this.btnVoiceControl.Size = new System.Drawing.Size(110, 59);
            this.btnVoiceControl.TabIndex = 9;
            this.btnVoiceControl.Text = "Voice Control";
            this.btnVoiceControl.UseVisualStyleBackColor = false;
            this.btnVoiceControl.Click += new System.EventHandler(this.btnVoiceControl_Click);
            // 
            // lbCompositUpForce
            // 
            this.lbCompositUpForce.AutoSize = true;
            this.lbCompositUpForce.BackColor = System.Drawing.Color.Transparent;
            this.lbCompositUpForce.Location = new System.Drawing.Point(9, 578);
            this.lbCompositUpForce.Name = "lbCompositUpForce";
            this.lbCompositUpForce.Size = new System.Drawing.Size(150, 20);
            this.lbCompositUpForce.TabIndex = 18;
            this.lbCompositUpForce.Text = "Composit Up Force:";
            // 
            // lbGravity
            // 
            this.lbGravity.AutoSize = true;
            this.lbGravity.BackColor = System.Drawing.Color.Transparent;
            this.lbGravity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGravity.ForeColor = System.Drawing.Color.Blue;
            this.lbGravity.Location = new System.Drawing.Point(120, 532);
            this.lbGravity.Name = "lbGravity";
            this.lbGravity.Size = new System.Drawing.Size(33, 25);
            this.lbGravity.TabIndex = 17;
            this.lbGravity.Text = "gv";
            // 
            // lbSoundThreshold
            // 
            this.lbSoundThreshold.AutoSize = true;
            this.lbSoundThreshold.BackColor = System.Drawing.Color.Transparent;
            this.lbSoundThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoundThreshold.ForeColor = System.Drawing.Color.Green;
            this.lbSoundThreshold.Location = new System.Drawing.Point(65, 532);
            this.lbSoundThreshold.Name = "lbSoundThreshold";
            this.lbSoundThreshold.Size = new System.Drawing.Size(27, 25);
            this.lbSoundThreshold.TabIndex = 16;
            this.lbSoundThreshold.Text = "tv";
            // 
            // lbSoundDivisor
            // 
            this.lbSoundDivisor.AutoSize = true;
            this.lbSoundDivisor.BackColor = System.Drawing.Color.Transparent;
            this.lbSoundDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoundDivisor.ForeColor = System.Drawing.Color.Red;
            this.lbSoundDivisor.Location = new System.Drawing.Point(7, 532);
            this.lbSoundDivisor.Name = "lbSoundDivisor";
            this.lbSoundDivisor.Size = new System.Drawing.Size(33, 25);
            this.lbSoundDivisor.TabIndex = 15;
            this.lbSoundDivisor.Text = "dv";
            // 
            // sbGravity
            // 
            this.sbGravity.Location = new System.Drawing.Point(121, 131);
            this.sbGravity.Name = "sbGravity";
            this.sbGravity.Size = new System.Drawing.Size(30, 401);
            this.sbGravity.TabIndex = 14;
            this.sbGravity.Value = 8;
            this.sbGravity.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbGravity_Scroll);
            // 
            // lbUfoGravity
            // 
            this.lbUfoGravity.AutoSize = true;
            this.lbUfoGravity.BackColor = System.Drawing.Color.Transparent;
            this.lbUfoGravity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUfoGravity.ForeColor = System.Drawing.Color.Blue;
            this.lbUfoGravity.Location = new System.Drawing.Point(117, 88);
            this.lbUfoGravity.Name = "lbUfoGravity";
            this.lbUfoGravity.Size = new System.Drawing.Size(42, 37);
            this.lbUfoGravity.TabIndex = 12;
            this.lbUfoGravity.Text = "G";
            // 
            // lbSThreshold
            // 
            this.lbSThreshold.AutoSize = true;
            this.lbSThreshold.BackColor = System.Drawing.Color.Transparent;
            this.lbSThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSThreshold.ForeColor = System.Drawing.Color.Green;
            this.lbSThreshold.Location = new System.Drawing.Point(63, 89);
            this.lbSThreshold.Name = "lbSThreshold";
            this.lbSThreshold.Size = new System.Drawing.Size(37, 37);
            this.lbSThreshold.TabIndex = 12;
            this.lbSThreshold.Text = "T";
            // 
            // lbSDivisor
            // 
            this.lbSDivisor.AutoSize = true;
            this.lbSDivisor.BackColor = System.Drawing.Color.Transparent;
            this.lbSDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDivisor.ForeColor = System.Drawing.Color.Red;
            this.lbSDivisor.Location = new System.Drawing.Point(6, 88);
            this.lbSDivisor.Name = "lbSDivisor";
            this.lbSDivisor.Size = new System.Drawing.Size(40, 37);
            this.lbSDivisor.TabIndex = 12;
            this.lbSDivisor.Text = "D";
            // 
            // sbSoundThreshold
            // 
            this.sbSoundThreshold.Location = new System.Drawing.Point(64, 131);
            this.sbSoundThreshold.Name = "sbSoundThreshold";
            this.sbSoundThreshold.Size = new System.Drawing.Size(30, 401);
            this.sbSoundThreshold.TabIndex = 11;
            this.sbSoundThreshold.Value = 5;
            this.sbSoundThreshold.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbSoundThreshold_Scroll);
            // 
            // sbSoundDivisor
            // 
            this.sbSoundDivisor.Location = new System.Drawing.Point(7, 131);
            this.sbSoundDivisor.Name = "sbSoundDivisor";
            this.sbSoundDivisor.Size = new System.Drawing.Size(30, 401);
            this.sbSoundDivisor.TabIndex = 10;
            this.sbSoundDivisor.Value = 15;
            this.sbSoundDivisor.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbSoundDivisor_Scroll);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(215, 226);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(110, 54);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(833, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // rbKeepGoing2
            // 
            this.rbKeepGoing2.AutoSize = true;
            this.rbKeepGoing2.Location = new System.Drawing.Point(215, 195);
            this.rbKeepGoing2.Name = "rbKeepGoing2";
            this.rbKeepGoing2.Size = new System.Drawing.Size(248, 24);
            this.rbKeepGoing2.TabIndex = 19;
            this.rbKeepGoing2.TabStop = true;
            this.rbKeepGoing2.Text = "Sound Value Control Direction";
            this.rbKeepGoing2.UseVisualStyleBackColor = true;
            this.rbKeepGoing2.CheckedChanged += new System.EventHandler(this.rbKeepGoing2_CheckedChanged);
            // 
            // Sound2Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.canvas);
            this.Name = "Sound2Play";
            this.Text = "Sound2Play";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.Sound2Play_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            this.canvas.ResumeLayout(false);
            this.canvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbUfoHeight;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbSoundValue;
        private System.Windows.Forms.RadioButton rbKeepGoing;
        private System.Windows.Forms.RadioButton rbManulPlay;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.VScrollBar sbSoundDivisor;
        private System.Windows.Forms.VScrollBar sbSoundThreshold;
        private System.Windows.Forms.Label lbSThreshold;
        private System.Windows.Forms.Label lbSDivisor;
        private System.Windows.Forms.VScrollBar sbGravity;
        private System.Windows.Forms.Label lbUfoGravity;
        private System.Windows.Forms.Label lbGravity;
        private System.Windows.Forms.Label lbSoundThreshold;
        private System.Windows.Forms.Label lbSoundDivisor;
        private System.Windows.Forms.Label lbCompositUpForce;
        private System.Windows.Forms.Button btnVoiceControl;
        private System.Windows.Forms.RadioButton rbKeepGoing2;
    }
}

