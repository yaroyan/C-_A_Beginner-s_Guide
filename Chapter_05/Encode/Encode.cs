/*

p,198 9.
排他的論理和を使ったメッセージのエンコードとデコード

*/

using System;

class Encode {
    static void Main () {
        string msg = "This is a test";
        string encmsg = "";
        string decmsg = "";
        string key = "abcdefgi";
        int j;

        Console.Write ("Original message : ");
        Console.WriteLine (msg);

        //メッセージのエンコード
        j = 0;
        for (int i = 0; i < msg.Length; i++) {
            encmsg += (char) (msg[i] ^ key[j]);
            j++;
            if (j == 8) j = 0;
        }

        Console.Write ("Encoded message : ");
        Console.WriteLine (encmsg);

        //メッセージのデコード
        j = 0;
        for (int i = 0; i < msg.Length; i++) {
            decmsg += (char) (encmsg[i] ^ key[j]);
            j++;
            if (j == 8) j = 0;
        }

        Console.Write ("Decoded message : ");
        Console.WriteLine (decmsg);
    }
}