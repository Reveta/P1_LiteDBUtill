using LiteDB;

namespace P1_LiteDBUtill.com.reveta.liteBD.reader {
    
    public class DBConfig {
        private string DbName;
        private string config;
        public LiteDatabase Database{ get; private set; }

        public DBConfig(string dbName) {
            DbName = dbName;
            config = "Filename=" + dbName + ".litedb4; Mode=Exclusive;";
            Database = new LiteDatabase(config);
        }
    }
}