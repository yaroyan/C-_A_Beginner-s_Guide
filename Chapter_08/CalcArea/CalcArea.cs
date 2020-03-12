// p,331 13

using System;

abstract class Shape {
    public Shape (int w, int h) {
        Width = w;
        Height = h;
    }
    public int Width { get; protected set; }
    public int Height { get; protected set; }

    public abstract int CalcArea ();
}

class Triangle : Shape {
    public Triangle (int w, int h) : base (w, h) { }
    public override int CalcArea () {
        return ((Width * Height) / 2);
    }
}

class RectAngle : Shape {
    public RectAngle (int w, int h) : base (w, h) { }
    public override int CalcArea () {
        return (Width * Height);
    }
}