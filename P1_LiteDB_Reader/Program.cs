using System;
using P1_LiteDBUtill.com.reveta.liteBD.reader;

namespace P1_LiteDBUtill {
    internal class Program {
        public static void Main(string[] args) {
            DbLite db = new DbLite(new DBConfig("test"));
            Message messageByCarsN = db.GetMessageByCarsN(args[0])[0];

//            messageByCarsN.Status = Status.Saved;
//            db.UpdateMessage(messageByCarsN);
            Console.WriteLine(messageByCarsN);
        }
    }
}