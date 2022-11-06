namespace WinCoreDC
{
    public partial class Form1 : Form
    {
        ParticleSystem s;

        public Form1()
        {
            InitializeComponent();

            // DoubleBuffered = true;
            //var f= picCanvas.DoubleBuffered; //only for Forms it is ok
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            
            s = new ParticleSystem(
                particleSize.Value,
                trackAge.Value);

            timer1.Interval = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled) timer16t.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            s.UpdatePositions();

            // if (s.Particles.Count < 100)
            //s.AddParticle(picCanvas.Width / 2, picCanvas.Height * 0.8f);
            s.AddParticle(canvas.Width / 2, canvas.Height * 0.8f);

            //picCanvas.Invalidate();
            canvas.Invalidate();

            label1.Text = s.Particles.Count.ToString();
        }

        Dictionary<int, SolidBrush> brushes = new();

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            //float v = particleSize.Value;
            //foreach (var p in s.Particles.Where(p => p.IsAlive))
            //{
            //    int transparency = (int)((1.0 - p.Age / (double)p.MaxAge) * 255.0);

            //    SolidBrush b;
            //    if (brushes.ContainsKey(transparency))
            //        b = brushes[transparency];
            //    else
            //    {
            //        b = new SolidBrush(Color.FromArgb((int)transparency, Color.White));
            //        brushes.Add(transparency, b);
            //    }
            //    e.Graphics.FillEllipse(b, p.X - v / 2, p.Y - v / 2, v, v);
            //}

        }

        private void picCanvas_Resize(object sender, EventArgs e)
        {
            //s.Bounds = picCanvas.ClientRectangle;
        }

        private void particleSize_Scroll(object sender, EventArgs e)
        {
            s.ParticleSize = particleSize.Value;
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 10; i++)
                s.AddParticle(e.X, e.Y);
        }

        private void btnRandomizeSpeeds_Click(object sender, EventArgs e)
        {
            s.IncreaseEnergy();
        }

        private void trackAge_Scroll(object sender, EventArgs e)
        {
            s.MaxAge = trackAge.Value;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            float v = particleSize.Value;
            foreach (var p in s.Particles.Where(p => p.IsAlive))
            {
                int transparency = (int)((1.0 - p.Age / (double)p.MaxAge) * 255.0);

                SolidBrush b;
                if (brushes.ContainsKey(transparency))
                    b = brushes[transparency];
                else
                {
                    b = new SolidBrush(Color.FromArgb((int)transparency, Color.White));
                    brushes.Add(transparency, b);
                }
                e.Graphics.FillEllipse(b, p.X - v / 2, p.Y - v / 2, v, v);
            }
        }
    }
}