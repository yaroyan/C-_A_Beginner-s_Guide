/*

p,156 11.
四角形の面積を求めるクラスを作成する。

*/

using System;

class MyRect{
    public int width;
    public int height;

    public MyRect(int w, int h) {
        width = w;
        height = h;
    }

    public int Area() {
        return width * height;
    }
}