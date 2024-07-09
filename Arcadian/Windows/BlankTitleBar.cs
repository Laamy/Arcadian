using System.Drawing;
using System.Windows.Forms;

class BlankTitleBar : TitleBarForm
{
    private DropShadowPanel dropShadowPanel1;

    public override void InitializeComponents()
    {
        base.InitializeComponents();
        InitializeComponent();

        Text = "Arcadian";
    }

    private void InitializeComponent()
    {
            this.dropShadowPanel1 = new DropShadowPanel();
            this.SuspendLayout();
            // 
            // dropShadowPanel1
            // 
            this.dropShadowPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dropShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dropShadowPanel1.Location = new System.Drawing.Point(129, 173);
            this.dropShadowPanel1.Name = "dropShadowPanel1";
            this.dropShadowPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.dropShadowPanel1.Size = new System.Drawing.Size(130, 119);
            this.dropShadowPanel1.TabIndex = 1;
            // 
            // BlankTitleBar
            // 
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.dropShadowPanel1);
            this.Name = "BlankTitleBar";
            this.Controls.SetChildIndex(this.dropShadowPanel1, 0);
            this.ResumeLayout(false);

    }
}
