using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    public class Captain : Pirate
    {
        public Captain(string name) : base(name)
        {
        }

        public override void Work()
        {
            _goldAmount += 4;
            if (_healthPoints > 3)
            {
                _healthPoints -= 3;
            }
        }

        public override void Party()
        {
            _healthPoints += 5;
        }
    }
}
