namespace ConsoleApp3
{
    public class Cloud
    {
        public int size { get; set; }
        public string color { get; set; }
        public string type { get; set; }
        public int high { get; set; }
        public Cloud(int size, string color, string type, int high)
        {
            this.size = size;
            this.color = color;
            this.type = type;
            this.high = high;
        }
        public Cloud Clone()
        {
            return new Cloud(size, color, type, high);
        }
    }
}
