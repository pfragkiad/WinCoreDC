namespace WinCoreDC
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.particleSize = new System.Windows.Forms.TrackBar();
            this.btnRandomizeSpeeds = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackAge = new System.Windows.Forms.TrackBar();
            this.canvas = new WinCoreDC.BufferedControl();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particleSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackAge)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCanvas.BackColor = System.Drawing.Color.Black;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Location = new System.Drawing.Point(48, 373);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(124, 113);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.Resize += new System.EventHandler(this.picCanvas_Resize);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // particleSize
            // 
            this.particleSize.Location = new System.Drawing.Point(40, 102);
            this.particleSize.Maximum = 50;
            this.particleSize.Minimum = 5;
            this.particleSize.Name = "particleSize";
            this.particleSize.Size = new System.Drawing.Size(166, 45);
            this.particleSize.TabIndex = 2;
            this.particleSize.Value = 30;
            this.particleSize.Scroll += new System.EventHandler(this.particleSize_Scroll);
            // 
            // btnRandomizeSpeeds
            // 
            this.btnRandomizeSpeeds.Location = new System.Drawing.Point(48, 169);
            this.btnRandomizeSpeeds.Name = "btnRandomizeSpeeds";
            this.btnRandomizeSpeeds.Size = new System.Drawing.Size(134, 23);
            this.btnRandomizeSpeeds.TabIndex = 3;
            this.btnRandomizeSpeeds.Text = "Randomize Speeds";
            this.btnRandomizeSpeeds.UseVisualStyleBackColor = true;
            this.btnRandomizeSpeeds.Click += new System.EventHandler(this.btnRandomizeSpeeds_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // trackAge
            // 
            this.trackAge.Location = new System.Drawing.Point(48, 335);
            this.trackAge.Maximum = 100;
            this.trackAge.Minimum = 40;
            this.trackAge.Name = "trackAge";
            this.trackAge.Size = new System.Drawing.Size(158, 45);
            this.trackAge.TabIndex = 5;
            this.trackAge.Value = 40;
            this.trackAge.Scroll += new System.EventHandler(this.trackAge_Scroll);
            // 
            // canvas
            // 
            this.canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas.BackColor = System.Drawing.Color.Black;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(238, 29);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(479, 445);
            this.canvas.TabIndex = 6;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 486);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.trackAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRandomizeSpeeds);
            this.Controls.Add(this.particleSize);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particleSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private PictureBox picCanvas;
        private System.Windows.Forms.Timer timer1;
        private TrackBar particleSize;
        private Button btnRandomizeSpeeds;
        private Label label1;
        private TrackBar trackAge;
        private BufferedControl canvas;
    }
}