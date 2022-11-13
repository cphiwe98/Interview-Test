using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTest.Controllers
{
    public class Hero: IHero
    {
        public string name { get; set; }
        public string power { get; set; }
        public List<KeyValuePair<string, int>> stats {get;set;}
        public void evolve(int statIncrease = 5)
        {
            foreach(var i in stats)
            {               
                var newEntry = new KeyValuePair<string, int>(i.Key, i.Value + statIncrease);
                stats.Add(newEntry);
            }

            
        }
    }

    interface IHero
    {
        void evolve(int value);
    }
}
