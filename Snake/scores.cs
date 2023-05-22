using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class scores
    {
        private string name;
        private int pts;

        public scores(string name, int pts)
        {
            this.name = name;
            this.pts = pts;
        }
        
        public string getname()
        {
            return this.name;
        }

        public int getpts()
        {
            return this.pts;
        }
    }
}
