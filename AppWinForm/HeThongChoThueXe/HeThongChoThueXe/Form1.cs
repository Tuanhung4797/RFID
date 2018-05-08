using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;
using System.IO;
using System.Xml;


namespace HeThongChoThueXe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ComList = SerialPort.GetPortNames();

            int[] ComNumberList = new int[ComList.Length];
            for (int i = 0; i < ComList.Length; i++)
            {
                ComNumberList[i] = int.Parse(ComList[i].Substring(3));
            }

            Array.Sort(ComNumberList);
            foreach (int ComNumber in ComNumberList)
            {
                cbxComList.Items.Add("COM" + ComNumber.ToString());
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxComList.Text == "")
            {
                MessageBox.Show("Vui lòng chọn cổng COM", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (serialPort.IsOpen)
            {
                serialPort.Close();
                button1.Text = "Kết nối";
                cbxComList.Enabled = true;
            }
            else
            {
                try
                {
                    serialPort.PortName = cbxComList.Text;
                    serialPort.Open();
                    button1.Text = "Ngắt kết nối";
                    cbxComList.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể mở cổng " + serialPort.PortName, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        
        Action<string> serialPortReceivedAction;

        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {

            serialPortReceivedAction = serialPortReceiver;
            try
            {
                this.BeginInvoke(serialPortReceivedAction, serialPort.ReadLine());
            }
            catch { }

        }
        private void serialPortReceiver(string input)
        {
            string x1m = "X1M";
            string x1t = "X1T";
            string x2m = "X2M";
            string x2t = "X2T";
            string dataInput = input.Remove(3);
            if (string.Compare(dataInput, x1m, true) == 0)
            {
                tt1.Text = "Đã cho thuê";
                DateTime tg = DateTime.Now;
                time1m.Text = tg.ToString("HH:mm:ss");
                time1t.Text = "..........";
                count1 = 1;
                timer1.Start();
                t1.Text = "0";
                string gioX1M = tg.ToString("HH");
                string phutX1M = tg.ToString("mm");
                string muonX1 = "borrowX1 ";
                string space = " ";
                string end = ";";
                string tgMx1 = tg.ToString("HH:mm:ss");
                string sendData1 = String.Concat(muonX1,"H",gioX1M,space,"M",phutX1M,end);
                serialPort.Write(sendData1);
                MessageBox.Show(sendData1.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.Compare(dataInput, x1t, true) == 0)
            {
                tt1.Text = "Đã trả, đang tại bến";
                DateTime tg = DateTime.Now;
                time1t.Text = tg.ToString("HH:mm:ss");
                timer1.Stop();
                int tienx1 = count1 * 10000;
                t1.Text = tienx1.ToString();
                string gioX1T = tg.ToString("HH");
                string phutX1T = tg.ToString("mm");
                string space = " ";
                string tien1 = (tienx1 / 1000).ToString();
                string traxe1 = "payX1 ";
                string end = ";";
                string sendData2 = String.Concat(traxe1,"H", gioX1T,space, "M", phutX1T, space, "A", tien1, end);
                serialPort.Write(sendData2.ToString());
                MessageBox.Show(sendData2.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.Compare(dataInput, x2m, true) == 0)
            {
                tt2.Text = "Đã cho thuê";
                DateTime tg = DateTime.Now;
                time2m.Text = tg.ToString("HH:mm:ss");
                time2t.Text = "..........";
                count2 = 1;
                timer2.Start();
                t2.Text = "0";
                string gioX2M = tg.ToString("HH");
                string phutX2M = tg.ToString("mm");
                string muonX2 = "borrowX2 ";
                string space = " ";
                string end = ";";
                string tgMx2 = tg.ToString("HH:mm:ss");
                string sendData3 = String.Concat(muonX2, "H", gioX2M, space, "M", phutX2M, end);
                serialPort.Write(sendData3);
                MessageBox.Show(sendData3.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.Compare(dataInput, x2t, true) == 0)
            {
                tt2.Text = "Đã trả, đang tại bến";
                DateTime tg = DateTime.Now;
                time2t.Text = tg.ToString("HH:mm:ss");
                timer2.Stop();
                int tienx2 = count2 * 10000;
                t2.Text = tienx2.ToString();
                string gioX2T = tg.ToString("HH");
                string phutX2T = tg.ToString("mm");
                string space = " ";
                string tien2 = (tienx2 / 1000).ToString();
                string traxe2 = "payX2 ";
                string end = ";";
                string sendData4 = String.Concat(traxe2, "H", gioX2T, space, "M", phutX2T, space, "B", tien2, end);
                serialPort.Write(sendData4.ToString());
                MessageBox.Show(sendData4.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int count1 = 1;
        int count2 = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count1++;
        }

        
        private void timer2_Tick(object sender, EventArgs e)
        {
            count2++;
        }
 

    }
}
