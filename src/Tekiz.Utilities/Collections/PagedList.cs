﻿using System.Collections.Generic;

namespace Tekiz.Utilities.Collections
{
    public class PagedList<T> : IPagedList<T>
    {
        public PagedList()
        {
            Items = new List<T>();
        }

        public int TotalCount { get; set; }

        public IList<T> Items { get; set; }
    }
}