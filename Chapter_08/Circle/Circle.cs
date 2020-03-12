/*

p,331 2

*/

using System;

abstract class TwoDShape {
    double pri_width;
    double pri_height;

    //デフォルトコンストラクター
    public TwoDShape () {
        Width = Height = 0;
        Name = "null";
    }

    //すべての情報を指定する引数を持つコンストラクター
    public TwoDShape (double w, double h, string n) {
        Width = w;
        Height = h;
        Name = n;
    }

    //幅と高さが等しい場合のコンストラクター
    public TwoDShape (double x, string n) {
        Width = Height = x;
        Name = n;
    }

    //オブジェクトから別のオブジェクトを作るコンストラクター
    public TwoDShape (TwoDShape ob) {
        Width = ob.Width;
        Height = ob.Height;
        Name = ob.Name;
    }

    //Width,Height,Nameの各プロパティ
    public double Width {
        get { return pri_width; }
        set { pri_width = value < 0 ? -value : value; }
    }

    public double Height {
        get { return pri_height; }
        set { pri_height = value < 0 ? -value : value; }
    }

    public string Name { get; set; }

    public void ShowDim () {
        Console.WriteLine ("Width and Height are" + Width + " and " + Height);
    }

    //Area()の抽象メソッド
    public abstract double Area ();

}

class Cirle : TwoDShape {
    //コンストラクター
    public Circle (double x) : base (x, "Circle") { }

    //別のインスタンスから作成するコンストラクター
    public Circle (Circle ob) : base (ob) { }

    public override double Area () {
        return (Width / 2) * (Width / 2) * 3.14;
    }
}