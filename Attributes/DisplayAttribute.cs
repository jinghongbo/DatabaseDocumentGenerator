using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDocumentGenerator.Attributes
{
    public class DisplayAttribute : Attribute
    {
        public string Text { get; set; }
        public DisplayAttribute(string text)
        {
            Text = text;
        }
    }
}
