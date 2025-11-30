using Modbus.Device;   // Nếu bạn dùng Modbus RTU để nói chuyện với PLC
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace GPUN_1
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        ModbusSerialMaster modbusMaster;
        //ushort startAddress = 0;
        //PLCController plc = new PLCController();
       


        bool isConnected = false;   // trạng thái kết nối PLC

        string portName;
        int baudrate;
        Parity parity;
        StopBits stopBits;
        int dataBits;
        byte slaveID;
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

            cb_Pick_Parity.Items.AddRange(new string[] { "None", "Odd", "Even" });
            cb_Pick_Parity.SelectedIndex = 0;

            cb_Pick_DataBits.Items.AddRange(new string[] { "7", "8" });
            cb_Pick_DataBits.SelectedIndex = 1; // Mặc định chọn 8 bits

            cb_Pick_StopBits.Items.AddRange(new string[] { "1", "2" });
            cb_Pick_StopBits.SelectedIndex = 0; // Mặc định chọn 1 stop bit


            cb_Pick_Slave.Items.AddRange(new string[] { "1", "2", "3" });
            cb_Pick_Slave.SelectedIndex = 0; // Mặc định chọn 1 cho SlaveID

            lblStatus.Text = "TRẠNG THÁI: CHƯA KẾT NỐI";
            lblStatus.BackColor = Color.Red;



            btnCONTROL.Enabled = false;   // ban đầu tắt nút CONTROL

        }

        public (string portName, int baudrate, byte slaveID, Parity parity, StopBits stopBits, int dataBits) __setup()
        {
            string portName = cbPort.Text;      // combobox chọn cổng COM
            int baudrate  = int.Parse(cbBaudrate.Text); // combobox chọn baudrate
            string slaveIDText = cb_Pick_Slave.Text; // combobox chọn slave ID
          
            Parity parity = (Parity)Enum.Parse(typeof(Parity), cb_Pick_Parity.SelectedItem.ToString());
            StopBits stopBits = (StopBits)Enum.Parse(typeof(StopBits), cb_Pick_StopBits.SelectedItem.ToString());
            int dataBits = int.Parse(cb_Pick_DataBits.SelectedItem.ToString());
            byte slaveID = byte.Parse(cb_Pick_Slave.SelectedItem.ToString());
            return (portName, baudrate, slaveID, parity, stopBits, dataBits);
        }




        private async void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                var setup = __setup();

                if (string.IsNullOrEmpty(setup.portName))
                {
                    MessageBox.Show("Vui lòng chọn cổng COM!");
                    return;
                }


                // 1. Khởi tạo SerialPort
                serialPort = new SerialPort(setup.portName, setup.baudrate, setup.parity, setup.dataBits, setup.stopBits);
                serialPort.ReadTimeout = 500;
                serialPort.WriteTimeout = 500;

                // 2. Mở kết nối serial
                serialPort.Open();

                // 3. Tạo Modbus master
                modbusMaster = ModbusSerialMaster.CreateRtu(serialPort);

                

                // 4. Kiểm tra kết nối Modbus
                lblStatus.Text = "TRẠNG THÁI: ĐANG KIỂM TRA KẾT NỐI...";
                bool modbusConnected = await TestModbusConnection(setup.slaveID);

                if (!modbusConnected)
                {
                    throw new Exception("PLC không phản hồi qua giao thức Modbus");
                }

                // 5. Cập nhật UI khi thành công
                lblStatus.Text = "TRẠNG THÁI: ĐÃ KẾT NỐI";
                lblStatus.BackColor = Color.LimeGreen;
                lblStatus.ForeColor = Color.Black;

                MessageBox.Show($"Kết nối thành công với PLC!\nPort: {setup.portName}\nSlave ID: {setup.slaveID}");
                isConnected = true;
                btnCONTROL.Enabled = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "TRẠNG THÁI: LỖI KẾT NỐI";
                lblStatus.BackColor = Color.Red;
                lblStatus.ForeColor = Color.White;

                MessageBox.Show("Không thể kết nối: " + ex.Message);
                isConnected = false;
                btnCONTROL.Enabled = false;

                //// Dọn dẹp tài nguyên
                //if (serialPort?.IsOpen == true)
                //    serialPort.Close();
            }
         
        }

        // THÊM hàm này vào class Form1 của bạn
        private async Task<bool> TestModbusConnection(byte slaveID)
        {
            try
            {
                // Thử đọc 1 coil từ PLC để kiểm tra kết nối
                bool[] testResult = await Task.Run(() =>
                {
                    return modbusMaster.ReadCoils(slaveID, 0, 1);
                });

                // Nếu đọc thành công (không ném exception) → kết nối OK
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi kiểm tra Modbus: {ex.Message}");
                return false;
            }
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
                modbusMaster.WriteSingleCoil(2, 1, false);  // tắt coil 1 của slave 1
                modbusMaster.WriteSingleCoil(2, 0, false);  // tắt coil 2 của slave 1
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private async void BUT_2_Click(object sender, EventArgs e)
        {
            bool toggle2 = false;  // trạng thái ON/OFF hiện tại
            try
            {
                // LẤY slaveID từ cấu hình hiện tại
                var setup = __setup();
                byte slaveID = setup.slaveID;

                toggle2 = !toggle2;
                await Task.Delay(100);

                // Sử dụng slaveID vừa lấy
                modbusMaster.WriteSingleCoil(slaveID, (ushort)00001, toggle2);

                await Task.Delay(100);
                BUT_2.Text = toggle2 ? "Y00 ON" : "Y00 OFF";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi điều khiển: " + ex.Message);
            }
        }

        private bool toggle1 = false; // trạng thái ON/OFF hiện tại 
        private async void BUT_1_Click(object sender, EventArgs e)
        {
            try
            {
                if ( serialPort == null || !serialPort.IsOpen)
                {
                    MessageBox.Show("Chưa kết nối PLC. Vui lòng nhấn CONNECT trước!");
                    return;
                }

                var setup = __setup();
                byte slaveID = setup.slaveID;

                toggle1 = !toggle1;
                await modbusMaster.WriteSingleCoilAsync(slaveID, (ushort)0000, true); // Y000
                BUT_1.Text = toggle1 ? "Y00 ON" : "Y00 OFF";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi điều khiển: " + ex.Message);
            }
        }


        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void panelCONNECT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCONTROL_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void cbPort_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cbPickSlave_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbBaudrate_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Chose_Click(object sender, EventArgs e)
        {

        }
    }

}
    
