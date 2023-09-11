using OpenCvSharp;
using DirectShowLib;
using System.ComponentModel;
using System.Text.RegularExpressions;
using OpenCvSharp.Extensions;

namespace WinForms_02
{
    public partial class FormVideoCapture : Form
    {
        public VideoCapture captureDev;
        private const int frameUpdatesPerSec = 60;
        public FormVideoCapture()
        {
            InitializeComponent();

            captureDev = new VideoCapture();
        }

        public Bitmap CaptureFrame()
        {
            using (var mat = captureDev.RetrieveMat())
            {
                var frameBitmap = BitmapConverter.ToBitmap(mat);
                return frameBitmap;
            }
        }

        public void StartCapture()
        {
            if (comboDevice.SelectedItem is not CameraDevice selectedItem)
                return;

            var index = selectedItem.OpenCvId; // just to esacpe error. selectedItem is NOT NULL.

            if (!captureDev.Open(index, VideoCaptureAPIs.DSHOW)) // just to esacpe error. index is NOT NULL.
            {
                MessageBox.Show($"Unable to open camera {selectedItem.Name ?? "Unknown"}.");
                return;
            }

            btnStart.Text = "Stop";

            bgwRender.RunWorkerAsync();
        }

        public void StopCapture()
        {
            bgwRender.CancelAsync();
            captureDev.Release();
            picPreview.Image?.Dispose();
            picPreview.Image = null;
            picPreview.Invalidate();
            btnStart.Text = "Start";
        }

        public void FormVideoCapture_Load(object sender, EventArgs e)
        {
            // initialize combo box
            var dataSource = CameraDevicesEnumerator.GetAllConnectedCameras();
            comboDevice.DataSource = dataSource;
            comboDevice.DisplayMember = "Name";
            comboDevice.ValueMember = "OpenCvId";
            comboDevice.SelectedIndex = 0;
        }

        private void bgwRender_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (!worker.CancellationPending)
            {
                worker.ReportProgress(0, CaptureFrame());

                Thread.Sleep(1000 / frameUpdatesPerSec);
            }
        }

        private void bgwRender_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            Bitmap bitmap = e.UserState as Bitmap;
            // clear previous image
            picPreview.Image?.Dispose();
            picPreview.Image = bitmap;
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            if (captureDev.IsOpened())
                StartCapture();
            else
                StopCapture();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = CaptureFrame();
            // clear previous image
            picCaptured.Image?.Dispose();
            picCaptured.Image = bitmap;
            labelSavedImage.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var picturesDir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            var finalPath = $@"{picturesDir}\Capture_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.jpg";
            picCaptured.Image.Save(finalPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            labelSavedImage.Text = $"Saved to {finalPath}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            picCaptured.Image?.Dispose();
            picCaptured.Image = null;
            picCaptured.Invalidate();
            labelSavedImage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormVideoCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            bgwRender.CancelAsync();
            captureDev.Dispose();
        }

    }
}
