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
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;

namespace TesteAcessoCamera
{
    public partial class Form1 : Form
    {
        private Capture _capture = null;
        private bool _salvar = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            // Normal, sem efeitos
            Mat frame = new Mat();
            _capture.Retrieve(frame, 0);
            CamImageBox.Image = frame;

            // Somente as linhas
            Mat grayFrame = new Mat();
            CvInvoke.Canny(frame, grayFrame, 100, 60);
            CamImageBox.Image = grayFrame;

            if (_salvar)
            {
                frame.Save(@"captura.jpg");
                _salvar = false;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CvInvoke.UseOpenCL = false;
            try
            {
                _capture = new Capture();

                // Vira a captura verticalmente
                //_capture.FlipVertical = _capture.FlipHorizontal = !_capture.FlipHorizontal;

                // Vira a captura horizontalmente
                //_capture.FlipVertical = _capture.FlipVertical = !_capture.FlipVertical;

                _capture.ImageGrabbed += ProcessFrame;
                Application.Idle += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            _capture.ImageGrabbed -= ProcessFrame;
            Application.Idle -= ProcessFrame;
            _capture = null;
            CamImageBox.Image = null;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _salvar = true;
        }
    }
}

// :::::::::::::::::::::::::::::::::::::::::::
// Artigo completo em
// http://www.fabricioleite.com.br/artigo/item/primeiros_passos_com_opencv_e_emgu_-_acessando_a_webcam
// por Fabricio Leite
// :::::::::::::::::::::::::::::::::::::::::::