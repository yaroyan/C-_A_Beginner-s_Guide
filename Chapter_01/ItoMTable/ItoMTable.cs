/*

p,42 12.
インチからメートルへ変換表

*/

using System;

class ItoMTable {
    static void Main () {
        double inches, meters;
        int counter;

        counter = 0;

        for (inches = 0.0; inches <= 144.0; inches++) {
            meters = inches / 39.37;

            Console.WriteLine (inches + "Inches is" + meters + "meters.");

            counter++;

            //10行ごとに空白行を出力する
            if (counter == 12) {
                Console.WriteLine ();
                counter = 0; //行カウンターのリセット
            }
        }
    }
}