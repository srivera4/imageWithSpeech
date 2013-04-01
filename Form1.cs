using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Speech.AudioFormat;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;



namespace imageWithSpeech
{
  public partial class Form1 : Form
  {
    Capture cap = new Capture();
    MemStorage storage = new MemStorage();

    Image<Bgr, Byte> image;
    Image<Bgr, Byte> colorSpectrumImage;
    Image<Gray, Byte> smoothedImage;
    Image<Gray, Byte> colorMaskedImage;

    int minHue, maxHue, minSat, maxSat, minVal, maxVal;
    int erodeDimension, erodeOffset;
    int dilateDimension, dilateOffset;
    int MAX_KERNEL_LENGTH =31;

    SpeechSynthesizer speaker = new SpeechSynthesizer();


    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      erodeDimensionTB.Text = "0";
      erodeOffsetTB.Text= "0";

      dilateDimensionTB.Text = "0";
      dilateOffsetTB.Text= "0";

      colorSpectrumImage = new Image<Bgr, byte>("triangulo_hsv.png");
      imageBox2.Image = colorSpectrumImage;
      Application.Idle += new EventHandler(frameGrabber);

        //  Image<Gray, Byte> redMask = GetRedPixelMask(Testing);

        //  imageBox1.Image = Testing;
        //  imageBox2.Image = redMask;

        //}
        //catch
        //{
        //  MessageBox.Show("what the fuck");
        //}

        //SpeechSynthesizer synth = new SpeechSynthesizer();

        //foreach (InstalledVoice voice in synth.GetInstalledVoices())
        //{
        //  VoiceInfo info = voice.VoiceInfo;
        //  string name = info.Name;
        //  string id = info.Id;
        //}

        //speaker.SelectVoice("Microsoft Anna");
        //speaker.Speak("Please Speak Clearly.");


        //Choices c = new Choices(new string[] { "Hi", "Bye" });
        //GrammarBuilder gb = new GrammarBuilder(c);
        //Grammar wordList = new Grammar(gb);

        ////SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        //SpeechRecognizer sr = new SpeechRecognizer();

        //wordList.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(wordList_SpeechRecognized);
        //sr.LoadGrammar(wordList);
        ////sre.SpeechRecognized += wordList_SpeechRecognized;

      }

    private void extractContours(Image<Gray, Byte> img)
    {
      Contour<Point> contours = img.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, storage);

      while (contours != null)
      {
        Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.0025, storage);
        image.Draw(currentContour, new Bgr(Color.LimeGreen), 2);
        contours = contours.HNext;
      }

    }

    private void frameGrabber(object sender, EventArgs e)
    {
      image = cap.QueryFrame();
      if (gausSmoothCB.Checked)
      {
        smoothImage();
      }
      colorMaskedImage = colorMask(image);
      imageBox3.Image = erodeDilateImage(colorMaskedImage);



      if (getContoursCB.Checked)
      {
        extractContours(colorMaskedImage);
        imageBox4.Image = image;
      }
    }
    
    private void smoothImage()
    {

      if (gausSmoothCB.Checked & gausLengthTB.Text != "" )
      {
        int gausLength = Convert.ToInt32(gausLengthTB.Text);
        int isGausInputOdd = gausLength % 2;

        if (gausLength != 0 & gausLength < MAX_KERNEL_LENGTH & isGausInputOdd != 0)
        {
          image = image.SmoothGaussian(gausLength, gausLength, 0, 0);   
        }
      }

    }

    private Image<Gray, Byte> erodeDilateImage(Image<Gray, Byte> img)
    {
      if (erodeDimensionTB.Text != "" & erodeDimensionTB.Text != "0" & erodeOffsetTB.Text != "" & erodeOffsetTB.Text != "0" )
      {
        erodeDimension = Convert.ToInt32(erodeDimensionTB.Text);
        erodeOffset = Convert.ToInt32(erodeOffsetTB.Text);

        //if (erodeDimension != 0 & erodeOffset != 0)
        //{
        if (erodeDimension > erodeOffset)
        {
          StructuringElementEx rectErode = new StructuringElementEx(erodeDimension, erodeDimension, erodeOffset, erodeOffset, Emgu.CV.CvEnum.CV_ELEMENT_SHAPE.CV_SHAPE_RECT);
          CvInvoke.cvErode(img, img, rectErode, 1);
        }
        //}
      }
      if (dilateDimensionTB.Text != "" & dilateDimensionTB.Text != "0" & dilateOffsetTB.Text != "" & dilateOffsetTB.Text != "0")
      {
        dilateDimension = Convert.ToInt32(dilateDimensionTB.Text);
        dilateOffset = Convert.ToInt32(dilateOffsetTB.Text);
        //if (dilateDimension != 0 & dilateOffset != 0)
        //{
        if (dilateDimension > dilateOffset)
        {
          StructuringElementEx rectDilate = new StructuringElementEx(dilateDimension, dilateDimension, dilateOffset, dilateOffset, Emgu.CV.CvEnum.CV_ELEMENT_SHAPE.CV_SHAPE_RECT);
          CvInvoke.cvDilate(img, img, rectDilate, 2);
        }
        //}
      }

      return img;
    }

    private Image<Gray,Byte> colorMask(Image<Bgr, Byte> bgrImage)
    {
      
      Image<Hsv, Byte> hsvImg = bgrImage.Convert<Hsv, Byte>();
      Image<Gray, Byte>[] channels = hsvImg.Split();
      Image<Gray, Byte> imghue = channels[0];            //hsv, so channels[0] is hue.
      Image<Gray, Byte> imgval = channels[2];            //hsv, so channels[2] is value.
      Image<Gray, Byte> imgsat = channels[1];            //hsv, so channels[1] is 

      minHue = hueMinTB.Value;
      maxHue = hueMaxTB.Value;
      minSat = satMinTB.Value;
      maxSat = satMaxTB.Value;
      minVal = valMinTB.Value;
      maxVal = valMaxTB.Value;

      //filter out all but "the color you want"...seems to be 0 to 128 ?
      Image<Gray, byte> huefilter = imghue.InRange(new Gray(minHue ), new Gray(maxHue ));
      Image<Gray, byte> satfilter = imgsat.InRange(new Gray(minSat ), new Gray(maxSat ));

      //use the value channel to filter out all but brighter colors
      //Image<Gray, byte> valfilter = imgval.InRange(new Gray(Color.Orange .GetBrightness() - 5), new Gray(Color.Orange .GetBrightness() + 5));
      Image<Gray, byte> valfilter = imgval.InRange(new Gray(minVal ), new Gray(maxVal));

      //now and the two to get the parts of the imaged that are colored and above some brightness.
      Image<Gray, byte> detimg = huefilter.And(valfilter).And(satfilter);
      return detimg;


    }

    private void wordList_SpeechRecognized(object sender, RecognitionEventArgs e)
    {
      if (e.Result.Confidence >= 0.7)
      {
        if (e.Result.Text == "Hi")
        {
          speaker.Speak("Hi");
        }
      }
      else
      {

      }
    }
    private static Image<Gray, Byte> GetRedPixelMask(Image<Bgr, byte> image)
    {
      using (Image<Hsv, Byte> hsv = image.Convert<Hsv, Byte>())
      {
        Image<Gray, Byte>[] channels = hsv.Split();

        try
        {
          //channels[0] is the mask for hue less than 20 or larger than 160
          CvInvoke.cvInRangeS(channels[0], new MCvScalar(20), new MCvScalar(160), channels[0]);
          channels[0]._Not();

          //channels[1] is the mask for satuation of at least 10, this is mainly used to filter out white pixels
          channels[1]._ThresholdBinary(new Gray(10), new Gray(255.0));
          CvInvoke.cvAnd(channels[0], channels[1], channels[0], IntPtr.Zero);
        }
        finally
        {
          channels[1].Dispose();
          channels[2].Dispose();
        }
        return channels[0];
      }
    }

    private void hueMinTB_Scroll(object sender, EventArgs e)
    {
     Image<Gray,Byte> grayImage= colorMask(colorSpectrumImage);
     imageBox1.Image = grayImage;
     hueMinValLB.Text = hueMinTB.Value.ToString();
    }

    private void hueMaxTB_Scroll(object sender, EventArgs e)
    {
      Image<Gray, Byte> grayImage = colorMask(colorSpectrumImage);
      imageBox1.Image = grayImage;
      hueMaxValLB.Text = hueMaxTB.Value.ToString();
    }

    private void satMinTB_Scroll(object sender, EventArgs e)
    {
      Image<Gray, Byte> grayImage = colorMask(colorSpectrumImage);
      imageBox1.Image = grayImage;
      satMinValLB.Text = satMinTB.Value.ToString();
    }

    private void satMaxTB_Scroll(object sender, EventArgs e)
    {
      Image<Gray, Byte> grayImage = colorMask(colorSpectrumImage);
      imageBox1.Image = grayImage;
      satMaxValLB.Text = satMaxTB.Value.ToString();
    }

    private void valMinTB_Scroll(object sender, EventArgs e)
    {
      Image<Gray, Byte> grayImage = colorMask(colorSpectrumImage);
      imageBox1.Image = grayImage;
      valMinValLB.Text = valMinTB.Value.ToString();
    }

    private void valMaxTB_Scroll(object sender, EventArgs e)
    {
      Image<Gray, Byte> grayImage = colorMask(colorSpectrumImage);
      imageBox1.Image = grayImage;
      valMaxValLB.Text = valMaxTB.Value.ToString();
    }
  }
}
