using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EyeTestHack
{
    public partial class Form1 : Form
    {
        Bitmap CapturedImage = null;

        class PointOfInterest
        {
            public int X;
            public int Y;
            public Color Color;

            public PointOfInterest()
            {
            }

            public PointOfInterest(int x, int y, Color c)
            {
                this.X = x;
                this.Y = y;
                this.Color = c;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        void CaptureImage()
        {
            int x = 0, y = 0, width = 1366, height = 768;

            if (!int.TryParse(txtX.Text, out x))
            {
                txtX.Text = "0";
                x = 0;
            }

            if (!int.TryParse(txtY.Text, out y))
            {
                txtY.Text = "0";
                y = 0;
            }

            if (!int.TryParse(txtWidth.Text, out width))
            {
                txtWidth.Text = "1366";
                width = 1366;
            }

            if (!int.TryParse(txtHeight.Text, out height))
            {
                txtHeight.Text = "768";
                height = 768;
            }

            try
            {
                using (Bitmap bmpScreenCapture = new Bitmap(width, height))
                {
                    using (Graphics g = Graphics.FromImage(bmpScreenCapture))
                    {
                        g.CopyFromScreen(x, y, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
                    }

                    CapturedImage = bmpScreenCapture.Clone(new Rectangle(0, 0, width, height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                }
            }
            catch
            {
                MessageBox.Show("Cannot capture screenshot");
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            CaptureImage();
            if (CapturedImage != null)
            {
                pbCapturedImage.Image = CapturedImage;
            }
        }        

        private void btnCaptureAndShow_Click(object sender, EventArgs e)
        {
            CaptureImage();
            if (CapturedImage != null)
            {
                int width = CapturedImage.Width;
                int height = CapturedImage.Height;
                int R, G, B;
                int cR = 0, cG = 0, cB = 0;

                List<PointOfInterest> POIs = new List<PointOfInterest>();

                for (int r = 0; r < height - 5; r += 10)
                {
                    for (int c = 0; c < width - 5; c += 10)
                    {
                        cR = 0;
                        cG = 0;
                        cB = 0;
                        bool is_same = true;
                        bool bg = false;

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                Color PixelColor = CapturedImage.GetPixel(c + j, r + i);
                                R = PixelColor.R;
                                G = PixelColor.G;
                                B = PixelColor.B;

                                if (R == 255 && G == 255 && B == 255)
                                {
                                    bg = true;
                                    break;
                                }

                                if (cR == 0 && cG == 0 && cB == 0)
                                {
                                    cR = R;
                                    cG = G;
                                    cB = B;
                                }
                                else
                                {
                                    if (cR != R || cG != G || cB != B)
                                    {
                                        is_same = false;
                                        break;
                                    }
                                }
                            }
                            if (!is_same || bg) break;
                        }
                        if (is_same && !bg)
                        {
                            POIs.Add(new PointOfInterest(c, r, Color.FromArgb(cR, cG, cB)));
                        }
                    }
                }

                if (POIs.Count > 0)
                {
                    var g = POIs.GroupBy(poi => poi.Color).Select(n => new { Color = n.Key, Items = n.ToList() }).ToList().OrderBy(a => a.Items.Count).ToList()[0].Color;

                    for (int r = 0; r < height; r++)
                    {
                        for (int c = 0; c < width; c++)
                        {
                            Color PixelColor = CapturedImage.GetPixel(c, r);
                            R = PixelColor.R;
                            G = PixelColor.G;
                            B = PixelColor.B;

                            if (R == g.R && G == g.G && B == g.B)
                            {
                                CapturedImage.SetPixel(c, r, Color.FromArgb(255, 255, 255));
                            }
                        }
                    }
                }

                pbCapturedImage.Image = CapturedImage;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (txtX.CanFocus)
            {
                txtX.Focus();
            }
        }
    }
}
