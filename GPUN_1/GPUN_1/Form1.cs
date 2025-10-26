using System;
using System.IO.Ports;
using Modbus.Device;   // Nếu bạn dùng Modbus RTU để nói chuyện với PLC

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPUN_1
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        ModbusSerialMaster modbusMaster;
        PLCController plc = new PLCController();

        bool isConnected = false;   // trạng thái kết nối PLC

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainForm.Visible = true;
            panelCONNECT.Visible = false;
            panelCONTROL.Visible = false;


            cbPort.Items.AddRange(SerialPort.GetPortNames()); // liệt kê COM

            cbBaudrate.Items.AddRange(new string[] { "9600", "19200", "38400", "115200" });
            cbBaudrate.SelectedIndex = 0;

            lblStatus.Text = "TRẠNG THÁI: CHƯA KẾT NỐI";
            lblStatus.BackColor = Color.Red;

            btnCONTROL.Enabled = false;   // ban đầu tắt nút CONTROL
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string portName = cbPort.Text;      // combobox chọn cổng COM
                string baudrateText = cbBaudrate.Text; // combobox chọn baudrate
                int baudrate;
                

                if (string.IsNullOrEmpty(portName))
                {
                    MessageBox.Show("Vui lòng chọn cổng COM!");
                    return;
                }

                if (!int.TryParse(baudrateText, out baudrate))
                {
                    MessageBox.Show("Vui lòng chọn đúng Baudrate!");
                    return;
                }
                //// Mở cổng serial
                //serialPort = new SerialPort(portName, baudrate, Parity.None, 8, StopBits.One);
                //serialPort.Open();

                //// Tạo master Modbus RTU
                //modbusMaster = ModbusSerialMaster.CreateRtu(serialPort);

                plc.Connect(portName, baudrate);

                lblStatus.Text = "TRẠNG THÁI: ĐÃ KẾT NỐI";
                lblStatus.BackColor = Color.LimeGreen;
                lblStatus.ForeColor = Color.Black;

                MessageBox.Show("Kết nối thành công với PLC!");

                isConnected = true;
                btnCONTROL.Enabled = true;   // bật nút CONTROL

            }
            catch (Exception ex)
            {
                lblStatus.Text = "TRẠNG THÁI: LỖI KẾT NỐI";
                lblStatus.BackColor = Color.Red;
                lblStatus.ForeColor = Color.White;

                MessageBox.Show("Không thể kết nối: " + ex.Message);
                isConnected = false;
                btnCONTROL.Enabled = false;  // tắt nút CONTROL khi lỗi

            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cập nhật danh sách cổng COM khi người dùng mở combobox
            cbPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cbPort.Items.AddRange(ports);
        }
        private void cbBaudrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //// Cập nhật danh sách baudrate khi người dùng mở combobox
            //cbBaudrate.Items.Clear();
            //int[] baudrates = new int[] { 9600, 19200, 38400, 57600, 115200 };
            //foreach (var rate in baudrates)
            //{
            //    cbBaudrate.Items.Add(rate.ToString());
            //}
            if (cbBaudrate.SelectedItem != null)
            {
                string selectedBaud = cbBaudrate.SelectedItem.ToString();
                Console.WriteLine("Baudrate đã chọn: " + selectedBaud);
                // hoặc lưu lại để dùng khi kết nối
                // selectedBaudrate = int.Parse(selectedBaud);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.Close();
                    lblStatus.Text = "TRẠNG THÁI: CHƯA KẾT NỐI";
                    lblStatus.BackColor = Color.Red;
                    lblStatus.ForeColor = Color.White;

                    isConnected = false;
                    btnCONTROL.Enabled = false;  // vô hiệu hóa nút CONTROL khi ngắt kết nối
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show("Lỗi khi ngắt kết nối: " + ex.Message);
            }
        }

        private void btnUSER_Click(object sender, EventArgs e)
        {
            MainForm.Visible = true;
            panelCONNECT.Visible = false;
            panelCONTROL.Visible = false;
        }

        private void btnCONNECT2_Click(object sender, EventArgs e)
        {
            MainForm.Visible = false;
            panelCONNECT.Visible = true;
            panelCONTROL.Visible = false;
        }

        private void btnCONTROL_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Vui lòng kết nối PLC trước khi điều khiển!");
                return;
            }

            MainForm.Visible = false;
            panelCONNECT.Visible = false;
            panelCONTROL.Visible = true;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void panelCONTROL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BUT_3_Click(object sender, EventArgs e)
        {
            try
            {
                ushort[] values = plc.ReadHoldingRegisters(1, 0, 1);
                lblState.Text = "Giá trị đọc được: " + values[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BUT_2_Click(object sender, EventArgs e)
        {
            try
            {
                plc.WriteCoil(1, 0, false);  // tắt coil 0
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BUT_1_Click(object sender, EventArgs e)
        {
            try
            {
                plc.WriteCoil(1, 0, true);  // bật coil 0 của slave 1
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void panelCONNECT_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
    
