using System.Drawing;


namespace CarWashManagement.Core.Features
{
    public class StrengthLevel
    {
        public string Text { get; }
        public Color Color { get; } 
        public StrengthLevel(string text, Color color)
        {
            Text = text;
            Color = color;
        }
    }
}