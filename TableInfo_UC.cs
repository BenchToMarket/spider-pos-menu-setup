using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DataSet_Builder;


public partial class TableInfo_UC : System.Windows.Forms.UserControl
{

    private bool _isNewTable;
    private PhysicalTable _currentTable;

    internal bool IsNewTable
    {
        get
        {
            return _isNewTable;
        }
        set
        {
            _isNewTable = value;
        }
    }

    internal PhysicalTable CurrentTable
    {
        get
        {
            return _currentTable;
        }
        set
        {
            _currentTable = value;
        }
    }

    public event NewTableAcceptedEventHandler NewTableAccepted;

    public delegate void NewTableAcceptedEventHandler();
    public event UpdateOldTableEventHandler UpdateOldTable;

    public delegate void UpdateOldTableEventHandler();
    public event TableCancelEventHandler TableCancel;

    public delegate void TableCancelEventHandler();


    #region  Windows Form Designer generated code 

    public TableInfo_UC(bool isNT, PhysicalTable tempTable) : base()
    {

        _isNewTable = isNT;
        _currentTable = tempTable;

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
    private Global.System.Windows.Forms.Panel _Panel1;

    internal virtual Global.System.Windows.Forms.Panel Panel1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Panel1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Panel1 = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblTableNumber;

    internal virtual Global.System.Windows.Forms.Label lblTableNumber
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblTableNumber;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblTableNumber = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnNewTable;

    internal virtual Global.System.Windows.Forms.Button btnNewTable
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnNewTable;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnNewTable != null)
            {
                _btnNewTable.Click -= btnNewTTableAccepted_Click;
            }

            _btnNewTable = value;
            if (_btnNewTable != null)
            {
                _btnNewTable.Click += btnNewTTableAccepted_Click;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtTableNum;

    internal virtual Global.System.Windows.Forms.TextBox txtTableNum
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtTableNum;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtTableNum != null)
            {
                _txtTableNum.Validating -= txtTableNum_Validating;
            }

            _txtTableNum = value;
            if (_txtTableNum != null)
            {
                _txtTableNum.Validating += txtTableNum_Validating;
            }
        }
    }
    private Global.System.Windows.Forms.Label _lblSeats;

    internal virtual Global.System.Windows.Forms.Label lblSeats
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblSeats;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblSeats = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtSeats;

    internal virtual Global.System.Windows.Forms.TextBox txtSeats
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtSeats;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtSeats != null)
            {
                _txtSeats.Validating -= txtSeats_Validating;
            }

            _txtSeats = value;
            if (_txtSeats != null)
            {
                _txtSeats.Validating += txtSeats_Validating;
            }
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
    private Global.System.Windows.Forms.Button _btnClose;

    internal virtual Global.System.Windows.Forms.Button btnClose
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnClose;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnClose != null)
            {
                _btnClose.Click -= btnCancel_Click;
            }

            _btnClose = value;
            if (_btnClose != null)
            {
                _btnClose.Click += btnCancel_Click;
            }
        }
    }
    private Global.System.Windows.Forms.CheckBox _chbAvailable;

    internal virtual Global.System.Windows.Forms.CheckBox chbAvailable
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chbAvailable;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chbAvailable = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chbActive;

    internal virtual Global.System.Windows.Forms.CheckBox chbActive
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chbActive;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chbActive = value;
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
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        _Panel1 = new System.Windows.Forms.Panel();
        _chbActive = new System.Windows.Forms.CheckBox();
        _chbAvailable = new System.Windows.Forms.CheckBox();
        _btnClose = new System.Windows.Forms.Button();
        _btnClose.Click += btnCancel_Click;
        _txtWidth = new System.Windows.Forms.TextBox();
        _txtWidth.Validating += txtWidth_Validating;
        _txtHeight = new System.Windows.Forms.TextBox();
        _txtHeight.Validating += txtHeight_Validating;
        _lblWidth = new System.Windows.Forms.Label();
        _lblHeight = new System.Windows.Forms.Label();
        _txtSeats = new System.Windows.Forms.TextBox();
        _txtSeats.Validating += txtSeats_Validating;
        _lblSeats = new System.Windows.Forms.Label();
        _txtTableNum = new System.Windows.Forms.TextBox();
        _txtTableNum.Validating += txtTableNum_Validating;
        _btnNewTable = new System.Windows.Forms.Button();
        _btnNewTable.Click += btnNewTTableAccepted_Click;
        _lblTableNumber = new System.Windows.Forms.Label();
        _ErrorProvider1 = new System.Windows.Forms.ErrorProvider();
        _Panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // Panel1
        // 
        _Panel1.BackColor = System.Drawing.Color.LightGray;
        _Panel1.Controls.Add(_chbActive);
        _Panel1.Controls.Add(_chbAvailable);
        _Panel1.Controls.Add(_btnClose);
        _Panel1.Controls.Add(_txtWidth);
        _Panel1.Controls.Add(_txtHeight);
        _Panel1.Controls.Add(_lblWidth);
        _Panel1.Controls.Add(_lblHeight);
        _Panel1.Controls.Add(_txtSeats);
        _Panel1.Controls.Add(_lblSeats);
        _Panel1.Controls.Add(_txtTableNum);
        _Panel1.Controls.Add(_btnNewTable);
        _Panel1.Controls.Add(_lblTableNumber);
        _Panel1.Location = new System.Drawing.Point(8, 16);
        _Panel1.Name = "_Panel1";
        _Panel1.Size = new System.Drawing.Size(232, 320);
        _Panel1.TabIndex = 0;
        // 
        // chbActive
        // 
        _chbActive.Location = new System.Drawing.Point(32, 208);
        _chbActive.Name = "_chbActive";
        _chbActive.TabIndex = 5;
        _chbActive.Text = "Display on POS";
        // 
        // chbAvailable
        // 
        _chbAvailable.Location = new System.Drawing.Point(32, 176);
        _chbAvailable.Name = "_chbAvailable";
        _chbAvailable.Size = new System.Drawing.Size(168, 24);
        _chbAvailable.TabIndex = 4;
        _chbAvailable.Text = "Available at Open";
        // 
        // btnClose
        // 
        _btnClose.Location = new System.Drawing.Point(128, 264);
        _btnClose.Name = "_btnClose";
        _btnClose.Size = new System.Drawing.Size(80, 40);
        _btnClose.TabIndex = 7;
        _btnClose.TabStop = false;
        _btnClose.Text = "Close";
        // 
        // txtWidth
        // 
        _txtWidth.Location = new System.Drawing.Point(112, 88);
        _txtWidth.Name = "_txtWidth";
        _txtWidth.Size = new System.Drawing.Size(56, 20);
        _txtWidth.TabIndex = 2;
        _txtWidth.Text = "";
        // 
        // txtHeight
        // 
        _txtHeight.Location = new System.Drawing.Point(112, 120);
        _txtHeight.Name = "_txtHeight";
        _txtHeight.Size = new System.Drawing.Size(56, 20);
        _txtHeight.TabIndex = 3;
        _txtHeight.Text = "";
        // 
        // lblWidth
        // 
        _lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblWidth.ForeColor = System.Drawing.Color.DarkBlue;
        _lblWidth.Location = new System.Drawing.Point(24, 88);
        _lblWidth.Name = "_lblWidth";
        _lblWidth.Size = new System.Drawing.Size(64, 16);
        _lblWidth.TabIndex = 6;
        _lblWidth.Text = "Width";
        // 
        // lblHeight
        // 
        _lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblHeight.ForeColor = System.Drawing.Color.DarkBlue;
        _lblHeight.Location = new System.Drawing.Point(24, 120);
        _lblHeight.Name = "_lblHeight";
        _lblHeight.Size = new System.Drawing.Size(64, 16);
        _lblHeight.TabIndex = 5;
        _lblHeight.Text = "Height";
        // 
        // txtSeats
        // 
        _txtSeats.Location = new System.Drawing.Point(112, 56);
        _txtSeats.Name = "_txtSeats";
        _txtSeats.Size = new System.Drawing.Size(56, 20);
        _txtSeats.TabIndex = 1;
        _txtSeats.Text = "";
        // 
        // lblSeats
        // 
        _lblSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblSeats.ForeColor = System.Drawing.Color.DarkBlue;
        _lblSeats.Location = new System.Drawing.Point(24, 56);
        _lblSeats.Name = "_lblSeats";
        _lblSeats.Size = new System.Drawing.Size(64, 16);
        _lblSeats.TabIndex = 3;
        _lblSeats.Text = "Seats";
        // 
        // txtTableNum
        // 
        _txtTableNum.Location = new System.Drawing.Point(112, 16);
        _txtTableNum.Name = "_txtTableNum";
        _txtTableNum.Size = new System.Drawing.Size(56, 20);
        _txtTableNum.TabIndex = 0;
        _txtTableNum.Text = "";
        // 
        // btnNewTable
        // 
        _btnNewTable.Location = new System.Drawing.Point(24, 264);
        _btnNewTable.Name = "_btnNewTable";
        _btnNewTable.Size = new System.Drawing.Size(80, 40);
        _btnNewTable.TabIndex = 1;
        _btnNewTable.TabStop = false;
        _btnNewTable.Text = "Create New";
        // 
        // lblTableNumber
        // 
        _lblTableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblTableNumber.ForeColor = System.Drawing.Color.DarkBlue;
        _lblTableNumber.Location = new System.Drawing.Point(24, 8);
        _lblTableNumber.Name = "_lblTableNumber";
        _lblTableNumber.Size = new System.Drawing.Size(136, 32);
        _lblTableNumber.TabIndex = 0;
        _lblTableNumber.Text = "Table #";
        _lblTableNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // ErrorProvider1
        // 
        _ErrorProvider1.ContainerControl = this;
        // 
        // TableInfo_UC
        // 
        this.BackColor = System.Drawing.Color.LightGray;
        this.Controls.Add(_Panel1);
        this.Name = "TableInfo_UC";
        this.Size = new System.Drawing.Size(248, 344);
        _Panel1.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private void InitializeOther()
    {

        if (IsNewTable == false)
        {
            btnNewTable.Text = "Update";
        }

        BindData();

    }
    private void BindData()
    {

        txtTableNum.Text = CurrentTable.PhysicalTableNumber;
        txtSeats.Text = CurrentTable.Seats;
        txtWidth.Text = CurrentTable.myWidth;
        txtHeight.Text = CurrentTable.myHeight;
        chbAvailable.Checked = CurrentTable.Available;
        chbActive.Checked = CurrentTable.Active;

    }

    private void txtTableNum_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        var argtxtValNumeric = txtTableNum;
        ValidateNumeric(ref argtxtValNumeric);
        txtTableNum = argtxtValNumeric;
    }

    private void txtSeats_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        var argtxtValNumeric = txtSeats;
        ValidateNumeric(ref argtxtValNumeric);
        txtSeats = argtxtValNumeric;
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

    private void btnNewTTableAccepted_Click(object sender, EventArgs e)
    {

        if (ErrorProvider1.GetError(txtTableNum).Length == 0 & ErrorProvider1.GetError(txtSeats).Length == 0 & ErrorProvider1.GetError(txtWidth).Length == 0 & ErrorProvider1.GetError(txtHeight).Length == 0)
        {
            CurrentTable.PhysicalTableNumber = txtTableNum.Text;
            CurrentTable.Seats = txtSeats.Text;
            CurrentTable.myWidth = txtWidth.Text;
            CurrentTable.myHeight = txtHeight.Text;
            CurrentTable.Available = chbAvailable.Checked;
            CurrentTable.Active = chbActive.Checked;

            if (IsNewTable == true)
            {
                NewTableAccepted?.Invoke();
            }
            else
            {
                UpdateOldTable?.Invoke();
            }
        }

    }

    private void btnCancel_Click(object sender, EventArgs e)
    {

        TableCancel?.Invoke();

    }

}