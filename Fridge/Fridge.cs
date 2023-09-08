using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Fridge
{
    internal class Fridge
    {
        private int numFrig;
        private int year;
        private string[] flavor;
        private int currentAmount;

        public Fridge(int numFrig, int year)
        {

            this.numFrig = numFrig;

            this.year = year;

            this.flavor = new string[25];

            this.currentAmount = 0;
        }
        public bool AddFlavor(string flavor)
        {
            if (this.currentAmount >= 25) return false;
            this.flavor[currentAmount] = flavor;
            currentAmount++;
            return true;
        }
        public string BestFlavor()
        {
            string best = "Error";
            int max = 0;
            int temp;
            for (int i = 0; i < currentAmount; i++)
            {
                temp = CountFalvors(flavor[i]);
                if (temp > max)
                {
                    max = temp;
                    best = flavor[i];
                }
            }
            return best;
        }
        private int CountFalvors(string f)
        {
            int c = 0;
            for (int i = 0; i < this.currentAmount; i++)
            {
                if (this.flavor[i] == f)
                    c++;
            }
            return c;
        }
    }
               
}
