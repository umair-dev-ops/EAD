using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_Project0.Client.Services
{
    public class CounterStateService
    {
        private int Count;

        public event Action OnChange;
        public int CounterCount
        {
            get { return Count; }
            set {
                
                Count = value;
                NotifyChange();
            }
        }
        private void NotifyChange() => OnChange?.Invoke();
    }
}
