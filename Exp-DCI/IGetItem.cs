using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exp_DCI
{
    public interface IGetItem
    {
        public List<Item> GetItems(string url, int Id);
    }
}
