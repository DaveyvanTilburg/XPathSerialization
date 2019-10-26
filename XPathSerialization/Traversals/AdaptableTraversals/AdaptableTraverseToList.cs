﻿using System.Collections;
using XPathSerialization.XPathConfigurations;

namespace XPathSerialization.Traversals.AdaptableTraversals
{
    public class AdaptableTraverseToList : Traversal
    {
        public string Path { get; set; }

        public object Traverse(object target)
        {
            if (!(target is Adaptable adaptable))
            {
                Errors.ErrorObservable.GetInstance().Raise("Object is not of expected type Adaptable");
                return string.Empty;
            }

            var adaptablePathContainer = AdaptablePathContainer.CreateAdaptablePath(Path);

            Adaptable pathTarget = adaptable.GetOrCreateAdaptable(adaptablePathContainer.CreatePathQueue());
            IList adaptableScope = pathTarget.GetListProperty(adaptablePathContainer.PropertyName);

            return adaptableScope;
        }
    }
}