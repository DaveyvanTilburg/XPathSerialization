﻿using AdaptableMapper.Traversals;
using Newtonsoft.Json.Linq;

namespace AdaptableMapper.Json
{
    public sealed class JsonGetThisValue : GetValueTraversal
    {
        public string GetValue(object source)
        {
            if (!(source is JToken jToken))
            {
                Errors.ProcessObservable.GetInstance().Raise("JSON#9; Source is not of expected type JToken", "error", source?.GetType()?.Name);
                return string.Empty;
            }

            return jToken.Value<string>();
        }
    }
}