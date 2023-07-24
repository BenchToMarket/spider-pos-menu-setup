using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DataSet_Builder;


public partial class WallInfo_UC : System.Windows.Forms.UserControl
{

    private bool _isNewWall;
    private Wall _currentWall;
    public bool locationHasChanged;

    private Wall _newWall;

    public bool IsNewWall
    {
        get
        {
            return _isNewWall;
        }
        set
        {
            _isNewWall = value;
        }
    }

    public Wall CurrentWall
    {
        get
        {
            return _currentWall;
        }
        set
        {
            _currentWall = value;
        }
    }

    public Wall NewWall
    {
        get
        {
            return _newWall;
        }
        set
        {
            _newWall = value;
        }
    }


    public event NewWallAcceptedEventHandler NewWallAccepted;

    public delegate void NewWallAcceptedEventHandler();
    public event UpdateOldWallEventHandler UpdateOldWall;

    public delegate void UpdateOldWallEventHandler();
    public event WallCancelEventHandler WallCancel;

    public delegate void WallCancelEventHandler();

    #region  Windows Form Designer generated code 

    public WallInfo_UC(bool isNT, Wall tempWall) : base()
    {

        _isNewWall = isNT;
        _currentWall = tempWall;
        _newWall = tempWall;

        // This call is required by the Windows Form Designer.
        InitializeComponent();

        // Add any initialization after the InitializeComponent() call
        InitializeOther();

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

    private Global.System.Windows.Forms.Label _lblToEnd;

    internal virtual Global.System.Windows.Forms.Label lblToEnd
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblToEnd;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblToEnd = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblHeight;

    internal virtual Global.System.Windows.Forms.Label lblHeight
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblHeight;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblHeight = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblWidth;

    internal virtual Global.System.Windows.Forms.Label lblWidth
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblWidth;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblWidth = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtHeight;

    internal virtual Global.System.Windows.Forms.TextBox txtHeight
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtHeight;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtHeight != null)
            {
                _txtHeight.Validating -= txtHeight_Validating;
            }

            _txtHeight = value;
            if (_txtHeight != null)
            {
                _txtHeight.Validating += txtHeight_Validating;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtWidth;

    internal virtual Global.System.Windows.Forms.TextBox txtWidth
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtWidth;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtWidth != null)
            {
                _txtWidth.Validating -= txtWidth_Validating;
            }

            _txtWidth = value;
            if (_txtWidth != null)
            {
                _txtWidth.Validating += txtWidth_Validating;
            }
        }
    }

    private Global.System.Windows.Forms.Button _btnTop;

    internal virtual Global.System.Windows.Forms.Button btnTop
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnTop;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnTop != null)
            {
                _btnTop.Click -= btnTop_Click;
            }

            _btnTop = value;
            if (_btnTop != null)
            {
                _btnTop.Click += btnTop_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnLeft;

    internal virtual Global.System.Windows.Forms.Button btnLeft
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnLeft;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnLeft != null)
            {
                _btnLeft.Click -= btnLeft_Click;
            }

            _btnLeft = value;
            if (_btnLeft != null)
            {
                _btnLeft.Click += btnLeft_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnRight;

    internal virtual Global.System.Windows.Forms.Button btnRight
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnRight;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnRight != null)
            {
                _btnRight.Click -= btnRight_Click;
            }

            _btnRight = value;
            if (_btnRight != null)
            {
                _btnRight.Click += btnRight_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnBottom;

    internal virtual Global.System.Windows.Forms.Button btnBottom
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnBottom;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnBottom != null)
            {
                _btnBottom.Click -= btnBottom_Click;
            }

            _btnBottom = value;
            if (_btnBottom != null)
            {
                _btnBottom.Click += btnBottom_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnCancel;

    internal virtual Global.System.Windows.Forms.Button btnCancel
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnCancel;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnCancel != null)
            {
                _btnCancel.Click -= btnCancel_Click;
            }

            _btnCancel = value;
            if (_btnCancel != null)
            {
                _btnCancel.Click += btnCancel_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnNewWall;

    internal virtual Global.System.Windows.Forms.Button btnNewWall
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnNewWall;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnNewWall != null)
            {
                _btnNewWall.Click -= btnNewWall_Click;
            }

            _btnNewWall = value;
            if (_btnNewWall != null)
            {
                _btnNewWall.Click += btnNewWall_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Label _lblWall;

    internal virtual Global.System.Windows.Forms.Label lblWall
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblWall;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblWall = value;
        }
    }
    private Global.System.Windows.Forms.ErrorProvider _ErrorProvider1;

    internal virtual Global.System.Windows.Forms.ErrorProvider ErrorProvider1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _ErrorProvider1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ErrorProvider1 = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnFlip;

    internal virtual Global.System.Windows.Forms.Button btnFlip
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnFlip;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnFlip != null)
            {
                _btnFlip.Click -= btnFlip_Click;
            }

            _btnFlip = value;
            if (_btnFlip != null)
            {
                _btnFlip.Click += btnFlip_Click;
            }
        }
    }
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        _txtWidth = new System.Windows.Forms.TextBox();
        _txtWidth.Validating += txtWidth_Validating;
        _txtHeight = new System.Windows.Forms.TextBox();
        _txtHeight.Validating += txtHeight_Validating;
        _lblWidth = new System.Windows.Forms.Label();
        _lblHeight = new System.Windows.Forms.Label();
        _lblToEnd = new System.Windows.Forms.Label();
        _btnTop = new System.Windows.Forms.Button();
        _btnTop.Click += btnTop_Click;
        _btnLeft = new System.Windows.Forms.Button();
        _btnLeft.Click += btnLeft_Click;
        _btnRight = new System.Windows.Forms.Button();
        _btnRight.Click += btnRight_Click;
        _btnBottom = new System.Windows.Forms.Button();
        _btnBottom.Click += btnBottom_Click;
        _btnCancel = new System.Windows.Forms.Button();
        _btnCancel.Click += btnCancel_Click;
        _btnNewWall = new System.Windows.Forms.Button();
        _btnNewWall.Click += btnNewWall_Click;
        _lblWall = new System.Windows.Forms.Label();
        _ErrorProvider1 = new System.Windows.Forms.ErrorProvider();
        _btnFlip = new System.Windows.Forms.Button();
        _btnFlip.Click += btnFlip_Click;
        this.SuspendLayout();
        // 
        // txtWidth
        // 
        _txtWidth.Location = new System.Drawing.Point(96, 64);
        _txtWidth.Name = "_txtWidth";
        _txtWidth.Size = new System.Drawing.Size(56, 20);
        _txtWidth.TabIndex = 10;
        _txtWidth.Text = "";
        // 
        // txtHeight
        // 
        _txtHeight.Location = new System.Drawing.Point(96, 96);
        _txtHeight.Name = "_txtHeight";
        _txtHeight.Size = new System.Drawing.Size(56, 20);
        _txtHeight.TabIndex = 11;
        _txtHeight.Text = "";
        // 
        // lblWidth
        // 
        _lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblWidth.ForeColor = System.Drawing.Color.DarkBlue;
        _lblWidth.Location = new System.Drawing.Point(24, 64);
        _lblWidth.Name = "_lblWidth";
        _lblWidth.Size = new System.Drawing.Size(64, 16);
        _lblWidth.TabIndex = 13;
        _lblWidth.Text = "Width";
        // 
        // lblHeight
        // 
        _lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblHeight.ForeColor = System.Drawing.Color.DarkBlue;
        _lblHeight.Location = new System.Drawing.Point(24, 96);
        _lblHeight.Name = "_lblHeight";
        _lblHeight.Size = new System.Drawing.Size(64, 16);
        _lblHeight.TabIndex = 12;
        _lblHeight.Text = "Height";
        // 
        // lblToEnd
        // 
        _lblToEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblToEnd.ForeColor = System.Drawing.Color.DarkBlue;
        _lblToEnd.Location = new System.Drawing.Point(96, 128);
        _lblToEnd.Name = "_lblToEnd";
        _lblToEnd.Size = new System.Drawing.Size(64, 16);
        _lblToEnd.TabIndex = 14;
        _lblToEnd.Text = "To End";
        // 
        // btnTop
        // 
        _btnTop.Location = new System.Drawing.Point(80, 152);
        _btnTop.Name = "_btnTop";
        _btnTop.Size = new System.Drawing.Size(80, 32);
        _btnTop.TabIndex = 15;
        _btnTop.Text = "Top";
        // 
        // btnLeft
        // 
        _btnLeft.Location = new System.Drawing.Point(24, 192);
        _btnLeft.Name = "_btnLeft";
        _btnLeft.Size = new System.Drawing.Size(75, 32);
        _btnLeft.TabIndex = 16;
        _btnLeft.Text = "Left";
        // 
        // btnRight
        // 
        _btnRight.Location = new System.Drawing.Point(144, 192);
        _btnRight.Name = "_btnRight";
        _btnRight.Size = new System.Drawing.Size(75, 32);
        _btnRight.TabIndex = 17;
        _btnRight.Text = "Right";
        // 
        // btnBottom
        // 
        _btnBottom.Location = new System.Drawing.Point(80, 232);
        _btnBottom.Name = "_btnBottom";
        _btnBottom.Size = new System.Drawing.Size(80, 32);
        _btnBottom.TabIndex = 18;
        _btnBottom.Text = "Bottom";
        // 
        // btnCancel
        // 
        _btnCancel.Location = new System.Drawing.Point(136, 288);
        _btnCancel.Name = "_btnCancel";
        _btnCancel.Size = new System.Drawing.Size(88, 40);
        _btnCancel.TabIndex = 20;
        _btnCancel.TabStop = false;
        _btnCancel.Text = "Close";
        // 
        // btnNewWall
        // 
        _btnNewWall.Location = new System.Drawing.Point(24, 288);
        _btnNewWall.Name = "_btnNewWall";
        _btnNewWall.Size = new System.Drawing.Size(88, 40);
        _btnNewWall.TabIndex = 19;
        _btnNewWall.TabStop = false;
        _btnNewWall.Text = "Create New";
        // 
        // lblWall
        // 
        _lblWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblWall.ForeColor = System.Drawing.Color.DarkBlue;
        _lblWall.Location = new System.Drawing.Point(16, 8);
        _lblWall.Name = "_lblWall";
        _lblWall.Size = new System.Drawing.Size(216, 32);
        _lblWall.TabIndex = 21;
        _lblWall.Text = "Physical Structure";
        _lblWall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // ErrorProvider1
        // 
        _ErrorProvider1.ContainerControl = this;
        // 
        // btnFlip
        // 
        _btnFlip.Location = new System.Drawing.Point(176, 72);
        _btnFlip.Name = "_btnFlip";
        _btnFlip.Size = new System.Drawing.Size(48, 40);
        _btnFlip.TabIndex = 22;
        _btnFlip.Text = "Flip";
        // 
        // WallInfo_UC
        // 
        this.BackColor = System.Drawing.Color.LightGray;
        this.Controls.Add(_btnFlip);
        this.Controls.Add(_lblWall);
        this.Controls.Add(_btnCancel);
        this.Controls.Add(_btnNewWall);
        this.Controls.Add(_btnBottom);
        this.Controls.Add(_btnRight);
        this.Controls.Add(_btnLeft);
        this.Controls.Add(_btnTop);
        this.Controls.Add(_lblToEnd);
        this.Controls.Add(_txtWidth);
        this.Controls.Add(_txtHeight);
        this.Controls.Add(_lblWidth);
        this.Controls.Add(_lblHeight);
        this.Name = "WallInfo_UC";
        this.Size = new System.Drawing.Size(248, 344);
        this.ResumeLayout(false);

    }

    #endregion

    private void InitializeOther()
    {

        if (IsNewWall == false)
        {
            btnNewWall.Text = "Update";
        }

        BindData();

    }
    private void BindData()
    {

        txtWidth.Text = CurrentWall.myWidth;
        txtHeight.Text = CurrentWall.myHeight;

    }

    private void btnRight_Click(object sender, EventArgs e)
    {
        NewWall.myWidth = this.Parent.Width - CurrentWall.xLoc;
        txtWidth.Text = NewWall.myWidth;

    }
    private void btnLeft_Click(object sender, EventArgs e)
    {
        NewWall.myWidth = CurrentWall.xLoc + CurrentWall.myWidth;
        txtWidth.Text = NewWall.myWidth;
        NewWall.xLoc = 0;
        locationHasChanged = true;

    }
    private void btnBottom_Click(object sender, EventArgs e)
    {
        NewWall.myHeight = this.Parent.Height - CurrentWall.yLoc;
        txtHeight.Text = NewWall.myHeight;

    }
    private void btnTop_Click(object sender, EventArgs e)
    {
        NewWall.myHeight = CurrentWall.yLoc + CurrentWall.myHeight;
        txtHeight.Text = NewWall.myHeight;
        NewWall.yLoc = 0;
        locationHasChanged = true;

    }
    private void btnFlip_Click(object sender, EventArgs e)
    {
        NewWall.myWidth = txtHeight.Text;
        NewWall.myHeight = txtWidth.Text;

        txtWidth.Text = NewWall.myWidth;
        txtHeight.Text = NewWall.myHeight;
    }
    private void txtWidth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        var argtxtValNumeric = txtWidth;
        ValidateNumeric(ref argtxtValNumeric);
        txtWidth = argtxtValNumeric;

    }

    private void txtHeight_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        var argtxtValNumeric = txtHeight;
        ValidateNumeric(ref argtxtValNumeric);
        txtHeight = argtxtValNumeric;

    }

    private void ValidateNumeric(ref TextBox txtValNumeric)
    {

        if (txtValNumeric.Text == "")
        {
            ErrorProvider1.SetError(txtValNumeric, "This TextBox can not be Blank.");
            txtValNumeric.Focus();
            Interaction.Beep();
        }

        else if (!Information.IsNumeric(txtValNumeric.Text))
        {
            ErrorProvider1.SetError(txtValNumeric, "This must be a numeric value.");
            txtValNumeric.Focus();
            Interaction.Beep();
        }

        else
        {
            // cancels the error
            ErrorProvider1.Dispose();
            // Me.ErrorProvider1.SetError(txtValNumeric, "")
        }
    }

    private void btnNewWall_Click(object sender, EventArgs e)
    {
        if (ErrorProvider1.GetError(txtWidth).Length == 0 & ErrorProvider1.GetError(txtHeight).Length == 0)
        {
            NewWall.myWidth = txtWidth.Text;
            NewWall.myHeight = txtHeight.Text;

            if (IsNewWall == true)
            {
                NewWallAccepted?.Invoke();
            }
            else
            {
                UpdateOldWall?.Invoke();
            }
        }

    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        WallCancel?.Invoke();

    }

}