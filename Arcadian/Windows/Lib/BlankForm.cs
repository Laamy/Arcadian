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
    private const int BORDER_RADIUS = 7;

    private void UpdateRegion()
    {
        GraphicsPath path = new GraphicsPath();
        path.StartFigure();
        path.AddArc(new Rectangle(0, 0, BORDER_RADIUS, BORDER_RADIUS), 180, 90);
        path.AddArc(new Rectangle(this.Width - BORDER_RADIUS, 0, BORDER_RADIUS, BORDER_RADIUS), 270, 90);
        path.AddArc(new Rectangle(this.Width - BORDER_RADIUS, this.Height - BORDER_RADIUS, BORDER_RADIUS, BORDER_RADIUS), 0, 90);
        path.AddArc(new Rectangle(0, this.Height - BORDER_RADIUS, BORDER_RADIUS, BORDER_RADIUS), 90, 90);
        path.CloseFigure();

        this.Region = new Region(path);
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