using System;
using System.Linq;

namespace tottoko
{
    class Program
    {

        private static readonly string[] TOTTOTO = {
            "とっとと【自主規制】すよﾀﾋね太郎",
            "すみっこまでだよﾀﾋね太郎",
            "商売道具　ヒマワリの種",
            "やっぱり【自主規制】すよﾀﾋね太郎",
            "とっとと【自主規制】すよﾀﾋね太郎",
            "どこでも【自主規制】すよﾀﾋね太郎",
            "大好きなのはロコちゃんと金と美女～！",
            "やっぱり【自主規制】ﾀﾋね太郎",
        };

        private static readonly string[] ROKOTYAN ={
            "ぷりっきゅあ　ぷりっきゅあ",
            "ぷりきゅあ　ぷりきゅあ　ぷりきゅあ　ぷりきゅあ",
            "それぞれの夢　芽生え始めてる",
            "全部違う色だからドキドキするね",
            "やっぱプリキュアって最高だよな!",
            "ﾀﾋね太郎、お前ってやつは仕事出来てえらいぞ！！！天才ハムスターだな！！",
            "友達ほしい.......",
            "友達なんていなくても全然平気だし！！！！（大声）",
            "ｳｳ　ハムちゃんずは好きだけど友達は欲しい",
        };

        static void Main(string[] args)
        {
            var tottoko = TOTTOTO.OrderBy((_) => { return Guid.NewGuid(); }).First();
            var rokotyan = ROKOTYAN.OrderBy((_) => { return Guid.NewGuid(); }).First();
            Console.WriteLine( $"それではお聞きください。とっととﾀﾋね太郎さんによる「とっととハムちゃんずうた」です。「{tottoko}」そしてロコちゃんは「{rokotyan}」");
            }
    };
};
