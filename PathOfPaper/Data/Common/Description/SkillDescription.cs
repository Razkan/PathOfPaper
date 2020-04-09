using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PathOfPaper.Data.Skill.Tag;

namespace PathOfPaper.Data.Common.Description
{
    public class SkillDescription : IDescription
    {
        public IEnumerable<ITag> Tags { get; set; }
        public IEnumerable<string> Text { get; set; }

        public SkillDescription(IEnumerable<ITag> tags, string text)
        {
            Tags = tags;
            Text = new[] { text };
        }

        public SkillDescription(IEnumerable<ITag> tags, IEnumerable<string> text)
        {
            Tags = tags;
            Text = text;
        }

        public string Get()
        {
            var builder = new StringBuilder();
            builder.AppendLine(string.Join(", ", Tags.Select(tag => tag.Description.Get())));
            builder.AppendLine(string.Join(Environment.NewLine, Text));
            return builder.ToString();
        }
    }
}