using System;
using System.Collections.Generic;
using System.Linq;
using LiteDB;

namespace P1_LiteDBUtill.com.reveta.liteBD.reader {
    public class DbLite {
        private DBConfig _config;

        public DbLite(DBConfig config) {
            _config = config;
        }

        public void UpdateMessage(Message message) {
            GetMessageTable().Update(message);
        }

        public Message GetMessageById(int id) {
            return GetMessageTable().FindById(id);
        }

        public List<Message> GetMessageByCarsN(string carsN) {
            return GetMessageTable().Find(m => m.CarsN.Equals(carsN)).ToList();
        }

        public List<Message> GetMessageByText(string text) {
            return GetMessageTable().Find(m => m.Text.Equals(text)).ToList();
        }
        
        private LiteCollection<Message> GetMessageTable() {
            using (LiteDatabase db = _config.Database) {
                LiteCollection<Message> collection = db.GetCollection<Message>("Message");
                return collection;
            }
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