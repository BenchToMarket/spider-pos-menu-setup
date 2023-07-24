using System;
using System.Diagnostics;

public partial class TerminalGroup_UC : System.Windows.Forms.UserControl
{

    #region  Windows Form Designer generated code 

    public TerminalGroup_UC(float x, float y, float w, float h) : base()
    {

        this.Location = new System.Drawing.Point((int)Math.Round(x), (int)Math.Round(y));
        this.Width = w;
        this.Height = h;
        this.BackColor = System.Drawing.SystemColors.Control;


        // This call is required by the Windows Form Designer.
        InitializeComponent();

        // Add any initialization after the InitializeComponent() call

    }

    // UserControl overrides dispose to clean up the component list.
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (components is not null)
            {
                components.Dispose();
            }
        }
        base.Dispose(disposing);
    }

    // Required by the Windows Form Designer
    private System.ComponentModel.IContainer components;

    // NOTE: The following procedure is required by the Windows Form Designer
    // It can be modified using the Windows Form Designer.  
    // Do not modify it using the code editor.
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
    }

    #endregion

}