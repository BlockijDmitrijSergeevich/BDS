﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USA
{
    class PaintScreen
    {
        public int Xoffset = 2000;
        public int Yoffset = 900;
        public Graphics BitMapgraphics { private set; get; }

        private Bitmap myBitmap;
        private PictureBox pictureBox;
        public PaintScreen(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            myBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            BitMapgraphics = Graphics.FromImage(myBitmap);
        }

        public void DrawFillArray(PointF[] points, float neg)
        {
            Pen p = new Pen(Color.Black, 1);
            BitMapgraphics.FillPolygon(new SolidBrush(ParsColor(neg)), points);
            BitMapgraphics.DrawPolygon(p, points);
        }
        public void DrawFillArray(Point[] points, float neg)
        {
            PointF[] pointFs = ParsArray(points);
            DrawFillArray(pointFs, neg);
        }
        public void Clear()
        {
            BitMapgraphics.Clear(Color.White);
        }
        public void Update()
        {
            pictureBox.Image = myBitmap;
        }
        private PointF Pars(Point point)
        {
            return new PointF(point.X * 10 + Xoffset, point.Y * -10 + Yoffset);
        }
        private PointF[] ParsArray(Point[] points)
        {
            PointF[] pointFs = new PointF[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                pointFs[i] = Pars(points[i]);
            }
            return pointFs;
        }
        private Color ParsColor(float neg)
        {
            Color color;
            if (neg == 0)
            {
                color = Color.FromArgb(220, 220, 220);
                return color;
            }
            int bneg = (int)Math.Abs(neg * 1275);
            if (neg > 0)
            {
                color = neg < 0.2 ? Color.FromArgb(255 - bneg, 255, 255 - bneg) : Color.FromArgb(0, 255, 0);
            }
            else
            {
                color = neg > -0.2 ? Color.FromArgb(255, 255 - bneg, 255 - bneg) : Color.FromArgb(255, 0, 0);
            }
            return color;
        }
    }
}