using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feudal.GameForms
{
    public partial class CreatePlayersForm : Form
    {
        public List<string> PlayerNames { get; private set; }

        public CreatePlayersForm()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            string tmp = NamesTextBox.Text.Replace("\r", "");
            PlayerNames = new List<string>(tmp.Split('\n'));

            if (PlayerNames == null) throw new InvalidOperationException("PlayerNames came back null!");

            Close();
        }
    }
}
