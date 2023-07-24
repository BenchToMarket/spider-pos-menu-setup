using System.Diagnostics;

internal partial struct CheckType
{

    private int _orderNumber;
    private int _checkNumber;
    private int _tableNumber;
    private int _customerNumber;
    private int _lastSIN;
    private int _referenceSIN;
    private float _subtotal;

    public int OrderNumber
    {
        get
        {
            return _orderNumber;
        }
        set
        {
            _orderNumber = value;
        }
    }

    public int Check
    {
        get
        {
            return _checkNumber;
        }
        set
        {
            _checkNumber = value;
        }
    }

    public int Table
    {
        get
        {
            return _tableNumber;
        }
        set
        {
            _tableNumber = value;
        }
    }

    public int Customer
    {
        get
        {
            return _customerNumber;
        }
        set
        {
            _customerNumber = value;
        }
    }

    public int SIN
    {
        get
        {
            return _lastSIN;
        }
        set
        {
            _lastSIN = value;
        }
    }

    public int ReferenceSIN
    {
        get
        {
            return _referenceSIN;
        }
        set
        {
            _referenceSIN = value;
        }
    }

    public float SubTotal
    {
        get
        {
            return _subtotal;
        }
        set
        {
            _subtotal = value;
        }
    }

}


public partial class Ordering : System.Windows.Forms.Form
{

    // *** I do not think we use
    // *** it comes from Ordering, but we never get here
    // 222

    internal Panel custPanel;
    internal custButton[] customerButton = new custButton[10];
    internal custButton customerbuttonMain;

    // ***********************************************************
    // Defines the names, and values which will determine location
    // and size of all panels
    // ***********************************************************


    // ************************************************************************
    // For both Main and MainModifier Panels
    // (allow user to choose initial foods and modifiers)
    // ************************************************************************

    // Define both main and mainModifer panels
    internal Panel pnlMain;
    internal Panel pnlMainModifier;

    // ********************************************************************************
    // For Both Order Panel and OrderModifier Panel
    // ********************************************************************************

    internal Panel pnlOrder;
    internal Panel pnlOrderModifier;
    internal Panel pnlDescription;

    // position and size of Order Panel (op)
    private double opLocationX = ssX * 0.02d;
    private double opLocationY = ssY * 0.01d;
    private double opWidth = ssX * 0.78d;
    private double opHeight = ssY * 0.75d;
    private double opButtonWidth;
    private double opButtonHeight;

    // position and size of modifier panel (mp)
    private double mpLocationX = ssX * 0.15d;
    private double mpLocationY = ssY * 0.38d;
    private double mpWidth = ssX * 0.65d;
    private double mpHeight = ssY * 0.42d;
    private double mpButtonWidth;
    private double mpButtonHeight;

    // position and size of description panel
    private double dpLocationX = ssX * 0.02d;
    private double dpLocationY = ssY * 0.01d;
    private double dpWidth = ssX * 0.78d;
    private double dpHeight = ssY * 0.35d;

    // Buttons for the order(op) and modifier(mp) panel
    private OrderButton[] btnMain;
    private OrderButton[] btnModifier;
    private OrderButton[] btnOrder;
    private OrderButton[] btnOrderModifier;

    internal DataGrid gridViewOrder;





    private Label totalOrderLabel = new Label();
    private Label totalOrder;
    // Private subTotal As Single = 33.22

    internal ListView tableStatusView;
    internal ListView byServerView;

    // descriptions of all status categories
    internal string[] statusName = new string[11];



    private Panel kitchenCommands = new Panel();
    private Button btnSend;
    private Button btnHold;
    private Button btnVoid;
    private Button btnModify;
    private Button btnStatus;
    private Button btnLeave;

    private Panel ViewStatus;
    private Button btnStatus1;
    private Button btnStatus2;
    private Button btnStatus3;
    private Button btnStatus4;
    private Button btnStatus5;
    private Button btnStatus6;

    internal ListBox modifyComboBox;


    internal int[] numberFree;
    private CheckType openCheck;





    #region  Windows Form Designer generated code 

    public Ordering() : base()
    {
        custPanel = new Panel();
        pnlMain = new Panel();
        pnlMainModifier = new Panel();
        pnlOrder = new Panel();
        pnlOrderModifier = new Panel();
        pnlDescription = new Panel();
        opButtonWidth = (opWidth - 3 * buttonSpace) / 4;
        opButtonHeight = (opHeight - 10 * buttonSpace) / 8;
        mpButtonWidth = (mpWidth - 3 * buttonSpace) / 4;
        mpButtonHeight = (mpHeight - 5 * buttonSpace) / 4;
        gridViewOrder = new DataGrid();
        totalOrder = new Label();
        tableStatusView = new ListView();
        byServerView = new ListView();
        ViewStatus = new Panel();

        // This call is required by the Windows Form Designer.
        InitializeComponent();

        // Add any initialization after the InitializeComponent() call
        InitializeOther();


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
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        // 
        // Ordering
        // 
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.ClientSize = new System.Drawing.Size(292, 273);
        this.Name = "Ordering";
        this.Text = "Ordering";

    }

    #endregion

    private void InitializeOther()
    {


        // PopulateTables(1)   'either 1 for lunch or 2 for dinner
        // or any other number disired




    }


}