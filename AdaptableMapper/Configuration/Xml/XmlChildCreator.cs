﻿using System.Xml.Linq;
using AdaptableMapper.Traversals;
using AdaptableMapper.Xml;

namespace AdaptableMapper.Configuration.Xml
{
    public sealed class XmlChildCreator : ChildCreator
    {
        public object CreateChild(Template template)
        {
            if (!(template.Parent is XElement xElement))
            {
                Process.ProcessObservable.GetInstance().Raise("XmlChildCreator#1; parent is not of expected type XElement", "error", template.Parent?.GetType().Name);
                return NullElement.Create();
            }

            if (!(template.Child is XElement xTemplate))
            {
                Process.ProcessObservable.GetInstance().Raise("XmlChildCreator#2; template is not of expected type XElement", "error", template.Child?.GetType().Name);
                return NullElement.Create();
            }

            var xTemplateCopy = new XElement(xTemplate);
            return xTemplateCopy;
        }

        public void AddToParent(Template template, object newChild)
        {
            if (!(template.Parent is XElement parent))
            {
                Process.ProcessObservable.GetInstance().Raise("XmlChildCreator#3; parent is not of expected type XElement", "error", template.Parent?.GetType().Name);
                return;
            }

            if (!(newChild is XElement xTemplate))
            {
                Process.ProcessObservable.GetInstance().Raise("XmlChildCreator#4; template is not of expected type XElement", "error", template.Child?.GetType().Name);
                return;
            }

            parent.Add(xTemplate);
        }
    }
}