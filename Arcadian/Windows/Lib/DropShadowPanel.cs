using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class DropShadow
{
    public int ShadowDepth = 0;
    public Color ShadowColor { get; set; } = Color.FromArgb(0xff, 48, 48, 48);
}

class DropShadowPanel : Panel
{
    public DropShadow TopShadow = new DropShadow();
    public DropShadow LeftShadow = new DropShadow();
    public DropShadow RightShadow = new DropShadow();
    public DropShadow BottomShadow = new DropShadow();

    public DropShadowPanel()
    {
        Padding = new Padding(
            top: TopShadow.ShadowDepth,
            left: LeftShadow.ShadowDepth,
            bottom: BottomShadow.ShadowDepth,
            right: RightShadow.ShadowDepth
        );
    }

    // TODO: allow shadow control (4 way)
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // totally best code

        // Draw Top Shadow
        if (TopShadow.ShadowDepth != 0)
        {
            using (LinearGradientBrush topBrush = new LinearGradientBrush(
                new Rectangle(0, 0, Width, TopShadow.ShadowDepth),
                TopShadow.ShadowColor,
                BackColor,
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(topBrush, 0, 0, Width, TopShadow.ShadowDepth);
            }
        }

        // Draw Left Shadow
        if (LeftShadow.ShadowDepth != 0)
        {
            using (LinearGradientBrush leftBrush = new LinearGradientBrush(
                new Rectangle(0, 0, LeftShadow.ShadowDepth, Height),
                LeftShadow.ShadowColor,
                BackColor,
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(leftBrush, 0, 0, LeftShadow.ShadowDepth, Height);
            }

        }

        // Draw Right Shadow

        if (RightShadow.ShadowDepth != 0)
        {
            using (LinearGradientBrush rightBrush = new LinearGradientBrush(
                new Rectangle(Width - RightShadow.ShadowDepth, 0, RightShadow.ShadowDepth, Height),
                BackColor,
                RightShadow.ShadowColor,
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(rightBrush, Width - RightShadow.ShadowDepth, 0, RightShadow.ShadowDepth, Height);
            }
        }

        // Draw Bottom Shadow
        if (BottomShadow.ShadowDepth != 0)
        {
            using (LinearGradientBrush bottomBrush = new LinearGradientBrush(
                new Rectangle(0, Height - BottomShadow.ShadowDepth, Width, BottomShadow.ShadowDepth),
                BackColor,
                BottomShadow.ShadowColor,
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(bottomBrush, 0, Height - BottomShadow.ShadowDepth, Width, BottomShadow.ShadowDepth);
            }
        }
    }
}