/*

p,361 6.

*/

using System;

interface IVehicle {
    int Range ();
    double FuelNeeded (int miles);
    int Passengers { get; set; }
    int FuelCap { get; set; }
    int Mpg { get; set; }
}

class Vehicle : IVehicle {

    //Vehicleクラスのコンストラクター
    public Vehicle (int p, int f, int m) {
        Passengers = p;
        FuelCap = f;
        Mpg = m;
    }

    //走行距離を返す
    public int Range () {
        return Mpg * FuelCap;
    }

    //与えられた走行距離で必要な燃料を求める
    public double FuelNeeded (int miles) {
        return (double) miles / Mpg;
    }

    //乗客定員、燃料容量、および燃費のための自動実装するプロパティ
    public int Passengers { get; protected set; }
    public int FuelCap { get; protected set; }
    public int Mpg { get; protected set; }
}