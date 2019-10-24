using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUI
{

    public class TournamentStatus
    {
        private bool isCreated;

        public bool IsCreated()
        {
            return isCreated;
        }

        public void Created(bool value)
        {
            isCreated = value;
        }

        public TournamentStatus(bool value) { this.Created(value); }
    }
}
