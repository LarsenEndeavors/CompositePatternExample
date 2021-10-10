using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePatternExample.Objects
{
    public class Node : IComposite
    {
        private string Title { get; }
        private List<IComposite> Leaves { get; }

        public Node(string title, List<IComposite> leaves)
        {
            Title = title;
            Leaves = leaves;
        }

        public string ToHtml()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<ul><li>" + Title);
            Leaves.ForEach(l => stringBuilder.AppendLine(l.ToHtml()));
            stringBuilder.AppendLine("</li></ul>");
            return stringBuilder.ToString();
        }
    }
}