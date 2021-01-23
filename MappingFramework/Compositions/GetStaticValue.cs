﻿using MappingFramework.Configuration;
using MappingFramework.Converters;
using MappingFramework.Traversals;
using MappingFramework.ValueMutations.Traversals;

namespace MappingFramework.Compositions
{
    public class GetStaticValue : GetValueTraversal, GetValueStringTraversal, ResolvableByTypeId
    {
        public const string _typeId = "136fe331-e3c2-496d-a7fc-e317b7eb80aa";
        public string TypeId => _typeId;

        public string Value { get; set; }

        public GetStaticValue() { }
        public GetStaticValue(string value)
            => Value = value;

        public string GetValue(Context context, string value)
        {
            return GetValue((Context)null);
        }

        public string GetValue(Context context)
        {
            if (string.IsNullOrWhiteSpace(Value))
                context.PropertyIsEmpty(this, nameof(Value));

            return Value;
        }
    }
}