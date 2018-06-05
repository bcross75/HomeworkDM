using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDM
{
    class Hero : Character
    {
        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public Duty Duty { get; set; } 
    }

    public enum Duty
    {
        Idle = 1,
        OnMission = 2,
        TopSecret = 3
    }
}
