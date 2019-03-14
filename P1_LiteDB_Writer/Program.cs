
using P1_LiteDBUtill.com.reveta.liteBD;
using P1_LiteDBUtill.com.reveta.liteBD.writer;

namespace P1_LiteDBUtill {
    internal class Program {
        public static void Main(string[] args) {
            DbLite db = new DbLite(new DBConfig("test"));

            db.WriteMessage(args[0], args[1]);
        }
    }
}