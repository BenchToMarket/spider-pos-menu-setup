using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using DataSet_Builder;


public partial class SetupEmploy : System.Windows.Forms.UserControl
{

    private CurrencyManager EmployeeCurrencyMan;
    private CurrencyManager JobCodeCurrencyMan;
    private Global.System.Windows.Forms.Button _btnSwipeCode;

    internal virtual Global.System.Windows.Forms.Button btnSwipeCode
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnSwipeCode;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnSwipeCode != null)
            {
                _btnSwipeCode.Click -= btnSwipeCode_Click;
            }

            _btnSwipeCode = value;
            if (_btnSwipeCode != null)
            {
                _btnSwipeCode.Click += btnSwipeCode_Click;
            }
        }
    }
    private DataSet_Builder.ReadCredit_DSB _readSwipe;

    private DataSet_Builder.ReadCredit_DSB readSwipe
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _readSwipe;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_readSwipe != null)
            {
                _readSwipe.CardReadSuccessful -= CardJustSwiped;
            }

            _readSwipe = value;
            if (_readSwipe != null)
            {
                _readSwipe.CardReadSuccessful += CardJustSwiped;
            }
        }
    }
    private Global.System.Windows.Forms.Label _Label10;

    internal virtual Global.System.Windows.Forms.Label Label10
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label10;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label10 = value;
        }
    }

    // Dim didNotAddEmployee As Boolean

    private ArrayList availEmpID = new ArrayList();


    #region  Windows Form Designer generated code 

    public SetupEmploy() : base()
    {

        // This call is required by the Windows Form Designer.
        InitializeComponent();

        // Add any initialization after the InitializeComponent() call
        InitializeOther();

        // tmrCardRead_DSB = New Timer
        readSwipe = new ReadCredit_DSB();

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
    private Global.System.Windows.Forms.TabControl _TabControl1;

    internal virtual Global.System.Windows.Forms.TabControl TabControl1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _TabControl1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TabControl1 = value;
        }
    }
    private Global.System.Windows.Forms.DataGrid _grdActiveEmployee;

    internal virtual Global.System.Windows.Forms.DataGrid grdActiveEmployee
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _grdActiveEmployee;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_grdActiveEmployee != null)
            {
                _grdActiveEmployee.CurrentCellChanged -= grdActiveEmployee_Changed;
            }

            _grdActiveEmployee = value;
            if (_grdActiveEmployee != null)
            {
                _grdActiveEmployee.CurrentCellChanged += grdActiveEmployee_Changed;
            }
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpID;

    internal virtual Global.System.Windows.Forms.Label lblEmpID
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpID;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpID = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpLast;

    internal virtual Global.System.Windows.Forms.Label lblEmpLast
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpLast;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpLast = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpFirst;

    internal virtual Global.System.Windows.Forms.Label lblEmpFirst
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpFirst;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpFirst = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpAddress1;

    internal virtual Global.System.Windows.Forms.Label lblEmpAddress1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpAddress1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpAddress1 = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpAddress2;

    internal virtual Global.System.Windows.Forms.Label lblEmpAddress2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpAddress2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpAddress2 = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpZip;

    internal virtual Global.System.Windows.Forms.Label lblEmpZip
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpZip;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpZip = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpState;

    internal virtual Global.System.Windows.Forms.Label lblEmpState
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpState;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpState = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpCity;

    internal virtual Global.System.Windows.Forms.Label lblEmpCity
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpCity;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpCity = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpPhone;

    internal virtual Global.System.Windows.Forms.Label lblEmpPhone
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpPhone;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpPhone = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpCell;

    internal virtual Global.System.Windows.Forms.Label lblEmpCell
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpCell;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpCell = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpBirth;

    internal virtual Global.System.Windows.Forms.Label lblEmpBirth
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpBirth;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpBirth = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpHire;

    internal virtual Global.System.Windows.Forms.Label lblEmpHire
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpHire;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpHire = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpReportsTo;

    internal virtual Global.System.Windows.Forms.Label lblEmpReportsTo
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpReportsTo;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpReportsTo = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpLast;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpLast
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpLast;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpLast = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpFirst;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpFirst
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpFirst;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtEmpFirst != null)
            {
                _txtEmpFirst.TextChanged -= txtEmpFirst_TextChanged;
            }

            _txtEmpFirst = value;
            if (_txtEmpFirst != null)
            {
                _txtEmpFirst.TextChanged += txtEmpFirst_TextChanged;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpMiddle;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpMiddle
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpMiddle;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpMiddle = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpAddress1;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpAddress1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpAddress1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpAddress1 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpAddress2;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpAddress2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpAddress2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpAddress2 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpCity;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpCity
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpCity;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpCity = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpState;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpState
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpState;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpState = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpZip;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpZip
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpZip;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpZip = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpHome;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpHome
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpHome;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpHome = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpCell;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpCell
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpCell;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpCell = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpBirth;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpBirth
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpBirth;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpBirth = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpHire;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpHire
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpHire;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpHire = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkEmpTerminated;

    internal virtual Global.System.Windows.Forms.CheckBox chkEmpTerminated
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkEmpTerminated;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkEmpTerminated = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkEmpTraining;

    internal virtual Global.System.Windows.Forms.CheckBox chkEmpTraining
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkEmpTraining;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkEmpTraining = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxEmpReportsTo;

    internal virtual Global.System.Windows.Forms.ComboBox cbxEmpReportsTo
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxEmpReportsTo;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxEmpReportsTo != null)
            {
                _cbxEmpReportsTo.SelectedIndexChanged -= cbxEmpReportsTO_SelectedIndexChanged;
            }

            _cbxEmpReportsTo = value;
            if (_cbxEmpReportsTo != null)
            {
                _cbxEmpReportsTo.SelectedIndexChanged += cbxEmpReportsTO_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.Panel _pnlJobPayRates;

    internal virtual Global.System.Windows.Forms.Panel pnlJobPayRates
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlJobPayRates;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlJobPayRates = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxEmpJob1;

    internal virtual Global.System.Windows.Forms.ComboBox cbxEmpJob1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxEmpJob1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxEmpJob1 != null)
            {
                _cbxEmpJob1.SelectedIndexChanged -= cbxEmpJob1_SelectedIndexChanged;
            }

            _cbxEmpJob1 = value;
            if (_cbxEmpJob1 != null)
            {
                _cbxEmpJob1.SelectedIndexChanged += cbxEmpJob1_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxEmpJob2;

    internal virtual Global.System.Windows.Forms.ComboBox cbxEmpJob2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxEmpJob2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxEmpJob2 != null)
            {
                _cbxEmpJob2.SelectedIndexChanged -= cbxEmpJob2_SelectedIndexChanged;
            }

            _cbxEmpJob2 = value;
            if (_cbxEmpJob2 != null)
            {
                _cbxEmpJob2.SelectedIndexChanged += cbxEmpJob2_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpRate1;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpRate1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpRate1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpRate1 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpRate2;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpRate2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpRate2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpRate2 = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpJobCodes;

    internal virtual Global.System.Windows.Forms.Label lblEmpJobCodes
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpJobCodes;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpJobCodes = value;
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
    private Global.System.Windows.Forms.ComboBox _cbxEmpJob3;

    internal virtual Global.System.Windows.Forms.ComboBox cbxEmpJob3
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxEmpJob3;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxEmpJob3 != null)
            {
                _cbxEmpJob3.SelectedIndexChanged -= cbxEmpJob3_SelectedIndexChanged;
            }

            _cbxEmpJob3 = value;
            if (_cbxEmpJob3 != null)
            {
                _cbxEmpJob3.SelectedIndexChanged += cbxEmpJob3_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxEmpJob4;

    internal virtual Global.System.Windows.Forms.ComboBox cbxEmpJob4
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxEmpJob4;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxEmpJob4 != null)
            {
                _cbxEmpJob4.SelectedIndexChanged -= cbxEmpJob4_SelectedIndexChanged;
            }

            _cbxEmpJob4 = value;
            if (_cbxEmpJob4 != null)
            {
                _cbxEmpJob4.SelectedIndexChanged += cbxEmpJob4_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxEmpJob5;

    internal virtual Global.System.Windows.Forms.ComboBox cbxEmpJob5
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxEmpJob5;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxEmpJob5 != null)
            {
                _cbxEmpJob5.SelectedIndexChanged -= cbxEmpJob5_SelectedIndexChanged;
            }

            _cbxEmpJob5 = value;
            if (_cbxEmpJob5 != null)
            {
                _cbxEmpJob5.SelectedIndexChanged += cbxEmpJob5_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxEmpJob6;

    internal virtual Global.System.Windows.Forms.ComboBox cbxEmpJob6
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxEmpJob6;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxEmpJob6 != null)
            {
                _cbxEmpJob6.SelectedIndexChanged -= cbxEmpJob6_SelectedIndexChanged;
            }

            _cbxEmpJob6 = value;
            if (_cbxEmpJob6 != null)
            {
                _cbxEmpJob6.SelectedIndexChanged += cbxEmpJob6_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxEmpJob7;

    internal virtual Global.System.Windows.Forms.ComboBox cbxEmpJob7
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxEmpJob7;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxEmpJob7 != null)
            {
                _cbxEmpJob7.SelectedIndexChanged -= cbxEmpJob7_SelectedIndexChanged;
            }

            _cbxEmpJob7 = value;
            if (_cbxEmpJob7 != null)
            {
                _cbxEmpJob7.SelectedIndexChanged += cbxEmpJob7_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpRate7;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpRate7
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpRate7;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpRate7 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpRate6;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpRate6
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpRate6;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpRate6 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpRate5;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpRate5
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpRate5;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpRate5 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpRate4;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpRate4
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpRate4;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpRate4 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpRate3;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpRate3
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpRate3;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpRate3 = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnUpdateEmployee;

    internal virtual Global.System.Windows.Forms.Button btnUpdateEmployee
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnUpdateEmployee;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnUpdateEmployee != null)
            {
                _btnUpdateEmployee.Click -= btnUpdateEmployee_Click;
            }

            _btnUpdateEmployee = value;
            if (_btnUpdateEmployee != null)
            {
                _btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtSSN;

    internal virtual Global.System.Windows.Forms.TextBox txtSSN
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtSSN;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtSSN = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblSSN;

    internal virtual Global.System.Windows.Forms.Label lblSSN
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblSSN;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblSSN = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxEmpID;

    internal virtual Global.System.Windows.Forms.ComboBox cbxEmpID
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxEmpID;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxEmpID != null)
            {
                _cbxEmpID.SelectedIndexChanged -= cbxEmpID_SelectedIndexChanged;
            }

            _cbxEmpID = value;
            if (_cbxEmpID != null)
            {
                _cbxEmpID.SelectedIndexChanged += cbxEmpID_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpInstruct;

    internal virtual Global.System.Windows.Forms.Label lblEmpInstruct
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpInstruct;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpInstruct = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlEmpTax;

    internal virtual Global.System.Windows.Forms.Panel pnlEmpTax
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlEmpTax;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlEmpTax = value;
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
    private Global.System.Windows.Forms.ComboBox _cbxEmpFiling;

    internal virtual Global.System.Windows.Forms.ComboBox cbxEmpFiling
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxEmpFiling;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxEmpFiling = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpDependents;

    internal virtual Global.System.Windows.Forms.Label lblEmpDependents
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpDependents;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpDependents = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpDependent;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpDependent
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpDependent;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpDependent = value;
        }
    }
    private Global.System.Windows.Forms.TabPage _tabEmpDetail;

    internal virtual Global.System.Windows.Forms.TabPage tabEmpDetail
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _tabEmpDetail;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_tabEmpDetail != null)
            {
                _tabEmpDetail.Leave -= tabEmpDetail_Click;
            }

            _tabEmpDetail = value;
            if (_tabEmpDetail != null)
            {
                _tabEmpDetail.Leave += tabEmpDetail_Click;
            }
        }
    }
    private Global.System.Windows.Forms.TabPage _TabJobCodeDetail;

    internal virtual Global.System.Windows.Forms.TabPage TabJobCodeDetail
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _TabJobCodeDetail;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_TabJobCodeDetail != null)
            {
                _TabJobCodeDetail.Leave -= TabJobCodeDetail_Click;
            }

            _TabJobCodeDetail = value;
            if (_TabJobCodeDetail != null)
            {
                _TabJobCodeDetail.Leave += TabJobCodeDetail_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Label _Label7;

    internal virtual Global.System.Windows.Forms.Label Label7
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label7;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label7 = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label8;

    internal virtual Global.System.Windows.Forms.Label Label8
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label8;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label8 = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxJobCode;

    internal virtual Global.System.Windows.Forms.ComboBox cbxJobCode
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxJobCode;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxJobCode = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblEmpNick;

    internal virtual Global.System.Windows.Forms.Label lblEmpNick
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblEmpNick;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblEmpNick = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpNick;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpNick
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpNick;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpNick = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtEmpID;

    internal virtual Global.System.Windows.Forms.TextBox txtEmpID
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtEmpID;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtEmpID = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnOverrides;

    internal virtual Global.System.Windows.Forms.Button btnOverrides
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnOverrides;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnOverrides != null)
            {
                _btnOverrides.Click -= btnOverrides_Click;
            }

            _btnOverrides = value;
            if (_btnOverrides != null)
            {
                _btnOverrides.Click += btnOverrides_Click;
            }
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
    private Global.System.Windows.Forms.Label _Label6;

    internal virtual Global.System.Windows.Forms.Label Label6
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label6;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label6 = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label5;

    internal virtual Global.System.Windows.Forms.Label Label5
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label5;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label5 = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnOPverrideClose;

    internal virtual Global.System.Windows.Forms.Button btnOPverrideClose
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnOPverrideClose;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnOPverrideClose != null)
            {
                _btnOPverrideClose.Click -= btnOPverrideClose_Click;
            }

            _btnOPverrideClose = value;
            if (_btnOPverrideClose != null)
            {
                _btnOPverrideClose.Click += btnOPverrideClose_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Panel _pnlOverrides;

    internal virtual Global.System.Windows.Forms.Panel pnlOverrides
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlOverrides;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlOverrides = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkOperationLimited;

    internal virtual Global.System.Windows.Forms.CheckBox chkOperationLimited
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkOperationLimited;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkOperationLimited = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkOperationAll;

    internal virtual Global.System.Windows.Forms.CheckBox chkOperationAll
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkOperationAll;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkOperationAll = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkReportLimited;

    internal virtual Global.System.Windows.Forms.CheckBox chkReportLimited
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkReportLimited;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkReportLimited = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkReportAll;

    internal virtual Global.System.Windows.Forms.CheckBox chkReportAll
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkReportAll;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkReportAll = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkEmployeeLimited;

    internal virtual Global.System.Windows.Forms.CheckBox chkEmployeeLimited
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkEmployeeLimited;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkEmployeeLimited = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkEmployeeAll;

    internal virtual Global.System.Windows.Forms.CheckBox chkEmployeeAll
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkEmployeeAll;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkEmployeeAll = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkSystemLimited;

    internal virtual Global.System.Windows.Forms.CheckBox chkSystemLimited
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkSystemLimited;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkSystemLimited = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkSystemAll;

    internal virtual Global.System.Windows.Forms.CheckBox chkSystemAll
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkSystemAll;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkSystemAll = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnCreateJobCode;

    internal virtual Global.System.Windows.Forms.Button btnCreateJobCode
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnCreateJobCode;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnCreateJobCode != null)
            {
                _btnCreateJobCode.Click -= btnCreateJobCode_Click;
            }

            _btnCreateJobCode = value;
            if (_btnCreateJobCode != null)
            {
                _btnCreateJobCode.Click += btnCreateJobCode_Click;
            }
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkJobManager;

    internal virtual Global.System.Windows.Forms.CheckBox chkJobManager
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkJobManager;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkJobManager = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkJobHost;

    internal virtual Global.System.Windows.Forms.CheckBox chkJobHost
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkJobHost;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkJobHost = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkJobShareTips;

    internal virtual Global.System.Windows.Forms.CheckBox chkJobShareTips
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkJobShareTips;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkJobShareTips = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkJobReportTips;

    internal virtual Global.System.Windows.Forms.CheckBox chkJobReportTips
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkJobReportTips;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkJobReportTips = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkJobClock;

    internal virtual Global.System.Windows.Forms.CheckBox chkJobClock
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkJobClock;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkJobClock = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkJobPassword;

    internal virtual Global.System.Windows.Forms.CheckBox chkJobPassword
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkJobPassword;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkJobPassword = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkJobCashDrawer;

    internal virtual Global.System.Windows.Forms.CheckBox chkJobCashDrawer
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkJobCashDrawer;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkJobCashDrawer = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkJobServer;

    internal virtual Global.System.Windows.Forms.CheckBox chkJobServer
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkJobServer;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkJobServer = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkJobBar;

    internal virtual Global.System.Windows.Forms.CheckBox chkJobBar
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkJobBar;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkJobBar = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkJobCashier;

    internal virtual Global.System.Windows.Forms.CheckBox chkJobCashier
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkJobCashier;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkJobCashier = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnJobCodeUpdate;

    internal virtual Global.System.Windows.Forms.Button btnJobCodeUpdate
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnJobCodeUpdate;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnJobCodeUpdate != null)
            {
                _btnJobCodeUpdate.Click -= btnJobCodeUpdate_Click;
            }

            _btnJobCodeUpdate = value;
            if (_btnJobCodeUpdate != null)
            {
                _btnJobCodeUpdate.Click += btnJobCodeUpdate_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Panel _Panel2;

    internal virtual Global.System.Windows.Forms.Panel Panel2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Panel2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Panel2 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtUpdateJobCode;

    internal virtual Global.System.Windows.Forms.TextBox txtUpdateJobCode
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtUpdateJobCode;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtUpdateJobCode = value;
        }
    }
    private Global.System.Windows.Forms.Panel _Panel3;

    internal virtual Global.System.Windows.Forms.Panel Panel3
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Panel3;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Panel3 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtNewJobCode;

    internal virtual Global.System.Windows.Forms.TextBox txtNewJobCode
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtNewJobCode;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtNewJobCode = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label9;

    internal virtual Global.System.Windows.Forms.Label Label9
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label9;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label9 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtPasscode;

    internal virtual Global.System.Windows.Forms.TextBox txtPasscode
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtPasscode;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtPasscode = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkClockInReqFirst;

    internal virtual Global.System.Windows.Forms.CheckBox chkClockInReqFirst
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkClockInReqFirst;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkClockInReqFirst = value;
        }
    }
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        _TabControl1 = new System.Windows.Forms.TabControl();
        _tabEmpDetail = new System.Windows.Forms.TabPage();
        _tabEmpDetail.Leave += tabEmpDetail_Click;
        _btnSwipeCode = new System.Windows.Forms.Button();
        _btnSwipeCode.Click += btnSwipeCode_Click;
        _txtPasscode = new System.Windows.Forms.TextBox();
        _Label9 = new System.Windows.Forms.Label();
        _pnlOverrides = new System.Windows.Forms.Panel();
        _chkClockInReqFirst = new System.Windows.Forms.CheckBox();
        _btnOPverrideClose = new System.Windows.Forms.Button();
        _btnOPverrideClose.Click += btnOPverrideClose_Click;
        _chkEmployeeLimited = new System.Windows.Forms.CheckBox();
        _chkEmployeeAll = new System.Windows.Forms.CheckBox();
        _chkSystemLimited = new System.Windows.Forms.CheckBox();
        _chkSystemAll = new System.Windows.Forms.CheckBox();
        _Label6 = new System.Windows.Forms.Label();
        _Label5 = new System.Windows.Forms.Label();
        _chkOperationLimited = new System.Windows.Forms.CheckBox();
        _chkOperationAll = new System.Windows.Forms.CheckBox();
        _chkReportLimited = new System.Windows.Forms.CheckBox();
        _chkReportAll = new System.Windows.Forms.CheckBox();
        _Label4 = new System.Windows.Forms.Label();
        _Label3 = new System.Windows.Forms.Label();
        _btnOverrides = new System.Windows.Forms.Button();
        _btnOverrides.Click += btnOverrides_Click;
        _txtEmpID = new System.Windows.Forms.TextBox();
        _txtEmpNick = new System.Windows.Forms.TextBox();
        _pnlEmpTax = new System.Windows.Forms.Panel();
        _txtEmpDependent = new System.Windows.Forms.TextBox();
        _lblEmpDependents = new System.Windows.Forms.Label();
        _cbxEmpFiling = new System.Windows.Forms.ComboBox();
        _Label2 = new System.Windows.Forms.Label();
        _lblSSN = new System.Windows.Forms.Label();
        _txtSSN = new System.Windows.Forms.TextBox();
        _pnlJobPayRates = new System.Windows.Forms.Panel();
        _txtEmpRate7 = new System.Windows.Forms.TextBox();
        _txtEmpRate6 = new System.Windows.Forms.TextBox();
        _txtEmpRate5 = new System.Windows.Forms.TextBox();
        _txtEmpRate4 = new System.Windows.Forms.TextBox();
        _txtEmpRate3 = new System.Windows.Forms.TextBox();
        _cbxEmpJob7 = new System.Windows.Forms.ComboBox();
        _cbxEmpJob7.SelectedIndexChanged += cbxEmpJob7_SelectedIndexChanged;
        _cbxEmpJob6 = new System.Windows.Forms.ComboBox();
        _cbxEmpJob6.SelectedIndexChanged += cbxEmpJob6_SelectedIndexChanged;
        _cbxEmpJob5 = new System.Windows.Forms.ComboBox();
        _cbxEmpJob5.SelectedIndexChanged += cbxEmpJob5_SelectedIndexChanged;
        _cbxEmpJob4 = new System.Windows.Forms.ComboBox();
        _cbxEmpJob4.SelectedIndexChanged += cbxEmpJob4_SelectedIndexChanged;
        _cbxEmpJob3 = new System.Windows.Forms.ComboBox();
        _cbxEmpJob3.SelectedIndexChanged += cbxEmpJob3_SelectedIndexChanged;
        _Label1 = new System.Windows.Forms.Label();
        _lblEmpJobCodes = new System.Windows.Forms.Label();
        _txtEmpRate2 = new System.Windows.Forms.TextBox();
        _txtEmpRate1 = new System.Windows.Forms.TextBox();
        _cbxEmpJob2 = new System.Windows.Forms.ComboBox();
        _cbxEmpJob2.SelectedIndexChanged += cbxEmpJob2_SelectedIndexChanged;
        _cbxEmpJob1 = new System.Windows.Forms.ComboBox();
        _cbxEmpJob1.SelectedIndexChanged += cbxEmpJob1_SelectedIndexChanged;
        _chkEmpTerminated = new System.Windows.Forms.CheckBox();
        _chkEmpTraining = new System.Windows.Forms.CheckBox();
        _cbxEmpReportsTo = new System.Windows.Forms.ComboBox();
        _cbxEmpReportsTo.SelectedIndexChanged += cbxEmpReportsTO_SelectedIndexChanged;
        _txtEmpHire = new System.Windows.Forms.TextBox();
        _txtEmpBirth = new System.Windows.Forms.TextBox();
        _txtEmpCell = new System.Windows.Forms.TextBox();
        _txtEmpHome = new System.Windows.Forms.TextBox();
        _txtEmpZip = new System.Windows.Forms.TextBox();
        _txtEmpState = new System.Windows.Forms.TextBox();
        _txtEmpCity = new System.Windows.Forms.TextBox();
        _txtEmpAddress2 = new System.Windows.Forms.TextBox();
        _txtEmpAddress1 = new System.Windows.Forms.TextBox();
        _txtEmpMiddle = new System.Windows.Forms.TextBox();
        _txtEmpFirst = new System.Windows.Forms.TextBox();
        _txtEmpFirst.TextChanged += txtEmpFirst_TextChanged;
        _txtEmpLast = new System.Windows.Forms.TextBox();
        _lblEmpReportsTo = new System.Windows.Forms.Label();
        _lblEmpHire = new System.Windows.Forms.Label();
        _lblEmpBirth = new System.Windows.Forms.Label();
        _lblEmpCell = new System.Windows.Forms.Label();
        _lblEmpPhone = new System.Windows.Forms.Label();
        _lblEmpZip = new System.Windows.Forms.Label();
        _lblEmpState = new System.Windows.Forms.Label();
        _lblEmpCity = new System.Windows.Forms.Label();
        _lblEmpAddress2 = new System.Windows.Forms.Label();
        _lblEmpAddress1 = new System.Windows.Forms.Label();
        _lblEmpNick = new System.Windows.Forms.Label();
        _lblEmpFirst = new System.Windows.Forms.Label();
        _lblEmpLast = new System.Windows.Forms.Label();
        _lblEmpID = new System.Windows.Forms.Label();
        _grdActiveEmployee = new System.Windows.Forms.DataGrid();
        _grdActiveEmployee.CurrentCellChanged += grdActiveEmployee_Changed;
        _btnUpdateEmployee = new System.Windows.Forms.Button();
        _btnUpdateEmployee.Click += btnUpdateEmployee_Click;
        _TabJobCodeDetail = new System.Windows.Forms.TabPage();
        _TabJobCodeDetail.Leave += TabJobCodeDetail_Click;
        _Label10 = new System.Windows.Forms.Label();
        _Panel3 = new System.Windows.Forms.Panel();
        _btnJobCodeUpdate = new System.Windows.Forms.Button();
        _btnJobCodeUpdate.Click += btnJobCodeUpdate_Click;
        _txtUpdateJobCode = new System.Windows.Forms.TextBox();
        _Panel2 = new System.Windows.Forms.Panel();
        _txtNewJobCode = new System.Windows.Forms.TextBox();
        _btnCreateJobCode = new System.Windows.Forms.Button();
        _btnCreateJobCode.Click += btnCreateJobCode_Click;
        _chkJobManager = new System.Windows.Forms.CheckBox();
        _cbxJobCode = new System.Windows.Forms.ComboBox();
        _Label8 = new System.Windows.Forms.Label();
        _Label7 = new System.Windows.Forms.Label();
        _chkJobHost = new System.Windows.Forms.CheckBox();
        _chkJobShareTips = new System.Windows.Forms.CheckBox();
        _chkJobReportTips = new System.Windows.Forms.CheckBox();
        _chkJobClock = new System.Windows.Forms.CheckBox();
        _chkJobPassword = new System.Windows.Forms.CheckBox();
        _chkJobCashDrawer = new System.Windows.Forms.CheckBox();
        _chkJobServer = new System.Windows.Forms.CheckBox();
        _chkJobBar = new System.Windows.Forms.CheckBox();
        _chkJobCashier = new System.Windows.Forms.CheckBox();
        _lblEmpInstruct = new System.Windows.Forms.Label();
        _cbxEmpID = new System.Windows.Forms.ComboBox();
        _cbxEmpID.SelectedIndexChanged += cbxEmpID_SelectedIndexChanged;
        _TabControl1.SuspendLayout();
        _tabEmpDetail.SuspendLayout();
        _pnlOverrides.SuspendLayout();
        _pnlEmpTax.SuspendLayout();
        _pnlJobPayRates.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_grdActiveEmployee).BeginInit();
        _TabJobCodeDetail.SuspendLayout();
        _Panel3.SuspendLayout();
        _Panel2.SuspendLayout();
        this.SuspendLayout();
        // 
        // TabControl1
        // 
        _TabControl1.Controls.Add(_tabEmpDetail);
        _TabControl1.Controls.Add(_TabJobCodeDetail);
        _TabControl1.Location = new System.Drawing.Point(24, 140);
        _TabControl1.Name = "_TabControl1";
        _TabControl1.SelectedIndex = 0;
        _TabControl1.Size = new System.Drawing.Size(744, 544);
        _TabControl1.TabIndex = 1;
        // 
        // tabEmpDetail
        // 
        _tabEmpDetail.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _tabEmpDetail.Controls.Add(_btnSwipeCode);
        _tabEmpDetail.Controls.Add(_txtPasscode);
        _tabEmpDetail.Controls.Add(_Label9);
        _tabEmpDetail.Controls.Add(_pnlOverrides);
        _tabEmpDetail.Controls.Add(_btnOverrides);
        _tabEmpDetail.Controls.Add(_txtEmpID);
        _tabEmpDetail.Controls.Add(_txtEmpNick);
        _tabEmpDetail.Controls.Add(_pnlEmpTax);
        _tabEmpDetail.Controls.Add(_lblSSN);
        _tabEmpDetail.Controls.Add(_txtSSN);
        _tabEmpDetail.Controls.Add(_pnlJobPayRates);
        _tabEmpDetail.Controls.Add(_chkEmpTerminated);
        _tabEmpDetail.Controls.Add(_chkEmpTraining);
        _tabEmpDetail.Controls.Add(_cbxEmpReportsTo);
        _tabEmpDetail.Controls.Add(_txtEmpHire);
        _tabEmpDetail.Controls.Add(_txtEmpBirth);
        _tabEmpDetail.Controls.Add(_txtEmpCell);
        _tabEmpDetail.Controls.Add(_txtEmpHome);
        _tabEmpDetail.Controls.Add(_txtEmpZip);
        _tabEmpDetail.Controls.Add(_txtEmpState);
        _tabEmpDetail.Controls.Add(_txtEmpCity);
        _tabEmpDetail.Controls.Add(_txtEmpAddress2);
        _tabEmpDetail.Controls.Add(_txtEmpAddress1);
        _tabEmpDetail.Controls.Add(_txtEmpMiddle);
        _tabEmpDetail.Controls.Add(_txtEmpFirst);
        _tabEmpDetail.Controls.Add(_txtEmpLast);
        _tabEmpDetail.Controls.Add(_lblEmpReportsTo);
        _tabEmpDetail.Controls.Add(_lblEmpHire);
        _tabEmpDetail.Controls.Add(_lblEmpBirth);
        _tabEmpDetail.Controls.Add(_lblEmpCell);
        _tabEmpDetail.Controls.Add(_lblEmpPhone);
        _tabEmpDetail.Controls.Add(_lblEmpZip);
        _tabEmpDetail.Controls.Add(_lblEmpState);
        _tabEmpDetail.Controls.Add(_lblEmpCity);
        _tabEmpDetail.Controls.Add(_lblEmpAddress2);
        _tabEmpDetail.Controls.Add(_lblEmpAddress1);
        _tabEmpDetail.Controls.Add(_lblEmpNick);
        _tabEmpDetail.Controls.Add(_lblEmpFirst);
        _tabEmpDetail.Controls.Add(_lblEmpLast);
        _tabEmpDetail.Controls.Add(_lblEmpID);
        _tabEmpDetail.Controls.Add(_grdActiveEmployee);
        _tabEmpDetail.Controls.Add(_btnUpdateEmployee);
        _tabEmpDetail.Location = new System.Drawing.Point(4, 22);
        _tabEmpDetail.Name = "_tabEmpDetail";
        _tabEmpDetail.Size = new System.Drawing.Size(736, 518);
        _tabEmpDetail.TabIndex = 0;
        _tabEmpDetail.Text = "Employee Detail";
        // 
        // btnSwipeCode
        // 
        _btnSwipeCode.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _btnSwipeCode.ForeColor = System.Drawing.Color.White;
        _btnSwipeCode.Location = new System.Drawing.Point(405, 462);
        _btnSwipeCode.Name = "_btnSwipeCode";
        _btnSwipeCode.Size = new System.Drawing.Size(75, 50);
        _btnSwipeCode.TabIndex = 45;
        _btnSwipeCode.Text = "Swipe Code";
        _btnSwipeCode.UseVisualStyleBackColor = false;
        // 
        // txtPasscode
        // 
        _txtPasscode.Location = new System.Drawing.Point(328, 464);
        _txtPasscode.Name = "_txtPasscode";
        _txtPasscode.Size = new System.Drawing.Size(64, 20);
        _txtPasscode.TabIndex = 15;
        // 
        // Label9
        // 
        _Label9.Location = new System.Drawing.Point(248, 464);
        _Label9.Name = "_Label9";
        _Label9.Size = new System.Drawing.Size(80, 24);
        _Label9.TabIndex = 44;
        _Label9.Text = "Passcode:";
        _Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // pnlOverrides
        // 
        _pnlOverrides.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        _pnlOverrides.Controls.Add(_chkClockInReqFirst);
        _pnlOverrides.Controls.Add(_btnOPverrideClose);
        _pnlOverrides.Controls.Add(_chkEmployeeLimited);
        _pnlOverrides.Controls.Add(_chkEmployeeAll);
        _pnlOverrides.Controls.Add(_chkSystemLimited);
        _pnlOverrides.Controls.Add(_chkSystemAll);
        _pnlOverrides.Controls.Add(_Label6);
        _pnlOverrides.Controls.Add(_Label5);
        _pnlOverrides.Controls.Add(_chkOperationLimited);
        _pnlOverrides.Controls.Add(_chkOperationAll);
        _pnlOverrides.Controls.Add(_chkReportLimited);
        _pnlOverrides.Controls.Add(_chkReportAll);
        _pnlOverrides.Controls.Add(_Label4);
        _pnlOverrides.Controls.Add(_Label3);
        _pnlOverrides.Location = new System.Drawing.Point(548, 464);
        _pnlOverrides.Name = "_pnlOverrides";
        _pnlOverrides.Size = new System.Drawing.Size(464, 312);
        _pnlOverrides.TabIndex = 43;
        _pnlOverrides.Visible = false;
        // 
        // chkClockInReqFirst
        // 
        _chkClockInReqFirst.Location = new System.Drawing.Point(280, 264);
        _chkClockInReqFirst.Name = "_chkClockInReqFirst";
        _chkClockInReqFirst.Size = new System.Drawing.Size(128, 24);
        _chkClockInReqFirst.TabIndex = 30;
        _chkClockInReqFirst.Text = "Clock In Required";
        // 
        // btnOPverrideClose
        // 
        _btnOPverrideClose.Location = new System.Drawing.Point(72, 248);
        _btnOPverrideClose.Name = "_btnOPverrideClose";
        _btnOPverrideClose.Size = new System.Drawing.Size(112, 40);
        _btnOPverrideClose.TabIndex = 29;
        _btnOPverrideClose.Text = "Close Window";
        // 
        // chkEmployeeLimited
        // 
        _chkEmployeeLimited.Location = new System.Drawing.Point(280, 192);
        _chkEmployeeLimited.Name = "_chkEmployeeLimited";
        _chkEmployeeLimited.Size = new System.Drawing.Size(104, 24);
        _chkEmployeeLimited.TabIndex = 28;
        _chkEmployeeLimited.Text = "Limited Access";
        // 
        // chkEmployeeAll
        // 
        _chkEmployeeAll.Location = new System.Drawing.Point(280, 160);
        _chkEmployeeAll.Name = "_chkEmployeeAll";
        _chkEmployeeAll.Size = new System.Drawing.Size(104, 24);
        _chkEmployeeAll.TabIndex = 27;
        _chkEmployeeAll.Text = "All Access";
        // 
        // chkSystemLimited
        // 
        _chkSystemLimited.Location = new System.Drawing.Point(280, 88);
        _chkSystemLimited.Name = "_chkSystemLimited";
        _chkSystemLimited.Size = new System.Drawing.Size(104, 24);
        _chkSystemLimited.TabIndex = 26;
        _chkSystemLimited.Text = "Limited Access";
        // 
        // chkSystemAll
        // 
        _chkSystemAll.Location = new System.Drawing.Point(280, 56);
        _chkSystemAll.Name = "_chkSystemAll";
        _chkSystemAll.Size = new System.Drawing.Size(104, 24);
        _chkSystemAll.TabIndex = 25;
        _chkSystemAll.Text = "All Access";
        // 
        // Label6
        // 
        _Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label6.Location = new System.Drawing.Point(232, 128);
        _Label6.Name = "_Label6";
        _Label6.Size = new System.Drawing.Size(136, 24);
        _Label6.TabIndex = 24;
        _Label6.Text = "Employee Management";
        _Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // Label5
        // 
        _Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label5.Location = new System.Drawing.Point(232, 24);
        _Label5.Name = "_Label5";
        _Label5.Size = new System.Drawing.Size(128, 24);
        _Label5.TabIndex = 23;
        _Label5.Text = "System Management";
        _Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // chkOperationLimited
        // 
        _chkOperationLimited.Location = new System.Drawing.Point(80, 200);
        _chkOperationLimited.Name = "_chkOperationLimited";
        _chkOperationLimited.Size = new System.Drawing.Size(104, 24);
        _chkOperationLimited.TabIndex = 22;
        _chkOperationLimited.Text = "Limited Access";
        // 
        // chkOperationAll
        // 
        _chkOperationAll.Location = new System.Drawing.Point(80, 160);
        _chkOperationAll.Name = "_chkOperationAll";
        _chkOperationAll.Size = new System.Drawing.Size(104, 24);
        _chkOperationAll.TabIndex = 21;
        _chkOperationAll.Text = "All Access";
        // 
        // chkReportLimited
        // 
        _chkReportLimited.Location = new System.Drawing.Point(72, 88);
        _chkReportLimited.Name = "_chkReportLimited";
        _chkReportLimited.Size = new System.Drawing.Size(104, 24);
        _chkReportLimited.TabIndex = 20;
        _chkReportLimited.Text = "Limited Access";
        // 
        // chkReportAll
        // 
        _chkReportAll.Location = new System.Drawing.Point(72, 56);
        _chkReportAll.Name = "_chkReportAll";
        _chkReportAll.Size = new System.Drawing.Size(104, 24);
        _chkReportAll.TabIndex = 19;
        _chkReportAll.Text = "All Access";
        // 
        // Label4
        // 
        _Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label4.Location = new System.Drawing.Point(32, 128);
        _Label4.Name = "_Label4";
        _Label4.Size = new System.Drawing.Size(152, 24);
        _Label4.TabIndex = 18;
        _Label4.Text = "Operation Management";
        _Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // Label3
        // 
        _Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label3.Location = new System.Drawing.Point(32, 24);
        _Label3.Name = "_Label3";
        _Label3.Size = new System.Drawing.Size(136, 23);
        _Label3.TabIndex = 17;
        _Label3.Text = "Report Management";
        _Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btnOverrides
        // 
        _btnOverrides.Location = new System.Drawing.Point(520, 464);
        _btnOverrides.Name = "_btnOverrides";
        _btnOverrides.Size = new System.Drawing.Size(176, 32);
        _btnOverrides.TabIndex = 42;
        _btnOverrides.Text = "Override Options";
        // 
        // txtEmpID
        // 
        _txtEmpID.BackColor = System.Drawing.SystemColors.Window;
        _txtEmpID.Enabled = false;
        _txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _txtEmpID.Location = new System.Drawing.Point(328, 16);
        _txtEmpID.Name = "_txtEmpID";
        _txtEmpID.Size = new System.Drawing.Size(64, 20);
        _txtEmpID.TabIndex = 41;
        // 
        // txtEmpNick
        // 
        _txtEmpNick.Location = new System.Drawing.Point(328, 112);
        _txtEmpNick.Name = "_txtEmpNick";
        _txtEmpNick.Size = new System.Drawing.Size(96, 20);
        _txtEmpNick.TabIndex = 4;
        _txtEmpNick.TabStop = false;
        // 
        // pnlEmpTax
        // 
        _pnlEmpTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        _pnlEmpTax.Controls.Add(_txtEmpDependent);
        _pnlEmpTax.Controls.Add(_lblEmpDependents);
        _pnlEmpTax.Controls.Add(_cbxEmpFiling);
        _pnlEmpTax.Controls.Add(_Label2);
        _pnlEmpTax.Location = new System.Drawing.Point(496, 336);
        _pnlEmpTax.Name = "_pnlEmpTax";
        _pnlEmpTax.Size = new System.Drawing.Size(224, 104);
        _pnlEmpTax.TabIndex = 40;
        // 
        // txtEmpDependent
        // 
        _txtEmpDependent.Location = new System.Drawing.Point(128, 64);
        _txtEmpDependent.Name = "_txtEmpDependent";
        _txtEmpDependent.Size = new System.Drawing.Size(64, 20);
        _txtEmpDependent.TabIndex = 3;
        // 
        // lblEmpDependents
        // 
        _lblEmpDependents.Location = new System.Drawing.Point(24, 64);
        _lblEmpDependents.Name = "_lblEmpDependents";
        _lblEmpDependents.Size = new System.Drawing.Size(88, 24);
        _lblEmpDependents.TabIndex = 2;
        _lblEmpDependents.Text = "# Dependents:";
        _lblEmpDependents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // cbxEmpFiling
        // 
        _cbxEmpFiling.Location = new System.Drawing.Point(32, 32);
        _cbxEmpFiling.Name = "_cbxEmpFiling";
        _cbxEmpFiling.Size = new System.Drawing.Size(160, 21);
        _cbxEmpFiling.TabIndex = 1;
        _cbxEmpFiling.Text = "Filing Status";
        // 
        // Label2
        // 
        _Label2.Location = new System.Drawing.Point(32, 0);
        _Label2.Name = "_Label2";
        _Label2.Size = new System.Drawing.Size(160, 24);
        _Label2.TabIndex = 0;
        _Label2.Text = "Payroll Tax Info";
        _Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblSSN
        // 
        _lblSSN.Location = new System.Drawing.Point(248, 152);
        _lblSSN.Name = "_lblSSN";
        _lblSSN.Size = new System.Drawing.Size(80, 16);
        _lblSSN.TabIndex = 37;
        _lblSSN.Text = "SS#:";
        _lblSSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtSSN
        // 
        _txtSSN.Location = new System.Drawing.Point(328, 144);
        _txtSSN.Name = "_txtSSN";
        _txtSSN.Size = new System.Drawing.Size(152, 20);
        _txtSSN.TabIndex = 4;
        // 
        // pnlJobPayRates
        // 
        _pnlJobPayRates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        _pnlJobPayRates.Controls.Add(_txtEmpRate7);
        _pnlJobPayRates.Controls.Add(_txtEmpRate6);
        _pnlJobPayRates.Controls.Add(_txtEmpRate5);
        _pnlJobPayRates.Controls.Add(_txtEmpRate4);
        _pnlJobPayRates.Controls.Add(_txtEmpRate3);
        _pnlJobPayRates.Controls.Add(_cbxEmpJob7);
        _pnlJobPayRates.Controls.Add(_cbxEmpJob6);
        _pnlJobPayRates.Controls.Add(_cbxEmpJob5);
        _pnlJobPayRates.Controls.Add(_cbxEmpJob4);
        _pnlJobPayRates.Controls.Add(_cbxEmpJob3);
        _pnlJobPayRates.Controls.Add(_Label1);
        _pnlJobPayRates.Controls.Add(_lblEmpJobCodes);
        _pnlJobPayRates.Controls.Add(_txtEmpRate2);
        _pnlJobPayRates.Controls.Add(_txtEmpRate1);
        _pnlJobPayRates.Controls.Add(_cbxEmpJob2);
        _pnlJobPayRates.Controls.Add(_cbxEmpJob1);
        _pnlJobPayRates.Location = new System.Drawing.Point(496, 64);
        _pnlJobPayRates.Name = "_pnlJobPayRates";
        _pnlJobPayRates.Size = new System.Drawing.Size(224, 264);
        _pnlJobPayRates.TabIndex = 34;
        // 
        // txtEmpRate7
        // 
        _txtEmpRate7.Location = new System.Drawing.Point(152, 232);
        _txtEmpRate7.Name = "_txtEmpRate7";
        _txtEmpRate7.Size = new System.Drawing.Size(64, 20);
        _txtEmpRate7.TabIndex = 28;
        // 
        // txtEmpRate6
        // 
        _txtEmpRate6.Location = new System.Drawing.Point(152, 200);
        _txtEmpRate6.Name = "_txtEmpRate6";
        _txtEmpRate6.Size = new System.Drawing.Size(64, 20);
        _txtEmpRate6.TabIndex = 26;
        // 
        // txtEmpRate5
        // 
        _txtEmpRate5.Location = new System.Drawing.Point(152, 168);
        _txtEmpRate5.Name = "_txtEmpRate5";
        _txtEmpRate5.Size = new System.Drawing.Size(64, 20);
        _txtEmpRate5.TabIndex = 24;
        // 
        // txtEmpRate4
        // 
        _txtEmpRate4.Location = new System.Drawing.Point(152, 136);
        _txtEmpRate4.Name = "_txtEmpRate4";
        _txtEmpRate4.Size = new System.Drawing.Size(64, 20);
        _txtEmpRate4.TabIndex = 22;
        // 
        // txtEmpRate3
        // 
        _txtEmpRate3.Location = new System.Drawing.Point(152, 104);
        _txtEmpRate3.Name = "_txtEmpRate3";
        _txtEmpRate3.Size = new System.Drawing.Size(64, 20);
        _txtEmpRate3.TabIndex = 20;
        // 
        // cbxEmpJob7
        // 
        _cbxEmpJob7.Location = new System.Drawing.Point(8, 232);
        _cbxEmpJob7.MaxDropDownItems = 20;
        _cbxEmpJob7.Name = "_cbxEmpJob7";
        _cbxEmpJob7.Size = new System.Drawing.Size(136, 21);
        _cbxEmpJob7.TabIndex = 27;
        // 
        // cbxEmpJob6
        // 
        _cbxEmpJob6.Location = new System.Drawing.Point(8, 200);
        _cbxEmpJob6.MaxDropDownItems = 20;
        _cbxEmpJob6.Name = "_cbxEmpJob6";
        _cbxEmpJob6.Size = new System.Drawing.Size(136, 21);
        _cbxEmpJob6.TabIndex = 25;
        // 
        // cbxEmpJob5
        // 
        _cbxEmpJob5.Location = new System.Drawing.Point(8, 168);
        _cbxEmpJob5.MaxDropDownItems = 20;
        _cbxEmpJob5.Name = "_cbxEmpJob5";
        _cbxEmpJob5.Size = new System.Drawing.Size(136, 21);
        _cbxEmpJob5.TabIndex = 23;
        // 
        // cbxEmpJob4
        // 
        _cbxEmpJob4.Location = new System.Drawing.Point(8, 136);
        _cbxEmpJob4.MaxDropDownItems = 20;
        _cbxEmpJob4.Name = "_cbxEmpJob4";
        _cbxEmpJob4.Size = new System.Drawing.Size(136, 21);
        _cbxEmpJob4.TabIndex = 21;
        // 
        // cbxEmpJob3
        // 
        _cbxEmpJob3.Location = new System.Drawing.Point(8, 104);
        _cbxEmpJob3.MaxDropDownItems = 20;
        _cbxEmpJob3.Name = "_cbxEmpJob3";
        _cbxEmpJob3.Size = new System.Drawing.Size(136, 21);
        _cbxEmpJob3.TabIndex = 19;
        // 
        // Label1
        // 
        _Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label1.Location = new System.Drawing.Point(152, 8);
        _Label1.Name = "_Label1";
        _Label1.Size = new System.Drawing.Size(56, 24);
        _Label1.TabIndex = 5;
        _Label1.Text = "Rate";
        _Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblEmpJobCodes
        // 
        _lblEmpJobCodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblEmpJobCodes.Location = new System.Drawing.Point(16, 8);
        _lblEmpJobCodes.Name = "_lblEmpJobCodes";
        _lblEmpJobCodes.Size = new System.Drawing.Size(112, 24);
        _lblEmpJobCodes.TabIndex = 4;
        _lblEmpJobCodes.Text = "Job Codes";
        _lblEmpJobCodes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtEmpRate2
        // 
        _txtEmpRate2.Location = new System.Drawing.Point(152, 72);
        _txtEmpRate2.Name = "_txtEmpRate2";
        _txtEmpRate2.Size = new System.Drawing.Size(64, 20);
        _txtEmpRate2.TabIndex = 18;
        // 
        // txtEmpRate1
        // 
        _txtEmpRate1.Location = new System.Drawing.Point(152, 40);
        _txtEmpRate1.Name = "_txtEmpRate1";
        _txtEmpRate1.Size = new System.Drawing.Size(64, 20);
        _txtEmpRate1.TabIndex = 16;
        // 
        // cbxEmpJob2
        // 
        _cbxEmpJob2.Location = new System.Drawing.Point(8, 72);
        _cbxEmpJob2.MaxDropDownItems = 20;
        _cbxEmpJob2.Name = "_cbxEmpJob2";
        _cbxEmpJob2.Size = new System.Drawing.Size(136, 21);
        _cbxEmpJob2.TabIndex = 17;
        // 
        // cbxEmpJob1
        // 
        _cbxEmpJob1.Location = new System.Drawing.Point(8, 40);
        _cbxEmpJob1.MaxDropDownItems = 20;
        _cbxEmpJob1.Name = "_cbxEmpJob1";
        _cbxEmpJob1.Size = new System.Drawing.Size(136, 21);
        _cbxEmpJob1.TabIndex = 15;
        // 
        // chkEmpTerminated
        // 
        _chkEmpTerminated.Location = new System.Drawing.Point(305, 490);
        _chkEmpTerminated.Name = "_chkEmpTerminated";
        _chkEmpTerminated.Size = new System.Drawing.Size(87, 24);
        _chkEmpTerminated.TabIndex = 33;
        _chkEmpTerminated.TabStop = false;
        _chkEmpTerminated.Text = "Terminated";
        // 
        // chkEmpTraining
        // 
        _chkEmpTraining.Location = new System.Drawing.Point(235, 488);
        _chkEmpTraining.Name = "_chkEmpTraining";
        _chkEmpTraining.Size = new System.Drawing.Size(64, 24);
        _chkEmpTraining.TabIndex = 32;
        _chkEmpTraining.TabStop = false;
        _chkEmpTraining.Text = "Training";
        // 
        // cbxEmpReportsTo
        // 
        _cbxEmpReportsTo.Location = new System.Drawing.Point(328, 432);
        _cbxEmpReportsTo.Name = "_cbxEmpReportsTo";
        _cbxEmpReportsTo.Size = new System.Drawing.Size(160, 21);
        _cbxEmpReportsTo.TabIndex = 14;
        // 
        // txtEmpHire
        // 
        _txtEmpHire.Location = new System.Drawing.Point(328, 400);
        _txtEmpHire.Name = "_txtEmpHire";
        _txtEmpHire.Size = new System.Drawing.Size(96, 20);
        _txtEmpHire.TabIndex = 13;
        // 
        // txtEmpBirth
        // 
        _txtEmpBirth.Location = new System.Drawing.Point(328, 368);
        _txtEmpBirth.Name = "_txtEmpBirth";
        _txtEmpBirth.Size = new System.Drawing.Size(96, 20);
        _txtEmpBirth.TabIndex = 12;
        // 
        // txtEmpCell
        // 
        _txtEmpCell.Location = new System.Drawing.Point(328, 336);
        _txtEmpCell.Name = "_txtEmpCell";
        _txtEmpCell.Size = new System.Drawing.Size(96, 20);
        _txtEmpCell.TabIndex = 11;
        // 
        // txtEmpHome
        // 
        _txtEmpHome.Location = new System.Drawing.Point(328, 304);
        _txtEmpHome.Name = "_txtEmpHome";
        _txtEmpHome.Size = new System.Drawing.Size(96, 20);
        _txtEmpHome.TabIndex = 10;
        // 
        // txtEmpZip
        // 
        _txtEmpZip.Location = new System.Drawing.Point(328, 272);
        _txtEmpZip.Name = "_txtEmpZip";
        _txtEmpZip.Size = new System.Drawing.Size(96, 20);
        _txtEmpZip.TabIndex = 9;
        // 
        // txtEmpState
        // 
        _txtEmpState.Location = new System.Drawing.Point(448, 240);
        _txtEmpState.Name = "_txtEmpState";
        _txtEmpState.Size = new System.Drawing.Size(32, 20);
        _txtEmpState.TabIndex = 8;
        // 
        // txtEmpCity
        // 
        _txtEmpCity.Location = new System.Drawing.Point(328, 240);
        _txtEmpCity.Name = "_txtEmpCity";
        _txtEmpCity.Size = new System.Drawing.Size(96, 20);
        _txtEmpCity.TabIndex = 7;
        // 
        // txtEmpAddress2
        // 
        _txtEmpAddress2.Location = new System.Drawing.Point(328, 208);
        _txtEmpAddress2.Name = "_txtEmpAddress2";
        _txtEmpAddress2.Size = new System.Drawing.Size(152, 20);
        _txtEmpAddress2.TabIndex = 6;
        // 
        // txtEmpAddress1
        // 
        _txtEmpAddress1.Location = new System.Drawing.Point(328, 176);
        _txtEmpAddress1.Name = "_txtEmpAddress1";
        _txtEmpAddress1.Size = new System.Drawing.Size(152, 20);
        _txtEmpAddress1.TabIndex = 5;
        // 
        // txtEmpMiddle
        // 
        _txtEmpMiddle.Location = new System.Drawing.Point(424, 80);
        _txtEmpMiddle.Name = "_txtEmpMiddle";
        _txtEmpMiddle.Size = new System.Drawing.Size(56, 20);
        _txtEmpMiddle.TabIndex = 3;
        // 
        // txtEmpFirst
        // 
        _txtEmpFirst.Location = new System.Drawing.Point(328, 80);
        _txtEmpFirst.Name = "_txtEmpFirst";
        _txtEmpFirst.Size = new System.Drawing.Size(96, 20);
        _txtEmpFirst.TabIndex = 2;
        // 
        // txtEmpLast
        // 
        _txtEmpLast.Location = new System.Drawing.Point(328, 48);
        _txtEmpLast.Name = "_txtEmpLast";
        _txtEmpLast.Size = new System.Drawing.Size(152, 20);
        _txtEmpLast.TabIndex = 1;
        // 
        // lblEmpReportsTo
        // 
        _lblEmpReportsTo.Location = new System.Drawing.Point(248, 432);
        _lblEmpReportsTo.Name = "_lblEmpReportsTo";
        _lblEmpReportsTo.Size = new System.Drawing.Size(80, 24);
        _lblEmpReportsTo.TabIndex = 15;
        _lblEmpReportsTo.Text = "Reports To:";
        _lblEmpReportsTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblEmpHire
        // 
        _lblEmpHire.Location = new System.Drawing.Point(248, 400);
        _lblEmpHire.Name = "_lblEmpHire";
        _lblEmpHire.Size = new System.Drawing.Size(80, 24);
        _lblEmpHire.TabIndex = 14;
        _lblEmpHire.Text = "Hire Date:";
        _lblEmpHire.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblEmpBirth
        // 
        _lblEmpBirth.Location = new System.Drawing.Point(240, 368);
        _lblEmpBirth.Name = "_lblEmpBirth";
        _lblEmpBirth.Size = new System.Drawing.Size(88, 24);
        _lblEmpBirth.TabIndex = 13;
        _lblEmpBirth.Text = "Birth Date:";
        _lblEmpBirth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblEmpCell
        // 
        _lblEmpCell.Location = new System.Drawing.Point(240, 336);
        _lblEmpCell.Name = "_lblEmpCell";
        _lblEmpCell.Size = new System.Drawing.Size(88, 24);
        _lblEmpCell.TabIndex = 12;
        _lblEmpCell.Text = "Cell Phone:";
        _lblEmpCell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblEmpPhone
        // 
        _lblEmpPhone.Location = new System.Drawing.Point(232, 304);
        _lblEmpPhone.Name = "_lblEmpPhone";
        _lblEmpPhone.Size = new System.Drawing.Size(96, 24);
        _lblEmpPhone.TabIndex = 11;
        _lblEmpPhone.Text = "Home Phone:";
        _lblEmpPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblEmpZip
        // 
        _lblEmpZip.Location = new System.Drawing.Point(248, 280);
        _lblEmpZip.Name = "_lblEmpZip";
        _lblEmpZip.Size = new System.Drawing.Size(80, 16);
        _lblEmpZip.TabIndex = 10;
        _lblEmpZip.Text = "Zip:";
        _lblEmpZip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblEmpState
        // 
        _lblEmpState.Location = new System.Drawing.Point(424, 240);
        _lblEmpState.Name = "_lblEmpState";
        _lblEmpState.Size = new System.Drawing.Size(24, 24);
        _lblEmpState.TabIndex = 9;
        _lblEmpState.Text = "St:";
        _lblEmpState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblEmpCity
        // 
        _lblEmpCity.Location = new System.Drawing.Point(240, 248);
        _lblEmpCity.Name = "_lblEmpCity";
        _lblEmpCity.Size = new System.Drawing.Size(88, 16);
        _lblEmpCity.TabIndex = 8;
        _lblEmpCity.Text = "City:";
        _lblEmpCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblEmpAddress2
        // 
        _lblEmpAddress2.Location = new System.Drawing.Point(232, 208);
        _lblEmpAddress2.Name = "_lblEmpAddress2";
        _lblEmpAddress2.Size = new System.Drawing.Size(96, 24);
        _lblEmpAddress2.TabIndex = 7;
        _lblEmpAddress2.Text = "Address 2:";
        _lblEmpAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblEmpAddress1
        // 
        _lblEmpAddress1.Location = new System.Drawing.Point(232, 176);
        _lblEmpAddress1.Name = "_lblEmpAddress1";
        _lblEmpAddress1.Size = new System.Drawing.Size(96, 24);
        _lblEmpAddress1.TabIndex = 6;
        _lblEmpAddress1.Text = "Address 1:";
        _lblEmpAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblEmpNick
        // 
        _lblEmpNick.Location = new System.Drawing.Point(232, 120);
        _lblEmpNick.Name = "_lblEmpNick";
        _lblEmpNick.Size = new System.Drawing.Size(96, 16);
        _lblEmpNick.TabIndex = 5;
        _lblEmpNick.Text = "NickName:";
        _lblEmpNick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblEmpFirst
        // 
        _lblEmpFirst.Location = new System.Drawing.Point(232, 88);
        _lblEmpFirst.Name = "_lblEmpFirst";
        _lblEmpFirst.Size = new System.Drawing.Size(96, 16);
        _lblEmpFirst.TabIndex = 4;
        _lblEmpFirst.Text = "First / Middle:";
        _lblEmpFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblEmpLast
        // 
        _lblEmpLast.Location = new System.Drawing.Point(232, 48);
        _lblEmpLast.Name = "_lblEmpLast";
        _lblEmpLast.Size = new System.Drawing.Size(96, 24);
        _lblEmpLast.TabIndex = 3;
        _lblEmpLast.Text = "Last Name:";
        _lblEmpLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblEmpID
        // 
        _lblEmpID.Location = new System.Drawing.Point(232, 16);
        _lblEmpID.Name = "_lblEmpID";
        _lblEmpID.Size = new System.Drawing.Size(96, 16);
        _lblEmpID.TabIndex = 2;
        _lblEmpID.Text = "Employee ID:";
        _lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // grdActiveEmployee
        // 
        _grdActiveEmployee.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
        _grdActiveEmployee.ColumnHeadersVisible = false;
        _grdActiveEmployee.DataMember = "";
        _grdActiveEmployee.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
        _grdActiveEmployee.HeaderForeColor = System.Drawing.SystemColors.ControlText;
        _grdActiveEmployee.Location = new System.Drawing.Point(18, 31);
        _grdActiveEmployee.Name = "_grdActiveEmployee";
        _grdActiveEmployee.ReadOnly = true;
        _grdActiveEmployee.RowHeadersVisible = false;
        _grdActiveEmployee.Size = new System.Drawing.Size(208, 453);
        _grdActiveEmployee.TabIndex = 0;
        // 
        // btnUpdateEmployee
        // 
        _btnUpdateEmployee.BackColor = System.Drawing.Color.Red;
        _btnUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _btnUpdateEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        _btnUpdateEmployee.Location = new System.Drawing.Point(536, 16);
        _btnUpdateEmployee.Name = "_btnUpdateEmployee";
        _btnUpdateEmployee.Size = new System.Drawing.Size(160, 32);
        _btnUpdateEmployee.TabIndex = 29;
        _btnUpdateEmployee.Text = "Update";
        _btnUpdateEmployee.UseVisualStyleBackColor = false;
        _btnUpdateEmployee.Visible = false;
        // 
        // TabJobCodeDetail
        // 
        _TabJobCodeDetail.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _TabJobCodeDetail.Controls.Add(_Label10);
        _TabJobCodeDetail.Controls.Add(_Panel3);
        _TabJobCodeDetail.Controls.Add(_Panel2);
        _TabJobCodeDetail.Controls.Add(_chkJobManager);
        _TabJobCodeDetail.Controls.Add(_cbxJobCode);
        _TabJobCodeDetail.Controls.Add(_Label8);
        _TabJobCodeDetail.Controls.Add(_Label7);
        _TabJobCodeDetail.Controls.Add(_chkJobHost);
        _TabJobCodeDetail.Controls.Add(_chkJobShareTips);
        _TabJobCodeDetail.Controls.Add(_chkJobReportTips);
        _TabJobCodeDetail.Controls.Add(_chkJobClock);
        _TabJobCodeDetail.Controls.Add(_chkJobPassword);
        _TabJobCodeDetail.Controls.Add(_chkJobCashDrawer);
        _TabJobCodeDetail.Controls.Add(_chkJobServer);
        _TabJobCodeDetail.Controls.Add(_chkJobBar);
        _TabJobCodeDetail.Controls.Add(_chkJobCashier);
        _TabJobCodeDetail.Location = new System.Drawing.Point(4, 22);
        _TabJobCodeDetail.Name = "_TabJobCodeDetail";
        _TabJobCodeDetail.Size = new System.Drawing.Size(736, 518);
        _TabJobCodeDetail.TabIndex = 1;
        _TabJobCodeDetail.Text = "Jobcode Detail";
        // 
        // Label10
        // 
        _Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label10.Location = new System.Drawing.Point(41, 144);
        _Label10.Name = "_Label10";
        _Label10.Size = new System.Drawing.Size(151, 156);
        _Label10.TabIndex = 30;
        _Label10.Text = "Function only defines which screens flows for this Jobcode. For example, Manageme" + "nt will go directly to Management screen. List override options in each Employee" + " under Override Options.";

        // 
        // Panel3
        // 
        _Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        _Panel3.Controls.Add(_btnJobCodeUpdate);
        _Panel3.Controls.Add(_txtUpdateJobCode);
        _Panel3.Location = new System.Drawing.Point(360, 384);
        _Panel3.Name = "_Panel3";
        _Panel3.Size = new System.Drawing.Size(160, 112);
        _Panel3.TabIndex = 29;
        // 
        // btnJobCodeUpdate
        // 
        _btnJobCodeUpdate.BackColor = System.Drawing.Color.Red;
        _btnJobCodeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _btnJobCodeUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        _btnJobCodeUpdate.Location = new System.Drawing.Point(8, 8);
        _btnJobCodeUpdate.Name = "_btnJobCodeUpdate";
        _btnJobCodeUpdate.Size = new System.Drawing.Size(144, 40);
        _btnJobCodeUpdate.TabIndex = 27;
        _btnJobCodeUpdate.Text = "Update";
        _btnJobCodeUpdate.UseVisualStyleBackColor = false;
        // 
        // txtUpdateJobCode
        // 
        _txtUpdateJobCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _txtUpdateJobCode.Location = new System.Drawing.Point(16, 72);
        _txtUpdateJobCode.Name = "_txtUpdateJobCode";
        _txtUpdateJobCode.Size = new System.Drawing.Size(128, 22);
        _txtUpdateJobCode.TabIndex = 26;
        // 
        // Panel2
        // 
        _Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        _Panel2.Controls.Add(_txtNewJobCode);
        _Panel2.Controls.Add(_btnCreateJobCode);
        _Panel2.Location = new System.Drawing.Point(536, 384);
        _Panel2.Name = "_Panel2";
        _Panel2.Size = new System.Drawing.Size(160, 112);
        _Panel2.TabIndex = 28;
        // 
        // txtNewJobCode
        // 
        _txtNewJobCode.Location = new System.Drawing.Point(16, 72);
        _txtNewJobCode.Name = "_txtNewJobCode";
        _txtNewJobCode.Size = new System.Drawing.Size(128, 20);
        _txtNewJobCode.TabIndex = 26;
        // 
        // btnCreateJobCode
        // 
        _btnCreateJobCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _btnCreateJobCode.Location = new System.Drawing.Point(8, 8);
        _btnCreateJobCode.Name = "_btnCreateJobCode";
        _btnCreateJobCode.Size = new System.Drawing.Size(144, 40);
        _btnCreateJobCode.TabIndex = 25;
        _btnCreateJobCode.Text = "Create New";
        // 
        // chkJobManager
        // 
        _chkJobManager.Location = new System.Drawing.Point(240, 144);
        _chkJobManager.Name = "_chkJobManager";
        _chkJobManager.Size = new System.Drawing.Size(104, 24);
        _chkJobManager.TabIndex = 24;
        _chkJobManager.Text = "Manager";
        // 
        // cbxJobCode
        // 
        _cbxJobCode.Location = new System.Drawing.Point(296, 40);
        _cbxJobCode.Name = "_cbxJobCode";
        _cbxJobCode.Size = new System.Drawing.Size(176, 21);
        _cbxJobCode.TabIndex = 23;
        // 
        // Label8
        // 
        _Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label8.Location = new System.Drawing.Point(480, 112);
        _Label8.Name = "_Label8";
        _Label8.Size = new System.Drawing.Size(100, 23);
        _Label8.TabIndex = 22;
        _Label8.Text = "Requirements";
        _Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // Label7
        // 
        _Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label7.Location = new System.Drawing.Point(216, 112);
        _Label7.Name = "_Label7";
        _Label7.Size = new System.Drawing.Size(100, 23);
        _Label7.TabIndex = 21;
        _Label7.Text = "Functions";
        _Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // chkJobHost
        // 
        _chkJobHost.Location = new System.Drawing.Point(240, 304);
        _chkJobHost.Name = "_chkJobHost";
        _chkJobHost.Size = new System.Drawing.Size(104, 24);
        _chkJobHost.TabIndex = 12;
        _chkJobHost.Text = "Host / Hostess";
        // 
        // chkJobShareTips
        // 
        _chkJobShareTips.Location = new System.Drawing.Point(520, 272);
        _chkJobShareTips.Name = "_chkJobShareTips";
        _chkJobShareTips.Size = new System.Drawing.Size(112, 24);
        _chkJobShareTips.TabIndex = 7;
        _chkJobShareTips.Text = "Share Tips Req'd";
        _chkJobShareTips.Visible = false;
        // 
        // chkJobReportTips
        // 
        _chkJobReportTips.Location = new System.Drawing.Point(520, 232);
        _chkJobReportTips.Name = "_chkJobReportTips";
        _chkJobReportTips.Size = new System.Drawing.Size(120, 24);
        _chkJobReportTips.TabIndex = 6;
        _chkJobReportTips.Text = "Report Tips Req'd";
        _chkJobReportTips.Visible = false;
        // 
        // chkJobClock
        // 
        _chkJobClock.Checked = true;
        _chkJobClock.CheckState = System.Windows.Forms.CheckState.Checked;
        _chkJobClock.Location = new System.Drawing.Point(520, 192);
        _chkJobClock.Name = "_chkJobClock";
        _chkJobClock.Size = new System.Drawing.Size(104, 24);
        _chkJobClock.TabIndex = 5;
        _chkJobClock.Text = "Clock-in Req'd";
        _chkJobClock.Visible = false;
        // 
        // chkJobPassword
        // 
        _chkJobPassword.Location = new System.Drawing.Point(520, 152);
        _chkJobPassword.Name = "_chkJobPassword";
        _chkJobPassword.Size = new System.Drawing.Size(112, 24);
        _chkJobPassword.TabIndex = 4;
        _chkJobPassword.Text = "Password Req'd";
        // 
        // chkJobCashDrawer
        // 
        _chkJobCashDrawer.Location = new System.Drawing.Point(240, 352);
        _chkJobCashDrawer.Name = "_chkJobCashDrawer";
        _chkJobCashDrawer.Size = new System.Drawing.Size(104, 24);
        _chkJobCashDrawer.TabIndex = 3;
        _chkJobCashDrawer.Text = "Cash Drawer";
        // 
        // chkJobServer
        // 
        _chkJobServer.Location = new System.Drawing.Point(240, 224);
        _chkJobServer.Name = "_chkJobServer";
        _chkJobServer.Size = new System.Drawing.Size(104, 24);
        _chkJobServer.TabIndex = 2;
        _chkJobServer.Text = "Server";
        // 
        // chkJobBar
        // 
        _chkJobBar.Location = new System.Drawing.Point(240, 184);
        _chkJobBar.Name = "_chkJobBar";
        _chkJobBar.Size = new System.Drawing.Size(104, 24);
        _chkJobBar.TabIndex = 1;
        _chkJobBar.Text = "Bartender";
        // 
        // chkJobCashier
        // 
        _chkJobCashier.Location = new System.Drawing.Point(240, 264);
        _chkJobCashier.Name = "_chkJobCashier";
        _chkJobCashier.Size = new System.Drawing.Size(104, 24);
        _chkJobCashier.TabIndex = 0;
        _chkJobCashier.Text = "Cashier";
        // 
        // lblEmpInstruct
        // 
        _lblEmpInstruct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblEmpInstruct.ForeColor = System.Drawing.Color.White;
        _lblEmpInstruct.Location = new System.Drawing.Point(487, 35);
        _lblEmpInstruct.Name = "_lblEmpInstruct";
        _lblEmpInstruct.Size = new System.Drawing.Size(198, 57);
        _lblEmpInstruct.TabIndex = 39;
        _lblEmpInstruct.Text = "Select New Employee ID from Drop Down Box ONLY to add New Employee";
        _lblEmpInstruct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // cbxEmpID
        // 
        _cbxEmpID.Location = new System.Drawing.Point(544, 95);
        _cbxEmpID.MaxDropDownItems = 50;
        _cbxEmpID.Name = "_cbxEmpID";
        _cbxEmpID.Size = new System.Drawing.Size(88, 21);
        _cbxEmpID.TabIndex = 0;
        // 
        // SetupEmploy
        // 
        this.BackColor = System.Drawing.Color.FromArgb(0, 78, 152);
        this.Controls.Add(_TabControl1);
        this.Controls.Add(_lblEmpInstruct);
        this.Controls.Add(_cbxEmpID);
        this.Name = "SetupEmploy";
        this.Size = new System.Drawing.Size(792, 704);
        _TabControl1.ResumeLayout(false);
        _tabEmpDetail.ResumeLayout(false);
        _tabEmpDetail.PerformLayout();
        _pnlOverrides.ResumeLayout(false);
        _pnlEmpTax.ResumeLayout(false);
        _pnlEmpTax.PerformLayout();
        _pnlJobPayRates.ResumeLayout(false);
        _pnlJobPayRates.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_grdActiveEmployee).EndInit();
        _TabJobCodeDetail.ResumeLayout(false);
        _Panel3.ResumeLayout(false);
        _Panel3.PerformLayout();
        _Panel2.ResumeLayout(false);
        _Panel2.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private void InitializeOther()
    {

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            GenerateEmployeeDataSets();
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        CreateEmpIDArray();
        UpdateEmpIDArray();

        DisplayEmployeeListTab();

        RePositionOverridePanel();

        BindData();

        BindJobCodeNameComboBoxes222();

    }


    private void BindData()
    {
        DataRow oRow;

        EmployeeCurrencyMan = BindingContext(dsSetup.Tables("ActiveEmployee"));


        // *****************************
        // EmployList
        JobCodeCurrencyMan = BindingContext(dsSetup.Tables("JobCodes"));
        foreach (int empID in availEmpID)
            cbxEmpID.Items.Add(empID);

        grdActiveEmployee.DataSource = dsSetup.Tables("ActiveEmployee");
        cbxJobCode.DataSource = dsSetup.Tables("JobCodes");
        cbxJobCode.DisplayMember = "JobCodeName";

        // *****must add one back
        // Me.cbxEmpID.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "EmployeeID")
        txtEmpID.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "EmployeeNumber");
        txtEmpLast.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "LastName");
        txtEmpFirst.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "FirstName");
        txtEmpMiddle.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "MiddleName");
        txtEmpNick.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "NickName");
        txtSSN.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "SSN");
        txtEmpAddress1.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "Address1");
        txtEmpAddress2.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "Address2");
        txtEmpCity.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "City");
        txtEmpState.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "State");
        txtEmpZip.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "Zip");
        txtEmpHome.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "HomePhone");
        txtEmpCell.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "CellPhone");
        txtEmpBirth.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "BirthDate");
        txtEmpHire.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "HireDate");
        txtPasscode.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "Passcode");



        // Me.cbxEmpReportsTo.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "ReportsTo")
        chkEmpTraining.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "Training");
        chkEmpTerminated.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "Terminated");

        chkOperationAll.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "OperationMgmtAll");
        chkOperationLimited.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "OperationMgmtLimited");
        chkReportAll.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "ReportMgmtAll");
        chkReportLimited.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "ReportMgmtLimited");
        chkSystemAll.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "SystemMgmtAll");
        chkSystemLimited.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "SystemMgmtLimited");
        chkEmployeeAll.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "EmployeeMgmtAll");
        chkEmployeeLimited.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "EmployeeMgmtLimited");
        chkClockInReqFirst.DataBindings.Add("Checked", dsSetup.Tables("ActiveEmployee"), "ClockInReq");

        foreach (DataRow currentORow in dsSetup.Tables("ActiveEmployee").Rows)
        {
            oRow = currentORow;
            if (oRow("EmployeeMgmtAll") == true | oRow("EmployeeMgmtLimited") == true)
            {
                cbxEmpReportsTo.Items.Add(oRow("LastName") + ", " + oRow("FirstName"));
            }
        }
        cbxEmpReportsTo.Items.Add("** Delete Supervisor **");

        BindJobCodeNames();

        foreach (DataRow currentORow1 in dsSetup.Tables("TaxFilingStatus").Rows)
        {
            oRow = currentORow1;
            cbxEmpFiling.Items.Add(oRow("FilingStatusName"));
        }

        txtEmpRate1.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobRate1");
        txtEmpRate2.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobRate2");
        txtEmpRate3.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobRate3");
        txtEmpRate4.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobRate4");
        txtEmpRate5.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobRate5");
        txtEmpRate6.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobRate6");
        txtEmpRate7.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobRate7");

        cbxEmpJob1.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobName1");
        cbxEmpJob2.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobName2");
        cbxEmpJob3.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobName3");
        cbxEmpJob4.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobName4");
        cbxEmpJob5.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobName5");
        cbxEmpJob6.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobName6");
        cbxEmpJob7.DataBindings.Add("Text", dsSetup.Tables("ActiveEmployee"), "JobName7");



        cbxJobCode.DataBindings.Add("Text", dsSetup.Tables("JobCodes"), "JobCodeName");
        txtUpdateJobCode.DataBindings.Add("Text", dsSetup.Tables("JobCodes"), "JobCodeName");
        chkJobManager.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "Manager");
        chkJobBar.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "Bartender");
        chkJobServer.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "Server");
        chkJobCashier.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "Cashier");
        chkJobHost.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "Hostess");
        chkJobPassword.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "PasswordReq");
        chkJobClock.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "ClockInReq");
        chkJobReportTips.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "ReportTipsReq");
        chkJobShareTips.DataBindings.Add("Checked", dsSetup.Tables("JobCodes"), "ShareTipsReq");

    }

    private void RePopulateJobCodeData()
    {

        dsSetup.Tables("JobCodes").Clear();
        sql.SqlSelectCommandEmployeeJobCodes.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandEmployeeJobCodes.Parameters("@LocationID").Value = corpPhysicalLocation;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlEmployeeJobCodes.Fill(dsSetup.Tables("JobCodes"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

    }

    private void BindJobCodeNames()
    {

        cbxEmpJob1.Items.Clear();
        cbxEmpJob2.Items.Clear();
        cbxEmpJob3.Items.Clear();
        cbxEmpJob4.Items.Clear();
        cbxEmpJob5.Items.Clear();
        cbxEmpJob6.Items.Clear();
        cbxEmpJob7.Items.Clear();

        foreach (DataRow oRow in dsSetup.Tables("JobCodes").Rows)
        {
            cbxEmpJob1.Items.Add(oRow("JobCodeName"));
            cbxEmpJob2.Items.Add(oRow("JobCodeName"));
            cbxEmpJob3.Items.Add(oRow("JobCodeName"));
            cbxEmpJob4.Items.Add(oRow("JobCodeName"));
            cbxEmpJob5.Items.Add(oRow("JobCodeName"));
            cbxEmpJob6.Items.Add(oRow("JobCodeName"));
            cbxEmpJob7.Items.Add(oRow("JobCodeName"));
            // this is on 2nd page
            // Me.cbxJobCode.Items.Add(oRow("JobCodeName"))
        }

        cbxEmpJob1.Items.Add("** Delete Job Code **");
        cbxEmpJob2.Items.Add("** Delete Job Code **");
        cbxEmpJob3.Items.Add("** Delete Job Code **");
        cbxEmpJob4.Items.Add("** Delete Job Code **");
        cbxEmpJob5.Items.Add("** Delete Job Code **");
        cbxEmpJob6.Items.Add("** Delete Job Code **");
        cbxEmpJob7.Items.Add("** Delete Job Code **");

    }

    private void RePositionOverridePanel()
    {

        pnlOverrides.Location = new Point((this.Width - pnlOverrides.Width) / 2, (this.Height - pnlOverrides.Height) / 2);

    }

    private void DisplayEmployeeListTab()
    {
        var tsActiveEmployee = new DataGridTableStyle();
        tsActiveEmployee.MappingName = "ActiveEmployee";
        tsActiveEmployee.RowHeadersVisible = false;
        tsActiveEmployee.GridLineStyle = DataGridLineStyle.None;

        var csLastName = new DataGridTextBoxColumn();
        csLastName.MappingName = "LastName";
        csLastName.Width = 100;

        var csFirstName = new DataGridTextBoxColumn();
        csFirstName.MappingName = "FirstName";
        csFirstName.Width = 50;

        var csEmpID = new DataGridTextBoxColumn();
        csEmpID.MappingName = "EmployeeNumber";
        csEmpID.Width = 50;

        tsActiveEmployee.GridColumnStyles.Add(csLastName);
        tsActiveEmployee.GridColumnStyles.Add(csFirstName);
        tsActiveEmployee.GridColumnStyles.Add(csEmpID);
        grdActiveEmployee.TableStyles.Add(tsActiveEmployee);

    }

    private void UpdateDatabaseEmployee()
    {

        // If didNotAddEmployee = True Then
        // If Me.txtEmpLast.TextLength = 0 Then
        // dsSetup.Tables("ActiveEmployee").RejectChanges()
        // Exit Sub 'this is if we start to add emp but don't put a last name
        // End If

        if (!dsSetup.HasChanges)
            return;
        MakeSureAllSelectedJobCodesNoNULLS222();

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlEmployeeActiveEmployee.Update(dsSetup, "ActiveEmployee");
            sql.cn.Close();
            dsSetup.Tables("ActiveEmployee").AcceptChanges();
        }
        catch (Exception ex)
        {
            CloseConnection();
            Interaction.MsgBox(ex.Message);
        }


    }

    private void MakeSureAllSelectedJobCodesNoNULLS222()
    {

        if (!object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID1"), DBNull.Value))
        {
            if (object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate1"), DBNull.Value))
            {
                dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate1") = 0;
            }
        }
        if (!object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID2"), DBNull.Value))
        {
            if (object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate2"), DBNull.Value))
            {
                dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate2") = 0;
            }
        }
        if (!object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID3"), DBNull.Value))
        {
            if (object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate3"), DBNull.Value))
            {
                dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate3") = 0;
            }
        }
        if (!object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID4"), DBNull.Value))
        {
            if (object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate4"), DBNull.Value))
            {
                dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate4") = 0;
            }
        }
        if (!object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID5"), DBNull.Value))
        {
            if (object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate5"), DBNull.Value))
            {
                dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate5") = 0;
            }
        }
        if (!object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID6"), DBNull.Value))
        {
            if (object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate6"), DBNull.Value))
            {
                dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate6") = 0;
            }
        }
        if (!object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID7"), DBNull.Value))
        {
            if (object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate7"), DBNull.Value))
            {
                dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate7") = 0;
            }
        }

    }

    private void btnUpdateEmployee_Click(object sender, EventArgs e)
    {

        if (EmployeeCurrencyMan.Position == 0)
        {
            EmployeeCurrencyMan.Position += 1;
            EmployeeCurrencyMan.Position -= 1;
        }
        else
        {
            EmployeeCurrencyMan.Position -= 1;
            EmployeeCurrencyMan.Position += 1;
        }

        UpdateDatabaseEmployee();

    }

    private void cbxEmpID_SelectedIndexChanged(object sender, EventArgs e)
    {

        DataRow oRow;

        oRow = dsSetup.Tables("ActiveEmployee").NewRow;

        oRow("CompanyID") = corpID;
        oRow("LocationID") = corpPhysicalLocation;   // selectedLocation
        oRow("EmployeeNumber") = (int)cbxEmpID.Text;
        availEmpID.Remove(cbxEmpID.Text);
        oRow("LastName") = "Enter Last Name";
        oRow("FirstName") = "";
        oRow("MiddleName") = "";
        oRow("NickName") = "";
        oRow("Passcode") = Strings.Format(Conversion.Int(9999f * VBMath.Rnd() + 1f), "0000");
        oRow("BirthDate") = DBNull.Value;
        oRow("HireDate") = Strings.Format(DateTime.Now, "M/d/yyyy");
        oRow("Address1") = "";
        oRow("Address2") = "";
        oRow("City") = "";
        oRow("State") = "";
        oRow("Zip") = "";
        oRow("HomePhone") = "";
        oRow("CellPhone") = "";

        oRow("ReportsTo") = DBNull.Value;
        oRow("Training") = 0;
        oRow("Terminated") = 0;
        oRow("ClockInReq") = 1;

        oRow("ReportMgmtAll") = 0;
        oRow("ReportMgmtLimited") = 0;
        oRow("OperationMgmtAll") = 0;
        oRow("OperationMgmtLimited") = 0;
        oRow("SystemMgmtAll") = 0;
        oRow("SystemMgmtLimited") = 0;
        oRow("EmployeeMgmtAll") = 0;
        oRow("EmployeeMgmtLimited") = 0;

        oRow("JobCodeID1") = DBNull.Value;
        oRow("JobRate1") = 0; // DBNull.Value
        oRow("JobCodeID2") = DBNull.Value;
        oRow("JobRate2") = 0; // DBNull.Value
        oRow("JobCodeID3") = DBNull.Value;
        oRow("JobRate3") = 0; // DBNull.Value
        oRow("JobCodeID4") = DBNull.Value;
        oRow("JobRate4") = 0; // DBNull.Value
        oRow("JobCodeID5") = DBNull.Value;
        oRow("JobRate5") = 0; // DBNull.Value
        oRow("JobCodeID6") = DBNull.Value;
        oRow("JobRate6") = 0; // DBNull.Value
        oRow("JobCodeID7") = DBNull.Value;
        oRow("JobRate7") = 0; // DBNull.Value
        oRow("Lefty") = 0; // DBNull.Value

        dsSetup.Tables("ActiveEmployee").Rows.Add(oRow);

        EmployeeCurrencyMan.Position = EmployeeCurrencyMan.Count - 1;
        txtEmpLast.Focus();
        // didNotAddEmployee = True

    }

    // Private Sub txtEmpLast_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpLast.TextChanged
    // If Me.txtEmpLast.TextLength = 1 Then
    // didNotAddEmployee = False
    // End If
    // End Sub

    private void CreateEmpIDArray()
    {
        int index;
        bool addID;

        for (index = 1000; index <= 9999; index++)
            availEmpID.Add(index);

        foreach (DataRow oRow in dsSetup.Tables("ActiveEmployee").Rows)
            availEmpID.Remove(oRow("EmployeeNumber"));
        availEmpID.Remove(6986); // me

    }

    private void UpdateEmpIDArray()
    {

        foreach (DataRow oRow in dsSetup.Tables("UsedEmployeeNumber").Rows)
            availEmpID.Remove(oRow("EmployeeNumber"));

    }

    private void txtEmpFirst_TextChanged(object sender, EventArgs e)
    {
        // If Me.txtEmpNick.Text.Length = 0 Then
        txtEmpNick.Text = txtEmpFirst.Text;
        // End If

    }


    private void BindJobCodeNameComboBoxes222()
    {
        DataRow oRow;
        return;

        cbxEmpJob1.SelectedIndex = -1;
        cbxEmpJob2.SelectedIndex = -1;
        cbxEmpJob3.SelectedIndex = -1;
        cbxEmpJob4.SelectedIndex = -1;
        cbxEmpJob5.SelectedIndex = -1;
        cbxEmpJob6.SelectedIndex = -1;
        cbxEmpJob7.SelectedIndex = -1;

        if (dsSetup.Tables("ActiveEmployee").Rows.Count == 0 | EmployeeCurrencyMan.Position == -1)
        {
            return;
        }

        foreach (DataRow currentORow in dsSetup.Tables("JobCodes").Rows)
        {
            oRow = currentORow;
            if (!object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID1"), DBNull.Value))
            {
                if (oRow("JobCodeID") == dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID1"))
                {
                    cbxEmpJob1.SelectedItem = oRow("JobCodeName");
                }
            }
            if (!object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID2"), DBNull.Value))
            {
                if (oRow("JobCodeID") == dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID2"))
                {
                    cbxEmpJob2.SelectedItem = oRow("JobCodeName");
                }
            }
            if (!object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID3"), DBNull.Value))
            {
                if (oRow("JobCodeID") == dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID3"))
                {
                    cbxEmpJob3.SelectedItem = oRow("JobCodeName");
                }
            }
            if (!object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID4"), DBNull.Value))
            {
                if (oRow("JobCodeID") == dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID4"))
                {
                    cbxEmpJob4.SelectedItem = oRow("JobCodeName");
                }
            }
            if (!object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID5"), DBNull.Value))
            {
                if (oRow("JobCodeID") == dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID5"))
                {
                    cbxEmpJob5.SelectedItem = oRow("JobCodeName");
                }
            }

            if (!object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID6"), DBNull.Value))
            {
                if (oRow("JobCodeID") == dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID6"))
                {
                    cbxEmpJob6.SelectedItem = oRow("JobCodeName");
                }
            }
            if (!object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID7"), DBNull.Value))
            {
                if (oRow("JobCodeID") == dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID7"))
                {
                    cbxEmpJob7.SelectedItem = oRow("JobCodeName");
                }
            }
        }

        cbxEmpReportsTo.SelectedIndex = -1;
        foreach (DataRow currentORow1 in dsSetup.Tables("ActiveEmployee").Rows)
        {
            oRow = currentORow1;
            if (!object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("ReportsTo"), DBNull.Value))
            {
                if (oRow("EmployeeNumber") == dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("ReportsTo"))
                {
                    cbxEmpReportsTo.SelectedItem = oRow("LastName") + ", " + oRow("FirstName");
                }
            }
        }


    }

    private void cbxEmpJob1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbxEmpJob1.SelectedIndex == -1)
            return;

        int valueCatID;
        string valueCatName;

        if (cbxEmpJob1.Text == "** Delete Job Code **" | cbxEmpJob1.Text == "")
        {
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobName1") = DBNull.Value;
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID1") = DBNull.Value;
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate1") = 0; // DBNull.Value
            cbxEmpJob1.SelectedIndex = -1;
            return;
        }
        else
        {

            valueCatID = dsSetup.Tables("JobCodes").Rows(cbxEmpJob1.SelectedIndex)("JobCodeID");
            valueCatName = dsSetup.Tables("JobCodes").Rows(cbxEmpJob1.SelectedIndex)("JobCodeName");
        }

        dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID1") = valueCatID;
        dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobName1") = valueCatName;

    }

    private void cbxEmpJob2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbxEmpJob2.SelectedIndex == -1)
            return;

        int valueCatID;
        string valueCatName;

        if (cbxEmpJob2.Text == "** Delete Job Code **" | cbxEmpJob2.Text == "")
        {
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobName2") = DBNull.Value;
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID2") = DBNull.Value;
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate2") = 0; // DBNull.Value
            cbxEmpJob2.SelectedIndex = -1;
            return;
        }
        else
        {

            valueCatID = dsSetup.Tables("JobCodes").Rows(cbxEmpJob2.SelectedIndex)("JobCodeID");
            valueCatName = dsSetup.Tables("JobCodes").Rows(cbxEmpJob2.SelectedIndex)("JobCodeName");
        }

        dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID2") = valueCatID;
        dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobName2") = valueCatName;

    }

    private void cbxEmpJob3_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbxEmpJob3.SelectedIndex == -1)
            return;

        int valueCatID;
        string valueCatName;

        if (cbxEmpJob3.Text == "** Delete Job Code **" | cbxEmpJob3.Text == "")
        {
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobName3") = DBNull.Value;
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID3") = DBNull.Value;
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate3") = 0; // DBNull.Value
            cbxEmpJob3.SelectedIndex = -1;
            return;
        }
        else
        {

            valueCatID = dsSetup.Tables("JobCodes").Rows(cbxEmpJob3.SelectedIndex)("JobCodeID");
            valueCatName = dsSetup.Tables("JobCodes").Rows(cbxEmpJob3.SelectedIndex)("JobCodeName");
        }

        dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID3") = valueCatID;
        dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobName3") = valueCatName;

    }

    private void cbxEmpJob4_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbxEmpJob4.SelectedIndex == -1)
            return;

        int valueCatID;
        string valueCatName;

        if (cbxEmpJob4.Text == "** Delete Job Code **" | cbxEmpJob4.Text == "")
        {
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobName4") = DBNull.Value;
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID4") = DBNull.Value;
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate4") = 0; // DBNull.Value
            cbxEmpJob4.SelectedIndex = -1;
            return;
        }
        else
        {

            valueCatID = dsSetup.Tables("JobCodes").Rows(cbxEmpJob4.SelectedIndex)("JobCodeID");
            valueCatName = dsSetup.Tables("JobCodes").Rows(cbxEmpJob4.SelectedIndex)("JobCodeName");
        }

        dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID4") = valueCatID;
        dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobName4") = valueCatName;

    }

    private void cbxEmpJob5_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbxEmpJob5.SelectedIndex == -1)
            return;

        int valueCatID;
        string valueCatName;

        if (cbxEmpJob5.Text == "** Delete Job Code **" | cbxEmpJob5.Text == "")
        {
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobName5") = DBNull.Value;
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID5") = DBNull.Value;
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate5") = 0; // DBNull.Value
            cbxEmpJob5.SelectedIndex = -1;
            return;
        }
        else
        {

            valueCatID = dsSetup.Tables("JobCodes").Rows(cbxEmpJob5.SelectedIndex)("JobCodeID");
            valueCatName = dsSetup.Tables("JobCodes").Rows(cbxEmpJob5.SelectedIndex)("JobCodeName");
        }

        dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID5") = valueCatID;
        dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobName5") = valueCatName;

    }

    private void cbxEmpJob6_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbxEmpJob6.SelectedIndex == -1)
            return;

        int valueCatID;
        string valueCatName;

        if (cbxEmpJob6.Text == "** Delete Job Code **" | cbxEmpJob6.Text == "")
        {
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobName6") = DBNull.Value;
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID6") = DBNull.Value;
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate6") = 0; // DBNull.Value
            cbxEmpJob6.SelectedIndex = -1;
            return;
        }
        else
        {

            valueCatID = dsSetup.Tables("JobCodes").Rows(cbxEmpJob6.SelectedIndex)("JobCodeID");
            valueCatName = dsSetup.Tables("JobCodes").Rows(cbxEmpJob6.SelectedIndex)("JobCodeName");
        }

        dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID6") = valueCatID;
        dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobName6") = valueCatName;

    }

    private void cbxEmpJob7_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbxEmpJob7.SelectedIndex == -1)
            return;

        int valueCatID;
        string valueCatName;

        if (cbxEmpJob7.Text == "** Delete Job Code **" | cbxEmpJob7.Text == "")
        {
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobName7") = DBNull.Value;
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID7") = DBNull.Value;
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobRate7") = 0; // DBNull.Value
            cbxEmpJob7.SelectedIndex = -1;
            return;
        }
        else
        {

            valueCatID = dsSetup.Tables("JobCodes").Rows(cbxEmpJob7.SelectedIndex)("JobCodeID");
            valueCatName = dsSetup.Tables("JobCodes").Rows(cbxEmpJob7.SelectedIndex)("JobCodeName");
        }

        dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobCodeID7") = valueCatID;
        dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("JobName7") = valueCatName;

    }

    private void cbxEmpReportsTO_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbxEmpReportsTo.SelectedIndex == -1)
            return;

        int valueCatID;
        int index = 0;

        if (cbxEmpReportsTo.Text == "** Delete Supervisor **")
        {
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("ReportsTo") = DBNull.Value;
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("ReportsTo") = DBNull.Value;
            cbxEmpReportsTo.SelectedIndex = -1;
            return;
        }

        else
        {
            valueCatID = cbxEmpReportsTo.SelectedIndex;

            foreach (DataRow oRow in dsSetup.Tables("ActiveEmployee").Rows)
            {
                if (oRow("EmployeeMgmtAll") == true | oRow("EmployeeMgmtLimited") == true)
                {
                    if (valueCatID == index)
                    {
                        dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("ReportsTo") = valueCatID;
                        break;
                    }
                    index += 1;
                }
            }
        }

    }

    private void btnOPverrideClose_Click(object sender, EventArgs e)
    {
        pnlOverrides.Visible = false;

    }

    private void btnOverrides_Click(object sender, EventArgs e)
    {
        pnlOverrides.Visible = true;
        pnlOverrides.BringToFront();

    }

    private void btnCreateJobCode_Click(object sender, EventArgs e)
    {

        if (txtNewJobCode.Text.Length == 0)
        {
            Interaction.MsgBox("Please Enter New Job Code Name.");
            return;
        }

        DataRow oRow;
        bool existingJobCode = false;

        foreach (DataRow currentORow in dsSetup.Tables("JobCodes").Rows)
        {
            oRow = currentORow;
            if (string.Compare(oRow("JobCodeName"), txtNewJobCode.Text, true) == 0) // (oRow("JobCodeName") = Me.txtNewJobCode.Text Then
            {
                existingJobCode = true;
                break;
            }
        }

        if (existingJobCode == true)
        {
            Interaction.MsgBox(txtNewJobCode.Text + " already exists");
            return;
        }

        oRow = dsSetup.Tables("JobCodes").NewRow;

        oRow("CompanyID") = corpID;
        oRow("LocationID") = corpPhysicalLocation;   // selectedLocation
        oRow("JobCodeName") = txtNewJobCode.Text;
        oRow("Manager") = chkJobManager.Checked;
        oRow("Cashier") = chkJobCashier.Checked;
        oRow("Bartender") = chkJobBar.Checked;
        oRow("Server") = chkJobServer.Checked;
        oRow("Hostess") = chkJobHost.Checked;
        oRow("PasswordReq") = chkJobPassword.Checked;
        oRow("ClockInReq") = chkJobClock.Checked;
        oRow("ReportTipsReq") = chkJobReportTips.Checked;
        oRow("ShareTipsReq") = chkJobShareTips.Checked;

        dsSetup.Tables("JobCodes").Rows.Add(oRow);

        JobCodeCurrencyMan.Position = dsSetup.Tables("JobCodes").Rows.Count - 1;
        txtNewJobCode.Text = "";

    }

    private void UpdateJobCodeDatabase()
    {
        if (!dsSetup.HasChanges)
            return;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlEmployeeJobCodes.Update(dsSetup, "JobCodes");
            sql.cn.Close();

            dsSetup.Tables("JobCodes").AcceptChanges();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        cbxJobCode.Invalidate();

        RePopulateJobCodeData();
        BindJobCodeNames();

    }

    private void tabEmpDetail_Click(object sender, EventArgs e)
    {

        if (EmployeeCurrencyMan.Position == 0)
        {
            EmployeeCurrencyMan.Position += 1;
            EmployeeCurrencyMan.Position -= 1;
        }
        else
        {
            EmployeeCurrencyMan.Position -= 1;
            EmployeeCurrencyMan.Position += 1;
        }

        UpdateDatabaseEmployee();

    }

    private void TabJobCodeDetail_Click(object sender, EventArgs e)
    {

        if (JobCodeCurrencyMan.Position == 0)
        {
            JobCodeCurrencyMan.Position += 1;
            JobCodeCurrencyMan.Position -= 1;
        }
        else
        {
            JobCodeCurrencyMan.Position -= 1;
            JobCodeCurrencyMan.Position += 1;
        }

        UpdateJobCodeDatabase();

    }


    private void btnJobCodeUpdate_Click(object sender, EventArgs e)
    {

        if (JobCodeCurrencyMan.Position == 0)
        {
            JobCodeCurrencyMan.Position += 1;
            JobCodeCurrencyMan.Position -= 1;
        }
        else
        {
            JobCodeCurrencyMan.Position -= 1;
            JobCodeCurrencyMan.Position += 1;
        }
        UpdateJobCodeDatabase();

        return;

        // we don't need below because everything is bound

        if (JobCodeCurrencyMan.Position == -1)
        {
            Interaction.MsgBox("Please Select a Job Code.");
            return;
        }

        DataRow oRow;

        oRow = dsSetup.Tables("JobCodes").Rows(JobCodeCurrencyMan.Position);

        oRow("CompanyID") = corpID;
        oRow("LocationID") = corpPhysicalLocation;   // selectedLocation
        oRow("JobCodeName") = txtUpdateJobCode.Text;
        oRow("Manager") = chkJobManager.Checked;
        oRow("Cashier") = chkJobCashier.Checked;
        oRow("Bartender") = chkJobBar.Checked;
        oRow("Server") = chkJobServer.Checked;
        oRow("Hostess") = chkJobHost.Checked;
        oRow("PasswordReq") = chkJobPassword.Checked;
        oRow("ClockInReq") = chkJobClock.Checked;
        oRow("ReportTipsReq") = chkJobReportTips.Checked;
        oRow("ShareTipsReq") = chkJobShareTips.Checked;

        RePopulateJobCodeData();

    }

    private void grdActiveEmployee_Changed(object sender, EventArgs e)
    {

        if (object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("SwipeCode"), DBNull.Value))
        {
            btnSwipeCode.Text = "Inactive Swipe Code";
        }
        else
        {
            btnSwipeCode.Text = "Swipe Code";
        }

    }

    private void CardJustSwiped(ref Payment newPayment)
    {

        dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("SwipeCode") = newPayment.SwipeCode;
        btnSwipeCode.Text = "Swipe Code";

    }

    private void btnSwipeCode_Click(object sender, EventArgs e)
    {


        if (object.ReferenceEquals(dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("SwipeCode"), DBNull.Value))
        {
            Interaction.MsgBox("Swipe Card Now to Add Swipe Code");
        }

        else if (Interaction.MsgBox("Would you like to remove Swipe Code?", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
        {
            dsSetup.Tables("ActiveEmployee").Rows(EmployeeCurrencyMan.Position)("SwipeCode") = DBNull.Value;
            btnSwipeCode.Text = "Inactive Swipe Code";
        }
        else
        {
            Interaction.MsgBox("Swipe Card Now to Replace Swipe Code");
        }
        // AddCardHandler()

    }

    internal void AddCardHandler()
    {

        // 999
        // Exit Sub
        try
        {
            // because if Swipe is not connected this won't work
            tmrCardRead_DSB.Start();
            tmrCardRead_DSB.Tick += readSwipe.tmrCardRead_Tick;
        }

        catch (Exception ex)
        {

        }

    }

    internal void RemoveCardHandler()
    {
        // 999
        // Exit Sub
        try
        {
            tmrCardRead_DSB.Stop();
            tmrCardRead_DSB.Tick -= readSwipe.tmrCardRead_Tick;
        }

        catch (Exception ex)
        {

        }


    }
}