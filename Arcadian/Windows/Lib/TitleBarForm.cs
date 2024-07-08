using System;
using System.Drawing;
using System.Windows.Forms;

class TitleBarForm : BlankForm
{
    Panel TitleBar;
    Label TitleBarText;
    Label TitleBarMinBtn;
    Label TitleBarCloseBtn;

    class StyleForm
    {
        public static Color Background = Color.FromArgb(0xFF, 0x30, 0x30, 0x30);
        public static Color Titlebar = Color.FromArgb(0xFF, 0x20, 0x20, 0x20);
    }

    public override string Text
    {
        get => base.Text;
        set
        {
            base.Text = value;

            TitleBarText.Text = value;
        }
    }

    public override void InitializeComponents()
    {
        FormBorderStyle = FormBorderStyle.None;
        StartPosition = FormStartPosition.CenterScreen;
        Size = new Size(800, 460);

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
                Opacity = 0.9;
            }

            void Titlebar_MouseUp(object sender, MouseEventArgs e)
            {
                Dragging = false;

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
                Size = new Size(0, 28),
                BackColor = StyleForm.Titlebar
            };

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
                    Font = new Font("Arial", 12),
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
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.Yellow,
                    Font = new Font("Arial", 20),
                    Size = new Size(16, 0),
                    Text = "•"
                };

                TitleBarMinBtn.Click += MinBtn_Click;
                TitleBar.Controls.Add(TitleBarMinBtn);
            }

            {
                void CloseBtn_Click(object sender, EventArgs e) => Close();

                TitleBarCloseBtn = new Label()
                {
                    Dock = DockStyle.Right,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.Red,
                    Font = new Font("Arial", 20),
                    Size = new Size(16, 0),
                    Text = "•"
                };

                TitleBarCloseBtn.Click += CloseBtn_Click;
                TitleBar.Controls.Add(TitleBarCloseBtn);
            }
        }
    }
}
