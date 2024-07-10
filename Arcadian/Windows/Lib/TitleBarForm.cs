using System;
using System.Drawing;
using System.Windows.Forms;

class TitleBarForm : BlankForm
{
    Panel TitleBar;
    DropShadowPanel TitleBarShadow; // seperate to avoid annoyances
    Label TitleBarText;
    Label TitleBarMinBtn;
    Label TitleBarCloseBtn;

    public void RefreshTaskbar()
    {
        TitleBarShadow.BringToFront();
    }

    class StyleForm
    {
        public static Color Background = Color.FromArgb(0xFF, 0x30, 0x30, 0x30);
        public static Color Titlebar = Color.FromArgb(0xFF, 0x20, 0x20, 0x20);
        public static Color TitlebarClose = Color.FromArgb(0xFF, 0x91, 0x17, 0x1f);
        public static Color TitlebarMinimize = Color.FromArgb(0xFF, 0xff, 0x95, 0x00);
    }

    public override string Text
    {
        get => base.Text;
        set
        {
            base.Text = value;

            TitleBarText.Text = " " + value;
        }
    }

    bool IsResizing = false;
    
    //TODO: fix resize bug
    protected override void OnResizeBegin(EventArgs e)
    {
        base.OnResizeBegin(e);

        IsResizing = true;
        Opacity = 0.9;
    }

    protected override void OnResizeEnd(EventArgs e)
    {
        base.OnResizeEnd(e);

        IsResizing = false;
        Opacity = 1;
    }

    public override void InitializeComponents()
    {
        FormBorderStyle = FormBorderStyle.None;
        StartPosition = FormStartPosition.CenterScreen;
        Size = new Size(800, 460);
        DoubleBuffered = true;

        MinimumSize = new Size(600, 320);
        MaximumSize = new Size(800, 460);

        BackColor = StyleForm.Background;

        {
            bool Dragging = false;
            Point DragCursorPoint = default;
            Point DragFormPoint = default; // this shouldnt need to be specified but MSVS IDE detected it as an error..

            void Titlebar_MouseDown(object sender, MouseEventArgs e)
            {
                Dragging = true;
                DragCursorPoint = Cursor.Position;
                DragFormPoint = this.Location;

                if (!IsResizing)
                    Opacity = 0.9;
            }

            void Titlebar_MouseUp(object sender, MouseEventArgs e)
            {
                Dragging = false;

                if (!IsResizing)
                    Opacity = 1;
            }

            void Titlebar_MouseMove(object sender, MouseEventArgs e)
            {
                if (Dragging)
                {
                    Point diff = Point.Subtract(Cursor.Position, new Size(DragCursorPoint));
                    Location = Point.Add(DragFormPoint, new Size(diff));
                }
            }

            TitleBar = new Panel()
            {
                Dock = DockStyle.Top,
                Size = new Size(0, 24),
                BackColor = StyleForm.Titlebar
            };

            {
                TitleBarShadow = new DropShadowPanel()
                {
                    Dock = DockStyle.Top,
                    ShadowDepth = 10,
                    Size = new Size(0, 10), // also shadow depth
                    BackColor = StyleForm.Titlebar,
                    ShadowColor = StyleForm.Background,
                };

                TitleBarShadow.MouseDown += Titlebar_MouseDown;
                TitleBarShadow.MouseMove += Titlebar_MouseMove;
                TitleBarShadow.MouseUp += Titlebar_MouseUp;
                Controls.Add(TitleBarShadow);
            }

            TitleBar.MouseDown += Titlebar_MouseDown;
            TitleBar.MouseMove += Titlebar_MouseMove;
            TitleBar.MouseUp += Titlebar_MouseUp;
            Controls.Add(TitleBar);

            {
                TitleBarText = new Label()
                {
                    Dock = DockStyle.Left,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Text = "TitleBarForm",
                    ForeColor = Color.White,
                    Font = new Font("Yu Gothic UI Light", 10),
                    Size = new Size(150, 0),
                };

                TitleBarText.MouseDown += Titlebar_MouseDown;
                TitleBarText.MouseMove += Titlebar_MouseMove;
                TitleBarText.MouseUp += Titlebar_MouseUp;
                TitleBar.Controls.Add(TitleBarText);
            }

            {
                void MinBtn_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

                TitleBarMinBtn = new Label()
                {
                    Dock = DockStyle.Right,
                    TextAlign = ContentAlignment.BottomCenter,
                    ForeColor = StyleForm.TitlebarMinimize,
                    Font = new Font("Arial", 8),
                    Size = new Size(24, 0),
                    Text = "⚫" // "•"
                };

                TitleBarMinBtn.Padding = new Padding(7, 0, 0, 3);

                TitleBarMinBtn.Click += MinBtn_Click;
                TitleBar.Controls.Add(TitleBarMinBtn);
            }

            {
                void CloseBtn_Click(object sender, EventArgs e) => Close();

                TitleBarCloseBtn = new Label()
                {
                    Dock = DockStyle.Right,
                    TextAlign = ContentAlignment.BottomCenter,
                    ForeColor = StyleForm.TitlebarClose,
                    Font = new Font("Arial", 8),
                    Size = new Size(24, 0),
                    Text = "⚫" // "•"
                };

                TitleBarCloseBtn.Padding = new Padding(0, 0, 3, 3);

                TitleBarCloseBtn.Click += CloseBtn_Click;
                TitleBar.Controls.Add(TitleBarCloseBtn);
            }
        }
    }
}
