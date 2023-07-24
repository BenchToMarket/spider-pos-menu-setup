using System.Diagnostics;


internal partial class Exit_UC : System.Windows.Forms.UserControl
{
    public Exit_UC()
    {
        InitializeComponent();
    }

    // UserControl overrides dispose to clean up the component list.
    [DebuggerNonUserCode()]
    protected override void Dispose(bool disposing)
    {
        try
        {
            if (disposing && components is not null)
            {
                components.Dispose();
            }
        }
        finally
        {
            base.Dispose(disposing);
        }
    }

    // Required by the Windows Form Designer
    private System.ComponentModel.IContainer components;

    // NOTE: The following procedure is required by the Windows Form Designer
    // It can be modified using the Windows Form Designer.  
    // Do not modify it using the code editor.
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        pnlExitUC = new System.Windows.Forms.Panel();
        btnExitCancel = new System.Windows.Forms.Button();
        btnForceMenu = new System.Windows.Forms.Button();
        btnExitNoForce = new System.Windows.Forms.Button();
        DateTimePickerMenu = new System.Windows.Forms.DateTimePicker();
        pnlExitUC.SuspendLayout();
        this.SuspendLayout();
        // 
        // pnlExitUC
        // 
        pnlExitUC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        pnlExitUC.Controls.Add(btnExitCancel);
        pnlExitUC.Controls.Add(btnForceMenu);
        pnlExitUC.Controls.Add(btnExitNoForce);
        pnlExitUC.Controls.Add(DateTimePickerMenu);
        pnlExitUC.Location = new System.Drawing.Point(12, 14);
        pnlExitUC.Name = "pnlExitUC";
        pnlExitUC.Size = new System.Drawing.Size(354, 244);
        pnlExitUC.TabIndex = 0;
        // 
        // btnExitCancel
        // 
        btnExitCancel.BackColor = System.Drawing.Color.FromArgb(149, 179, 215);
        btnExitCancel.Location = new System.Drawing.Point(29, 193);
        btnExitCancel.Name = "btnExitCancel";
        btnExitCancel.Size = new System.Drawing.Size(80, 26);
        btnExitCancel.TabIndex = 3;
        btnExitCancel.Text = "Cancel";
        btnExitCancel.UseVisualStyleBackColor = false;
        // 
        // btnForceMenu
        // 
        btnForceMenu.BackColor = System.Drawing.Color.FromArgb(149, 179, 215);
        btnForceMenu.Location = new System.Drawing.Point(29, 19);
        btnForceMenu.Name = "btnForceMenu";
        btnForceMenu.Size = new System.Drawing.Size(80, 80);
        btnForceMenu.TabIndex = 2;
        btnForceMenu.Text = "Force Menu Reload on New Daily";
        btnForceMenu.UseVisualStyleBackColor = false;
        // 
        // btnExitNoForce
        // 
        btnExitNoForce.BackColor = System.Drawing.Color.FromArgb(149, 179, 215);
        btnExitNoForce.Location = new System.Drawing.Point(29, 115);
        btnExitNoForce.Name = "btnExitNoForce";
        btnExitNoForce.Size = new System.Drawing.Size(80, 57);
        btnExitNoForce.TabIndex = 1;
        btnExitNoForce.Text = "Exit with Forcing";
        btnExitNoForce.UseVisualStyleBackColor = false;
        btnExitNoForce.Visible = false;
        // 
        // DateTimePickerMenu
        // 
        DateTimePickerMenu.Location = new System.Drawing.Point(133, 19);
        DateTimePickerMenu.Name = "DateTimePickerMenu";
        DateTimePickerMenu.Size = new System.Drawing.Size(200, 20);
        DateTimePickerMenu.TabIndex = 0;
        // 
        // Exit_UC
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.Black;
        this.Controls.Add(pnlExitUC);
        this.Name = "Exit_UC";
        this.Size = new System.Drawing.Size(381, 272);
        pnlExitUC.ResumeLayout(false);
        this.ResumeLayout(false);

    }
    internal Global.System.Windows.Forms.Panel pnlExitUC;
    internal Global.System.Windows.Forms.Button btnForceMenu;
    internal Global.System.Windows.Forms.Button btnExitNoForce;
    internal Global.System.Windows.Forms.DateTimePicker DateTimePickerMenu;
    internal Global.System.Windows.Forms.Button btnExitCancel;

}