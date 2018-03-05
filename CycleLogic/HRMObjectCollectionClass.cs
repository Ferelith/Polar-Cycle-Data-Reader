using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicForCycle
{
    public class HRMObjectCollectionClass
    {
        private List<HRMObjectClass> HRMObjects = new List<HRMObjectClass>();

        public HRMObjectClass getObject(int i)
        {
            return this.HRMObjects[i];
        }

        public void add(HRMObjectClass HRMObject)
        {
            this.HRMObjects.Add(HRMObject);
        }

        public void remove(HRMObjectClass HRMObject)
        {
            this.HRMObjects.Remove(HRMObject);
        }

        public int getCount()
        {
            return this.HRMObjects.Count;
        }

        public void clear()
        {
            this.HRMObjects.Clear();
        }
    }
}
