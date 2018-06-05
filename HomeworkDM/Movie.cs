using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDM
{
    class Movie
    {
        public Character[] Characters { get; set; }

        public Movie()
        {
            Characters = new Character[]
            {
                new Hero {Duty = Duty.Idle, Name = "Lucy"},
                new Villain {Name = "Vector", Status = Status.AtLarge},
                new Minion {Eyes = 1, Name = "Fred"},
                new Kid {Accessory = "Fluffy Unicorn", Name = "Agnes"}

            };
        }
    }
}
