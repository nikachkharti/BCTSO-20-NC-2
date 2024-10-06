namespace Lecture8.MiniBank.Models
{
    public class Client : Person // მემკვიდრეობა
    {
        public Account Account { get; set; } // კომპოზიცია
    }
}
