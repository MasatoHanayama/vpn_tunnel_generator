using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vpn_tunnel_generator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            VpnTunnel vpnTunnel = new VpnTunnel(this.tunnel_name.Text, this.server_address.Text, this.pre_shared_key.Text, this.nat_chk.Checked);

            // for debug
            //MessageBox.Show("下記の設定を登録します。\r\n続行しますか？\r\n" + vpnTunnel.Name() + "\r\n" + vpnTunnel.Address() + "\r\n" + vpnTunnel.PreSharedKey() + "\r\n" + vpnTunnel.NatTraversal().ToString(), "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            //using (var invoker = new RunspaceInvoke())
            //{

            //}

                MessageBox.Show("設定を完了しました！", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void recordUser_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (this.recordUser_chk.Checked)
            {
                this.user_name.Enabled = true;
                this.user_password.Enabled = true;
            }
            else
            {
                this.user_name.Enabled = false;
                this.user_password.Enabled = false;
            }
        }
    }

    public class VpnTunnel
    {
        private String name;
        private String address;
        private String preSharedKey;
        private bool natTraversal;
        
        public String Name()
        {
            return this.name;
        }
        public String Address()
        {
            return this.address;
        }

        public String PreSharedKey()
        {
            return this.preSharedKey;
        }

        public bool NatTraversal()
        {
            return this.natTraversal;
        }

        public VpnTunnel(String name, String address, String preSharedKey, bool natTraversal)
        {
            this.name = name;
            this.address = address;
            this.preSharedKey = preSharedKey;
            this.natTraversal = natTraversal;
        }
    }
}
