using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

public class CustomFlatComboBox : ComboBox
{
    private Color borderColor = Color.Gray;
    [DefaultValue(typeof(Color), "Gray")]
    public Color BorderColor
    {
        get { return borderColor; }
        set
        {
            if (borderColor != value)
            {
                borderColor = value;
                Invalidate();
            }
        }
    }
    private Color buttonColor = Color.LightGray;
    [DefaultValue(typeof(Color), "LightGray")]
    public Color ButtonColor
    {
        get { return buttonColor; }
        set
        {
            if (buttonColor != value)
            {
                buttonColor = value;
                Invalidate();
            }
        }
    }
    protected override void WndProc(ref Message m)
    {
        if (m.Msg == WM_PAINT && DropDownStyle != ComboBoxStyle.Simple)
        {
            var clientRect = ClientRectangle;
            var dropDownButtonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
            var outerBorder = new Rectangle(clientRect.Location,
                new Size(clientRect.Width - 1, clientRect.Height - 1));
            var innerBorder = new Rectangle(outerBorder.X + 1, outerBorder.Y + 1,
                outerBorder.Width - dropDownButtonWidth - 2, outerBorder.Height - 2);
            var innerInnerBorder = new Rectangle(innerBorder.X + 1, innerBorder.Y + 1,
                innerBorder.Width - 2, innerBorder.Height - 2);
            var dropDownRect = new Rectangle(innerBorder.Right + 1, innerBorder.Y,
                dropDownButtonWidth, innerBorder.Height + 1);
            if (RightToLeft == RightToLeft.Yes)
            {
                innerBorder.X = clientRect.Width - innerBorder.Right;
                innerInnerBorder.X = clientRect.Width - innerInnerBorder.Right;
                dropDownRect.X = clientRect.Width - dropDownRect.Right;
                dropDownRect.Width += 1;
            }
            var innerBorderColor = Enabled ? BackColor : SystemColors.Control;
            var outerBorderColor = Enabled ? BorderColor : SystemColors.ControlDark;
            var buttonColor = Enabled ? ButtonColor : SystemColors.Control;
            var middle = new Point(dropDownRect.Left + dropDownRect.Width / 2,
                dropDownRect.Top + dropDownRect.Height / 2);
            var arrow = new Point[]
            {
                new Point(middle.X - 3, middle.Y - 2),
                new Point(middle.X + 4, middle.Y - 2),
                new Point(middle.X, middle.Y + 2)
            };
            var ps = new PAINTSTRUCT();
            bool shoulEndPaint = false;
            IntPtr dc;
            if (m.WParam == IntPtr.Zero)
            {
                dc = BeginPaint(Handle, ref ps);
                m.WParam = dc;
                shoulEndPaint = true;
            }
            else
            {
                dc = m.WParam;
            }
            var rgn = CreateRectRgn(innerInnerBorder.Left, innerInnerBorder.Top,
                innerInnerBorder.Right, innerInnerBorder.Bottom);
            SelectClipRgn(dc, rgn);
            DefWndProc(ref m);
            DeleteObject(rgn);
            rgn = CreateRectRgn(clientRect.Left, clientRect.Top,
                clientRect.Right, clientRect.Bottom);
            SelectClipRgn(dc, rgn);
            using (var g = Graphics.FromHdc(dc))
            {
                using (var b = new SolidBrush(buttonColor))
                {
                    g.FillRectangle(b, dropDownRect);
                }
                using (var b = new SolidBrush(outerBorderColor))
                {
                    g.FillPolygon(b, arrow);
                }
                using (var p = new Pen(innerBorderColor))
                {
                    g.DrawRectangle(p, innerBorder);
                    g.DrawRectangle(p, innerInnerBorder);
                }
                using (var p = new Pen(outerBorderColor))
                {
                    g.DrawRectangle(p, outerBorder);
                }
            }
            if (shoulEndPaint)
                EndPaint(Handle, ref ps);
            DeleteObject(rgn);
        }
        else
            base.WndProc(ref m);
    }

    private const int WM_PAINT = 0xF;
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int L, T, R, B;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct PAINTSTRUCT
    {
        public IntPtr hdc;
        public bool fErase;
        public int rcPaint_left;
        public int rcPaint_top;
        public int rcPaint_right;
        public int rcPaint_bottom;
        public bool fRestore;
        public bool fIncUpdate;
        public int reserved1;
        public int reserved2;
        public int reserved3;
        public int reserved4;
        public int reserved5;
        public int reserved6;
        public int reserved7;
        public int reserved8;
    }
    [DllImport("user32.dll")]
    private static extern IntPtr BeginPaint(IntPtr hWnd,
        [In, Out] ref PAINTSTRUCT lpPaint);

    [DllImport("user32.dll")]
    private static extern bool EndPaint(IntPtr hWnd, ref PAINTSTRUCT lpPaint);

    [DllImport("gdi32.dll")]
    public static extern int SelectClipRgn(IntPtr hDC, IntPtr hRgn);

    [DllImport("user32.dll")]
    public static extern int GetUpdateRgn(IntPtr hwnd, IntPtr hrgn, bool fErase);
    public enum RegionFlags
    {
        ERROR = 0,
        NULLREGION = 1,
        SIMPLEREGION = 2,
        COMPLEXREGION = 3,
    }
    [DllImport("gdi32.dll")]
    internal static extern bool DeleteObject(IntPtr hObject);

    [DllImport("gdi32.dll")]
    private static extern IntPtr CreateRectRgn(int x1, int y1, int x2, int y2);
}
public class CustomTextBox : TextBox
{
    const int WM_NCPAINT = 0x85;
    const uint RDW_INVALIDATE = 0x1;
    const uint RDW_IUPDATENOW = 0x100;
    const uint RDW_FRAME = 0x400;
    [DllImport("user32.dll")]
    static extern IntPtr GetWindowDC(IntPtr hWnd);
    [DllImport("user32.dll")]
    static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
    [DllImport("user32.dll")]
    static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, uint flags);
    Color borderColor = Color.Blue;
    public Color BorderColor
    {
        get { return borderColor; }
        set
        {
            borderColor = value;
            RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
        }
    }
    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);
        if (m.Msg == WM_NCPAINT && BorderColor != Color.Transparent &&
            BorderStyle == System.Windows.Forms.BorderStyle.Fixed3D)
        {
            var hdc = GetWindowDC(this.Handle);
            using (var g = Graphics.FromHdcInternal(hdc))
            using (var p = new Pen(BorderColor))
                g.DrawRectangle(p, new Rectangle(0, 0, Width - 1, Height - 1));
            ReleaseDC(this.Handle, hdc);
        }
    }
    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
               RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
    }
}
public class CustomRadioButton : RadioButton
{
    //Fields
    private Color checkedColor = Color.MediumSlateBlue;
    private Color unCheckedColor = Color.Gray;
    //Properties
    public bool LastChecked { get; set; }
    public Color CheckedColor
    {
        get { return checkedColor; }
        set
        {
            checkedColor = value;
            this.Invalidate();
        }
    }

    public Color UnCheckedColor
    {
        get { return unCheckedColor; }
        set
        {
            unCheckedColor = value;
            this.Invalidate();
        }
    }
    //Constructor
    public CustomRadioButton()
    {
        this.MinimumSize = new Size(0, 21);
        //Add a padding of 10 to the left to have a considerable distance between the text and the RadioButton.
        this.Padding = new Padding(10, 0, 0, 0);
    }
    //Overridden methods
    protected override void OnPaint(PaintEventArgs pevent)
    {
        //Fields
        Graphics graphics = pevent.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        float rbBorderSize = 18F;
        float rbCheckSize = 12F;
        RectangleF rectRbBorder = new RectangleF()
        {
            X = 0.5F,
            Y = (this.Height - rbBorderSize) / 2, //Center
            Width = rbBorderSize,
            Height = rbBorderSize
        };
        RectangleF rectRbCheck = new RectangleF()
        {
            X = rectRbBorder.X + ((rectRbBorder.Width - rbCheckSize) / 2), //Center
            Y = (this.Height - rbCheckSize) / 2, //Center
            Width = rbCheckSize,
            Height = rbCheckSize
        };

        //Drawing
        using (Pen penBorder = new Pen(checkedColor, 1.6F))
        using (SolidBrush brushRbCheck = new SolidBrush(checkedColor))
        using (SolidBrush brushText = new SolidBrush(this.ForeColor))
        {
            //Draw surface
            graphics.Clear(this.BackColor);
            //Draw Radio Button
            if (this.Checked)
            {
                graphics.DrawEllipse(penBorder, rectRbBorder);//Circle border
                graphics.FillEllipse(brushRbCheck, rectRbCheck); //Circle Radio Check
            }
            else
            {
                penBorder.Color = unCheckedColor;
                graphics.DrawEllipse(penBorder, rectRbBorder); //Circle border
            }
            //Draw text
            graphics.DrawString(this.Text, this.Font, brushText,
                rbBorderSize + 8, (this.Height - TextRenderer.MeasureText(this.Text, this.Font).Height) / 2);//Y=Center
        }
    }
    //X-> Obsolete code, this was replaced by the Padding property in the constructor
    //(this.Padding = new Padding(10,0,0,0);)
    //protected override void OnResize(EventArgs e)
    //{
    //    base.OnResize(e);
    //    this.Width = TextRenderer.MeasureText(this.Text, this.Font).Width + 30;
    //}
}