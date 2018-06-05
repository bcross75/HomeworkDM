using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDM
{
    class Villain : Character
    {
        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public Status Status { get; set; }
    }

    public enum Status
    {
        Incarcerated = 1,
        AtLarge = 2,
        Unknown = 3
    }
}
