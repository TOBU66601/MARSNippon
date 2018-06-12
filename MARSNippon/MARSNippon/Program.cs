using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSNippon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "---------------------------\n" +
                "BVE日本線専用　出札システム\n"+
                "---------------------------"
                );

            Console.WriteLine(
                "業務内容選択"
                );

            Console.WriteLine(
                "0.駅設定\n" +
                "1.担当者登録\n" +
                "2.出札業務\n" +
                "3.レポート出力\n" +
                "4.精算\n" +
                "5.メンテナンス"

                );
            //0~業務を入力させる。その後、駅番号を入力させる。→コマンドフォーム変更
            //最終シャットダウンの内容も書かせる。

            Console.WriteLine("試作中。何かキーを押してクローズ");
            Console.ReadKey();
            //本環境では完全隠し
        }

        
    }
}
