namespace WinFormsApp1.Elements
{
        class CustomTextBox : TextBox
        {
            public event EventHandler CueTextChanged;
            private string _cueText;
            public string CueText
            {
                get { return _cueText; }
                set
                {
                    value = value ?? string.Empty;
                    if (value != _cueText)
                    {
                        _cueText = value;
                        OnCueTextChanged(EventArgs.Empty);
                    }
                }
            }
            public CustomTextBox()
                : base()
            {
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);
            BackColor = Color.Transparent;
            _cueText = string.Empty;
            }
            protected virtual void OnCueTextChanged(EventArgs e)
            {
                this.Invalidate(true);
                if (this.CueTextChanged != null)
                    this.CueTextChanged(this, e);
            }
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                if (string.IsNullOrEmpty(this.Text.Trim()) && !string.IsNullOrEmpty(this.CueText) && !this.Focused)
                {
                    Point startingPoint = new Point(0, 0);
                    StringFormat format = new StringFormat();
                    Font font = new Font(this.Font.FontFamily.Name, this.Font.Size, FontStyle.Italic);
                    if (this.RightToLeft == RightToLeft.Yes)
                    {
                        format.LineAlignment = StringAlignment.Far;
                        format.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                    }
                Brush brush = new SolidBrush(this.ForeColor);
                e.Graphics.DrawString(CueText, font, brush, this.ClientRectangle, format);
                }
            }
            const int WM_PAINT = 0x000F;
            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);
                if (m.Msg == WM_PAINT)
                {
                    this.OnPaint(new PaintEventArgs(Graphics.FromHwnd(m.HWnd), this.ClientRectangle));
                }
            }
        }
}
