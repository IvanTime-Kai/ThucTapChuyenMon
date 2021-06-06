using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace dental_sys
{
    public partial class frm_NhanDienKhuonMat : Form
    {
        #region Variables
        private Capture videoCapture = null; // Capture images from either camera or video file
        private Image<Bgr, Byte> currentFrame = null; // Bgr: Defines a Bgr(BlueGreenRed) color
        Mat frame = new Mat(); // Mat: matrix in cv::Mats
        CascadeClassifier faceCascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml"); // tạo ra 1 lớp để detect đối tượng

        bool isWarned = false;
        #endregion
        public frm_NhanDienKhuonMat()
        {
            InitializeComponent();
        }

        private void frm_NhanDienKhuonMat_Load(object sender, EventArgs e)
        {
            videoCapture = new Capture();
            videoCapture.ImageGrabbed += ProcessFrame; // ImageGrabbed: the event to be called when an image is grabbed
            videoCapture.Start(); // bắt đầu quá trình chụp ảnh, mỗi khi chụp đc 1 bức ảnh(grabbed a image) nó sẽ gọi callback ProcessFrame để đưa tấm ảnh lên PictureBox -> video captures
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            videoCapture.Retrieve(frame, 0); // Retrieve a gray image frame after Grab
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic); // convert this Mat to Image

            Mat grayImage = new Mat();
            CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray); // CvInvoke : library to invoke OpenCV functions (thự viện để gọi các hàm của OpenCV), CvtColor: chuyển đổi hình ảnh đầu vào từ hình ảnh màu này sang hình ảnh màu khác, Bgr2Gray: BlackGreenRed to Gray
            CvInvoke.EqualizeHist(grayImage, grayImage); // the algorithm normalize brightness and increases contrast of image (thuật toán bình thường hóa độ sáng và tăng độ tương phản của hình ảnh)

            Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty); // Detects objects of different sizes in the input image. The detected objects are returned as a list of rectangles. (Phát hiện các đối tượng có kích thước khác nhau trong hình ảnh đầu vào. Các đối tượng được phát hiện được trả về dưới dạng danh sách các hình chữ nhật.)
                                                                                                                   //if faces detected
            if (faces.Length > 0)
            {
                foreach (var face in faces)
                {
                    // Draw square around each face
                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2); // Vẽ cái hình chữ nhật (face) màu đỏ lên cái hình hiện tại currentFrame
                    Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                    resultImage.ROI = face;
                }

                if (faces.Length >= 2)
                {
                    if (isWarned == false)
                    {
                        MessageBox.Show("Mật khẩu của bạn có thẻ bị xem lén!", "Cảnh báo");
                        if (this.InvokeRequired)
                        {
                            this.Invoke(new MethodInvoker(delegate
                            {
                                this.Show();
                            }));
                        }
                        isWarned = true;
                    }
                }
            }


            //Render the video capture into the Picture Box picCapture
            picCapture.Image = currentFrame.Bitmap;
        }

        private void frm_NhanDienKhuonMat_FormClosed(object sender, FormClosedEventArgs e)
        {
            videoCapture.Dispose();
        }
    }
}
