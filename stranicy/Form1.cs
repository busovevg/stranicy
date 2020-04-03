using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace stranicy
{
    public partial class Form1 : Form
            {
        private Plc plc = null;
        List<Panel> listPanel = new List<Panel>();
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void PreviousPage_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel[index].BringToFront();
            CpuTypeCB.DataSource = Enum.GetNames(typeof(CpuType));
        }
        private void ConnectBt_Click(object sender, EventArgs e)
        {

            CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), CpuTypeCB.SelectedValue.ToString());

            plc = new Plc(cpu, IPaddressTB.Text, Convert.ToInt16(RackTB.Text), Convert.ToInt16(SlotTB.Text));
            plc.Open();

            if (plc.IsConnected)
            {

                StatusConnTB.Text = "Connected";
            }
        }


        private void DisconnectBt_Click(object sender, EventArgs e)
        {

            plc.Close();
            StatusConnTB.Text = "Disconnected";


        }

        private void ReadDataBt_Click(object sender, EventArgs e)
        {

            string address = DbAddressTB.Text;
            object result = plc.Read(address);
            ReadDataTB.Text = string.Format("{0}", result.ToString());
        }

        private void WriteBt_Click(object sender, EventArgs e)
        {
            string address = DbAddressTB.Text;
            object setpoint = Convert.ToInt16(WriteDataTB.Text);
            plc.Write(address, setpoint);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
