﻿using AdaptableMapper.Traversals;
using System.Linq;
using System.Xml.Linq;

namespace AdaptableMapper.Xml
{
    public sealed class XmlGetSearch : GetTraversal
    {
        public XmlGetSearch(string path, string searchPath)
        {
            Path = path;
            SearchPath = searchPath;
        }

        public string Path { get; set; }
        public string SearchPath { get; set; }

        public string GetValue(object source)
        {
            if (!(source is XElement xElement))
            {
                Errors.ErrorObservable.GetInstance().Raise("Object is not of expected type XElement");
                return string.Empty;
            }

            string searchValue = null;
            if (!string.IsNullOrWhiteSpace(SearchPath))
                searchValue = xElement.GetXPathValues(SearchPath).First();

            string actualXPath = string.IsNullOrWhiteSpace(searchValue) ? Path : Path.Replace("{{searchResult}}", searchValue);
            string value = xElement.GetXPathValues(actualXPath).First();

            return value;
        }
    }
}