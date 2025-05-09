using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    //売上集計クラス
    public class SalesCounter {
        private readonly IEnumerable<Sale> _sales;
        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }
        //店舗別売り上げを求める
        public IDictionary<String, int> GetPerStoreSales() {
            var dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }
        //売り上げデータの読み込み、Saleオブジェクトのリストを返す
        public static IEnumerable<Sale> ReadSales(String filePath) {
            //売り上げデータを入れるリストオブジェクト
            var sales = new List<Sale>();
            //ファイルを一気に読み込む
            var lines = File.ReadAllLines(filePath);
            //読み込んだ行数分繰り返し
            foreach (var line in lines) {
                string[] items = line.Split(',');
                //Saleオブジェクトを生成
                var sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }
    }
}
