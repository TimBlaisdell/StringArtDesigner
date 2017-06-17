using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace StringArtDesigner {
    public partial class ImagePanel : UserControl {
        public ImagePanel() {
            InitializeComponent();
            // Set the value of the double-buffering style bits to true.
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint | ControlStyles.ResizeRedraw |
                          ControlStyles.UserPaint | ControlStyles.DoubleBuffer,
                          true);
        }
        public Size CanvasSize {
            get { return _canvasSize; }
            set {
                _canvasSize = value;
                displayScrollbar();
                setScrollbarValues();
                Invalidate();
            }
        }
        public Bitmap Image {
            get { return _image; }
            set {
                _image = value;
                displayScrollbar();
                setScrollbarValues();
                Invalidate();
            }
        }
        public InterpolationMode InterpolationMode { get; set; } = InterpolationMode.HighQualityBilinear;
        public float Zoom {
            get { return _zoom; }
            set {
                if (value < 0.001f) value = 0.001f;
                _zoom = value;
                displayScrollbar();
                setScrollbarValues();
                Invalidate();
            }
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e) {
            Invalidate();
        }
        protected override void OnLoad(EventArgs e) {
            displayScrollbar();
            setScrollbarValues();
            base.OnLoad(e);
        }
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            //draw image
            if (_image != null) {
                Point pt = new Point((int) (hScrollBar1.Value / _zoom), (int) (vScrollBar1.Value / _zoom));
                var srcRect = _canvasSize.Width * _zoom < _viewRectWidth && _canvasSize.Height * _zoom < _viewRectHeight
                    ? new Rectangle(0, 0, _canvasSize.Width, _canvasSize.Height)
                    : new Rectangle(pt, new Size((int) (_viewRectWidth / _zoom), (int) (_viewRectHeight / _zoom)));
                var distRect = new Rectangle(-srcRect.Width / 2, -srcRect.Height / 2, srcRect.Width, srcRect.Height);
                Matrix mx = new Matrix(); // create an identity matrix
                mx.Scale(_zoom, _zoom); // zoom image
                mx.Translate(_viewRectWidth / 2.0f, _viewRectHeight / 2.0f, MatrixOrder.Append); // move image to view window center
                using (var g = e.Graphics) {
                    g.InterpolationMode = InterpolationMode;
                    g.Transform = mx;
                    g.DrawImage(_image, distRect, srcRect, GraphicsUnit.Pixel);
                }
            }
        }
        protected override void OnResize(EventArgs e) {
            displayScrollbar();
            setScrollbarValues();
            base.OnResize(e);
        }
        private void displayScrollbar() {
            _viewRectWidth = Width;
            _viewRectHeight = Height;
            if (_image != null) _canvasSize = _image.Size;
            // If the zoomed image is wider than view window, show the HScrollBar and adjust the view window
            if (_viewRectWidth > _canvasSize.Width * _zoom) {
                hScrollBar1.Visible = false;
                _viewRectHeight = Height;
            }
            else {
                hScrollBar1.Visible = true;
                _viewRectHeight = Height - hScrollBar1.Height;
            }
            // If the zoomed image is taller than view window, show the VScrollBar and adjust the view window
            if (_viewRectHeight > _canvasSize.Height * _zoom) {
                vScrollBar1.Visible = false;
                _viewRectWidth = Width;
            }
            else {
                vScrollBar1.Visible = true;
                _viewRectWidth = Width - vScrollBar1.Width;
            }
            // Set up scrollbars
            hScrollBar1.Location = new Point(0, Height - hScrollBar1.Height);
            hScrollBar1.Width = _viewRectWidth;
            vScrollBar1.Location = new Point(Width - vScrollBar1.Width, 0);
            vScrollBar1.Height = _viewRectHeight;
        }
        private void setScrollbarValues() {
            // Set the Maximum, Minimum, LargeChange and SmallChange properties.
            vScrollBar1.Minimum = 0;
            hScrollBar1.Minimum = 0;
            // If the offset does not make the Maximum less than zero, set its value. 
            if ((_canvasSize.Width * _zoom - _viewRectWidth) > 0) {
                hScrollBar1.Maximum = (int) (_canvasSize.Width * _zoom) - _viewRectWidth;
            }
            // If the VScrollBar is visible, adjust the Maximum of the 
            // HSCrollBar to account for the width of the VScrollBar.  
            if (vScrollBar1.Visible) {
                hScrollBar1.Maximum += vScrollBar1.Width;
            }
            hScrollBar1.LargeChange = hScrollBar1.Maximum / 10;
            hScrollBar1.SmallChange = hScrollBar1.Maximum / 20;
            // Adjust the Maximum value to make the raw Maximum value 
            // attainable by user interaction.
            hScrollBar1.Maximum += hScrollBar1.LargeChange;
            // If the offset does not make the Maximum less than zero, set its value.    
            if ((_canvasSize.Height * _zoom - _viewRectHeight) > 0) {
                vScrollBar1.Maximum = (int) (_canvasSize.Height * _zoom) - _viewRectHeight;
            }
            // If the HScrollBar is visible, adjust the Maximum of the 
            // VSCrollBar to account for the width of the HScrollBar.
            if (hScrollBar1.Visible) {
                vScrollBar1.Maximum += hScrollBar1.Height;
            }
            vScrollBar1.LargeChange = vScrollBar1.Maximum / 10;
            vScrollBar1.SmallChange = vScrollBar1.Maximum / 20;
            // Adjust the Maximum value to make the raw Maximum value 
            // attainable by user interaction.
            vScrollBar1.Maximum += vScrollBar1.LargeChange;
        }
        private Size _canvasSize = new Size(60, 40);
        private Bitmap _image;
        private int _viewRectWidth, _viewRectHeight; // view window width and height
        private float _zoom = 1.0f;
    }
}