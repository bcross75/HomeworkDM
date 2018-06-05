using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDM
{
    public abstract class Character
    {
        public abstract void Draw();

        public string Name { get; set; }
    }
}
