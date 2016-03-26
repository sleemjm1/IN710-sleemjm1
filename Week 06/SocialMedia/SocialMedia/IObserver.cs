using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    public interface IObserver
    {
        void Update(string statusUpdate);
        void Display();
    }
}
