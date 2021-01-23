﻿using System;
using System.IO;
using System.Xml.Linq;
using MappingFramework.ContentTypes;
using MappingFramework.Converters;
using MappingFramework.Xml;

namespace MappingFramework.Configuration.Xml
{
    [ContentType(ContentType.Xml)]
    public sealed class XmlTargetInstantiator : TargetInstantiator, ResolvableByTypeId
    {
        public const string _typeId = "137a2d0b-c49f-491b-b5b9-24413f9969ee";
        public string TypeId => _typeId;

        public XmlTargetInstantiator()
        {
            XmlInterpretation = XmlInterpretation.Default;
        }

        public XmlInterpretation XmlInterpretation { get; set; }

        public object Create(Context context, object source)
        {
            if (!(source is string template))
            {
                context.InvalidInput(source, typeof(string));
                return NullElement.Create();
            }

            XElement root;
            try
            {
                var stringReader = new StringReader(template);
                var document = XDocument.Load(stringReader);
                root = document.Root;
            }
            catch(Exception exception)
            {
                context.OperationFailed(this, exception);
                return NullElement.Create();
            }

            if (XmlInterpretation == XmlInterpretation.WithoutNamespace)
                root.RemoveAllNamespaces();

            return root;
        }
    }
}