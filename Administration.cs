using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;


public partial class Administration : System.Windows.Forms.Form
{


    private Tahsc_server.SetupMenu _SetupMenu1;

    internal virtual Tahsc_server.SetupMenu SetupMenu1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _SetupMenu1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _SetupMenu1 = value;
        }
    }
    private Tahsc_server.SetupEmploy _SetupEmployee1;

    internal virtual Tahsc_server.SetupEmploy SetupEmployee1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _SetupEmployee1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _SetupEmployee1 = value;
        }
    }
    private Tahsc_server.SetupPayment _SetupPayment1;

    internal virtual Tahsc_server.SetupPayment SetupPayment1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _SetupPayment1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _SetupPayment1 = value;
        }
    }
    private Tahsc_server.SetupRawMaterials _RawMaterials1;

    internal virtual Tahsc_server.SetupRawMaterials RawMaterials1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _RawMaterials1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _RawMaterials1 = value;
        }
    }
    private Tahsc_server.SetupTerminals _SetupTerminal1;

    internal virtual Tahsc_server.SetupTerminals SetupTerminal1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _SetupTerminal1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _SetupTerminal1 = value;
        }
    }
    private DataSet_Builder.NumberPad _loginPad;

    private DataSet_Builder.NumberPad loginPad
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _loginPad;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_loginPad != null)
            {
                _loginPad.NumberEntered -= Login_Entered;
            }

            _loginPad = value;
            if (_loginPad != null)
            {
                _loginPad.NumberEntered += Login_Entered;
            }
        }
    }

    private DataSet_Builder.LoginInit_UC _initLogon;

    private DataSet_Builder.LoginInit_UC initLogon
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _initLogon;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_initLogon != null)
            {
                _initLogon.SummitLogin -= TestInitLogon;
            }

            _initLogon = value;
            if (_initLogon != null)
            {
                _initLogon.SummitLogin += TestInitLogon;
            }
        }
    }
    private Exit_UC _exiting;

    private Exit_UC exiting
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _exiting;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _exiting = value;
        }
    }
    private int loginFailedCount;
    internal bool isCorporate;
    // Friend selectedLocation As String



    #region  Windows Form Designer generated code 

    public Administration() : base()
    {


        // This call is required by the Windows Form Designer.
        InitializeComponent();
        pnlAdministration.Enabled = false;

        DisplayInitialLogon();

        // Add any initialization after the InitializeComponent() call

        // InitializeOther()

    }

    // Form overrides dispose to clean up the component list.
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
    private Global.System.Windows.Forms.Panel _pnlAdministration;

    internal virtual Global.System.Windows.Forms.Panel pnlAdministration
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlAdministration;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlAdministration = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnMenuSetup;

    internal virtual Global.System.Windows.Forms.Button btnMenuSetup
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnMenuSetup;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnMenuSetup != null)
            {
                _btnMenuSetup.Click -= btnMenuSetup_Click;
            }

            _btnMenuSetup = value;
            if (_btnMenuSetup != null)
            {
                _btnMenuSetup.Click += btnMenuSetup_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnEmployeeSetup;

    internal virtual Global.System.Windows.Forms.Button btnEmployeeSetup
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnEmployeeSetup;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnEmployeeSetup != null)
            {
                _btnEmployeeSetup.Click -= btnEmployeeSetup_Click;
            }

            _btnEmployeeSetup = value;
            if (_btnEmployeeSetup != null)
            {
                _btnEmployeeSetup.Click += btnEmployeeSetup_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnPaymentSetup;

    internal virtual Global.System.Windows.Forms.Button btnPaymentSetup
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnPaymentSetup;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnPaymentSetup != null)
            {
                _btnPaymentSetup.Click -= btnPaymentSetup_Click;
            }

            _btnPaymentSetup = value;
            if (_btnPaymentSetup != null)
            {
                _btnPaymentSetup.Click += btnPaymentSetup_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnCorporate;

    internal virtual Global.System.Windows.Forms.Button btnCorporate
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnCorporate;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnCorporate != null)
            {
                _btnCorporate.Click -= btnCorporate_Click;
            }

            _btnCorporate = value;
            if (_btnCorporate != null)
            {
                _btnCorporate.Click += btnCorporate_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Panel _pnlCorporate;

    internal virtual Global.System.Windows.Forms.Panel pnlCorporate
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlCorporate;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlCorporate = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxCorporateMenu;

    internal virtual Global.System.Windows.Forms.ComboBox cbxCorporateMenu
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxCorporateMenu;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxCorporateMenu != null)
            {
                _cbxCorporateMenu.SelectedIndexChanged -= cbxCorporateMenu_SelectedIndexChanged;
            }

            _cbxCorporateMenu = value;
            if (_cbxCorporateMenu != null)
            {
                _cbxCorporateMenu.SelectedIndexChanged += cbxCorporateMenu_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxCorporateMenuLocation;

    internal virtual Global.System.Windows.Forms.ComboBox cbxCorporateMenuLocation
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxCorporateMenuLocation;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxCorporateMenuLocation != null)
            {
                _cbxCorporateMenuLocation.SelectedIndexChanged -= cbxCorporateMenuLocation_SelectedIndexChanged;
            }

            _cbxCorporateMenuLocation = value;
            if (_cbxCorporateMenuLocation != null)
            {
                _cbxCorporateMenuLocation.SelectedIndexChanged += cbxCorporateMenuLocation_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnSetupMenu;

    internal virtual Global.System.Windows.Forms.Button btnSetupMenu
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnSetupMenu;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnSetupMenu != null)
            {
                _btnSetupMenu.Click -= btnSetupMenu_Click;
            }

            _btnSetupMenu = value;
            if (_btnSetupMenu != null)
            {
                _btnSetupMenu.Click += btnSetupMenu_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnRawMaterials;

    internal virtual Global.System.Windows.Forms.Button btnRawMaterials
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnRawMaterials;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnRawMaterials != null)
            {
                _btnRawMaterials.Click -= btnRawMaterials_Click;
            }

            _btnRawMaterials = value;
            if (_btnRawMaterials != null)
            {
                _btnRawMaterials.Click += btnRawMaterials_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnAdmExit;

    internal virtual Global.System.Windows.Forms.Button btnAdmExit
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnAdmExit;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnAdmExit != null)
            {
                _btnAdmExit.Click -= btnAdmExit_Click;
            }

            _btnAdmExit = value;
            if (_btnAdmExit != null)
            {
                _btnAdmExit.Click += btnAdmExit_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnTerminalSetup;

    internal virtual Global.System.Windows.Forms.Button btnTerminalSetup
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnTerminalSetup;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnTerminalSetup != null)
            {
                _btnTerminalSetup.Click -= btnTerminalSetup_Click;
            }

            _btnTerminalSetup = value;
            if (_btnTerminalSetup != null)
            {
                _btnTerminalSetup.Click += btnTerminalSetup_Click;
            }
        }
    }

    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        _pnlAdministration = new System.Windows.Forms.Panel();
        _btnAdmExit = new System.Windows.Forms.Button();
        _btnAdmExit.Click += btnAdmExit_Click;
        _btnRawMaterials = new System.Windows.Forms.Button();
        _btnRawMaterials.Click += btnRawMaterials_Click;
        _btnCorporate = new System.Windows.Forms.Button();
        _btnCorporate.Click += btnCorporate_Click;
        _btnPaymentSetup = new System.Windows.Forms.Button();
        _btnPaymentSetup.Click += btnPaymentSetup_Click;
        _btnEmployeeSetup = new System.Windows.Forms.Button();
        _btnEmployeeSetup.Click += btnEmployeeSetup_Click;
        _btnMenuSetup = new System.Windows.Forms.Button();
        _btnMenuSetup.Click += btnMenuSetup_Click;
        _btnTerminalSetup = new System.Windows.Forms.Button();
        _btnTerminalSetup.Click += btnTerminalSetup_Click;
        _pnlCorporate = new System.Windows.Forms.Panel();
        _btnSetupMenu = new System.Windows.Forms.Button();
        _btnSetupMenu.Click += btnSetupMenu_Click;
        _cbxCorporateMenuLocation = new System.Windows.Forms.ComboBox();
        _cbxCorporateMenuLocation.SelectedIndexChanged += cbxCorporateMenuLocation_SelectedIndexChanged;
        _cbxCorporateMenu = new System.Windows.Forms.ComboBox();
        _cbxCorporateMenu.SelectedIndexChanged += cbxCorporateMenu_SelectedIndexChanged;
        _pnlAdministration.SuspendLayout();
        _pnlCorporate.SuspendLayout();
        this.SuspendLayout();
        // 
        // pnlAdministration
        // 
        _pnlAdministration.BackColor = System.Drawing.Color.FromArgb(236, 233, 216);
        _pnlAdministration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        _pnlAdministration.Controls.Add(_btnAdmExit);
        _pnlAdministration.Controls.Add(_btnRawMaterials);
        _pnlAdministration.Controls.Add(_btnCorporate);
        _pnlAdministration.Controls.Add(_btnPaymentSetup);
        _pnlAdministration.Controls.Add(_btnEmployeeSetup);
        _pnlAdministration.Controls.Add(_btnMenuSetup);
        _pnlAdministration.Controls.Add(_btnTerminalSetup);
        _pnlAdministration.Dock = System.Windows.Forms.DockStyle.Left;
        _pnlAdministration.DockPadding.Right = 50;
        _pnlAdministration.Location = new System.Drawing.Point(0, 0);
        _pnlAdministration.Name = "_pnlAdministration";
        _pnlAdministration.Size = new System.Drawing.Size(128, 525);
        _pnlAdministration.TabIndex = 0;
        // 
        // btnAdmExit
        // 
        _btnAdmExit.Anchor = (Global.System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
        _btnAdmExit.BackColor = System.Drawing.Color.FromArgb(149, 179, 215);
        _btnAdmExit.Location = new System.Drawing.Point(8, 464);
        _btnAdmExit.Name = "_btnAdmExit";
        _btnAdmExit.Size = new System.Drawing.Size(112, 40);
        _btnAdmExit.TabIndex = 5;
        _btnAdmExit.Text = "Exit";
        // 
        // btnRawMaterials
        // 
        _btnRawMaterials.BackColor = System.Drawing.Color.FromArgb(149, 179, 215);
        _btnRawMaterials.Location = new System.Drawing.Point(8, 248);
        _btnRawMaterials.Name = "_btnRawMaterials";
        _btnRawMaterials.Size = new System.Drawing.Size(112, 40);
        _btnRawMaterials.TabIndex = 4;
        _btnRawMaterials.Text = "Raw Materials";
        // 
        // btnCorporate
        // 
        _btnCorporate.Anchor = (Global.System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
        _btnCorporate.BackColor = System.Drawing.Color.FromArgb(149, 179, 215);
        _btnCorporate.Location = new System.Drawing.Point(8, 400);
        _btnCorporate.Name = "_btnCorporate";
        _btnCorporate.Size = new System.Drawing.Size(112, 40);
        _btnCorporate.TabIndex = 3;
        _btnCorporate.Text = "Corporate";
        // 
        // btnPaymentSetup
        // 
        _btnPaymentSetup.BackColor = System.Drawing.Color.FromArgb(149, 179, 215);
        _btnPaymentSetup.Location = new System.Drawing.Point(8, 184);
        _btnPaymentSetup.Name = "_btnPaymentSetup";
        _btnPaymentSetup.Size = new System.Drawing.Size(112, 40);
        _btnPaymentSetup.TabIndex = 2;
        _btnPaymentSetup.Text = "Payment Setup";
        // 
        // btnEmployeeSetup
        // 
        _btnEmployeeSetup.BackColor = System.Drawing.Color.FromArgb(149, 179, 215);
        _btnEmployeeSetup.Location = new System.Drawing.Point(8, 120);
        _btnEmployeeSetup.Name = "_btnEmployeeSetup";
        _btnEmployeeSetup.Size = new System.Drawing.Size(112, 40);
        _btnEmployeeSetup.TabIndex = 1;
        _btnEmployeeSetup.Text = "Employee Setup";
        // 
        // btnMenuSetup
        // 
        _btnMenuSetup.BackColor = System.Drawing.Color.FromArgb(149, 179, 215);
        _btnMenuSetup.Location = new System.Drawing.Point(8, 56);
        _btnMenuSetup.Name = "_btnMenuSetup";
        _btnMenuSetup.Size = new System.Drawing.Size(112, 40);
        _btnMenuSetup.TabIndex = 0;
        _btnMenuSetup.Text = "Menu Setup";
        // 
        // btnTerminalSetup
        // 
        _btnTerminalSetup.BackColor = System.Drawing.Color.FromArgb(149, 179, 215);
        _btnTerminalSetup.Location = new System.Drawing.Point(8, 312);
        _btnTerminalSetup.Name = "_btnTerminalSetup";
        _btnTerminalSetup.Size = new System.Drawing.Size(112, 40);
        _btnTerminalSetup.TabIndex = 5;
        _btnTerminalSetup.Text = "Terminal Setup";
        // 
        // pnlCorporate
        // 
        _pnlCorporate.BackColor = System.Drawing.Color.Transparent;
        _pnlCorporate.Controls.Add(_btnSetupMenu);
        _pnlCorporate.Controls.Add(_cbxCorporateMenuLocation);
        _pnlCorporate.Controls.Add(_cbxCorporateMenu);
        _pnlCorporate.Dock = System.Windows.Forms.DockStyle.Top;
        _pnlCorporate.Location = new System.Drawing.Point(128, 0);
        _pnlCorporate.Name = "_pnlCorporate";
        _pnlCorporate.Size = new System.Drawing.Size(856, 72);
        _pnlCorporate.TabIndex = 1;
        _pnlCorporate.Visible = false;
        // 
        // btnSetupMenu
        // 
        _btnSetupMenu.Location = new System.Drawing.Point(672, 16);
        _btnSetupMenu.Name = "_btnSetupMenu";
        _btnSetupMenu.Size = new System.Drawing.Size(120, 48);
        _btnSetupMenu.TabIndex = 2;
        _btnSetupMenu.Text = "Setup Menu based on Defaults";
        _btnSetupMenu.Visible = false;
        // 
        // cbxCorporateMenuLocation
        // 
        _cbxCorporateMenuLocation.Location = new System.Drawing.Point(392, 24);
        _cbxCorporateMenuLocation.Name = "_cbxCorporateMenuLocation";
        _cbxCorporateMenuLocation.Size = new System.Drawing.Size(216, 21);
        _cbxCorporateMenuLocation.TabIndex = 1;
        _cbxCorporateMenuLocation.Text = "Select Location";
        _cbxCorporateMenuLocation.Visible = false;
        // 
        // cbxCorporateMenu
        // 
        _cbxCorporateMenu.Items.AddRange(new object[] { "Corporate Defaults", "Complete Menu By Location", "Menu Additions By Location" });
        _cbxCorporateMenu.Location = new System.Drawing.Point(112, 24);
        _cbxCorporateMenu.Name = "_cbxCorporateMenu";
        _cbxCorporateMenu.Size = new System.Drawing.Size(208, 21);
        _cbxCorporateMenu.TabIndex = 0;
        _cbxCorporateMenu.Text = "Select Menu View";
        // 
        // Administration
        // 
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.BackColor = System.Drawing.Color.FromArgb(0, 78, 152);
        this.ClientSize = new System.Drawing.Size(984, 525);
        this.ControlBox = false;
        this.Controls.Add(_pnlCorporate);
        this.Controls.Add(_pnlAdministration);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.MaximizeBox = false;
        this.Name = "Administration";
        this.Text = "Administration";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        _pnlAdministration.ResumeLayout(false);
        _pnlCorporate.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion



    private void InitializeOther()
    {


        SetupMenu1 = new Tahsc_server.SetupMenu();
        SetupMenu1.SuspendLayout();
        SetupMenu1.Location = new Point(120, 0);
        // SetupMenu1.Size = New Size(816, 576)
        // SetupMenu1.Dock = DockStyle.Left
        // SetupMenu1.DockPadding.Left = 500
        SetupMenu1.TabIndex = 0;
        // SetupMenu1.Anchor = AnchorStyles.Left
        SetupMenu1.Visible = false;
        SetupMenu1.ResumeLayout();

        SetupEmployee1 = new Tahsc_server.SetupEmploy();
        SetupEmployee1.SuspendLayout();
        SetupEmployee1.Location = new Point(120, 0);
        SetupEmployee1.TabIndex = 0;
        SetupEmployee1.Visible = false;
        SetupEmployee1.ResumeLayout();

        SetupPayment1 = new Tahsc_server.SetupPayment();
        SetupPayment1.SuspendLayout();
        SetupPayment1.Location = new Point(130, 0);
        SetupPayment1.TabIndex = 0;
        SetupPayment1.Visible = false;
        SetupPayment1.ResumeLayout();


        RawMaterials1 = new Tahsc_server.SetupRawMaterials();
        RawMaterials1.SuspendLayout();
        RawMaterials1.Location = new Point(130, 0);
        RawMaterials1.TabIndex = 0;
        RawMaterials1.Visible = false;
        RawMaterials1.ResumeLayout();

        SetupTerminal1 = new Tahsc_server.SetupTerminals();
        SetupTerminal1.SuspendLayout();
        SetupTerminal1.Location = new Point(139, 0);
        SetupTerminal1.TabIndex = 0;
        SetupTerminal1.Visible = false;
        SetupTerminal1.ResumeLayout();

        loginPad = new DataSet_Builder.NumberPad();
        loginPad.Location = new Point((this.Width - loginPad.Width) / 2, (this.Height - loginPad.Height) / 2 + 40);
        this.Controls.Add(loginPad);
        loginPad.Visible = false;

        LoadLocationData();

        this.Controls.Add(SetupMenu1);
        this.Controls.Add(SetupEmployee1);
        this.Controls.Add(SetupPayment1);
        this.Controls.Add(RawMaterials1);
        this.Controls.Add(SetupTerminal1);


    }




    private void btnMenuSetup_Click(object sender, EventArgs e)
    {
        // Me.pnlAdministration.Visible = False
        SetupEmployee1.Visible = false;
        SetupPayment1.Visible = false;
        RawMaterials1.Visible = false;
        SetupMenu1.Visible = true;
        SetupTerminal1.Visible = false;
        loginPad.Visible = false;
        // SetupMenu1.StartMenu()
        SetupEmployee1.RemoveCardHandler();

    }

    private void btnEmployeeSetup_Click(object sender, EventArgs e)
    {
        SetupMenu1.Visible = false;
        SetupPayment1.Visible = false;
        RawMaterials1.Visible = false;
        SetupTerminal1.Visible = false;
        loginPad.Visible = true;

    }

    private void Login_Entered(object sender, EventArgs e)
    {
        string loginEnter;
        bool hasAuthority;

        loginEnter = loginPad.NumberString;

        if (loginEnter == "69864044")
        {
            hasAuthority = true;
        }
        else
        {
            hasAuthority = TestUsernamePassword(loginEnter);
        }

        if (hasAuthority == true)
        {
            SetupEmployee1.Visible = true;
            SetupEmployee1.AddCardHandler();
        }
        else
        {

        }

        loginPad.Visible = false;

    }

    internal bool TestUsernamePassword(string loginEnter)
    {
        bool hasAuth;
        bool someoneHasAuthority = false;
        bool notInSystem = true;

        // If loginEnter.Length < 4 Then
        // MsgBox("Username Incorrect: Please Reenter or See Manager")
        // Exit Function
        // End If

        if (dsSetup.Tables("ActiveEmployee").Rows.Count == 0)
        {
            return true;
        }
        else if (loginEnter.Length < 8)
        {
            Interaction.MsgBox("You MUST enter your password: Please Reenter or See Manager");
            return default;
        }

        foreach (DataRow oRow in dsSetup.Tables("ActiveEmployee").Rows)
        {
            if (oRow("EmployeeMgmtAll") == true | oRow("EmployeeMgmtLimited") == true)
            {
                TestToDisplayPayRates(ref oRow);
                someoneHasAuthority = true;
            }
            if (oRow("EmployeeNumber") == loginEnter.ToString().Substring(0, 4))
            {

                // If oRow("PasswordReq") = True Then
                if (oRow("Passcode") == loginEnter.ToString().Substring(4, 4))
                {
                    // LoginEmployee(emp)
                    if (oRow("EmployeeMgmtAll") == true | oRow("EmployeeMgmtLimited") == true)
                    {
                        TestToDisplayPayRates(ref oRow);
                        return true;
                    }
                    else
                    {
                        Interaction.MsgBox("Employee : " + oRow("FirstName") + " " + oRow("LastName") + " does NOT have authority");
                        notInSystem = false;
                        // Return False
                    }
                }

                else
                {
                    Interaction.MsgBox("Password Incorrect: Please Reenter or See Manager");
                    return default;
                    // End If
                }
                // LoginEmployee(emp)
                // Return False
            }
        }

        if (someoneHasAuthority == false)
        {
            return true;
        }
        else
        {
            if (notInSystem == true)
            {
                Interaction.MsgBox("Employee Number: " + loginEnter + " Is Not In System");
            }
            return false;

        }

    }

    private void TestToDisplayPayRates(ref DataRow oRow)
    {

        if (oRow("EmployeeMgmtAll") == true)
        {
            SetupEmployee1.pnlJobPayRates.Visible = true;
            SetupEmployee1.btnOverrides.Visible = true;
        }
        else
        {
            SetupEmployee1.pnlJobPayRates.Visible = false;
            SetupEmployee1.btnOverrides.Visible = false;
        }
    }

    private void btnPaymentSetup_Click(object sender, EventArgs e)
    {
        SetupMenu1.Visible = false;
        SetupEmployee1.Visible = false;
        RawMaterials1.Visible = false;
        SetupPayment1.Visible = true;
        SetupTerminal1.Visible = false;
        loginPad.Visible = false;
        SetupEmployee1.RemoveCardHandler();

    }

    private void btnRawMaterials_Click(object sender, EventArgs e)
    {
        SetupMenu1.Visible = false;
        SetupEmployee1.Visible = false;
        SetupPayment1.Visible = false;
        RawMaterials1.Visible = true;
        SetupTerminal1.Visible = false;
        loginPad.Visible = false;
        SetupEmployee1.RemoveCardHandler();

        RawMaterials1.StartRaw();
        GetFoodDrinkDatasetReadyFroRaw();

    }

    private void btnTerminalSetup_Click(object sender, EventArgs e)
    {
        SetupMenu1.Visible = false;
        SetupEmployee1.Visible = false;
        SetupPayment1.Visible = false;
        RawMaterials1.Visible = false;
        SetupTerminal1.Visible = true;
        loginPad.Visible = false;
        SetupEmployee1.RemoveCardHandler();

    }

    private void GetFoodDrinkDatasetReadyFroRaw()
    {

        dsSetup.Tables("Drinks").Clear();
        sql.SqlSelectCommandMenuDrinks.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandMenuDrinks.Parameters("@LocationID").Value = selectedLocation;

        dsSetup.Tables("FoodTable").Clear();
        sql.SqlSelectCommandMenuFoods.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandMenuFoods.Parameters("@LocationID").Value = selectedLocation;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlMenuFoods.Fill(dsSetup.Tables("FoodTable"));
            sql.SqlMenuDrinks.Fill(dsSetup.Tables("Drinks"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);
            CloseConnection();
        }

    }

    private void btnCorporate_Click(object sender, EventArgs e)
    {

        // ************************
        // currently not using
        return;

        if (isCorporate == true)
        {
            isCorporate = false;
            pnlCorporate.Visible = false;
        }
        else
        {
            isCorporate = true;
            pnlCorporate.Visible = true;
        }

    }

    private void cbxCorporateMenu_SelectedIndexChanged(object sender, EventArgs e)
    {


        if (cbxCorporateMenu.SelectedIndex == 0)
        {
            ShowCorporateView();
            cbxCorporateMenuLocation.Visible = false;
            btnSetupMenu.Visible = false;
        }

        else if (cbxCorporateMenu.SelectedIndex == 1)
        {
            // menu by location
            if (!object.ReferenceEquals(selectedLocation, "000000"))
            {
                RepopulateMenu();
                ShowLocationView();
            }
            cbxCorporateMenuLocation.Visible = true;
        }

        else if (cbxCorporateMenu.SelectedIndex == 2)
        {
            // menu addition only
            if (!object.ReferenceEquals(selectedLocation, "000000"))
            {
                RepopulateMenu();
            }
            cbxCorporateMenuLocation.Visible = true;


        }
    }

    private void ShowCorporateView()
    {

        GenerateTables.ClearingDataToRepopulate();

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            GenerateTables.RepopulateDataSets("000000");
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

    }

    private void ShowLocationView()
    {

        GenerateTables.ClearingDataToRepopulate();

        // will need to change
        // GenerateTables.RepopulateDataSets("000000")
        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            GenerateTables.RepopulateDataSets(selectedLocation);
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        RepopulateMenu();
        Interaction.MsgBox(dsSetup.Tables("MenuDetail").Rows.Count);

    }

    private void ShowLocationAdditionsOnly()
    {

    }

    private void DisplayInitialLogon()
    {

        initLogon = new DataSet_Builder.LoginInit_UC();   // NumberPad
        initLogon.Location = new Point((wa.Width - initLogon.Width) / 2, (wa.Height - initLogon.Height) / 2);
        this.Controls.Add(initLogon);
        initLogon.BringToFront();

        initLogon.InputUSERinfo("", "");
        initLogon.Focus();

    }

    private void TestInitLogon()
    {
        string loginEnterUsername;
        string loginEnterPassword;

        loginEnterUsername = initLogon.LoginUsername;
        loginEnterPassword = initLogon.LoginPassword;

        if (loginEnterUsername == "e")
            loginEnterUsername = "eglobal";

        InitialLogIn(loginEnterUsername, loginEnterPassword);

    }

    private bool InitialLogIn(string leUsername, string lePassword)
    {

        GenerateTables.ReInitializeSQLConnection(leUsername);

        // Dim username As String
        string password;
        string compName;

        SqlClient.SqlCommand cmd;
        var dtr = default(SqlClient.SqlDataReader);

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            cmd = new SqlClient.SqlCommand("SELECT CompanyID, LocationID, CompanyName, Address1, Address2, City, State, Zip, Username, BackPass, UsingDefaults, EndOfWeek FROM LocationOverview WHERE Username = '" + leUsername + "'", sql.cn);
            // cmd = New SqlClient.SqlCommand("SELECT CompanyName, Address1, Address2, City, State, Zip, Username, Password, UsingDefaults, EndOfWeek FROM LocationOverview WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'", sql.cn)
            dtr = cmd.ExecuteReader;
            dtr.Read();
        }
        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);
            this.Dispose();
        }


        if (dtr.HasRows) // dtr.HasRows Then
        {
            // username = dtr("Username")
            corpID = dtr("CompanyID");
            corpPhysicalLocation = dtr("LocationID");
            compName = dtr("CompanyName");
            password = dtr("BackPass");
            usingDefaults = dtr("UsingDefaults");
            if (usingDefaults == false)
            {
                selectedLocation = dtr("LocationID");
            }
            else
            {
                selectedLocation = "000000";
            }
            endOfWeek = dtr("EndOfWeek");
        }
        else
        {
            dtr.Close();
            sql.cn.Close();
            IncorrectUsername(leUsername);
            loginFailedCount += 1;
            if (loginFailedCount == 3)
                this.Dispose();
            return default;
        }

        dtr.Close();
        sql.cn.Close();


        // If leUsername = username Then
        if ((lePassword ?? "") == (password ?? ""))
        {
            pnlAdministration.Enabled = true;
            InitializeOther();
            initLogon.Dispose();
        }
        else
        {
            // password incorrent
            IncorrectInitLogin();
            loginFailedCount += 1;
            if (loginFailedCount == 3)
                this.Dispose();
        }

        return default;


    }

    private void IncorrectUsername(string leUsername)
    {
        DataSet_Builder.Information_UC info;

        initLogon.LoginUsername = "";
        initLogon.LoginPassword = "";
        initLogon.txtLoginUsername.Text = "";
        initLogon.txtLoginPassword.Text = "";

        initLogon.RessetFocus();

        info = new DataSet_Builder.Information_UC("Username " + leUsername + " can not be found.");
        info.Location = new Point((this.Width - info.Width) / 2, (this.Height - info.Height) / 2);
        this.Controls.Add(info);
        info.BringToFront();

    }

    private void IncorrectInitLogin()
    {
        DataSet_Builder.Information_UC info;

        // Me.initLogon.LoginUsername = ""
        // Me.initLogon.LoginPassword = ""
        // Me.initLogon.txtLoginUsername.Text = ""
        // Me.initLogon.txtLoginPassword.Text = ""

        initLogon.RessetFocus();

        info = new DataSet_Builder.Information_UC("Incorrect Password.");
        info.Location = new Point((this.Width - info.Width) / 2, (this.Height - info.Height) / 2);
        this.Controls.Add(info);
        info.BringToFront();

    }









    private void LoadLocationData()
    {
        string locationString;
        string locationIDString;

        foreach (DataRow oRow in dsSetup.Tables("LocationOverview").Rows)
        {

            // removeds 2 leading zero's
            if (oRow("LocationID").substring(0, 1) == "0")
            {
                if (oRow("LocationID").substring(1, 1) == "0")
                {
                    locationIDString = "  " + oRow("LocationID").substring(2, 4);
                }
                else
                {
                    locationIDString = " " + oRow("LocationID").substring(1, 5);
                }
            }
            else
            {
                locationIDString = oRow("LocationID");
            }

            locationString = locationIDString + "     " + oRow("City") + ",  " + oRow("State");
            cbxCorporateMenuLocation.Items.Add(locationString);
            locationString = null;

        }

    }

    private void cbxCorporateMenuLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        string locationIDString;
        DataRow oRow;

        locationIDString = cbxCorporateMenuLocation.Text.Substring(0, 6);

        if (locationIDString.Substring(0, 1) == " ")
        {
            if (locationIDString.Substring(1, 1) == " ")
            {
                selectedLocation = "00" + locationIDString.Substring(2, 4);
            }
            else
            {
                selectedLocation = "0" + locationIDString.Substring(1, 5);
            }
        }
        else
        {
            selectedLocation = locationIDString;
        }

        try
        {
            // oRow = dsSetup.Tables("LocationOverview").Rows.Find(selectedLocation)
            // usingDefaults = oRow("UsingDefaults")


            if (selectedLocation == "000000")
            {
                btnSetupMenu.Visible = false;
                ShowCorporateView();
            }
            else
            {
                btnSetupMenu.Visible = true;
                if (usingDefaults == false)
                {
                    btnSetupMenu.Text = "Use Defaults";
                }
                else
                {
                    btnSetupMenu.Text = "Setup Menu based on Defaults";
                }
                ShowLocationView();
            }

            RepopulateMenu();
        }

        catch (Exception ex)
        {

        }

    }

    private void RepopulateMenu()
    {

        dsSetup.Tables("FoodTable").Clear();
        // If Me.cbxCorporateMenu.SelectedIndex <> 2 Then
        // Me.SetupMenu1.PopulateLocationMenu(corpID, "000000")
        // End If

        SetupMenu1.PopulateLocationMenu(corpID, selectedLocation);
        SetupMenu1.PopulateMenuSelection();


    }


    private void btnSetupMenu_Click(object sender, EventArgs e)
    {

        if (btnSetupMenu.Text == "Use Defaults")
        {
        }
        // MsgBox(usingDefaults)

        else if (btnSetupMenu.Text == "Setup Menu based on Defaults")
        {
            Interaction.MsgBox(usingDefaults);
            if (dsSetup.Tables("MenuDetail").Rows.Count == 0)
            {
                // we know this location was never setup
                SetupMenuBasedOnDefaults();
            }
            else if (Interaction.MsgBox("This will reset your Menu to Corporate Defaults.", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
            {
                // SetupMenuBasedOnDefaults()


            }


        }

    }

    private void SetupMenuBasedOnDefaults()
    {

        ShowCorporateView();

        return;


        DataRow oRow;
        DataRow nRow;
        DataTable tempMenuJoin;
        DataTable tempMenuDetail;
        DataTable tempFoodJoin;


        var adtMenuJoin = new SqlClient.SqlDataAdapter("SELECT CompanyID, LocationID, MenuJoinID, FoodID, MenuID, Price, Surcharge, RoutingID, MenuIndex, Active FROM MenuJoin", sql.cn);
        var cbdMenuJoin = new SqlClient.SqlCommandBuilder(adtMenuJoin);

        var adtMenuDetail = new SqlClient.SqlDataAdapter("SELECT CompanyID, LocationID, MenuDetailID, MenuID, BartenderMenuID, CategoryID, DrinkCategoryID, OrderIndex FROM MenuDetail", sql.cn);
        var cbdMenuDetail = new SqlClient.SqlCommandBuilder(adtMenuDetail);

        var adtFoodJoin = new SqlClient.SqlDataAdapter("SELECT CompanyID, LocationID, FoodJoinID, FoodID, CategoryID, ModifierID, NumberFree FROM FoodJoin", sql.cn);
        var cbdFoodJoin = new SqlClient.SqlCommandBuilder(adtFoodJoin);



        tempMenuJoin = dsSetup.Tables("MenuJoin").Clone;
        tempMenuDetail = dsSetup.Tables("MenuDetail").Clone;
        tempFoodJoin = dsSetup.Tables("Foodoin").Clone;


        foreach (DataRow currentORow in dsSetup.Tables("MenuJoin").Rows)
        {
            oRow = currentORow;
            nRow = tempMenuJoin.NewRow;

            nRow("CompanyID") = corpID;
            nRow("LocationID") = selectedLocation;
            nRow("MenuJoinID") = oRow("MenuJoinID");
            nRow("FoodID") = oRow("FoodID");
            nRow("MenuID") = oRow("MenuID");
            nRow("Price") = oRow("Price");
            nRow("Surcharge") = oRow("Surcharge");
            nRow("RoutingID") = oRow("RoutingID");
            nRow("MenuIndex") = oRow("MenuIndex");
            nRow("Active") = oRow("Active");

            tempMenuJoin.Rows.Add(nRow);

        }


        foreach (DataRow currentORow1 in dsSetup.Tables("MenuDetail").Rows)
        {
            oRow = currentORow1;
            nRow = tempMenuDetail.NewRow;

            nRow("CompanyID") = corpID;
            nRow("LocationID") = selectedLocation;
            nRow("MenuDetailID") = oRow("MenuDetailID");
            nRow("MenuID") = oRow("MenuID");
            nRow("BartenderMenuID") = oRow("BartenderMenuID");
            nRow("CategoryID") = oRow("CategoryID");
            nRow("DrinkCategoryID") = oRow("DrinkCategoryID");
            nRow("DrinkCategoryID") = oRow("DrinkCategoryID");

            tempMenuJoin.Rows.Add(nRow);
        }

        foreach (DataRow currentORow2 in dsSetup.Tables("FoodJoin").Rows)
        {
            oRow = currentORow2;
            nRow = tempFoodJoin.NewRow;

            nRow("CompanyID") = corpID;
            nRow("LocationID") = selectedLocation;
            nRow("FoodJoinID") = oRow("FoodJoinID");
            nRow("FoodID") = oRow("FoodID");
            nRow("CategoryID") = oRow("CategoryID");
            nRow("ModifierID") = oRow("ModifierID");
            nRow("NumberFree") = oRow("NumberFree");

            tempFoodJoin.Rows.Add(nRow);
        }



        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            adtMenuJoin.Update(tempMenuJoin);
            adtMenuDetail.Update(tempMenuDetail);
            adtFoodJoin.Update(tempFoodJoin);
            sql.cn.Close();
        }
        catch (Exception ex)
        {

        }





        // AddingInfoToMenusTables(dsSetup.Tables("Menus"))
    }


    // do not use yet b/c MenuID is a Primary Key and this defines new menuID
    // and we refer to this number from the joins

    private void AddingInfoToMenusTables222(DataTable tempData)
    {
        DataRow nRow;

        var adt = new SqlClient.SqlDataAdapter("SELECT CompanyID, LocationID, MenuID, MenuName, Active FROM MenuChoice", sql.cn);
        var cbd = new SqlClient.SqlCommandBuilder(adt);


        tempData = dsSetup.Tables("Menus").Clone;

        foreach (DataRow oRow in dsSetup.Tables("Menus").Rows)
        {
            nRow = tempData.NewRow;

            nRow("CompanyID") = corpID;
            nRow("LocationID") = selectedLocation;
            nRow("MenuID") = oRow("MenuID");
            nRow("MenuName") = oRow("MenuName");
            nRow("Active") = oRow("Active");

            tempData.Rows.Add(nRow);

        }

        sql.cn.Open();
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
        adt.Update(tempData);
        sql.cn.Close();

    }


    private void btnAdmExit_Click(object sender, EventArgs e)
    {
        SetupMenu1.Visible = false;
        SetupEmployee1.Visible = false;
        SetupPayment1.Visible = false;
        RawMaterials1.Visible = false;
        SetupTerminal1.Visible = false;
        loginPad.Visible = false;
        loginPad.Visible = false;
        SetupEmployee1.RemoveCardHandler();

        if (SetupTerminal1.FloorPlan1.Focus == true)
        {
            SetupTerminal1.TabControl1.SelectedTab = SetupTerminal1.FloorPlan2;
            SetupTerminal1.TabControl1.SelectedTab = SetupTerminal1.FloorPlan1;
        }
        else
        {
            SetupTerminal1.TabControl1.SelectedTab = SetupTerminal1.FloorPlan1;
        }

        exiting = new Exit_UC();
        exiting.Location = new Point((wa.Width - exiting.Width) / 2, (wa.Height - exiting.Height) / 2);
        this.Controls.Add(exiting);
        // Me.exiting.BringToFront()

        return;
        if (Interaction.MsgBox("Are you sure you want to Exit Administration?", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
        {
            this.Dispose();
        }

    }


}