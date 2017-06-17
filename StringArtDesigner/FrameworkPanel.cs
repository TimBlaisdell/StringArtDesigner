using System;
using System.Drawing;
using System.Windows.Forms;

namespace StringArtDesigner {
    public partial class FrameworkPanel : UserControl, IPanel {
        public FrameworkPanel() {
            InitializeComponent();
            _workArea = new Rectangle(menuStrip1.Right, 0, Width - menuStrip1.Width, Height);
            FrameworkSize = new Size(1000, 1000);
        }
        public Size FrameworkSize {
            get { return _frameworkSize; }
            set {
                _frameworkSize = value;
                numWidth.Value = value.Width;
                numHeight.Value = value.Height;
                _frameworkImage = new Bitmap(_frameworkSize.Width, _frameworkSize.Height);
            }
        }
        public int Index { get; set; }
        public string Title => "Framework";
        private void numHeight_ValueChanged(object sender, EventArgs e) {
            FrameworkSize = new Size(_frameworkSize.Width, (int) numHeight.Value);
        }
        private void numWidth_ValueChanged(object sender, EventArgs e) {
            FrameworkSize = new Size((int) numWidth.Value, _frameworkSize.Height);
        }
        private void sizeToolStripMenuItem_Click(object sender, EventArgs e) {
            panelPropertiesSize.Location = _workArea.Location;
            panelPropertiesSize.Visible = true;
        }
        private Bitmap _frameworkImage;
        private Size _frameworkSize;
        private Rectangle _workArea;

        private void label4_Click(object sender, EventArgs e) {
            panelPropertiesSize.Visible = false;
        }
    }
}