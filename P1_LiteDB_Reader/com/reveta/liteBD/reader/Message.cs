namespace P1_LiteDBUtill.com.reveta.liteBD.reader {
    public class Message {
        public int Id { get; set; }
        public string Text { get; set; }
        public string CarsN { get; set; }
        public Status Status { get; set; }

        
        public Message() { }

        public Message(string text, string carsN, Status status) {
            Text = text;
            CarsN = carsN;
            Status = status;
        }

        public override string ToString() {
            return string.Format("Id: {0}, Text: {1}, CarsN: {2}, Status: {3}", Id, Text, CarsN, Status);
        }
    }

    public enum Status {
        Saved, //Message was saved at db
        Loaded, //Message was loaded from db
        Used ////Message was loaded and showed on scoreboard
    }
}