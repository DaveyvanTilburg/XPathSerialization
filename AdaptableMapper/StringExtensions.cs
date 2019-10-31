﻿using System.Collections.Generic;

namespace AdaptableMapper
{
    public static class StringExtensions
    {
        public static Stack<string> ToStack(this string value)
        {
            return new Stack<string>(value.Split('/'));
        }

        public static Queue<string> ToQueue(this string value)
        {
            return new Queue<string>(value.Split('/'));
        }
    }
}