using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace Porty
{
    public partial class Form1 : Form
    {
        string dataOUT;
        string dataIN;
        string X;
        string Y;
        string Z;
        string Parameter;
        string Command;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBOXCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParity.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
                if (serialPort1.IsOpen)
                {
                    dataOUT = "WH";

                    serialPort1.Write(dataOUT + "\r");

                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBOXCOMPORT.Items.AddRange(ports);
            chBoxDTR.Checked = false;
            serialPort1.DtrEnable = false;
            chBoxRTS.Checked = false;
            serialPort1.RtsEnable = false;
            chBoxOldData.Checked = true;
            chBoxUpdate.Checked = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;

            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;

                serialPort1.Write(dataOUT + "\r");

            }
        }

        private void chBoxDTR_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxDTR.Checked)
            {
                serialPort1.DtrEnable = true;

            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void chBoxRTS_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxRTS.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else
            {
                serialPort1.RtsEnable = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tBoxDataOut.Text != "")
            {
                tBoxDataOut.Text = "";
            }
        }


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }


        private void ShowData(object sender, EventArgs e)
        {

            if (chBoxUpdate.Checked)
            {
                tBoxDataIN.Text = dataIN;
            }
            else if (chBoxOldData.Checked)
            {
                tBoxDataIN.Text += dataIN;
            }
        }

       
        private void btnClearDataIN_Click(object sender, EventArgs e)
        {
            if (tBoxDataIN.Text != "")
            {
                tBoxDataIN.Text = "";
            }
        }

        private void chBoxUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxUpdate.Checked)
            {
                chBoxUpdate.Checked = true;
                chBoxOldData.Checked = false;
            }
            else
            {
                chBoxOldData.Checked = true;
            }
        }

        private void chBoxOldData_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxOldData.Checked)
            {
                chBoxUpdate.Checked = false;
                chBoxOldData.Checked = true;
            }
            else
            {
                chBoxUpdate.Checked = true;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBOXCOMPORT.Items.AddRange(ports);
            chBoxDTR.Checked = false;
            serialPort1.DtrEnable = false;
            chBoxRTS.Checked = false;
            serialPort1.RtsEnable = false;
            chBoxOldData.Checked = true;
            chBoxUpdate.Checked = false;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBOXCOMPORT.Items.AddRange(ports);
        }


        private void Jogspeed_Scroll(object sender, EventArgs e)
        {
            tbjspeed.Text = "" + Jogspeed.Value;


           
        }

        private void btnLeftR_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
               serialPort1.Write("DJ 6," + Jogspeed.Value + "\r");

            }
        }

        private void btnRightR_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("DJ 6,-" + Jogspeed.Value + "\r");

            }
        }

        private void btnLeftP_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("DJ 5," + Jogspeed.Value + "\r");

            }
        }

        private void btnRightP_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("DJ 5,-" + Jogspeed.Value + "\r");

            }
        }

        private void btnLeftT_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("DJ 4," + Jogspeed.Value + "\r");

            }
        }

        private void btnRightT_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("DJ 4,-" + Jogspeed.Value + "\r");

            }
        }

        private void btnLeftE_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("DJ 3," + Jogspeed.Value + "\r"); ;

            }
        }

        private void btnRightE_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("DJ 3,-" + Jogspeed.Value + "\r");

            }
        }

        private void btnLeftS_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("DJ 2," + Jogspeed.Value + "\r");

            }
        }

        private void btnRightS_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("DJ 2,-" + Jogspeed.Value + "\r");

            }
        }

        private void btnLeftW_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("DJ 1," + Jogspeed.Value + "\r");

            }
        }

        private void btnRightW_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("DJ 1,-" + Jogspeed.Value + "\r");

            }
        }
        
        private void btnOH_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("GO\r");

            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("GC\r");

            }

        }

        private void tBoxDataIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("WH\r");

            }
        }



        private void btnStraight_Click(object sender, EventArgs e)
        {
            X = tBoxX.Text;
            Y = tBoxY.Text;
            Z = tBoxZ.Text;
            serialPort1.Write("DS " + (X) + "," + (Y) + "," + (Z) + "\r");
        }

        private void btnDRAW_Click(object sender, EventArgs e)
        {
            X = tBoxX.Text;
            Y = tBoxY.Text;
            Z = tBoxZ.Text;
            serialPort1.Write("DW " + (X) + "," + (Y) + "," + (Z) + "\r");
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            Parameter = textBox1.Text;
            Command = comboBox1.Text; 
            
            serialPort1.Write( Command  +  Parameter + "\r");
        }




        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void cBOXCOMPORT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
  }
