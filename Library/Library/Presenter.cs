using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Presenter
    {
        public event Action<int> ChangeLabel;

        private Model m;
        public Presenter(Form1 view)
        {
            // Это для слабой связи (презентер не содержит форму, но юзает её)
            ChangeLabel += view.changeLabel;
            m = new Model(0);

        }

        public void IncValue()
        {
            m.setState(m.getState() + 1);
            ChangeLabel.Invoke(m.getState());
        }

        public void Clear()
        {
            m.setState(0);
            ChangeLabel.Invoke(m.getState());
        }
    }

    
}
