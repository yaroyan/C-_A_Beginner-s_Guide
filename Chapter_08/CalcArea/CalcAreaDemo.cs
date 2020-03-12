// p,331 14

using System;

class Test {
    static void Main () {
        Shape[] list = {
            new Triangle (100, 50),
            new RectAngle (10, 10),
            new RectAngle (10, 30)
        };

        foreach (Shape ob in list) {
            Console.WriteLine (ob.CalcArea ());
        }
    }
}