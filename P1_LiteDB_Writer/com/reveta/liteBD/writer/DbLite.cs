using System;
using LiteDB;

namespace P1_LiteDBUtill.com.reveta.liteBD.writer {
    
    public class DbLite {
        private DBConfig _config;

        public DbLite(DBConfig config) {
            _config = config;
        }

        public bool WriteMessage(string carsN, string message) {
            try {
                using (LiteDatabase db = _config.Database) {
                    LiteCollection<Message> collection = db.GetCollection<Message>("Message");
                    Message newMessage = new Message(message, carsN, Status.Saved);
                    collection.Insert(newMessage);
                    return true;
                }
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}