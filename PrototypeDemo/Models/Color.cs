namespace PrototypeDemo.Models
{
    public class Color : IClone
    {
        public int R { set; get; } = 0;
        public int G { set; get; } = 0;
        public int B { set; get; } = 0;
        public object Clone()
        {
            var result = new Color();
            result.R = this.R;
            result.G = this.G;
            result.B = this.B;
            return result;
        }
    }
}
