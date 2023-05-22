using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class scoreset
    {
        private List<scores> scorelist;
        public scoreset()
        {
            this.scorelist = new List<scores>();
        }

        public int getSize()
        {
            return scorelist.Count;
        }

       public scores GetScores(int index)
        {
            return scorelist[index];
        }

        public void addscore(scores i)
        {
            scorelist.Add(i);
        }

        public void insertscore(int index , scores i)
        {
            scorelist.Insert(index , i);
        }


    }
}
