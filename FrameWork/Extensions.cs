﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public static class Extensions
    {
        #region ICollection Methods

        public static void AddRange<T>(this ICollection<T> target, IEnumerable<T> source)
        {
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));                
            }
            foreach (var element in source)
            {
                target.Add(element);
            }
        }

        #endregion
    }
}
