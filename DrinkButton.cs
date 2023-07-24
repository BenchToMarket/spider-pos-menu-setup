public partial class DrinkButton : Button
{

    private int _id;
    private string _categoryName;
    private int _drinkCategoryID;
    private int _dRowNumber;
    private int _drinkIndex;
    private float _drinkPrice;
    private decimal _callPrice;
    private decimal _addOnPrice;
    private int _drinkFunctionID;
    private string _drinkDesc;
    private bool _drinkAddOnChoice;
    private bool _isDrinkAdd;
    private bool _isALiquorType;
    private bool _isWineParring;
    private int _liquorTypeID;
    private int _position;
    private int _menuIndex;
    private BorderStyle _bStyle;

    internal int ID
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }

    internal string CategoryName
    {
        get
        {
            return _categoryName;
        }
        set
        {
            _categoryName = value;
        }
    }

    internal int DrinkCategoryID
    {
        get
        {
            return _drinkCategoryID;
        }
        set
        {
            _drinkCategoryID = value;
        }
    }

    internal int dRowNumber
    {
        get
        {
            return _dRowNumber;
        }
        set
        {
            _dRowNumber = value;
        }
    }

    internal int DrinkIndex
    {
        get
        {
            return _drinkIndex;
        }
        set
        {
            _drinkIndex = value;
        }
    }

    internal float DrinkPrice
    {
        get
        {
            return _drinkPrice;
        }
        set
        {
            _drinkPrice = value;
        }
    }

    internal decimal CallPrice
    {
        get
        {
            return _callPrice;
        }
        set
        {
            _callPrice = value;
        }
    }

    internal decimal AddOnPrice
    {
        get
        {
            return _addOnPrice;
        }
        set
        {
            _addOnPrice = value;
        }
    }

    internal int DrinkFunctionID
    {
        get
        {
            return _drinkFunctionID;
        }
        set
        {
            _drinkFunctionID = value;
        }
    }

    internal string DrinkDesc
    {
        get
        {
            return _drinkDesc;
        }
        set
        {
            _drinkDesc = value;
        }
    }

    internal bool DrinkAddOnChoice
    {
        get
        {
            return _drinkAddOnChoice;
        }
        set
        {
            _drinkAddOnChoice = value;
        }
    }

    internal bool IsDrinkAdd
    {
        get
        {
            return _isDrinkAdd;
        }
        set
        {
            _isDrinkAdd = value;
        }
    }

    internal bool IsALiquorType
    {
        get
        {
            return _isALiquorType;
        }
        set
        {
            _isALiquorType = value;
        }
    }

    internal bool IsWineParring
    {
        get
        {
            return _isWineParring;
        }
        set
        {
            _isWineParring = value;
        }
    }

    internal int LiquorTypeID
    {
        get
        {
            return _liquorTypeID;
        }
        set
        {
            _liquorTypeID = value;
        }
    }

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

    internal BorderStyle BorderStyle
    {
        get
        {
            return _bStyle;
        }
        set
        {
            _bStyle = value;
        }
    }

    public DrinkButton()
    {
        _bStyle = BorderStyle.FixedSingle;
    }




}