using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordWalmart
{
    public class AddServerForm : Form
    {
        public static Label messageLabel1;
        private HeaderPanel header;
        public AddServerForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            header = new HeaderPanel(this);

            messageLabel1 = new Label();
            messageLabel1.Enabled = false;

            this.Controls.Add(messageLabel1);

            this.Resize += FormStart_Resize;
            this.Activated += AddServerForm_Activated;
        }

        private void AddServerForm_Activated(object sender, EventArgs e)
        {
            
        }

        private void FormStart_Resize(object sender, EventArgs e)
        {
            header.Width = this.Width;
        }
    }
}
