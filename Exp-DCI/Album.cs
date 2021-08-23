using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exp_DCI
{
    public class Album : Item
    {
        public override int Id { get; set; }

        public override string Title { get; set; }

        public int UserId { get; set; }
    }
}
