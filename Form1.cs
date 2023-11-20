using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Adamantium;

public partial class Form1 : Form
{
    string ComPort = "COM4";
    string termread = "";
    string CMD0 = "1mvr5";
    string CMD1 = "1pos?";
    string CMD2 = "1sta?";
    string CMD3 = "1mvr-5";
    string CMD4 = "1sta?";
    string CMD5 = "1pos?";
    string delimStr = " #,\n\r";    // delimiters to parse the position
    bool CmdCheck;
    bool timeflag = false;
    bool eOn = false;
    bool joyflag = false;
    char[] delimiter = null;    // char array for the delimiters to parse position reads		
    int CmdCount = 0;
    int cmdcounts = 0;
    int BaudRate = 38400;

    // TEST vars
    private string[] commandTexts = new string[6]; // Array to store command texts
    private int msValue = 250; // Default value for msTextBox

    public Form1()
    {
        InitializeComponent(); // required for Windows Forms designer support.

        foreach (string s in SerialPort.GetPortNames())
        {
            portComboBox.Items.Add(s);
        }
        if (portComboBox.Items.Count > 0)
        {
            portComboBox.SelectedIndex = 0;
        }
        comTimer.Start();
        delimiter = delimStr.ToCharArray();

        // Event registration remains the same
        adamSerialPort.DataReceived += new SerialDataReceivedEventHandler(adamSerialPort_DataReceived);

        // Set values to UI elements
        baudTextBox.Text = BaudRate.ToString();
        cmd0TextBox.Text = CMD0;
        cmd1TextBox.Text = CMD1;
        cmd2TextBox.Text = CMD2;
        cmd3TextBox.Text = CMD3;
        cmd4TextBox.Text = CMD4;
        cmd5TextBox.Text = CMD5;
        msTextBox.Text = msValue.ToString();
    }

delegate void updateTextBoxDelegate(string newText);

    private void updateTextBox(string newText)
    {
        /*
        if (textBox1.InvokeRequired)
        {
            updateTextBoxDelegate del = new updateTextBoxDelegate(updateTextBox);
            textBox1.BeginInvoke(del, new object[] { newText });
        }
        else
        {
            textBox1.Text = textBox1.Text.Insert(textBox1.SelectionStart, newText);
            textBox1.Text = textBox1.Text.Insert(textBox1.SelectionStart, "\r\n");
        }
        i++;
        */
    }
    delegate void updateTimerDelegate(string newText);

    private void updateTimer(string newText)
    {
        /*
        if (Time.InvokeRequired)
        {
            updateTextBoxDelegate del = new updateTextBoxDelegate(updateTimer);
            Time.BeginInvoke(del, new object[] { newText });
        }
        else
        {
            Time.Text = "";
            Time.Text = Time.Text.Insert(Time.SelectionStart, newText);

        }
        */
    }

    private void serialWrite(string msg)
    {
        /*
        if (serialPort1.IsOpen)
        {
            if (serialPort1.BytesToRead <= 0)
            {
                System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                byte[] data = encoding.GetBytes(msg);
                try
                {
                    serialPort1.Write(data, 0, data.Length);
                    serialPort1.Write("\n\r");
                }
                catch
                {
                    if (eOn)
                    {
                        sendMail("Serial Write");
                        END();
                    }
                }
            }
            else
            {
                serialPort1.DiscardInBuffer();
            }
        }
        else
        {
            serialPort1.PortName = ComPort;
            serialPort1.BaudRate = 38400;
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            try
            {
                serialPort1.Open();
                updateTextBox("\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r");
                updateTextBox(ComPort + " Open. Begin Testing");
                comboBox1.Enabled = false;
                OpenPort.Enabled = false;
            }
            catch
            {
                END();
            }
        }
        */
    }

    private void adamSerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
    {
        /*
        if (serialPort1.IsOpen)
        {
            int bytes = serialPort1.BytesToRead;
            byte[] buffer = new byte[bytes];
            if (serialPort1.BytesToWrite <= 0)
            {
                while (serialPort1.BytesToRead > 0)
                {
                    try
                    {
                        termread = serialPort1.ReadLine();
                        //updateTextBox("MMC: "+termread);						
                        //serialPort1.Read(buffer, 0, bytes);
                        //termread =System.Text.Encoding.Default.GetString(buffer);
                    }
                    catch
                    {
                        try
                        {
                            serialPort1.Open();
                            updateTextBox("\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r");
                            updateTextBox(ComPort + " Open. Begin Testing");
                            comboBox1.Enabled = false;
                            OpenPort.Enabled = false;
                        }
                        catch
                        {
                            END();
                        }
                    }
                    updateTextBox("MMC: " + termread);
                }
            }
            else
            {
                updateTextBox("Your port has been disconnected");
            }
        }
        */
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void command1_Click(object sender, EventArgs e)
    {

    }

    private void closeBtn_Click(object sender, EventArgs e)
    {

    }

    private void cmd5Btn_Click(object sender, EventArgs e)
    {

    }

    private void msRadioBtn_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void timer1_Tick(object sender, EventArgs e)
    {

    }
}
