using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp18
{
    class Students : Notify
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }

        private bool _checked;
        public bool Checked
        {
            get { return _checked; }
            set { _checked = value;
                if(StudentChackedChange != null)
                {
                    StudentChackedChange(this, new EventArgs());
                    NotifyPropertyChanged();
                }
            }
        }
        public event EventHandler StudentChackedChange;
    }
}
