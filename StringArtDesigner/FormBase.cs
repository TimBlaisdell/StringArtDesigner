using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StringArtDesigner {
    public partial class FormBase : Form {
        public FormBase() {
            InitializeComponent();
            BorderWidth = _borderWidth;
            _nextstepGap = btnNextStep.Left - lblNextStep.Right;
        }
        public Color BorderColor {
            get { return _borderColor; }
            set {
                _borderColor = value;
                Invalidate();
            }
        }
        public int BorderWidth {
            get { return _borderWidth; }
            set {
                _borderWidth = value;
                panelWindowTitle.Location = new Point(_borderWidth, _borderWidth);
                panelWindowTitle.Size = new Size(Width - _borderWidth * 2, 20);
                panelNavigation.Location = new Point(_borderWidth, panelNavigation.Location.Y);
                panelNavigation.Size = new Size(Width - _borderWidth * 2, panelNavigation.Height);
                Invalidate();
            }
        }
        public override string Text {
            get { return _text; }
            set {
                _text = value;
                this.BeginInvokeIfRequired(() => lblTitle.Text = _text);
            }
        }
        private void btnNextStep_Click(object sender, EventArgs e) {
        }
        private void btnNextStep_SizeChanged(object sender, EventArgs e) {
            btnNextStep.Location = new Point(panelNavigation.Width - btnNextStep.Width, btnNextStep.Top);
        }
        private void btnNextStep_VisibleChanged(object sender, EventArgs e) {
            lblNextStep.Visible = btnNextStep.Visible;
        }
        private void btnPrevStep_VisibleChanged(object sender, EventArgs e) {
            lblPrevStep.Visible = btnPrevStep.Visible;
        }
        private void lblClose_Click(object sender, EventArgs e) {
            Close();
        }
        private void lblNextStep_SizeChanged(object sender, EventArgs e) {
            lblNextStep.Left = btnNextStep.Left - (_nextstepGap + lblNextStep.Width);
        }
        private void lblTitle_MouseDoubleClick(object sender, MouseEventArgs e) {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            Invalidate();
        }
        private void lblTitle_MouseDown(object sender, MouseEventArgs e) {
            _moving = true;
            _lastMousePos = MousePosition;
        }
        private void lblTitle_MouseMove(object sender, MouseEventArgs e) {
            if (_moving) {
                Point newpos = MousePosition;
                Point diff = new Point(newpos.X - _lastMousePos.X, newpos.Y - _lastMousePos.Y);
                _lastMousePos = newpos;
                Location = new Point(Location.X + diff.X, Location.Y + diff.Y);
            }
        }
        private void lblTitle_MouseUp(object sender, MouseEventArgs e) {
            _moving = false;
        }
        private void panelNavigation_SizeChanged(object sender, EventArgs e) {
            btnNextStep.Left = panelNavigation.Width - (btnNextStep.Width + 2);
            lblNextStep.Left = btnNextStep.Left - (_nextstepGap + lblNextStep.Width);
        }
        private void panelWindowTitle_SizeChanged(object sender, EventArgs e) {
            lblClose.Left = panelWindowTitle.Width - lblClose.Width;
            lblTitle.Width = panelWindowTitle.Width - lblClose.Width;
        }
        protected void MakeCurrent(int i) {
            if (i < 0 || i >= _panels.Count) throw new Exception("Should never happen");
            _currentPanelIndex = i;
            foreach (var p in _panels) p.Visible = false;
            var panel = _panels[i];
            panel.Location = new Point(_borderWidth, panelNavigation.Bottom);
            panel.Size = new Size(Width - _borderWidth * 2, Height - (panelNavigation.Bottom + _borderWidth));
            lblCurrentStep.Text = panel.Title;
            btnPrevStep.Visible = i > 0;
            btnNextStep.Visible = i < _panels.Count - 1;
            if (i < _panels.Count - 1) lblNextStep.Text = _panels[i + 1].Title;
            if (i > 0) lblPrevStep.Text = _panels[i - 1].Title;
            panel.Visible = true;
        }
        protected override void OnControlAdded(ControlEventArgs e) {
            base.OnControlAdded(e);
            if (e.Control is IPanel) {
                _panels.Add((IPanel) e.Control);
                _panels.Sort((p1, p2) => p1.Index < p2.Index ? -1 : p1.Index == p2.Index ? 0 : 1);
            }
        }
        protected override void OnControlRemoved(ControlEventArgs e) {
            base.OnControlRemoved(e);
            var c = _panels.FirstOrDefault(p => ReferenceEquals(p, e.Control));
            if (c != null) _panels.Remove(c);
        }
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(new Pen(BorderColor, BorderWidth), _borderWidth / 2, _borderWidth / 2, Width - _borderWidth, Height - _borderWidth);
        }
        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            if (_panels.Count > 0) {
                MakeCurrent(0);
            }
        }
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            panelNavigation.Width = Width - _borderWidth * 2;
            panelWindowTitle.Width = panelNavigation.Width;
            if (_currentPanelIndex < _panels.Count) {
                var panel = _panels[_currentPanelIndex];
                panel.Size = new Size(panelNavigation.Width, Height - (panelNavigation.Bottom + _borderWidth));
            }
        }
        private Color _borderColor = Color.Black;
        private int _borderWidth = 2;
        private int _currentPanelIndex;
        private Point _lastMousePos;
        private bool _moving;
        private readonly int _nextstepGap;
        private readonly List<IPanel> _panels = new List<IPanel>();
        private string _text = "Title";
    }
}