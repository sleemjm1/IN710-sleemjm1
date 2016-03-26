using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMedia
{
    public partial class Form1 : Form
    {
        SMSubject smSubject;
        UserObserver mainUser;
        FriendObserver friend1;
        FriendObserver friend2;
        FriendObserver friend3;
        FriendObserver friend4;

        public Form1()
        {
            InitializeComponent();
            smSubject = new SMSubject();
            mainUser = new UserObserver(listMainPage, smSubject);
            friend1 = new FriendObserver(listFriend1, smSubject);
            friend2 = new FriendObserver(listFriend2, smSubject);
            friend3 = new FriendObserver(listFriend3, smSubject);
            friend4 = new FriendObserver(listFriend4, smSubject);
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            smSubject.TriggerNotifications(tbStatusUpdate);
        }
    }
}
