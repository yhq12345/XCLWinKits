using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonHelper.Model.CategoryConfig
{
    public class Category
    {
        public string Name { get; set; }
        public int Sort { get; set; }
        public List<CategoryItem> CategoryItemList { get; set; }
    }
}
