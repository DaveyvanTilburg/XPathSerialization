﻿using AdaptableMapper.Traversals;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AdaptableMapper.Xml
{
    public sealed class XmlGetScope : GetScopeTraversal
    {
        public XmlGetScope(string path)
        {
            Path = path;
        }

        public string Path { get; set; }

        public IEnumerable<object> GetScope(object source)
        {
            if (!(source is XElement xElement))
            {
                Errors.ErrorObservable.GetInstance().Raise("XML#12; source is not of expected type XElement", Path, source);
                return new List<XElement>();
            }

            IEnumerable<XElement> xScope = xElement.NavigateToPathSelectAll(Path);
            return xScope;
        }
    }
}