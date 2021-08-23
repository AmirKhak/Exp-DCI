using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exp_DCI
{
    public abstract class Item
    {
        public abstract int Id { get; set; }

        public abstract string Title { get; set; }
    }
}
