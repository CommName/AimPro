using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMProClient.AIMProService;

namespace AIMProClient
{
    public partial class MenuForm : Form
    {
        AIMProServerServiceClient proxy;
        public MenuForm(AIMProServerServiceClient proxy)
        {
            this.proxy = proxy;
            InitializeComponent();
        }
    }
}
