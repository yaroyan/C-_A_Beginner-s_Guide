/*

例７－１
char型データ用のクラス

*/

using System;

class Set {
    char[] members; //この配列がセットの値を保持する

    //実質的に読み取り専用の、自動実装するLengthプロパティ
    public int Length { get; private set; }

    //nullのセット（配列の実態がないセット）を作る
    public Set () {
        Length = 0;
    }

    //指定されたサイズの領域を持つ空のセットを作る
    public Set (int size) {
        members = new char[size]; //セットのためにメモリを確保
        Length = 0; //実質的な要素はない
    }

    //セットから別のセットを作る
    public Set (Set s) {
        members = new char[s.Length]; //セットのためにメモリを確保
        for (int i = 0; i < s.Length; i++) members[i] = s[i];
        Length = s.Length; //実質的な要素の数
    }

    //読み取り専用のインデクサー
    public char this [int idx] {
        get {
            if (idx >= 0 & idx < Length) return members[idx];
            else return (char) 0;
        }
    }

    /*
        引数で指定されたデータがセットの中に存在するかチェックする
        あればそのインデックスを返し、なければ-1を返す
    */
    int find (char ch) {
        int i;

        for (i = 0; i < Length; i++)
            if (members[i] == ch) return i;
        return -1;
    }

    //ユニークな要素をセットに追加する
    public static Set operator + (Set ob, char ch) {
        //もし、セットの中にchと同じものが既に存在していた場合は、元のセットのコピーを返す
        if (ob.find (ch) != -1) {

            //元のセットのコピーを返す
            return new Set (ob);

        } else { //新しい要素を含む新しいセットを返す

            //元のセットよりも、要素1つ分だけ大きいセットを新規作成する
            Set newset = new Set (ob.Length + 1);

            //新しいセットに要素をコピーする
            for (int i = 0; i < ob.Length; i++)
                newset.members[i] = ob.members[i];

            //Lengthプロパティを設定する
            newset.Length = ob.Length + 1;

            //新しいセットに新しい要素を追加する
            newset.members[newset.Length - 1] = ch;

            return newset; //新しいセットを返す
        }
    }

    //セットから要素を取り除く
    public static Set operator - (Set ob, char ch) {
        Set newset = new Set ();
        int i = ob.find (ch); //もし見つからなければ、変数iは-1になる

        //残りの要素をコピーする
        for (int j = 0; j < ob.Length; j++)
            if (j != i) newset = newset + ob.members[j];

        return newset;
    }

    //和集合
    public static Set operator + (Set ob1, Set ob2) {
        Set newset = new Set (ob1); //1番目のセットをコピーする

        //2番目のセットの要素を追加する
        for (int i = 0; i < ob2.Length; i++)
            newset = newset + ob2[i];

        return newset; //更新されたセットを返す
    }

    //差集合
    public static Set operator - (Set ob1, Set ob2) {
        Set newset = new Set (ob1); //1番目のセットをコピーする

        //2番目のセットの要素を1番目のセットから引く
        for (int i = 0; i < ob2.Length; i++)
            newset = newset - ob2[i];

        return newset; //更新されたセットを返す
    }

    //１番目のセットが２番目のセットの部分集合であるか判定する
    public static bool operator < (Set ob1, Set ob2) {

        //ob1のほうが要素数の多い場合はfalseを返して終了する
        if (ob1.Length > ob2.Length) return false;

        for (int i = 0; i < ob2.Length; i++)
            if (ob2.find (ob1[i]) == -1) return false;

        return true;
    }

    //１番目のセットが２番目のセットの上位集合であるか判定する
    public static bool operator > (Set ob1, Set ob2) {

        //ob1のほうが要素数の少ない場合はfalseを返して終了する
        if (ob1.Length < ob2.Length) return false;

        for (int i = 0; i < ob2.Length; i++)
            if (ob1.find (ob2[i]) == -1) return false;

        return true;
    }

    //１番目のセットが２番目のセットの積集合を求める
    public static Set operator & (Set ob1, Set ob2) {

        Set newset = new Set ();

        //両方のセットに共通の要素を新しいセットへ追加する
        for (int i = 0; i < ob1.Length; i++)
            if (ob2.find (ob1[i]) != -1)
                //ob1[i]がob2に存在するならば、その要素を新しいセットに追加する
                newset = newset + ob1[i];

        return newset;
    }

    //１番目のセットが２番目のセットの対称差を求める
    public static Set operator | (Set ob1, Set ob2) {
        
        Set newset = new Set();

        //ob1の中でob2に存在しない要素を新しいセットに追加する
        for(int i = 0; i < ob1.Length; i++)
            if(ob2.find(ob1[i]) == -1)
                //ob1[i]がob2に存在しないならば、その要素を新しいセットに追加する。
                newset = newset + ob1[i];

        //ob2の中でob1に存在しない要素を新しいセットに追加する
        for(int i = 0; i < ob2.Length; i++)
            if(ob1.find(ob2[i]) == -1)
                //ob2[i]がob1に存在しないならば、その要素を新しいセットに追加する。
                newset = newset + ob2[i];

        return newset;
    }

}

//Setクラスの使用例
class SetDemo {
    static void Main () {
        Set s1 = new Set ();
        Set s2 = new Set ();
        Set s3 = new Set ();

        s1 = s1 + 'A';
        s1 = s1 + 'B';
        s1 = s1 + 'C';

        Console.Write ("s1 after adding A B C: ");
        for (int i = 0; i < s1.Length; i++)
            Console.Write (s1[i] + " ");
        Console.WriteLine ();

        s1 = s1 - 'B';
        Console.Write ("s1 after s1 = s1 - 'B': ");
        for (int i = 0; i < s1.Length; i++)
            Console.Write (s1[i] + " ");
        Console.WriteLine ();

        s1 = s1 - 'A';
        Console.Write ("s1 after s1 = s1 - 'A': ");
        for (int i = 0; i < s1.Length; i++)
            Console.Write (s1[i] + " ");
        Console.WriteLine ();

        s1 = s1 - 'C';
        Console.Write ("s1 after s1 = s1 - 'C': ");
        for (int i = 0; i < s1.Length; i++)
            Console.Write (s1[i] + " ");
        Console.WriteLine ("\n");

        s1 = s1 + 'A';
        s1 = s1 + 'B';
        s1 = s1 + 'C';

        Console.Write ("s1 after adding A B C: ");
        for (int i = 0; i < s1.Length; i++)
            Console.Write (s1[i] + " ");
        Console.WriteLine ();

        s2 = s2 + 'A';
        s2 = s2 + 'X';
        s2 = s2 + 'W';

        Console.Write ("s2 after adding A X W: ");
        for (int i = 0; i < s2.Length; i++)
            Console.Write (s2[i] + " ");
        Console.WriteLine ();

        s3 = s1 + s2;
        Console.Write ("s3 after s3 =  s1 + s2: ");
        for (int i = 0; i < s3.Length; i++)
            Console.Write (s3[i] + " ");
        Console.WriteLine ();

        s3 = s3 - s1;
        Console.Write ("s3 after s3 =  s3 - s1: ");
        for (int i = 0; i < s3.Length; i++)
            Console.Write (s3[i] + " ");
        Console.WriteLine ("\n");

        s2 = s2 - s2; //s2のクリア
        s2 = s2 + 'C'; //逆の順番にABCを加える
        s2 = s2 + 'B';
        s2 = s2 + 'A';

        Console.Write ("s1 is now: ");
        for (int i = 0; i < s1.Length; i++)
            Console.Write (s1[i] + " ");
        Console.WriteLine ();

        Console.Write ("s2 is now: ");
        for (int i = 0; i < s2.Length; i++)
            Console.Write (s2[i] + " ");
        Console.WriteLine ();

        Console.Write ("s3 is now: ");
        for (int i = 0; i < s3.Length; i++)
            Console.Write (s3[i] + " ");
        Console.WriteLine ();

    }
}