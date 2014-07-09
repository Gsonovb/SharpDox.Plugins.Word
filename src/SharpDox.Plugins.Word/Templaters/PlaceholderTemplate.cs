﻿using SharpDox.Plugins.Word.OpenXml;
using System.Collections.Generic;

namespace SharpDox.Plugins.Word.Templaters
{
    internal class PlaceholderTemplate : BaseTemplate
    {
        private readonly string _title;

        public PlaceholderTemplate(string title, string outputPath) : base(outputPath, Templates.Placeholder)
        {
            _title = title;
        }

        public override void CreateDocument()
        {
            var data = new List<FieldData>();
            data.Add(new FieldData("Title", _title));
            _templater.ReplaceBookmarks(data);
        }
    }
}