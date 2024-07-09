using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class DropShadowPanel : Panel
{
    public int ShadowDepth = 7;
    public Color ShadowColor { get; set; } = Color.FromArgb(0xff, 48, 48, 48);

    public DropShadowPanel()
    {
        Padding = new Padding(0, 0, 0, ShadowDepth);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (LinearGradientBrush brush = new LinearGradientBrush(
            new Rectangle(0, Height - ShadowDepth, Width, ShadowDepth),
            BackColor,
            ShadowColor,
            LinearGradientMode.Vertical))
        {
            e.Graphics.FillRectangle(brush, 0, Height - ShadowDepth, Width, ShadowDepth);
        }
    }
}