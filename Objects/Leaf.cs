namespace CompositePatternExample.Objects
{
    public class Leaf : IComposite
    {
        private string Text { get; }

        public Leaf(string text)
        {
            Text = text;
        }

        public string ToHtml()
        {
            return "<input type=\"checkbox\" value=\"" + Text + "\"/>";
        }
    }
}