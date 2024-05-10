﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintCeunah.models
{
    public class Square : Shape
    {
        public Square(EnumShape shapeType, Point startPoint, Point endPoint, Color fillColor, Color borderColor, Pen borderWidth) : base(shapeType, startPoint, endPoint, fillColor, borderColor, borderWidth)
        {
        }

        public override void Draw(Graphics graphics)
        {
            // Hitung koordinat dan dimensi persegi
            int x = Math.Min(StartPoint.X, EndPoint.X);
            int y = Math.Min(StartPoint.Y, EndPoint.Y);
            int size = Math.Max(Math.Abs(StartPoint.X - EndPoint.X), Math.Abs(StartPoint.Y - EndPoint.Y));

            // Menggambar persegi
            graphics.DrawRectangle(BorderWidth, x, y, size, size);
            graphics.FillRectangle(BrushColor, x, y, size, size);
        }
    }
}
