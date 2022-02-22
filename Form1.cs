using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSV_Detection
{
    public partial class Form1 : Form
    {
        private VideoCapture _capture;
        private Thread _captureThread;
        private int hMin = 0;
        private int hMax = 179;
        private int sMin = 0;
        private int sMax = 255;
        private int vMin = 0;
        private int vMax = 255;
        private int _threshold = 150;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _capture = new VideoCapture(1);
            _captureThread = new Thread(DisplayWebcam);
            _captureThread.Start();
            thresholdTrackBar.Value = _threshold;
            hUpperBar.Value = hMin;
            hLowerBar.Value = hMax;
            sUpperBar.Value = sMin;
            sLowerBar.Value = sMax;
            vUpperBar.Value = vMin;
            vLowerBar.Value = vMax;

        }

        private void DisplayWebcam()
        {
            while (_capture.IsOpened)
            {
                Mat frame = _capture.QueryFrame();

                // resize to Image aspect ratio
                int newHeight = (frame.Size.Height * sourceImage.Size.Width) / frame.Size.Width;
                Size newSize = new Size(sourceImage.Size.Width, newHeight);
                CvInvoke.Resize(frame, frame, newSize);

                // display the image in the sourceImage box
                // Invoke(new Action(() => { sourceImage.Image = frame.Bitmap; }));
                sourceImage.Image = frame.Bitmap;

                Mat grayFrame = new Mat();
                Mat binaryFrame = new Mat();
                CvInvoke.CvtColor(frame, grayFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                CvInvoke.Threshold(grayFrame, binaryFrame, _threshold, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

                binaryPictureBox.Image = binaryFrame.Bitmap;

                // custom box /////////////////////////////////////////////////////////////////////////////////////
                // convert the image to an HSV image
                Mat hsvFrame = new Mat();
                CvInvoke.CvtColor(frame, hsvFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);

                // split the HSV image into an arrary of Mat Objects, one per channel:
                Mat[] hsvChannels = hsvFrame.Split();

                // filter out all but the "color you want"?
                Mat hueFilter = new Mat();
                CvInvoke.InRange(hsvChannels[0], new ScalarArray(hMin), new ScalarArray(hMax), hueFilter);
                Invoke(new Action(() => { hPictureBox.Image = hueFilter.Bitmap; }));

                Mat saturationFilter = new Mat();
                CvInvoke.InRange(hsvChannels[1], new ScalarArray(sMin), new ScalarArray(sMax), saturationFilter);
                Invoke(new Action(() => { sPictureBox.Image = saturationFilter.Bitmap; }));

                Mat valueFilter = new Mat();
                CvInvoke.InRange(hsvChannels[2], new ScalarArray(vMin), new ScalarArray(vMax), valueFilter);
                Invoke(new Action(() => { vPictureBox.Image = valueFilter.Bitmap; }));

                // combine the filters together
                Mat mergedImage = new Mat();
                CvInvoke.BitwiseAnd(hueFilter, saturationFilter, mergedImage);
                CvInvoke.BitwiseAnd(mergedImage, valueFilter, mergedImage);
                Invoke(new Action(() => { custom.Image = mergedImage.Bitmap; }));


                // Red Line ////////////////////////////////////////////////////////////////////////////
                Mat[] hsvChannelsRed = hsvFrame.Split();

                Mat hueFilterRed = new Mat();
                CvInvoke.InRange(hsvChannels[0], new ScalarArray(0), new ScalarArray(40), hueFilterRed);                

                Mat saturationFilterRed = new Mat();
                CvInvoke.InRange(hsvChannels[1], new ScalarArray(150), new ScalarArray(200), saturationFilterRed);
                
                Mat valueFilterRed = new Mat();
                CvInvoke.InRange(hsvChannels[2], new ScalarArray(110), new ScalarArray(255), valueFilterRed);
      
                Mat mergedImageRed = new Mat();
                CvInvoke.BitwiseAnd(hueFilterRed, saturationFilterRed, mergedImageRed);
                CvInvoke.BitwiseAnd(mergedImageRed, valueFilterRed, mergedImageRed);
                Invoke(new Action(() => { redLine.Image = mergedImageRed.Bitmap; }));

                int bottomHalf = frame.Height / 2;


                // Yellow Line //////////////////////////////////////////////////////////////////////////
                Mat[] hsvChannelsYellow = hsvFrame.Split();
             
                Mat hueFilterYellow = new Mat();
                CvInvoke.InRange(hsvChannels[0], new ScalarArray(17), new ScalarArray(33), hueFilterYellow);
                
                Mat saturationFilterYellow = new Mat();
                CvInvoke.InRange(hsvChannels[1], new ScalarArray(93), new ScalarArray(255), saturationFilterYellow);
               
                Mat valueFilterYellow = new Mat();
                CvInvoke.InRange(hsvChannels[2], new ScalarArray(151), new ScalarArray(255), valueFilterYellow);
             
                Mat mergedImageYellow = new Mat();
                CvInvoke.BitwiseAnd(hueFilterYellow, saturationFilterYellow, mergedImageYellow);
                CvInvoke.BitwiseAnd(mergedImageYellow, valueFilterYellow, mergedImageYellow);
                Invoke(new Action(() => { yellowLine.Image = mergedImageYellow.Bitmap; }));

                ///////////////////////////////////////////////////////////////////////////////////

                //Pixel count on the custom, yellow, and red pictures 
                int CIP = 0;
                int YIP = 0;
                int RIP = 0;  
                Image<Gray, byte> customImage = mergedImage.ToImage<Gray, byte>();
                Image<Gray, byte> yellowImage = mergedImageYellow.ToImage<Gray, byte>();
                Image<Gray, byte> redImage = mergedImageRed.ToImage<Gray, byte>();

                for (int y = 0; y < mergedImage.Height; y++)
                {
                    for (int x = 0; x < mergedImage.Width; x++)
                    {
                        //Custom Pixel counter
                        if (customImage.Data[y, x, 0] == 255)
                        {
                            CIP++;
                        }

                        //Yellow Pixel counter
                        if (yellowImage.Data[y, x, 0] == 255)
                        {
                            YIP++;
                        }

                        //Red Pixel counter
                        if (redImage.Data[y, x, 0] == 255)
                        {
                            RIP++;
                        }
                    }
                }

                // Write the number of pixels to the screen
                Invoke(new Action(() => 
                {
                    customPixels.Text = $"{CIP}";
                    yellowPixels.Text = $"{YIP}";
                    redPixels.Text = $"{RIP}";

                }));

                // Write the tracker bar values to the screen
                Invoke(new Action(() =>
                {
                    hMn.Text = $"{hMin}";
                    hMx.Text = $"{hMax}";
                    sMn.Text = $"{sMin}";
                    sMx.Text = $"{sMax}";
                    vMn.Text = $"{vMin}";
                    vMx.Text = $"{vMax}";
                }));

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _captureThread.Abort();
        }

        private void thresholdTrackBar_Scroll(object sender, EventArgs e)
        {
            _threshold = thresholdTrackBar.Value;
        }

        private void hUpperBar_Scroll(object sender, EventArgs e)
        {
            hMin = hUpperBar.Value; 
        }

        private void hLowerBar_Scroll(object sender, EventArgs e)
        {
            hMax = hLowerBar.Value;
        }

        private void sUpperBar_Scroll(object sender, EventArgs e)
        {
            sMin = sUpperBar.Value;
        }

        private void sLowerBar_Scroll(object sender, EventArgs e)
        {
            sMax = sLowerBar.Value;
        }

        private void vUpperBar_Scroll(object sender, EventArgs e)
        {
            vMin = vUpperBar.Value;
        }

        private void vLowerBar_Scroll(object sender, EventArgs e)
        {
            vMax = vLowerBar.Value;
        }

    }
}
