using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;


public partial class SetupPayment : System.Windows.Forms.UserControl
{

    private CurrencyManager PromotionCurrencyMan;
    private DataView dvPromo;

    // Dim promoDataHelper As New DataSet_Builder.SQLHelper

    private PromoBSGS currentBSGS;
    private PromoCombo currentCombo;
    private PromoCoupon currentCoupon;
    private string typeOfPromo;
    private bool justForAdjusting;


    #region  Windows Form Designer generated code 

    public SetupPayment() : base()
    {

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
    private Global.System.Windows.Forms.TabPage _TabCreditCards;

    internal virtual Global.System.Windows.Forms.TabPage TabCreditCards
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _TabCreditCards;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TabCreditCards = value;
        }
    }
    private Global.System.Windows.Forms.TabPage _TabPromos;

    internal virtual Global.System.Windows.Forms.TabPage TabPromos
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _TabPromos;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TabPromos = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnPromoAdd;

    internal virtual Global.System.Windows.Forms.Button btnPromoAdd
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnPromoAdd;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnPromoAdd != null)
            {
                _btnPromoAdd.Click -= btnPromoAdd_Click;
            }

            _btnPromoAdd = value;
            if (_btnPromoAdd != null)
            {
                _btnPromoAdd.Click += btnPromoAdd_Click;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtPromoName;

    internal virtual Global.System.Windows.Forms.TextBox txtPromoName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtPromoName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtPromoName = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblPromoStart;

    internal virtual Global.System.Windows.Forms.Label lblPromoStart
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblPromoStart;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblPromoStart = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblPromoEnd;

    internal virtual Global.System.Windows.Forms.Label lblPromoEnd
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblPromoEnd;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblPromoEnd = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblPromoMaxDollar;

    internal virtual Global.System.Windows.Forms.Label lblPromoMaxDollar
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblPromoMaxDollar;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblPromoMaxDollar = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblPromoMax;

    internal virtual Global.System.Windows.Forms.Label lblPromoMax
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblPromoMax;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblPromoMax = value;
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
    private Global.System.Windows.Forms.GroupBox _grpPromoTax;

    internal virtual Global.System.Windows.Forms.GroupBox grpPromoTax
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _grpPromoTax;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _grpPromoTax = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _cbxPromoTaxPromo;

    internal virtual Global.System.Windows.Forms.CheckBox cbxPromoTaxPromo
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxPromoTaxPromo;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxPromoTaxPromo = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _cbxPromoTaxFood;

    internal virtual Global.System.Windows.Forms.CheckBox cbxPromoTaxFood
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxPromoTaxFood;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxPromoTaxFood = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblPromoFoodEst;

    internal virtual Global.System.Windows.Forms.Label lblPromoFoodEst
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblPromoFoodEst;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblPromoFoodEst = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _cbxPromoGuestPay;

    internal virtual Global.System.Windows.Forms.CheckBox cbxPromoGuestPay
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxPromoGuestPay;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxPromoGuestPay = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _TextBox6;

    internal virtual Global.System.Windows.Forms.TextBox TextBox6
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _TextBox6;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TextBox6 = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblPromoSelect;

    internal virtual Global.System.Windows.Forms.Label lblPromoSelect
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblPromoSelect;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblPromoSelect = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblPromoName;

    internal virtual Global.System.Windows.Forms.Label lblPromoName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblPromoName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblPromoName = value;
        }
    }
    private Global.System.Windows.Forms.GroupBox _grpPromoType;

    internal virtual Global.System.Windows.Forms.GroupBox grpPromoType
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _grpPromoType;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _grpPromoType = value;
        }
    }
    private Global.System.Windows.Forms.RadioButton _RadioButton4;

    internal virtual Global.System.Windows.Forms.RadioButton RadioButton4
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _RadioButton4;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _RadioButton4 = value;
        }
    }
    private Global.System.Windows.Forms.RadioButton _RadioButton5;

    internal virtual Global.System.Windows.Forms.RadioButton RadioButton5
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _RadioButton5;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _RadioButton5 = value;
        }
    }
    private Global.System.Windows.Forms.RadioButton _RadioButton6;

    internal virtual Global.System.Windows.Forms.RadioButton RadioButton6
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _RadioButton6;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _RadioButton6 = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlPromoDetail;

    internal virtual Global.System.Windows.Forms.Panel pnlPromoDetail
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlPromoDetail;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlPromoDetail = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnPromoUpdate;

    internal virtual Global.System.Windows.Forms.Button btnPromoUpdate
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnPromoUpdate;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnPromoUpdate != null)
            {
                _btnPromoUpdate.Click -= btnPromoUpdate_Click;
            }

            _btnPromoUpdate = value;
            if (_btnPromoUpdate != null)
            {
                _btnPromoUpdate.Click += btnPromoUpdate_Click;
            }
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxPromoSelect;

    internal virtual Global.System.Windows.Forms.ComboBox cbxPromoSelect
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxPromoSelect;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxPromoSelect != null)
            {
                _cbxPromoSelect.SelectedIndexChanged -= cbxPromoSelect_SelectedIndexChanged;
            }

            _cbxPromoSelect = value;
            if (_cbxPromoSelect != null)
            {
                _cbxPromoSelect.SelectedIndexChanged += cbxPromoSelect_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkPromoActive;

    internal virtual Global.System.Windows.Forms.CheckBox chkPromoActive
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkPromoActive;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkPromoActive = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxPromoManLevel;

    internal virtual Global.System.Windows.Forms.ComboBox cbxPromoManLevel
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxPromoManLevel;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxPromoManLevel = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtPromoMaxCheck;

    internal virtual Global.System.Windows.Forms.TextBox txtPromoMaxCheck
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtPromoMaxCheck;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtPromoMaxCheck = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtPromoMaxDollar;

    internal virtual Global.System.Windows.Forms.TextBox txtPromoMaxDollar
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtPromoMaxDollar;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtPromoMaxDollar = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtPromoEnd;

    internal virtual Global.System.Windows.Forms.TextBox txtPromoEnd
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtPromoEnd;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtPromoEnd != null)
            {
                _txtPromoEnd.Validating -= txtPromoEnd_Validating;
            }

            _txtPromoEnd = value;
            if (_txtPromoEnd != null)
            {
                _txtPromoEnd.Validating += txtPromoEnd_Validating;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtPromoStart;

    internal virtual Global.System.Windows.Forms.TextBox txtPromoStart
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtPromoStart;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtPromoStart != null)
            {
                _txtPromoStart.Validating -= txtPromoStart_Validating;
            }

            _txtPromoStart = value;
            if (_txtPromoStart != null)
            {
                _txtPromoStart.Validating += txtPromoStart_Validating;
            }
        }
    }
    private Global.System.Windows.Forms.RadioButton _rdbPromoCombo;

    internal virtual Global.System.Windows.Forms.RadioButton rdbPromoCombo
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _rdbPromoCombo;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _rdbPromoCombo = value;
        }
    }
    private Global.System.Windows.Forms.RadioButton _rdbPromoCoupon;

    internal virtual Global.System.Windows.Forms.RadioButton rdbPromoCoupon
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _rdbPromoCoupon;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _rdbPromoCoupon = value;
        }
    }
    private Global.System.Windows.Forms.RadioButton _rdbPromoBSGS;

    internal virtual Global.System.Windows.Forms.RadioButton rdbPromoBSGS
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _rdbPromoBSGS;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _rdbPromoBSGS = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtPromoMaxTable;

    internal virtual Global.System.Windows.Forms.TextBox txtPromoMaxTable
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtPromoMaxTable;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtPromoMaxTable = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkPromoTip;

    internal virtual Global.System.Windows.Forms.CheckBox chkPromoTip
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkPromoTip;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkPromoTip = value;
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
    private Global.System.Windows.Forms.Button _btnAcceptNewPromo;

    internal virtual Global.System.Windows.Forms.Button btnAcceptNewPromo
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnAcceptNewPromo;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnAcceptNewPromo != null)
            {
                _btnAcceptNewPromo.Click -= btnAcceptNewPromo_Click;
            }

            _btnAcceptNewPromo = value;
            if (_btnAcceptNewPromo != null)
            {
                _btnAcceptNewPromo.Click += btnAcceptNewPromo_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnCancelNewPromo;

    internal virtual Global.System.Windows.Forms.Button btnCancelNewPromo
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnCancelNewPromo;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnCancelNewPromo != null)
            {
                _btnCancelNewPromo.Click -= btnCancelNewPromo_Click;
            }

            _btnCancelNewPromo = value;
            if (_btnCancelNewPromo != null)
            {
                _btnCancelNewPromo.Click += btnCancelNewPromo_Click;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtPromoType;

    internal virtual Global.System.Windows.Forms.TextBox txtPromoType
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtPromoType;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtPromoType = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlNewPromo;

    internal virtual Global.System.Windows.Forms.Panel pnlNewPromo
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlNewPromo;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlNewPromo = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtNewEnd;

    internal virtual Global.System.Windows.Forms.TextBox txtNewEnd
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtNewEnd;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtNewEnd != null)
            {
                _txtNewEnd.Validating -= txtNewEnd_Validating;
            }

            _txtNewEnd = value;
            if (_txtNewEnd != null)
            {
                _txtNewEnd.Validating += txtNewEnd_Validating;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtNewStart;

    internal virtual Global.System.Windows.Forms.TextBox txtNewStart
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtNewStart;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtNewStart != null)
            {
                _txtNewStart.Validating -= txtNewStart_Validating;
            }

            _txtNewStart = value;
            if (_txtNewStart != null)
            {
                _txtNewStart.Validating += txtNewStart_Validating;
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
    private Global.System.Windows.Forms.Panel _pnlPromotionMain;

    internal virtual Global.System.Windows.Forms.Panel pnlPromotionMain
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlPromotionMain;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlPromotionMain = value;
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
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        _TabControl1 = new System.Windows.Forms.TabControl();
        _TabCreditCards = new System.Windows.Forms.TabPage();
        _TabPromos = new System.Windows.Forms.TabPage();
        _pnlNewPromo = new System.Windows.Forms.Panel();
        _btnCancelNewPromo = new System.Windows.Forms.Button();
        _btnCancelNewPromo.Click += btnCancelNewPromo_Click;
        _btnAcceptNewPromo = new System.Windows.Forms.Button();
        _btnAcceptNewPromo.Click += btnAcceptNewPromo_Click;
        _Label5 = new System.Windows.Forms.Label();
        _txtNewEnd = new System.Windows.Forms.TextBox();
        _txtNewEnd.Validating += txtNewEnd_Validating;
        _Label3 = new System.Windows.Forms.Label();
        _Label4 = new System.Windows.Forms.Label();
        _txtNewStart = new System.Windows.Forms.TextBox();
        _txtNewStart.Validating += txtNewStart_Validating;
        _grpPromoType = new System.Windows.Forms.GroupBox();
        _RadioButton6 = new System.Windows.Forms.RadioButton();
        _RadioButton5 = new System.Windows.Forms.RadioButton();
        _RadioButton4 = new System.Windows.Forms.RadioButton();
        _rdbPromoCombo = new System.Windows.Forms.RadioButton();
        _rdbPromoCoupon = new System.Windows.Forms.RadioButton();
        _rdbPromoBSGS = new System.Windows.Forms.RadioButton();
        _pnlPromoDetail = new System.Windows.Forms.Panel();
        _pnlPromotionMain = new System.Windows.Forms.Panel();
        _btnPromoAdd = new System.Windows.Forms.Button();
        _btnPromoAdd.Click += btnPromoAdd_Click;
        _btnPromoUpdate = new System.Windows.Forms.Button();
        _btnPromoUpdate.Click += btnPromoUpdate_Click;
        _lblPromoName = new System.Windows.Forms.Label();
        _txtPromoName = new System.Windows.Forms.TextBox();
        _lblPromoSelect = new System.Windows.Forms.Label();
        _cbxPromoSelect = new System.Windows.Forms.ComboBox();
        _cbxPromoSelect.SelectedIndexChanged += cbxPromoSelect_SelectedIndexChanged;
        _lblPromoStart = new System.Windows.Forms.Label();
        _txtPromoStart = new System.Windows.Forms.TextBox();
        _txtPromoStart.Validating += txtPromoStart_Validating;
        _txtPromoEnd = new System.Windows.Forms.TextBox();
        _txtPromoEnd.Validating += txtPromoEnd_Validating;
        _lblPromoEnd = new System.Windows.Forms.Label();
        _chkPromoActive = new System.Windows.Forms.CheckBox();
        _txtPromoType = new System.Windows.Forms.TextBox();
        _txtPromoMaxCheck = new System.Windows.Forms.TextBox();
        _txtPromoMaxDollar = new System.Windows.Forms.TextBox();
        _lblPromoMax = new System.Windows.Forms.Label();
        _lblPromoMaxDollar = new System.Windows.Forms.Label();
        _Label1 = new System.Windows.Forms.Label();
        _chkPromoTip = new System.Windows.Forms.CheckBox();
        _cbxPromoManLevel = new System.Windows.Forms.ComboBox();
        _Label2 = new System.Windows.Forms.Label();
        _txtPromoMaxTable = new System.Windows.Forms.TextBox();
        _grpPromoTax = new System.Windows.Forms.GroupBox();
        _TextBox6 = new System.Windows.Forms.TextBox();
        _cbxPromoGuestPay = new System.Windows.Forms.CheckBox();
        _lblPromoFoodEst = new System.Windows.Forms.Label();
        _cbxPromoTaxFood = new System.Windows.Forms.CheckBox();
        _cbxPromoTaxPromo = new System.Windows.Forms.CheckBox();
        _ErrorProvider1 = new System.Windows.Forms.ErrorProvider();
        _Label6 = new System.Windows.Forms.Label();
        _TabControl1.SuspendLayout();
        _TabPromos.SuspendLayout();
        _pnlNewPromo.SuspendLayout();
        _grpPromoType.SuspendLayout();
        _pnlPromotionMain.SuspendLayout();
        _grpPromoTax.SuspendLayout();
        this.SuspendLayout();
        // 
        // TabControl1
        // 
        _TabControl1.Controls.Add(_TabCreditCards);
        _TabControl1.Controls.Add(_TabPromos);
        _TabControl1.Location = new System.Drawing.Point(24, 140);
        _TabControl1.Name = "_TabControl1";
        _TabControl1.SelectedIndex = 0;
        _TabControl1.Size = new System.Drawing.Size(744, 544);
        _TabControl1.TabIndex = 0;
        // 
        // TabCreditCards
        // 
        _TabCreditCards.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _TabCreditCards.Location = new System.Drawing.Point(4, 22);
        _TabCreditCards.Name = "_TabCreditCards";
        _TabCreditCards.Size = new System.Drawing.Size(736, 518);
        _TabCreditCards.TabIndex = 0;
        _TabCreditCards.Text = "Credit Cards";
        // 
        // TabPromos
        // 
        _TabPromos.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _TabPromos.Controls.Add(_pnlNewPromo);
        _TabPromos.Controls.Add(_pnlPromoDetail);
        _TabPromos.Controls.Add(_pnlPromotionMain);
        _TabPromos.Controls.Add(_grpPromoTax);
        _TabPromos.Location = new System.Drawing.Point(4, 22);
        _TabPromos.Name = "_TabPromos";
        _TabPromos.Size = new System.Drawing.Size(736, 518);
        _TabPromos.TabIndex = 1;
        _TabPromos.Text = "Promotions";
        // 
        // pnlNewPromo
        // 
        _pnlNewPromo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        _pnlNewPromo.Controls.Add(_btnCancelNewPromo);
        _pnlNewPromo.Controls.Add(_btnAcceptNewPromo);
        _pnlNewPromo.Controls.Add(_Label5);
        _pnlNewPromo.Controls.Add(_txtNewEnd);
        _pnlNewPromo.Controls.Add(_Label3);
        _pnlNewPromo.Controls.Add(_Label4);
        _pnlNewPromo.Controls.Add(_txtNewStart);
        _pnlNewPromo.Controls.Add(_grpPromoType);
        _pnlNewPromo.Location = new System.Drawing.Point(256, 152);
        _pnlNewPromo.Name = "_pnlNewPromo";
        _pnlNewPromo.Size = new System.Drawing.Size(288, 352);
        _pnlNewPromo.TabIndex = 27;
        _pnlNewPromo.Visible = false;
        // 
        // btnCancelNewPromo
        // 
        _btnCancelNewPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _btnCancelNewPromo.ForeColor = System.Drawing.Color.White;
        _btnCancelNewPromo.Location = new System.Drawing.Point(24, 312);
        _btnCancelNewPromo.Name = "_btnCancelNewPromo";
        _btnCancelNewPromo.Size = new System.Drawing.Size(104, 32);
        _btnCancelNewPromo.TabIndex = 31;
        _btnCancelNewPromo.Text = "Cancel";
        // 
        // btnAcceptNewPromo
        // 
        _btnAcceptNewPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _btnAcceptNewPromo.ForeColor = System.Drawing.Color.White;
        _btnAcceptNewPromo.Location = new System.Drawing.Point(160, 312);
        _btnAcceptNewPromo.Name = "_btnAcceptNewPromo";
        _btnAcceptNewPromo.Size = new System.Drawing.Size(104, 32);
        _btnAcceptNewPromo.TabIndex = 30;
        _btnAcceptNewPromo.Text = "Accept";
        // 
        // Label5
        // 
        _Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label5.ForeColor = System.Drawing.Color.White;
        _Label5.Location = new System.Drawing.Point(32, 16);
        _Label5.Name = "_Label5";
        _Label5.Size = new System.Drawing.Size(224, 32);
        _Label5.TabIndex = 29;
        _Label5.Text = "Select Promotion Type";
        // 
        // txtNewEnd
        // 
        _txtNewEnd.Location = new System.Drawing.Point(112, 272);
        _txtNewEnd.Name = "_txtNewEnd";
        _txtNewEnd.Size = new System.Drawing.Size(112, 20);
        _txtNewEnd.TabIndex = 28;
        _txtNewEnd.Text = "";
        // 
        // Label3
        // 
        _Label3.Location = new System.Drawing.Point(32, 272);
        _Label3.Name = "_Label3";
        _Label3.Size = new System.Drawing.Size(72, 24);
        _Label3.TabIndex = 27;
        _Label3.Text = "End Date:";
        _Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label4
        // 
        _Label4.Location = new System.Drawing.Point(32, 240);
        _Label4.Name = "_Label4";
        _Label4.Size = new System.Drawing.Size(72, 24);
        _Label4.TabIndex = 26;
        _Label4.Text = "Start Date:";
        _Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtNewStart
        // 
        _txtNewStart.Location = new System.Drawing.Point(112, 240);
        _txtNewStart.Name = "_txtNewStart";
        _txtNewStart.Size = new System.Drawing.Size(112, 20);
        _txtNewStart.TabIndex = 25;
        _txtNewStart.Text = "";
        // 
        // grpPromoType
        // 
        _grpPromoType.Controls.Add(_RadioButton6);
        _grpPromoType.Controls.Add(_RadioButton5);
        _grpPromoType.Controls.Add(_RadioButton4);
        _grpPromoType.Controls.Add(_rdbPromoCombo);
        _grpPromoType.Controls.Add(_rdbPromoCoupon);
        _grpPromoType.Controls.Add(_rdbPromoBSGS);
        _grpPromoType.Location = new System.Drawing.Point(32, 56);
        _grpPromoType.Name = "_grpPromoType";
        _grpPromoType.Size = new System.Drawing.Size(200, 168);
        _grpPromoType.TabIndex = 24;
        _grpPromoType.TabStop = false;
        _grpPromoType.Text = "Promo Type";
        // 
        // RadioButton6
        // 
        _RadioButton6.Enabled = false;
        _RadioButton6.Location = new System.Drawing.Point(32, 144);
        _RadioButton6.Name = "_RadioButton6";
        _RadioButton6.Size = new System.Drawing.Size(128, 16);
        _RadioButton6.TabIndex = 5;
        _RadioButton6.Text = "Open";
        // 
        // RadioButton5
        // 
        _RadioButton5.Enabled = false;
        _RadioButton5.Location = new System.Drawing.Point(32, 120);
        _RadioButton5.Name = "_RadioButton5";
        _RadioButton5.Size = new System.Drawing.Size(128, 16);
        _RadioButton5.TabIndex = 4;
        _RadioButton5.Text = "Open";
        // 
        // RadioButton4
        // 
        _RadioButton4.Enabled = false;
        _RadioButton4.Location = new System.Drawing.Point(32, 96);
        _RadioButton4.Name = "_RadioButton4";
        _RadioButton4.Size = new System.Drawing.Size(128, 16);
        _RadioButton4.TabIndex = 3;
        _RadioButton4.Text = "Open";
        // 
        // rdbPromoCombo
        // 
        _rdbPromoCombo.Enabled = false;
        _rdbPromoCombo.Location = new System.Drawing.Point(32, 72);
        _rdbPromoCombo.Name = "_rdbPromoCombo";
        _rdbPromoCombo.Size = new System.Drawing.Size(128, 16);
        _rdbPromoCombo.TabIndex = 2;
        _rdbPromoCombo.Text = "Combo";
        // 
        // rdbPromoCoupon
        // 
        _rdbPromoCoupon.Location = new System.Drawing.Point(32, 48);
        _rdbPromoCoupon.Name = "_rdbPromoCoupon";
        _rdbPromoCoupon.Size = new System.Drawing.Size(128, 16);
        _rdbPromoCoupon.TabIndex = 1;
        _rdbPromoCoupon.Text = "Coupon";
        // 
        // rdbPromoBSGS
        // 
        _rdbPromoBSGS.Location = new System.Drawing.Point(32, 24);
        _rdbPromoBSGS.Name = "_rdbPromoBSGS";
        _rdbPromoBSGS.Size = new System.Drawing.Size(136, 16);
        _rdbPromoBSGS.TabIndex = 0;
        _rdbPromoBSGS.Text = "Buy Some Get Some";
        // 
        // pnlPromoDetail
        // 
        _pnlPromoDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        _pnlPromoDetail.Location = new System.Drawing.Point(280, 16);
        _pnlPromoDetail.Name = "_pnlPromoDetail";
        _pnlPromoDetail.Size = new System.Drawing.Size(432, 256);
        _pnlPromoDetail.TabIndex = 25;
        // 
        // pnlPromotionMain
        // 
        _pnlPromotionMain.Controls.Add(_Label6);
        _pnlPromotionMain.Controls.Add(_btnPromoAdd);
        _pnlPromotionMain.Controls.Add(_btnPromoUpdate);
        _pnlPromotionMain.Controls.Add(_lblPromoName);
        _pnlPromotionMain.Controls.Add(_txtPromoName);
        _pnlPromotionMain.Controls.Add(_lblPromoSelect);
        _pnlPromotionMain.Controls.Add(_cbxPromoSelect);
        _pnlPromotionMain.Controls.Add(_lblPromoStart);
        _pnlPromotionMain.Controls.Add(_txtPromoStart);
        _pnlPromotionMain.Controls.Add(_txtPromoEnd);
        _pnlPromotionMain.Controls.Add(_lblPromoEnd);
        _pnlPromotionMain.Controls.Add(_chkPromoActive);
        _pnlPromotionMain.Controls.Add(_txtPromoType);
        _pnlPromotionMain.Controls.Add(_txtPromoMaxCheck);
        _pnlPromotionMain.Controls.Add(_txtPromoMaxDollar);
        _pnlPromotionMain.Controls.Add(_lblPromoMax);
        _pnlPromotionMain.Controls.Add(_lblPromoMaxDollar);
        _pnlPromotionMain.Controls.Add(_Label1);
        _pnlPromotionMain.Controls.Add(_chkPromoTip);
        _pnlPromotionMain.Controls.Add(_cbxPromoManLevel);
        _pnlPromotionMain.Controls.Add(_Label2);
        _pnlPromotionMain.Controls.Add(_txtPromoMaxTable);
        _pnlPromotionMain.Location = new System.Drawing.Point(8, 24);
        _pnlPromotionMain.Name = "_pnlPromotionMain";
        _pnlPromotionMain.Size = new System.Drawing.Size(248, 480);
        _pnlPromotionMain.TabIndex = 30;
        // 
        // btnPromoAdd
        // 
        _btnPromoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _btnPromoAdd.Location = new System.Drawing.Point(16, 8);
        _btnPromoAdd.Name = "_btnPromoAdd";
        _btnPromoAdd.Size = new System.Drawing.Size(72, 40);
        _btnPromoAdd.TabIndex = 1;
        _btnPromoAdd.Text = "Add New";
        // 
        // btnPromoUpdate
        // 
        _btnPromoUpdate.BackColor = System.Drawing.Color.Red;
        _btnPromoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _btnPromoUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        _btnPromoUpdate.Location = new System.Drawing.Point(104, 8);
        _btnPromoUpdate.Name = "_btnPromoUpdate";
        _btnPromoUpdate.Size = new System.Drawing.Size(120, 40);
        _btnPromoUpdate.TabIndex = 26;
        _btnPromoUpdate.Text = "Update";
        // 
        // lblPromoName
        // 
        _lblPromoName.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _lblPromoName.Location = new System.Drawing.Point(16, 144);
        _lblPromoName.Name = "_lblPromoName";
        _lblPromoName.Size = new System.Drawing.Size(64, 16);
        _lblPromoName.TabIndex = 3;
        _lblPromoName.Text = "Name:";
        _lblPromoName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtPromoName
        // 
        _txtPromoName.Location = new System.Drawing.Point(88, 136);
        _txtPromoName.Name = "_txtPromoName";
        _txtPromoName.Size = new System.Drawing.Size(136, 20);
        _txtPromoName.TabIndex = 2;
        _txtPromoName.Text = "";
        // 
        // lblPromoSelect
        // 
        _lblPromoSelect.Location = new System.Drawing.Point(8, 72);
        _lblPromoSelect.Name = "_lblPromoSelect";
        _lblPromoSelect.Size = new System.Drawing.Size(80, 16);
        _lblPromoSelect.TabIndex = 23;
        _lblPromoSelect.Text = "Select Promo:";
        _lblPromoSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // cbxPromoSelect
        // 
        _cbxPromoSelect.Location = new System.Drawing.Point(88, 72);
        _cbxPromoSelect.Name = "_cbxPromoSelect";
        _cbxPromoSelect.Size = new System.Drawing.Size(136, 21);
        _cbxPromoSelect.TabIndex = 22;
        // 
        // lblPromoStart
        // 
        _lblPromoStart.Location = new System.Drawing.Point(16, 168);
        _lblPromoStart.Name = "_lblPromoStart";
        _lblPromoStart.Size = new System.Drawing.Size(72, 24);
        _lblPromoStart.TabIndex = 8;
        _lblPromoStart.Text = "Start Date:";
        _lblPromoStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtPromoStart
        // 
        _txtPromoStart.Location = new System.Drawing.Point(88, 168);
        _txtPromoStart.Name = "_txtPromoStart";
        _txtPromoStart.Size = new System.Drawing.Size(128, 20);
        _txtPromoStart.TabIndex = 6;
        _txtPromoStart.Text = "";
        // 
        // txtPromoEnd
        // 
        _txtPromoEnd.Location = new System.Drawing.Point(88, 200);
        _txtPromoEnd.Name = "_txtPromoEnd";
        _txtPromoEnd.Size = new System.Drawing.Size(128, 20);
        _txtPromoEnd.TabIndex = 10;
        _txtPromoEnd.Text = "";
        // 
        // lblPromoEnd
        // 
        _lblPromoEnd.Location = new System.Drawing.Point(16, 200);
        _lblPromoEnd.Name = "_lblPromoEnd";
        _lblPromoEnd.Size = new System.Drawing.Size(72, 24);
        _lblPromoEnd.TabIndex = 9;
        _lblPromoEnd.Text = "End Date:";
        _lblPromoEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // chkPromoActive
        // 
        _chkPromoActive.Location = new System.Drawing.Point(48, 232);
        _chkPromoActive.Name = "_chkPromoActive";
        _chkPromoActive.Size = new System.Drawing.Size(144, 16);
        _chkPromoActive.TabIndex = 20;
        _chkPromoActive.Text = "Active";
        // 
        // txtPromoType
        // 
        _txtPromoType.Location = new System.Drawing.Point(8, 104);
        _txtPromoType.Name = "_txtPromoType";
        _txtPromoType.Size = new System.Drawing.Size(216, 20);
        _txtPromoType.TabIndex = 28;
        _txtPromoType.Text = "";
        // 
        // txtPromoMaxCheck
        // 
        _txtPromoMaxCheck.Location = new System.Drawing.Point(112, 336);
        _txtPromoMaxCheck.Name = "_txtPromoMaxCheck";
        _txtPromoMaxCheck.Size = new System.Drawing.Size(104, 20);
        _txtPromoMaxCheck.TabIndex = 15;
        _txtPromoMaxCheck.Text = "";
        // 
        // txtPromoMaxDollar
        // 
        _txtPromoMaxDollar.Location = new System.Drawing.Point(112, 304);
        _txtPromoMaxDollar.Name = "_txtPromoMaxDollar";
        _txtPromoMaxDollar.Size = new System.Drawing.Size(104, 20);
        _txtPromoMaxDollar.TabIndex = 14;
        _txtPromoMaxDollar.Text = "";
        // 
        // lblPromoMax
        // 
        _lblPromoMax.Location = new System.Drawing.Point(8, 344);
        _lblPromoMax.Name = "_lblPromoMax";
        _lblPromoMax.Size = new System.Drawing.Size(96, 16);
        _lblPromoMax.TabIndex = 12;
        _lblPromoMax.Text = "Check Maximum:";
        _lblPromoMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblPromoMaxDollar
        // 
        _lblPromoMaxDollar.Location = new System.Drawing.Point(24, 304);
        _lblPromoMaxDollar.Name = "_lblPromoMaxDollar";
        _lblPromoMaxDollar.Size = new System.Drawing.Size(80, 24);
        _lblPromoMaxDollar.TabIndex = 11;
        _lblPromoMaxDollar.Text = "Max $ Amount:";
        _lblPromoMaxDollar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label1
        // 
        _Label1.Location = new System.Drawing.Point(8, 376);
        _Label1.Name = "_Label1";
        _Label1.Size = new System.Drawing.Size(96, 16);
        _Label1.TabIndex = 13;
        _Label1.Text = "Table Maximum:";
        _Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // chkPromoTip
        // 
        _chkPromoTip.Location = new System.Drawing.Point(56, 440);
        _chkPromoTip.Name = "_chkPromoTip";
        _chkPromoTip.Size = new System.Drawing.Size(128, 24);
        _chkPromoTip.TabIndex = 19;
        _chkPromoTip.Text = "Tip Promo Amount";
        // 
        // cbxPromoManLevel
        // 
        _cbxPromoManLevel.Location = new System.Drawing.Point(112, 400);
        _cbxPromoManLevel.Name = "_cbxPromoManLevel";
        _cbxPromoManLevel.Size = new System.Drawing.Size(104, 21);
        _cbxPromoManLevel.TabIndex = 18;
        // 
        // Label2
        // 
        _Label2.Location = new System.Drawing.Point(16, 408);
        _Label2.Name = "_Label2";
        _Label2.Size = new System.Drawing.Size(88, 16);
        _Label2.TabIndex = 17;
        _Label2.Text = "Manager Level:";
        _Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtPromoMaxTable
        // 
        _txtPromoMaxTable.Location = new System.Drawing.Point(112, 368);
        _txtPromoMaxTable.Name = "_txtPromoMaxTable";
        _txtPromoMaxTable.Size = new System.Drawing.Size(104, 20);
        _txtPromoMaxTable.TabIndex = 16;
        _txtPromoMaxTable.Text = "";
        // 
        // grpPromoTax
        // 
        _grpPromoTax.Controls.Add(_TextBox6);
        _grpPromoTax.Controls.Add(_cbxPromoGuestPay);
        _grpPromoTax.Controls.Add(_lblPromoFoodEst);
        _grpPromoTax.Controls.Add(_cbxPromoTaxFood);
        _grpPromoTax.Controls.Add(_cbxPromoTaxPromo);
        _grpPromoTax.Location = new System.Drawing.Point(280, 328);
        _grpPromoTax.Name = "_grpPromoTax";
        _grpPromoTax.Size = new System.Drawing.Size(192, 176);
        _grpPromoTax.TabIndex = 21;
        _grpPromoTax.TabStop = false;
        _grpPromoTax.Text = "Tax";
        // 
        // TextBox6
        // 
        _TextBox6.Location = new System.Drawing.Point(96, 112);
        _TextBox6.Name = "_TextBox6";
        _TextBox6.Size = new System.Drawing.Size(80, 20);
        _TextBox6.TabIndex = 4;
        _TextBox6.Text = "";
        // 
        // cbxPromoGuestPay
        // 
        _cbxPromoGuestPay.Location = new System.Drawing.Point(16, 144);
        _cbxPromoGuestPay.Name = "_cbxPromoGuestPay";
        _cbxPromoGuestPay.Size = new System.Drawing.Size(160, 24);
        _cbxPromoGuestPay.TabIndex = 3;
        _cbxPromoGuestPay.Text = "Guest Pay Tax";
        // 
        // lblPromoFoodEst
        // 
        _lblPromoFoodEst.Location = new System.Drawing.Point(16, 104);
        _lblPromoFoodEst.Name = "_lblPromoFoodEst";
        _lblPromoFoodEst.Size = new System.Drawing.Size(72, 32);
        _lblPromoFoodEst.TabIndex = 2;
        _lblPromoFoodEst.Text = "Food Cost Est. Percent:";
        _lblPromoFoodEst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // cbxPromoTaxFood
        // 
        _cbxPromoTaxFood.Location = new System.Drawing.Point(16, 72);
        _cbxPromoTaxFood.Name = "_cbxPromoTaxFood";
        _cbxPromoTaxFood.Size = new System.Drawing.Size(160, 24);
        _cbxPromoTaxFood.TabIndex = 1;
        _cbxPromoTaxFood.Text = "Tax Food Amount";
        // 
        // cbxPromoTaxPromo
        // 
        _cbxPromoTaxPromo.Location = new System.Drawing.Point(16, 32);
        _cbxPromoTaxPromo.Name = "_cbxPromoTaxPromo";
        _cbxPromoTaxPromo.Size = new System.Drawing.Size(160, 24);
        _cbxPromoTaxPromo.TabIndex = 0;
        _cbxPromoTaxPromo.Text = "Tax Promo Amount";
        // 
        // ErrorProvider1
        // 
        _ErrorProvider1.ContainerControl = this;
        // 
        // Label6
        // 
        _Label6.Location = new System.Drawing.Point(24, 256);
        _Label6.Name = "_Label6";
        _Label6.Size = new System.Drawing.Size(192, 32);
        _Label6.TabIndex = 29;
        _Label6.Text = "Promotion is Active if either active is checked OR between dates";
        // 
        // SetupPayment
        // 
        this.BackColor = System.Drawing.Color.FromArgb(0, 78, 152);
        this.Controls.Add(_TabControl1);
        this.Name = "SetupPayment";
        this.Size = new System.Drawing.Size(792, 696);
        _TabControl1.ResumeLayout(false);
        _TabPromos.ResumeLayout(false);
        _pnlNewPromo.ResumeLayout(false);
        _grpPromoType.ResumeLayout(false);
        _pnlPromotionMain.ResumeLayout(false);
        _grpPromoTax.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private void InitializeOther()
    {

        BindData();
        PopulatePromotionTables();

        if (dsSetup.Tables("Promotion").Rows.Count > 0)
        {
            var argoRow = dsSetup.Tables("Promotion").Rows(0);
            PopulatePromoType(ref argoRow);
        }

    }

    private void BindData()
    {

        PromotionCurrencyMan = BindingContext(dsSetup.Tables("Promotion"));

        foreach (DataRow oRow in dsSetup.Tables("Promotion").Rows)
            cbxPromoSelect.Items.Add(oRow("PromoName"));
        cbxPromoSelect.DataSource = dsSetup.Tables("Promotion");
        cbxPromoSelect.DisplayMember = "PromoName";
        // cbxPromoSelect.DataBindings.Add("Text", dsSetup.Tables("Promotion"), "PromoName")


        txtPromoName.DataBindings.Add("Text", dsSetup.Tables("Promotion"), "PromoName");
        // rdbPromoBSGS.DataBindings.Add("Checked", dsSetup.Tables("Promotion"), "BSGS")
        // rdbPromoCoupon.DataBindings.Add("Checked", dsSetup.Tables("Promotion"), "Coupon")
        // rdbPromoCombo.DataBindings.Add("Checked", dsSetup.Tables("Promotion"), "Combo")


        txtPromoStart.DataBindings.Add("Text", dsSetup.Tables("Promotion"), "StartDate");
        txtPromoEnd.DataBindings.Add("Text", dsSetup.Tables("Promotion"), "EndDate");
        chkPromoActive.DataBindings.Add("Checked", dsSetup.Tables("Promotion"), "Active");
        txtPromoMaxDollar.DataBindings.Add("Text", dsSetup.Tables("Promotion"), "MaxAmount");
        txtPromoMaxCheck.DataBindings.Add("Text", dsSetup.Tables("Promotion"), "MaxCheck");
        txtPromoMaxTable.DataBindings.Add("Text", dsSetup.Tables("Promotion"), "MaxTable");
        // '      '           cbxPromoManlevel.DataBindings.Add(
        chkPromoTip.DataBindings.Add("Checked", dsSetup.Tables("Promotion"), "TipPromo");



    }

    private void PopulatePromotionTables()
    {

        dsSetup.Tables("PromoBSGSBuy").Clear();
        dsSetup.Tables("PromoBSGSGet").Clear();
        dsSetup.Tables("PromoBSGS").Clear();
        dsSetup.Tables("PromoCombo").Clear();
        dsSetup.Tables("PromoComboDetail").Clear();
        dsSetup.Tables("PromoCoupon").Clear();
        dsSetup.Tables("PromoCouponDiscount").Clear();
        dsSetup.Tables("PromoCouponAtleast").Clear();

        sql.SqlSelectCommandPromoBSGS.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandPromoBSGS.Parameters("@LocationID").Value = selectedLocation;
        sql.SqlSelectCommandBSGSBuy.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandBSGSBuy.Parameters("@LocationID").Value = selectedLocation;
        sql.SqlSelectCommandBSGSGet.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandBSGSGet.Parameters("@LocationID").Value = selectedLocation;

        sql.SqlSelectCommandCombo.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandCombo.Parameters("@LocationID").Value = selectedLocation;
        sql.SqlSelectCommandComboDetail.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandComboDetail.Parameters("@LocationID").Value = selectedLocation;

        sql.SqlSelectCommandCoupon.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandCoupon.Parameters("@LocationID").Value = selectedLocation;
        sql.SqlSelectCommandCouponDiscount.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandCouponDiscount.Parameters("@LocationID").Value = selectedLocation;
        sql.SqlSelectCommandCouponAtleast.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandCouponAtleast.Parameters("@LocationID").Value = selectedLocation;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlPromoBSGSBuy.Fill(dsSetup.Tables("PromoBSGSBuy"));
            sql.SqlPromoBSGSGet.Fill(dsSetup.Tables("PromoBSGSGet"));
            sql.SqlPromoBSGS.Fill(dsSetup.Tables("PromoBSGS"));

            sql.SqlPromoCombo.Fill(dsSetup.Tables("PromoCombo"));
            sql.SqlPromoComboDetail.Fill(dsSetup.Tables("PromoComboDetail"));

            sql.SqlPromoCoupon.Fill(dsSetup.Tables("PromoCoupon"));
            sql.SqlPromoCouponDiscount.Fill(dsSetup.Tables("PromoCouponDiscount"));
            sql.SqlPromoCouponAtleast.Fill(dsSetup.Tables("PromoCouponAtleast"));

            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

    }

    private void rbdPromoBSGS_CheckedChanged222(object sender, EventArgs e) // Handles rdbPromoBSGS.CheckedChanged
    {
        ClearPromoDetailPanel();

        if (rdbPromoBSGS.Checked == true)
        {
            dvPromo = new DataView();

            {
                ref var withBlock = ref dvPromo;
                withBlock.Table = dsSetup.Tables("PromoBSGS");
                withBlock.RowFilter = "PromoID = '" + PromotionCurrencyMan.Current("PromoID") + "'";
            }

            if (dvPromo.Count == 50)
            {
                DataRow oRow;

                oRow = dsSetup.Tables("PromoBSGS").NewRow;

                oRow("CompanyID") = corpID;
                oRow("LocationID") = selectedLocation;
                oRow("PromoID") = PromotionCurrencyMan.Current("PromoID");
                oRow("BuyFD_flag") = "F";
                oRow("GetFD_flag") = "F";
                // oRow("BuyCategoryID") = DBNull.Value
                // oRow("BuyCategoryAmount") = Nothing
                // oRow("BuyDrinkCategoryID") = Nothing
                // oRow("BuyDrinkCategoryAmount") = Nothing
                // '        oRow("GetCategoryID") = Nothing
                // oRow("GetCategoryAmount") = Nothing
                // oRow("GetDrinkCategoryID") = Nothing
                // oRow("GetDrinkCategoryAmount") = Nothing

                dsSetup.Tables("PromoBSGS").Rows.Add(oRow);
                UpdateBSGSData();

            }

            // could add: UpdateDataPromotion
            // this would make anychanges to radio button automatic
            currentBSGS = new PromoBSGS(PromotionCurrencyMan.Current("PromoID"));
            currentBSGS.Location = new Point(0, 0);
            pnlPromoDetail.Controls.Add(currentBSGS);

        }


    }

    private void UpdateBSGSData()
    {
        // used when adding new datarow to PromoBSGS
        dsSetup.Tables("PromoBSGSBuy").Clear();
        dsSetup.Tables("PromoBSGSGet").Clear();

        sql.SqlSelectCommandBSGSBuy.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandBSGSBuy.Parameters("@LocationID").Value = selectedLocation;
        sql.SqlSelectCommandBSGSGet.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandBSGSGet.Parameters("@LocationID").Value = selectedLocation;

        sql.cn.Open();
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
        sql.SqlPromoBSGS.Update(dsSetup.Tables("PromoBSGS"));
        sql.SqlPromoBSGSBuy.Fill(dsSetup.Tables("PromoBSGSBuy"));
        sql.SqlPromoBSGSGet.Fill(dsSetup.Tables("PromoBSGSGet"));
        sql.cn.Close();



    }

    private void rdbPromoCoupon_CheckedChanged222(object sender, EventArgs e) // Handles rdbPromoCoupon.CheckedChanged
    {
        ClearPromoDetailPanel();
        if (rdbPromoCoupon.Checked == true)
        {
            dvPromo = new DataView();

            {
                ref var withBlock = ref dvPromo;
                withBlock.Table = dsSetup.Tables("PromoCoupon");
                withBlock.RowFilter = "PromoID = '" + PromotionCurrencyMan.Current("PromoID") + "'";
            }

            if (dvPromo.Count == 50)
            {
                // Me.PromotionCurrencyMan.Position += 1
                // UpdateDatabasePromotion()
                // Me.PromotionCurrencyMan.Position -= 1

                DataRow oRow;

                oRow = dsSetup.Tables("PromoCoupon").NewRow;

                oRow("CompanyID") = corpID;
                oRow("LocationID") = selectedLocation;
                oRow("PromoID") = PromotionCurrencyMan.Current("PromoID");
                oRow("DiscountFD_flag") = "F";
                oRow("AtleastFD_flag") = "F";
                // oRow("DiscountCategoryID") = 0 'DBNull.Value
                // oRow("DiscountCategoryAmount") = 0 ' DBNull.Value
                // oRow("DiscountDrinkCategoryID") = 0 'DBNull.Value
                // oRow("AtleastCategoryID") = 0 'DBNull.Value
                // '          oRow("AtleastCategoryAmount") = 0 ' DBNull.Value
                // oRow("AtleastDrinkCategoryID") = 0 ' DBNull.Value

                // oRow("CouponDollarFlag") = 0
                // oRow("CouponDollarAmount") = 0
                // '       oRow("CouponPercentFlag") = 0
                // oRow("CouponPercentAmount") = 0


                dsSetup.Tables("PromoCoupon").Rows.Add(oRow);
                UpdateCouponData();

            }


            currentCoupon = new PromoCoupon(PromotionCurrencyMan.Current("PromoID"));
            currentCoupon.Location = new Point(0, 0);
            pnlPromoDetail.Controls.Add(currentCoupon);

        }


    }

    private void UpdateCouponData()
    {
        dsSetup.Tables("PromoCouponDiscount").Clear();
        dsSetup.Tables("PromoCouponAtleast").Clear();

        sql.SqlSelectCommandCouponDiscount.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandCouponDiscount.Parameters("@LocationID").Value = selectedLocation;
        sql.SqlSelectCommandCouponAtleast.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandCouponAtleast.Parameters("@LocationID").Value = selectedLocation;

        sql.cn.Open();
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
        sql.SqlPromoCoupon.Update(dsSetup.Tables("PromoCoupon"));
        sql.SqlPromoCouponDiscount.Fill(dsSetup.Tables("PromoCouponDiscount"));
        sql.SqlPromoCouponAtleast.Fill(dsSetup.Tables("PromoCouponAtleast"));
        sql.cn.Close();

    }

    private void rdbPromoCombo_CheckedChanged222(object sender, EventArgs e) // Handles rdbPromoCombo.CheckedChanged
    {
        ClearPromoDetailPanel();
        if (rdbPromoCombo.Checked == true)
        {
            dvPromo = new DataView();

            {
                ref var withBlock = ref dvPromo;
                withBlock.Table = dsSetup.Tables("PromoCombo");
                withBlock.RowFilter = "PromoID = '" + PromotionCurrencyMan.Current("PromoID") + "'";
            }

            if (dvPromo.Count == 50)
            {
                DataRow oRow;

                oRow = dsSetup.Tables("PromoCombo").NewRow;

                oRow("CompanyID") = corpID;
                oRow("LocationID") = selectedLocation;
                oRow("PromoID") = PromotionCurrencyMan.Current("PromoID");
                oRow("ComboFD_flag") = "F";
                // oRow("BuyCategoryID") = DBNull.Value
                // oRow("BuyCategoryAmount") = Nothing
                // oRow("BuyDrinkCategoryID") = Nothing
                // oRow("BuyDrinkCategoryAmount") = Nothing
                // '        oRow("GetCategoryID") = Nothing
                // oRow("GetCategoryAmount") = Nothing
                // oRow("GetDrinkCategoryID") = Nothing
                // oRow("GetDrinkCategoryAmount") = Nothing

                dsSetup.Tables("PromoCombo").Rows.Add(oRow);

                oRow = dsSetup.Tables("PromoComboDetail").NewRow;
                oRow("CompanyID") = corpID;
                oRow("LocationID") = selectedLocation;
                oRow("PromoID") = PromotionCurrencyMan.Current("PromoID");
                oRow("ComboPrice") = 0;
                dsSetup.Tables("PromoComboDetail").Rows.Add(oRow);

                UpdateCombo();

            }

            currentCombo = new PromoCombo(PromotionCurrencyMan.Current("PromoID"));
            currentCombo.Location = new Point(0, 0);
            pnlPromoDetail.Controls.Add(currentCombo);

        }

    }

    private void ClearPromoDetailPanel()
    {

        pnlPromoDetail.Controls.Clear();

    }


    private void btnPromoAdd_Click(object sender, EventArgs e)
    {

        pnlNewPromo.Visible = true;
        pnlPromoDetail.Enabled = true;
        pnlPromotionMain.Enabled = true;

    }

    private void CreateNewPromo()
    {

        DataRow oRow;

        UpdateDatabasePromotion();
        oRow = dsSetup.Tables("Promotion").NewRow;

        oRow("CompanyID") = corpID;
        oRow("LocationID") = selectedLocation;
        oRow("PromoName") = "  ** Enter New Promo";
        oRow("BSGS") = 0;
        oRow("Combo") = 0;
        oRow("Coupon") = 0;
        if (rdbPromoBSGS.Checked == true)
        {
            oRow("BSGS") = 1;
        }
        else if (rdbPromoCombo.Checked == true)
        {
            oRow("Combo") = 1;
        }
        else if (rdbPromoCoupon.Checked == true)
        {
            oRow("Coupon") = 1;
        }

        if (txtNewStart.Text == "")
        {
            oRow("StartDate") = DBNull.Value;
        }
        else
        {
            oRow("StartDate") = Strings.Format((DateTime)txtNewStart.Text, "M/d/yyyy");
        }
        if (txtNewEnd.Text == "")
        {
            oRow("EndDate") = DBNull.Value;
        }
        else
        {
            oRow("EndDate") = Strings.Format((DateTime)txtNewEnd.Text, "M/d/yyyy");
        }
        oRow("MaxAmount") = DBNull.Value;
        oRow("MaxCheck") = DBNull.Value;
        oRow("MaxTable") = DBNull.Value;
        oRow("TaxPromoAmount") = 0;
        oRow("TaxFoodCost") = 0;
        oRow("EstFoodCost") = DBNull.Value;
        oRow("GuestPayTax") = 0;
        oRow("ManagerLevel") = DBNull.Value;
        oRow("TipPromo") = 0;
        oRow("Active") = 1;

        dsSetup.Tables("Promotion").Rows.Add(oRow);
        oRow("PromoID") = InsertingNewDrink(ref oRow);
        dsSetup.Tables("Promotion").AcceptChanges();

        PromotionCurrencyMan.Position = PromotionCurrencyMan.Count - 1;
        txtPromoName.Focus();

    }

    private object InsertingNewDrink(ref DataRow orow)
    {

        var newPromoID = default(int);

        sql.SqlInsertCommandPromoPromotion.Parameters("@CompanyID").Value = orow("CompanyID");
        sql.SqlInsertCommandPromoPromotion.Parameters("@LocationID").Value = orow("LocationID");
        sql.SqlInsertCommandPromoPromotion.Parameters("@PromoName").Value = orow("PromoName");
        sql.SqlInsertCommandPromoPromotion.Parameters("@BSGS").Value = orow("BSGS");
        sql.SqlInsertCommandPromoPromotion.Parameters("@Combo").Value = orow("Combo");
        sql.SqlInsertCommandPromoPromotion.Parameters("@Coupon").Value = orow("Coupon");
        sql.SqlInsertCommandPromoPromotion.Parameters("@StartDate").Value = orow("StartDate");
        sql.SqlInsertCommandPromoPromotion.Parameters("@EndDate").Value = orow("EndDate");
        sql.SqlInsertCommandPromoPromotion.Parameters("@MaxAmount").Value = orow("MaxAmount");
        sql.SqlInsertCommandPromoPromotion.Parameters("@MaxCheck").Value = orow("MaxCheck");
        sql.SqlInsertCommandMenuDrinks.Parameters("@MaxTable").Value = orow("MaxTable");
        sql.SqlInsertCommandPromoPromotion.Parameters("@TaxPromoAmount").Value = orow("TaxPromoAmount");
        sql.SqlInsertCommandPromoPromotion.Parameters("@TaxFoodCost").Value = orow("TaxFoodCost");
        sql.SqlInsertCommandPromoPromotion.Parameters("@EstFoodCost").Value = orow("EstFoodCost");
        sql.SqlInsertCommandPromoPromotion.Parameters("@GuestPayTax").Value = orow("GuestPayTax");
        sql.SqlInsertCommandPromoPromotion.Parameters("@ManagerLevel").Value = orow("ManagerLevel");
        sql.SqlInsertCommandMenuDrinks.Parameters("@TipPromo").Value = orow("TipPromo");
        sql.SqlInsertCommandPromoPromotion.Parameters("@Active").Value = orow("Active");

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            newPromoID = (int)sql.SqlInsertCommandPromoPromotion.ExecuteScalar();
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        return newPromoID;

    }

    private void btnPromoUpdate_Click(object sender, EventArgs e)
    {

        justForAdjusting = true;

        if (PromotionCurrencyMan.Position < PromotionCurrencyMan.Count - 1)
        {
            PromotionCurrencyMan.Position += 1;
            PromotionCurrencyMan.Position -= 1;
        }
        else
        {
            PromotionCurrencyMan.Position -= 1;
            PromotionCurrencyMan.Position += 1;
        }

        UpdateDatabasePromotion();
        UpdatePromotionDetail();

        PopulatePromotionTables();  // this repopulated
        justForAdjusting = false;

    }


    private void UpdateDatabasePromotion()
    {

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlPromoPromotion.Update(dsSetup, "Promotion");
            sql.cn.Close();
            dsSetup.Tables("Promotion").AcceptChanges();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

    }

    private void UpdatePromotionDetail()
    {

        DataRow oRow;

        // oRow = dsSetup.Tables("Promotion").Rows(cbxPromoSelect.SelectedIndex)

        if (typeOfPromo == "BSGS")
        {
            UpdateBSGS();
        }
        else if (typeOfPromo == "Coupon")
        {
            UpdateCoupon();
        }
        else if (typeOfPromo == "Combo")
        {
            UpdateCombo();
        }

    }

    private void UpdateBSGS()
    {

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            // sql.SqlPromoBSGSBuy.Update(dsSetup.Tables("PromoBSGSBuy"))
            // sql.SqlPromoBSGSGet.Update(dsSetup.Tables("PromoBSGSGet"))
            sql.SqlPromoBSGS.Update(dsSetup.Tables("PromoBSGS"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

    }

    private void UpdateCombo()
    {

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlPromoCombo.Update(dsSetup.Tables("PromoCombo"));
            sql.SqlPromoComboDetail.Update(dsSetup.Tables("PromoComboDetail"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

    }

    private void UpdateCoupon()
    {

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            // sql.SqlPromoCouponDiscount.Update(dsSetup.Tables("PromoCouponDiscount"))
            // sql.SqlPromoCouponAtleast.Update(dsSetup.Tables("PromoCouponAtleast"))
            sql.SqlPromoCoupon.Update(dsSetup.Tables("PromoCoupon"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

    }

    private void cbxPromoSelect_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataRow oRow;

        if (justForAdjusting == true)
            return;

        oRow = dsSetup.Tables("Promotion").Rows(cbxPromoSelect.SelectedIndex);
        PopulatePromoType(ref oRow);

    }

    private void PopulatePromoType(ref DataRow oRow)
    {

        ClearPromoDetailPanel();

        if (oRow("BSGS") == true)
        {
            txtPromoType.Text = "Buy Something, Get Something";
            currentBSGS = new PromoBSGS(oRow("PromoID"));    // PromotionCurrencyMan.Current("PromoID"))
            currentBSGS.Location = new Point(0, 0);
            pnlPromoDetail.Controls.Add(currentBSGS);
            typeOfPromo = "BSGS";
        }

        else if (oRow("Coupon") == true)
        {
            txtPromoType.Text = "Coupon";
            currentCoupon = new PromoCoupon(oRow("PromoID"));
            currentCoupon.Location = new Point(0, 0);
            pnlPromoDetail.Controls.Add(currentCoupon);
            typeOfPromo = "Coupon";
        }

        else if (oRow("Combo") == true)
        {
            txtPromoType.Text = "Combo";
            currentCombo = new PromoCombo(oRow("PromoID"));
            currentCombo.Location = new Point(0, 0);
            pnlPromoDetail.Controls.Add(currentCombo);
            typeOfPromo = "Combo";

        }

    }

    private void btnCancelNewPromo_Click(object sender, EventArgs e)
    {

        ResetNewPromoValues();

    }

    private void btnAcceptNewPromo_Click(object sender, EventArgs e)
    {

        if (rdbPromoBSGS.Checked == false & rdbPromoCombo.Checked == false & rdbPromoCoupon.Checked == false)
        {
            Interaction.MsgBox("You must select a Promotion Type.");
            return;
        }

        CreateNewPromo();
        ResetNewPromoValues();

    }

    private void ResetNewPromoValues()
    {

        pnlNewPromo.Visible = false;
        rdbPromoBSGS.Checked = false;
        rdbPromoBSGS.Checked = false;
        rdbPromoBSGS.Checked = false;
        txtNewStart.Text = "";
        txtNewEnd.Text = "";
        pnlPromoDetail.Enabled = true;
        pnlPromotionMain.Enabled = true;

    }

    private void ValidateDate(ref TextBox txtValNumeric)
    {

        if (txtValNumeric.Text == "")
        {
            // cancels the error
            ErrorProvider1.Dispose();
        }

        else if (!Information.IsDate(txtValNumeric.Text))
        {
            ErrorProvider1.SetError(txtValNumeric, "This must be a Date or Blank.");
            txtValNumeric.Focus();
            Interaction.Beep();
        }
        else
        {
            // cancels the error
            ErrorProvider1.Dispose();
        }
    }

    private void txtNewStart_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        var argtxtValNumeric = txtNewStart;
        ValidateDate(ref argtxtValNumeric);
        txtNewStart = argtxtValNumeric;
    }

    private void txtNewEnd_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        var argtxtValNumeric = txtNewEnd;
        ValidateDate(ref argtxtValNumeric);
        txtNewEnd = argtxtValNumeric;
    }

    private void txtPromoStart_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        var argtxtValNumeric = txtPromoStart;
        ValidateDate(ref argtxtValNumeric);
        txtPromoStart = argtxtValNumeric;
    }

    private void txtPromoEnd_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        var argtxtValNumeric = txtPromoEnd;
        ValidateDate(ref argtxtValNumeric);
        txtPromoEnd = argtxtValNumeric;
    }
}