using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGame
{

    class Stats
    {
        public int total = 0;
        public int missed = 0;
        public int correct = 0;
        public int accuracy = 0;

        public void Update(bool corredyKey)
        {
            total++;
            if (!corredyKey) {
                missed++;
            }
            else
            {
                correct++;
            }
            accuracy = 100 * correct / total;
        }
    }
}
