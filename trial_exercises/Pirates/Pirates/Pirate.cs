using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    public class Pirate
    {
        protected string _name;
        protected int _goldAmount;
        protected int _healthPoints;
        protected bool _hasWoodenLeg;

        public Pirate(string name)
        {
            var random = new Random();

            _name = name;
            _goldAmount = 0;
            _healthPoints = 20;
            _hasWoodenLeg = random.Next(1, 11) < 6;
        }

        public int GetGoldAmount()
        {
            return _goldAmount;
        }

        public string GetName()
        {
            return _name;
        }

        public bool IsPoor()
        {
            return _hasWoodenLeg && _goldAmount < 15;
        }

        public override string ToString()
        {
            return _hasWoodenLeg ? 
                $"Hello, I'm {_name}. I have a wooden leg and {_goldAmount} amount of gold."
                : 
                $"Hello, I'm {_name}. I still have my real legs and {_goldAmount} amount of gold.";
        }

        public virtual void Work()
        {
            _goldAmount += 1;
            if (_healthPoints > 0)
            {
                _healthPoints -= 1;
            }
        }

        public virtual void Party()
        {
            _healthPoints += 1;
        }
    }
}
