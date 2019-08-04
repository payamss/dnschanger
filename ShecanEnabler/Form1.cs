using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShecanEnabler
{
    public partial class DNSChanger : Form
    {
        public DNSChanger()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
           MessageBox.Show( GetDnsAdress().ToString());
            if (GetDnsAdress().ToString()=="8.8.8.8")
            {
                rdGoogle.Checked = true;
                rdDefault.Checked = false;
                rdShecan1.Checked = false;

            }
        }
        private static IPAddress GetDnsAdress()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                if (networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();
                    IPAddressCollection dnsAddresses = ipProperties.DnsAddresses;

                    foreach (IPAddress dnsAdress in dnsAddresses)
                    {
                        return dnsAdress;
                    }
                }
            }
            throw new InvalidOperationException("Unable to find DNS Address");
        }

        private void DNSChanger_Load(object sender, EventArgs e)
        {
            if (GetDnsAdress().ToString() == "8.8.8.8")
            {
                rdGoogle.Checked = true;
                rdDefault.Checked = false;
                rdOpenDNS.Checked = false;
                rdShecan1.Checked = false;
                rdShecan2.Checked = false;
            }
            else if (GetDnsAdress().ToString() == "178.22.122.100" )
            {
                rdGoogle.Checked = false;
                rdDefault.Checked = false;
                rdOpenDNS.Checked = false;
                rdShecan1.Checked = true;
                rdShecan2.Checked = false;
            }
            else if (GetDnsAdress().ToString() == "185.51.200.2")
            {
                rdGoogle.Checked = false;
                rdDefault.Checked = false;
                rdOpenDNS.Checked = false;
                rdShecan1.Checked = false;
                rdShecan2.Checked = true;
            }
            else if (GetDnsAdress().ToString() == "4.2.2.4" )
            {
                rdGoogle.Checked = false;
                rdDefault.Checked = false;
                rdOpenDNS.Checked = true;
                rdShecan1.Checked = false;
                rdShecan2.Checked = false;
            }
            else if (GetDnsAdress().ToString() == "")
            {
                rdGoogle.Checked = false;
                rdDefault.Checked = true;
                rdOpenDNS.Checked = false;
                rdShecan1.Checked = false;
                rdShecan2.Checked = false;
            }
        }

        private void rdDefault_CheckedChanged(object sender, EventArgs e)
        {
            NetworkManagement nm = new NetworkManagement();
            nm.setDNS(" ");
        }

        private void rdGoogle_CheckedChanged(object sender, EventArgs e)
        {
            NetworkManagement nm = new NetworkManagement();
            nm.setDNS(txtGoogle.Text);
        }


        private void rdOpenDNS_CheckedChanged(object sender, EventArgs e)
        {
            NetworkManagement nm = new NetworkManagement();
            nm.setDNS(txtOpen.Text);
        }

        private void rdShecan1_CheckedChanged(object sender, EventArgs e)
        {
            NetworkManagement nm = new NetworkManagement();
            nm.setDNS(txtShecanDNS1.Text);
        }

        private void rdShecan2_CheckedChanged(object sender, EventArgs e)
        {
            NetworkManagement nm = new NetworkManagement();
            nm.setDNS(txtShecanDNS2.Text);
        }
    }
}

