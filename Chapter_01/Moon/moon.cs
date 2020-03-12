/*
p,42 11.
地球上から月面での体重へ変換
*/

using System;

class moon {
    static void Main () {
        double earth_weight; // 地球上での体重
        double moon_weight; // 月面での体重

        earth_weight = 50.0;
        moon_weight = earth_weight * 0.17;

        Console.WriteLine ("地球上の体重：" + earth_weight);
        Console.WriteLine ("月面での体重：" + moon_weight);
    }
}