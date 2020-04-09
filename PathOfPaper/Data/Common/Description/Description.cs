using System;
using System.Collections.Generic;

namespace PathOfPaper.Data.Common.Description
{
    public class Description : IDescription
    {
        public IEnumerable<string> Text { get; set; }

        public Description(string text)
        {
            Text = new [] { text };
        }

        public Description(IEnumerable<string> text)
        {
            Text = text;
        }

        public string Get()
        {
            return string.Join(Environment.NewLine, Text);
        }
    }
}