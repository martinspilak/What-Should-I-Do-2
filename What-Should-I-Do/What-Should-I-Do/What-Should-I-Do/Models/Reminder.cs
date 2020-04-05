using SQLite;

namespace What_Should_I_Do.Models
{
    public class Reminder
    {
        [PrimaryKey, AutoIncrement, Unique]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
    }
}
