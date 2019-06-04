using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Model
    {
        private int state;

        public Model(int state)
        {
            this.state = state;
        }

        // Getter
        public int getState() 
        {
            return state;
        }

        //Setter
        public void setState(int state)
        {
            this.state = state;
        }
    }
}
