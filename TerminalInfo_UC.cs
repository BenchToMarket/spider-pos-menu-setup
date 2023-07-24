using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using DataSet_Builder;


public partial class TerminalInfo_UC : System.Windows.Forms.UserControl
{

    private bool _isNewTerminal;
    private bool _changesMade;
    private int _newIndex;
    private bool StandardOrdering = true;

    private Terminal _currentTerminal;
    internal DataView dvUseOrder;
    internal bool priority1 = false;
    internal bool priority2 = false;
    internal bool priority3 = false;


    internal bool IsNewTerminal
    {
        get
        {
            return _isNewTerminal;
        }
        set
        {
            _isNewTerminal = value;
        }
    }

    internal Terminal CurrentTerminal
    {
        get
        {
            return _currentTerminal;
        }
        set
        {
            _currentTerminal = value;
        }
    }

    public event NewTerminalAcceptedEventHandler NewTerminalAccepted;

    public delegate void NewTerminalAcceptedEventHandler();
    public event UpdateOldTerminalEventHandler UpdateOldTerminal;

    public delegate void UpdateOldTerminalEventHandler();
    public event TerminalCancelEventHandler TerminalCancel;

    public delegate void TerminalCancelEventHandler();
    public event NewUseOrderRowEventHandler NewUseOrderRow;

    public delegate void NewUseOrderRowEventHandler(int useOrder, string newUse);

    #region  Windows Form Designer generated code 

    public TerminalInfo_UC(bool isNT, Terminal tempTerminal) : base()
    {

        _isNewTerminal = isNT;
        _currentTerminal = tempTerminal;

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
    private Global.System.Windows.Forms.Button _btnNewTerminalAccepted;

    internal virtual Global.System.Windows.Forms.Button btnNewTerminalAccepted
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnNewTerminalAccepted;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnNewTerminalAccepted != null)
            {
                _btnNewTerminalAccepted.Click -= btnNewTerminalAccepted_Click;
            }

            _btnNewTerminalAccepted = value;
            if (_btnNewTerminalAccepted != null)
            {
                _btnNewTerminalAccepted.Click += btnNewTerminalAccepted_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Label _lblTermNum;

    internal virtual Global.System.Windows.Forms.Label lblTermNum
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblTermNum;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblTermNum = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtTermName;

    internal virtual Global.System.Windows.Forms.TextBox txtTermName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtTermName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtTermName != null)
            {
                _txtTermName.Validating -= txtTermName_Validating;
            }

            _txtTermName = value;
            if (_txtTermName != null)
            {
                _txtTermName.Validating += txtTermName_Validating;
            }
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxTermMethod;

    internal virtual Global.System.Windows.Forms.ComboBox cbxTermMethod
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxTermMethod;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxTermMethod != null)
            {
                _cbxTermMethod.SelectedIndexChanged -= cbxTermMethod_SelectedIndexChanged;
            }

            _cbxTermMethod = value;
            if (_cbxTermMethod != null)
            {
                _cbxTermMethod.SelectedIndexChanged += cbxTermMethod_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxTermGroup;

    internal virtual Global.System.Windows.Forms.ComboBox cbxTermGroup
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxTermGroup;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxTermGroup != null)
            {
                _cbxTermGroup.SelectedIndexChanged -= cbxTermGroup_SelectedIndexChanged;
            }

            _cbxTermGroup = value;
            if (_cbxTermGroup != null)
            {
                _cbxTermGroup.SelectedIndexChanged += cbxTermGroup_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.Label _Label1;

    internal virtual Global.System.Windows.Forms.Label Label1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label1 = value;
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
    private Global.System.Windows.Forms.Button _btnStdOrdering;

    internal virtual Global.System.Windows.Forms.Button btnStdOrdering
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnStdOrdering;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnStdOrdering != null)
            {
                _btnStdOrdering.Click -= btnStdOrdering_Click;
            }

            _btnStdOrdering = value;
            if (_btnStdOrdering != null)
            {
                _btnStdOrdering.Click += btnStdOrdering_Click;
            }
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxPriority1;

    internal virtual Global.System.Windows.Forms.ComboBox cbxPriority1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxPriority1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxPriority1 != null)
            {
                _cbxPriority1.SelectedIndexChanged -= cbxPriority1_SelectedIndexChanged;
            }

            _cbxPriority1 = value;
            if (_cbxPriority1 != null)
            {
                _cbxPriority1.SelectedIndexChanged += cbxPriority1_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxPriority2;

    internal virtual Global.System.Windows.Forms.ComboBox cbxPriority2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxPriority2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxPriority2 != null)
            {
                _cbxPriority2.SelectedIndexChanged -= cbxPriority2_SelectedIndexChanged;
            }

            _cbxPriority2 = value;
            if (_cbxPriority2 != null)
            {
                _cbxPriority2.SelectedIndexChanged += cbxPriority2_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxPriority3;

    internal virtual Global.System.Windows.Forms.ComboBox cbxPriority3
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxPriority3;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxPriority3 != null)
            {
                _cbxPriority3.SelectedIndexChanged -= cbxPriority3_SelectedIndexChanged;
            }

            _cbxPriority3 = value;
            if (_cbxPriority3 != null)
            {
                _cbxPriority3.SelectedIndexChanged += cbxPriority3_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.Label _Label2;

    internal virtual Global.System.Windows.Forms.Label Label2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label2 = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlPriority;

    internal virtual Global.System.Windows.Forms.Panel pnlPriority
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlPriority;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlPriority = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label3;

    internal virtual Global.System.Windows.Forms.Label Label3
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label3;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label3 = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label4;

    internal virtual Global.System.Windows.Forms.Label Label4
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label4;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label4 = value;
        }
    }
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        _btnNewTerminalAccepted = new System.Windows.Forms.Button();
        _btnNewTerminalAccepted.Click += btnNewTerminalAccepted_Click;
        _lblTermNum = new System.Windows.Forms.Label();
        _txtTermName = new System.Windows.Forms.TextBox();
        _txtTermName.Validating += txtTermName_Validating;
        _cbxTermMethod = new System.Windows.Forms.ComboBox();
        _cbxTermMethod.SelectedIndexChanged += cbxTermMethod_SelectedIndexChanged;
        _cbxTermGroup = new System.Windows.Forms.ComboBox();
        _cbxTermGroup.SelectedIndexChanged += cbxTermGroup_SelectedIndexChanged;
        _Label1 = new System.Windows.Forms.Label();
        _btnCancel = new System.Windows.Forms.Button();
        _btnCancel.Click += btnCancel_Click;
        _ErrorProvider1 = new System.Windows.Forms.ErrorProvider();
        _btnStdOrdering = new System.Windows.Forms.Button();
        _btnStdOrdering.Click += btnStdOrdering_Click;
        _cbxPriority1 = new System.Windows.Forms.ComboBox();
        _cbxPriority1.SelectedIndexChanged += cbxPriority1_SelectedIndexChanged;
        _cbxPriority2 = new System.Windows.Forms.ComboBox();
        _cbxPriority2.SelectedIndexChanged += cbxPriority2_SelectedIndexChanged;
        _cbxPriority3 = new System.Windows.Forms.ComboBox();
        _cbxPriority3.SelectedIndexChanged += cbxPriority3_SelectedIndexChanged;
        _Label2 = new System.Windows.Forms.Label();
        _pnlPriority = new System.Windows.Forms.Panel();
        _Label4 = new System.Windows.Forms.Label();
        _Label3 = new System.Windows.Forms.Label();
        _pnlPriority.SuspendLayout();
        this.SuspendLayout();
        // 
        // btnNewTerminalAccepted
        // 
        _btnNewTerminalAccepted.Location = new System.Drawing.Point(24, 288);
        _btnNewTerminalAccepted.Name = "_btnNewTerminalAccepted";
        _btnNewTerminalAccepted.Size = new System.Drawing.Size(88, 40);
        _btnNewTerminalAccepted.TabIndex = 0;
        _btnNewTerminalAccepted.TabStop = false;
        _btnNewTerminalAccepted.Text = "Create New";
        // 
        // lblTermNum
        // 
        _lblTermNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblTermNum.ForeColor = System.Drawing.Color.DarkBlue;
        _lblTermNum.Location = new System.Drawing.Point(16, 16);
        _lblTermNum.Name = "_lblTermNum";
        _lblTermNum.Size = new System.Drawing.Size(216, 24);
        _lblTermNum.TabIndex = 1;
        _lblTermNum.Text = "Terminal #   ";
        _lblTermNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtTermName
        // 
        _txtTermName.Location = new System.Drawing.Point(56, 64);
        _txtTermName.Name = "_txtTermName";
        _txtTermName.Size = new System.Drawing.Size(176, 20);
        _txtTermName.TabIndex = 0;
        _txtTermName.Text = "";
        // 
        // cbxTermMethod
        // 
        _cbxTermMethod.Location = new System.Drawing.Point(56, 96);
        _cbxTermMethod.Name = "_cbxTermMethod";
        _cbxTermMethod.Size = new System.Drawing.Size(176, 21);
        _cbxTermMethod.TabIndex = 1;
        // 
        // cbxTermGroup
        // 
        _cbxTermGroup.Location = new System.Drawing.Point(56, 128);
        _cbxTermGroup.Name = "_cbxTermGroup";
        _cbxTermGroup.Size = new System.Drawing.Size(176, 21);
        _cbxTermGroup.TabIndex = 2;
        _cbxTermGroup.Text = "No Terminal Group";
        // 
        // Label1
        // 
        _Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label1.ForeColor = System.Drawing.Color.DarkBlue;
        _Label1.Location = new System.Drawing.Point(16, 40);
        _Label1.Name = "_Label1";
        _Label1.Size = new System.Drawing.Size(160, 16);
        _Label1.TabIndex = 5;
        _Label1.Text = "Name (case sensitive)";
        // 
        // btnCancel
        // 
        _btnCancel.Location = new System.Drawing.Point(136, 288);
        _btnCancel.Name = "_btnCancel";
        _btnCancel.Size = new System.Drawing.Size(88, 40);
        _btnCancel.TabIndex = 6;
        _btnCancel.TabStop = false;
        _btnCancel.Text = "Close";
        // 
        // ErrorProvider1
        // 
        _ErrorProvider1.ContainerControl = this;
        // 
        // btnStdOrdering
        // 
        _btnStdOrdering.Location = new System.Drawing.Point(16, 160);
        _btnStdOrdering.Name = "_btnStdOrdering";
        _btnStdOrdering.Size = new System.Drawing.Size(136, 24);
        _btnStdOrdering.TabIndex = 7;
        _btnStdOrdering.Text = "Standard Ordering";
        // 
        // cbxPriority1
        // 
        _cbxPriority1.Items.AddRange(new object[] { "None", "Dine In", "Take Out", "Delivery" });
        _cbxPriority1.Location = new System.Drawing.Point(104, 8);
        _cbxPriority1.Name = "_cbxPriority1";
        _cbxPriority1.Size = new System.Drawing.Size(121, 21);
        _cbxPriority1.TabIndex = 8;
        _cbxPriority1.Text = "None";
        // 
        // cbxPriority2
        // 
        _cbxPriority2.Items.AddRange(new object[] { "None", "Dine In", "Take Out", "Delivery" });
        _cbxPriority2.Location = new System.Drawing.Point(104, 40);
        _cbxPriority2.Name = "_cbxPriority2";
        _cbxPriority2.Size = new System.Drawing.Size(121, 21);
        _cbxPriority2.TabIndex = 9;
        _cbxPriority2.Text = "None";
        // 
        // cbxPriority3
        // 
        _cbxPriority3.Items.AddRange(new object[] { "None", "Dine In", "Take Out", "Delivery" });
        _cbxPriority3.Location = new System.Drawing.Point(104, 72);
        _cbxPriority3.Name = "_cbxPriority3";
        _cbxPriority3.Size = new System.Drawing.Size(121, 21);
        _cbxPriority3.TabIndex = 10;
        _cbxPriority3.Text = "None";
        // 
        // Label2
        // 
        _Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label2.ForeColor = System.Drawing.Color.DarkBlue;
        _Label2.Location = new System.Drawing.Point(16, 8);
        _Label2.Name = "_Label2";
        _Label2.Size = new System.Drawing.Size(72, 16);
        _Label2.TabIndex = 11;
        _Label2.Text = "Priority 1";
        // 
        // pnlPriority
        // 
        _pnlPriority.Controls.Add(_Label4);
        _pnlPriority.Controls.Add(_Label3);
        _pnlPriority.Controls.Add(_Label2);
        _pnlPriority.Controls.Add(_cbxPriority3);
        _pnlPriority.Controls.Add(_cbxPriority2);
        _pnlPriority.Controls.Add(_cbxPriority1);
        _pnlPriority.Location = new System.Drawing.Point(8, 184);
        _pnlPriority.Name = "_pnlPriority";
        _pnlPriority.Size = new System.Drawing.Size(232, 96);
        _pnlPriority.TabIndex = 12;
        _pnlPriority.Visible = false;
        // 
        // Label4
        // 
        _Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label4.ForeColor = System.Drawing.Color.DarkBlue;
        _Label4.Location = new System.Drawing.Point(16, 72);
        _Label4.Name = "_Label4";
        _Label4.Size = new System.Drawing.Size(72, 16);
        _Label4.TabIndex = 13;
        _Label4.Text = "Priority 3";
        // 
        // Label3
        // 
        _Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label3.ForeColor = System.Drawing.Color.DarkBlue;
        _Label3.Location = new System.Drawing.Point(16, 40);
        _Label3.Name = "_Label3";
        _Label3.Size = new System.Drawing.Size(72, 16);
        _Label3.TabIndex = 12;
        _Label3.Text = "Priority 2";
        // 
        // TerminalInfo_UC
        // 
        this.BackColor = System.Drawing.Color.LightGray;
        this.Controls.Add(_pnlPriority);
        this.Controls.Add(_btnStdOrdering);
        this.Controls.Add(_btnCancel);
        this.Controls.Add(_Label1);
        this.Controls.Add(_cbxTermGroup);
        this.Controls.Add(_cbxTermMethod);
        this.Controls.Add(_txtTermName);
        this.Controls.Add(_lblTermNum);
        this.Controls.Add(_btnNewTerminalAccepted);
        this.Name = "TerminalInfo_UC";
        this.Size = new System.Drawing.Size(248, 344);
        _pnlPriority.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private void InitializeOther()
    {

        if (IsNewTerminal == false)
        {
            btnNewTerminalAccepted.Text = "Update";
        }

        BindData();

    }

    private void BindData()
    {

        cbxTermMethod.Items.Add("Table");
        cbxTermMethod.Items.Add("Bar");
        cbxTermMethod.Items.Add("Quick");

        cbxTermGroup.Items.Add("No Terminal Group");
        foreach (DataRow oRow in dsSetup.Tables("TermGroups").Rows)
            cbxTermGroup.Items.Add(oRow("TerminalsGroupName"));

        lblTermNum.Text = "Terminal #  " + CurrentTerminal.TermID;
        txtTermName.Text = CurrentTerminal.TermName;
        cbxTermMethod.SelectedText = CurrentTerminal.TermMethod;
        if (CurrentTerminal.TermGroupID == 0)
        {
            cbxTermGroup.Text = "No Terminal Group";
        }
        else
        {
            cbxTermGroup.Text = CurrentTerminal.TermGroupName;
        }

        dvUseOrder = new DataView();
        if (IsNewTerminal == false)
        {
            {
                ref var withBlock = ref dvUseOrder;
                withBlock.Table = dsSetup.Tables("TerminalsUseOrder");
                withBlock.RowFilter = "TerminalsPrimaryKey = " + CurrentTerminal.TermPrimaryKey;
                withBlock.RowStateFilter = DataViewRowState.CurrentRows;
                withBlock.Sort = "UsePriority ASC";
            }

            foreach (DataRowView vRow in dvUseOrder)
            {
                pnlPriority.Visible = true;
                btnStdOrdering.Text = "Priority Ordering";
                StandardOrdering = false;
                switch (vRow("UsePriority"))
                {
                    case 1:
                        {
                            priority1 = true;    // this only says there is a row
                            if (vRow("Active") == true)
                            {
                                cbxPriority1.Text = vRow("MethodUse");
                            }

                            break;
                        }
                    case 2:
                        {
                            priority2 = true;
                            if (vRow("Active") == true)
                            {
                                cbxPriority2.Text = vRow("MethodUse");
                            }

                            break;
                        }
                    case 3:
                        {
                            priority3 = true;
                            if (vRow("Active") == true)
                            {
                                cbxPriority3.Text = vRow("MethodUse");
                            }

                            break;
                        }
                }
            }
        }

    }

    private void cbxTermMethod_SelectedIndexChanged(object sender, EventArgs e)
    {

        CurrentTerminal.TermMethod = cbxTermMethod.SelectedItem;

    }

    private void cbxTermGroup_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (cbxTermGroup.SelectedItem == "No Terminal Group")
        {
            CurrentTerminal.TermGroupID = 0;
        }
        else
        {
            foreach (DataRow oRow in dsSetup.Tables("TermGroups").Rows)
            {
                if (cbxTermGroup.SelectedItem == oRow("TerminalsGroupName"))
                {
                    CurrentTerminal.TermGroupID = oRow("TerminalsGroupID");
                }
            }
        }

    }

    private void txtTermName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        var argtxtValNumeric = txtTermName;
        ValidateNumeric(ref argtxtValNumeric);
        txtTermName = argtxtValNumeric;
    }

    private void ValidateNumeric(ref TextBox txtValNumeric)
    {

        if (txtValNumeric.Text == "")
        {
            ErrorProvider1.SetError(txtValNumeric, "This TextBox can not be Blank.");
            txtValNumeric.Focus();
            Interaction.Beep();
        }
        else if (!(Information.TypeName(txtValNumeric.Text) == "String"))
        {
            ErrorProvider1.SetError(txtValNumeric, "This must be a String value.");
            txtValNumeric.Focus();
            Interaction.Beep();
        }
        else
        {
            // cancels the error
            ErrorProvider1.Dispose();
        }

    }

    private void btnNewTerminalAccepted_Click(object sender, EventArgs e)
    {

        if (ErrorProvider1.GetError(txtTermName).Length == 0)
        {
            // Dim vCount As Integer = 1
            // CurrentTerminal.TermName = Me.txtTermName.Text
            if (StandardOrdering == true)
            {
                if (dvUseOrder.Count > 0)
                {
                    foreach (DataRowView vRow in dvUseOrder)
                        vRow("Active") = 0;
                }
            }

            if (IsNewTerminal == true)
            {
                NewTerminalAccepted?.Invoke();
                this.Dispose();
            }
            else
            {
                UpdateOldTerminal?.Invoke();
            }
        }

    }

    private void btnCancel_Click(object sender, EventArgs e)
    {

        TerminalCancel?.Invoke();

    }

    private void btnStdOrdering_Click(object sender, EventArgs e)
    {
        if (StandardOrdering == true)
        {
            // switching to Priority Ordering
            pnlPriority.Visible = true;
            StandardOrdering = false;
            btnStdOrdering.Text = "Priority Ordering";
        }
        else
        {
            pnlPriority.Visible = false;
            StandardOrdering = true;
            btnStdOrdering.Text = "Standard Ordering";
        }

    }

    private void cbxPriority1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (priority1 == false & !(cbxPriority1.SelectedItem == "None"))
        {
            // this means we need to add a new row to TerminalsUseOrder
            if (IsNewTerminal == true)
            {
                CurrentTerminal.TermName = txtTermName.Text;
                NewTerminalAccepted?.Invoke();
                IsNewTerminal = false;
            }

            NewUseOrderRow?.Invoke(1, cbxPriority1.SelectedItem);
            priority1 = true;
        }
        else if (priority1 == true)
        {
            ChangeUseOrderData(1, cbxPriority1.SelectedItem);
        }
    }

    private void cbxPriority2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (priority2 == false & !(cbxPriority2.SelectedItem == "None"))
        {
            // this means we need to add a new row to TerminalsUseOrder
            if (IsNewTerminal == true)
            {
                CurrentTerminal.TermName = txtTermName.Text;
                NewTerminalAccepted?.Invoke();
                IsNewTerminal = false;
            }
            NewUseOrderRow?.Invoke(2, cbxPriority1.SelectedItem);
            priority2 = true;
        }
        else if (priority2 == true)
        {
            ChangeUseOrderData(2, cbxPriority2.SelectedItem);
        }
    }

    private void cbxPriority3_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (priority3 == false & !(cbxPriority3.SelectedItem == "None"))
        {
            // this means we need to add a new row to TerminalsUseOrder
            if (IsNewTerminal == true)
            {
                CurrentTerminal.TermName = txtTermName.Text;
                NewTerminalAccepted?.Invoke();
                IsNewTerminal = false;
            }
            NewUseOrderRow?.Invoke(3, cbxPriority1.SelectedItem);
            priority3 = true;
        }
        else if (priority3 == true)
        {
            ChangeUseOrderData(3, cbxPriority3.SelectedItem);
        }
    }

    private void ChangeUseOrderData(int useOrder, string newUse)
    {

        foreach (DataRowView vRow in dvUseOrder)
        {
            if (vRow("UsePriority") == useOrder)
            {
                if (!(newUse == "None"))
                {
                    vRow("MethodUse") = newUse;
                    vRow("Active") = 1;
                }
                else
                {
                    vRow("MethodUse") = newUse;
                    vRow("Active") = 0;
                }
            }
        }
    }
}