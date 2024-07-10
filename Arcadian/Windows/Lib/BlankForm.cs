using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class BlankForm : Form
{
    public BlankForm()
    {
        InitializeComponents();
    }

    public virtual void InitializeComponents() { }

    private const int CS_DROPSHADOW = 0x00020000;
    private const int BORDER_RADIUS = 15;

    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // width of ellipse
        int nHeightEllipse // height of ellipse
    );

    // https://stackoverflow.com/questions/18822067/rounded-corners-in-c-sharp-windows-forms
    private void UpdateRegion()
    {
        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, BORDER_RADIUS, BORDER_RADIUS));
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);

        UpdateRegion();
        this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        UpdateRegion();
    }

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ClassStyle |= CS_DROPSHADOW;
            return cp;
        }
    }

    protected override void WndProc(ref Message m)
    {
        const int RESIZE_HANDLE_SIZE = 10;

        switch (m.Msg)
        {
            case 0x0084:
                base.WndProc(ref m);
                if ((int)m.Result == 0x01)
                {
                    Point screenPoint = new Point(m.LParam.ToInt32());
                    Point clientPoint = this.PointToClient(screenPoint);
                    if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                    {
                        if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                            m.Result = (IntPtr)13;
                        else if (clientPoint.X < (this.Size.Width - RESIZE_HANDLE_SIZE))
                            m.Result = (IntPtr)12;
                        else
                            m.Result = (IntPtr)14;
                    }
                    else if (clientPoint.Y <= (this.Size.Height - RESIZE_HANDLE_SIZE))
                    {
                        if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                            m.Result = (IntPtr)10; // HTLEFT
                        else if (clientPoint.X < (this.Size.Width - RESIZE_HANDLE_SIZE))
                            m.Result = (IntPtr)1;
                        else
                            m.Result = (IntPtr)11;
                    }
                    else
                    {
                        if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                            m.Result = (IntPtr)16;
                        else if (clientPoint.X < (this.Size.Width - RESIZE_HANDLE_SIZE))
                            m.Result = (IntPtr)15;
                        else
                            m.Result = (IntPtr)17;
                    }
                }
                return;
        }
        base.WndProc(ref m);
    }
}