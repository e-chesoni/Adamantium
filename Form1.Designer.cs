namespace Adamantium;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            //System.Text.ASCIIEncoding.ASCIIEncodingSealed asciiEncodingSealed2 = new System.Text.ASCIIEncoding.ASCIIEncodingSealed();
            System.Text.DecoderReplacementFallback decoderReplacementFallback2 = new System.Text.DecoderReplacementFallback();
            System.Text.EncoderReplacementFallback encoderReplacementFallback2 = new System.Text.EncoderReplacementFallback();
            this.adamSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.refreshBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.selectComboBox = new System.Windows.Forms.ComboBox();
            this.selectCheckBox = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.msRadioBtn = new System.Windows.Forms.RadioButton();
            this.stopBtn = new System.Windows.Forms.Button();
            this.timerCheckBox = new System.Windows.Forms.CheckBox();
            this.jogCheckBox = new System.Windows.Forms.CheckBox();
            this.cmd0TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendCmd0Btn = new System.Windows.Forms.Button();
            this.cmd0RadioBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd1TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmd5Label = new System.Windows.Forms.Label();
            this.cmd2TextBox = new System.Windows.Forms.TextBox();
            this.cmd3TextBox = new System.Windows.Forms.TextBox();
            this.cmd4TextBox = new System.Windows.Forms.TextBox();
            this.cmd5TextBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.baudTextBox = new System.Windows.Forms.TextBox();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.emailCheckBox = new System.Windows.Forms.CheckBox();
            this.emailOnLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.flushBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.cyclesTextBox = new System.Windows.Forms.TextBox();
            this.msTextBox = new System.Windows.Forms.TextBox();
            this.sendCmd1Btn = new System.Windows.Forms.Button();
            this.sendCmd2Btn = new System.Windows.Forms.Button();
            this.sendCmd3Btn = new System.Windows.Forms.Button();
            this.sendCmd4Btn = new System.Windows.Forms.Button();
            this.sendCmd5Btn = new System.Windows.Forms.Button();
            this.cmd1RadioBtn = new System.Windows.Forms.RadioButton();
            this.cmd2RadioBtn = new System.Windows.Forms.RadioButton();
            this.cmd3RadioBtn = new System.Windows.Forms.RadioButton();
            this.cmd4RadioBtn = new System.Windows.Forms.RadioButton();
            this.cmd5RadioBtn = new System.Windows.Forms.RadioButton();
            this.comTimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // adamSerialPort
            // 
            this.adamSerialPort.BaudRate = 9600;
            this.adamSerialPort.DataBits = 8;
            this.adamSerialPort.DiscardNull = false;
            this.adamSerialPort.DtrEnable = false;
            //asciiEncodingSealed2.DecoderFallback = decoderReplacementFallback2;
            //asciiEncodingSealed2.EncoderFallback = encoderReplacementFallback2;
            //this.adamSerialPort.Encoding = asciiEncodingSealed2;
            this.adamSerialPort.Handshake = System.IO.Ports.Handshake.None;
            this.adamSerialPort.NewLine = "\n";
            this.adamSerialPort.Parity = System.IO.Ports.Parity.None;
            this.adamSerialPort.ParityReplace = ((byte)(63));
            this.adamSerialPort.PortName = "COM1";
            this.adamSerialPort.ReadBufferSize = 4096;
            this.adamSerialPort.ReadTimeout = -1;
            this.adamSerialPort.ReceivedBytesThreshold = 1;
            this.adamSerialPort.RtsEnable = false;
            this.adamSerialPort.StopBits = System.IO.Ports.StopBits.One;
            this.adamSerialPort.WriteBufferSize = 2048;
            this.adamSerialPort.WriteTimeout = -1;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(12, 12);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(220, 12);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 1;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            // 
            // selectComboBox
            // 
            this.selectComboBox.FormattingEnabled = true;
            this.selectComboBox.Location = new System.Drawing.Point(93, 12);
            this.selectComboBox.Name = "selectComboBox";
            this.selectComboBox.Size = new System.Drawing.Size(121, 23);
            this.selectComboBox.TabIndex = 2;
            // 
            // selectCheckBox
            // 
            this.selectCheckBox.AutoSize = true;
            this.selectCheckBox.Location = new System.Drawing.Point(304, 16);
            this.selectCheckBox.Name = "selectCheckBox";
            this.selectCheckBox.Size = new System.Drawing.Size(15, 14);
            this.selectCheckBox.TabIndex = 3;
            this.selectCheckBox.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton1.Location = new System.Drawing.Point(461, 57);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 19);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "cycles/hr";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // msRadioBtn
            // 
            this.msRadioBtn.AutoSize = true;
            this.msRadioBtn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.msRadioBtn.Location = new System.Drawing.Point(493, 89);
            this.msRadioBtn.Name = "msRadioBtn";
            this.msRadioBtn.Size = new System.Drawing.Size(41, 19);
            this.msRadioBtn.TabIndex = 5;
            this.msRadioBtn.TabStop = true;
            this.msRadioBtn.Text = "ms";
            this.msRadioBtn.UseVisualStyleBackColor = true;
            this.msRadioBtn.CheckedChanged += new System.EventHandler(this.msRadioBtn_CheckedChanged);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Red;
            this.stopBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stopBtn.Location = new System.Drawing.Point(686, 89);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "STOP";
            this.stopBtn.UseVisualStyleBackColor = false;
            // 
            // timerCheckBox
            // 
            this.timerCheckBox.AutoSize = true;
            this.timerCheckBox.Location = new System.Drawing.Point(686, 61);
            this.timerCheckBox.Name = "timerCheckBox";
            this.timerCheckBox.Size = new System.Drawing.Size(72, 19);
            this.timerCheckBox.TabIndex = 7;
            this.timerCheckBox.Text = "TimerOn";
            this.timerCheckBox.UseVisualStyleBackColor = true;
            // 
            // jogCheckBox
            // 
            this.jogCheckBox.AutoSize = true;
            this.jogCheckBox.Location = new System.Drawing.Point(688, 128);
            this.jogCheckBox.Name = "jogCheckBox";
            this.jogCheckBox.Size = new System.Drawing.Size(87, 19);
            this.jogCheckBox.TabIndex = 8;
            this.jogCheckBox.Text = "Jog Control";
            this.jogCheckBox.UseVisualStyleBackColor = true;
            // 
            // cmd0TextBox
            // 
            this.cmd0TextBox.Location = new System.Drawing.Point(535, 174);
            this.cmd0TextBox.Name = "cmd0TextBox";
            this.cmd0TextBox.Size = new System.Drawing.Size(139, 23);
            this.cmd0TextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "command 0";
            this.label1.Click += new System.EventHandler(this.command1_Click);
            // 
            // sendCmd0Btn
            // 
            this.sendCmd0Btn.Location = new System.Drawing.Point(565, 203);
            this.sendCmd0Btn.Name = "sendCmd0Btn";
            this.sendCmd0Btn.Size = new System.Drawing.Size(75, 23);
            this.sendCmd0Btn.TabIndex = 11;
            this.sendCmd0Btn.Text = "Send";
            this.sendCmd0Btn.UseVisualStyleBackColor = true;
            // 
            // cmd0RadioBtn
            // 
            this.cmd0RadioBtn.AutoSize = true;
            this.cmd0RadioBtn.Location = new System.Drawing.Point(686, 177);
            this.cmd0RadioBtn.Name = "cmd0RadioBtn";
            this.cmd0RadioBtn.Size = new System.Drawing.Size(31, 19);
            this.cmd0RadioBtn.TabIndex = 12;
            this.cmd0RadioBtn.TabStop = true;
            this.cmd0RadioBtn.Text = "0";
            this.cmd0RadioBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "command 1";
            // 
            // cmd1TextBox
            // 
            this.cmd1TextBox.Location = new System.Drawing.Point(535, 259);
            this.cmd1TextBox.Name = "cmd1TextBox";
            this.cmd1TextBox.Size = new System.Drawing.Size(139, 23);
            this.cmd1TextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "command 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "command 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "command 4";
            // 
            // cmd5Label
            // 
            this.cmd5Label.AutoSize = true;
            this.cmd5Label.Location = new System.Drawing.Point(458, 390);
            this.cmd5Label.Name = "cmd5Label";
            this.cmd5Label.Size = new System.Drawing.Size(71, 15);
            this.cmd5Label.TabIndex = 18;
            this.cmd5Label.Text = "command 5";
            this.cmd5Label.Click += new System.EventHandler(this.cmd5Btn_Click);
            // 
            // cmd2TextBox
            // 
            this.cmd2TextBox.Location = new System.Drawing.Point(535, 292);
            this.cmd2TextBox.Name = "cmd2TextBox";
            this.cmd2TextBox.Size = new System.Drawing.Size(139, 23);
            this.cmd2TextBox.TabIndex = 19;
            // 
            // cmd3TextBox
            // 
            this.cmd3TextBox.Location = new System.Drawing.Point(535, 322);
            this.cmd3TextBox.Name = "cmd3TextBox";
            this.cmd3TextBox.Size = new System.Drawing.Size(139, 23);
            this.cmd3TextBox.TabIndex = 20;
            // 
            // cmd4TextBox
            // 
            this.cmd4TextBox.Location = new System.Drawing.Point(535, 354);
            this.cmd4TextBox.Name = "cmd4TextBox";
            this.cmd4TextBox.Size = new System.Drawing.Size(139, 23);
            this.cmd4TextBox.TabIndex = 21;
            // 
            // cmd5TextBox
            // 
            this.cmd5TextBox.Location = new System.Drawing.Point(535, 387);
            this.cmd5TextBox.Name = "cmd5TextBox";
            this.cmd5TextBox.Size = new System.Drawing.Size(139, 23);
            this.cmd5TextBox.TabIndex = 22;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(700, 426);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 23;
            this.closeBtn.Text = "close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "BAUD";
            // 
            // baudTextBox
            // 
            this.baudTextBox.Location = new System.Drawing.Point(93, 49);
            this.baudTextBox.Name = "baudTextBox";
            this.baudTextBox.Size = new System.Drawing.Size(100, 23);
            this.baudTextBox.TabIndex = 25;
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(12, 82);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(75, 23);
            this.portComboBox.TabIndex = 26;
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(93, 82);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 27;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            // 
            // emailCheckBox
            // 
            this.emailCheckBox.AutoSize = true;
            this.emailCheckBox.Location = new System.Drawing.Point(12, 111);
            this.emailCheckBox.Name = "emailCheckBox";
            this.emailCheckBox.Size = new System.Drawing.Size(15, 14);
            this.emailCheckBox.TabIndex = 28;
            this.emailCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailOnLabel
            // 
            this.emailOnLabel.AutoSize = true;
            this.emailOnLabel.Location = new System.Drawing.Point(33, 110);
            this.emailOnLabel.Name = "emailOnLabel";
            this.emailOnLabel.Size = new System.Drawing.Size(55, 15);
            this.emailOnLabel.TabIndex = 29;
            this.emailOnLabel.Text = "Email On";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(12, 136);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(375, 274);
            this.logTextBox.TabIndex = 30;
            // 
            // flushBtn
            // 
            this.flushBtn.Location = new System.Drawing.Point(12, 416);
            this.flushBtn.Name = "flushBtn";
            this.flushBtn.Size = new System.Drawing.Size(75, 23);
            this.flushBtn.TabIndex = 31;
            this.flushBtn.Text = "Flush";
            this.flushBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(312, 416);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 32;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // cyclesTextBox
            // 
            this.cyclesTextBox.Location = new System.Drawing.Point(561, 57);
            this.cyclesTextBox.Name = "cyclesTextBox";
            this.cyclesTextBox.Size = new System.Drawing.Size(100, 23);
            this.cyclesTextBox.TabIndex = 33;
            // 
            // msTextBox
            // 
            this.msTextBox.Location = new System.Drawing.Point(561, 89);
            this.msTextBox.Name = "msTextBox";
            this.msTextBox.Size = new System.Drawing.Size(100, 23);
            this.msTextBox.TabIndex = 34;
            // 
            // sendCmd1Btn
            // 
            this.sendCmd1Btn.Location = new System.Drawing.Point(680, 259);
            this.sendCmd1Btn.Name = "sendCmd1Btn";
            this.sendCmd1Btn.Size = new System.Drawing.Size(75, 23);
            this.sendCmd1Btn.TabIndex = 35;
            this.sendCmd1Btn.Text = "send";
            this.sendCmd1Btn.UseVisualStyleBackColor = true;
            // 
            // sendCmd2Btn
            // 
            this.sendCmd2Btn.Location = new System.Drawing.Point(680, 292);
            this.sendCmd2Btn.Name = "sendCmd2Btn";
            this.sendCmd2Btn.Size = new System.Drawing.Size(75, 23);
            this.sendCmd2Btn.TabIndex = 36;
            this.sendCmd2Btn.Text = "send";
            this.sendCmd2Btn.UseVisualStyleBackColor = true;
            // 
            // sendCmd3Btn
            // 
            this.sendCmd3Btn.Location = new System.Drawing.Point(680, 322);
            this.sendCmd3Btn.Name = "sendCmd3Btn";
            this.sendCmd3Btn.Size = new System.Drawing.Size(75, 23);
            this.sendCmd3Btn.TabIndex = 37;
            this.sendCmd3Btn.Text = "send";
            this.sendCmd3Btn.UseVisualStyleBackColor = true;
            // 
            // sendCmd4Btn
            // 
            this.sendCmd4Btn.Location = new System.Drawing.Point(680, 354);
            this.sendCmd4Btn.Name = "sendCmd4Btn";
            this.sendCmd4Btn.Size = new System.Drawing.Size(75, 23);
            this.sendCmd4Btn.TabIndex = 38;
            this.sendCmd4Btn.Text = "send";
            this.sendCmd4Btn.UseVisualStyleBackColor = true;
            // 
            // sendCmd5Btn
            // 
            this.sendCmd5Btn.Location = new System.Drawing.Point(680, 387);
            this.sendCmd5Btn.Name = "sendCmd5Btn";
            this.sendCmd5Btn.Size = new System.Drawing.Size(75, 23);
            this.sendCmd5Btn.TabIndex = 39;
            this.sendCmd5Btn.Text = "send";
            this.sendCmd5Btn.UseVisualStyleBackColor = true;
            // 
            // cmd1RadioBtn
            // 
            this.cmd1RadioBtn.AutoSize = true;
            this.cmd1RadioBtn.Location = new System.Drawing.Point(761, 263);
            this.cmd1RadioBtn.Name = "cmd1RadioBtn";
            this.cmd1RadioBtn.Size = new System.Drawing.Size(31, 19);
            this.cmd1RadioBtn.TabIndex = 40;
            this.cmd1RadioBtn.TabStop = true;
            this.cmd1RadioBtn.Text = "1";
            this.cmd1RadioBtn.UseVisualStyleBackColor = true;
            // 
            // cmd2RadioBtn
            // 
            this.cmd2RadioBtn.AutoSize = true;
            this.cmd2RadioBtn.Location = new System.Drawing.Point(761, 295);
            this.cmd2RadioBtn.Name = "cmd2RadioBtn";
            this.cmd2RadioBtn.Size = new System.Drawing.Size(31, 19);
            this.cmd2RadioBtn.TabIndex = 41;
            this.cmd2RadioBtn.TabStop = true;
            this.cmd2RadioBtn.Text = "2";
            this.cmd2RadioBtn.UseVisualStyleBackColor = true;
            // 
            // cmd3RadioBtn
            // 
            this.cmd3RadioBtn.AutoSize = true;
            this.cmd3RadioBtn.Location = new System.Drawing.Point(761, 326);
            this.cmd3RadioBtn.Name = "cmd3RadioBtn";
            this.cmd3RadioBtn.Size = new System.Drawing.Size(31, 19);
            this.cmd3RadioBtn.TabIndex = 42;
            this.cmd3RadioBtn.TabStop = true;
            this.cmd3RadioBtn.Text = "3";
            this.cmd3RadioBtn.UseVisualStyleBackColor = true;
            // 
            // cmd4RadioBtn
            // 
            this.cmd4RadioBtn.AutoSize = true;
            this.cmd4RadioBtn.Location = new System.Drawing.Point(761, 358);
            this.cmd4RadioBtn.Name = "cmd4RadioBtn";
            this.cmd4RadioBtn.Size = new System.Drawing.Size(31, 19);
            this.cmd4RadioBtn.TabIndex = 43;
            this.cmd4RadioBtn.TabStop = true;
            this.cmd4RadioBtn.Text = "4";
            this.cmd4RadioBtn.UseVisualStyleBackColor = true;
            // 
            // cmd5RadioBtn
            // 
            this.cmd5RadioBtn.AutoSize = true;
            this.cmd5RadioBtn.Location = new System.Drawing.Point(761, 391);
            this.cmd5RadioBtn.Name = "cmd5RadioBtn";
            this.cmd5RadioBtn.Size = new System.Drawing.Size(31, 19);
            this.cmd5RadioBtn.TabIndex = 44;
            this.cmd5RadioBtn.TabStop = true;
            this.cmd5RadioBtn.Text = "5";
            this.cmd5RadioBtn.UseVisualStyleBackColor = true;
            // 
            // comTimer
            // 
            this.comTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(812, 461);
            this.Controls.Add(this.cmd5RadioBtn);
            this.Controls.Add(this.cmd4RadioBtn);
            this.Controls.Add(this.cmd3RadioBtn);
            this.Controls.Add(this.cmd2RadioBtn);
            this.Controls.Add(this.cmd1RadioBtn);
            this.Controls.Add(this.sendCmd5Btn);
            this.Controls.Add(this.sendCmd4Btn);
            this.Controls.Add(this.sendCmd3Btn);
            this.Controls.Add(this.sendCmd2Btn);
            this.Controls.Add(this.sendCmd1Btn);
            this.Controls.Add(this.msTextBox);
            this.Controls.Add(this.cyclesTextBox);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.flushBtn);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.emailOnLabel);
            this.Controls.Add(this.emailCheckBox);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.baudTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.cmd5TextBox);
            this.Controls.Add(this.cmd4TextBox);
            this.Controls.Add(this.cmd3TextBox);
            this.Controls.Add(this.cmd2TextBox);
            this.Controls.Add(this.cmd5Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmd1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmd0RadioBtn);
            this.Controls.Add(this.sendCmd0Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd0TextBox);
            this.Controls.Add(this.jogCheckBox);
            this.Controls.Add(this.timerCheckBox);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.msRadioBtn);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.selectCheckBox);
            this.Controls.Add(this.selectComboBox);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.refreshBtn);
            this.Name = "Form1";
            this.Text = "Adamantium Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button refreshBtn;
    private Button selectBtn;
    private ComboBox selectComboBox;
    private CheckBox selectCheckBox;
    private RadioButton radioButton1;
    private RadioButton msRadioBtn;
    private Button stopBtn;
    private CheckBox timerCheckBox;
    private CheckBox jogCheckBox;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label7;
    private Label cmd5Label;
    private TextBox cmd0TextBox;
    private TextBox cmd1TextBox;
    private TextBox cmd2TextBox;
    private TextBox cmd3TextBox;
    private TextBox cmd4TextBox;
    private TextBox cmd5TextBox;
    private TextBox baudTextBox;
    private ComboBox portComboBox;
    private Button openBtn;
    private CheckBox emailCheckBox;
    private Label emailOnLabel;
    private TextBox cyclesTextBox;
    private TextBox msTextBox;
    private Button sendCmd0Btn;
    private Button sendCmd1Btn;
    private Button sendCmd2Btn;
    private Button sendCmd3Btn;
    private Button sendCmd4Btn;
    private Button sendCmd5Btn;
    private RadioButton cmd0RadioBtn;
    private RadioButton cmd1RadioBtn;
    private RadioButton cmd2RadioBtn;
    private RadioButton cmd3RadioBtn;
    private RadioButton cmd4RadioBtn;
    private RadioButton cmd5RadioBtn;
    private TextBox logTextBox;
    private Button flushBtn;
    private Button clearBtn;
    private Button closeBtn;

    private System.Windows.Forms.Timer comTimer;
    private System.Windows.Forms.Timer timer2;
    private System.Windows.Forms.Timer timer3;
    private System.IO.Ports.SerialPort adamSerialPort;
}
