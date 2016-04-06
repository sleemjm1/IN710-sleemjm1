using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlHandlers
{
    public class CustomObserver
    {
        protected Button button;    // We are observing a button this time, so no need for subject class
        protected int ID;           // This ID is passed in on creation 

        public CustomObserver(int ID, Button button)
        {
            this.ID = ID;
            this.button = button;

            EventHandler handler = new EventHandler(CustomHandlerMethod);   // Make event handler delegate

            button.Click += handler;    // The event we will trigger on is "Click" event
        }

        public void CustomHandlerMethod(object sender, EventArgs e)
        {
            string intro = "This is a custom handler.\n\n";
            string codeNumber = "My code number is " + ID + "\n\n";
            string type = "My type is " + this.GetType().ToString() + "\n\n";
            string name = "I am responding to: " + button.Name;

            MessageBox.Show(intro + codeNumber + type + name);
        }
    }
}
