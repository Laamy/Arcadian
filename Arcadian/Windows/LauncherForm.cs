using System.Drawing;
using System.Windows.Forms;

class LauncherForm : TitleBarForm
{
    private Label label2;
    private Panel panel1;
    private Label label1;
    private Label label5;
    private Label label4;
    private Label label3;
    private ScrollablePanel scrollablePanel1;
    private Label label12;
    private Label label11;
    private Label label8;
    private Label label7;
    private Label label6;
    private Label label9;
    private ScrollablePanel clientspanel;

    public override void InitializeComponents()
    {
        base.InitializeComponents();
        InitializeComponent();

        Text = "Arcadian";
    }

    private void InitializeComponent()
    {
            this.clientspanel = new ScrollablePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scrollablePanel1 = new ScrollablePanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.clientspanel.SuspendLayout();
            this.scrollablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientspanel
            // 
            this.clientspanel.AutoScroll = true;
            this.clientspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.clientspanel.Controls.Add(this.label5);
            this.clientspanel.Controls.Add(this.label4);
            this.clientspanel.Controls.Add(this.label3);
            this.clientspanel.Controls.Add(this.label1);
            this.clientspanel.Controls.Add(this.label2);
            this.clientspanel.Controls.Add(this.panel1);
            this.clientspanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientspanel.Location = new System.Drawing.Point(0, 28);
            this.clientspanel.Name = "clientspanel";
            this.clientspanel.Size = new System.Drawing.Size(181, 432);
            this.clientspanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 37);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Home";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "1.21.1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "1.21.0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "1.19.71";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "1.16.201";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scrollablePanel1
            // 
            this.scrollablePanel1.AutoScroll = true;
            this.scrollablePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.scrollablePanel1.Controls.Add(this.label12);
            this.scrollablePanel1.Controls.Add(this.label11);
            this.scrollablePanel1.Controls.Add(this.label8);
            this.scrollablePanel1.Controls.Add(this.label7);
            this.scrollablePanel1.Controls.Add(this.label6);
            this.scrollablePanel1.Controls.Add(this.label9);
            this.scrollablePanel1.Location = new System.Drawing.Point(180, 28);
            this.scrollablePanel1.Name = "scrollablePanel1";
            this.scrollablePanel1.Size = new System.Drawing.Size(181, 432);
            this.scrollablePanel1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 37);
            this.label9.TabIndex = 4;
            this.label9.Text = "Test Client";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Horion";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dive";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 37);
            this.label8.TabIndex = 7;
            this.label8.Text = "Vanilla";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 37);
            this.label11.TabIndex = 8;
            this.label11.Text = "Borion";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 37);
            this.label12.TabIndex = 9;
            this.label12.Text = "Iris";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LauncherForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.scrollablePanel1);
            this.Controls.Add(this.clientspanel);
            this.Name = "LauncherForm";
            this.Controls.SetChildIndex(this.clientspanel, 0);
            this.Controls.SetChildIndex(this.scrollablePanel1, 0);
            this.clientspanel.ResumeLayout(false);
            this.scrollablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }
}
