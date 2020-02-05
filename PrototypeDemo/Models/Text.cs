using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDemo.Models
{
    public enum FontType
    {
        Normal,
        Bold,
        Italic
    }

    public enum FontFamily
    {
        Arial,
        ArialBlack,
        TimesNewRoman,
        Calibri
    }

    public class Text : IClone
    {
        private FontType _fontType;
        private FontFamily _fontFamily;
        public string Texto { set; get; }
        public Color Color { set; get; }

        public Text()
        {
            _fontType = FontType.Normal;
            _fontFamily = FontFamily.Arial;
            Texto = string.Empty;
            Color = new Color();
        }

        public void ChangeFont(FontType fontType)
        {
            this._fontType = fontType;
        }

        public void TextInfo()
        {
            Console.WriteLine($"Texto: {Texto}, FontType: {_fontType}, FontFamily:{_fontFamily}, Color: {Color.R} {Color.G} {Color.B}");
        }

        public object Clone()
        {
            var result =  new Text();
            result.Texto = this.Texto;
            result.ChangeFont(this._fontType);
            result.Color = (Color) this.Color.Clone();
            return result;
        }
    }
}
