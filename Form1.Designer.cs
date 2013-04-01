namespace imageWithSpeech
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.imageBox1 = new Emgu.CV.UI.ImageBox();
      this.hueMinTB = new System.Windows.Forms.TrackBar();
      this.hueMaxTB = new System.Windows.Forms.TrackBar();
      this.satMinTB = new System.Windows.Forms.TrackBar();
      this.satMaxTB = new System.Windows.Forms.TrackBar();
      this.valMinTB = new System.Windows.Forms.TrackBar();
      this.valMaxTB = new System.Windows.Forms.TrackBar();
      this.hueLB = new System.Windows.Forms.Label();
      this.saturationLB = new System.Windows.Forms.Label();
      this.valueLB = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.imageBox2 = new Emgu.CV.UI.ImageBox();
      this.imageBox3 = new Emgu.CV.UI.ImageBox();
      this.label10 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.erodeOffsetTB = new System.Windows.Forms.TextBox();
      this.erodeDimensionTB = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.dilateOffsetTB = new System.Windows.Forms.TextBox();
      this.dilateDimensionTB = new System.Windows.Forms.TextBox();
      this.hueMinValLB = new System.Windows.Forms.Label();
      this.hueMaxValLB = new System.Windows.Forms.Label();
      this.satMinValLB = new System.Windows.Forms.Label();
      this.valMinValLB = new System.Windows.Forms.Label();
      this.valMaxValLB = new System.Windows.Forms.Label();
      this.satMaxValLB = new System.Windows.Forms.Label();
      this.imageBox4 = new Emgu.CV.UI.ImageBox();
      this.getContoursCB = new System.Windows.Forms.CheckBox();
      this.gausSmoothCB = new System.Windows.Forms.CheckBox();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.label9 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.label11 = new System.Windows.Forms.Label();
      this.gausLengthTB = new System.Windows.Forms.TextBox();
      this.label14 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.gausSigmaXTB = new System.Windows.Forms.TextBox();
      this.gausSigmaYTB = new System.Windows.Forms.TextBox();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.label16 = new System.Windows.Forms.Label();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.label17 = new System.Windows.Forms.Label();
      this.checkBox4 = new System.Windows.Forms.CheckBox();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.label19 = new System.Windows.Forms.Label();
      this.label20 = new System.Windows.Forms.Label();
      this.textBox8 = new System.Windows.Forms.TextBox();
      this.textBox9 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.hueMinTB)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.hueMaxTB)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.satMinTB)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.satMaxTB)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.valMinTB)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.valMaxTB)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.SuspendLayout();
      // 
      // imageBox1
      // 
      this.imageBox1.Location = new System.Drawing.Point(340, 502);
      this.imageBox1.Name = "imageBox1";
      this.imageBox1.Size = new System.Drawing.Size(321, 342);
      this.imageBox1.TabIndex = 2;
      this.imageBox1.TabStop = false;
      // 
      // hueMinTB
      // 
      this.hueMinTB.LargeChange = 20;
      this.hueMinTB.Location = new System.Drawing.Point(50, 29);
      this.hueMinTB.Maximum = 180;
      this.hueMinTB.Name = "hueMinTB";
      this.hueMinTB.Size = new System.Drawing.Size(393, 45);
      this.hueMinTB.SmallChange = 5;
      this.hueMinTB.TabIndex = 3;
      this.hueMinTB.TickFrequency = 5;
      this.hueMinTB.Scroll += new System.EventHandler(this.hueMinTB_Scroll);
      // 
      // hueMaxTB
      // 
      this.hueMaxTB.LargeChange = 20;
      this.hueMaxTB.Location = new System.Drawing.Point(48, 72);
      this.hueMaxTB.Maximum = 180;
      this.hueMaxTB.Name = "hueMaxTB";
      this.hueMaxTB.Size = new System.Drawing.Size(393, 45);
      this.hueMaxTB.SmallChange = 5;
      this.hueMaxTB.TabIndex = 4;
      this.hueMaxTB.TickFrequency = 5;
      this.hueMaxTB.Value = 180;
      this.hueMaxTB.Scroll += new System.EventHandler(this.hueMaxTB_Scroll);
      // 
      // satMinTB
      // 
      this.satMinTB.LargeChange = 20;
      this.satMinTB.Location = new System.Drawing.Point(48, 140);
      this.satMinTB.Maximum = 255;
      this.satMinTB.Name = "satMinTB";
      this.satMinTB.Size = new System.Drawing.Size(393, 45);
      this.satMinTB.SmallChange = 5;
      this.satMinTB.TabIndex = 5;
      this.satMinTB.TickFrequency = 5;
      this.satMinTB.Value = 1;
      this.satMinTB.Scroll += new System.EventHandler(this.satMinTB_Scroll);
      // 
      // satMaxTB
      // 
      this.satMaxTB.LargeChange = 20;
      this.satMaxTB.Location = new System.Drawing.Point(48, 183);
      this.satMaxTB.Maximum = 255;
      this.satMaxTB.Name = "satMaxTB";
      this.satMaxTB.Size = new System.Drawing.Size(393, 45);
      this.satMaxTB.SmallChange = 5;
      this.satMaxTB.TabIndex = 6;
      this.satMaxTB.TickFrequency = 5;
      this.satMaxTB.Value = 255;
      this.satMaxTB.Scroll += new System.EventHandler(this.satMaxTB_Scroll);
      // 
      // valMinTB
      // 
      this.valMinTB.LargeChange = 20;
      this.valMinTB.Location = new System.Drawing.Point(48, 242);
      this.valMinTB.Maximum = 255;
      this.valMinTB.Name = "valMinTB";
      this.valMinTB.Size = new System.Drawing.Size(393, 45);
      this.valMinTB.SmallChange = 5;
      this.valMinTB.TabIndex = 7;
      this.valMinTB.TickFrequency = 5;
      this.valMinTB.Scroll += new System.EventHandler(this.valMinTB_Scroll);
      // 
      // valMaxTB
      // 
      this.valMaxTB.LargeChange = 20;
      this.valMaxTB.Location = new System.Drawing.Point(48, 288);
      this.valMaxTB.Maximum = 255;
      this.valMaxTB.Name = "valMaxTB";
      this.valMaxTB.Size = new System.Drawing.Size(393, 45);
      this.valMaxTB.SmallChange = 5;
      this.valMaxTB.TabIndex = 8;
      this.valMaxTB.TickFrequency = 5;
      this.valMaxTB.Value = 255;
      this.valMaxTB.Scroll += new System.EventHandler(this.valMaxTB_Scroll);
      // 
      // hueLB
      // 
      this.hueLB.AutoSize = true;
      this.hueLB.Location = new System.Drawing.Point(42, 87);
      this.hueLB.Name = "hueLB";
      this.hueLB.Size = new System.Drawing.Size(30, 13);
      this.hueLB.TabIndex = 9;
      this.hueLB.Text = "Hue:";
      // 
      // saturationLB
      // 
      this.saturationLB.AutoSize = true;
      this.saturationLB.Location = new System.Drawing.Point(55, 115);
      this.saturationLB.Name = "saturationLB";
      this.saturationLB.Size = new System.Drawing.Size(58, 13);
      this.saturationLB.TabIndex = 10;
      this.saturationLB.Text = "Saturation:";
      // 
      // valueLB
      // 
      this.valueLB.AutoSize = true;
      this.valueLB.Location = new System.Drawing.Point(55, 226);
      this.valueLB.Name = "valueLB";
      this.valueLB.Size = new System.Drawing.Size(37, 13);
      this.valueLB.TabIndex = 11;
      this.valueLB.Text = "Value:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 29);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(24, 13);
      this.label1.TabIndex = 12;
      this.label1.Text = "Min";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 72);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(27, 13);
      this.label2.TabIndex = 13;
      this.label2.Text = "Max";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(14, 140);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(24, 13);
      this.label3.TabIndex = 14;
      this.label3.Text = "Min";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(14, 183);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(27, 13);
      this.label4.TabIndex = 15;
      this.label4.Text = "Max";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(14, 242);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(24, 13);
      this.label5.TabIndex = 16;
      this.label5.Text = "Min";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(14, 288);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(27, 13);
      this.label6.TabIndex = 17;
      this.label6.Text = "Max";
      // 
      // imageBox2
      // 
      this.imageBox2.Location = new System.Drawing.Point(12, 500);
      this.imageBox2.Name = "imageBox2";
      this.imageBox2.Size = new System.Drawing.Size(322, 344);
      this.imageBox2.TabIndex = 2;
      this.imageBox2.TabStop = false;
      // 
      // imageBox3
      // 
      this.imageBox3.Location = new System.Drawing.Point(12, 16);
      this.imageBox3.Name = "imageBox3";
      this.imageBox3.Size = new System.Drawing.Size(649, 480);
      this.imageBox3.TabIndex = 2;
      this.imageBox3.TabStop = false;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(39, 51);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(67, 13);
      this.label10.TabIndex = 21;
      this.label10.Text = "Side Length:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(39, 82);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(35, 13);
      this.label7.TabIndex = 22;
      this.label7.Text = "Offset";
      // 
      // erodeOffsetTB
      // 
      this.erodeOffsetTB.Location = new System.Drawing.Point(112, 79);
      this.erodeOffsetTB.Name = "erodeOffsetTB";
      this.erodeOffsetTB.Size = new System.Drawing.Size(44, 20);
      this.erodeOffsetTB.TabIndex = 25;
      // 
      // erodeDimensionTB
      // 
      this.erodeDimensionTB.Location = new System.Drawing.Point(112, 44);
      this.erodeDimensionTB.Name = "erodeDimensionTB";
      this.erodeDimensionTB.Size = new System.Drawing.Size(44, 20);
      this.erodeDimensionTB.TabIndex = 26;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.checkBox1);
      this.groupBox1.Controls.Add(this.label10);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.erodeDimensionTB);
      this.groupBox1.Controls.Add(this.erodeOffsetTB);
      this.groupBox1.Location = new System.Drawing.Point(16, 18);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(189, 114);
      this.groupBox1.TabIndex = 29;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Erosion Smooth";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.checkBox2);
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Controls.Add(this.label12);
      this.groupBox2.Controls.Add(this.dilateOffsetTB);
      this.groupBox2.Controls.Add(this.dilateDimensionTB);
      this.groupBox2.Location = new System.Drawing.Point(211, 18);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(189, 114);
      this.groupBox2.TabIndex = 30;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Dilate Smooth";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(47, 48);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(67, 13);
      this.label8.TabIndex = 21;
      this.label8.Text = "Side Length:";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(61, 79);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(38, 13);
      this.label12.TabIndex = 22;
      this.label12.Text = "Offset:";
      // 
      // dilateOffsetTB
      // 
      this.dilateOffsetTB.Location = new System.Drawing.Point(117, 76);
      this.dilateOffsetTB.Name = "dilateOffsetTB";
      this.dilateOffsetTB.Size = new System.Drawing.Size(44, 20);
      this.dilateOffsetTB.TabIndex = 27;
      // 
      // dilateDimensionTB
      // 
      this.dilateDimensionTB.Location = new System.Drawing.Point(117, 45);
      this.dilateDimensionTB.Name = "dilateDimensionTB";
      this.dilateDimensionTB.Size = new System.Drawing.Size(44, 20);
      this.dilateDimensionTB.TabIndex = 26;
      // 
      // hueMinValLB
      // 
      this.hueMinValLB.AutoSize = true;
      this.hueMinValLB.Location = new System.Drawing.Point(449, 29);
      this.hueMinValLB.Name = "hueMinValLB";
      this.hueMinValLB.Size = new System.Drawing.Size(13, 13);
      this.hueMinValLB.TabIndex = 31;
      this.hueMinValLB.Text = "0";
      // 
      // hueMaxValLB
      // 
      this.hueMaxValLB.AutoSize = true;
      this.hueMaxValLB.Location = new System.Drawing.Point(449, 72);
      this.hueMaxValLB.Name = "hueMaxValLB";
      this.hueMaxValLB.Size = new System.Drawing.Size(13, 13);
      this.hueMaxValLB.TabIndex = 32;
      this.hueMaxValLB.Text = "0";
      // 
      // satMinValLB
      // 
      this.satMinValLB.AutoSize = true;
      this.satMinValLB.Location = new System.Drawing.Point(447, 140);
      this.satMinValLB.Name = "satMinValLB";
      this.satMinValLB.Size = new System.Drawing.Size(13, 13);
      this.satMinValLB.TabIndex = 33;
      this.satMinValLB.Text = "0";
      // 
      // valMinValLB
      // 
      this.valMinValLB.AutoSize = true;
      this.valMinValLB.Location = new System.Drawing.Point(449, 242);
      this.valMinValLB.Name = "valMinValLB";
      this.valMinValLB.Size = new System.Drawing.Size(13, 13);
      this.valMinValLB.TabIndex = 34;
      this.valMinValLB.Text = "0";
      // 
      // valMaxValLB
      // 
      this.valMaxValLB.AutoSize = true;
      this.valMaxValLB.Location = new System.Drawing.Point(449, 288);
      this.valMaxValLB.Name = "valMaxValLB";
      this.valMaxValLB.Size = new System.Drawing.Size(13, 13);
      this.valMaxValLB.TabIndex = 35;
      this.valMaxValLB.Text = "0";
      // 
      // satMaxValLB
      // 
      this.satMaxValLB.AutoSize = true;
      this.satMaxValLB.Location = new System.Drawing.Point(449, 183);
      this.satMaxValLB.Name = "satMaxValLB";
      this.satMaxValLB.Size = new System.Drawing.Size(13, 13);
      this.satMaxValLB.TabIndex = 36;
      this.satMaxValLB.Text = "0";
      // 
      // imageBox4
      // 
      this.imageBox4.Location = new System.Drawing.Point(667, 16);
      this.imageBox4.Name = "imageBox4";
      this.imageBox4.Size = new System.Drawing.Size(640, 480);
      this.imageBox4.TabIndex = 37;
      this.imageBox4.TabStop = false;
      // 
      // getContoursCB
      // 
      this.getContoursCB.AutoSize = true;
      this.getContoursCB.Location = new System.Drawing.Point(406, 157);
      this.getContoursCB.Name = "getContoursCB";
      this.getContoursCB.Size = new System.Drawing.Size(68, 17);
      this.getContoursCB.TabIndex = 38;
      this.getContoursCB.Text = "Contours";
      this.getContoursCB.UseVisualStyleBackColor = true;
      // 
      // gausSmoothCB
      // 
      this.gausSmoothCB.AutoSize = true;
      this.gausSmoothCB.Location = new System.Drawing.Point(19, 19);
      this.gausSmoothCB.Name = "gausSmoothCB";
      this.gausSmoothCB.Size = new System.Drawing.Size(98, 17);
      this.gausSmoothCB.TabIndex = 39;
      this.gausSmoothCB.Text = "Enable Smooth";
      this.gausSmoothCB.UseVisualStyleBackColor = true;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(667, 502);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(658, 346);
      this.tabControl1.TabIndex = 40;
      // 
      // tabPage1
      // 
      this.tabPage1.BackColor = System.Drawing.Color.White;
      this.tabPage1.Controls.Add(this.label9);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.saturationLB);
      this.tabPage1.Controls.Add(this.valueLB);
      this.tabPage1.Controls.Add(this.valMaxTB);
      this.tabPage1.Controls.Add(this.label6);
      this.tabPage1.Controls.Add(this.satMaxValLB);
      this.tabPage1.Controls.Add(this.valMinTB);
      this.tabPage1.Controls.Add(this.hueMinValLB);
      this.tabPage1.Controls.Add(this.label5);
      this.tabPage1.Controls.Add(this.valMaxValLB);
      this.tabPage1.Controls.Add(this.satMaxTB);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.hueMinTB);
      this.tabPage1.Controls.Add(this.hueMaxValLB);
      this.tabPage1.Controls.Add(this.valMinValLB);
      this.tabPage1.Controls.Add(this.label4);
      this.tabPage1.Controls.Add(this.satMinTB);
      this.tabPage1.Controls.Add(this.hueMaxTB);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Controls.Add(this.satMinValLB);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(650, 320);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "tabPage1";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.groupBox5);
      this.tabPage2.Controls.Add(this.groupBox4);
      this.tabPage2.Controls.Add(this.groupBox3);
      this.tabPage2.Controls.Add(this.groupBox1);
      this.tabPage2.Controls.Add(this.hueLB);
      this.tabPage2.Controls.Add(this.getContoursCB);
      this.tabPage2.Controls.Add(this.groupBox2);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(650, 320);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(57, 10);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(30, 13);
      this.label9.TabIndex = 41;
      this.label9.Text = "Hue:";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.label14);
      this.groupBox3.Controls.Add(this.label15);
      this.groupBox3.Controls.Add(this.gausSmoothCB);
      this.groupBox3.Controls.Add(this.gausSigmaXTB);
      this.groupBox3.Controls.Add(this.gausSigmaYTB);
      this.groupBox3.Controls.Add(this.label11);
      this.groupBox3.Controls.Add(this.gausLengthTB);
      this.groupBox3.Location = new System.Drawing.Point(16, 138);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(189, 176);
      this.groupBox3.TabIndex = 30;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Gaussian Smooth";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(39, 52);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(67, 13);
      this.label11.TabIndex = 21;
      this.label11.Text = "Side Length:";
      // 
      // gausLengthTB
      // 
      this.gausLengthTB.Location = new System.Drawing.Point(112, 49);
      this.gausLengthTB.Name = "gausLengthTB";
      this.gausLengthTB.Size = new System.Drawing.Size(44, 20);
      this.gausLengthTB.TabIndex = 26;
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(39, 84);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(50, 13);
      this.label14.TabIndex = 27;
      this.label14.Text = "Sigma_x:";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(39, 115);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(50, 13);
      this.label15.TabIndex = 28;
      this.label15.Text = "Sigma_y:";
      // 
      // gausSigmaXTB
      // 
      this.gausSigmaXTB.Location = new System.Drawing.Point(112, 81);
      this.gausSigmaXTB.Name = "gausSigmaXTB";
      this.gausSigmaXTB.Size = new System.Drawing.Size(44, 20);
      this.gausSigmaXTB.TabIndex = 30;
      // 
      // gausSigmaYTB
      // 
      this.gausSigmaYTB.Location = new System.Drawing.Point(112, 112);
      this.gausSigmaYTB.Name = "gausSigmaYTB";
      this.gausSigmaYTB.Size = new System.Drawing.Size(44, 20);
      this.gausSigmaYTB.TabIndex = 29;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(19, 19);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(98, 17);
      this.checkBox1.TabIndex = 40;
      this.checkBox1.Text = "Enable Smooth";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new System.Drawing.Point(22, 19);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(98, 17);
      this.checkBox2.TabIndex = 41;
      this.checkBox2.Text = "Enable Smooth";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.checkBox3);
      this.groupBox4.Controls.Add(this.label16);
      this.groupBox4.Controls.Add(this.textBox6);
      this.groupBox4.Location = new System.Drawing.Point(406, 18);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(189, 114);
      this.groupBox4.TabIndex = 42;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Median Smooth";
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Location = new System.Drawing.Point(22, 19);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(98, 17);
      this.checkBox3.TabIndex = 41;
      this.checkBox3.Text = "Enable Smooth";
      this.checkBox3.UseVisualStyleBackColor = true;
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(47, 48);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(30, 13);
      this.label16.TabIndex = 21;
      this.label16.Text = "Size:";
      // 
      // textBox6
      // 
      this.textBox6.Location = new System.Drawing.Point(83, 44);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(44, 20);
      this.textBox6.TabIndex = 26;
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.label17);
      this.groupBox5.Controls.Add(this.checkBox4);
      this.groupBox5.Controls.Add(this.textBox5);
      this.groupBox5.Controls.Add(this.label19);
      this.groupBox5.Controls.Add(this.label20);
      this.groupBox5.Controls.Add(this.textBox8);
      this.groupBox5.Controls.Add(this.textBox9);
      this.groupBox5.Location = new System.Drawing.Point(211, 138);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(189, 176);
      this.groupBox5.TabIndex = 40;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Bilateral Smooth";
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(21, 115);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(93, 13);
      this.label17.TabIndex = 27;
      this.label17.Text = "Coordinate Sigma:";
      // 
      // checkBox4
      // 
      this.checkBox4.AutoSize = true;
      this.checkBox4.Location = new System.Drawing.Point(19, 19);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new System.Drawing.Size(98, 17);
      this.checkBox4.TabIndex = 39;
      this.checkBox4.Text = "Enable Smooth";
      this.checkBox4.UseVisualStyleBackColor = true;
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(125, 110);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(44, 20);
      this.textBox5.TabIndex = 30;
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Location = new System.Drawing.Point(19, 56);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(63, 13);
      this.label19.TabIndex = 21;
      this.label19.Text = "Kernel Size:";
      // 
      // label20
      // 
      this.label20.AutoSize = true;
      this.label20.Location = new System.Drawing.Point(19, 84);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(66, 13);
      this.label20.TabIndex = 22;
      this.label20.Text = "Color Sigma:";
      // 
      // textBox8
      // 
      this.textBox8.Location = new System.Drawing.Point(125, 53);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new System.Drawing.Size(44, 20);
      this.textBox8.TabIndex = 26;
      // 
      // textBox9
      // 
      this.textBox9.Location = new System.Drawing.Point(125, 79);
      this.textBox9.Name = "textBox9";
      this.textBox9.Size = new System.Drawing.Size(44, 20);
      this.textBox9.TabIndex = 25;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.ClientSize = new System.Drawing.Size(1433, 856);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.imageBox4);
      this.Controls.Add(this.imageBox3);
      this.Controls.Add(this.imageBox2);
      this.Controls.Add(this.imageBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.hueMinTB)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.hueMaxTB)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.satMinTB)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.satMaxTB)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.valMinTB)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.valMaxTB)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private Emgu.CV.UI.ImageBox imageBox1;
    private System.Windows.Forms.TrackBar hueMinTB;
    private System.Windows.Forms.TrackBar hueMaxTB;
    private System.Windows.Forms.TrackBar satMinTB;
    private System.Windows.Forms.TrackBar satMaxTB;
    private System.Windows.Forms.TrackBar valMinTB;
    private System.Windows.Forms.TrackBar valMaxTB;
    private System.Windows.Forms.Label hueLB;
    private System.Windows.Forms.Label saturationLB;
    private System.Windows.Forms.Label valueLB;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private Emgu.CV.UI.ImageBox imageBox2;
    private Emgu.CV.UI.ImageBox imageBox3;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox erodeOffsetTB;
    private System.Windows.Forms.TextBox erodeDimensionTB;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox dilateOffsetTB;
    private System.Windows.Forms.TextBox dilateDimensionTB;
    private System.Windows.Forms.Label hueMinValLB;
    private System.Windows.Forms.Label hueMaxValLB;
    private System.Windows.Forms.Label satMinValLB;
    private System.Windows.Forms.Label valMinValLB;
    private System.Windows.Forms.Label valMaxValLB;
    private System.Windows.Forms.Label satMaxValLB;
    private Emgu.CV.UI.ImageBox imageBox4;
    private System.Windows.Forms.CheckBox getContoursCB;
    private System.Windows.Forms.CheckBox gausSmoothCB;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.TextBox gausSigmaXTB;
    private System.Windows.Forms.TextBox gausSigmaYTB;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox gausLengthTB;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.CheckBox checkBox4;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.TextBox textBox8;
    private System.Windows.Forms.TextBox textBox9;

  }
}

