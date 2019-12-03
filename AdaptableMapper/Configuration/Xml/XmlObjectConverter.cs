﻿using System;
using System.IO;
using System.Xml.Linq;
using AdaptableMapper.Xml;

namespace AdaptableMapper.Configuration.Xml
{
    public sealed class XmlObjectConverter : ObjectConverter
    {
        public XmlInterpretation XmlInterpretation { get; set; }

        public XmlObjectConverter()
        {
            XmlInterpretation = XmlInterpretation.Default;
        }

        public object Convert(object source)
        {
            if (!(source is string input))
            {
                Process.ProcessObservable.GetInstance().Raise("XML#18; source is not of expected type String", "error", source?.GetType().Name);
                return NullElement.Create();
            }

            XElement root;
            try
            {
                var stringReader = new StringReader(input);
                var document = XDocument.Load(stringReader);
                root = document.Root;
            }
            catch(Exception exception)
            {
                Process.ProcessObservable.GetInstance().Raise("XML#19; input could not be parsed to XElement", "error", input, exception.GetType().Name, exception.Message);
                root = NullElement.Create();
            }

            if(XmlInterpretation == XmlInterpretation.WithoutNamespace)
                root.RemoveAllNamespaces();

            return root;
        }
    }
}