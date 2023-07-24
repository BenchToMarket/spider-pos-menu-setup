
internal partial class OrderButton : Button
{

    private bool _drinkCategory;
    private bool _subCategory;
    private bool _drinkAdds;
    private string _text;
    private string _name;
    private int _id;
    private int _foodID;      // carries food id to modifier selection
    private int _numberFree;
    private int _functions;

    private int _btnNumber;
    private int _btnIndex;
    private int _dataViewIndex;
    private short _priority;
    private int _colorInt;
    private int _colorForeInt;
    private bool _halfSplit;
    private bool _isActive;

    private BorderStyle bStyle;


    public bool DrinkCategory
    {
        get
        {
            return _drinkCategory;
        }
        set
        {
            _drinkCategory = value;
        }
    }

    public bool SubCategory
    {
        get
        {
            return _subCategory;
        }
        set
        {
            _subCategory = value;
        }
    }

    public bool DrinkAdds
    {
        get
        {
            return _drinkAdds;
        }
        set
        {
            _drinkAdds = value;
        }
    }

    public string ItemName
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    public int ID
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

    public int FoodID
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

    public int NumberFree
    {
        get
        {
            return _numberFree;
        }
        set
        {
            _numberFree = value;
        }
    }

    public int Functions
    {
        get
        {
            return _functions;
        }
        set
        {
            _functions = value;
        }
    }

    public int BtnNumber
    {
        get
        {
            return _btnNumber;
        }
        set
        {
            _btnNumber = value;
        }
    }

    public int BtnIndex
    {
        get
        {
            return _btnIndex;
        }
        set
        {
            _btnIndex = value;
        }
    }

    public int DataViewIndex
    {
        get
        {
            return _dataViewIndex;
        }
        set
        {
            _dataViewIndex = value;
        }
    }

    public BorderStyle BorderStyle
    {
        get
        {
            return bStyle;
        }
        set
        {
            bStyle = value;
        }
    }

    public short Priority
    {
        get
        {
            return _priority;
        }
        set
        {
            _priority = value;
        }
    }

    public int ColorInt
    {
        get
        {
            return _colorInt;
        }
        set
        {
            _colorInt = value;
        }
    }

    public int ColorForeInt
    {
        get
        {
            return _colorForeInt;
        }
        set
        {
            _colorForeInt = value;
        }
    }

    public bool HalfSplit
    {
        get
        {
            return _halfSplit;
        }
        set
        {
            _halfSplit = value;
        }
    }

    public bool IsActive
    {
        get
        {
            return _isActive;
        }
        set
        {
            _isActive = value;
        }
    }

    public OrderButton()
    {
        bStyle = BorderStyle.FixedSingle;
    }


}