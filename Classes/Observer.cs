using SCD_LAB_W14.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCD_LAB_W14.Classes
{
    public class Observer : INewsObserver
    {
        public string UserName { get; set; }
        public Observer(string userName, INewsSubject subject)
        {
            UserName = userName;
            subject.RegisterObserver(this);
        }

        public void update(string newstype)
        {
            MessageBox.Show("Hello " + UserName + ", News Related to " + newstype + " Has Arrived");
        }
    }
}
