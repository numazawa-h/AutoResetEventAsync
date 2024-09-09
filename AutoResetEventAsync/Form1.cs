using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoResetEventAsync
{
    public partial class Form1 : Form
    {
        int no = 0;
        AutoResetEventAsync _event = new AutoResetEventAsync();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            _event.Set();
        }

        private async void btn_Await_Click(object sender, EventArgs e)
        {
            int n = ++no;
            if(await _event.Wait())
            {
                this.textBox1.Text = $"Fire{n}";
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            _event.Reset(chk_InitSet.Checked, chk_KeepOrder.Checked);
            no = 0;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            _event.Cancel();
        }
    }
}
