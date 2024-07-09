using System;
using System.Drawing;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

class ScrollablePanel : Panel
{
    public ScrollablePanel()
    {
        AutoScroll = true;
    }

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);

        if (m.Msg == 0x85) // WM_NCPAINT
            ShowScrollBar(this.Handle, 1, 0); // SB_VERT
    }

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);
}