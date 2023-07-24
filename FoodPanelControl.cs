using System.Diagnostics;


public partial class FoodPanelControl : System.Windows.Forms.Button
{

    internal Label foodNamePanel;
    internal Label foodPricePanel;

    private int _position;
    private int _menuJoinID;
    private string _foodName;
    private decimal _foodPrice;
    private int _menuIndex;
    private int _isStaging;
    private string _updatingTable;
    private int _foodID;
    private decimal _surcharge;
    private int _routingID;
    private int _drinkID;
    private int _generalMenuID;
    private int _currentMenu;
    private Color _bColor;
    private Color _fColor;

    internal int Position
    {
        get
        {
            return _position;
        }
        set
        {
            _position = value;
        }
    }
    internal int MenuJoinID
    {
        get
        {
            return _menuJoinID;
        }
        set
        {
            _menuJoinID = value;
        }
    }

    internal string FoodName
    {
        get
        {
            return _foodName;
        }
        set
        {
            _foodName = value;
        }
    }

    internal decimal FoodPrice
    {
        get
        {
            return _foodPrice;
        }
        set
        {
            _foodPrice = value;
        }
    }

    internal int MenuIndex
    {
        get
        {
            return _menuIndex;
        }
        set
        {
            _menuIndex = value;
        }
    }

    internal bool StagingPanel
    {
        get
        {
            return Conversions.ToBoolean(_isStaging);
        }
        set
        {
            _isStaging = Conversions.ToInteger(value);
        }
    }

    internal string UpdatingTable
    {
        get
        {
            return _updatingTable;
        }
        set
        {
            _updatingTable = value;
        }
    }

    internal int FoodID
    {
        get
        {
            return _foodID;
        }
        set
        {
            _foodID = value;
        }
    }

    internal decimal Surcharge
    {
        get
        {
            return _surcharge;
        }
        set
        {
            _surcharge = value;
        }
    }

    internal int RoutingID
    {
        get
        {
            return _routingID;
        }
        set
        {
            _routingID = value;
        }
    }

    internal int DrinkID
    {
        get
        {
            return _drinkID;
        }
        set
        {
            _drinkID = value;
        }
    }

    internal int GeneralMenuID
    {
        get
        {
            return _generalMenuID;
        }
        set
        {
            _generalMenuID = value;
        }
    }

    internal int CurrentMenu
    {
        get
        {
            return _currentMenu;
        }
        set
        {
            _currentMenu = value;
        }
    }

    #region  Windows Form Designer generated code 

    public FoodPanelControl(Color bColor, Color fColor, int foodOrderNumber, int index, int menuJoinID, string name, decimal price, float w, float h, bool isStaging, string dTable, int fID, decimal sur, int rout, int dID, int GenMenuID, int cm) : base()
    {

        // Me.BackColor = bColor
        // Me.ForeColor = fColor

        // This call is required by the Windows Form Designer.
        InitializeComponent();

        // Add any initialization after the InitializeComponent() call
        Position = foodOrderNumber;
        MenuJoinID = menuJoinID;
        MenuIndex = index;
        StagingPanel = isStaging;
        FoodName = name;
        FoodPrice = price;
        UpdatingTable = dTable;

        FoodID = fID;
        Surcharge = sur;
        RoutingID = rout;
        DrinkID = dID;
        GeneralMenuID = GenMenuID;
        CurrentMenu = cm;
        _bColor = bColor;
        _fColor = fColor;

        InitializeOther(w, h);

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

    private void InitializeOther(float width, float height)
    {
        foodNamePanel = new Label();
        foodPricePanel = new Label();

        this.Size = new Size(width, height);
        this.Text = FoodName;
        this.AllowDrop = true;

        foodNamePanel.Size = new Size(width, height / 2f);
        foodNamePanel.Location = new Point(0, 0);
        foodNamePanel.Text = FoodName;

        foodPricePanel.Size = new Size(width, height / 2f);
        foodPricePanel.Location = new Point(0, height / 2f);
        foodPricePanel.Text = "$ " + FoodPrice;
        // If _bColor = Nothing Then
        // foodNamePanel.BackColor = Color.PowderBlue
        // foodPricePanel.BackColor = Color.PowderBlue
        // Else
        foodNamePanel.BackColor = _bColor;
        foodPricePanel.BackColor = _bColor;
        foodNamePanel.ForeColor = _fColor;
        foodPricePanel.ForeColor = _fColor;
        // End If
        foodPricePanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

        // Me.Controls.Add(foodNamePanel)
        // Me.Controls.Add(foodPricePanel)

    }



}