using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

class LauncherForm : TitleBarForm
{
    private ScrollablePanel clientspanel;

    public List<ClientBase> Clients = new List<ClientBase>()
    {
        new ClientBase() // temp things
        {
            Name = "Trero Utility",
            Image = "https://hd.wallpaperswide.com/thumbs/funny_cat_5-t2.jpg",
            Version = "v1.17.11"
        },
        new ClientBase()
        {
            Name = "Netherite Client",
            Version = "v1.19.0"
        },
        new ClientBase()
        {
            Name = "Dive Client",
            Version = "v1.20.1"
        }
    };

    public override void InitializeComponents()
    {
        base.InitializeComponents();
        InitializeComponent();
        RefreshTaskbar();

        Text = "Arcadian";
    }

    private void InitializeComponent()
    {
        // the side panel
        this.clientspanel = new ScrollablePanel();

        clientspanel.SuspendLayout();
        this.SuspendLayout();

        this.clientspanel.AutoScroll = true;
        this.clientspanel.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
        this.clientspanel.Dock = System.Windows.Forms.DockStyle.Left;
        this.clientspanel.Location = new System.Drawing.Point(0, 34);
        this.clientspanel.Size = new System.Drawing.Size(181, 426);
        this.clientspanel.TabIndex = 1;
        //this.clientspanel.RightShadow = new DropShadow() { ShadowDepth = 7 };

        // winform designer generated code
        // setup panel
        foreach (var client in Clients)
        {
            Label label1;
            ScrollablePanel SlotBackground;
            PictureBox ClientImage;
            Label label2;

            SlotBackground = new ScrollablePanel();
            ClientImage = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();

            SlotBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(ClientImage)).BeginInit();

            this.clientspanel.Controls.Add(SlotBackground);

            SlotBackground.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            SlotBackground.Controls.Add(ClientImage);
            SlotBackground.Controls.Add(label2);
            SlotBackground.Controls.Add(label1);
            SlotBackground.Dock = System.Windows.Forms.DockStyle.Top;
            SlotBackground.Location = new System.Drawing.Point(0, 0);
            SlotBackground.Size = new System.Drawing.Size(181, 56);

            //SlotBackground.RightShadow = new DropShadow() { ShadowDepth = 7 };

            // TODO: cache images/make texture repos class
            if (client.Image != null)
            {
                using (WebClient wc = new WebClient())
                {
                    byte[] daImage = wc.DownloadData(client.Image);
                    using (var ms = new MemoryStream(daImage))
                    {
                        ClientImage.Image = Image.FromStream(ms);
                    }
                }
            }
            else
            {
                // texture not found
                ClientImage.Image = global::Arcadian.Properties.Resources.background;
            }

            ClientImage.Location = new System.Drawing.Point(8, 7);
            ClientImage.Size = new System.Drawing.Size(43, 43);
            ClientImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            label2.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            label2.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F);
            label2.ForeColor = System.Drawing.Color.White;
            label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label2.Location = new System.Drawing.Point(58, 3);
            label2.Size = new System.Drawing.Size(123, 31);
            label2.Text = client.Name;
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            label1.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F);
            label1.ForeColor = System.Drawing.Color.White;
            label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.Location = new System.Drawing.Point(60, 30);
            label1.Size = new System.Drawing.Size(121, 24);
            label1.Text = client.Version;
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            SlotBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(ClientImage)).EndInit();
        }

        this.ClientSize = new System.Drawing.Size(800, 460);
        this.Controls.Add(this.clientspanel);
        this.Name = "LauncherForm";
        this.Controls.SetChildIndex(this.clientspanel, 0);

        this.clientspanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }
}
