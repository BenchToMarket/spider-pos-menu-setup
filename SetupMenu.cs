using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;


internal partial struct ActiveCategory
{
    private int _activeID;
    private int _dataViewIndex;
    private string _activeText;
    private string _activeAbrevText;
    private int _activeFunction;
    private string _activeCategoryType;
    private int _activeButton;
    private int _activePosition;
    private int _categoryIndexMore;
    private int _categoryIndexModifier;
    private int _categoryIsActive;
    private bool _updated;
    private bool _halfSplit;
    // Private _updatedModifier As Boolean
    private int _colorInt;
    private int _colorForeInt;
    private short _priority;


    internal int ActiveID
    {
        get
        {
            return _activeID;
        }
        set
        {
            _activeID = value;
        }
    }

    internal int DataViewIndex
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

    internal string ActiveText
    {
        get
        {
            return _activeText;
        }
        set
        {
            _activeText = value;
        }
    }

    internal string ActiveAbrevText
    {
        get
        {
            return _activeAbrevText;
        }
        set
        {
            _activeAbrevText = value;
        }
    }

    internal int ActiveFunction
    {
        get
        {
            return _activeFunction;
        }
        set
        {
            _activeFunction = value;
        }
    }

    internal string ActiveCategoryType
    {
        get
        {
            return _activeCategoryType;
        }
        set
        {
            _activeCategoryType = value;
        }
    }

    internal int ActiveButton
    {
        get
        {
            return _activeButton;
        }
        set
        {
            _activeButton = value;
        }
    }

    internal int ActivePosition
    {
        get
        {
            return _activePosition;
        }
        set
        {
            _activePosition = value;
        }
    }

    internal int CategoryIndexMore
    {
        get
        {
            return _categoryIndexMore;
        }
        set
        {
            _categoryIndexMore = value;
        }
    }

    internal int CategoryIndexModifier
    {
        get
        {
            return _categoryIndexModifier;
        }
        set
        {
            _categoryIndexModifier = value;
        }
    }

    internal bool CategoryIsActive
    {
        get
        {
            return Conversions.ToBoolean(_categoryIsActive);
        }
        set
        {
            _categoryIsActive = Conversions.ToInteger(value);
        }
    }

    internal bool Updated
    {
        get
        {
            return _updated;
        }
        set
        {
            _updated = value;
        }
    }

    internal bool HalfSplit
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
    // Friend Property UpdatedModifier() As Boolean
    // Get
    // Return _updatedModifier
    // '       End Get
    // Set(ByVal Value As Boolean)
    // _updatedModifier = Value
    // End Set
    // End Property

    internal int ColorInt
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

    internal int ColorForeInt
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

    internal short Priority
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

}

internal partial struct ActiveMenu
{

    private int _activeMenuID;
    private string _activeMenuName;
    private int _activeMenuCategoryID;
    private int _activeMenuDrinkCategoryID;
    private int _activeMenuOrderIndex;
    private int _activeDetailID;
    // Private _dRow As DataRow

    internal int ActiveMenuID
    {
        get
        {
            return _activeMenuID;
        }
        set
        {
            _activeMenuID = value;
        }
    }
    internal string ActiveMenuName
    {
        get
        {
            return _activeMenuName;
        }
        set
        {
            _activeMenuName = value;
        }
    }

    internal int ActiveMenuCategoryID
    {
        get
        {
            return _activeMenuCategoryID;
        }
        set
        {
            _activeMenuCategoryID = value;
        }
    }

    internal int ActiveMenuDrinkCategoryID
    {
        get
        {
            return _activeMenuDrinkCategoryID;
        }
        set
        {
            _activeMenuDrinkCategoryID = value;
        }
    }

    internal int ActiveMenuOrderIndex
    {
        get
        {
            return _activeMenuOrderIndex;
        }
        set
        {
            _activeMenuOrderIndex = value;
        }
    }

    internal int ActiveDetialID
    {
        get
        {
            return _activeDetailID;
        }
        set
        {
            _activeDetailID = value;
        }
    }
    // Friend Property dRow() As DataRow
    // Get
    // Return _dRow
    // End Get
    // Set(ByVal Value As DataRow)
    // _dRow = Value
    // End Set
    // End Property

}

internal partial struct ActiveFood
{

    private int _functionID;
    private int _FoodRoutingID;
    private string _foodRoutingName;
    private int _PrintPriorityID;
    private string _printPriorityName;
    private int _FoodTaxID;
    private string _foodTaxName;
    private bool _isMainFood;
    private int _activeFoodID;
    private int _previousPosition;
    private bool _gotoPrevious;
    private bool _menuCostChanged;


    internal int FunctionID
    {
        get
        {
            return _functionID;
        }
        set
        {
            _functionID = value;
        }
    }

    internal bool IsMainFood
    {
        get
        {
            return _isMainFood;
        }
        set
        {
            _isMainFood = value;
        }
    }

    internal int FoodRoutingID
    {
        get
        {
            return _FoodRoutingID;
        }
        set
        {
            _FoodRoutingID = value;
        }
    }

    internal string FoodRoutingName
    {
        get
        {
            return _foodRoutingName;
        }
        set
        {
            _foodRoutingName = value;
        }
    }

    internal int PrintPriorityID
    {
        get
        {
            return _PrintPriorityID;
        }
        set
        {
            _PrintPriorityID = value;
        }
    }

    internal string PrintPriorityName
    {
        get
        {
            return _printPriorityName;
        }
        set
        {
            _printPriorityName = value;
        }
    }

    internal int FoodTaxID
    {
        get
        {
            return _FoodTaxID;
        }
        set
        {
            _FoodTaxID = value;
        }
    }

    internal string FoodTaxName
    {
        get
        {
            return _foodTaxName;
        }
        set
        {
            _foodTaxName = value;
        }
    }

    internal int ActiveFoodID
    {
        get
        {
            return _activeFoodID;
        }
        set
        {
            _activeFoodID = value;
        }
    }

    internal int PreviousPosition
    {
        get
        {
            return _previousPosition;
        }
        set
        {
            _previousPosition = value;
        }
    }

    internal bool GotoPrevious
    {
        get
        {
            return _gotoPrevious;
        }
        set
        {
            _gotoPrevious = value;
        }
    }

    internal bool MenuCostChanged
    {
        get
        {
            return _menuCostChanged;
        }
        set
        {
            _menuCostChanged = value;
        }
    }

}

internal partial struct ActiveModifier
{
    private int _activeModifierID;
    private string _activeModifierName;
    private string _activeAbrevText;
    private int _activeModifierCategoryID;
    private int _pageIndex;
    private int _maxIndex;
    private int _menuIndex;
    private bool _changesMade;
    private FoodPanelControl _changingPanel;

    private string _activeModifierDesc;


    internal int ActiveModifierID
    {
        get
        {
            return _activeModifierID;
        }
        set
        {
            _activeModifierID = value;
        }
    }

    internal string ActiveModifierName
    {
        get
        {
            return _activeModifierName;
        }
        set
        {
            _activeModifierName = value;
        }
    }

    internal string ActiveAbrevText
    {
        get
        {
            return _activeAbrevText;
        }
        set
        {
            _activeAbrevText = value;
        }
    }

    internal int PageIndex
    {
        get
        {
            return _pageIndex;
        }
        set
        {
            _pageIndex = value;
        }
    }

    internal int MaxIndex
    {
        get
        {
            return _maxIndex;
        }
        set
        {
            _maxIndex = value;
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

    internal bool ChangesMade
    {
        get
        {
            return _changesMade;
        }
        set
        {
            _changesMade = value;
        }
    }

    internal FoodPanelControl ChangingPanel
    {
        get
        {
            return _changingPanel;
        }
        set
        {
            _changingPanel = value;
        }
    }

    internal int ActiveModifierCategoryID
    {
        get
        {
            return _activeModifierCategoryID;
        }
        set
        {
            _activeModifierCategoryID = value;
        }
    }


}

internal partial struct ActiveFoodJoin
{

    private int _activeJoinFoodID;
    private int _activeTempIndex;
    private int _activeCategoryRow;
    private int _activeModifierRow;

    internal int ActiveJoinFoodID
    {
        get
        {
            return _activeJoinFoodID;
        }
        set
        {
            _activeJoinFoodID = value;
        }
    }

    internal int ActiveTempIndex
    {
        get
        {
            return _activeTempIndex;
        }
        set
        {
            _activeTempIndex = value;
        }
    }

    internal int ActiveCategoryRow
    {
        get
        {
            return _activeCategoryRow;
        }
        set
        {
            _activeCategoryRow = value;
        }
    }

    internal int ActiveModifierRow
    {
        get
        {
            return _activeModifierRow;
        }
        set
        {
            _activeModifierRow = value;
        }
    }


}

internal partial struct ActiveDrink
{

    private string _drinkName;
    private int _drinkCategoryID;
    private int _drinkCategoryIndex;
    private int _drinkNameIndex;
    private int _drinkNameID;
    private int _dRowNumber;
    private bool _changesMade;
    private int _LiquorType;
    private int _drinkFunctionID;
    private decimal _drinkPrice;
    private decimal _drinkHappyPrice;
    private decimal _callPrice;
    private decimal _addOnPrice;
    private string _drinkDesc;
    private bool _drinkAddOnChoice;
    private bool _isDrinkAdd;
    private bool _isWineParring;

    internal string DrinkName
    {
        get
        {
            return _drinkName;
        }
        set
        {
            _drinkName = value;
        }
    }

    internal object DrinkCategoryID
    {
        get
        {
            return _drinkCategoryID;
        }
        set
        {
            _drinkCategoryID = Conversions.ToInteger(value);
        }
    }

    internal object DrinkCategoryIndex
    {
        get
        {
            return _drinkCategoryIndex;
        }
        set
        {
            _drinkCategoryIndex = Conversions.ToInteger(value);
        }
    }

    internal object DrinkNameIndex
    {
        get
        {
            return _drinkNameIndex;
        }
        set
        {
            _drinkNameIndex = Conversions.ToInteger(value);
        }
    }

    internal object DrinkNameID
    {
        get
        {
            return _drinkNameID;
        }
        set
        {
            _drinkNameID = Conversions.ToInteger(value);
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
    internal bool ChangesMade
    {
        get
        {
            return _changesMade;
        }
        set
        {
            _changesMade = value;
        }
    }
    internal int LiquorType
    {
        get
        {
            return _LiquorType;
        }
        set
        {
            _LiquorType = value;
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

    internal decimal DrinkPrice
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

    internal decimal DrinkHappyPrice
    {
        get
        {
            return _drinkHappyPrice;
        }
        set
        {
            _drinkHappyPrice = value;
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

}

internal partial struct ActiveFoodOrder
{
    private int _currentMenu;
    private int _currentCategory;
    private string _funFlag;
    private bool _catIsDrink;
    private int _currentCategorySub;
    private string _funFlagSub;
    private int _pageIndex;
    // Private _stagingIndex As Integer
    private int _maxIndex;
    private int _morePanels;
    private bool _extendedDisplay;

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

    internal int CurrentCategory
    {
        get
        {
            return _currentCategory;
        }
        set
        {
            _currentCategory = value;
        }
    }

    internal string FunFlag
    {
        get
        {
            return _funFlag;
        }
        set
        {
            _funFlag = value;
        }
    }

    internal bool CatIsDrink
    {
        get
        {
            return _catIsDrink;
        }
        set
        {
            _catIsDrink = value;
        }
    }

    internal int CurrentCategorySub
    {
        get
        {
            return _currentCategorySub;
        }
        set
        {
            _currentCategorySub = value;
        }
    }

    internal string FunFlagsub
    {
        get
        {
            return _funFlagSub;
        }
        set
        {
            _funFlagSub = value;
        }
    }

    internal int PageIndex
    {
        get
        {
            return _pageIndex;
        }
        set
        {
            _pageIndex = value;
        }
    }

    // Friend Property StagingIndex() As Integer
    // Get
    // Return _stagingIndex
    // End Get
    // Set(ByVal Value As Integer)
    // _stagingIndex = Value
    // End Set
    // End Property

    internal int MaxIndex
    {
        get
        {
            return _maxIndex;
        }
        set
        {
            _maxIndex = value;
        }
    }

    internal int MorePanels
    {
        get
        {
            return _morePanels;
        }
        set
        {
            _morePanels = value;
        }
    }

    internal bool ExtendedDisplay
    {
        get
        {
            return _extendedDisplay;
        }
        set
        {
            _extendedDisplay = value;
        }
    }

}


public partial class SetupMenu : System.Windows.Forms.UserControl, ICollection
{

    // Friend sql As New DataSet_Builder.SQLHelper

    private OrderButton[] btnMain = new OrderButton[201];
    private OrderButton[] btnModifier = new OrderButton[21];
    private CustomCheckBox[] menuActive = new CustomCheckBox[11];
    private CheckBox[] menuCheckBox = new CheckBox[11];
    private TextBox[] menuCostText = new TextBox[11];
    private bool menuBoxUpdated;
    private bool MenuCostChanged;
    private TextBox[] menuSurchargeText = new TextBox[11];
    private ComboBox[] menuRouting = new ComboBox[11];
    private TextBox txtMenuUpdate;
    private Button btnMenuAdd;
    private ButtonColor_UC ColorChoice;
    private ButtonColor_UC ColorChoiceNew;
    private ButtonColor_UC DrinkColorChoice;

    private CheckBox[] prepCheckBox = new CheckBox[101];
    // Dim prepNameText(100) As Label
    private Label[] prepMethod = new Label[101];
    private TextBox[] prepPriceText = new TextBox[101];
    private TextBox[] prepOrderByText = new TextBox[101];
    private TextBox[] prepInvMultiplier = new TextBox[101];
    private bool prepDrinkUpdated;

    // Public Shared btnMainCollection As New ControlBindingsCollection

    // Dim WithEvents btnMainMore As New Button
    // Dim WithEvents btnModifierMore As New Button

    private DrinkButton[] btnCategory = new DrinkButton[33];
    private DrinkButton[] btnCategory2 = new DrinkButton[33];
    private DrinkButton[] btnDrinks = new DrinkButton[61];
    private bool addingNewDrinkTest;
    private bool drinkDisplaying;
    private FoodPanelControl currentDrinkPanel;
    private FoodPanelControl currentDrinkPanelLast;


    private OrderButton[] btnMenu = new OrderButton[21];

    private ActiveCategory newCategory = new ActiveCategory();
    private ActiveMenu newMenu = new ActiveMenu();
    private ActiveFood newFood = new ActiveFood();
    private ActiveModifier newModifier = new ActiveModifier();
    private ActiveFoodJoin newFoodJoin = new ActiveFoodJoin();
    private ActiveDrink newDrink;
    private ActiveDrink oldDrink;
    private ActiveFoodOrder newFoodOrder = new ActiveFoodOrder();

    private bool newModifierChangesMade;
    private bool newDrinkChangesMade;
    private int newFoodOrderStagingIndex; // Boolean

    private bool updatedMenu;
    private bool updatedMenuDetail;
    private bool updatedCategory;
    private bool updatedDrink;
    private int currentDrinkCategoryID;
    private bool updatedWPI;
    private bool updatedFoodJoin;
    private bool filledFirstFood;
    private bool isOrderQuickService;
    private bool justAdjustingPosition;

    private CurrencyManager FoodCurrencyMan;
    private CurrencyManager ModifierCurrencyMan;
    private CurrencyManager JoinIndividualMan;
    private CurrencyManager mainCatCurrencyMan;
    private int globalJoinValueCategoryID;

    // Friend dvMainCategory As DataView = New DataView
    internal DataView dvActiveMenu = new DataView();
    internal DataView dvMenuJoin = new DataView();
    internal DataView dvModifiers = new DataView();
    internal DataView dvModifiers2 = new DataView();
    internal DataView dvMainFoodsCategory;
    internal DataView dvModifierCategory; // = New DataView
    internal DataView dvFoodJoinMainFoodsCagtegory;
    internal DataView dvFoodJoinCategory;

    private DataGridTableStyle tsJoinIndividualModifiers = new DataGridTableStyle();

    // Friend dvFoods As New DataView
    // Friend dvJoinFoodCategoryJoins As DataView
    // Friend dvJoinFoodModifierJoins As DataView
    private string bartnerderMenuMode;
    private int valueMenuID;
    private string valueMenuName;
    private bool valueMenuActive;
    private int generalDrinkCategoryID = -1;
    private string lastPrepMethod = "USdol";

    internal DataView dvCategory = new DataView();
    internal DataView dvSubCategory = new DataView();
    internal DataView dvDrinkCats = new DataView();
    internal DataView dvOrderMenu = new DataView();
    internal DataView dvOrderStaging = new DataView();
    internal DataView dvModifierStaging = new DataView();

    private int[] foodMenuJoinID = new int[66];
    private string[] foodName = new string[66];
    private decimal[] foodPrice = new decimal[66];
    private int[] foodIndex = new int[66];
    private int[] foodFoodID = new int[66];
    private decimal[] foodSurcharge = new decimal[66];
    private int[] foodRoutingID = new int[66];
    private int[] foodDrinkID = new int[66];
    private int[] foodGeneralMenuID = new int[66];
    private int[] foodCurrentMenu = new int[66];
    private Color[] foodBackColor = new Color[66];
    private Color[] foodForeColor = new Color[66];

    private int[] modifierID = new int[33];
    private string[] modifierName = new string[33];
    private int[] modifierIndex = new int[33];
    // Dim modifierDataViewIndex(32) As Integer


    private FoodOrderPanel foodOrderPanel1;
    private FoodOrderPanel foodOrderPanel2;
    private FoodOrderPanel foodOrderPanel3;
    private FoodOrderPanel foodOrderPanel4;
    private FoodOrderPanel foodOrderPanel5;
    private FoodOrderPanel foodOrderPanel6;
    private FoodOrderPanel foodOrderPanel7;
    private FoodOrderPanel foodOrderPanel8;
    private FoodOrderPanel foodOrderPanel9;
    private FoodOrderPanel foodOrderPanel10;
    private FoodOrderPanel foodOrderPanel11;
    private FoodOrderPanel foodOrderPanel12;
    private FoodOrderPanel foodOrderPanel13;
    private FoodOrderPanel foodOrderPanel14;
    private FoodOrderPanel foodOrderPanel15;
    private FoodOrderPanel foodOrderPanel16;
    private FoodOrderPanel foodOrderPanel17;
    private FoodOrderPanel foodOrderPanel18;
    private FoodOrderPanel foodOrderPanel19;
    private FoodOrderPanel foodOrderPanel20;
    private FoodOrderPanel foodOrderPanel21;
    private FoodOrderPanel foodOrderPanel22;
    private FoodOrderPanel foodOrderPanel23;
    private FoodOrderPanel foodOrderPanel24;
    private FoodOrderPanel foodOrderPanel25;
    private FoodOrderPanel foodOrderPanel26;
    private FoodOrderPanel foodOrderPanel27;
    private FoodOrderPanel foodOrderPanel28;
    private FoodOrderPanel foodOrderPanel29;
    private FoodOrderPanel foodOrderPanel30;
    private FoodOrderPanel foodOrderPanel31;
    private FoodOrderPanel foodOrderPanel32;
    private FoodOrderPanel foodOrderPanel33;
    private FoodOrderPanel foodOrderPanel34;
    private FoodOrderPanel foodOrderPanel35;
    private FoodOrderPanel foodOrderPanel36;
    private FoodOrderPanel foodOrderPanel37;
    private FoodOrderPanel foodOrderPanel38;
    private FoodOrderPanel foodOrderPanel39;
    private FoodOrderPanel foodOrderPanel40;
    private FoodOrderPanel foodOrderPanel41;
    private FoodOrderPanel foodOrderPanel42;
    private FoodOrderPanel foodOrderPanel43;
    private FoodOrderPanel foodOrderPanel44;
    private FoodOrderPanel foodOrderPanel45;
    private FoodOrderPanel foodOrderPanel46;
    private FoodOrderPanel foodOrderPanel47;
    private FoodOrderPanel foodOrderPanel48;
    private FoodOrderPanel foodOrderPanel49;
    private FoodOrderPanel foodOrderPanel50;
    private FoodOrderPanel foodOrderPanel51;
    private FoodOrderPanel foodOrderPanel52;
    private FoodOrderPanel foodOrderPanel53;
    private FoodOrderPanel foodOrderPanel54;
    private FoodOrderPanel foodOrderPanel55;
    private FoodOrderPanel foodOrderPanel56;
    private FoodOrderPanel foodOrderPanel57;
    private FoodOrderPanel foodOrderPanel58;
    private FoodOrderPanel foodOrderPanel59;
    private FoodOrderPanel foodOrderPanel60;

    private FoodOrderPanel modifierOrderPanel1;
    private FoodOrderPanel modifierOrderPanel2;
    private FoodOrderPanel modifierOrderPanel3;
    private FoodOrderPanel modifierOrderPanel4;
    private FoodOrderPanel modifierOrderPanel5;
    private FoodOrderPanel modifierOrderPanel6;
    private FoodOrderPanel modifierOrderPanel7;
    private FoodOrderPanel modifierOrderPanel8;
    private FoodOrderPanel modifierOrderPanel9;
    private FoodOrderPanel modifierOrderPanel10;
    private FoodOrderPanel modifierOrderPanel11;
    private FoodOrderPanel modifierOrderPanel12;
    private FoodOrderPanel modifierOrderPanel13;
    private FoodOrderPanel modifierOrderPanel14;
    private FoodOrderPanel modifierOrderPanel15;
    private FoodOrderPanel modifierOrderPanel16;
    private FoodOrderPanel modifierOrderPanel17;
    private FoodOrderPanel modifierOrderPanel18;
    private FoodOrderPanel modifierOrderPanel19;
    private FoodOrderPanel modifierOrderPanel20;
    private FoodOrderPanel modifierOrderPanel21;
    private FoodOrderPanel modifierOrderPanel22;
    private FoodOrderPanel modifierOrderPanel23;
    private FoodOrderPanel modifierOrderPanel24;
    private FoodOrderPanel modifierOrderPanel25;


    private FoodOrderPanel DrinkOrderPanel1;
    private FoodOrderPanel DrinkOrderPanel2;
    private FoodOrderPanel DrinkOrderPanel3;
    private FoodOrderPanel DrinkOrderPanel4;
    private FoodOrderPanel DrinkOrderPanel5;
    private FoodOrderPanel DrinkOrderPanel6;
    private FoodOrderPanel DrinkOrderPanel7;
    private FoodOrderPanel DrinkOrderPanel8;
    private FoodOrderPanel DrinkOrderPanel9;
    private FoodOrderPanel DrinkOrderPanel10;
    private FoodOrderPanel DrinkOrderPanel11;
    private FoodOrderPanel DrinkOrderPanel12;
    private FoodOrderPanel DrinkOrderPanel13;
    private FoodOrderPanel DrinkOrderPanel14;
    private FoodOrderPanel DrinkOrderPanel15;
    private FoodOrderPanel DrinkOrderPanel16;
    private FoodOrderPanel DrinkOrderPanel17;
    private FoodOrderPanel DrinkOrderPanel18;
    private FoodOrderPanel DrinkOrderPanel19;
    private FoodOrderPanel DrinkOrderPanel20;
    private FoodOrderPanel DrinkOrderPanel21;
    private FoodOrderPanel DrinkOrderPanel22;
    private FoodOrderPanel DrinkOrderPanel23;
    private FoodOrderPanel DrinkOrderPanel24;
    private FoodOrderPanel DrinkOrderPanel25;
    private FoodOrderPanel DrinkOrderPanel26;
    private FoodOrderPanel DrinkOrderPanel27;
    private FoodOrderPanel DrinkOrderPanel28;
    private FoodOrderPanel DrinkOrderPanel29;
    private FoodOrderPanel DrinkOrderPanel30;
    private FoodOrderPanel DrinkOrderPanel31;
    private FoodOrderPanel DrinkOrderPanel32;
    private FoodOrderPanel DrinkOrderPanel33;
    private FoodOrderPanel DrinkOrderPanel34;
    private FoodOrderPanel DrinkOrderPanel35;
    private FoodOrderPanel DrinkOrderPanel36;
    private FoodOrderPanel DrinkOrderPanel37;
    private FoodOrderPanel DrinkOrderPanel38;
    private FoodOrderPanel DrinkOrderPanel39;
    private FoodOrderPanel DrinkOrderPanel40;
    private FoodOrderPanel DrinkOrderPanel41;
    private FoodOrderPanel DrinkOrderPanel42;
    private FoodOrderPanel DrinkOrderPanel43;
    private FoodOrderPanel DrinkOrderPanel44;
    private FoodOrderPanel DrinkOrderPanel45;
    private FoodOrderPanel DrinkOrderPanel46;
    private FoodOrderPanel DrinkOrderPanel47;
    private FoodOrderPanel DrinkOrderPanel48;
    private FoodOrderPanel DrinkOrderPanel49;
    private FoodOrderPanel DrinkOrderPanel50;
    private FoodOrderPanel DrinkOrderPanel51;
    private FoodOrderPanel DrinkOrderPanel52;
    private FoodOrderPanel DrinkOrderPanel53;
    private FoodOrderPanel DrinkOrderPanel54;
    private FoodOrderPanel DrinkOrderPanel55;
    private FoodOrderPanel DrinkOrderPanel56;
    private FoodOrderPanel DrinkOrderPanel57;
    private FoodOrderPanel DrinkOrderPanel58;
    private FoodOrderPanel DrinkOrderPanel59;
    private FoodOrderPanel DrinkOrderPanel60;

    private FoodOrderPanel modifierOrderStaging1;
    private FoodOrderPanel modifierOrderStaging2;
    private FoodOrderPanel modifierOrderStaging3;
    private FoodOrderPanel modifierOrderStaging4;
    private FoodOrderPanel modifierOrderStaging5;
    private FoodOrderPanel modifierOrderStaging6;
    private FoodOrderPanel modifierOrderStaging7;
    private FoodOrderPanel modifierOrderStaging8;

    // **** not using the following ten
    // Dim WithEvents FoodOrderStaging1 As FoodOrderPanel
    // Dim WithEvents FoodOrderStaging2 As FoodOrderPanel
    // Dim WithEvents FoodOrderStaging3 As FoodOrderPanel
    // Dim WithEvents FoodOrderStaging4 As FoodOrderPanel
    // Dim WithEvents FoodOrderStaging5 As FoodOrderPanel
    // Dim WithEvents FoodOrderStaging6 As FoodOrderPanel
    // Dim WithEvents FoodOrderStaging7 As FoodOrderPanel
    // Dim WithEvents FoodOrderStaging8 As FoodOrderPanel
    // Dim WithEvents FoodOrderStaging9 As FoodOrderPanel
    // Dim WithEvents FoodOrderStaging10 As FoodOrderPanel

    private Panel dummyPanel;
    private Global.System.Windows.Forms.CheckBox _chkExtendedDisplay;

    internal virtual Global.System.Windows.Forms.CheckBox chkExtendedDisplay
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkExtendedDisplay;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkExtendedDisplay = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkNewExtendedDisplay;

    internal virtual Global.System.Windows.Forms.CheckBox chkNewExtendedDisplay
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkNewExtendedDisplay;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkNewExtendedDisplay = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnJoinReq;

    internal virtual Global.System.Windows.Forms.Button btnJoinReq
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnJoinReq;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnJoinReq = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label26;

    internal virtual Global.System.Windows.Forms.Label Label26
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label26;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label26 = value;
        }
    }
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
    private Global.System.Windows.Forms.Label _Label27;

    internal virtual Global.System.Windows.Forms.Label Label27
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label27;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label27 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtFoodInvMultiplier;

    internal virtual Global.System.Windows.Forms.TextBox txtFoodInvMultiplier
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtFoodInvMultiplier;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtFoodInvMultiplier = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxFoodFilterModifiers;

    internal virtual Global.System.Windows.Forms.ComboBox cbxFoodFilterModifiers
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxFoodFilterModifiers;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxFoodFilterModifiers = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlOrderPage;

    internal virtual Global.System.Windows.Forms.Panel pnlOrderPage
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlOrderPage;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlOrderPage = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlModifierPage;

    internal virtual Global.System.Windows.Forms.Panel pnlModifierPage
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlModifierPage;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlModifierPage = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkNewDisplayWithAdds;

    internal virtual Global.System.Windows.Forms.CheckBox chkNewDisplayWithAdds
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkNewDisplayWithAdds;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkNewDisplayWithAdds = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkDisplayWithAdd;

    internal virtual Global.System.Windows.Forms.CheckBox chkDisplayWithAdd
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkDisplayWithAdd;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkDisplayWithAdd = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblDrinkHappyPrice;

    internal virtual Global.System.Windows.Forms.Label lblDrinkHappyPrice
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblDrinkHappyPrice;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblDrinkHappyPrice = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtDrinkHappyPrice;

    internal virtual Global.System.Windows.Forms.TextBox txtDrinkHappyPrice
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtDrinkHappyPrice;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtDrinkHappyPrice = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label28;

    internal virtual Global.System.Windows.Forms.Label Label28
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label28;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label28 = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label29;

    internal virtual Global.System.Windows.Forms.Label Label29
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label29;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label29 = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label30;

    internal virtual Global.System.Windows.Forms.Label Label30
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label30;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label30 = value;
        }
    }

    private FoodOrderPanel[] foodOrderStaging = new FoodOrderPanel[11];
    // Dim modifierOrderStaging(8) As FoodOrderPanel

    // Dim stagingIndex As Integer = 0




    #region  Windows Form Designer generated code 

    public SetupMenu() : base()
    {
        txtMenuUpdate = new TextBox();
        btnMenuAdd = new Button();

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
    private Global.System.Windows.Forms.TabPage _tabCategory;

    internal virtual Global.System.Windows.Forms.TabPage tabCategory
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _tabCategory;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _tabCategory = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblCategoryName;

    internal virtual Global.System.Windows.Forms.Label lblCategoryName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblCategoryName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblCategoryName = value;
        }
    }
    private Global.System.Windows.Forms.Panel _MainCategoryPanel;

    internal virtual Global.System.Windows.Forms.Panel MainCategoryPanel
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _MainCategoryPanel;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _MainCategoryPanel = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblCategoryAbrev;

    internal virtual Global.System.Windows.Forms.Label lblCategoryAbrev
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblCategoryAbrev;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblCategoryAbrev = value;
        }
    }
    private Global.System.Windows.Forms.Panel _ModifierCategoryPanel;

    internal virtual Global.System.Windows.Forms.Panel ModifierCategoryPanel
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _ModifierCategoryPanel;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ModifierCategoryPanel = value;
        }
    }
    private Global.System.Windows.Forms.TabPage _TabModifiers;

    internal virtual Global.System.Windows.Forms.TabPage TabModifiers
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _TabModifiers;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TabModifiers = value;
        }
    }
    private Global.System.Windows.Forms.Label _LblModDescLabel;

    internal virtual Global.System.Windows.Forms.Label LblModDescLabel
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _LblModDescLabel;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _LblModDescLabel = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblSelectModifierFilter;

    internal virtual Global.System.Windows.Forms.Label lblSelectModifierFilter
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblSelectModifierFilter;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblSelectModifierFilter = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxModifierFilter;

    internal virtual Global.System.Windows.Forms.ComboBox cbxModifierFilter
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxModifierFilter;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxModifierFilter = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlUpdateModifiers;

    internal virtual Global.System.Windows.Forms.Panel pnlUpdateModifiers
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlUpdateModifiers;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlUpdateModifiers = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnRemoveModifier;

    internal virtual Global.System.Windows.Forms.Button btnRemoveModifier
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnRemoveModifier;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnRemoveModifier = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtModifierCost;

    internal virtual Global.System.Windows.Forms.TextBox txtModifierCost
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtModifierCost;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtModifierCost = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtModifierName;

    internal virtual Global.System.Windows.Forms.TextBox txtModifierName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtModifierName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtModifierName = value;
        }
    }
    private Global.System.Windows.Forms.TabPage _TabMainFood;

    internal virtual Global.System.Windows.Forms.TabPage TabMainFood
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _TabMainFood;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TabMainFood = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnEnterNewFood;

    internal virtual Global.System.Windows.Forms.Button btnEnterNewFood
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnEnterNewFood;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnEnterNewFood = value;
        }
    }
    private Global.System.Windows.Forms.GroupBox _menuCostGroupBox;

    internal virtual Global.System.Windows.Forms.GroupBox menuCostGroupBox
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _menuCostGroupBox;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _menuCostGroupBox = value;
        }
    }
    private Global.System.Windows.Forms.DataGrid _grdFoodList;

    internal virtual Global.System.Windows.Forms.DataGrid grdFoodList
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _grdFoodList;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _grdFoodList = value;
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
    private Global.System.Windows.Forms.Button _btnRemoveFood;

    internal virtual Global.System.Windows.Forms.Button btnRemoveFood
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnRemoveFood;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnRemoveFood = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxFoodCategory;

    internal virtual Global.System.Windows.Forms.ComboBox cbxFoodCategory
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxFoodCategory;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxFoodCategory = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtFoodName;

    internal virtual Global.System.Windows.Forms.TextBox txtFoodName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtFoodName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtFoodName = value;
        }
    }
    private Global.System.Windows.Forms.TabPage _TabFoodJoin;

    internal virtual Global.System.Windows.Forms.TabPage TabFoodJoin
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _TabFoodJoin;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TabFoodJoin = value;
        }
    }
    private Global.System.Windows.Forms.DataGrid _grdJoinFoodModifierJoins;

    internal virtual Global.System.Windows.Forms.DataGrid grdJoinFoodModifierJoins
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _grdJoinFoodModifierJoins;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _grdJoinFoodModifierJoins = value;
        }
    }
    private Global.System.Windows.Forms.DataGrid _grdJoinFoodChoice;

    internal virtual Global.System.Windows.Forms.DataGrid grdJoinFoodChoice
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _grdJoinFoodChoice;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _grdJoinFoodChoice = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxJoinCategorySelect;

    internal virtual Global.System.Windows.Forms.ComboBox cbxJoinCategorySelect
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxJoinCategorySelect;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxJoinCategorySelect = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblJoinFoodSelected;

    internal virtual Global.System.Windows.Forms.Label lblJoinFoodSelected
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblJoinFoodSelected;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblJoinFoodSelected = value;
        }
    }
    private Global.System.Windows.Forms.DataGrid _grdJoinFoodCategoryJoins;

    internal virtual Global.System.Windows.Forms.DataGrid grdJoinFoodCategoryJoins
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _grdJoinFoodCategoryJoins;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _grdJoinFoodCategoryJoins = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxJoinIndividualModifierSelect;

    internal virtual Global.System.Windows.Forms.ComboBox cbxJoinIndividualModifierSelect
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxJoinIndividualModifierSelect;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxJoinIndividualModifierSelect = value;
        }
    }
    private Global.System.Windows.Forms.DataGrid _grdJoinIndividualModifiers;

    internal virtual Global.System.Windows.Forms.DataGrid grdJoinIndividualModifiers
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _grdJoinIndividualModifiers;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _grdJoinIndividualModifiers = value;
        }
    }
    private Global.System.Windows.Forms.DataGrid _grdJoinPossibleCategories;

    internal virtual Global.System.Windows.Forms.DataGrid grdJoinPossibleCategories
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _grdJoinPossibleCategories;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _grdJoinPossibleCategories = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblSelectFoodFilter;

    internal virtual Global.System.Windows.Forms.Label lblSelectFoodFilter
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblSelectFoodFilter;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblSelectFoodFilter = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnShowAllFood;

    internal virtual Global.System.Windows.Forms.Button btnShowAllFood
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnShowAllFood;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnShowAllFood = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtAbrevFoodName;

    internal virtual Global.System.Windows.Forms.TextBox txtAbrevFoodName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtAbrevFoodName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtAbrevFoodName = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtChitFoodName;

    internal virtual Global.System.Windows.Forms.TextBox txtChitFoodName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtChitFoodName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtChitFoodName = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblFoodName;

    internal virtual Global.System.Windows.Forms.Label lblFoodName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblFoodName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblFoodName = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxPrintPriority;

    internal virtual Global.System.Windows.Forms.ComboBox cbxPrintPriority
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxPrintPriority;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxPrintPriority = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtFoodCost;

    internal virtual Global.System.Windows.Forms.TextBox txtFoodCost
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtFoodCost;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtFoodCost = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnFoodRecipe;

    internal virtual Global.System.Windows.Forms.Button btnFoodRecipe
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnFoodRecipe;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnFoodRecipe = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxFoodFilter;

    internal virtual Global.System.Windows.Forms.ComboBox cbxFoodFilter
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxFoodFilter;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxFoodFilter = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblAbrevFoodName;

    internal virtual Global.System.Windows.Forms.Label lblAbrevFoodName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblAbrevFoodName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblAbrevFoodName = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblChitFoodName;

    internal virtual Global.System.Windows.Forms.Label lblChitFoodName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblChitFoodName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblChitFoodName = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblSelectFoodCategory;

    internal virtual Global.System.Windows.Forms.Label lblSelectFoodCategory
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblSelectFoodCategory;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblSelectFoodCategory = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblPrintPriority;

    internal virtual Global.System.Windows.Forms.Label lblPrintPriority
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblPrintPriority;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblPrintPriority = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblFoodCost;

    internal virtual Global.System.Windows.Forms.Label lblFoodCost
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblFoodCost;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblFoodCost = value;
        }
    }
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
    private Global.System.Windows.Forms.TabPage _TabDrinkCategory;

    internal virtual Global.System.Windows.Forms.TabPage TabDrinkCategory
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _TabDrinkCategory;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TabDrinkCategory = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlDrinkCategory;

    internal virtual Global.System.Windows.Forms.Panel pnlDrinkCategory
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlDrinkCategory;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlDrinkCategory = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtDrinkCategoryName;

    internal virtual Global.System.Windows.Forms.TextBox txtDrinkCategoryName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtDrinkCategoryName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtDrinkCategoryName = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnDrinkCategoryName;

    internal virtual Global.System.Windows.Forms.Button btnDrinkCategoryName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnDrinkCategoryName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnDrinkCategoryName = value;
        }
    }
    private Global.System.Windows.Forms.TabPage _TabDrinks;

    internal virtual Global.System.Windows.Forms.TabPage TabDrinks
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _TabDrinks;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TabDrinks = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlDrinks;

    internal virtual Global.System.Windows.Forms.Panel pnlDrinks
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlDrinks;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlDrinks = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlDrinkByCategory;

    internal virtual Global.System.Windows.Forms.Panel pnlDrinkByCategory
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlDrinkByCategory;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlDrinkByCategory = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblDrinkName;

    internal virtual Global.System.Windows.Forms.Label lblDrinkName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblDrinkName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblDrinkName = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtDrinkName;

    internal virtual Global.System.Windows.Forms.TextBox txtDrinkName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtDrinkName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtDrinkName = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlDrinkUpdate;

    internal virtual Global.System.Windows.Forms.Panel pnlDrinkUpdate
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlDrinkUpdate;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlDrinkUpdate = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnDeleteDrink;

    internal virtual Global.System.Windows.Forms.Button btnDeleteDrink
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnDeleteDrink;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnDeleteDrink = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblDrinkCost;

    internal virtual Global.System.Windows.Forms.Label lblDrinkCost
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblDrinkCost;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblDrinkCost = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblDrinkDescLabel;

    internal virtual Global.System.Windows.Forms.Label lblDrinkDescLabel
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblDrinkDescLabel;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblDrinkDescLabel = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkIsAddOn;

    internal virtual Global.System.Windows.Forms.CheckBox chkIsAddOn
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkIsAddOn;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkIsAddOn = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkSelectAddOn;

    internal virtual Global.System.Windows.Forms.CheckBox chkSelectAddOn
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkSelectAddOn;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkSelectAddOn = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtDrinkPrice;

    internal virtual Global.System.Windows.Forms.TextBox txtDrinkPrice
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtDrinkPrice;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtDrinkPrice = value;
        }
    }
    private Global.System.Windows.Forms.RichTextBox _txtDrinkDesc;

    internal virtual Global.System.Windows.Forms.RichTextBox txtDrinkDesc
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtDrinkDesc;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtDrinkDesc = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblDrinkCategoryName;

    internal virtual Global.System.Windows.Forms.Label lblDrinkCategoryName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblDrinkCategoryName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblDrinkCategoryName = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnBackToCategory;

    internal virtual Global.System.Windows.Forms.Button btnBackToCategory
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnBackToCategory;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnBackToCategory = value;
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
    private Global.System.Windows.Forms.Label _lblCallPrice;

    internal virtual Global.System.Windows.Forms.Label lblCallPrice
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblCallPrice;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblCallPrice = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtCallPrice;

    internal virtual Global.System.Windows.Forms.TextBox txtCallPrice
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtCallPrice;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtCallPrice = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxLiquorType;

    internal virtual Global.System.Windows.Forms.ComboBox cbxLiquorType
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxLiquorType;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxLiquorType = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblCallLiquor;

    internal virtual Global.System.Windows.Forms.Label lblCallLiquor
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblCallLiquor;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblCallLiquor = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtAddOnPrice;

    internal virtual Global.System.Windows.Forms.TextBox txtAddOnPrice
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtAddOnPrice;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtAddOnPrice = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlIsLiquorType;

    internal virtual Global.System.Windows.Forms.Panel pnlIsLiquorType
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlIsLiquorType;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlIsLiquorType = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkLiquorType;

    internal virtual Global.System.Windows.Forms.CheckBox chkLiquorType
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkLiquorType;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkLiquorType = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblIsLiquorType;

    internal virtual Global.System.Windows.Forms.Label lblIsLiquorType
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblIsLiquorType;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblIsLiquorType = value;
        }
    }
    private Global.System.Windows.Forms.TabPage _TabMenuSetup;

    internal virtual Global.System.Windows.Forms.TabPage TabMenuSetup
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _TabMenuSetup;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TabMenuSetup = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxMenuSelection;

    internal virtual Global.System.Windows.Forms.ComboBox cbxMenuSelection
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxMenuSelection;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxMenuSelection = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlMenuPage1;

    internal virtual Global.System.Windows.Forms.Panel pnlMenuPage1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlMenuPage1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlMenuPage1 = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlMenuPage2;

    internal virtual Global.System.Windows.Forms.Panel pnlMenuPage2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlMenuPage2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlMenuPage2 = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxMenuMainFood;

    internal virtual Global.System.Windows.Forms.ComboBox cbxMenuMainFood
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxMenuMainFood;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxMenuMainFood = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxMenuDrink;

    internal virtual Global.System.Windows.Forms.ComboBox cbxMenuDrink
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxMenuDrink;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxMenuDrink = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblMenuSelectButtonText;

    internal virtual Global.System.Windows.Forms.Label lblMenuSelectButtonText
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblMenuSelectButtonText;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblMenuSelectButtonText = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnMenuGeneralDrink;

    internal virtual Global.System.Windows.Forms.Button btnMenuGeneralDrink
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnMenuGeneralDrink;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnMenuGeneralDrink = value;
        }
    }
    private Global.System.Windows.Forms.GroupBox _menuActiveBox;

    internal virtual Global.System.Windows.Forms.GroupBox menuActiveBox
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _menuActiveBox;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _menuActiveBox = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlMenuUpdate;

    internal virtual Global.System.Windows.Forms.Panel pnlMenuUpdate
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlMenuUpdate;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlMenuUpdate = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnRemoveMenuChoices;

    internal virtual Global.System.Windows.Forms.Button btnRemoveMenuChoices
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnRemoveMenuChoices;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnRemoveMenuChoices = value;
        }
    }
    private Global.System.Windows.Forms.Button _BtnUpdateMenuChoices;

    internal virtual Global.System.Windows.Forms.Button BtnUpdateMenuChoices
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _BtnUpdateMenuChoices;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _BtnUpdateMenuChoices = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblMenuPage1;

    internal virtual Global.System.Windows.Forms.Label lblMenuPage1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblMenuPage1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblMenuPage1 = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblMenuPage2;

    internal virtual Global.System.Windows.Forms.Label lblMenuPage2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblMenuPage2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblMenuPage2 = value;
        }
    }
    private Global.System.Windows.Forms.ListBox _lstModifierJoin;

    internal virtual Global.System.Windows.Forms.ListBox lstModifierJoin
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lstModifierJoin;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lstModifierJoin = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlDrinkModifiers;

    internal virtual Global.System.Windows.Forms.Panel pnlDrinkModifiers
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlDrinkModifiers;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlDrinkModifiers = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblDrinkSplash;

    internal virtual Global.System.Windows.Forms.Label lblDrinkSplash
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblDrinkSplash;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblDrinkSplash = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblDrinkTall;

    internal virtual Global.System.Windows.Forms.Label lblDrinkTall
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblDrinkTall;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblDrinkTall = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblDrinkUp;

    internal virtual Global.System.Windows.Forms.Label lblDrinkUp
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblDrinkUp;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblDrinkUp = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblDrinkRocks;

    internal virtual Global.System.Windows.Forms.Label lblDrinkRocks
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblDrinkRocks;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblDrinkRocks = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblDrinkDouble;

    internal virtual Global.System.Windows.Forms.Label lblDrinkDouble
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblDrinkDouble;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblDrinkDouble = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtDrinkRocks;

    internal virtual Global.System.Windows.Forms.TextBox txtDrinkRocks
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtDrinkRocks;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtDrinkRocks = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtDrinkUp;

    internal virtual Global.System.Windows.Forms.TextBox txtDrinkUp
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtDrinkUp;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtDrinkUp = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtDrinkTall;

    internal virtual Global.System.Windows.Forms.TextBox txtDrinkTall
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtDrinkTall;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtDrinkTall = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtDrinkSplash;

    internal virtual Global.System.Windows.Forms.TextBox txtDrinkSplash
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtDrinkSplash;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtDrinkSplash = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtDrinkDouble;

    internal virtual Global.System.Windows.Forms.TextBox txtDrinkDouble
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtDrinkDouble;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtDrinkDouble = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnDrinkPrices;

    internal virtual Global.System.Windows.Forms.Button btnDrinkPrices
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnDrinkPrices;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnDrinkPrices = value;
        }
    }
    private Global.System.Windows.Forms.TabPage _TabFoodOrder;

    internal virtual Global.System.Windows.Forms.TabPage TabFoodOrder
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _TabFoodOrder;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TabFoodOrder = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxOrderMenuSelection;

    internal virtual Global.System.Windows.Forms.ComboBox cbxOrderMenuSelection
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxOrderMenuSelection;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxOrderMenuSelection = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblOrderMenuName;

    internal virtual Global.System.Windows.Forms.Label lblOrderMenuName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblOrderMenuName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblOrderMenuName = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlOrderFoodItems;

    internal virtual Global.System.Windows.Forms.Panel pnlOrderFoodItems
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlOrderFoodItems;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlOrderFoodItems = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlOrderFoodStaging;

    internal virtual Global.System.Windows.Forms.Panel pnlOrderFoodStaging
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlOrderFoodStaging;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlOrderFoodStaging = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxOrderCategorySelection;

    internal virtual Global.System.Windows.Forms.ComboBox cbxOrderCategorySelection
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxOrderCategorySelection;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxOrderCategorySelection = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblOrderCategoryName;

    internal virtual Global.System.Windows.Forms.Label lblOrderCategoryName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblOrderCategoryName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblOrderCategoryName = value;
        }
    }
    private Global.System.Windows.Forms.Panel _Panel4;

    internal virtual Global.System.Windows.Forms.Panel Panel4
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Panel4;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Panel4 = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnOrderUp;

    internal virtual Global.System.Windows.Forms.Button btnOrderUp
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnOrderUp;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnOrderUp = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnOrderDown;

    internal virtual Global.System.Windows.Forms.Button btnOrderDown
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnOrderDown;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnOrderDown = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblOrderDesc1;

    internal virtual Global.System.Windows.Forms.Label lblOrderDesc1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblOrderDesc1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblOrderDesc1 = value;
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
    private Global.System.Windows.Forms.TextBox _txtModifierAbrev;

    internal virtual Global.System.Windows.Forms.TextBox txtModifierAbrev
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtModifierAbrev;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtModifierAbrev = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtModifierChit;

    internal virtual Global.System.Windows.Forms.TextBox txtModifierChit
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtModifierChit;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtModifierChit = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxModifierRouting;

    internal virtual Global.System.Windows.Forms.ComboBox cbxModifierRouting
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxModifierRouting;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxModifierRouting = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtModifierSurcharge;

    internal virtual Global.System.Windows.Forms.TextBox txtModifierSurcharge
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtModifierSurcharge;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtModifierSurcharge = value;
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
    private Global.System.Windows.Forms.Label _lblModifierAbrev;

    internal virtual Global.System.Windows.Forms.Label lblModifierAbrev
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblModifierAbrev;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblModifierAbrev = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblModifierChit;

    internal virtual Global.System.Windows.Forms.Label lblModifierChit
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblModifierChit;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblModifierChit = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblModifierSurcharge;

    internal virtual Global.System.Windows.Forms.Label lblModifierSurcharge
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblModifierSurcharge;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblModifierSurcharge = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblModifierRouting;

    internal virtual Global.System.Windows.Forms.Label lblModifierRouting
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblModifierRouting;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblModifierRouting = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlModifierItems;

    internal virtual Global.System.Windows.Forms.Panel pnlModifierItems
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlModifierItems;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlModifierItems = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlOrderModifierStaging;

    internal virtual Global.System.Windows.Forms.Panel pnlOrderModifierStaging
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlOrderModifierStaging;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlOrderModifierStaging = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnModifierAddPage;

    internal virtual Global.System.Windows.Forms.Button btnModifierAddPage
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnModifierAddPage;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnModifierAddPage = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnJoinFoodRemoveCategory;

    internal virtual Global.System.Windows.Forms.Button btnJoinFoodRemoveCategory
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnJoinFoodRemoveCategory;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnJoinFoodRemoveCategory = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnJoinFoodRemoveIndividual;

    internal virtual Global.System.Windows.Forms.Button btnJoinFoodRemoveIndividual
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnJoinFoodRemoveIndividual;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnJoinFoodRemoveIndividual = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblCategoryMain;

    internal virtual Global.System.Windows.Forms.Label lblCategoryMain
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblCategoryMain;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblCategoryMain = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblCategoryModifiers;

    internal virtual Global.System.Windows.Forms.Label lblCategoryModifiers
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblCategoryModifiers;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblCategoryModifiers = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnMainPrevious;

    internal virtual Global.System.Windows.Forms.Button btnMainPrevious
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnMainPrevious;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnMainPrevious = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnModifierPrevious;

    internal virtual Global.System.Windows.Forms.Button btnModifierPrevious
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnModifierPrevious;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnModifierPrevious = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnMainMore;

    internal virtual Global.System.Windows.Forms.Button btnMainMore
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnMainMore;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnMainMore = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnModifierMore;

    internal virtual Global.System.Windows.Forms.Button btnModifierMore
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnModifierMore;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnModifierMore = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnFoodJoinLink;

    internal virtual Global.System.Windows.Forms.Button btnFoodJoinLink
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnFoodJoinLink;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnFoodJoinLink = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblMenuSetup;

    internal virtual Global.System.Windows.Forms.Label lblMenuSetup
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblMenuSetup;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblMenuSetup = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnModifierRemovePage;

    internal virtual Global.System.Windows.Forms.Button btnModifierRemovePage
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnModifierRemovePage;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnModifierRemovePage = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnOrderAdd;

    internal virtual Global.System.Windows.Forms.Button btnOrderAdd
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnOrderAdd;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnOrderAdd = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnOrderRemove;

    internal virtual Global.System.Windows.Forms.Button btnOrderRemove
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnOrderRemove;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnOrderRemove = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnOrderUpdateStaging;

    internal virtual Global.System.Windows.Forms.Button btnOrderUpdateStaging
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnOrderUpdateStaging;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnOrderUpdateStaging = value;
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
    private Global.System.Windows.Forms.CheckBox _chkWineParring;

    internal virtual Global.System.Windows.Forms.CheckBox chkWineParring
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkWineParring;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkWineParring = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxWineParring;

    internal virtual Global.System.Windows.Forms.ComboBox cbxWineParring
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxWineParring;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxWineParring = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblWineParring;

    internal virtual Global.System.Windows.Forms.Label lblWineParring
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblWineParring;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblWineParring = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnMenuBartender;

    internal virtual Global.System.Windows.Forms.Button btnMenuBartender
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnMenuBartender;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnMenuBartender = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxDrinkFunction;

    internal virtual Global.System.Windows.Forms.ComboBox cbxDrinkFunction
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxDrinkFunction;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxDrinkFunction = value;
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
    private Global.System.Windows.Forms.TextBox _txtRecipe;

    internal virtual Global.System.Windows.Forms.TextBox txtRecipe
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtRecipe;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtRecipe = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnJoinFree;

    internal virtual Global.System.Windows.Forms.Button btnJoinFree
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnJoinFree;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnJoinFree = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtModifierDescription;

    internal virtual Global.System.Windows.Forms.TextBox txtModifierDescription
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtModifierDescription;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtModifierDescription = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnJoinGroup;

    internal virtual Global.System.Windows.Forms.Button btnJoinGroup
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnJoinGroup;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnJoinGroup = value;
        }
    }
    private Global.System.Windows.Forms.Panel _Panel5;

    internal virtual Global.System.Windows.Forms.Panel Panel5
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Panel5;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Panel5 = value;
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
    private Global.System.Windows.Forms.Button _btnJoinGTC;

    internal virtual Global.System.Windows.Forms.Button btnJoinGTC
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnJoinGTC;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnJoinGTC = value;
        }
    }
    private Global.System.Windows.Forms.Panel _Panel6;

    internal virtual Global.System.Windows.Forms.Panel Panel6
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Panel6;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Panel6 = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxCategoryFunction;

    internal virtual Global.System.Windows.Forms.ComboBox cbxCategoryFunction
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxCategoryFunction;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxCategoryFunction = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxCategroyPriority;

    internal virtual Global.System.Windows.Forms.ComboBox cbxCategroyPriority
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxCategroyPriority;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxCategroyPriority = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkCategoryActive;

    internal virtual Global.System.Windows.Forms.CheckBox chkCategoryActive
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkCategoryActive;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkCategoryActive = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnCategoryColor;

    internal virtual Global.System.Windows.Forms.Button btnCategoryColor
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnCategoryColor;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnCategoryColor = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxOrderSubCategroy;

    internal virtual Global.System.Windows.Forms.ComboBox cbxOrderSubCategroy
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxOrderSubCategroy;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxOrderSubCategroy = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnDrinkCategoryColor;

    internal virtual Global.System.Windows.Forms.Button btnDrinkCategoryColor
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnDrinkCategoryColor;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnDrinkCategoryColor = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkHalfSplit;

    internal virtual Global.System.Windows.Forms.CheckBox chkHalfSplit
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkHalfSplit;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkHalfSplit = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlNewFood;

    internal virtual Global.System.Windows.Forms.Panel pnlNewFood
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlNewFood;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlNewFood = value;
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
    private Global.System.Windows.Forms.ComboBox _ComboBox1;

    internal virtual Global.System.Windows.Forms.ComboBox ComboBox1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _ComboBox1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ComboBox1 = value;
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
    private Global.System.Windows.Forms.Label _Label11;

    internal virtual Global.System.Windows.Forms.Label Label11
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label11;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label11 = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label12;

    internal virtual Global.System.Windows.Forms.Label Label12
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label12;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label12 = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label13;

    internal virtual Global.System.Windows.Forms.Label Label13
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label13;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label13 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtNewChitFoodName;

    internal virtual Global.System.Windows.Forms.TextBox txtNewChitFoodName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtNewChitFoodName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtNewChitFoodName = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtNewAbrevFoodName;

    internal virtual Global.System.Windows.Forms.TextBox txtNewAbrevFoodName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtNewAbrevFoodName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtNewAbrevFoodName = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxNewFoodCategory;

    internal virtual Global.System.Windows.Forms.ComboBox cbxNewFoodCategory
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxNewFoodCategory;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxNewFoodCategory = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtNewFoodName;

    internal virtual Global.System.Windows.Forms.TextBox txtNewFoodName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtNewFoodName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtNewFoodName = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnNewFoodAccept;

    internal virtual Global.System.Windows.Forms.Button btnNewFoodAccept
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnNewFoodAccept;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnNewFoodAccept = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnNewFoodCancel;

    internal virtual Global.System.Windows.Forms.Button btnNewFoodCancel
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnNewFoodCancel;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnNewFoodCancel = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label14;

    internal virtual Global.System.Windows.Forms.Label Label14
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label14;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label14 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtNewFoodPrepare;

    internal virtual Global.System.Windows.Forms.TextBox txtNewFoodPrepare
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtNewFoodPrepare;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtNewFoodPrepare = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label15;

    internal virtual Global.System.Windows.Forms.Label Label15
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label15;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label15 = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label16;

    internal virtual Global.System.Windows.Forms.Label Label16
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label16;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label16 = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnNewCategoryAccept;

    internal virtual Global.System.Windows.Forms.Button btnNewCategoryAccept
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnNewCategoryAccept;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnNewCategoryAccept = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnNewCategoryCancel;

    internal virtual Global.System.Windows.Forms.Button btnNewCategoryCancel
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnNewCategoryCancel;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnNewCategoryCancel = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtCategoryName;

    internal virtual Global.System.Windows.Forms.TextBox txtCategoryName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtCategoryName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtCategoryName = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtCategoryAbrev;

    internal virtual Global.System.Windows.Forms.TextBox txtCategoryAbrev
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtCategoryAbrev;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtCategoryAbrev = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlNewCategory;

    internal virtual Global.System.Windows.Forms.Panel pnlNewCategory
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlNewCategory;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlNewCategory = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkNewHalfSplit;

    internal virtual Global.System.Windows.Forms.CheckBox chkNewHalfSplit
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkNewHalfSplit;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkNewHalfSplit = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnNewCategoryColor;

    internal virtual Global.System.Windows.Forms.Button btnNewCategoryColor
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnNewCategoryColor;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnNewCategoryColor = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxNewCategroyPriority;

    internal virtual Global.System.Windows.Forms.ComboBox cbxNewCategroyPriority
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxNewCategroyPriority;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxNewCategroyPriority = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxNewCategoryFunction;

    internal virtual Global.System.Windows.Forms.ComboBox cbxNewCategoryFunction
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxNewCategoryFunction;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxNewCategoryFunction = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtNewCategoryAbrev;

    internal virtual Global.System.Windows.Forms.TextBox txtNewCategoryAbrev
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtNewCategoryAbrev;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtNewCategoryAbrev = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtNewCategoryName;

    internal virtual Global.System.Windows.Forms.TextBox txtNewCategoryName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtNewCategoryName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtNewCategoryName = value;
        }
    }
    private Global.System.Windows.Forms.Panel _Panel7;

    internal virtual Global.System.Windows.Forms.Panel Panel7
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Panel7;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Panel7 = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label17;

    internal virtual Global.System.Windows.Forms.Label Label17
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label17;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label17 = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label18;

    internal virtual Global.System.Windows.Forms.Label Label18
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label18;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label18 = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label19;

    internal virtual Global.System.Windows.Forms.Label Label19
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label19;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label19 = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label20;

    internal virtual Global.System.Windows.Forms.Label Label20
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label20;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label20 = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label21;

    internal virtual Global.System.Windows.Forms.Label Label21
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label21;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label21 = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label22;

    internal virtual Global.System.Windows.Forms.Label Label22
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label22;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label22 = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label23;

    internal virtual Global.System.Windows.Forms.Label Label23
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label23;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label23 = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label24;

    internal virtual Global.System.Windows.Forms.Label Label24
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label24;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label24 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtNewModifierSurcharge;

    internal virtual Global.System.Windows.Forms.TextBox txtNewModifierSurcharge
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtNewModifierSurcharge;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtNewModifierSurcharge = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtNewModifierChit;

    internal virtual Global.System.Windows.Forms.TextBox txtNewModifierChit
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtNewModifierChit;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtNewModifierChit = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtNewModifierAbrev;

    internal virtual Global.System.Windows.Forms.TextBox txtNewModifierAbrev
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtNewModifierAbrev;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtNewModifierAbrev = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtNewModifierName;

    internal virtual Global.System.Windows.Forms.TextBox txtNewModifierName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtNewModifierName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtNewModifierName = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxNewModifierRouting;

    internal virtual Global.System.Windows.Forms.ComboBox cbxNewModifierRouting
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxNewModifierRouting;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbxNewModifierRouting = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtNewModifierDescription;

    internal virtual Global.System.Windows.Forms.TextBox txtNewModifierDescription
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtNewModifierDescription;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtNewModifierDescription = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtNewModifierCost;

    internal virtual Global.System.Windows.Forms.TextBox txtNewModifierCost
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtNewModifierCost;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtNewModifierCost = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnAcceptModifier;

    internal virtual Global.System.Windows.Forms.Button btnAcceptModifier
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnAcceptModifier;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnAcceptModifier = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnCancelModifier;

    internal virtual Global.System.Windows.Forms.Button btnCancelModifier
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnCancelModifier;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnCancelModifier = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlNewModifier;

    internal virtual Global.System.Windows.Forms.Panel pnlNewModifier
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlNewModifier;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlNewModifier = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnModCancelNew;

    internal virtual Global.System.Windows.Forms.Button btnModCancelNew
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnModCancelNew;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnModCancelNew = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkManual;

    internal virtual Global.System.Windows.Forms.CheckBox chkManual
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkManual;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkManual = value;
        }
    }
    private Global.System.Windows.Forms.TabPage _TabDrinkPrep;

    internal virtual Global.System.Windows.Forms.TabPage TabDrinkPrep
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _TabDrinkPrep;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TabDrinkPrep = value;
        }
    }
    private Global.System.Windows.Forms.Label _Label25;

    internal virtual Global.System.Windows.Forms.Label Label25
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Label25;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label25 = value;
        }
    }

    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        _tabCategory = new System.Windows.Forms.TabPage();
        _Label29 = new System.Windows.Forms.Label();
        _Label28 = new System.Windows.Forms.Label();
        _pnlNewCategory = new System.Windows.Forms.Panel();
        _chkNewDisplayWithAdds = new System.Windows.Forms.CheckBox();
        _chkNewExtendedDisplay = new System.Windows.Forms.CheckBox();
        _btnNewCategoryCancel = new System.Windows.Forms.Button();
        _btnNewCategoryAccept = new System.Windows.Forms.Button();
        _chkNewHalfSplit = new System.Windows.Forms.CheckBox();
        _btnNewCategoryColor = new System.Windows.Forms.Button();
        _cbxNewCategroyPriority = new System.Windows.Forms.ComboBox();
        _cbxNewCategoryFunction = new System.Windows.Forms.ComboBox();
        _txtNewCategoryAbrev = new System.Windows.Forms.TextBox();
        _Label15 = new System.Windows.Forms.Label();
        _Label16 = new System.Windows.Forms.Label();
        _txtNewCategoryName = new System.Windows.Forms.TextBox();
        _Panel6 = new System.Windows.Forms.Panel();
        _chkDisplayWithAdd = new System.Windows.Forms.CheckBox();
        _chkExtendedDisplay = new System.Windows.Forms.CheckBox();
        _chkHalfSplit = new System.Windows.Forms.CheckBox();
        _btnCategoryColor = new System.Windows.Forms.Button();
        _chkCategoryActive = new System.Windows.Forms.CheckBox();
        _cbxCategroyPriority = new System.Windows.Forms.ComboBox();
        _cbxCategoryFunction = new System.Windows.Forms.ComboBox();
        _txtCategoryAbrev = new System.Windows.Forms.TextBox();
        _lblCategoryAbrev = new System.Windows.Forms.Label();
        _lblCategoryName = new System.Windows.Forms.Label();
        _txtCategoryName = new System.Windows.Forms.TextBox();
        _btnModifierMore = new System.Windows.Forms.Button();
        _btnMainMore = new System.Windows.Forms.Button();
        _btnModifierPrevious = new System.Windows.Forms.Button();
        _btnMainPrevious = new System.Windows.Forms.Button();
        _lblCategoryModifiers = new System.Windows.Forms.Label();
        _lblCategoryMain = new System.Windows.Forms.Label();
        _MainCategoryPanel = new System.Windows.Forms.Panel();
        _ModifierCategoryPanel = new System.Windows.Forms.Panel();
        _TabModifiers = new System.Windows.Forms.TabPage();
        _pnlModifierPage = new System.Windows.Forms.Panel();
        _btnModifierAddPage = new System.Windows.Forms.Button();
        _btnModifierRemovePage = new System.Windows.Forms.Button();
        _pnlNewModifier = new System.Windows.Forms.Panel();
        _btnCancelModifier = new System.Windows.Forms.Button();
        _btnAcceptModifier = new System.Windows.Forms.Button();
        _Label17 = new System.Windows.Forms.Label();
        _Label18 = new System.Windows.Forms.Label();
        _Label19 = new System.Windows.Forms.Label();
        _txtNewModifierSurcharge = new System.Windows.Forms.TextBox();
        _txtNewModifierChit = new System.Windows.Forms.TextBox();
        _txtNewModifierAbrev = new System.Windows.Forms.TextBox();
        _Label20 = new System.Windows.Forms.Label();
        _Label21 = new System.Windows.Forms.Label();
        _txtNewModifierName = new System.Windows.Forms.TextBox();
        _Label22 = new System.Windows.Forms.Label();
        _cbxNewModifierRouting = new System.Windows.Forms.ComboBox();
        _Label23 = new System.Windows.Forms.Label();
        _txtNewModifierDescription = new System.Windows.Forms.TextBox();
        _txtNewModifierCost = new System.Windows.Forms.TextBox();
        _Label24 = new System.Windows.Forms.Label();
        _Panel7 = new System.Windows.Forms.Panel();
        _btnModCancelNew = new System.Windows.Forms.Button();
        _lblModifierSurcharge = new System.Windows.Forms.Label();
        _lblModifierChit = new System.Windows.Forms.Label();
        _lblModifierAbrev = new System.Windows.Forms.Label();
        _txtModifierSurcharge = new System.Windows.Forms.TextBox();
        _txtModifierChit = new System.Windows.Forms.TextBox();
        _txtModifierAbrev = new System.Windows.Forms.TextBox();
        _Label1 = new System.Windows.Forms.Label();
        _lblSelectModifierFilter = new System.Windows.Forms.Label();
        _txtModifierName = new System.Windows.Forms.TextBox();
        _Label2 = new System.Windows.Forms.Label();
        _cbxModifierRouting = new System.Windows.Forms.ComboBox();
        _LblModDescLabel = new System.Windows.Forms.Label();
        _txtModifierDescription = new System.Windows.Forms.TextBox();
        _txtModifierCost = new System.Windows.Forms.TextBox();
        _lblModifierRouting = new System.Windows.Forms.Label();
        _pnlOrderModifierStaging = new System.Windows.Forms.Panel();
        _pnlModifierItems = new System.Windows.Forms.Panel();
        _cbxModifierFilter = new System.Windows.Forms.ComboBox();
        _pnlUpdateModifiers = new System.Windows.Forms.Panel();
        _btnRemoveModifier = new System.Windows.Forms.Button();
        _TabMainFood = new System.Windows.Forms.TabPage();
        _cbxFoodFilterModifiers = new System.Windows.Forms.ComboBox();
        _btnFoodRecipe = new System.Windows.Forms.Button();
        _Panel1 = new System.Windows.Forms.Panel();
        _txtFoodInvMultiplier = new System.Windows.Forms.TextBox();
        _Label27 = new System.Windows.Forms.Label();
        _txtFoodCost = new System.Windows.Forms.TextBox();
        _lblFoodCost = new System.Windows.Forms.Label();
        _chkManual = new System.Windows.Forms.CheckBox();
        _pnlNewFood = new System.Windows.Forms.Panel();
        _Label14 = new System.Windows.Forms.Label();
        _txtNewFoodPrepare = new System.Windows.Forms.TextBox();
        _btnNewFoodCancel = new System.Windows.Forms.Button();
        _btnNewFoodAccept = new System.Windows.Forms.Button();
        _Label9 = new System.Windows.Forms.Label();
        _ComboBox1 = new System.Windows.Forms.ComboBox();
        _Label10 = new System.Windows.Forms.Label();
        _Label11 = new System.Windows.Forms.Label();
        _Label12 = new System.Windows.Forms.Label();
        _Label13 = new System.Windows.Forms.Label();
        _txtNewChitFoodName = new System.Windows.Forms.TextBox();
        _txtNewAbrevFoodName = new System.Windows.Forms.TextBox();
        _cbxNewFoodCategory = new System.Windows.Forms.ComboBox();
        _txtNewFoodName = new System.Windows.Forms.TextBox();
        _txtRecipe = new System.Windows.Forms.TextBox();
        _lblWineParring = new System.Windows.Forms.Label();
        _cbxWineParring = new System.Windows.Forms.ComboBox();
        _lstModifierJoin = new System.Windows.Forms.ListBox();
        _lblPrintPriority = new System.Windows.Forms.Label();
        _lblSelectFoodCategory = new System.Windows.Forms.Label();
        _lblChitFoodName = new System.Windows.Forms.Label();
        _lblAbrevFoodName = new System.Windows.Forms.Label();
        _cbxPrintPriority = new System.Windows.Forms.ComboBox();
        _lblFoodName = new System.Windows.Forms.Label();
        _txtChitFoodName = new System.Windows.Forms.TextBox();
        _txtAbrevFoodName = new System.Windows.Forms.TextBox();
        _btnShowAllFood = new System.Windows.Forms.Button();
        _cbxFoodFilter = new System.Windows.Forms.ComboBox();
        _lblSelectFoodFilter = new System.Windows.Forms.Label();
        _btnFoodJoinLink = new System.Windows.Forms.Button();
        _btnEnterNewFood = new System.Windows.Forms.Button();
        _menuCostGroupBox = new System.Windows.Forms.GroupBox();
        _grdFoodList = new System.Windows.Forms.DataGrid();
        _Panel2 = new System.Windows.Forms.Panel();
        _btnRemoveFood = new System.Windows.Forms.Button();
        _cbxFoodCategory = new System.Windows.Forms.ComboBox();
        _txtFoodName = new System.Windows.Forms.TextBox();
        _TabFoodJoin = new System.Windows.Forms.TabPage();
        _btnJoinReq = new System.Windows.Forms.Button();
        _btnJoinGTC = new System.Windows.Forms.Button();
        _Panel5 = new System.Windows.Forms.Panel();
        _Label26 = new System.Windows.Forms.Label();
        _Label8 = new System.Windows.Forms.Label();
        _Label7 = new System.Windows.Forms.Label();
        _Label6 = new System.Windows.Forms.Label();
        _Label5 = new System.Windows.Forms.Label();
        _Label4 = new System.Windows.Forms.Label();
        _btnJoinGroup = new System.Windows.Forms.Button();
        _btnJoinFoodRemoveIndividual = new System.Windows.Forms.Button();
        _btnJoinFoodRemoveCategory = new System.Windows.Forms.Button();
        _grdJoinFoodModifierJoins = new System.Windows.Forms.DataGrid();
        _btnJoinFree = new System.Windows.Forms.Button();
        _grdJoinFoodChoice = new System.Windows.Forms.DataGrid();
        _cbxJoinCategorySelect = new System.Windows.Forms.ComboBox();
        _lblJoinFoodSelected = new System.Windows.Forms.Label();
        _grdJoinFoodCategoryJoins = new System.Windows.Forms.DataGrid();
        _cbxJoinIndividualModifierSelect = new System.Windows.Forms.ComboBox();
        _grdJoinIndividualModifiers = new System.Windows.Forms.DataGrid();
        _grdJoinPossibleCategories = new System.Windows.Forms.DataGrid();
        _TabControl1 = new System.Windows.Forms.TabControl();
        _TabDrinkCategory = new System.Windows.Forms.TabPage();
        _Label30 = new System.Windows.Forms.Label();
        _btnDrinkCategoryColor = new System.Windows.Forms.Button();
        _pnlDrinkModifiers = new System.Windows.Forms.Panel();
        _btnDrinkPrices = new System.Windows.Forms.Button();
        _txtDrinkSplash = new System.Windows.Forms.TextBox();
        _txtDrinkTall = new System.Windows.Forms.TextBox();
        _txtDrinkUp = new System.Windows.Forms.TextBox();
        _txtDrinkRocks = new System.Windows.Forms.TextBox();
        _txtDrinkDouble = new System.Windows.Forms.TextBox();
        _lblDrinkSplash = new System.Windows.Forms.Label();
        _lblDrinkTall = new System.Windows.Forms.Label();
        _lblDrinkUp = new System.Windows.Forms.Label();
        _lblDrinkRocks = new System.Windows.Forms.Label();
        _lblDrinkDouble = new System.Windows.Forms.Label();
        _pnlIsLiquorType = new System.Windows.Forms.Panel();
        _lblIsLiquorType = new System.Windows.Forms.Label();
        _chkLiquorType = new System.Windows.Forms.CheckBox();
        _lblDrinkCategoryName = new System.Windows.Forms.Label();
        _btnDrinkCategoryName = new System.Windows.Forms.Button();
        _txtDrinkCategoryName = new System.Windows.Forms.TextBox();
        _pnlDrinkCategory = new System.Windows.Forms.Panel();
        _TabDrinks = new System.Windows.Forms.TabPage();
        _lblDrinkHappyPrice = new System.Windows.Forms.Label();
        _txtDrinkHappyPrice = new System.Windows.Forms.TextBox();
        _Label3 = new System.Windows.Forms.Label();
        _cbxDrinkFunction = new System.Windows.Forms.ComboBox();
        _chkWineParring = new System.Windows.Forms.CheckBox();
        _txtAddOnPrice = new System.Windows.Forms.TextBox();
        _Panel3 = new System.Windows.Forms.Panel();
        _lblCallLiquor = new System.Windows.Forms.Label();
        _cbxLiquorType = new System.Windows.Forms.ComboBox();
        _txtCallPrice = new System.Windows.Forms.TextBox();
        _lblCallPrice = new System.Windows.Forms.Label();
        _btnBackToCategory = new System.Windows.Forms.Button();
        _txtDrinkDesc = new System.Windows.Forms.RichTextBox();
        _chkIsAddOn = new System.Windows.Forms.CheckBox();
        _chkSelectAddOn = new System.Windows.Forms.CheckBox();
        _lblDrinkDescLabel = new System.Windows.Forms.Label();
        _lblDrinkCost = new System.Windows.Forms.Label();
        _txtDrinkPrice = new System.Windows.Forms.TextBox();
        _txtDrinkName = new System.Windows.Forms.TextBox();
        _lblDrinkName = new System.Windows.Forms.Label();
        _pnlDrinks = new System.Windows.Forms.Panel();
        _pnlDrinkByCategory = new System.Windows.Forms.Panel();
        _TabDrinkPrep = new System.Windows.Forms.TabPage();
        _Label25 = new System.Windows.Forms.Label();
        _TabMenuSetup = new System.Windows.Forms.TabPage();
        _btnMenuBartender = new System.Windows.Forms.Button();
        _lblMenuSetup = new System.Windows.Forms.Label();
        _lblMenuPage2 = new System.Windows.Forms.Label();
        _lblMenuPage1 = new System.Windows.Forms.Label();
        _pnlMenuUpdate = new System.Windows.Forms.Panel();
        _btnRemoveMenuChoices = new System.Windows.Forms.Button();
        _BtnUpdateMenuChoices = new System.Windows.Forms.Button();
        _menuActiveBox = new System.Windows.Forms.GroupBox();
        _btnMenuGeneralDrink = new System.Windows.Forms.Button();
        _lblMenuSelectButtonText = new System.Windows.Forms.Label();
        _cbxMenuDrink = new System.Windows.Forms.ComboBox();
        _cbxMenuMainFood = new System.Windows.Forms.ComboBox();
        _pnlMenuPage2 = new System.Windows.Forms.Panel();
        _pnlMenuPage1 = new System.Windows.Forms.Panel();
        _cbxMenuSelection = new System.Windows.Forms.ComboBox();
        _TabFoodOrder = new System.Windows.Forms.TabPage();
        _pnlOrderPage = new System.Windows.Forms.Panel();
        _btnOrderAdd = new System.Windows.Forms.Button();
        _btnOrderRemove = new System.Windows.Forms.Button();
        _cbxOrderSubCategroy = new System.Windows.Forms.ComboBox();
        _lblOrderDesc1 = new System.Windows.Forms.Label();
        _btnOrderDown = new System.Windows.Forms.Button();
        _btnOrderUp = new System.Windows.Forms.Button();
        _Panel4 = new System.Windows.Forms.Panel();
        _btnOrderUpdateStaging = new System.Windows.Forms.Button();
        _lblOrderCategoryName = new System.Windows.Forms.Label();
        _cbxOrderCategorySelection = new System.Windows.Forms.ComboBox();
        _pnlOrderFoodStaging = new System.Windows.Forms.Panel();
        _pnlOrderFoodItems = new System.Windows.Forms.Panel();
        _lblOrderMenuName = new System.Windows.Forms.Label();
        _cbxOrderMenuSelection = new System.Windows.Forms.ComboBox();
        _pnlDrinkUpdate = new System.Windows.Forms.Panel();
        _btnDeleteDrink = new System.Windows.Forms.Button();
        _ErrorProvider1 = new System.Windows.Forms.ErrorProvider(components);
        _tabCategory.SuspendLayout();
        _pnlNewCategory.SuspendLayout();
        _Panel6.SuspendLayout();
        _TabModifiers.SuspendLayout();
        _pnlModifierPage.SuspendLayout();
        _pnlNewModifier.SuspendLayout();
        _Panel7.SuspendLayout();
        _pnlUpdateModifiers.SuspendLayout();
        _TabMainFood.SuspendLayout();
        _Panel1.SuspendLayout();
        _pnlNewFood.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_grdFoodList).BeginInit();
        _Panel2.SuspendLayout();
        _TabFoodJoin.SuspendLayout();
        _Panel5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_grdJoinFoodModifierJoins).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_grdJoinFoodChoice).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_grdJoinFoodCategoryJoins).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_grdJoinIndividualModifiers).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_grdJoinPossibleCategories).BeginInit();
        _TabControl1.SuspendLayout();
        _TabDrinkCategory.SuspendLayout();
        _pnlDrinkModifiers.SuspendLayout();
        _pnlIsLiquorType.SuspendLayout();
        _TabDrinks.SuspendLayout();
        _Panel3.SuspendLayout();
        _TabDrinkPrep.SuspendLayout();
        _TabMenuSetup.SuspendLayout();
        _pnlMenuUpdate.SuspendLayout();
        _TabFoodOrder.SuspendLayout();
        _pnlOrderPage.SuspendLayout();
        _Panel4.SuspendLayout();
        _pnlDrinkUpdate.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_ErrorProvider1).BeginInit();
        this.SuspendLayout();
        // 
        // tabCategory
        // 
        _tabCategory.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _tabCategory.Controls.Add(_Label29);
        _tabCategory.Controls.Add(_Label28);
        _tabCategory.Controls.Add(_pnlNewCategory);
        _tabCategory.Controls.Add(_Panel6);
        _tabCategory.Controls.Add(_btnModifierMore);
        _tabCategory.Controls.Add(_btnMainMore);
        _tabCategory.Controls.Add(_btnModifierPrevious);
        _tabCategory.Controls.Add(_btnMainPrevious);
        _tabCategory.Controls.Add(_lblCategoryModifiers);
        _tabCategory.Controls.Add(_lblCategoryMain);
        _tabCategory.Controls.Add(_MainCategoryPanel);
        _tabCategory.Controls.Add(_ModifierCategoryPanel);
        _tabCategory.Location = new System.Drawing.Point(4, 22);
        _tabCategory.Name = "_tabCategory";
        _tabCategory.Size = new System.Drawing.Size(840, 550);
        _tabCategory.TabIndex = 0;
        _tabCategory.Text = "Category";
        // 
        // Label29
        // 
        _Label29.Location = new System.Drawing.Point(517, 50);
        _Label29.Name = "_Label29";
        _Label29.Size = new System.Drawing.Size(157, 70);
        _Label29.TabIndex = 29;
        _Label29.Text = "Only place items that are the same for every menu and will never have a modifier " + "to them. For example temperature and kitchen commands.";
        // 
        // Label28
        // 
        _Label28.Location = new System.Drawing.Point(333, 51);
        _Label28.Name = "_Label28";
        _Label28.Size = new System.Drawing.Size(140, 44);
        _Label28.TabIndex = 28;
        _Label28.Text = "General Menu is a Shell Category. Main Food Items is to distinguish Covers.";
        // 
        // pnlNewCategory
        // 
        _pnlNewCategory.BackColor = System.Drawing.Color.Moccasin;
        _pnlNewCategory.Controls.Add(_chkNewDisplayWithAdds);
        _pnlNewCategory.Controls.Add(_chkNewExtendedDisplay);
        _pnlNewCategory.Controls.Add(_btnNewCategoryCancel);
        _pnlNewCategory.Controls.Add(_btnNewCategoryAccept);
        _pnlNewCategory.Controls.Add(_chkNewHalfSplit);
        _pnlNewCategory.Controls.Add(_btnNewCategoryColor);
        _pnlNewCategory.Controls.Add(_cbxNewCategroyPriority);
        _pnlNewCategory.Controls.Add(_cbxNewCategoryFunction);
        _pnlNewCategory.Controls.Add(_txtNewCategoryAbrev);
        _pnlNewCategory.Controls.Add(_Label15);
        _pnlNewCategory.Controls.Add(_Label16);
        _pnlNewCategory.Controls.Add(_txtNewCategoryName);
        _pnlNewCategory.Location = new System.Drawing.Point(654, 134);
        _pnlNewCategory.Name = "_pnlNewCategory";
        _pnlNewCategory.Size = new System.Drawing.Size(256, 344);
        _pnlNewCategory.TabIndex = 27;
        _pnlNewCategory.Visible = false;
        // 
        // chkNewDisplayWithAdds
        // 
        _chkNewDisplayWithAdds.Location = new System.Drawing.Point(16, 258);
        _chkNewDisplayWithAdds.Name = "_chkNewDisplayWithAdds";
        _chkNewDisplayWithAdds.Size = new System.Drawing.Size(133, 24);
        _chkNewDisplayWithAdds.TabIndex = 34;
        _chkNewDisplayWithAdds.Text = "Display With Add / No";
        // 
        // chkNewExtendedDisplay
        // 
        _chkNewExtendedDisplay.Location = new System.Drawing.Point(16, 230);
        _chkNewExtendedDisplay.Name = "_chkNewExtendedDisplay";
        _chkNewExtendedDisplay.Size = new System.Drawing.Size(104, 24);
        _chkNewExtendedDisplay.TabIndex = 33;
        _chkNewExtendedDisplay.Text = "Extended Display";
        // 
        // btnNewCategoryCancel
        // 
        _btnNewCategoryCancel.Location = new System.Drawing.Point(144, 288);
        _btnNewCategoryCancel.Name = "_btnNewCategoryCancel";
        _btnNewCategoryCancel.Size = new System.Drawing.Size(80, 40);
        _btnNewCategoryCancel.TabIndex = 32;
        _btnNewCategoryCancel.Text = "Cancel";
        // 
        // btnNewCategoryAccept
        // 
        _btnNewCategoryAccept.Location = new System.Drawing.Point(32, 288);
        _btnNewCategoryAccept.Name = "_btnNewCategoryAccept";
        _btnNewCategoryAccept.Size = new System.Drawing.Size(80, 40);
        _btnNewCategoryAccept.TabIndex = 31;
        _btnNewCategoryAccept.Text = "New Category";
        // 
        // chkNewHalfSplit
        // 
        _chkNewHalfSplit.Location = new System.Drawing.Point(16, 200);
        _chkNewHalfSplit.Name = "_chkNewHalfSplit";
        _chkNewHalfSplit.Size = new System.Drawing.Size(104, 24);
        _chkNewHalfSplit.TabIndex = 30;
        _chkNewHalfSplit.Text = "Half Splits";
        // 
        // btnNewCategoryColor
        // 
        _btnNewCategoryColor.BackColor = System.Drawing.Color.CornflowerBlue;
        _btnNewCategoryColor.Location = new System.Drawing.Point(144, 192);
        _btnNewCategoryColor.Name = "_btnNewCategoryColor";
        _btnNewCategoryColor.Size = new System.Drawing.Size(88, 32);
        _btnNewCategoryColor.TabIndex = 29;
        _btnNewCategoryColor.Text = "Button Color";
        _btnNewCategoryColor.UseVisualStyleBackColor = false;
        // 
        // cbxNewCategroyPriority
        // 
        _cbxNewCategroyPriority.Location = new System.Drawing.Point(16, 160);
        _cbxNewCategroyPriority.Name = "_cbxNewCategroyPriority";
        _cbxNewCategroyPriority.Size = new System.Drawing.Size(121, 21);
        _cbxNewCategroyPriority.TabIndex = 27;
        // 
        // cbxNewCategoryFunction
        // 
        _cbxNewCategoryFunction.Location = new System.Drawing.Point(16, 120);
        _cbxNewCategoryFunction.Name = "_cbxNewCategoryFunction";
        _cbxNewCategoryFunction.Size = new System.Drawing.Size(208, 21);
        _cbxNewCategoryFunction.TabIndex = 26;
        // 
        // txtNewCategoryAbrev
        // 
        _txtNewCategoryAbrev.Location = new System.Drawing.Point(16, 72);
        _txtNewCategoryAbrev.Name = "_txtNewCategoryAbrev";
        _txtNewCategoryAbrev.Size = new System.Drawing.Size(208, 20);
        _txtNewCategoryAbrev.TabIndex = 1;
        // 
        // Label15
        // 
        _Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label15.Location = new System.Drawing.Point(8, 56);
        _Label15.Name = "_Label15";
        _Label15.Size = new System.Drawing.Size(216, 16);
        _Label15.TabIndex = 9;
        _Label15.Text = "Category Abreviation";
        // 
        // Label16
        // 
        _Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label16.Location = new System.Drawing.Point(8, 8);
        _Label16.Name = "_Label16";
        _Label16.Size = new System.Drawing.Size(208, 16);
        _Label16.TabIndex = 8;
        _Label16.Text = "Category Name";
        // 
        // txtNewCategoryName
        // 
        _txtNewCategoryName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        _txtNewCategoryName.Location = new System.Drawing.Point(16, 24);
        _txtNewCategoryName.Name = "_txtNewCategoryName";
        _txtNewCategoryName.Size = new System.Drawing.Size(208, 20);
        _txtNewCategoryName.TabIndex = 0;
        // 
        // Panel6
        // 
        _Panel6.BackColor = System.Drawing.Color.Moccasin;
        _Panel6.Controls.Add(_chkDisplayWithAdd);
        _Panel6.Controls.Add(_chkExtendedDisplay);
        _Panel6.Controls.Add(_chkHalfSplit);
        _Panel6.Controls.Add(_btnCategoryColor);
        _Panel6.Controls.Add(_chkCategoryActive);
        _Panel6.Controls.Add(_cbxCategroyPriority);
        _Panel6.Controls.Add(_cbxCategoryFunction);
        _Panel6.Controls.Add(_txtCategoryAbrev);
        _Panel6.Controls.Add(_lblCategoryAbrev);
        _Panel6.Controls.Add(_lblCategoryName);
        _Panel6.Controls.Add(_txtCategoryName);
        _Panel6.Location = new System.Drawing.Point(32, 40);
        _Panel6.Name = "_Panel6";
        _Panel6.Size = new System.Drawing.Size(256, 344);
        _Panel6.TabIndex = 26;
        // 
        // chkDisplayWithAdd
        // 
        _chkDisplayWithAdd.Location = new System.Drawing.Point(16, 294);
        _chkDisplayWithAdd.Name = "_chkDisplayWithAdd";
        _chkDisplayWithAdd.Size = new System.Drawing.Size(133, 24);
        _chkDisplayWithAdd.TabIndex = 32;
        _chkDisplayWithAdd.Text = "Display With Add / No";
        // 
        // chkExtendedDisplay
        // 
        _chkExtendedDisplay.Location = new System.Drawing.Point(16, 262);
        _chkExtendedDisplay.Name = "_chkExtendedDisplay";
        _chkExtendedDisplay.Size = new System.Drawing.Size(133, 24);
        _chkExtendedDisplay.TabIndex = 31;
        _chkExtendedDisplay.Text = "Extended Display";
        // 
        // chkHalfSplit
        // 
        _chkHalfSplit.Location = new System.Drawing.Point(16, 200);
        _chkHalfSplit.Name = "_chkHalfSplit";
        _chkHalfSplit.Size = new System.Drawing.Size(104, 24);
        _chkHalfSplit.TabIndex = 30;
        _chkHalfSplit.Text = "Half Splits";
        // 
        // btnCategoryColor
        // 
        _btnCategoryColor.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _btnCategoryColor.ForeColor = System.Drawing.Color.White;
        _btnCategoryColor.Location = new System.Drawing.Point(144, 192);
        _btnCategoryColor.Name = "_btnCategoryColor";
        _btnCategoryColor.Size = new System.Drawing.Size(88, 32);
        _btnCategoryColor.TabIndex = 29;
        _btnCategoryColor.Text = "Button Color";
        _btnCategoryColor.UseVisualStyleBackColor = false;
        // 
        // chkCategoryActive
        // 
        _chkCategoryActive.Location = new System.Drawing.Point(16, 232);
        _chkCategoryActive.Name = "_chkCategoryActive";
        _chkCategoryActive.Size = new System.Drawing.Size(104, 24);
        _chkCategoryActive.TabIndex = 28;
        _chkCategoryActive.Text = "Active";
        // 
        // cbxCategroyPriority
        // 
        _cbxCategroyPriority.Location = new System.Drawing.Point(16, 160);
        _cbxCategroyPriority.Name = "_cbxCategroyPriority";
        _cbxCategroyPriority.Size = new System.Drawing.Size(121, 21);
        _cbxCategroyPriority.TabIndex = 27;
        // 
        // cbxCategoryFunction
        // 
        _cbxCategoryFunction.Location = new System.Drawing.Point(16, 120);
        _cbxCategoryFunction.Name = "_cbxCategoryFunction";
        _cbxCategoryFunction.Size = new System.Drawing.Size(208, 21);
        _cbxCategoryFunction.TabIndex = 26;
        // 
        // txtCategoryAbrev
        // 
        _txtCategoryAbrev.Location = new System.Drawing.Point(16, 72);
        _txtCategoryAbrev.Name = "_txtCategoryAbrev";
        _txtCategoryAbrev.Size = new System.Drawing.Size(208, 20);
        _txtCategoryAbrev.TabIndex = 1;
        // 
        // lblCategoryAbrev
        // 
        _lblCategoryAbrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblCategoryAbrev.Location = new System.Drawing.Point(8, 56);
        _lblCategoryAbrev.Name = "_lblCategoryAbrev";
        _lblCategoryAbrev.Size = new System.Drawing.Size(216, 16);
        _lblCategoryAbrev.TabIndex = 9;
        _lblCategoryAbrev.Text = "Category Abreviation";
        // 
        // lblCategoryName
        // 
        _lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblCategoryName.Location = new System.Drawing.Point(8, 8);
        _lblCategoryName.Name = "_lblCategoryName";
        _lblCategoryName.Size = new System.Drawing.Size(208, 16);
        _lblCategoryName.TabIndex = 8;
        _lblCategoryName.Text = "Category Name";
        // 
        // txtCategoryName
        // 
        _txtCategoryName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        _txtCategoryName.Location = new System.Drawing.Point(16, 24);
        _txtCategoryName.Name = "_txtCategoryName";
        _txtCategoryName.Size = new System.Drawing.Size(208, 20);
        _txtCategoryName.TabIndex = 0;
        // 
        // btnModifierMore
        // 
        _btnModifierMore.Location = new System.Drawing.Point(520, 464);
        _btnModifierMore.Name = "_btnModifierMore";
        _btnModifierMore.Size = new System.Drawing.Size(128, 32);
        _btnModifierMore.TabIndex = 23;
        _btnModifierMore.Text = "More";
        // 
        // btnMainMore
        // 
        _btnMainMore.Location = new System.Drawing.Point(336, 464);
        _btnMainMore.Name = "_btnMainMore";
        _btnMainMore.Size = new System.Drawing.Size(128, 32);
        _btnMainMore.TabIndex = 22;
        _btnMainMore.Text = "More";
        // 
        // btnModifierPrevious
        // 
        _btnModifierPrevious.Location = new System.Drawing.Point(520, 126);
        _btnModifierPrevious.Name = "_btnModifierPrevious";
        _btnModifierPrevious.Size = new System.Drawing.Size(128, 32);
        _btnModifierPrevious.TabIndex = 21;
        _btnModifierPrevious.Text = "Previous";
        // 
        // btnMainPrevious
        // 
        _btnMainPrevious.Location = new System.Drawing.Point(336, 126);
        _btnMainPrevious.Name = "_btnMainPrevious";
        _btnMainPrevious.Size = new System.Drawing.Size(128, 32);
        _btnMainPrevious.TabIndex = 20;
        _btnMainPrevious.Text = "Previous";
        // 
        // lblCategoryModifiers
        // 
        _lblCategoryModifiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblCategoryModifiers.ForeColor = System.Drawing.Color.Silver;
        _lblCategoryModifiers.Location = new System.Drawing.Point(528, 19);
        _lblCategoryModifiers.Name = "_lblCategoryModifiers";
        _lblCategoryModifiers.Size = new System.Drawing.Size(120, 32);
        _lblCategoryModifiers.TabIndex = 15;
        _lblCategoryModifiers.Text = "Modifiers";
        _lblCategoryModifiers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblCategoryMain
        // 
        _lblCategoryMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblCategoryMain.ForeColor = System.Drawing.Color.Silver;
        _lblCategoryMain.Location = new System.Drawing.Point(320, 19);
        _lblCategoryMain.Name = "_lblCategoryMain";
        _lblCategoryMain.Size = new System.Drawing.Size(153, 32);
        _lblCategoryMain.TabIndex = 14;
        _lblCategoryMain.Text = "Foods && General";
        _lblCategoryMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // MainCategoryPanel
        // 
        _MainCategoryPanel.BackColor = System.Drawing.Color.White;
        _MainCategoryPanel.Location = new System.Drawing.Point(336, 160);
        _MainCategoryPanel.Name = "_MainCategoryPanel";
        _MainCategoryPanel.Size = new System.Drawing.Size(128, 304);
        _MainCategoryPanel.TabIndex = 2;
        // 
        // ModifierCategoryPanel
        // 
        _ModifierCategoryPanel.BackColor = System.Drawing.Color.White;
        _ModifierCategoryPanel.Location = new System.Drawing.Point(520, 160);
        _ModifierCategoryPanel.Name = "_ModifierCategoryPanel";
        _ModifierCategoryPanel.Size = new System.Drawing.Size(128, 304);
        _ModifierCategoryPanel.TabIndex = 12;
        // 
        // TabModifiers
        // 
        _TabModifiers.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _TabModifiers.Controls.Add(_pnlModifierPage);
        _TabModifiers.Controls.Add(_pnlNewModifier);
        _TabModifiers.Controls.Add(_Panel7);
        _TabModifiers.Controls.Add(_pnlOrderModifierStaging);
        _TabModifiers.Controls.Add(_pnlModifierItems);
        _TabModifiers.Controls.Add(_cbxModifierFilter);
        _TabModifiers.Controls.Add(_pnlUpdateModifiers);
        _TabModifiers.Location = new System.Drawing.Point(4, 22);
        _TabModifiers.Name = "_TabModifiers";
        _TabModifiers.Size = new System.Drawing.Size(840, 550);
        _TabModifiers.TabIndex = 2;
        _TabModifiers.Text = "Modifiers";
        // 
        // pnlModifierPage
        // 
        _pnlModifierPage.Controls.Add(_btnModifierAddPage);
        _pnlModifierPage.Controls.Add(_btnModifierRemovePage);
        _pnlModifierPage.Location = new System.Drawing.Point(382, 432);
        _pnlModifierPage.Name = "_pnlModifierPage";
        _pnlModifierPage.Size = new System.Drawing.Size(100, 108);
        _pnlModifierPage.TabIndex = 46;
        _pnlModifierPage.Visible = false;
        // 
        // btnModifierAddPage
        // 
        _btnModifierAddPage.Location = new System.Drawing.Point(15, 10);
        _btnModifierAddPage.Name = "_btnModifierAddPage";
        _btnModifierAddPage.Size = new System.Drawing.Size(72, 40);
        _btnModifierAddPage.TabIndex = 41;
        _btnModifierAddPage.Text = "Add Page";
        // 
        // btnModifierRemovePage
        // 
        _btnModifierRemovePage.Location = new System.Drawing.Point(15, 56);
        _btnModifierRemovePage.Name = "_btnModifierRemovePage";
        _btnModifierRemovePage.Size = new System.Drawing.Size(72, 40);
        _btnModifierRemovePage.TabIndex = 42;
        _btnModifierRemovePage.Text = "Remove Page";
        // 
        // pnlNewModifier
        // 
        _pnlNewModifier.Controls.Add(_btnCancelModifier);
        _pnlNewModifier.Controls.Add(_btnAcceptModifier);
        _pnlNewModifier.Controls.Add(_Label17);
        _pnlNewModifier.Controls.Add(_Label18);
        _pnlNewModifier.Controls.Add(_Label19);
        _pnlNewModifier.Controls.Add(_txtNewModifierSurcharge);
        _pnlNewModifier.Controls.Add(_txtNewModifierChit);
        _pnlNewModifier.Controls.Add(_txtNewModifierAbrev);
        _pnlNewModifier.Controls.Add(_Label20);
        _pnlNewModifier.Controls.Add(_Label21);
        _pnlNewModifier.Controls.Add(_txtNewModifierName);
        _pnlNewModifier.Controls.Add(_Label22);
        _pnlNewModifier.Controls.Add(_cbxNewModifierRouting);
        _pnlNewModifier.Controls.Add(_Label23);
        _pnlNewModifier.Controls.Add(_txtNewModifierDescription);
        _pnlNewModifier.Controls.Add(_txtNewModifierCost);
        _pnlNewModifier.Controls.Add(_Label24);
        _pnlNewModifier.Location = new System.Drawing.Point(744, 448);
        _pnlNewModifier.Name = "_pnlNewModifier";
        _pnlNewModifier.Size = new System.Drawing.Size(360, 400);
        _pnlNewModifier.TabIndex = 45;
        _pnlNewModifier.Visible = false;
        // 
        // btnCancelModifier
        // 
        _btnCancelModifier.Location = new System.Drawing.Point(16, 312);
        _btnCancelModifier.Name = "_btnCancelModifier";
        _btnCancelModifier.Size = new System.Drawing.Size(64, 40);
        _btnCancelModifier.TabIndex = 45;
        _btnCancelModifier.Text = "Cancel";
        // 
        // btnAcceptModifier
        // 
        _btnAcceptModifier.Location = new System.Drawing.Point(8, 248);
        _btnAcceptModifier.Name = "_btnAcceptModifier";
        _btnAcceptModifier.Size = new System.Drawing.Size(80, 48);
        _btnAcceptModifier.TabIndex = 44;
        _btnAcceptModifier.Text = "Accept Modifier";
        // 
        // Label17
        // 
        _Label17.Location = new System.Drawing.Point(184, 144);
        _Label17.Name = "_Label17";
        _Label17.Size = new System.Drawing.Size(80, 16);
        _Label17.TabIndex = 36;
        _Label17.Text = "Surcharge:";
        _Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label18
        // 
        _Label18.Location = new System.Drawing.Point(56, 112);
        _Label18.Name = "_Label18";
        _Label18.Size = new System.Drawing.Size(72, 16);
        _Label18.TabIndex = 35;
        _Label18.Text = "Kitchen:";
        _Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label19
        // 
        _Label19.Location = new System.Drawing.Point(56, 80);
        _Label19.Name = "_Label19";
        _Label19.Size = new System.Drawing.Size(72, 16);
        _Label19.TabIndex = 34;
        _Label19.Text = "Button:";
        _Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtNewModifierSurcharge
        // 
        _txtNewModifierSurcharge.Location = new System.Drawing.Point(272, 144);
        _txtNewModifierSurcharge.Name = "_txtNewModifierSurcharge";
        _txtNewModifierSurcharge.Size = new System.Drawing.Size(64, 20);
        _txtNewModifierSurcharge.TabIndex = 4;
        // 
        // txtNewModifierChit
        // 
        _txtNewModifierChit.Location = new System.Drawing.Point(136, 112);
        _txtNewModifierChit.Name = "_txtNewModifierChit";
        _txtNewModifierChit.Size = new System.Drawing.Size(200, 20);
        _txtNewModifierChit.TabIndex = 3;
        _txtNewModifierChit.Text = "Enter Chit Name";
        // 
        // txtNewModifierAbrev
        // 
        _txtNewModifierAbrev.Location = new System.Drawing.Point(136, 80);
        _txtNewModifierAbrev.Name = "_txtNewModifierAbrev";
        _txtNewModifierAbrev.Size = new System.Drawing.Size(200, 20);
        _txtNewModifierAbrev.TabIndex = 2;
        _txtNewModifierAbrev.Text = "Enter Abrev Name";
        // 
        // Label20
        // 
        _Label20.Location = new System.Drawing.Point(56, 48);
        _Label20.Name = "_Label20";
        _Label20.Size = new System.Drawing.Size(72, 16);
        _Label20.TabIndex = 20;
        _Label20.Text = "Full Name:";
        _Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label21
        // 
        _Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label21.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
        _Label21.Location = new System.Drawing.Point(64, 16);
        _Label21.Name = "_Label21";
        _Label21.Size = new System.Drawing.Size(248, 24);
        _Label21.TabIndex = 7;
        _Label21.Text = "Add New Modifier";
        _Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtNewModifierName
        // 
        _txtNewModifierName.Location = new System.Drawing.Point(136, 48);
        _txtNewModifierName.Name = "_txtNewModifierName";
        _txtNewModifierName.Size = new System.Drawing.Size(200, 20);
        _txtNewModifierName.TabIndex = 1;
        _txtNewModifierName.Text = "Enter Modifier Name";
        // 
        // Label22
        // 
        _Label22.Location = new System.Drawing.Point(128, 256);
        _Label22.Name = "_Label22";
        _Label22.Size = new System.Drawing.Size(104, 24);
        _Label22.TabIndex = 33;
        _Label22.Text = "Food Cost:           (for accounting only)";
        _Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // cbxNewModifierRouting
        // 
        _cbxNewModifierRouting.BackColor = System.Drawing.Color.LightSteelBlue;
        _cbxNewModifierRouting.Location = new System.Drawing.Point(136, 224);
        _cbxNewModifierRouting.Name = "_cbxNewModifierRouting";
        _cbxNewModifierRouting.Size = new System.Drawing.Size(200, 21);
        _cbxNewModifierRouting.TabIndex = 6;
        _cbxNewModifierRouting.Text = "Route w/ Food";
        // 
        // Label23
        // 
        _Label23.Location = new System.Drawing.Point(112, 288);
        _Label23.Name = "_Label23";
        _Label23.Size = new System.Drawing.Size(216, 16);
        _Label23.TabIndex = 11;
        _Label23.Text = "Description";
        _Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtNewModifierDescription
        // 
        _txtNewModifierDescription.Location = new System.Drawing.Point(96, 304);
        _txtNewModifierDescription.Multiline = true;
        _txtNewModifierDescription.Name = "_txtNewModifierDescription";
        _txtNewModifierDescription.Size = new System.Drawing.Size(248, 88);
        _txtNewModifierDescription.TabIndex = 43;
        // 
        // txtNewModifierCost
        // 
        _txtNewModifierCost.BackColor = System.Drawing.Color.LightSteelBlue;
        _txtNewModifierCost.Location = new System.Drawing.Point(240, 256);
        _txtNewModifierCost.Name = "_txtNewModifierCost";
        _txtNewModifierCost.Size = new System.Drawing.Size(96, 20);
        _txtNewModifierCost.TabIndex = 7;
        _txtNewModifierCost.Text = "Enter Cost";
        _txtNewModifierCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // Label24
        // 
        _Label24.Location = new System.Drawing.Point(128, 200);
        _Label24.Name = "_Label24";
        _Label24.Size = new System.Drawing.Size(208, 24);
        _Label24.TabIndex = 38;
        _Label24.Text = "Routing (only if seperate from Food):";
        _Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // Panel7
        // 
        _Panel7.Controls.Add(_btnModCancelNew);
        _Panel7.Controls.Add(_lblModifierSurcharge);
        _Panel7.Controls.Add(_lblModifierChit);
        _Panel7.Controls.Add(_lblModifierAbrev);
        _Panel7.Controls.Add(_txtModifierSurcharge);
        _Panel7.Controls.Add(_txtModifierChit);
        _Panel7.Controls.Add(_txtModifierAbrev);
        _Panel7.Controls.Add(_Label1);
        _Panel7.Controls.Add(_lblSelectModifierFilter);
        _Panel7.Controls.Add(_txtModifierName);
        _Panel7.Controls.Add(_Label2);
        _Panel7.Controls.Add(_cbxModifierRouting);
        _Panel7.Controls.Add(_LblModDescLabel);
        _Panel7.Controls.Add(_txtModifierDescription);
        _Panel7.Controls.Add(_txtModifierCost);
        _Panel7.Controls.Add(_lblModifierRouting);
        _Panel7.Location = new System.Drawing.Point(424, 16);
        _Panel7.Name = "_Panel7";
        _Panel7.Size = new System.Drawing.Size(360, 400);
        _Panel7.TabIndex = 44;
        // 
        // btnModCancelNew
        // 
        _btnModCancelNew.Location = new System.Drawing.Point(24, 328);
        _btnModCancelNew.Name = "_btnModCancelNew";
        _btnModCancelNew.Size = new System.Drawing.Size(56, 48);
        _btnModCancelNew.TabIndex = 44;
        _btnModCancelNew.Text = "Cancel";
        _btnModCancelNew.Visible = false;
        // 
        // lblModifierSurcharge
        // 
        _lblModifierSurcharge.Location = new System.Drawing.Point(184, 167);
        _lblModifierSurcharge.Name = "_lblModifierSurcharge";
        _lblModifierSurcharge.Size = new System.Drawing.Size(80, 16);
        _lblModifierSurcharge.TabIndex = 36;
        _lblModifierSurcharge.Text = "Surcharge:";
        _lblModifierSurcharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblModifierChit
        // 
        _lblModifierChit.Location = new System.Drawing.Point(56, 135);
        _lblModifierChit.Name = "_lblModifierChit";
        _lblModifierChit.Size = new System.Drawing.Size(72, 16);
        _lblModifierChit.TabIndex = 35;
        _lblModifierChit.Text = "Kitchen:";
        _lblModifierChit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblModifierAbrev
        // 
        _lblModifierAbrev.Location = new System.Drawing.Point(56, 103);
        _lblModifierAbrev.Name = "_lblModifierAbrev";
        _lblModifierAbrev.Size = new System.Drawing.Size(72, 16);
        _lblModifierAbrev.TabIndex = 34;
        _lblModifierAbrev.Text = "Button:";
        _lblModifierAbrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtModifierSurcharge
        // 
        _txtModifierSurcharge.Location = new System.Drawing.Point(272, 167);
        _txtModifierSurcharge.Name = "_txtModifierSurcharge";
        _txtModifierSurcharge.Size = new System.Drawing.Size(64, 20);
        _txtModifierSurcharge.TabIndex = 4;
        // 
        // txtModifierChit
        // 
        _txtModifierChit.Location = new System.Drawing.Point(136, 135);
        _txtModifierChit.Name = "_txtModifierChit";
        _txtModifierChit.Size = new System.Drawing.Size(200, 20);
        _txtModifierChit.TabIndex = 3;
        _txtModifierChit.Text = "Enter Chit Name";
        // 
        // txtModifierAbrev
        // 
        _txtModifierAbrev.Location = new System.Drawing.Point(136, 103);
        _txtModifierAbrev.Name = "_txtModifierAbrev";
        _txtModifierAbrev.Size = new System.Drawing.Size(200, 20);
        _txtModifierAbrev.TabIndex = 2;
        _txtModifierAbrev.Text = "Enter Abrev Name";
        // 
        // Label1
        // 
        _Label1.Location = new System.Drawing.Point(56, 71);
        _Label1.Name = "_Label1";
        _Label1.Size = new System.Drawing.Size(72, 16);
        _Label1.TabIndex = 20;
        _Label1.Text = "Full Name:";
        _Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblSelectModifierFilter
        // 
        _lblSelectModifierFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblSelectModifierFilter.ForeColor = System.Drawing.Color.Silver;
        _lblSelectModifierFilter.Location = new System.Drawing.Point(64, 16);
        _lblSelectModifierFilter.Name = "_lblSelectModifierFilter";
        _lblSelectModifierFilter.Size = new System.Drawing.Size(248, 24);
        _lblSelectModifierFilter.TabIndex = 7;
        _lblSelectModifierFilter.Text = "Modifier Display for ALL Menus";
        _lblSelectModifierFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtModifierName
        // 
        _txtModifierName.Location = new System.Drawing.Point(136, 71);
        _txtModifierName.Name = "_txtModifierName";
        _txtModifierName.Size = new System.Drawing.Size(200, 20);
        _txtModifierName.TabIndex = 1;
        _txtModifierName.Text = "Enter Modifier Name";
        // 
        // Label2
        // 
        _Label2.Location = new System.Drawing.Point(128, 256);
        _Label2.Name = "_Label2";
        _Label2.Size = new System.Drawing.Size(104, 24);
        _Label2.TabIndex = 33;
        _Label2.Text = "Food Cost:           (for accounting only)";
        _Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // cbxModifierRouting
        // 
        _cbxModifierRouting.BackColor = System.Drawing.Color.LightSteelBlue;
        _cbxModifierRouting.Location = new System.Drawing.Point(136, 224);
        _cbxModifierRouting.Name = "_cbxModifierRouting";
        _cbxModifierRouting.Size = new System.Drawing.Size(200, 21);
        _cbxModifierRouting.TabIndex = 6;
        _cbxModifierRouting.Text = "Route w/ Food";
        // 
        // LblModDescLabel
        // 
        _LblModDescLabel.Location = new System.Drawing.Point(112, 288);
        _LblModDescLabel.Name = "_LblModDescLabel";
        _LblModDescLabel.Size = new System.Drawing.Size(216, 16);
        _LblModDescLabel.TabIndex = 11;
        _LblModDescLabel.Text = "Description";
        _LblModDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtModifierDescription
        // 
        _txtModifierDescription.Location = new System.Drawing.Point(96, 304);
        _txtModifierDescription.Multiline = true;
        _txtModifierDescription.Name = "_txtModifierDescription";
        _txtModifierDescription.Size = new System.Drawing.Size(248, 88);
        _txtModifierDescription.TabIndex = 43;
        // 
        // txtModifierCost
        // 
        _txtModifierCost.BackColor = System.Drawing.Color.LightSteelBlue;
        _txtModifierCost.Location = new System.Drawing.Point(240, 256);
        _txtModifierCost.Name = "_txtModifierCost";
        _txtModifierCost.Size = new System.Drawing.Size(96, 20);
        _txtModifierCost.TabIndex = 7;
        _txtModifierCost.Text = "Enter Cost";
        _txtModifierCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // lblModifierRouting
        // 
        _lblModifierRouting.Location = new System.Drawing.Point(128, 200);
        _lblModifierRouting.Name = "_lblModifierRouting";
        _lblModifierRouting.Size = new System.Drawing.Size(208, 24);
        _lblModifierRouting.TabIndex = 38;
        _lblModifierRouting.Text = "Routing (only if seperate from Food):";
        _lblModifierRouting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // pnlOrderModifierStaging
        // 
        _pnlOrderModifierStaging.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        _pnlOrderModifierStaging.Location = new System.Drawing.Point(24, 432);
        _pnlOrderModifierStaging.Name = "_pnlOrderModifierStaging";
        _pnlOrderModifierStaging.Size = new System.Drawing.Size(328, 80);
        _pnlOrderModifierStaging.TabIndex = 40;
        // 
        // pnlModifierItems
        // 
        _pnlModifierItems.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        _pnlModifierItems.Location = new System.Drawing.Point(16, 48);
        _pnlModifierItems.Name = "_pnlModifierItems";
        _pnlModifierItems.Size = new System.Drawing.Size(344, 368);
        _pnlModifierItems.TabIndex = 39;
        // 
        // cbxModifierFilter
        // 
        _cbxModifierFilter.Location = new System.Drawing.Point(88, 16);
        _cbxModifierFilter.MaxDropDownItems = 16;
        _cbxModifierFilter.Name = "_cbxModifierFilter";
        _cbxModifierFilter.Size = new System.Drawing.Size(192, 21);
        _cbxModifierFilter.TabIndex = 6;
        _cbxModifierFilter.Text = "Select Modifier Category";
        // 
        // pnlUpdateModifiers
        // 
        _pnlUpdateModifiers.BackColor = System.Drawing.SystemColors.Control;
        _pnlUpdateModifiers.Controls.Add(_btnRemoveModifier);
        _pnlUpdateModifiers.Location = new System.Drawing.Point(560, 448);
        _pnlUpdateModifiers.Name = "_pnlUpdateModifiers";
        _pnlUpdateModifiers.Size = new System.Drawing.Size(128, 52);
        _pnlUpdateModifiers.TabIndex = 5;
        // 
        // btnRemoveModifier
        // 
        _btnRemoveModifier.BackColor = System.Drawing.Color.FromArgb(149, 179, 215);
        _btnRemoveModifier.Location = new System.Drawing.Point(4, 4);
        _btnRemoveModifier.Name = "_btnRemoveModifier";
        _btnRemoveModifier.Size = new System.Drawing.Size(120, 43);
        _btnRemoveModifier.TabIndex = 1;
        _btnRemoveModifier.Text = "Remove Modifier From Display";
        _btnRemoveModifier.UseVisualStyleBackColor = false;
        // 
        // TabMainFood
        // 
        _TabMainFood.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _TabMainFood.Controls.Add(_cbxFoodFilterModifiers);
        _TabMainFood.Controls.Add(_btnFoodRecipe);
        _TabMainFood.Controls.Add(_Panel1);
        _TabMainFood.Controls.Add(_pnlNewFood);
        _TabMainFood.Controls.Add(_txtRecipe);
        _TabMainFood.Controls.Add(_lblWineParring);
        _TabMainFood.Controls.Add(_cbxWineParring);
        _TabMainFood.Controls.Add(_lstModifierJoin);
        _TabMainFood.Controls.Add(_lblPrintPriority);
        _TabMainFood.Controls.Add(_lblSelectFoodCategory);
        _TabMainFood.Controls.Add(_lblChitFoodName);
        _TabMainFood.Controls.Add(_lblAbrevFoodName);
        _TabMainFood.Controls.Add(_cbxPrintPriority);
        _TabMainFood.Controls.Add(_lblFoodName);
        _TabMainFood.Controls.Add(_txtChitFoodName);
        _TabMainFood.Controls.Add(_txtAbrevFoodName);
        _TabMainFood.Controls.Add(_btnShowAllFood);
        _TabMainFood.Controls.Add(_cbxFoodFilter);
        _TabMainFood.Controls.Add(_lblSelectFoodFilter);
        _TabMainFood.Controls.Add(_btnFoodJoinLink);
        _TabMainFood.Controls.Add(_btnEnterNewFood);
        _TabMainFood.Controls.Add(_menuCostGroupBox);
        _TabMainFood.Controls.Add(_grdFoodList);
        _TabMainFood.Controls.Add(_Panel2);
        _TabMainFood.Controls.Add(_cbxFoodCategory);
        _TabMainFood.Controls.Add(_txtFoodName);
        _TabMainFood.Location = new System.Drawing.Point(4, 22);
        _TabMainFood.Name = "_TabMainFood";
        _TabMainFood.Size = new System.Drawing.Size(840, 550);
        _TabMainFood.TabIndex = 1;
        _TabMainFood.Text = "Kitchen";
        // 
        // cbxFoodFilterModifiers
        // 
        _cbxFoodFilterModifiers.Location = new System.Drawing.Point(16, 67);
        _cbxFoodFilterModifiers.MaxDropDownItems = 16;
        _cbxFoodFilterModifiers.Name = "_cbxFoodFilterModifiers";
        _cbxFoodFilterModifiers.Size = new System.Drawing.Size(192, 21);
        _cbxFoodFilterModifiers.TabIndex = 41;
        _cbxFoodFilterModifiers.Text = "Select Modifier Category";
        // 
        // btnFoodRecipe
        // 
        _btnFoodRecipe.Location = new System.Drawing.Point(279, 351);
        _btnFoodRecipe.Name = "_btnFoodRecipe";
        _btnFoodRecipe.Size = new System.Drawing.Size(152, 24);
        _btnFoodRecipe.TabIndex = 10;
        _btnFoodRecipe.Text = "Recipe / Description";
        // 
        // Panel1
        // 
        _Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        _Panel1.Controls.Add(_txtFoodInvMultiplier);
        _Panel1.Controls.Add(_Label27);
        _Panel1.Controls.Add(_txtFoodCost);
        _Panel1.Controls.Add(_lblFoodCost);
        _Panel1.Controls.Add(_chkManual);
        _Panel1.Location = new System.Drawing.Point(227, 259);
        _Panel1.Name = "_Panel1";
        _Panel1.Size = new System.Drawing.Size(254, 68);
        _Panel1.TabIndex = 40;
        // 
        // txtFoodInvMultiplier
        // 
        _txtFoodInvMultiplier.Location = new System.Drawing.Point(71, 33);
        _txtFoodInvMultiplier.Name = "_txtFoodInvMultiplier";
        _txtFoodInvMultiplier.Size = new System.Drawing.Size(88, 20);
        _txtFoodInvMultiplier.TabIndex = 41;
        _txtFoodInvMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // Label27
        // 
        _Label27.AutoSize = true;
        _Label27.Location = new System.Drawing.Point(3, 39);
        _Label27.Name = "_Label27";
        _Label27.Size = new System.Drawing.Size(60, 13);
        _Label27.TabIndex = 40;
        _Label27.Text = "Inv Multiply";
        _Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtFoodCost
        // 
        _txtFoodCost.BackColor = System.Drawing.Color.LightSteelBlue;
        _txtFoodCost.Location = new System.Drawing.Point(71, 7);
        _txtFoodCost.Name = "_txtFoodCost";
        _txtFoodCost.Size = new System.Drawing.Size(88, 20);
        _txtFoodCost.TabIndex = 9;
        _txtFoodCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // lblFoodCost
        // 
        _lblFoodCost.Location = new System.Drawing.Point(-1, 7);
        _lblFoodCost.Name = "_lblFoodCost";
        _lblFoodCost.Size = new System.Drawing.Size(72, 16);
        _lblFoodCost.TabIndex = 32;
        _lblFoodCost.Text = "Food Cost: ";
        _lblFoodCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // chkManual
        // 
        _chkManual.Location = new System.Drawing.Point(183, 7);
        _chkManual.Name = "_chkManual";
        _chkManual.Size = new System.Drawing.Size(64, 24);
        _chkManual.TabIndex = 39;
        _chkManual.Text = "Manual";
        // 
        // pnlNewFood
        // 
        _pnlNewFood.BackColor = System.Drawing.Color.Moccasin;
        _pnlNewFood.Controls.Add(_Label14);
        _pnlNewFood.Controls.Add(_txtNewFoodPrepare);
        _pnlNewFood.Controls.Add(_btnNewFoodCancel);
        _pnlNewFood.Controls.Add(_btnNewFoodAccept);
        _pnlNewFood.Controls.Add(_Label9);
        _pnlNewFood.Controls.Add(_ComboBox1);
        _pnlNewFood.Controls.Add(_Label10);
        _pnlNewFood.Controls.Add(_Label11);
        _pnlNewFood.Controls.Add(_Label12);
        _pnlNewFood.Controls.Add(_Label13);
        _pnlNewFood.Controls.Add(_txtNewChitFoodName);
        _pnlNewFood.Controls.Add(_txtNewAbrevFoodName);
        _pnlNewFood.Controls.Add(_cbxNewFoodCategory);
        _pnlNewFood.Controls.Add(_txtNewFoodName);
        _pnlNewFood.Location = new System.Drawing.Point(596, 194);
        _pnlNewFood.Name = "_pnlNewFood";
        _pnlNewFood.Size = new System.Drawing.Size(280, 360);
        _pnlNewFood.TabIndex = 38;
        _pnlNewFood.Visible = false;
        // 
        // Label14
        // 
        _Label14.Location = new System.Drawing.Point(104, 216);
        _Label14.Name = "_Label14";
        _Label14.Size = new System.Drawing.Size(80, 23);
        _Label14.TabIndex = 49;
        _Label14.Text = "Prepare Time:";
        _Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtNewFoodPrepare
        // 
        _txtNewFoodPrepare.Location = new System.Drawing.Point(200, 216);
        _txtNewFoodPrepare.Name = "_txtNewFoodPrepare";
        _txtNewFoodPrepare.Size = new System.Drawing.Size(56, 20);
        _txtNewFoodPrepare.TabIndex = 48;
        // 
        // btnNewFoodCancel
        // 
        _btnNewFoodCancel.Location = new System.Drawing.Point(160, 304);
        _btnNewFoodCancel.Name = "_btnNewFoodCancel";
        _btnNewFoodCancel.Size = new System.Drawing.Size(75, 40);
        _btnNewFoodCancel.TabIndex = 47;
        _btnNewFoodCancel.Text = "Cancel";
        // 
        // btnNewFoodAccept
        // 
        _btnNewFoodAccept.Location = new System.Drawing.Point(40, 304);
        _btnNewFoodAccept.Name = "_btnNewFoodAccept";
        _btnNewFoodAccept.Size = new System.Drawing.Size(75, 40);
        _btnNewFoodAccept.TabIndex = 46;
        _btnNewFoodAccept.Text = "Accept";
        // 
        // Label9
        // 
        _Label9.Location = new System.Drawing.Point(0, 184);
        _Label9.Name = "_Label9";
        _Label9.Size = new System.Drawing.Size(80, 16);
        _Label9.TabIndex = 45;
        _Label9.Text = "Wine Parring:";
        _Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // ComboBox1
        // 
        _ComboBox1.Location = new System.Drawing.Point(80, 184);
        _ComboBox1.Name = "_ComboBox1";
        _ComboBox1.Size = new System.Drawing.Size(176, 21);
        _ComboBox1.TabIndex = 44;
        // 
        // Label10
        // 
        _Label10.Location = new System.Drawing.Point(8, 152);
        _Label10.Name = "_Label10";
        _Label10.Size = new System.Drawing.Size(72, 16);
        _Label10.TabIndex = 43;
        _Label10.Text = "Category:";
        _Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label11
        // 
        _Label11.Location = new System.Drawing.Point(8, 112);
        _Label11.Name = "_Label11";
        _Label11.Size = new System.Drawing.Size(72, 16);
        _Label11.TabIndex = 42;
        _Label11.Text = "Kitchen:";
        _Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label12
        // 
        _Label12.Location = new System.Drawing.Point(8, 80);
        _Label12.Name = "_Label12";
        _Label12.Size = new System.Drawing.Size(72, 16);
        _Label12.TabIndex = 41;
        _Label12.Text = "Button:";
        _Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label13
        // 
        _Label13.Location = new System.Drawing.Point(8, 48);
        _Label13.Name = "_Label13";
        _Label13.Size = new System.Drawing.Size(72, 16);
        _Label13.TabIndex = 40;
        _Label13.Text = "Full Name:";
        _Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtNewChitFoodName
        // 
        _txtNewChitFoodName.Location = new System.Drawing.Point(80, 112);
        _txtNewChitFoodName.Name = "_txtNewChitFoodName";
        _txtNewChitFoodName.Size = new System.Drawing.Size(176, 20);
        _txtNewChitFoodName.TabIndex = 38;
        // 
        // txtNewAbrevFoodName
        // 
        _txtNewAbrevFoodName.Location = new System.Drawing.Point(80, 80);
        _txtNewAbrevFoodName.Name = "_txtNewAbrevFoodName";
        _txtNewAbrevFoodName.Size = new System.Drawing.Size(176, 20);
        _txtNewAbrevFoodName.TabIndex = 37;
        // 
        // cbxNewFoodCategory
        // 
        _cbxNewFoodCategory.Location = new System.Drawing.Point(80, 152);
        _cbxNewFoodCategory.Name = "_cbxNewFoodCategory";
        _cbxNewFoodCategory.Size = new System.Drawing.Size(176, 21);
        _cbxNewFoodCategory.TabIndex = 39;
        // 
        // txtNewFoodName
        // 
        _txtNewFoodName.Location = new System.Drawing.Point(80, 48);
        _txtNewFoodName.Name = "_txtNewFoodName";
        _txtNewFoodName.Size = new System.Drawing.Size(176, 20);
        _txtNewFoodName.TabIndex = 36;
        // 
        // txtRecipe
        // 
        _txtRecipe.Location = new System.Drawing.Point(206, 381);
        _txtRecipe.Multiline = true;
        _txtRecipe.Name = "_txtRecipe";
        _txtRecipe.Size = new System.Drawing.Size(320, 128);
        _txtRecipe.TabIndex = 37;
        _txtRecipe.Visible = false;
        // 
        // lblWineParring
        // 
        _lblWineParring.Location = new System.Drawing.Point(216, 200);
        _lblWineParring.Name = "_lblWineParring";
        _lblWineParring.Size = new System.Drawing.Size(80, 16);
        _lblWineParring.TabIndex = 35;
        _lblWineParring.Text = "Wine Parring:";
        _lblWineParring.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // cbxWineParring
        // 
        _cbxWineParring.Location = new System.Drawing.Point(296, 200);
        _cbxWineParring.Name = "_cbxWineParring";
        _cbxWineParring.Size = new System.Drawing.Size(176, 21);
        _cbxWineParring.TabIndex = 34;
        // 
        // lstModifierJoin
        // 
        _lstModifierJoin.Location = new System.Drawing.Point(624, 56);
        _lstModifierJoin.Name = "_lstModifierJoin";
        _lstModifierJoin.Size = new System.Drawing.Size(160, 160);
        _lstModifierJoin.TabIndex = 33;
        // 
        // lblPrintPriority
        // 
        _lblPrintPriority.Location = new System.Drawing.Point(216, 232);
        _lblPrintPriority.Name = "_lblPrintPriority";
        _lblPrintPriority.Size = new System.Drawing.Size(80, 16);
        _lblPrintPriority.TabIndex = 29;
        _lblPrintPriority.Text = "Print Priority:";
        _lblPrintPriority.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblSelectFoodCategory
        // 
        _lblSelectFoodCategory.Location = new System.Drawing.Point(224, 168);
        _lblSelectFoodCategory.Name = "_lblSelectFoodCategory";
        _lblSelectFoodCategory.Size = new System.Drawing.Size(72, 16);
        _lblSelectFoodCategory.TabIndex = 27;
        _lblSelectFoodCategory.Text = "Category:";
        _lblSelectFoodCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblChitFoodName
        // 
        _lblChitFoodName.Location = new System.Drawing.Point(224, 128);
        _lblChitFoodName.Name = "_lblChitFoodName";
        _lblChitFoodName.Size = new System.Drawing.Size(72, 16);
        _lblChitFoodName.TabIndex = 26;
        _lblChitFoodName.Text = "Kitchen:";
        _lblChitFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblAbrevFoodName
        // 
        _lblAbrevFoodName.Location = new System.Drawing.Point(224, 96);
        _lblAbrevFoodName.Name = "_lblAbrevFoodName";
        _lblAbrevFoodName.Size = new System.Drawing.Size(72, 16);
        _lblAbrevFoodName.TabIndex = 25;
        _lblAbrevFoodName.Text = "Button:";
        _lblAbrevFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // cbxPrintPriority
        // 
        _cbxPrintPriority.BackColor = System.Drawing.Color.White;
        _cbxPrintPriority.Location = new System.Drawing.Point(296, 232);
        _cbxPrintPriority.Name = "_cbxPrintPriority";
        _cbxPrintPriority.Size = new System.Drawing.Size(120, 21);
        _cbxPrintPriority.TabIndex = 6;
        // 
        // lblFoodName
        // 
        _lblFoodName.Location = new System.Drawing.Point(224, 64);
        _lblFoodName.Name = "_lblFoodName";
        _lblFoodName.Size = new System.Drawing.Size(72, 16);
        _lblFoodName.TabIndex = 19;
        _lblFoodName.Text = "Full Name:";
        _lblFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtChitFoodName
        // 
        _txtChitFoodName.Location = new System.Drawing.Point(296, 128);
        _txtChitFoodName.Name = "_txtChitFoodName";
        _txtChitFoodName.Size = new System.Drawing.Size(176, 20);
        _txtChitFoodName.TabIndex = 3;
        // 
        // txtAbrevFoodName
        // 
        _txtAbrevFoodName.Location = new System.Drawing.Point(296, 96);
        _txtAbrevFoodName.Name = "_txtAbrevFoodName";
        _txtAbrevFoodName.Size = new System.Drawing.Size(176, 20);
        _txtAbrevFoodName.TabIndex = 2;
        // 
        // btnShowAllFood
        // 
        _btnShowAllFood.Location = new System.Drawing.Point(56, 515);
        _btnShowAllFood.Name = "_btnShowAllFood";
        _btnShowAllFood.Size = new System.Drawing.Size(96, 24);
        _btnShowAllFood.TabIndex = 16;
        _btnShowAllFood.Text = "Show All";
        // 
        // cbxFoodFilter
        // 
        _cbxFoodFilter.Location = new System.Drawing.Point(16, 40);
        _cbxFoodFilter.MaxDropDownItems = 16;
        _cbxFoodFilter.Name = "_cbxFoodFilter";
        _cbxFoodFilter.Size = new System.Drawing.Size(192, 21);
        _cbxFoodFilter.TabIndex = 15;
        _cbxFoodFilter.Text = "Select Food Category";
        // 
        // lblSelectFoodFilter
        // 
        _lblSelectFoodFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblSelectFoodFilter.ForeColor = System.Drawing.Color.Silver;
        _lblSelectFoodFilter.Location = new System.Drawing.Point(264, 16);
        _lblSelectFoodFilter.Name = "_lblSelectFoodFilter";
        _lblSelectFoodFilter.Size = new System.Drawing.Size(232, 32);
        _lblSelectFoodFilter.TabIndex = 14;
        _lblSelectFoodFilter.Text = "Select Category";
        _lblSelectFoodFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnFoodJoinLink
        // 
        _btnFoodJoinLink.ForeColor = System.Drawing.Color.White;
        _btnFoodJoinLink.Location = new System.Drawing.Point(656, 16);
        _btnFoodJoinLink.Name = "_btnFoodJoinLink";
        _btnFoodJoinLink.Size = new System.Drawing.Size(104, 32);
        _btnFoodJoinLink.TabIndex = 13;
        _btnFoodJoinLink.Text = "Update Joins";
        // 
        // btnEnterNewFood
        // 
        _btnEnterNewFood.ForeColor = System.Drawing.Color.White;
        _btnEnterNewFood.Location = new System.Drawing.Point(56, 8);
        _btnEnterNewFood.Name = "_btnEnterNewFood";
        _btnEnterNewFood.Size = new System.Drawing.Size(120, 32);
        _btnEnterNewFood.TabIndex = 11;
        _btnEnterNewFood.Text = "Enter New Food";
        // 
        // menuCostGroupBox
        // 
        _menuCostGroupBox.Location = new System.Drawing.Point(552, 232);
        _menuCostGroupBox.Name = "_menuCostGroupBox";
        _menuCostGroupBox.Size = new System.Drawing.Size(280, 192);
        _menuCostGroupBox.TabIndex = 14;
        _menuCostGroupBox.TabStop = false;
        _menuCostGroupBox.Text = "Price per Menu";
        // 
        // grdFoodList
        // 
        _grdFoodList.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
        _grdFoodList.CaptionText = "               Food Items";
        _grdFoodList.ColumnHeadersVisible = false;
        _grdFoodList.DataMember = "";
        _grdFoodList.GridLineColor = System.Drawing.SystemColors.ActiveCaptionText;
        _grdFoodList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
        _grdFoodList.Location = new System.Drawing.Point(24, 104);
        _grdFoodList.Name = "_grdFoodList";
        _grdFoodList.ReadOnly = true;
        _grdFoodList.RowHeadersVisible = false;
        _grdFoodList.RowHeaderWidth = 0;
        _grdFoodList.Size = new System.Drawing.Size(176, 405);
        _grdFoodList.TabIndex = 7;
        // 
        // Panel2
        // 
        _Panel2.BackColor = System.Drawing.SystemColors.Control;
        _Panel2.Controls.Add(_btnRemoveFood);
        _Panel2.Location = new System.Drawing.Point(38, 566);
        _Panel2.Name = "_Panel2";
        _Panel2.Size = new System.Drawing.Size(152, 48);
        _Panel2.TabIndex = 6;
        // 
        // btnRemoveFood
        // 
        _btnRemoveFood.BackColor = System.Drawing.Color.FromArgb(149, 179, 215);
        _btnRemoveFood.Location = new System.Drawing.Point(8, 8);
        _btnRemoveFood.Name = "_btnRemoveFood";
        _btnRemoveFood.Size = new System.Drawing.Size(136, 32);
        _btnRemoveFood.TabIndex = 12;
        _btnRemoveFood.Text = "Remove Food Item";
        _btnRemoveFood.UseVisualStyleBackColor = false;
        // 
        // cbxFoodCategory
        // 
        _cbxFoodCategory.BackColor = System.Drawing.Color.White;
        _cbxFoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
        _cbxFoodCategory.Location = new System.Drawing.Point(296, 168);
        _cbxFoodCategory.MaxDropDownItems = 16;
        _cbxFoodCategory.Name = "_cbxFoodCategory";
        _cbxFoodCategory.Size = new System.Drawing.Size(176, 21);
        _cbxFoodCategory.TabIndex = 4;
        // 
        // txtFoodName
        // 
        _txtFoodName.Location = new System.Drawing.Point(296, 64);
        _txtFoodName.Name = "_txtFoodName";
        _txtFoodName.Size = new System.Drawing.Size(176, 20);
        _txtFoodName.TabIndex = 1;
        // 
        // TabFoodJoin
        // 
        _TabFoodJoin.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _TabFoodJoin.Controls.Add(_btnJoinReq);
        _TabFoodJoin.Controls.Add(_btnJoinGTC);
        _TabFoodJoin.Controls.Add(_Panel5);
        _TabFoodJoin.Controls.Add(_btnJoinGroup);
        _TabFoodJoin.Controls.Add(_btnJoinFoodRemoveIndividual);
        _TabFoodJoin.Controls.Add(_btnJoinFoodRemoveCategory);
        _TabFoodJoin.Controls.Add(_grdJoinFoodModifierJoins);
        _TabFoodJoin.Controls.Add(_btnJoinFree);
        _TabFoodJoin.Controls.Add(_grdJoinFoodChoice);
        _TabFoodJoin.Controls.Add(_cbxJoinCategorySelect);
        _TabFoodJoin.Controls.Add(_lblJoinFoodSelected);
        _TabFoodJoin.Controls.Add(_grdJoinFoodCategoryJoins);
        _TabFoodJoin.Controls.Add(_cbxJoinIndividualModifierSelect);
        _TabFoodJoin.Controls.Add(_grdJoinIndividualModifiers);
        _TabFoodJoin.Controls.Add(_grdJoinPossibleCategories);
        _TabFoodJoin.Location = new System.Drawing.Point(4, 22);
        _TabFoodJoin.Name = "_TabFoodJoin";
        _TabFoodJoin.Size = new System.Drawing.Size(840, 550);
        _TabFoodJoin.TabIndex = 3;
        _TabFoodJoin.Text = "Food Join";
        // 
        // btnJoinReq
        // 
        _btnJoinReq.ForeColor = System.Drawing.Color.White;
        _btnJoinReq.Location = new System.Drawing.Point(293, 456);
        _btnJoinReq.Name = "_btnJoinReq";
        _btnJoinReq.Size = new System.Drawing.Size(75, 48);
        _btnJoinReq.TabIndex = 22;
        _btnJoinReq.Text = "Required";
        // 
        // btnJoinGTC
        // 
        _btnJoinGTC.ForeColor = System.Drawing.Color.White;
        _btnJoinGTC.Location = new System.Drawing.Point(208, 456);
        _btnJoinGTC.Name = "_btnJoinGTC";
        _btnJoinGTC.Size = new System.Drawing.Size(75, 48);
        _btnJoinGTC.TabIndex = 21;
        _btnJoinGTC.Text = "GTC";
        // 
        // Panel5
        // 
        _Panel5.Controls.Add(_Label26);
        _Panel5.Controls.Add(_Label8);
        _Panel5.Controls.Add(_Label7);
        _Panel5.Controls.Add(_Label6);
        _Panel5.Controls.Add(_Label5);
        _Panel5.Controls.Add(_Label4);
        _Panel5.Location = new System.Drawing.Point(240, 304);
        _Panel5.Name = "_Panel5";
        _Panel5.Size = new System.Drawing.Size(272, 136);
        _Panel5.TabIndex = 20;
        // 
        // Label26
        // 
        _Label26.ForeColor = System.Drawing.Color.Silver;
        _Label26.Location = new System.Drawing.Point(8, 108);
        _Label26.Name = "_Label26";
        _Label26.Size = new System.Drawing.Size(248, 23);
        _Label26.TabIndex = 5;
        _Label26.Text = "R - Required to Order";
        // 
        // Label8
        // 
        _Label8.ForeColor = System.Drawing.Color.Silver;
        _Label8.Location = new System.Drawing.Point(8, 90);
        _Label8.Name = "_Label8";
        _Label8.Size = new System.Drawing.Size(248, 23);
        _Label8.TabIndex = 4;
        _Label8.Text = "C - GTC, Category is Good til Cancelled";
        // 
        // Label7
        // 
        _Label7.ForeColor = System.Drawing.Color.Silver;
        _Label7.Location = new System.Drawing.Point(8, 65);
        _Label7.Name = "_Label7";
        _Label7.Size = new System.Drawing.Size(256, 24);
        _Label7.TabIndex = 3;
        _Label7.Text = "G - Item must be selected within Category Group";
        // 
        // Label6
        // 
        _Label6.ForeColor = System.Drawing.Color.Silver;
        _Label6.Location = new System.Drawing.Point(8, 48);
        _Label6.Name = "_Label6";
        _Label6.Size = new System.Drawing.Size(224, 23);
        _Label6.TabIndex = 2;
        _Label6.Text = "A - Item automatically attach to Food";
        // 
        // Label5
        // 
        _Label5.ForeColor = System.Drawing.Color.Silver;
        _Label5.Location = new System.Drawing.Point(8, 24);
        _Label5.Name = "_Label5";
        _Label5.Size = new System.Drawing.Size(256, 24);
        _Label5.TabIndex = 1;
        _Label5.Text = "S - Item carrys Surcharge listed in Main Foods";
        // 
        // Label4
        // 
        _Label4.ForeColor = System.Drawing.Color.Silver;
        _Label4.Location = new System.Drawing.Point(8, 8);
        _Label4.Name = "_Label4";
        _Label4.Size = new System.Drawing.Size(248, 23);
        _Label4.TabIndex = 0;
        _Label4.Text = "F - Item is always free";
        // 
        // btnJoinGroup
        // 
        _btnJoinGroup.ForeColor = System.Drawing.Color.White;
        _btnJoinGroup.Location = new System.Drawing.Point(466, 456);
        _btnJoinGroup.Name = "_btnJoinGroup";
        _btnJoinGroup.Size = new System.Drawing.Size(72, 48);
        _btnJoinGroup.TabIndex = 19;
        _btnJoinGroup.Text = "Auto / Group";
        // 
        // btnJoinFoodRemoveIndividual
        // 
        _btnJoinFoodRemoveIndividual.ForeColor = System.Drawing.Color.Silver;
        _btnJoinFoodRemoveIndividual.Location = new System.Drawing.Point(400, 48);
        _btnJoinFoodRemoveIndividual.Name = "_btnJoinFoodRemoveIndividual";
        _btnJoinFoodRemoveIndividual.Size = new System.Drawing.Size(88, 40);
        _btnJoinFoodRemoveIndividual.TabIndex = 17;
        _btnJoinFoodRemoveIndividual.Text = "Remove";
        // 
        // btnJoinFoodRemoveCategory
        // 
        _btnJoinFoodRemoveCategory.ForeColor = System.Drawing.Color.Silver;
        _btnJoinFoodRemoveCategory.Location = new System.Drawing.Point(256, 48);
        _btnJoinFoodRemoveCategory.Name = "_btnJoinFoodRemoveCategory";
        _btnJoinFoodRemoveCategory.Size = new System.Drawing.Size(88, 40);
        _btnJoinFoodRemoveCategory.TabIndex = 16;
        _btnJoinFoodRemoveCategory.Text = "Remove";
        // 
        // grdJoinFoodModifierJoins
        // 
        _grdJoinFoodModifierJoins.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
        _grdJoinFoodModifierJoins.CaptionText = "     Individual Modifiers";
        _grdJoinFoodModifierJoins.ColumnHeadersVisible = false;
        _grdJoinFoodModifierJoins.DataMember = "";
        _grdJoinFoodModifierJoins.HeaderForeColor = System.Drawing.SystemColors.ControlText;
        _grdJoinFoodModifierJoins.Location = new System.Drawing.Point(376, 88);
        _grdJoinFoodModifierJoins.Name = "_grdJoinFoodModifierJoins";
        _grdJoinFoodModifierJoins.ReadOnly = true;
        _grdJoinFoodModifierJoins.Size = new System.Drawing.Size(152, 200);
        _grdJoinFoodModifierJoins.TabIndex = 15;
        // 
        // btnJoinFree
        // 
        _btnJoinFree.ForeColor = System.Drawing.Color.White;
        _btnJoinFree.Location = new System.Drawing.Point(379, 456);
        _btnJoinFree.Name = "_btnJoinFree";
        _btnJoinFree.Size = new System.Drawing.Size(76, 48);
        _btnJoinFree.TabIndex = 14;
        _btnJoinFree.Text = "Free / Surcharge";
        // 
        // grdJoinFoodChoice
        // 
        _grdJoinFoodChoice.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
        _grdJoinFoodChoice.CaptionText = "             Food Choices";
        _grdJoinFoodChoice.ColumnHeadersVisible = false;
        _grdJoinFoodChoice.DataMember = "";
        _grdJoinFoodChoice.HeaderForeColor = System.Drawing.SystemColors.ControlText;
        _grdJoinFoodChoice.Location = new System.Drawing.Point(24, 88);
        _grdJoinFoodChoice.Name = "_grdJoinFoodChoice";
        _grdJoinFoodChoice.ReadOnly = true;
        _grdJoinFoodChoice.Size = new System.Drawing.Size(176, 344);
        _grdJoinFoodChoice.TabIndex = 13;
        // 
        // cbxJoinCategorySelect
        // 
        _cbxJoinCategorySelect.Location = new System.Drawing.Point(24, 56);
        _cbxJoinCategorySelect.MaxDropDownItems = 16;
        _cbxJoinCategorySelect.Name = "_cbxJoinCategorySelect";
        _cbxJoinCategorySelect.Size = new System.Drawing.Size(176, 21);
        _cbxJoinCategorySelect.TabIndex = 12;
        _cbxJoinCategorySelect.Text = "Select Food Category";
        // 
        // lblJoinFoodSelected
        // 
        _lblJoinFoodSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblJoinFoodSelected.ForeColor = System.Drawing.Color.Silver;
        _lblJoinFoodSelected.Location = new System.Drawing.Point(224, 8);
        _lblJoinFoodSelected.Name = "_lblJoinFoodSelected";
        _lblJoinFoodSelected.Size = new System.Drawing.Size(304, 40);
        _lblJoinFoodSelected.TabIndex = 11;
        _lblJoinFoodSelected.Text = "Please Select A Food Item";
        _lblJoinFoodSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // grdJoinFoodCategoryJoins
        // 
        _grdJoinFoodCategoryJoins.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
        _grdJoinFoodCategoryJoins.CaptionText = "           Categories";
        _grdJoinFoodCategoryJoins.ColumnHeadersVisible = false;
        _grdJoinFoodCategoryJoins.DataMember = "";
        _grdJoinFoodCategoryJoins.HeaderForeColor = System.Drawing.SystemColors.ControlText;
        _grdJoinFoodCategoryJoins.Location = new System.Drawing.Point(224, 88);
        _grdJoinFoodCategoryJoins.Name = "_grdJoinFoodCategoryJoins";
        _grdJoinFoodCategoryJoins.ReadOnly = true;
        _grdJoinFoodCategoryJoins.Size = new System.Drawing.Size(144, 200);
        _grdJoinFoodCategoryJoins.TabIndex = 3;
        // 
        // cbxJoinIndividualModifierSelect
        // 
        _cbxJoinIndividualModifierSelect.Location = new System.Drawing.Point(552, 280);
        _cbxJoinIndividualModifierSelect.MaxDropDownItems = 16;
        _cbxJoinIndividualModifierSelect.Name = "_cbxJoinIndividualModifierSelect";
        _cbxJoinIndividualModifierSelect.Size = new System.Drawing.Size(168, 21);
        _cbxJoinIndividualModifierSelect.TabIndex = 2;
        _cbxJoinIndividualModifierSelect.Text = "Select Modifier Category";
        // 
        // grdJoinIndividualModifiers
        // 
        _grdJoinIndividualModifiers.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
        _grdJoinIndividualModifiers.CaptionText = "           Individual Items";
        _grdJoinIndividualModifiers.ColumnHeadersVisible = false;
        _grdJoinIndividualModifiers.DataMember = "";
        _grdJoinIndividualModifiers.HeaderForeColor = System.Drawing.SystemColors.ControlText;
        _grdJoinIndividualModifiers.Location = new System.Drawing.Point(552, 304);
        _grdJoinIndividualModifiers.Name = "_grdJoinIndividualModifiers";
        _grdJoinIndividualModifiers.ReadOnly = true;
        _grdJoinIndividualModifiers.Size = new System.Drawing.Size(168, 200);
        _grdJoinIndividualModifiers.TabIndex = 1;
        // 
        // grdJoinPossibleCategories
        // 
        _grdJoinPossibleCategories.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
        _grdJoinPossibleCategories.CaptionText = "       Possible Categories";
        _grdJoinPossibleCategories.ColumnHeadersVisible = false;
        _grdJoinPossibleCategories.DataMember = "";
        _grdJoinPossibleCategories.HeaderForeColor = System.Drawing.SystemColors.ControlText;
        _grdJoinPossibleCategories.Location = new System.Drawing.Point(552, 8);
        _grdJoinPossibleCategories.Name = "_grdJoinPossibleCategories";
        _grdJoinPossibleCategories.ReadOnly = true;
        _grdJoinPossibleCategories.Size = new System.Drawing.Size(168, 264);
        _grdJoinPossibleCategories.TabIndex = 0;
        // 
        // TabControl1
        // 
        _TabControl1.Controls.Add(_tabCategory);
        _TabControl1.Controls.Add(_TabMainFood);
        _TabControl1.Controls.Add(_TabModifiers);
        _TabControl1.Controls.Add(_TabFoodJoin);
        _TabControl1.Controls.Add(_TabDrinkCategory);
        _TabControl1.Controls.Add(_TabDrinks);
        _TabControl1.Controls.Add(_TabDrinkPrep);
        _TabControl1.Controls.Add(_TabMenuSetup);
        _TabControl1.Controls.Add(_TabFoodOrder);
        _TabControl1.ItemSize = new System.Drawing.Size(54, 18);
        _TabControl1.Location = new System.Drawing.Point(24, 140);
        _TabControl1.Name = "_TabControl1";
        _TabControl1.SelectedIndex = 0;
        _TabControl1.Size = new System.Drawing.Size(848, 576);
        _TabControl1.TabIndex = 11;
        _TabControl1.TabStop = false;
        // 
        // TabDrinkCategory
        // 
        _TabDrinkCategory.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _TabDrinkCategory.Controls.Add(_Label30);
        _TabDrinkCategory.Controls.Add(_btnDrinkCategoryColor);
        _TabDrinkCategory.Controls.Add(_pnlDrinkModifiers);
        _TabDrinkCategory.Controls.Add(_pnlIsLiquorType);
        _TabDrinkCategory.Controls.Add(_lblDrinkCategoryName);
        _TabDrinkCategory.Controls.Add(_btnDrinkCategoryName);
        _TabDrinkCategory.Controls.Add(_txtDrinkCategoryName);
        _TabDrinkCategory.Controls.Add(_pnlDrinkCategory);
        _TabDrinkCategory.Location = new System.Drawing.Point(4, 22);
        _TabDrinkCategory.Name = "_TabDrinkCategory";
        _TabDrinkCategory.Size = new System.Drawing.Size(840, 550);
        _TabDrinkCategory.TabIndex = 4;
        _TabDrinkCategory.Text = "Bar Category";
        // 
        // Label30
        // 
        _Label30.Location = new System.Drawing.Point(131, 13);
        _Label30.Name = "_Label30";
        _Label30.Size = new System.Drawing.Size(160, 43);
        _Label30.TabIndex = 31;
        _Label30.Text = "Only use if you have a Full Bar. Otherwise place drinks in the Kitchen && Food Ca" + "tegory.";
        // 
        // btnDrinkCategoryColor
        // 
        _btnDrinkCategoryColor.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _btnDrinkCategoryColor.ForeColor = System.Drawing.Color.White;
        _btnDrinkCategoryColor.Location = new System.Drawing.Point(328, 16);
        _btnDrinkCategoryColor.Name = "_btnDrinkCategoryColor";
        _btnDrinkCategoryColor.Size = new System.Drawing.Size(88, 40);
        _btnDrinkCategoryColor.TabIndex = 30;
        _btnDrinkCategoryColor.Text = "Button Color";
        _btnDrinkCategoryColor.UseVisualStyleBackColor = false;
        // 
        // pnlDrinkModifiers
        // 
        _pnlDrinkModifiers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        _pnlDrinkModifiers.Controls.Add(_btnDrinkPrices);
        _pnlDrinkModifiers.Controls.Add(_txtDrinkSplash);
        _pnlDrinkModifiers.Controls.Add(_txtDrinkTall);
        _pnlDrinkModifiers.Controls.Add(_txtDrinkUp);
        _pnlDrinkModifiers.Controls.Add(_txtDrinkRocks);
        _pnlDrinkModifiers.Controls.Add(_txtDrinkDouble);
        _pnlDrinkModifiers.Controls.Add(_lblDrinkSplash);
        _pnlDrinkModifiers.Controls.Add(_lblDrinkTall);
        _pnlDrinkModifiers.Controls.Add(_lblDrinkUp);
        _pnlDrinkModifiers.Controls.Add(_lblDrinkRocks);
        _pnlDrinkModifiers.Controls.Add(_lblDrinkDouble);
        _pnlDrinkModifiers.Location = new System.Drawing.Point(504, 272);
        _pnlDrinkModifiers.Name = "_pnlDrinkModifiers";
        _pnlDrinkModifiers.Size = new System.Drawing.Size(208, 224);
        _pnlDrinkModifiers.TabIndex = 6;
        _pnlDrinkModifiers.Visible = false;
        // 
        // btnDrinkPrices
        // 
        _btnDrinkPrices.Location = new System.Drawing.Point(48, 184);
        _btnDrinkPrices.Name = "_btnDrinkPrices";
        _btnDrinkPrices.Size = new System.Drawing.Size(128, 32);
        _btnDrinkPrices.TabIndex = 10;
        _btnDrinkPrices.Text = "Update Prices";
        // 
        // txtDrinkSplash
        // 
        _txtDrinkSplash.Location = new System.Drawing.Point(128, 152);
        _txtDrinkSplash.Name = "_txtDrinkSplash";
        _txtDrinkSplash.Size = new System.Drawing.Size(48, 20);
        _txtDrinkSplash.TabIndex = 9;
        // 
        // txtDrinkTall
        // 
        _txtDrinkTall.Location = new System.Drawing.Point(128, 120);
        _txtDrinkTall.Name = "_txtDrinkTall";
        _txtDrinkTall.Size = new System.Drawing.Size(48, 20);
        _txtDrinkTall.TabIndex = 8;
        // 
        // txtDrinkUp
        // 
        _txtDrinkUp.Location = new System.Drawing.Point(128, 88);
        _txtDrinkUp.Name = "_txtDrinkUp";
        _txtDrinkUp.Size = new System.Drawing.Size(48, 20);
        _txtDrinkUp.TabIndex = 7;
        // 
        // txtDrinkRocks
        // 
        _txtDrinkRocks.Location = new System.Drawing.Point(128, 56);
        _txtDrinkRocks.Name = "_txtDrinkRocks";
        _txtDrinkRocks.Size = new System.Drawing.Size(48, 20);
        _txtDrinkRocks.TabIndex = 6;
        // 
        // txtDrinkDouble
        // 
        _txtDrinkDouble.Location = new System.Drawing.Point(128, 24);
        _txtDrinkDouble.Name = "_txtDrinkDouble";
        _txtDrinkDouble.Size = new System.Drawing.Size(48, 20);
        _txtDrinkDouble.TabIndex = 5;
        // 
        // lblDrinkSplash
        // 
        _lblDrinkSplash.Location = new System.Drawing.Point(24, 152);
        _lblDrinkSplash.Name = "_lblDrinkSplash";
        _lblDrinkSplash.Size = new System.Drawing.Size(88, 16);
        _lblDrinkSplash.TabIndex = 4;
        _lblDrinkSplash.Text = "Splash:";
        _lblDrinkSplash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblDrinkTall
        // 
        _lblDrinkTall.Location = new System.Drawing.Point(16, 120);
        _lblDrinkTall.Name = "_lblDrinkTall";
        _lblDrinkTall.Size = new System.Drawing.Size(88, 16);
        _lblDrinkTall.TabIndex = 3;
        _lblDrinkTall.Text = "Tall:";
        _lblDrinkTall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblDrinkUp
        // 
        _lblDrinkUp.Location = new System.Drawing.Point(16, 88);
        _lblDrinkUp.Name = "_lblDrinkUp";
        _lblDrinkUp.Size = new System.Drawing.Size(88, 16);
        _lblDrinkUp.TabIndex = 2;
        _lblDrinkUp.Text = "Up:";
        _lblDrinkUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblDrinkRocks
        // 
        _lblDrinkRocks.Location = new System.Drawing.Point(16, 56);
        _lblDrinkRocks.Name = "_lblDrinkRocks";
        _lblDrinkRocks.Size = new System.Drawing.Size(88, 16);
        _lblDrinkRocks.TabIndex = 1;
        _lblDrinkRocks.Text = "Rocks:";
        _lblDrinkRocks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblDrinkDouble
        // 
        _lblDrinkDouble.Location = new System.Drawing.Point(16, 24);
        _lblDrinkDouble.Name = "_lblDrinkDouble";
        _lblDrinkDouble.Size = new System.Drawing.Size(88, 16);
        _lblDrinkDouble.TabIndex = 0;
        _lblDrinkDouble.Text = "Double:";
        _lblDrinkDouble.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // pnlIsLiquorType
        // 
        _pnlIsLiquorType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        _pnlIsLiquorType.Controls.Add(_lblIsLiquorType);
        _pnlIsLiquorType.Controls.Add(_chkLiquorType);
        _pnlIsLiquorType.Location = new System.Drawing.Point(504, 104);
        _pnlIsLiquorType.Name = "_pnlIsLiquorType";
        _pnlIsLiquorType.Size = new System.Drawing.Size(200, 88);
        _pnlIsLiquorType.TabIndex = 5;
        // 
        // lblIsLiquorType
        // 
        _lblIsLiquorType.Location = new System.Drawing.Point(16, 40);
        _lblIsLiquorType.Name = "_lblIsLiquorType";
        _lblIsLiquorType.Size = new System.Drawing.Size(168, 40);
        _lblIsLiquorType.TabIndex = 5;
        _lblIsLiquorType.Text = "If checked, only place Brand Names under Category.          (ie. Vodka is a Liqou" + "r Type)";
        _lblIsLiquorType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // chkLiquorType
        // 
        _chkLiquorType.Location = new System.Drawing.Point(40, 8);
        _chkLiquorType.Name = "_chkLiquorType";
        _chkLiquorType.Size = new System.Drawing.Size(120, 24);
        _chkLiquorType.TabIndex = 4;
        _chkLiquorType.Text = "Is a Liquor Type?";
        // 
        // lblDrinkCategoryName
        // 
        _lblDrinkCategoryName.Location = new System.Drawing.Point(544, 40);
        _lblDrinkCategoryName.Name = "_lblDrinkCategoryName";
        _lblDrinkCategoryName.Size = new System.Drawing.Size(120, 16);
        _lblDrinkCategoryName.TabIndex = 4;
        _lblDrinkCategoryName.Text = "Category Name:";
        // 
        // btnDrinkCategoryName
        // 
        _btnDrinkCategoryName.Location = new System.Drawing.Point(552, 208);
        _btnDrinkCategoryName.Name = "_btnDrinkCategoryName";
        _btnDrinkCategoryName.Size = new System.Drawing.Size(112, 40);
        _btnDrinkCategoryName.TabIndex = 2;
        _btnDrinkCategoryName.Text = "Remove Category";
        _btnDrinkCategoryName.Visible = false;
        // 
        // txtDrinkCategoryName
        // 
        _txtDrinkCategoryName.Location = new System.Drawing.Point(488, 64);
        _txtDrinkCategoryName.Name = "_txtDrinkCategoryName";
        _txtDrinkCategoryName.Size = new System.Drawing.Size(232, 20);
        _txtDrinkCategoryName.TabIndex = 1;
        // 
        // pnlDrinkCategory
        // 
        _pnlDrinkCategory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        _pnlDrinkCategory.Location = new System.Drawing.Point(16, 64);
        _pnlDrinkCategory.Name = "_pnlDrinkCategory";
        _pnlDrinkCategory.Size = new System.Drawing.Size(448, 440);
        _pnlDrinkCategory.TabIndex = 0;
        // 
        // TabDrinks
        // 
        _TabDrinks.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _TabDrinks.Controls.Add(_lblDrinkHappyPrice);
        _TabDrinks.Controls.Add(_txtDrinkHappyPrice);
        _TabDrinks.Controls.Add(_Label3);
        _TabDrinks.Controls.Add(_cbxDrinkFunction);
        _TabDrinks.Controls.Add(_chkWineParring);
        _TabDrinks.Controls.Add(_txtAddOnPrice);
        _TabDrinks.Controls.Add(_Panel3);
        _TabDrinks.Controls.Add(_btnBackToCategory);
        _TabDrinks.Controls.Add(_txtDrinkDesc);
        _TabDrinks.Controls.Add(_chkIsAddOn);
        _TabDrinks.Controls.Add(_chkSelectAddOn);
        _TabDrinks.Controls.Add(_lblDrinkDescLabel);
        _TabDrinks.Controls.Add(_lblDrinkCost);
        _TabDrinks.Controls.Add(_txtDrinkPrice);
        _TabDrinks.Controls.Add(_txtDrinkName);
        _TabDrinks.Controls.Add(_lblDrinkName);
        _TabDrinks.Controls.Add(_pnlDrinks);
        _TabDrinks.Controls.Add(_pnlDrinkByCategory);
        _TabDrinks.Location = new System.Drawing.Point(4, 22);
        _TabDrinks.Name = "_TabDrinks";
        _TabDrinks.Size = new System.Drawing.Size(840, 550);
        _TabDrinks.TabIndex = 5;
        _TabDrinks.Text = "Bar Drinks";
        // 
        // lblDrinkHappyPrice
        // 
        _lblDrinkHappyPrice.Location = new System.Drawing.Point(488, 433);
        _lblDrinkHappyPrice.Name = "_lblDrinkHappyPrice";
        _lblDrinkHappyPrice.Size = new System.Drawing.Size(120, 16);
        _lblDrinkHappyPrice.TabIndex = 22;
        _lblDrinkHappyPrice.Text = "Happy Hour Price:";
        _lblDrinkHappyPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtDrinkHappyPrice
        // 
        _txtDrinkHappyPrice.Location = new System.Drawing.Point(632, 433);
        _txtDrinkHappyPrice.Name = "_txtDrinkHappyPrice";
        _txtDrinkHappyPrice.Size = new System.Drawing.Size(88, 20);
        _txtDrinkHappyPrice.TabIndex = 21;
        // 
        // Label3
        // 
        _Label3.Location = new System.Drawing.Point(496, 80);
        _Label3.Name = "_Label3";
        _Label3.Size = new System.Drawing.Size(80, 16);
        _Label3.TabIndex = 20;
        _Label3.Text = "Tax Category:";
        _Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // cbxDrinkFunction
        // 
        _cbxDrinkFunction.Location = new System.Drawing.Point(584, 80);
        _cbxDrinkFunction.Name = "_cbxDrinkFunction";
        _cbxDrinkFunction.Size = new System.Drawing.Size(136, 21);
        _cbxDrinkFunction.TabIndex = 3;
        // 
        // chkWineParring
        // 
        _chkWineParring.Location = new System.Drawing.Point(488, 288);
        _chkWineParring.Name = "_chkWineParring";
        _chkWineParring.Size = new System.Drawing.Size(152, 24);
        _chkWineParring.TabIndex = 18;
        _chkWineParring.TabStop = false;
        _chkWineParring.Text = "Used as Wine Parring";
        // 
        // txtAddOnPrice
        // 
        _txtAddOnPrice.Location = new System.Drawing.Point(608, 256);
        _txtAddOnPrice.Name = "_txtAddOnPrice";
        _txtAddOnPrice.Size = new System.Drawing.Size(112, 20);
        _txtAddOnPrice.TabIndex = 5;
        _txtAddOnPrice.Text = "Add-on Price";
        // 
        // Panel3
        // 
        _Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        _Panel3.Controls.Add(_lblCallLiquor);
        _Panel3.Controls.Add(_cbxLiquorType);
        _Panel3.Controls.Add(_txtCallPrice);
        _Panel3.Controls.Add(_lblCallPrice);
        _Panel3.Location = new System.Drawing.Point(480, 320);
        _Panel3.Name = "_Panel3";
        _Panel3.Size = new System.Drawing.Size(240, 96);
        _Panel3.TabIndex = 16;
        // 
        // lblCallLiquor
        // 
        _lblCallLiquor.Location = new System.Drawing.Point(24, 8);
        _lblCallLiquor.Name = "_lblCallLiquor";
        _lblCallLiquor.Size = new System.Drawing.Size(192, 16);
        _lblCallLiquor.TabIndex = 19;
        _lblCallLiquor.Text = "For Call Liquor Requests Only:";
        _lblCallLiquor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // cbxLiquorType
        // 
        _cbxLiquorType.Location = new System.Drawing.Point(24, 32);
        _cbxLiquorType.Name = "_cbxLiquorType";
        _cbxLiquorType.Size = new System.Drawing.Size(196, 21);
        _cbxLiquorType.TabIndex = 18;
        _cbxLiquorType.TabStop = false;
        _cbxLiquorType.Text = "Liquor Type";
        // 
        // txtCallPrice
        // 
        _txtCallPrice.Location = new System.Drawing.Point(120, 64);
        _txtCallPrice.Name = "_txtCallPrice";
        _txtCallPrice.Size = new System.Drawing.Size(96, 20);
        _txtCallPrice.TabIndex = 17;
        _txtCallPrice.TabStop = false;
        // 
        // lblCallPrice
        // 
        _lblCallPrice.Location = new System.Drawing.Point(16, 64);
        _lblCallPrice.Name = "_lblCallPrice";
        _lblCallPrice.Size = new System.Drawing.Size(96, 16);
        _lblCallPrice.TabIndex = 16;
        _lblCallPrice.Text = "Brand Surcharge:";
        _lblCallPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // btnBackToCategory
        // 
        _btnBackToCategory.ForeColor = System.Drawing.Color.White;
        _btnBackToCategory.Location = new System.Drawing.Point(80, 16);
        _btnBackToCategory.Name = "_btnBackToCategory";
        _btnBackToCategory.Size = new System.Drawing.Size(112, 40);
        _btnBackToCategory.TabIndex = 13;
        _btnBackToCategory.Text = "Back To Category";
        // 
        // txtDrinkDesc
        // 
        _txtDrinkDesc.Location = new System.Drawing.Point(480, 120);
        _txtDrinkDesc.Name = "_txtDrinkDesc";
        _txtDrinkDesc.Size = new System.Drawing.Size(240, 96);
        _txtDrinkDesc.TabIndex = 4;
        _txtDrinkDesc.Text = "";
        // 
        // chkIsAddOn
        // 
        _chkIsAddOn.Location = new System.Drawing.Point(488, 256);
        _chkIsAddOn.Name = "_chkIsAddOn";
        _chkIsAddOn.Size = new System.Drawing.Size(112, 24);
        _chkIsAddOn.TabIndex = 10;
        _chkIsAddOn.TabStop = false;
        _chkIsAddOn.Text = "Used as Add-On";
        // 
        // chkSelectAddOn
        // 
        _chkSelectAddOn.Location = new System.Drawing.Point(488, 224);
        _chkSelectAddOn.Name = "_chkSelectAddOn";
        _chkSelectAddOn.Size = new System.Drawing.Size(120, 24);
        _chkSelectAddOn.TabIndex = 9;
        _chkSelectAddOn.TabStop = false;
        _chkSelectAddOn.Text = "Select Add-On";
        // 
        // lblDrinkDescLabel
        // 
        _lblDrinkDescLabel.Location = new System.Drawing.Point(488, 104);
        _lblDrinkDescLabel.Name = "_lblDrinkDescLabel";
        _lblDrinkDescLabel.Size = new System.Drawing.Size(88, 16);
        _lblDrinkDescLabel.TabIndex = 8;
        _lblDrinkDescLabel.Text = "Description:";
        _lblDrinkDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblDrinkCost
        // 
        _lblDrinkCost.Location = new System.Drawing.Point(488, 48);
        _lblDrinkCost.Name = "_lblDrinkCost";
        _lblDrinkCost.Size = new System.Drawing.Size(88, 16);
        _lblDrinkCost.TabIndex = 6;
        _lblDrinkCost.Text = "Drink Price:";
        _lblDrinkCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtDrinkPrice
        // 
        _txtDrinkPrice.Location = new System.Drawing.Point(632, 48);
        _txtDrinkPrice.Name = "_txtDrinkPrice";
        _txtDrinkPrice.Size = new System.Drawing.Size(88, 20);
        _txtDrinkPrice.TabIndex = 2;
        // 
        // txtDrinkName
        // 
        _txtDrinkName.Location = new System.Drawing.Point(584, 16);
        _txtDrinkName.Name = "_txtDrinkName";
        _txtDrinkName.Size = new System.Drawing.Size(136, 20);
        _txtDrinkName.TabIndex = 1;
        // 
        // lblDrinkName
        // 
        _lblDrinkName.Location = new System.Drawing.Point(488, 16);
        _lblDrinkName.Name = "_lblDrinkName";
        _lblDrinkName.Size = new System.Drawing.Size(88, 16);
        _lblDrinkName.TabIndex = 2;
        _lblDrinkName.Text = "Drink Name:";
        _lblDrinkName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // pnlDrinks
        // 
        _pnlDrinks.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        _pnlDrinks.Location = new System.Drawing.Point(16, 64);
        _pnlDrinks.Name = "_pnlDrinks";
        _pnlDrinks.Size = new System.Drawing.Size(360, 344);
        _pnlDrinks.TabIndex = 1;
        // 
        // pnlDrinkByCategory
        // 
        _pnlDrinkByCategory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        _pnlDrinkByCategory.Location = new System.Drawing.Point(16, 64);
        _pnlDrinkByCategory.Name = "_pnlDrinkByCategory";
        _pnlDrinkByCategory.Size = new System.Drawing.Size(448, 440);
        _pnlDrinkByCategory.TabIndex = 0;
        _pnlDrinkByCategory.Visible = false;
        // 
        // TabDrinkPrep
        // 
        _TabDrinkPrep.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _TabDrinkPrep.Controls.Add(_Label25);
        _TabDrinkPrep.Location = new System.Drawing.Point(4, 22);
        _TabDrinkPrep.Name = "_TabDrinkPrep";
        _TabDrinkPrep.Size = new System.Drawing.Size(840, 550);
        _TabDrinkPrep.TabIndex = 8;
        _TabDrinkPrep.Text = "Drink Prep";
        // 
        // Label25
        // 
        _Label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label25.ForeColor = System.Drawing.Color.White;
        _Label25.Location = new System.Drawing.Point(672, 384);
        _Label25.Name = "_Label25";
        _Label25.Size = new System.Drawing.Size(152, 120);
        _Label25.TabIndex = 0;
        _Label25.Text = "Only selected Drink Preps will display alphabetically. Place a number under Order" + " ONLY if you want to prioritze higher (otherwise leave blank). ";
        // 
        // TabMenuSetup
        // 
        _TabMenuSetup.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _TabMenuSetup.Controls.Add(_btnMenuBartender);
        _TabMenuSetup.Controls.Add(_lblMenuSetup);
        _TabMenuSetup.Controls.Add(_lblMenuPage2);
        _TabMenuSetup.Controls.Add(_lblMenuPage1);
        _TabMenuSetup.Controls.Add(_pnlMenuUpdate);
        _TabMenuSetup.Controls.Add(_menuActiveBox);
        _TabMenuSetup.Controls.Add(_btnMenuGeneralDrink);
        _TabMenuSetup.Controls.Add(_lblMenuSelectButtonText);
        _TabMenuSetup.Controls.Add(_cbxMenuDrink);
        _TabMenuSetup.Controls.Add(_cbxMenuMainFood);
        _TabMenuSetup.Controls.Add(_pnlMenuPage2);
        _TabMenuSetup.Controls.Add(_pnlMenuPage1);
        _TabMenuSetup.Controls.Add(_cbxMenuSelection);
        _TabMenuSetup.ForeColor = System.Drawing.Color.White;
        _TabMenuSetup.Location = new System.Drawing.Point(4, 22);
        _TabMenuSetup.Name = "_TabMenuSetup";
        _TabMenuSetup.Size = new System.Drawing.Size(840, 550);
        _TabMenuSetup.TabIndex = 6;
        _TabMenuSetup.Text = "Menu Setup";
        // 
        // btnMenuBartender
        // 
        _btnMenuBartender.BackColor = System.Drawing.Color.Firebrick;
        _btnMenuBartender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _btnMenuBartender.Location = new System.Drawing.Point(30, 75);
        _btnMenuBartender.Name = "_btnMenuBartender";
        _btnMenuBartender.Size = new System.Drawing.Size(136, 40);
        _btnMenuBartender.TabIndex = 20;
        _btnMenuBartender.Text = "Table Service";
        _btnMenuBartender.UseVisualStyleBackColor = false;
        // 
        // lblMenuSetup
        // 
        _lblMenuSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblMenuSetup.ForeColor = System.Drawing.Color.Silver;
        _lblMenuSetup.Location = new System.Drawing.Point(264, 16);
        _lblMenuSetup.Name = "_lblMenuSetup";
        _lblMenuSetup.Size = new System.Drawing.Size(248, 32);
        _lblMenuSetup.TabIndex = 19;
        _lblMenuSetup.Text = "Select Menu && Service";
        _lblMenuSetup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblMenuPage2
        // 
        _lblMenuPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblMenuPage2.ForeColor = System.Drawing.Color.Silver;
        _lblMenuPage2.Location = new System.Drawing.Point(408, 64);
        _lblMenuPage2.Name = "_lblMenuPage2";
        _lblMenuPage2.Size = new System.Drawing.Size(112, 24);
        _lblMenuPage2.TabIndex = 18;
        _lblMenuPage2.Text = "Page 2";
        _lblMenuPage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblMenuPage1
        // 
        _lblMenuPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblMenuPage1.ForeColor = System.Drawing.Color.Silver;
        _lblMenuPage1.Location = new System.Drawing.Point(248, 64);
        _lblMenuPage1.Name = "_lblMenuPage1";
        _lblMenuPage1.Size = new System.Drawing.Size(112, 24);
        _lblMenuPage1.TabIndex = 17;
        _lblMenuPage1.Text = "Page 1";
        _lblMenuPage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pnlMenuUpdate
        // 
        _pnlMenuUpdate.BackColor = System.Drawing.SystemColors.Control;
        _pnlMenuUpdate.Controls.Add(_btnRemoveMenuChoices);
        _pnlMenuUpdate.Controls.Add(_BtnUpdateMenuChoices);
        _pnlMenuUpdate.Location = new System.Drawing.Point(568, 432);
        _pnlMenuUpdate.Name = "_pnlMenuUpdate";
        _pnlMenuUpdate.Size = new System.Drawing.Size(136, 72);
        _pnlMenuUpdate.TabIndex = 16;
        _pnlMenuUpdate.Visible = false;
        // 
        // btnRemoveMenuChoices
        // 
        _btnRemoveMenuChoices.BackColor = System.Drawing.SystemColors.Desktop;
        _btnRemoveMenuChoices.Location = new System.Drawing.Point(8, 40);
        _btnRemoveMenuChoices.Name = "_btnRemoveMenuChoices";
        _btnRemoveMenuChoices.Size = new System.Drawing.Size(120, 24);
        _btnRemoveMenuChoices.TabIndex = 1;
        _btnRemoveMenuChoices.Text = "Remove Category";
        _btnRemoveMenuChoices.UseVisualStyleBackColor = false;
        // 
        // BtnUpdateMenuChoices
        // 
        _BtnUpdateMenuChoices.BackColor = System.Drawing.SystemColors.Desktop;
        _BtnUpdateMenuChoices.Location = new System.Drawing.Point(8, 8);
        _BtnUpdateMenuChoices.Name = "_BtnUpdateMenuChoices";
        _BtnUpdateMenuChoices.Size = new System.Drawing.Size(120, 24);
        _BtnUpdateMenuChoices.TabIndex = 0;
        _BtnUpdateMenuChoices.Text = "Update Menu";
        _BtnUpdateMenuChoices.UseVisualStyleBackColor = false;
        // 
        // menuActiveBox
        // 
        _menuActiveBox.Location = new System.Drawing.Point(46, 152);
        _menuActiveBox.Name = "_menuActiveBox";
        _menuActiveBox.Size = new System.Drawing.Size(120, 136);
        _menuActiveBox.TabIndex = 15;
        _menuActiveBox.TabStop = false;
        _menuActiveBox.Text = "Active Menus";
        // 
        // btnMenuGeneralDrink
        // 
        _btnMenuGeneralDrink.Location = new System.Drawing.Point(568, 192);
        _btnMenuGeneralDrink.Name = "_btnMenuGeneralDrink";
        _btnMenuGeneralDrink.Size = new System.Drawing.Size(136, 24);
        _btnMenuGeneralDrink.TabIndex = 6;
        _btnMenuGeneralDrink.Text = "General Drink Button";
        // 
        // lblMenuSelectButtonText
        // 
        _lblMenuSelectButtonText.Location = new System.Drawing.Point(544, 64);
        _lblMenuSelectButtonText.Name = "_lblMenuSelectButtonText";
        _lblMenuSelectButtonText.Size = new System.Drawing.Size(168, 32);
        _lblMenuSelectButtonText.TabIndex = 5;
        _lblMenuSelectButtonText.Text = "Select Either a Main Food or Drink Category";
        _lblMenuSelectButtonText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // cbxMenuDrink
        // 
        _cbxMenuDrink.Location = new System.Drawing.Point(544, 152);
        _cbxMenuDrink.MaxDropDownItems = 16;
        _cbxMenuDrink.Name = "_cbxMenuDrink";
        _cbxMenuDrink.Size = new System.Drawing.Size(176, 21);
        _cbxMenuDrink.TabIndex = 4;
        _cbxMenuDrink.Text = "Select Drink Category";
        // 
        // cbxMenuMainFood
        // 
        _cbxMenuMainFood.Location = new System.Drawing.Point(544, 112);
        _cbxMenuMainFood.MaxDropDownItems = 16;
        _cbxMenuMainFood.Name = "_cbxMenuMainFood";
        _cbxMenuMainFood.Size = new System.Drawing.Size(176, 21);
        _cbxMenuMainFood.TabIndex = 3;
        _cbxMenuMainFood.Text = "Select Main Food";
        // 
        // pnlMenuPage2
        // 
        _pnlMenuPage2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        _pnlMenuPage2.ForeColor = System.Drawing.Color.Black;
        _pnlMenuPage2.Location = new System.Drawing.Point(400, 96);
        _pnlMenuPage2.Name = "_pnlMenuPage2";
        _pnlMenuPage2.Size = new System.Drawing.Size(128, 336);
        _pnlMenuPage2.TabIndex = 2;
        // 
        // pnlMenuPage1
        // 
        _pnlMenuPage1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        _pnlMenuPage1.ForeColor = System.Drawing.Color.Black;
        _pnlMenuPage1.Location = new System.Drawing.Point(240, 96);
        _pnlMenuPage1.Name = "_pnlMenuPage1";
        _pnlMenuPage1.Size = new System.Drawing.Size(128, 336);
        _pnlMenuPage1.TabIndex = 1;
        // 
        // cbxMenuSelection
        // 
        _cbxMenuSelection.Location = new System.Drawing.Point(21, 37);
        _cbxMenuSelection.Name = "_cbxMenuSelection";
        _cbxMenuSelection.Size = new System.Drawing.Size(168, 21);
        _cbxMenuSelection.TabIndex = 0;
        _cbxMenuSelection.Text = "Choose Menu";
        // 
        // TabFoodOrder
        // 
        _TabFoodOrder.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _TabFoodOrder.Controls.Add(_pnlOrderPage);
        _TabFoodOrder.Controls.Add(_cbxOrderSubCategroy);
        _TabFoodOrder.Controls.Add(_lblOrderDesc1);
        _TabFoodOrder.Controls.Add(_btnOrderDown);
        _TabFoodOrder.Controls.Add(_btnOrderUp);
        _TabFoodOrder.Controls.Add(_Panel4);
        _TabFoodOrder.Controls.Add(_lblOrderCategoryName);
        _TabFoodOrder.Controls.Add(_cbxOrderCategorySelection);
        _TabFoodOrder.Controls.Add(_pnlOrderFoodStaging);
        _TabFoodOrder.Controls.Add(_pnlOrderFoodItems);
        _TabFoodOrder.Controls.Add(_lblOrderMenuName);
        _TabFoodOrder.Controls.Add(_cbxOrderMenuSelection);
        _TabFoodOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _TabFoodOrder.Location = new System.Drawing.Point(4, 22);
        _TabFoodOrder.Name = "_TabFoodOrder";
        _TabFoodOrder.Size = new System.Drawing.Size(840, 550);
        _TabFoodOrder.TabIndex = 7;
        _TabFoodOrder.Text = "Menu Display";
        // 
        // pnlOrderPage
        // 
        _pnlOrderPage.Controls.Add(_btnOrderAdd);
        _pnlOrderPage.Controls.Add(_btnOrderRemove);
        _pnlOrderPage.Location = new System.Drawing.Point(41, 384);
        _pnlOrderPage.Name = "_pnlOrderPage";
        _pnlOrderPage.Size = new System.Drawing.Size(107, 120);
        _pnlOrderPage.TabIndex = 16;
        _pnlOrderPage.Visible = false;
        // 
        // btnOrderAdd
        // 
        _btnOrderAdd.Location = new System.Drawing.Point(13, 13);
        _btnOrderAdd.Name = "_btnOrderAdd";
        _btnOrderAdd.Size = new System.Drawing.Size(80, 40);
        _btnOrderAdd.TabIndex = 13;
        _btnOrderAdd.Text = "Add Page";
        // 
        // btnOrderRemove
        // 
        _btnOrderRemove.Location = new System.Drawing.Point(13, 68);
        _btnOrderRemove.Name = "_btnOrderRemove";
        _btnOrderRemove.Size = new System.Drawing.Size(80, 40);
        _btnOrderRemove.TabIndex = 12;
        _btnOrderRemove.Text = "Remove Page";
        // 
        // cbxOrderSubCategroy
        // 
        _cbxOrderSubCategroy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _cbxOrderSubCategroy.Location = new System.Drawing.Point(24, 152);
        _cbxOrderSubCategroy.MaxDropDownItems = 16;
        _cbxOrderSubCategroy.Name = "_cbxOrderSubCategroy";
        _cbxOrderSubCategroy.Size = new System.Drawing.Size(160, 21);
        _cbxOrderSubCategroy.TabIndex = 15;
        _cbxOrderSubCategroy.Visible = false;
        // 
        // lblOrderDesc1
        // 
        _lblOrderDesc1.ForeColor = System.Drawing.Color.White;
        _lblOrderDesc1.Location = new System.Drawing.Point(704, 13);
        _lblOrderDesc1.Name = "_lblOrderDesc1";
        _lblOrderDesc1.Size = new System.Drawing.Size(104, 32);
        _lblOrderDesc1.TabIndex = 11;
        _lblOrderDesc1.Text = "2 panels left blank intentionally";
        _lblOrderDesc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnOrderDown
        // 
        _btnOrderDown.ForeColor = System.Drawing.Color.White;
        _btnOrderDown.Location = new System.Drawing.Point(707, 472);
        _btnOrderDown.Name = "_btnOrderDown";
        _btnOrderDown.Size = new System.Drawing.Size(104, 32);
        _btnOrderDown.TabIndex = 10;
        _btnOrderDown.Text = "Down";
        // 
        // btnOrderUp
        // 
        _btnOrderUp.ForeColor = System.Drawing.Color.White;
        _btnOrderUp.Location = new System.Drawing.Point(707, 48);
        _btnOrderUp.Name = "_btnOrderUp";
        _btnOrderUp.Size = new System.Drawing.Size(104, 32);
        _btnOrderUp.TabIndex = 9;
        _btnOrderUp.Text = "Up";
        // 
        // Panel4
        // 
        _Panel4.BackColor = System.Drawing.SystemColors.Control;
        _Panel4.Controls.Add(_btnOrderUpdateStaging);
        _Panel4.Location = new System.Drawing.Point(690, 507);
        _Panel4.Name = "_Panel4";
        _Panel4.Size = new System.Drawing.Size(136, 40);
        _Panel4.TabIndex = 8;
        // 
        // btnOrderUpdateStaging
        // 
        _btnOrderUpdateStaging.BackColor = System.Drawing.Color.FromArgb(56, 92, 152);
        _btnOrderUpdateStaging.ForeColor = System.Drawing.Color.White;
        _btnOrderUpdateStaging.Location = new System.Drawing.Point(8, 8);
        _btnOrderUpdateStaging.Name = "_btnOrderUpdateStaging";
        _btnOrderUpdateStaging.Size = new System.Drawing.Size(120, 24);
        _btnOrderUpdateStaging.TabIndex = 0;
        _btnOrderUpdateStaging.Text = "Update Staging";
        _btnOrderUpdateStaging.UseVisualStyleBackColor = false;
        // 
        // lblOrderCategoryName
        // 
        _lblOrderCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblOrderCategoryName.ForeColor = System.Drawing.Color.IndianRed;
        _lblOrderCategoryName.Location = new System.Drawing.Point(304, 40);
        _lblOrderCategoryName.Name = "_lblOrderCategoryName";
        _lblOrderCategoryName.Size = new System.Drawing.Size(280, 24);
        _lblOrderCategoryName.TabIndex = 7;
        _lblOrderCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // cbxOrderCategorySelection
        // 
        _cbxOrderCategorySelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _cbxOrderCategorySelection.Location = new System.Drawing.Point(24, 104);
        _cbxOrderCategorySelection.MaxDropDownItems = 16;
        _cbxOrderCategorySelection.Name = "_cbxOrderCategorySelection";
        _cbxOrderCategorySelection.Size = new System.Drawing.Size(160, 21);
        _cbxOrderCategorySelection.TabIndex = 6;
        // 
        // pnlOrderFoodStaging
        // 
        _pnlOrderFoodStaging.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        _pnlOrderFoodStaging.Location = new System.Drawing.Point(707, 80);
        _pnlOrderFoodStaging.Name = "_pnlOrderFoodStaging";
        _pnlOrderFoodStaging.Size = new System.Drawing.Size(104, 392);
        _pnlOrderFoodStaging.TabIndex = 5;
        // 
        // pnlOrderFoodItems
        // 
        _pnlOrderFoodItems.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        _pnlOrderFoodItems.Location = new System.Drawing.Point(200, 80);
        _pnlOrderFoodItems.Name = "_pnlOrderFoodItems";
        _pnlOrderFoodItems.Size = new System.Drawing.Size(456, 392);
        _pnlOrderFoodItems.TabIndex = 3;
        // 
        // lblOrderMenuName
        // 
        _lblOrderMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblOrderMenuName.ForeColor = System.Drawing.Color.IndianRed;
        _lblOrderMenuName.Location = new System.Drawing.Point(304, 16);
        _lblOrderMenuName.Name = "_lblOrderMenuName";
        _lblOrderMenuName.Size = new System.Drawing.Size(256, 24);
        _lblOrderMenuName.TabIndex = 1;
        _lblOrderMenuName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // cbxOrderMenuSelection
        // 
        _cbxOrderMenuSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _cbxOrderMenuSelection.Location = new System.Drawing.Point(24, 56);
        _cbxOrderMenuSelection.Name = "_cbxOrderMenuSelection";
        _cbxOrderMenuSelection.Size = new System.Drawing.Size(160, 21);
        _cbxOrderMenuSelection.TabIndex = 0;
        _cbxOrderMenuSelection.Text = "Select Menu";
        // 
        // pnlDrinkUpdate
        // 
        _pnlDrinkUpdate.BackColor = System.Drawing.SystemColors.Control;
        _pnlDrinkUpdate.Controls.Add(_btnDeleteDrink);
        _pnlDrinkUpdate.Location = new System.Drawing.Point(804, 85);
        _pnlDrinkUpdate.Name = "_pnlDrinkUpdate";
        _pnlDrinkUpdate.Size = new System.Drawing.Size(50, 49);
        _pnlDrinkUpdate.TabIndex = 4;
        _pnlDrinkUpdate.Visible = false;
        // 
        // btnDeleteDrink
        // 
        _btnDeleteDrink.BackColor = System.Drawing.Color.FromArgb(149, 179, 215);
        _btnDeleteDrink.Location = new System.Drawing.Point(16, 8);
        _btnDeleteDrink.Name = "_btnDeleteDrink";
        _btnDeleteDrink.Size = new System.Drawing.Size(74, 38);
        _btnDeleteDrink.TabIndex = 1;
        _btnDeleteDrink.Text = "Delete Drink";
        _btnDeleteDrink.UseVisualStyleBackColor = false;
        // 
        // ErrorProvider1
        // 
        _ErrorProvider1.ContainerControl = this;
        // 
        // SetupMenu
        // 
        this.BackColor = System.Drawing.Color.FromArgb(0, 78, 152);
        this.Controls.Add(_TabControl1);
        this.Controls.Add(_pnlDrinkUpdate);
        this.Name = "SetupMenu";
        this.Size = new System.Drawing.Size(888, 720);
        _tabCategory.ResumeLayout(false);
        _pnlNewCategory.ResumeLayout(false);
        _pnlNewCategory.PerformLayout();
        _Panel6.ResumeLayout(false);
        _Panel6.PerformLayout();
        _TabModifiers.ResumeLayout(false);
        _pnlModifierPage.ResumeLayout(false);
        _pnlNewModifier.ResumeLayout(false);
        _pnlNewModifier.PerformLayout();
        _Panel7.ResumeLayout(false);
        _Panel7.PerformLayout();
        _pnlUpdateModifiers.ResumeLayout(false);
        _TabMainFood.ResumeLayout(false);
        _TabMainFood.PerformLayout();
        _Panel1.ResumeLayout(false);
        _Panel1.PerformLayout();
        _pnlNewFood.ResumeLayout(false);
        _pnlNewFood.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_grdFoodList).EndInit();
        _Panel2.ResumeLayout(false);
        _TabFoodJoin.ResumeLayout(false);
        _Panel5.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)_grdJoinFoodModifierJoins).EndInit();
        ((System.ComponentModel.ISupportInitialize)_grdJoinFoodChoice).EndInit();
        ((System.ComponentModel.ISupportInitialize)_grdJoinFoodCategoryJoins).EndInit();
        ((System.ComponentModel.ISupportInitialize)_grdJoinIndividualModifiers).EndInit();
        ((System.ComponentModel.ISupportInitialize)_grdJoinPossibleCategories).EndInit();
        _TabControl1.ResumeLayout(false);
        _TabDrinkCategory.ResumeLayout(false);
        _TabDrinkCategory.PerformLayout();
        _pnlDrinkModifiers.ResumeLayout(false);
        _pnlDrinkModifiers.PerformLayout();
        _pnlIsLiquorType.ResumeLayout(false);
        _TabDrinks.ResumeLayout(false);
        _TabDrinks.PerformLayout();
        _Panel3.ResumeLayout(false);
        _Panel3.PerformLayout();
        _TabDrinkPrep.ResumeLayout(false);
        _TabMenuSetup.ResumeLayout(false);
        _pnlMenuUpdate.ResumeLayout(false);
        _TabFoodOrder.ResumeLayout(false);
        _pnlOrderPage.ResumeLayout(false);
        _Panel4.ResumeLayout(false);
        _pnlDrinkUpdate.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)_ErrorProvider1).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private void InitializeOther()
    {
        // ReInitializeSQLConnection()

        bartnerderMenuMode = "Table Service";

        dsSetup.Tables("LocationOpening").Clear();
        sql.SqlSelectLocationOpening.Parameters("@LocationID").Value = corpPhysicalLocation; // selectedLocation


        dsSetup.Tables("FoodTable").Clear();
        // PopulateLocationMenu(corpID, selectedLocation)
        sql.SqlSelectCommandMenuFoods.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandMenuFoods.Parameters("@LocationID").Value = selectedLocation;
        // Category
        sql.SqlSelectCommandCategoryMain.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandCategoryMain.Parameters("@LocationID").Value = selectedLocation;
        // sql.SqlSelectCommandCategoryModifier.Parameters("@CompanyID").Value = corpID
        // sql.SqlSelectCommandCategoryModifier.Parameters("@LocationID").Value = selectedLocation

        dsSetup.Tables("MenuJoin").Clear();
        sql.SqlSelectCommandMenuMenuJoin.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandMenuMenuJoin.Parameters("@LocationID").Value = selectedLocation;

        dsSetup.Tables("Menus").Clear();
        sql.SqlSelectCommandMenuMenuChoice.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandMenuMenuChoice.Parameters("@LocationID").Value = selectedLocation;

        dsSetup.Tables("Modifiers").Clear();
        sql.SqlSelectCommandModifiers.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandModifiers.Parameters("@LocationID").Value = selectedLocation;

        dsSetup.Tables("Drinks").Clear();
        sql.SqlSelectCommandMenuDrinks.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandMenuDrinks.Parameters("@LocationID").Value = selectedLocation;

        dsSetup.Tables("DrinkCategory").Clear();
        sql.SqlSelectCommandMenuDrinkCategory.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandMenuDrinkCategory.Parameters("@LocationID").Value = selectedLocation;

        dsSetup.Tables("DrinkModifiers").Clear();
        sql.SqlSelectCommandMenuDrinkModifiers.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandMenuDrinkModifiers.Parameters("@LocationID").Value = selectedLocation;

        dsSetup.Tables("WineParring").Clear();
        sql.SqlSelectCommandMenuWineParring.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandMenuWineParring.Parameters("@LocationID").Value = selectedLocation;

        dsSetup.Tables("LiquorTypes").Clear();
        sql.SqlSelectCommandMenuLiquorTypes.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandMenuLiquorTypes.Parameters("@LocationID").Value = selectedLocation;

        dsSetup.Tables("DrinkPrep").Clear();

        dsSetup.Tables("DrinkPrepLocation").Clear();
        sql.SqlSelectCommandMenuDrinkPrepLocation.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandMenuDrinkPrepLocation.Parameters("@LocationID").Value = selectedLocation;

        dsSetup.Tables("FoodJoin").Clear();
        sql.SqlSelectCommandJoinFoodJoin.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandJoinFoodJoin.Parameters("@LocationID").Value = selectedLocation;
        sql.SqlSelectCommandJoinFoodJoin.Parameters("@FoodID").Value = 0;

        dsSetup.Tables("JoinFoodCategoryJoins").Clear();
        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@LocationID").Value = selectedLocation;
        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@FoodID").Value = 0;

        dsSetup.Tables("JoinFoodModifierJoins").Clear();
        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@LocationID").Value = selectedLocation;
        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@FoodID").Value = 0;

        dsSetup.Tables("Promotion").Clear();
        sql.SqlSelectCommandPromoPromotion.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandPromoPromotion.Parameters("@LocationID").Value = selectedLocation;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            GenerateCategoryDataSets(corpID, selectedLocation);
            sql.SqlLocationOpening.Fill(dsSetup.Tables("LocationOpening"));
            sql.SqlMenuFoods.Fill(dsSetup.Tables("FoodTable"));
            sql.SqlMenuCategoryMain.Fill(dsSetup.Tables("MainCategory"));
            sql.SqlMenuMenuJoin.Fill(dsSetup.Tables("MenuJoin"));
            sql.SqlMenuMenuChoice.Fill(dsSetup.Tables("Menus"));
            // sql.SqlMenuCategoryModifier.Fill(dsSetup.Tables("ModifierCategory"))
            sql.SqlMenuModifiers.Fill(dsSetup.Tables("Modifiers"));
            sql.SqlMenuDrinks.Fill(dsSetup.Tables("Drinks"));
            sql.SqlMenuDrinkCategory.Fill(dsSetup.Tables("DrinkCategory"));
            sql.SqlMenuDrinkModifiers.Fill(dsSetup.Tables("DrinkModifiers"));
            sql.SqlMenuWineParring.Fill(dsSetup.Tables("WineParring"));
            sql.SqlMenuLiquorTypes.Fill(dsSetup.Tables("LiquorTypes"));
            sql.SqlMenuDrinkPrep.Fill(dsSetup.Tables("DrinkPrep"));
            sql.SqlMenuDrinkPrepLocation.Fill(dsSetup.Tables("DrinkPrepLocation"));
            sql.SqlJoinFoodJoin.Fill(dsSetup.Tables("FoodJoin"));
            sql.SqlJoinFoodCategoryJoins.Fill(dsSetup.Tables("JoinFoodCategoryJoins"));
            sql.SqlJoinFoodModiferJoins.Fill(dsSetup.Tables("JoinFoodModifierJoins"));
            sql.SqlPromoPromotion.Fill(dsSetup.Tables("Promotion"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        SetUpPrimaryKeys();
        StartMenu();

    }


 // Install-Package Microsoft.VisualBasic

internal partial class SurroundingClass
{
    internal void StartMenu()
    {

        CreateDataViews();

        BindData();

        newCategory.CategoryIndexMore = 1;
        DisplayMainCategoryPanel(newCategory.CategoryIndexMore);

        newCategory.CategoryIndexModifier = 1;
        DisplayModifierCategoryPanel(newCategory.CategoryIndexModifier);

        DisplayMenuSelectionPanel();

        DisplayFoodTab();

        DisplayFoodJoinGrids();
        newFoodJoin.ActiveCategoryRow = -1;
        newFoodJoin.ActiveModifierRow = -1;

        DisplayMenuCostGroupBox();

        PopulateMenuCostGroupBox();

        DisplayDrinkCategoryPanel();

        DisplayDrinkCategoryPanel2();

        DisplayDrinkByCategoryPanel();

        // 444    DisplayDrinkModifiers()

        DisplayDrinkPrep();

        DisplayMenuPages();

        CreateStagingPanel();

        this.pnlNewFood.Location = new Point(240, 64);
        this.pnlNewModifier.Location = new Point(424, 16);

    }


    internal void PopulateLocationMenu(ref string corpID, ref string locID)
    {

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlSelectCommandMenuFoods.Parameters("@CompanyID").Value = corpID;
            sql.SqlSelectCommandMenuFoods.Parameters("@LocationID").Value = locID;
            // sql.SqlSelectCommandMenuFoods.Parameters("@CategoryID").Value = 0   '1000
            sql.SqlMenuFoods.Fill(dsSetup.Tables("FoodTable"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

    }

    private void CreateDataViews()
    {


        {
            var withBlock = dvFoods;
            withBlock.Table = dsSetup.Tables("FoodTable");
            withBlock.RowFilter = "(FunctionFlag = 'O' OR FunctionFlag = 'F')";
        }

        {
            var withBlock1 = dvFoodsJoins;
            withBlock1.Table = dsSetup.Tables("FoodTable");
        }

        {
            var withBlock2 = dvModifiers;
            withBlock2.Table = dsSetup.Tables("Modifiers");
            withBlock2.AllowEdit = true;
            withBlock2.RowFilter = "CategoryID > 0";
            withBlock2.RowStateFilter = DataViewRowState.CurrentRows;
            withBlock2.Sort = "CategoryID, FoodName";
        }

        // 444     With dvMainCategory
        // 444    .Table = dsSetup.Tables("MainCategory")
        // old      .RowFilter = "FunctionFlag = 'F' OR FunctionFlag = 'O'" ' AND CategoryOrder < 11"
        // old       .Sort = "CategoryOrder"
        // 444    End With

        // With dvModifierCategory
        // .Table = dsSetup.Tables("MainCategory")
        // .RowFilter = "FunctionFlag = 'M'"
        // '       .Sort = "CategoryOrder"
        // End With



    }
    private void BindData()
    {
        DataRow oRow;

        // *********************
        // this may work for auto binding
        // Me.BindingContext(myobj).EndCurrentEdit

        // category
        this.cbxNewCategoryFunction.Items.Add("Choose Function");

        // For Each oRow In dsSetup.Tables("Functions").Rows
        // If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
        // If oRow("FunctionFlag") = "F" Or oRow("FunctionFlag") = "M" Or oRow("FunctionFlag") = "O" Then
        // Me.cbxCategoryFunction.Items.Add(oRow("FunctionName"))
        // Me.cbxNewCategoryFunction.Items.Add(oRow("FunctionName"))
        // End If
        // End If
        // Next

        this.cbxCategroyPriority.Items.Add("Highest");
        this.cbxCategroyPriority.Items.Add("High");
        this.cbxCategroyPriority.Items.Add("Medium");
        this.cbxCategroyPriority.Items.Add("Low");
        this.cbxCategroyPriority.Items.Add("Lowest");

        this.cbxNewCategroyPriority.Items.Add("Highest");
        this.cbxNewCategroyPriority.Items.Add("High");
        this.cbxNewCategroyPriority.Items.Add("Medium");
        this.cbxNewCategroyPriority.Items.Add("Low");
        this.cbxNewCategroyPriority.Items.Add("Lowest");

        // binds food data
        // grdFoodList.DataSource = dsSetup.Tables("FoodTable")

        foreach (DataRow currentORow in dsSetup.Tables("RoutingChoice").Rows)
        {
            oRow = currentORow;
            // cbxFoodRouting.Items.Add(oRow("RoutingName"))
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                this.cbxModifierRouting.Items.Add(oRow("RoutingName"));
            }

        }
        this.cbxModifierRouting.Items.Add("Route w/ Food");

        foreach (DataRow currentORow1 in dsSetup.Tables("PrintPriority").Rows)
        {
            oRow = currentORow1;
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                cbxPrintPriority.Items.Add(oRow("PrintPriorityName"));
            }
        }

        foreach (DataRow currentORow2 in dsSetup.Tables("WineParring").Rows)
        {
            oRow = currentORow2;
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                cbxWineParring.Items.Add(oRow("DrinkName"));
            }
        }

        // 444       For Each oRow In dsSetup.Tables("TaxTable").Rows
        // If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
        // cbxFoodTax.Items.Add(oRow("TaxName"))
        // End If
        // Next

        txtFoodName.DataBindings.Add("Text", dvFoods, "FoodName");
        txtAbrevFoodName.DataBindings.Add("Text", dvFoods, "AbrevFoodName");
        txtChitFoodName.DataBindings.Add("Text", dvFoods, "ChitFoodName");
        cbxFoodCategory.DataBindings.Add("Text", dvFoods, "CategoryName");
        // cbxFoodRouting.DataBindings.Add("Text", dsSetup.Tables("FoodTable"), "RoutingName")
        cbxPrintPriority.DataBindings.Add("Text", dvFoods, "PrintPriorityName");
        cbxWineParring.DataBindings.Add("Text", dvFoods, "DrinkName");
        // lblRecipe.DataBindings.Add("Text", dsSetup.Tables("FoodTable"), "FoodDesc")
        txtRecipe.DataBindings.Add("Text", dvFoods, "FoodDesc");

        // txtSurcharge.DataBindings.Add("Text", dsSetup.Tables("FoodTable"), "Surcharge")
        // cbxFoodTax.DataBindings.Add("Text", dvFoods, "TaxName")
        txtFoodCost.DataBindings.Add("Text", dvFoods, "FoodCost");
        txtFoodInvMultiplier.DataBindings.Add("Text", dvFoods, "InvMultiplier");
        chkManual.DataBindings.Add("Checked", dvFoods, "FoodCostManual");
        // lblSelectFoodFilter.DataBindings.Add("Text", dvFoods, "FoodName")

        FoodCurrencyMan = this.BindingContext(dvFoods); // dsSetup.Tables("FoodTable"))
        grdFoodList.DataSource = dvFoods; // dsSetup.Tables("FoodTable")


        // txtCategoryName.DataBindings.Add("Text", dvMainCategory, "CategoryName")
        // Me.txtCategoryAbrev.DataBindings.Add("Text", dvMainCategory, "CategoryAbrev")
        // Me.cbxCategoryFunction.DataBindings.Add("Text", dvMainCategory, "FunctionName")
        // cbxCategroyPriority.DataBindings.Add("Text", dvMainCategory, "PrintPriorityName")
        // chkHalfSplit.DataBindings.Add("Checked", dvMainCategory, "HalfSplit")
        // chkCategoryActive.DataBindings.Add("Checked", dvMainCategory, "Active")
        // chkExtendedDisplay.DataBindings.Add("Checked", dvMainCategory, "Extended")
        // chkDisplayWithAdd.DataBindings.Add("Checked", dvMainCategory, "DisplayWithAdd")
        // mainCatCurrencyMan = Me.BindingContext(dvMainCategory)
        // above(wrong(wrong))

        txtCategoryName.DataBindings.Add("Text", dsSetup.Tables("MainCategory"), "CategoryName");
        this.txtCategoryAbrev.DataBindings.Add("Text", dsSetup.Tables("MainCategory"), "CategoryAbrev");
        this.cbxCategoryFunction.DataBindings.Add("Text", dsSetup.Tables("MainCategory"), "FunctionName");
        cbxCategroyPriority.DataBindings.Add("Text", dsSetup.Tables("MainCategory"), "PrintPriorityName");
        chkHalfSplit.DataBindings.Add("Checked", dsSetup.Tables("MainCategory"), "HalfSplit");
        chkCategoryActive.DataBindings.Add("Checked", dsSetup.Tables("MainCategory"), "Active");
        chkExtendedDisplay.DataBindings.Add("Checked", dsSetup.Tables("MainCategory"), "Extended");
        chkDisplayWithAdd.DataBindings.Add("Checked", dsSetup.Tables("MainCategory"), "DisplayWithAdd");
        mainCatCurrencyMan = this.BindingContext(dsSetup.Tables("MainCategory"));

        // Category Buttons


        // ********  Modifiers


        // routingName populated in food

        txtModifierName.DataBindings.Add("Text", dvModifiers, "FoodName");
        this.txtModifierAbrev.DataBindings.Add("Text", dvModifiers, "AbrevFoodName");
        this.txtModifierChit.DataBindings.Add("Text", dvModifiers, "ChitFoodName");
        txtModifierCost.DataBindings.Add("Text", dvModifiers, "FoodCost");
        this.txtModifierSurcharge.DataBindings.Add("Text", dvModifiers, "Surcharge");
        // 'old        cbxModifierFilter.DataBindings.Add("Text", dsSetup.Tables("ModifierCategory"), "CategoryName") 'dsSetup.Tables("Modifiers"), "CategoryName")
        this.cbxModifierRouting.DataBindings.Add("Text", dvModifiers, "RoutingName");
        // 'old temp remv.    Me.lblSelectModifierFilter.DataBindings.Add("Text", dsSetup.Tables("Modifiers"), "CategoryName") 'dsSetup.Tables("Modifiers"), "FoodName")
        this.txtModifierDescription.DataBindings.Add("Text", dvModifiers, "FoodDesc");

        ModifierCurrencyMan = this.BindingContext(dvModifiers);    // (dsSetup.Tables("Modifiers"))
        JoinIndividualMan = this.BindingContext(dsSetup.Tables("FoodJoin"));

        // grdModifiers.DataSource = dsSetup.Tables("Modifiers") 'dvModifiers


        // **********************
        // Food / Modifier Link

        grdJoinFoodChoice.DataSource = dvFoodsJoins; // dvFoods  ' dsSetup.Tables("FoodTable")
        grdJoinFoodCategoryJoins.DataSource = dsSetup.Tables("JoinFoodCategoryJoins");
        grdJoinFoodModifierJoins.DataSource = dsSetup.Tables("JoinFoodModifierJoins");
        // grdJoinFoodModifierJoins.DataBindings =

        grdJoinPossibleCategories.DataSource = dvMainCategoryFoodJoin; // dsSetup.Tables("Main_ModifierCategory2") '("ModifierCategory")
        grdJoinIndividualModifiers.DataSource = dvModifiers2; // dsSetup.Tables("Modifiers2")
        // Me.grdJoinFoodCategoryJoins.SetDataBinding(dsSetup.Tables("JoinFoodCategoryJoins"), "dvJoinFoodCategoryJoins")


        // cbxJoinCategorySelect.DataSource = dsSetup.Tables("MainCategory")
        // cbxJoinCategorySelect.DisplayMember = "CategoryName"
        // cbxJoinCategorySelect.SelectedIndex = -1



        // For Each oRow In dsSetup.Tables("ModifierCategory").Rows
        // cbxJoinIndividualModifierSelect.Items.Add(oRow("CategoryName"))
        // Next
        // cbxJoinIndividualModifierSelect.DataSource = dsSetup.Tables("ModifierCategory")
        // cbxJoinIndividualModifierSelect.DisplayMember = "CategoryName"
        // cbxJoinIndividualModifierSelect.SelectedIndex = -1

        // ********************************
        // Drinks

        // txtDrinkName.DataBindings.Add("Text", dvDrinksByCategory, "CategoryName")
        // Me.txtDrinkPrice.DataBindings.Add("Text", dvDrinksByCategory, "CategoryAbrev")
        // Me.txtDrinkDesc.DataBindings.Add("Text", dvDrinksByCategory, "FunctionName")
        // Me.txtCallPrice.DataBindings.Add("Text", dvDrinksByCategory, "PrintPriorityName")
        // Me.txtAddOnPrice.DataBindings.Add("Checked", dvDrinksByCategory, "HalfSplit")
        // '     Me.chkSelectAddOn.DataBindings.Add("Checked", dvDrinksByCategory, "Active")
        // Me.chkIsAddOn.DataBindings.Add("Checked", dvDrinksByCategory, "Active")
        // Me.chkWineParring.DataBindings.Add("Checked", dvDrinksByCategory, "Active")
        // '
        // Me.cbxDrinkFunction.DataBindings.Add("Text", dvDrinksByCategory, "RoutingName")


        PopulateDrinkCategoriesNames();
        foreach (DataRow currentORow3 in dsSetup.Tables("DrinkFunctions").Rows)
        {
            oRow = currentORow3;
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                this.cbxDrinkFunction.Items.Add(oRow("FunctionName"));
            }
        }


        // txtDrinkDouble.DataBindings.Add("Text", dsSetup.Tables("DrinkModifiers"), "DrinkPrice")
        // **********************************
        // Menu

        PopulateMenuSelectionComboBox();

        foreach (DataRow currentORow4 in dsSetup.Tables("DrinkCategory").Rows)
        {
            oRow = currentORow4;
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                if (!object.ReferenceEquals(oRow("DrinkCategoryName"), DBNull.Value))
                {
                    this.cbxMenuDrink.Items.Add(oRow("DrinkCategoryName"));
                }
            }
        }

        // **************************************
        // Food Order

        foreach (DataRow currentORow5 in dsSetup.Tables("Menus").Rows)
        {
            oRow = currentORow5;
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                this.cbxOrderMenuSelection.Items.Add(oRow("MenuName"));
            }
        }


    }

    private void PopulateMenuSelectionComboBox()
    {
        this.cbxMenuSelection.Items.Clear();

        foreach (DataRow oRow in dsSetup.Tables("Menus").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                cbxMenuSelection.Items.Add(oRow("MenuName"));
            }
        }

    }

    private void PopulateDrinkCategoriesNames()
    {
        this.cbxLiquorType.Items.Clear();

        dsSetup.Tables("LiquorTypes").Clear();
        sql.SqlSelectCommandMenuLiquorTypes.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandMenuLiquorTypes.Parameters("@LocationID").Value = selectedLocation;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlMenuLiquorTypes.Fill(dsSetup.Tables("LiquorTypes"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        this.cbxLiquorType.Items.Add("No Liquor Type");
        foreach (DataRow oRow in dsSetup.Tables("LiquorTypes").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                cbxLiquorType.Items.Add(oRow("DrinkCategoryName"));
            }
        }

    }


    // *****************************************************************
    // Category
    // *****************************************************************

    internal void DisplayMainCategoryPanel(int startIndex)
    {


        // newCategory = New ActiveCategory
        // newCategory.CategoryIndexMore = 1
        // newCategory.CategoryIndexModifier = 1
        this.pnlNewCategory.Location = new Point(32, 40);

        int newCategoryID;

        // readjust size of panel
        if (dsSetup.Tables("MainCategory").Rows.Count == 0)
        {
            // MainCategoryPanel.Size = New Size(ssX * 0.1, ssY * 0.2)
        }

        // at this point keeping the same
        int btnWidth = this.MainCategoryPanel.Width - 2 * buttonSpace;
        int btnheight = (this.MainCategoryPanel.Height - 11 * buttonSpace) / 10;
        // MainCategoryPanel.Size = New System.Drawing.Size(btnWidth + 2 * buttonSpace, 10 * btnheight + 11 * buttonSpace)

        int index;
        int x = buttonSpace;
        int y = buttonSpace;

        for (index = 1; index <= 10; index++)
        {
            btnMain[index] = new OrderButton();
            {
                var withBlock = btnMain[index];
                withBlock.BtnNumber = index;
                withBlock.Size = new Size(btnWidth, btnheight);
                withBlock.Location = new Point(x, y);
                withBlock.TabStop = false;
                // .BtnIndex = index
                withBlock.IsActive = true;

                // btnMainCollection.Add(btnMain(index))
                MainCategoryPanel.Controls.Add(btnMain[index]);

                btnMain[index].Click += UpdateMainCategory;

            }
            y = y + btnheight + buttonSpace;
        }

        PopulateMainCategoryPanel(1);

    }

    private void PopulateMainCategoryPanel(int startIndex)
    {
        int index;
        int position;
        int dataViewCount;
        var wasPopulated = default(bool);

        for (position = 1; position <= 10; position++)
        {
            {
                var withBlock = btnMain[position];
                withBlock.ID = (object)null;
                withBlock.Name = (object)null;
                withBlock.Text = (object)null;
                withBlock.Functions = (object)null;
                withBlock.BackColor = Color.White;
            }
        }
        position = 1;

        // *** may be a problem with positio if ther is a deleted row  ??????
        var loopTo = startIndex + 9;
        for (index = startIndex; index <= loopTo; index++) // (dsSetup.Tables("MainCategory").Rows.Count))
        {
            dataViewCount = 0;
            // vRow = dvMainCategory(index)
            foreach (DataRow vRow in dsSetup.Tables("MainCategory").Rows) // dvMainCategory 
            {
                if (vRow("FunctionFlag") == "F" | vRow("FunctionFlag") == "O" | vRow("FunctionFlag") == "G")
                {
                    if (vRow("CategoryOrder") == index)
                    {

                        {
                            var withBlock1 = btnMain[position];
                            withBlock1.DataViewIndex = dataViewCount;
                            withBlock1.ID = vRow("CategoryID");
                            withBlock1.BtnIndex = index;
                            withBlock1.Name = vRow("CategoryName");
                            withBlock1.Text = vRow("CategoryAbrev");
                            withBlock1.Functions = vRow("FunctionID");
                            withBlock1.HalfSplit = vRow("HalfSplit");
                            withBlock1.IsActive = vRow("Active");
                            withBlock1.Priority = vRow("Priority");
                            if (!object.ReferenceEquals(vRow("ButtonColor"), DBNull.Value))
                            {
                                withBlock1.ColorInt = vRow("ButtonColor");
                            }
                            else
                            {
                                withBlock1.ColorInt = -9404272;
                            }    // slateGray
                            if (!object.ReferenceEquals(vRow("ButtonForeColor"), DBNull.Value))
                            {
                                withBlock1.ColorForeInt = vRow("ButtonForeColor");
                            }
                            else
                            {
                                withBlock1.ColorForeInt = -16777216;
                            }    // Black
                            withBlock1.BackColor = Color.FromArgb(withBlock1.ColorInt);
                            withBlock1.ForeColor = Color.FromArgb(withBlock1.ColorForeInt);
                        }
                        wasPopulated = true;
                    }
                }
                // If Not vRow.RowState = DataRowState.Deleted And Not vRow.RowState = DataRowState.Detached Then
                dataViewCount += 1;
                // End If
            }
            if (wasPopulated == false)
            {
                btnMain[position].BtnIndex = index;
            }
            else
            {
                wasPopulated = false;
            }

            position += 1;
        }

    }

    private void DisplayModifierCategoryPanel(int startIndex)
    {

        int btnWidth = this.ModifierCategoryPanel.Width - 2 * buttonSpace;
        int btnheight = (this.ModifierCategoryPanel.Height - 11 * buttonSpace) / 10;
        // ModifierCategoryPanel.Size = New System.Drawing.Size(btnWidth + 2 * buttonSpace, 10 * btnheight + 11 * buttonSpace)

        int index;
        int x = buttonSpace;
        int y = buttonSpace;

        for (index = 1; index <= 10; index++)
        {
            btnModifier[index] = new OrderButton();
            {
                var withBlock = btnModifier[index];
                withBlock.BtnNumber = index;
                withBlock.Size = new Size(btnWidth, btnheight);
                withBlock.Location = new Point(x, y);
                withBlock.TabStop = false;
                // .BtnIndex = index
                withBlock.IsActive = true;

                ModifierCategoryPanel.Controls.Add(btnModifier[index]);

                btnModifier[index].Click += UpdateMainCategory;   // UpdateModifierCategory

            }
            y = y + btnheight + buttonSpace;
        }

        PopulateModifierCategoryPanel(1);

    }

    private void PopulateModifierCategoryPanel(int startIndex)
    {
        int index;
        int position;
        int dataViewCount;
        var wasPopulated = default(bool);

        for (position = 1; position <= 10; position++)
        {
            {
                var withBlock = btnModifier[position];
                withBlock.ID = (object)null;
                withBlock.Name = (object)null;
                withBlock.Text = (object)null;
                withBlock.Functions = (object)null;
                withBlock.BackColor = Color.White;
            }
        }
        position = 1;

        var loopTo = startIndex + 9;
        for (index = startIndex; index <= loopTo; index++) // (dsSetup.Tables("ModifierCategory").Rows.Count))
        {
            dataViewCount = 0;

            foreach (DataRow vRow in dsSetup.Tables("MainCategory").Rows) // dvMainCategory '
            {
                if (vRow("FunctionFlag") == "M")
                {
                    // If Not vRow.RowState = DataRowState.Deleted And Not vRow.RowState = DataRowState.Detached Then
                    if (vRow("CategoryOrder") == index)
                    {
                        {
                            var withBlock1 = btnModifier[position];
                            withBlock1.DataViewIndex = dataViewCount;
                            withBlock1.ID = vRow("CategoryID");
                            withBlock1.BtnIndex = index;
                            withBlock1.Name = vRow("CategoryName");
                            withBlock1.Text = vRow("CategoryAbrev");
                            withBlock1.Functions = vRow("FunctionID");
                            withBlock1.HalfSplit = vRow("HalfSplit");
                            withBlock1.IsActive = vRow("Active");
                            withBlock1.Priority = vRow("Priority");
                            if (!object.ReferenceEquals(vRow("ButtonColor"), DBNull.Value))
                            {
                                withBlock1.ColorInt = vRow("ButtonColor");
                            }
                            else
                            {
                                withBlock1.ColorInt = -9404272;
                            }    // slateGray
                            if (!object.ReferenceEquals(vRow("ButtonForeColor"), DBNull.Value))
                            {
                                withBlock1.ColorForeInt = vRow("ButtonForeColor");
                            }
                            else
                            {
                                withBlock1.ColorForeInt = -16777216;
                            }    // Black

                            withBlock1.BackColor = Color.FromArgb(withBlock1.ColorInt);
                            withBlock1.ForeColor = Color.FromArgb(withBlock1.ColorForeInt);

                        }
                        wasPopulated = true;
                    }
                }
                dataViewCount += 1;
                // End If
            }
            if (wasPopulated == false)
            {
                btnModifier[position].BtnIndex = index;
            }
            else
            {
                wasPopulated = false;
            }
            position += 1;
        }

    }
    private void btnMainMore_Click(object sender, EventArgs e)
    {
        if (newCategory.CategoryIndexMore < 91)
        {
            newCategory.CategoryIndexMore += 10;
            PopulateMainCategoryPanel(newCategory.CategoryIndexMore);
        }
    }

    private void btnMainPrevious_Click(object sender, EventArgs e)
    {
        if (newCategory.CategoryIndexMore > 1)
        {
            newCategory.CategoryIndexMore -= 10;
            PopulateMainCategoryPanel(newCategory.CategoryIndexMore);
        }
    }
    private void btnModifierMore_Click(object sender, EventArgs e)
    {
        if (newCategory.CategoryIndexModifier < 91)
        {
            newCategory.CategoryIndexModifier += 10;
            PopulateModifierCategoryPanel(newCategory.CategoryIndexModifier);
        }
    }

    private void btnModifierPrevious_Click(object sender, EventArgs e)
    {
        if (newCategory.CategoryIndexModifier > 1)
        {
            newCategory.CategoryIndexModifier -= 10;
            PopulateModifierCategoryPanel(newCategory.CategoryIndexModifier);
        }
    }

    private void ButtonCatColor_Click(object sender, EventArgs e)
    {
        this.ColorChoice = new ButtonColor_UC();
        this.ColorChoice.Location = new Point(480, 25);
        this.Controls.Add(ColorChoice);
        ColorChoice.BringToFront();

    }

    private void ChangingButtonColor(int cc, int foreCC)
    {


        this.btnCategoryColor.BackColor = Color.FromArgb(cc);
        this.btnCategoryColor.ForeColor = Color.FromArgb(foreCC);

        // old    dvMainCategory(newCategory.DataViewIndex)("ButtonColor") = cc
        // old   dvMainCategory(newCategory.DataViewIndex)("ButtonForeColor") = foreCC
        dsSetup.Tables("MainCategory").Rows(newCategory.DataViewIndex)("ButtonColor") = cc;
        dsSetup.Tables("MainCategory").Rows(newCategory.DataViewIndex)("ButtonForeColor") = foreCC;
        return;

        // *****************
        // below is getting a concurrency violation
        // w/o it changes color, but not showing immediately

        if (newCategory.ActiveCategoryType == "Main")
        {
            btnMain(newCategory.ActiveButton).BackColor = Color.FromArgb(cc);
            btnMain(newCategory.ActiveButton).ForeColor = Color.FromArgb(foreCC);
        }

        else if (newCategory.ActiveCategoryType == "Modifier")
        {
            btnModifier(newCategory.ActiveButton).BackColor = Color.FromArgb(cc);
            btnModifier(newCategory.ActiveButton).ForeColor = Color.FromArgb(foreCC);

        }

    }


    private void UpdateMainCategory(object sender, EventArgs e) // Handles MainCategoryPanel.Click
    {
        DataRow oRow;

        try
        {
            OrderButton objButton = (OrderButton)sender;
            // MsgBox(sender.name)

            if (objButton.ID == 0)
            {
                // this means we have everything blank
                // ready for new category

                // SaveUpdatedCategory()
                this.cbxNewCategoryFunction.Items.Clear();
                foreach (DataRow currentORow in dsSetup.Tables("Functions").Rows)
                {
                    oRow = currentORow;
                    if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                    {
                        if (object.ReferenceEquals(objButton.Parent, this.MainCategoryPanel))
                        {
                            if (oRow("FunctionGroupID") == "1" | oRow("FunctionGroupID") == "10" | oRow("FunctionGroupID") == "99")
                            {
                                // 1 is Main Food Item          10 is Food Item -Other 
                                this.cbxNewCategoryFunction.Items.Add(oRow("FunctionName"));
                            }
                        }
                        else if (oRow("FunctionGroupID") == "9") // 9 is Modifier
                        {
                            this.cbxNewCategoryFunction.Items.Add(oRow("FunctionName"));
                        }

                    }
                }

                try
                {
                    // we may not have all the row for index 0 or 1
                    if (object.ReferenceEquals(objButton.Parent, this.MainCategoryPanel))
                    {
                        newCategory.ActiveCategoryType = "Main";
                        cbxNewCategoryFunction.SelectedIndex = 1;
                    }
                    else
                    {
                        newCategory.ActiveCategoryType = "Modifier";
                        cbxNewCategoryFunction.SelectedValue = 0;
                    }
                    this.cbxNewCategroyPriority.SelectedIndex = 2;
                }
                catch (Exception ex)
                {

                }

                this.pnlNewCategory.Visible = true;
                this.txtNewCategoryName.Text = "";
                this.txtNewCategoryAbrev.Text = "";

                this.chkNewHalfSplit.Checked = false;
                chkNewExtendedDisplay.Checked = false;
                if (object.ReferenceEquals(objButton.Parent, this.MainCategoryPanel))
                {
                    chkNewDisplayWithAdds.Checked = false;
                }
                else
                {
                    chkNewDisplayWithAdds.Checked = true;
                }

                newCategory.ActiveButton = objButton.BtnNumber;
                newCategory.ActivePosition = objButton.BtnIndex;
                // newCategory.Priority = 3

                this.btnNewCategoryColor.BackColor = Color.CornflowerBlue;
                this.btnNewCategoryColor.ForeColor = Color.Black;
                this.txtNewCategoryName.Focus();
            }

            else
            {

                newCategory.ActiveButton = objButton.BtnNumber;
                newCategory.ActivePosition = objButton.BtnIndex;
                newCategory.DataViewIndex = objButton.DataViewIndex;

                // we may not have all the row for index 0 or 1
                if (object.ReferenceEquals(objButton.Parent, this.MainCategoryPanel))
                {
                    newCategory.ActiveCategoryType = "Main";
                }
                else
                {
                    newCategory.ActiveCategoryType = "Modifier";
                }

                this.cbxCategoryFunction.Items.Clear();
                foreach (DataRow currentORow1 in dsSetup.Tables("Functions").Rows)
                {
                    oRow = currentORow1;
                    if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                    {
                        if (object.ReferenceEquals(objButton.Parent, this.MainCategoryPanel))
                        {
                            if (oRow("FunctionGroupID") == "1" | oRow("FunctionGroupID") == "10" | oRow("FunctionGroupID") == "99")
                            {
                                // 1 is Main Food Item          10 is Food Item -Other 
                                this.cbxCategoryFunction.Items.Add(oRow("FunctionName"));
                            }
                        }
                        else if (oRow("FunctionGroupID") == "9") // 9 is Modifier
                        {
                            this.cbxCategoryFunction.Items.Add(oRow("FunctionName"));
                        }

                    }
                }


                this.btnCategoryColor.BackColor = objButton.BackColor;
                this.btnCategoryColor.ForeColor = objButton.ForeColor;

                mainCatCurrencyMan.Position = objButton.DataViewIndex;
                this.txtCategoryName.Focus();
            }
        }

        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);
        }

    }

    private void txtCategoryAbrev_TextChanged(object sender, EventArgs e)
    {

        if (newCategory.ActiveCategoryType == "Main")
        {
            btnMain(newCategory.ActiveButton).Text = txtCategoryAbrev.Text;
        }
        else if (newCategory.ActiveCategoryType == "Modifier")
        {
            btnModifier(newCategory.ActiveButton).Text = txtCategoryAbrev.Text;
        }
    }

    private void txtNewCategoryAbrev_Enter(object sender, EventArgs e)
    {
        if (txtNewCategoryAbrev.Text.Length == 0)
        {
            txtNewCategoryAbrev.Text = this.txtNewCategoryName.Text;
        }

    }

    private void cbxCategoryFunction_SelectedIndexChanged(object sender, EventArgs e)
    {

        foreach (DataRow oRow in dsSetup.Tables("Functions").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                if (Operators.ConditionalCompareObjectEqual(oRow("FunctionName"), sender.text, false))
                {
                    if (!(dsSetup.Tables("MainCategory").Rows(newCategory.DataViewIndex)("FunctionID") == oRow("FunctionID")))
                    {
                        dsSetup.Tables("MainCategory").Rows(newCategory.DataViewIndex)("FunctionID") = oRow("FunctionID");
                    }
                    break;
                }
            }
        }

    }

    private void cbxCategroyPriority_SelectedIndexChanged(object sender, EventArgs e)
    {

        var newPriority = default(int);

        switch (sender.text)
        {
            case "Highest":
                {
                    newPriority = 1;
                    break;
                }
            case "High":
                {
                    newPriority = 2;
                    break;
                }
            case "Medium":
                {
                    newPriority = 3;
                    break;
                }
            case "Low":
                {
                    newPriority = 4;
                    break;
                }
            case "Lowest":
                {
                    newPriority = 5;
                    break;
                }
        }

        if (!(dsSetup.Tables("MainCategory").Rows(newCategory.DataViewIndex)("Priority") == newPriority))
        {
            dsSetup.Tables("MainCategory").Rows(newCategory.DataViewIndex)("Priority") = newPriority;
        }

    }

    private void chkCategoryActive_CheckedChanged(object sender, EventArgs e)
    {

        string tempCategoryName;

        if (this.chkCategoryActive.Checked == false)
        {
            // this is the new state
            // 444      Me.txtCategoryName.Text = newCategory.ActiveText
            tempCategoryName = "**Inactive**";
        }

        // Me.txtCategoryName.Text = newCategory.ActiveText
        else if (txtCategoryName.Text.Length > 15)
        {
            tempCategoryName = txtCategoryName.Text.Substring(0, 15);
        }
        else
        {
            tempCategoryName = txtCategoryName.Text;

        }

        this.txtCategoryAbrev.Text = tempCategoryName;

        if (newCategory.ActiveCategoryType == "Main")
        {
            btnMain(newCategory.ActiveButton).Text = tempCategoryName; // txtCategoryAbrev.Text
        }
        else if (newCategory.ActiveCategoryType == "Modifier")
        {
            btnModifier(newCategory.ActiveButton).Text = tempCategoryName; // txtCategoryAbrev.Text
        }

    }


    // **************************
    // new category

    private void cbxNewCategoryFunction_SelectedIndexChanged(object sender, EventArgs e)
    {

        foreach (DataRow oRow in dsSetup.Tables("Functions").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                if (Operators.ConditionalCompareObjectEqual(oRow("FunctionName"), sender.text, false))
                {
                    newCategory.ActiveFunction = oRow("FunctionID");
                    break;
                }
            }
        }
        newCategory.Updated = true;

    }

    private void cbxNewCategroyPriority_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (sender.text)
        {
            case "Highest":
                {
                    newCategory.Priority = 1;
                    break;
                }
            case "High":
                {
                    newCategory.Priority = 2;
                    break;
                }
            case "Medium":
                {
                    newCategory.Priority = 3;
                    break;
                }
            case "Low":
                {
                    newCategory.Priority = 4;
                    break;
                }
            case "Lowest":
                {
                    newCategory.Priority = 5;
                    break;
                }
        }

    }

    private void btnNewCategoryColor_Click(object sender, EventArgs e)
    {
        this.ColorChoiceNew = new ButtonColor_UC();
        this.ColorChoiceNew.Location = new Point(480, 25);
        this.Controls.Add(ColorChoiceNew);
        ColorChoiceNew.BringToFront();

    }
    private void ChangingNewButtonColor(int cc, int foreCC)
    {

        this.btnNewCategoryColor.BackColor = Color.FromArgb(cc);
        this.btnNewCategoryColor.ForeColor = Color.FromArgb(foreCC);
        newCategory.ColorInt = cc;
        newCategory.ColorForeInt = foreCC;
        newCategory.Updated = true;

        // dvMainCategory(newCategory.DataViewIndex)("ButtonColor") = cc
        // dvMainCategory(newCategory.DataViewIndex)("ButtonForeColor") = foreCC

    }

    private void txtNewCategoryName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        ValidateString(ref this.txtNewCategoryName);
    }
    private void txtNewCategoryAbrev_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        ValidateString(ref this.txtNewCategoryAbrev);
    }
    private void cbxFunction_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        ValidateNotBlank(this.cbxNewCategoryFunction);
    }

    private void ValidateString(ref TextBox txtValNumeric)
    {

        if (txtValNumeric.Text == "")
        {
            this.ErrorProvider1.SetError(txtValNumeric, "This TextBox can not be Blank.");
            txtValNumeric.Focus();
            Interaction.Beep();
        }
        else if (!(Information.TypeName(txtValNumeric.Text) == "String"))
        {
            this.ErrorProvider1.SetError(txtValNumeric, "This must be a String value.");
            txtValNumeric.Focus();
            Interaction.Beep();
        }
        else
        {
            // cancels the error
            this.ErrorProvider1.Dispose();
        }

    }

    private void ValidateStringAcceptBlanks(ref TextBox txtValNumeric)
    {

        if (Information.TypeName(txtValNumeric.Text) == "String")
        {
            this.ErrorProvider1.SetError(txtValNumeric, "This must be a String value.");
            txtValNumeric.Focus();
            Interaction.Beep();
        }
        else
        {
            // cancels the error
            this.ErrorProvider1.Dispose();
        }

    }
    private void btnNewCategoryAccept_Click(object sender, EventArgs e)
    {

        if (cbxNewCategoryFunction.SelectedIndex == -1)
        {
            Interaction.MsgBox("You must select a function.");
            return;
        }
        UpdateCategory();
        newCategory.Updated = false;
        this.pnlNewCategory.Visible = false;

    }

    private void btnNewCategoryCancel_Click(object sender, EventArgs e)
    {

        // all info reset when pulls up again
        newCategory.Updated = false;
        this.pnlNewCategory.Visible = false;

    }

    private void UpdateCategory()
    {
        DataRow oRow;
        DataRow fRow;
        string catType;
        object newCatID;
        var newFunFlag = default(string);
        var newFunName = default(string);
        var ppName = default(string);

        // If Me.txtNewCategoryName.Text.Length = 0 Then Exit Sub
        if (this.ErrorProvider1.GetError(this.txtNewCategoryAbrev).Length > 0 | this.ErrorProvider1.GetError(this.txtNewCategoryName).Length > 0 | this.ErrorProvider1.GetError(this.cbxCategoryFunction).Length > 0)
        {
            this.ErrorProvider1.Dispose();
            this.pnlNewCategory.Visible = false;
            return;
        }
        else
        {
            newCategory.Updated = false;
        }

        if (newCategory.ActiveCategoryType == "Main")
        {
            catType = "MainCategory";
        }
        else if (newCategory.ActiveCategoryType == "Modifier")
        {
            catType = "ModifierCategory";
        }
        else
        {
            return;
        }

        foreach (DataRow currentFRow in dsSetup.Tables("Functions").Rows)
        {
            fRow = currentFRow;
            if (!(fRow.RowState == DataRowState.Deleted) & !(fRow.RowState == DataRowState.Detached))
            {
                if (fRow("FunctionID") == newCategory.ActiveFunction)    // 1 Then
                {
                    // Main Food Item
                    newFunFlag = "F";
                    newFunName = fRow("FunctionName");
                    break;
                }
                else if (fRow("FunctionID") == newCategory.ActiveFunction) // 10 Then
                {
                    newFunFlag = "O";
                    newFunName = fRow("FunctionName");
                    break;
                }
                else if (fRow("FunctionID") == newCategory.ActiveFunction) // 9 Then
                {
                    newFunFlag = "M";
                    newFunName = fRow("FunctionName");
                    break;
                }
            }
        }
        foreach (DataRow currentFRow1 in dsSetup.Tables("PrintPriority").Rows)
        {
            fRow = currentFRow1;
            if (!(fRow.RowState == DataRowState.Deleted) & !(fRow.RowState == DataRowState.Detached))
            {
                if (fRow("PrintPriorityID") == newCategory.Priority)
                {
                    ppName = fRow("PrintPriorityName");
                }
            }
        }

        newCategory.ActiveText = this.txtNewCategoryName.Text; // 
        newCategory.ActiveAbrevText = this.txtNewCategoryAbrev.Text; // 

        SaveUpdatedCategory();
        oRow = dsSetup.Tables("MainCategory").NewRow; // catType).NewRow

        // *** will have to change the way we get category ID
        // newCategory.ActiveID = GetMaximumID("CategoryID", "Category") + 1
        oRow("CompanyID") = corpID;
        oRow("LocationID") = selectedLocation;
        // oRow("CategoryID") = newCategory.ActiveID
        oRow("CategoryName") = newCategory.ActiveText;  // Me.txtNewCategoryName.Text 
        oRow("CategoryAbrev") = newCategory.ActiveAbrevText;    // Me.txtNewCategoryAbrev.Text 
        oRow("CategoryOrder") = newCategory.ActivePosition;
        oRow("FunctionID") = newCategory.ActiveFunction;
        oRow("FunctionName") = newFunName;
        oRow("FunctionFlag") = newFunFlag;
        // we could also put FunctionGroupID here ??/

        oRow("Priority") = newCategory.Priority;
        oRow("PrintPriorityName") = ppName;

        oRow("ButtonColor") = this.btnNewCategoryColor.BackColor.ToArgb;
        oRow("ButtonForeColor") = this.btnNewCategoryColor.ForeColor.ToArgb;
        oRow("HalfSplit") = this.chkNewHalfSplit.Checked; // newCategory.HalfSplit
        oRow("Extended") = chkNewExtendedDisplay.Checked;
        oRow("DisplayWithAdd") = chkNewDisplayWithAdds.Checked;
        oRow("Active") = true; // newCategory.CategoryIsActive

        dsSetup.Tables("MainCategory").Rows.Add(oRow);   // catType).Rows.Add(oRow)
        oRow("CategoryID") = InsertingNewCategory(ref oRow);
        dsSetup.Tables("MainCategory").AcceptChanges(); // catType).AcceptChanges()
                                                        // 444     oRow("SubCategoryID") = CInt(oRow("CategoryID"))
                                                        // SaveUpdatedCategory()


        if (newCategory.ActiveCategoryType == "Main")
        {
            btnMain(newCategory.ActiveButton).ID = oRow("CategoryID");
            btnMain(newCategory.ActiveButton).Text = txtNewCategoryAbrev.Text;
            btnMain(newCategory.ActiveButton).BtnIndex = newCategory.ActivePosition;
            btnMain(newCategory.ActiveButton).DataViewIndex = dvMainCategory.Count - 1;
            btnMain(newCategory.ActiveButton).BackColor = this.btnNewCategoryColor.BackColor;
            btnMain(newCategory.ActiveButton).ForeColor = this.btnNewCategoryColor.ForeColor;
        }

        else if (newCategory.ActiveCategoryType == "Modifier")
        {
            btnModifier(newCategory.ActiveButton).ID = oRow("CategoryID");
            btnModifier(newCategory.ActiveButton).Text = txtNewCategoryAbrev.Text;
            btnModifier(newCategory.ActiveButton).BtnIndex = newCategory.ActivePosition;
            btnModifier(newCategory.ActiveButton).DataViewIndex = dvMainCategory.Count - 1;
            btnModifier(newCategory.ActiveButton).BackColor = this.btnNewCategoryColor.BackColor;
            btnModifier(newCategory.ActiveButton).ForeColor = this.btnNewCategoryColor.ForeColor;

        }

    }

    private object InsertingNewCategory(ref DataRow oRow)
    {
        var newCategoryID = default(int);

        sql.SqlInsertCommandCategoryMain.Parameters("@CompanyID").Value = oRow("CompanyID");
        sql.SqlInsertCommandCategoryMain.Parameters("@LocationID").Value = oRow("LocationID");
        sql.SqlInsertCommandCategoryMain.Parameters("@CategoryName").Value = oRow("CategoryName");
        sql.SqlInsertCommandCategoryMain.Parameters("@CategoryAbrev").Value = oRow("CategoryAbrev");
        sql.SqlInsertCommandCategoryMain.Parameters("@CategoryOrder").Value = oRow("CategoryOrder");
        sql.SqlInsertCommandCategoryMain.Parameters("@FunctionID").Value = oRow("FunctionID");
        sql.SqlInsertCommandCategoryMain.Parameters("@SubCategoryID").Value = 0; // oRow("SubCategoryID")
        sql.SqlInsertCommandCategoryMain.Parameters("@Priority").Value = oRow("Priority");
        sql.SqlInsertCommandCategoryMain.Parameters("@ButtonColor").Value = oRow("ButtonColor");
        sql.SqlInsertCommandCategoryMain.Parameters("@ButtonForeColor").Value = oRow("ButtonForeColor");
        sql.SqlInsertCommandCategoryMain.Parameters("@HalfSplit").Value = oRow("HalfSplit");
        sql.SqlInsertCommandCategoryMain.Parameters("@Extended").Value = oRow("Extended");
        sql.SqlInsertCommandCategoryMain.Parameters("@DisplayWithAdd").Value = oRow("DisplayWithAdd");
        sql.SqlInsertCommandCategoryMain.Parameters("@Active").Value = oRow("Active");

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            newCategoryID = (int)sql.SqlInsertCommandCategoryMain.ExecuteScalar();
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
            Interaction.MsgBox(ex.Message);
        }

        return newCategoryID;

    }

    private void AdjustCategoryPosition()
    {

        // this moves the currency manager up then back
        // in order for the dataset to read changes but not move position
        if (mainCatCurrencyMan.Position < mainCatCurrencyMan.Count - 1)
        {
            mainCatCurrencyMan.Position += 1;
            mainCatCurrencyMan.Position -= 1;
        }
        else
        {
            mainCatCurrencyMan.Position -= 1;
            mainCatCurrencyMan.Position += 1;
        }

    }

    private void SaveUpdatedCategory()
    {
        AdjustCategoryPosition();

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlMenuCategoryMain.Update(dsSetup, "MainCategory");
            sql.cn.Close();
            dsSetup.Tables("MainCategory").AcceptChanges();
        }
        catch (Exception ex)
        {
            CloseConnection();
            Interaction.MsgBox(ex.Message);
        }

    }

    private void tabCategory_Leave(object sender, EventArgs e)
    {

        // If newCategory.Updated = True Then 'Or newCategory.UpdatedModifier = True Then
        // UpdateCategory()

        SaveUpdatedCategory();

    }


    // old below

    private void UpdateNewCategoryPanel222(ActiveCategory nc, string ab)
    {
        DataRowView vRow;
        if (dvMainCategory.Count < 1)
            return;
        if (nc.ActiveButton == 0)
            return;

        vRow = dvMainCategory(newCategory.DataViewIndex);

        if (ab == "MainCategory")
        {
            {
                var withBlock = btnMain(nc.ActiveButton);
                withBlock.DataViewIndex = dvMainCategory.Count - 1;
                withBlock.Name = nc.ActiveText;
                withBlock.Text = nc.ActiveAbrevText;
                withBlock.ID = nc.ActiveID;
                withBlock.Priority = nc.Priority;
                withBlock.Functions = nc.ActiveFunction;
                withBlock.HalfSplit = nc.HalfSplit;
                withBlock.IsActive = nc.CategoryIsActive;
                if (!object.ReferenceEquals(vRow("ButtonColor"), DBNull.Value))
                {
                    withBlock.BackColor = Color.FromArgb(vRow("ButtonColor"));
                }
                else
                {
                    withBlock.BackColor = Color.FromArgb(-9404272);
                }
                if (!object.ReferenceEquals(vRow("ButtonForeColor"), DBNull.Value))
                {
                    withBlock.ForeColor = Color.FromArgb(vRow("ButtonForeColor"));
                }
                else
                {
                    withBlock.ForeColor = Color.FromArgb(-16777216);
                }

            }
        }
        // 444      AddHandler btnMain(nc.ActiveButton).Click, AddressOf UpdateMainCategory
        else if (ab == "ModifierCategory")
        {
            {
                var withBlock1 = btnModifier(nc.ActiveButton);
                withBlock1.DataViewIndex = dvMainCategory.Count - 1;
                withBlock1.Name = nc.ActiveText;
                withBlock1.Text = nc.ActiveAbrevText;
                withBlock1.ID = nc.ActiveID;
                withBlock1.Priority = nc.Priority;
                withBlock1.Functions = nc.ActiveFunction;
                withBlock1.HalfSplit = nc.HalfSplit;
                withBlock1.IsActive = nc.CategoryIsActive;
                if (!object.ReferenceEquals(vRow("ButtonColor"), DBNull.Value))
                {
                    withBlock1.BackColor = Color.FromArgb(vRow("ButtonColor"));
                }
                else
                {
                    withBlock1.BackColor = Color.FromArgb(-9404272);
                }
                if (!object.ReferenceEquals(vRow("ButtonForeColor"), DBNull.Value))
                {
                    withBlock1.ForeColor = Color.FromArgb(vRow("ButtonForeColor"));
                }
                else
                {
                    withBlock1.ForeColor = Color.FromArgb(-16777216);
                }
            }
            // 444          AddHandler btnModifier(nc.ActiveButton).Click, AddressOf UpdateMainCategory 'UpdateModifierCategory
        }

    }

    private void UpdateCategoryPanel222(ActiveCategory nc, string ab)
    {

        if (nc.ActiveCategoryType == "Main")
        {
            btnMain(nc.ActiveButton).Name = nc.ActiveText;
            btnMain(nc.ActiveButton).Text = nc.ActiveAbrevText;
            btnMain(nc.ActiveButton).Functions = nc.ActiveFunction;
            btnMain(nc.ActiveButton).Priority = nc.Priority;
            btnMain(nc.ActiveButton).ColorInt = nc.ColorInt;
            btnMain(nc.ActiveButton).BackColor = Color.FromArgb(nc.ColorInt);
            btnMain(nc.ActiveButton).ForeColor = Color.FromArgb(nc.ColorForeInt);
            btnMain(nc.ActiveButton).HalfSplit = nc.HalfSplit;
            btnMain(nc.ActiveButton).IsActive = nc.CategoryIsActive;
        }
        else
        {
            btnModifier(nc.ActiveButton).Name = nc.ActiveText;
            btnModifier(nc.ActiveButton).Text = nc.ActiveAbrevText;
            btnModifier(nc.ActiveButton).Functions = nc.ActiveFunction;
            btnModifier(nc.ActiveButton).Priority = nc.Priority;
            btnModifier(nc.ActiveButton).ColorInt = nc.ColorInt;
            btnModifier(nc.ActiveButton).BackColor = Color.FromArgb(nc.ColorInt);
            btnModifier(nc.ActiveButton).ForeColor = Color.FromArgb(nc.ColorForeInt);
            btnModifier(nc.ActiveButton).HalfSplit = nc.HalfSplit;
            btnModifier(nc.ActiveButton).IsActive = nc.CategoryIsActive;
        }

    }


    // ****************************************************************
    // Foods
    // ****************************************************************

    private void DisplayFoodTab()
    {
        var tsFood = new DataGridTableStyle();
        tsFood.MappingName = "FoodTable";
        tsFood.RowHeadersVisible = false;
        tsFood.GridLineColor = Color.White;

        var csFoodID = new DataGridTextBoxColumn();
        csFoodID.MappingName = "FoodID";
        csFoodID.Width = 0;

        var csFoodName = new DataGridTextBoxColumn();
        csFoodName.MappingName = "FoodName";
        csFoodName.Width = this.grdFoodList.Width * 0.85d;

        tsFood.GridColumnStyles.Add(csFoodID);
        tsFood.GridColumnStyles.Add(csFoodName);
        grdFoodList.TableStyles.Add(tsFood);

    }

    private void DisplayMenuCostGroupBox()
    {

        int numberOfActiveMenuSelections;
        // Dim numberOfMenuSelections As Integer
        var index = default(int);

        // dvActiveMenu = New DataView
        {
            var withBlock = dvActiveMenu;
            withBlock.Table = dsSetup.Tables("Menus");
            withBlock.AllowEdit = true;
            withBlock.RowFilter = "Active = 1";
            withBlock.RowStateFilter = DataViewRowState.CurrentRows;
        }

        numberOfActiveMenuSelections = GetButtonCount("ActiveMenus");
        // numberOfMenuSelections = GetButtonCount("Menus")
        if (numberOfActiveMenuSelections > 10)
        {
            ;
#error Cannot convert ReDimStatementSyntax - see comment for details
            /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
               at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
               at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
               at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
               at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

            Input:
                        ReDim menuCheckBox(20)

             */
            ;
#error Cannot convert ReDimStatementSyntax - see comment for details
            /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
               at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
               at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
               at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
               at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

            Input:
                        ReDim menuCostText(20)

             */
            ;
#error Cannot convert ReDimStatementSyntax - see comment for details
            /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
               at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
               at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
               at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
               at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

            Input:
                        ReDim menuSurchargeText(20)

             */
            ;
#error Cannot convert ReDimStatementSyntax - see comment for details
            /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
                           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
                           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
                           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
                           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
                           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
                           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
                           at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
                           at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

                        Input:
                                    ReDim menuRouting(20)

                         */
        }
        int xMenu = 70;   // 96
        int xMenu2 = 50;  // 60  '66
        int yMenu = 24;
        int xMenuLocation = 75;
        int yMenuLocation = 3 * buttonSpace;
        var priceLabel = new Label();
        var surLabel = new Label();
        var routingLabel = new Label();

        menuCostGroupBox.Size = new Size(xMenu * 4 + 10, (yMenu + buttonSpace) * numberOfActiveMenuSelections + 3 * buttonSpace + 15);

        priceLabel.Text = " Price";
        priceLabel.Size = new Size(xMenu2, 15);
        priceLabel.Location = new Point(xMenuLocation, yMenuLocation);
        priceLabel.TextAlign = ContentAlignment.TopLeft;
        surLabel.Text = "Surcharge";
        surLabel.Size = new Size(xMenu2 + 15, 15);
        surLabel.Location = new Point(xMenuLocation + xMenu2, yMenuLocation);
        surLabel.TextAlign = ContentAlignment.TopLeft;
        routingLabel.Text = "Routing";
        routingLabel.Size = new Size(xMenu2, 15);
        routingLabel.Location = new Point(xMenuLocation + 130, yMenuLocation);
        routingLabel.TextAlign = ContentAlignment.TopLeft;

        menuCostGroupBox.Controls.Add(priceLabel);
        menuCostGroupBox.Controls.Add(surLabel);
        menuCostGroupBox.Controls.Add(routingLabel);

        yMenuLocation = yMenuLocation + 15 + buttonSpace;

        foreach (DataRowView vRow in dvActiveMenu)
        {
            menuCheckBox[index] = new CheckBox();
            {
                var withBlock1 = menuCheckBox[index];
                withBlock1.Text = dsSetup.Tables("Menus").Rows(index)("MenuName");
                withBlock1.Size = new Size(xMenu, yMenu);
                withBlock1.Location = new Point(buttonSpace, yMenuLocation);
                menuCostGroupBox.Controls.Add(menuCheckBox[index]);
            }
            menuCheckBox[index].Enter += menuCheckBox_Changed;

            menuCostText[index] = new TextBox();
            {
                var withBlock2 = menuCostText[index];
                withBlock2.Size = new Size(xMenu2, yMenu);
                withBlock2.Location = new Point(xMenuLocation, yMenuLocation);
                withBlock2.TextAlign = HorizontalAlignment.Right;

                menuCostGroupBox.Controls.Add(menuCostText[index]);
                xMenuLocation += xMenu2 + buttonSpace;
            }
            menuCostText[index].Validating += menuCostBoxes_Validating;
            // AddHandler menuCostText(index).Enter, AddressOf menuCostText_Changed


            menuSurchargeText[index] = new TextBox();
            {
                var withBlock3 = menuSurchargeText[index];
                withBlock3.Size = new Size(xMenu2, yMenu);
                withBlock3.Location = new Point(xMenuLocation, yMenuLocation);
                withBlock3.TextAlign = HorizontalAlignment.Right;

                menuCostGroupBox.Controls.Add(menuSurchargeText[index]);
                xMenuLocation += xMenu2 + buttonSpace;
            }
            menuSurchargeText[index].Validating += menuCostBoxes_Validating;
            // AddHandler menuSurchargeText(index).Enter, AddressOf menuSurchargeText_Changed


            menuRouting[index] = new ComboBox();
            {
                var withBlock4 = menuRouting[index];
                withBlock4.Size = new Size(xMenu2 * 2, yMenu);
                withBlock4.Location = new Point(xMenuLocation, yMenuLocation);
                // .TextAlign = HorizontalAlignment.Right
                menuCostGroupBox.Controls.Add(menuRouting[index]);
            }
            // AddHandler menuRouting(index).Validating, AddressOf menuCostBoxes_Validating
            // AddHandler menuRouting(index).SelectedIndexChanged, AddressOf menuRouting_Changed


            foreach (DataRow oRow in dsSetup.Tables("RoutingChoice").Rows)
            {
                if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                {
                    menuRouting[index].Items.Add(oRow("RoutingName"));
                }
            }

            xMenuLocation = 75;
            yMenuLocation = yMenuLocation + yMenu + buttonSpace;
            index += 1;

        }

    }

    private void MenuCostGroupBox_Enter(object sender, EventArgs e)
    {

        // AdjustPosition()

        if (dsSetup.HasChanges(DataRowState.Modified | DataRowState.Added))
        {
            // UpdateDatabaseFoods()
        }

        MenuCostChanged = true;

    }

    private void grdFoodList_Mouse(object sender, MouseEventArgs e) // Handles grdFoodList.MouseDown
    {

        if (cbxFoodCategory.Text == default)
        {
            Interaction.MsgBox("Please select a Category");
            newFood.GotoPrevious = true;
            return;
        }
        // If cbxFoodRouting.Text = Nothing Then 'And newFood.FunctionID = 1 Then
        // MsgBox("Please Select a Food Routing")
        // newFood.GotoPrevious = True
        // Exit Sub
        // End If
        // If cbxFoodTax.Text = Nothing Then
        // MsgBox("Please Select a Tax")
        // newFood.GotoPrevious = True
        // Exit Sub
        // End If

    }

    private void grdFoodList_Changed(object sender, EventArgs e)
    {

        if (newFood.GotoPrevious == true)
        {
            newFood.GotoPrevious = false;
            this.grdFoodList.CurrentRowIndex = newFood.PreviousPosition;
            return;
        }


        // AdjustPosition()       this does not work b/c it puts us in a loop
        // Me.TabMainFood.Update()

        if (chkManual.Checked == true)
        {
            this.txtFoodCost.BackColor = System.Drawing.Color.White;
        }
        else
        {
            this.txtFoodCost.BackColor = System.Drawing.Color.LightSteelBlue;
        }

        if (justAdjustingPosition == false)
        {

            UpdateMenuJoin();    // will only update if it was entered
            // UpdateDatabaseFoods()

            PopulateMenuCostGroupBox();
            PopulateModifierListBox();
            newFood.PreviousPosition = FoodCurrencyMan.Position;     // this actually records the new position used later

        }


    }

    private void PopulateModifierListBox()
    {
        DataRow oRow;
        this.lstModifierJoin.Items.Clear();

        PopulateFoodJoinData(ref this.grdFoodList);

        foreach (DataRow currentORow in dsSetup.Tables("JoinFoodCategoryJoins").Rows)
        {
            oRow = currentORow;
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                lstModifierJoin.Items.Add(oRow("CategoryName"));
            }
        }
        foreach (DataRow currentORow1 in dsSetup.Tables("JoinFoodModifierJoins").Rows)
        {
            oRow = currentORow1;
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                lstModifierJoin.Items.Add(oRow("FoodName"));
            }
        }

    }

    private void PopulateMenuCostGroupBox()
    {
        int rowNum = grdFoodList.CurrentCell.RowNumber;
        FoodCurrencyMan.Position = rowNum;

        int valueFoodID;
        int index;
        // Dim valueCatID As Integer
        string valueCatName;
        DataRow oRow;

        try
        {
            if (FoodCurrencyMan.Position == -1)
            {
                valueFoodID = 0;
            }
            else
            {
                valueFoodID = dvFoods(FoodCurrencyMan.Position)("FoodID");
            } // dsSetup.Tables("FoodTable").Rows(FoodCurrencyMan.Position)("FoodID")
        }

        catch (Exception ex)
        {
            valueFoodID = 0;
        }
        newFood.ActiveFoodID = valueFoodID;

        {
            var withBlock = dvMenuJoin;
            withBlock.Table = dsSetup.Tables("MenuJoin");
            withBlock.RowFilter = "FoodID = '" + valueFoodID + "' AND GeneralMenuID IS NULL";
            withBlock.Sort = "MenuID";
        }
        // dvMenuJoin = New DataView(dsSetup.Tables("MenuJoin"), "FoodID ='" & valueFoodID & "'", "MenuID", DataViewRowState.CurrentRows)

        index = 0;
        var nestedIndex = default(int);
        foreach (DataRowView vRow in dvActiveMenu)
        {
            menuCostText[index].Clear();
            menuSurchargeText[index].Clear();
            menuCheckBox[index].Checked = false;
            // menuRouting(index).SelectedIndex = -1    'Nothing

            menuRouting[index].Text = (object)null;
            foreach (DataRowView vRowNested in dvMenuJoin)
            {
                if (dvActiveMenu[index]("MenuID") == dvMenuJoin[nestedIndex]("MenuID"))
                {
                    menuCostText[index].Text = dvMenuJoin[nestedIndex]("Price");
                    menuSurchargeText[index].Text = dvMenuJoin[nestedIndex]("Surcharge");
                    // valueCatID = dvMenuJoin(nestedIndex)("RoutingID")
                    // valueCatName = dsSetup.Tables("RoutingChoice").Rows(dvMenuJoin(nestedIndex)("RoutingName")).ToString
                    if (dvMenuJoin[nestedIndex]("RoutingID") > 0)
                    {
                        oRow = dsSetup.Tables("RoutingChoice").Rows.Find(dvMenuJoin[nestedIndex]("RoutingID"));
                        menuRouting[index].SelectedText = oRow("RoutingName"); // (dsSetup.Tables("RoutingChoice").Rows(dvMenuJoin(nestedIndex)("RoutingID"))("RoutingName"))
                    }
                    if (dvMenuJoin[nestedIndex]("Active") == true)
                    {
                        menuCheckBox[index].Checked = true;
                    }
                    else
                    {
                        menuCheckBox[index].Checked = false;
                    }
                    if (cbxFoodCategory.SelectedIndex > -1)
                    {
                        this.newFood.FunctionID = dsSetup.Tables("MainCategory").Rows(cbxFoodCategory.SelectedIndex)("FunctionID");
                        if (newFood.FunctionID != 1)
                        {
                            menuRouting[index].BackColor = Color.LightSteelBlue;
                        }
                        else
                        {
                            menuRouting[index].BackColor = Color.White;
                        }
                    }

                }
                nestedIndex += 1;
            }
            nestedIndex = 0;
            index += 1;
        }

    }

    private void btnEnterNewFood_Click(object sender, EventArgs e)
    {
        if (TestRoutingInfo() == true)
        {
            UpdateMenuJoin();
            StartNewFood();
        }

    }

    private bool TestRoutingInfo()
    {
        var index = default(int);

        foreach (DataRowView vRow in dvActiveMenu)
        {
            if (menuCheckBox[index].Checked == true)
            {
                if (menuRouting[index].Text == "")
                {
                    Interaction.MsgBox("You must Select a Routing for " + vRow("MenuName"));
                    return false;
                }
            }
        }

        return true;

    }

    private void MoveLast()
    {
        FoodCurrencyMan.Position = FoodCurrencyMan.Count - 1;
        // the following has to be add .. just like in OrderGrid
        // Me.grdFoodList.ScrollToRow(FoodCurrencyMan.Position)

    }

    private void AdjustPosition()
    {

        // this moves the currency manager up then back
        // in order for the dataset to read changes but not move position
        if (FoodCurrencyMan.Position < FoodCurrencyMan.Count - 1)
        {
            FoodCurrencyMan.Position += 1;
            FoodCurrencyMan.Position -= 1;
        }
        else
        {
            FoodCurrencyMan.Position -= 1;
            FoodCurrencyMan.Position += 1;
        }

    }

    private void PopulateNewFoodInfo()
    {

        // Me.cbxPrintPriority.Text = newFood.PrintPriorityName
        // Me.cbxFoodRouting.Text = newFood.FoodRoutingName
        // Me.cbxFoodTax.Text = newFood.FoodTaxName

    }

    private void ClearMenuCostGroupBox()
    {
        var index = default(int);

        // clears menu cost group box
        foreach (DataRowView vRow in dvActiveMenu)
        {
            menuCheckBox[index].CheckState = false;
            menuCostText[index].Text = (object)null;
            menuSurchargeText[index].Text = (object)null;
            menuRouting[index].SelectedIndex = -1;   // Nothing
            index += 1;
        }

    }

    private void btnUpdateFood_Click(object sender, EventArgs e)
    {
        if (cbxFoodCategory.Text == default)
        {
            Interaction.MsgBox("Please select a Category");
            return;
        }
        // If cbxFoodRouting.Text = Nothing Then 'And newFood.FunctionID = 1 Then
        // MsgBox("Please Select a Food Routing")
        // Exit Sub
        // End If
        // If cbxFoodTax.Text = Nothing Then
        // MsgBox("Please Select a Tax")
        // Exit Sub
        // End If

        justAdjustingPosition = true;
        AdjustPosition();
        justAdjustingPosition = false;

        UpdateMenuJoin();
        if (dsSetup.HasChanges(DataRowState.Modified | DataRowState.Added))
        {
            UpdateDatabaseFoods();
        }

    }

    private void btnRemoveFood_Click(object sender, EventArgs e)
    {
        DataRow oRow;

        if (Interaction.MsgBox("Are you sure you want to remove the " + this.txtFoodName.Text + " and all its Joins?", MsgBoxStyle.OkCancel) == MsgBoxResult.Ok)
        {

            var upFoodJoin = default(bool);

            UpdateDatabaseFoodJoin();
            UpdateMenuJoinDatabase();
            UpdateDatabaseFoods();

            foreach (DataRow currentORow in dsSetup.Tables("FoodJoin").Rows)
            {
                oRow = currentORow;
                if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                {
                    if (oRow("FoodID") == newFood.ActiveFoodID)
                    {
                        oRow.Delete();
                        upFoodJoin = true;
                    }
                }
            }

            foreach (DataRow currentORow1 in dsSetup.Tables("MenuJoin").Rows)
            {
                oRow = currentORow1;
                if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                {
                    if (oRow("FoodID") == newFood.ActiveFoodID)
                    {
                        oRow.Delete();
                        menuBoxUpdated = true;
                    }
                }
            }

            foreach (DataRow currentORow2 in dsSetup.Tables("FoodTable").Rows)
            {
                oRow = currentORow2;
                if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                {
                    if (oRow("FoodID") == newFood.ActiveFoodID)
                    {
                        oRow.Delete();
                    }
                }
            }

            newFood.ActiveFoodID = (object)null;

            this.justAdjustingPosition = true;
            if (FoodCurrencyMan.Position > 0)
            {
                FoodCurrencyMan.Position -= 1;
            }
            else
            {
                FoodCurrencyMan.Position += 1;
            }
            this.justAdjustingPosition = false;


            if (upFoodJoin == true)
            {
                UpdateDatabaseFoodJoin();
            }
            if (menuBoxUpdated == true)
            {
                UpdateMenuJoinDatabase();
            }
            UpdateDatabaseFoods();
            PopulateMenuCostGroupBox();
            PopulateModifierListBox();
        }

    }

    private void cbxFoodFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbxFoodFilter.SelectedIndex == -1)
            return;

        // FoodCurrencyMan.Position = 0
        // grdFoodList.CurrentCell.RowNumber()
        // Dim rowNum As Integer = grdFoodList.CurrentCell.RowNumber
        // FoodCurrencyMan.Position = rowNum
        // FoodCurrencyMan.Position = -1

        if (cbxFoodCategory.Text == default)
        {
            // MsgBox("Please select a Category")
            // Exit Sub
            // If cbxFoodRouting.Text = Nothing Then 'And newFood.FunctionID = 1 Then
            // MsgBox("Please Select a Food Routing")
            // Exit Sub
            // End If
            // If cbxFoodTax.Text = Nothing Then
            // MsgBox("Please Select a Tax")
            // Exit Sub
            // End If

            // AdjustPosition()
            // UpdateDatabaseFoods()

        }

        cbxNewFoodCategory.Items.Clear();
        cbxFoodFilterModifiers.SelectedIndex = -1;  // this define it is NOT modifier


        foreach (DataRowView vRow in dvMainFoodsCategory)
            cbxNewFoodCategory.Items.Add(vRow("CategoryName"));

        UpdateMenuJoin();

        int valueCatID;
        // valueCatID = dsSetup.Tables("MainCategory").Rows(cbxFoodFilter.SelectedIndex)("CategoryID")
        // Me.newFood.FunctionID = dsSetup.Tables("MainCategory").Rows(cbxFoodFilter.SelectedIndex)("FunctionID")

        valueCatID = dvMainFoodsCategory(cbxFoodFilter.SelectedIndex)("CategoryID");
        lblSelectFoodFilter.Text = dvMainFoodsCategory(cbxFoodFilter.SelectedIndex)("CategoryName");
        globalJoinValueCategoryID = valueCatID;

        // dsSetup.Tables("FoodTable").Clear()

        // sql.SqlSelectCommandMenuFoods.Parameters("@CompanyID").Value = corpID
        // sql.SqlSelectCommandMenuFoods.Parameters("@LocationID").Value = selectedLocation
        // sql.SqlSelectCommandMenuFoods.Parameters("@CategoryID").Value = valueCatID

        // Try
        // sql.cn.Open()
        // sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        // sql.SqlMenuFoods.Fill(dsSetup.Tables("FoodTable"))
        // '       sql.cn.Close()
        // Catch ex As Exception
        // MsgBox(ex.Message)
        // CloseConnection()
        // End Try

        // 

        {
            var withBlock = dvFoods;
            withBlock.Table = dsSetup.Tables("FoodTable");
            withBlock.RowFilter = "CategoryID = " + valueCatID;
        }


        {
            var withBlock1 = dvFoodsJoins;
            withBlock1.Table = dsSetup.Tables("FoodTable");
            withBlock1.RowFilter = "CategoryID = " + valueCatID;
        }

        grdFoodList.CurrentRowIndex = 1;
        // FoodCurrencyMan.Position = grdFoodList.CurrentRowIndex

        // Dim rowNum As Integer = grdFoodList.CurrentCell.RowNumber
        // FoodCurrencyMan.Position = rowNum

        if (dsSetup.Tables("FoodTable").Rows.Count == 0)
        {
            this.cbxFoodCategory.SelectedIndex = this.cbxFoodFilter.SelectedIndex;
            PopulateNewFoodInfo();
        }


    }

    private void cbxFoodFilterModifiers_SelectedIndexChanged(object sender, EventArgs e)
    {
        // 666
        if (cbxFoodFilterModifiers.SelectedIndex == -1)
            return;

        cbxNewFoodCategory.Items.Clear();
        cbxFoodFilter.SelectedIndex = -1;

        foreach (DataRowView vRow in dvModifierCategory)
            cbxNewFoodCategory.Items.Add(vRow("CategoryName"));

        UpdateMenuJoin();

        int valueCatID;

        valueCatID = dvModifierCategory(cbxFoodFilterModifiers.SelectedIndex)("CategoryID");
        lblSelectFoodFilter.Text = dvMainFoodsCategory(cbxFoodFilterModifiers.SelectedIndex)("CategoryName");
        globalJoinValueCategoryID = valueCatID;

        {
            var withBlock = dvFoods;
            withBlock.Table = dsSetup.Tables("FoodTable");
            withBlock.RowFilter = "CategoryID = " + valueCatID;
        }

        {
            var withBlock1 = dvFoodsJoins;
            withBlock1.Table = dsSetup.Tables("FoodTable");
            withBlock1.RowFilter = "CategoryID = " + valueCatID;
        }

        grdFoodList.CurrentRowIndex = 1;

        if (dsSetup.Tables("FoodTable").Rows.Count == 0)
        {
            this.cbxFoodCategory.SelectedIndex = this.cbxFoodFilter.SelectedIndex;
            PopulateNewFoodInfo();
        }


    }

    private void btnShowAllFood_Click(object sender, EventArgs e)
    {

        {
            var withBlock = dvFoods;
            withBlock.Table = dsSetup.Tables("FoodTable");
            withBlock.RowFilter = "CategoryID > 0 AND (FunctionFlag = 'O' OR FunctionFlag = 'F')";
        }
        globalJoinValueCategoryID = 0;


    }
    private void txtFoodName_Enter(object sender, Global.System.Windows.Forms.MouseEventArgs e)
    {
        if (txtFoodName.Text.Length == 0)
        {
            if (TestRoutingInfo() == true)
            {
                // StartNewFood()
                // EnteringNewFood()
            }
        }

    }
    private void txtAbrevFoodName_Enter(object sender, EventArgs e)
    {
        if (txtAbrevFoodName.Text.Length == 0)
        {
            txtAbrevFoodName.Text = this.txtFoodName.Text;
        }

    }

    private void txtChitFoodName_Enter(object sender, EventArgs e)
    {
        if (txtChitFoodName.Text.Length == 0)
        {
            txtChitFoodName.Text = this.txtFoodName.Text;
        }

    }

    private void cbxFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
    {

        // *** currently not allowing us to change category of food item
        return;

        int valueCatID;
        string valueCatName;
        int valueFoodID;
        string valueFunFlag;

        if (FoodCurrencyMan.Position == -1)
            return;

        try
        {
            valueFoodID = dvFoods(FoodCurrencyMan.Position)("FoodID");
            valueCatID = dvMainFoodsCategory(cbxFoodCategory.SelectedIndex)("CategoryID");
            valueCatName = dvMainFoodsCategory(cbxFoodCategory.SelectedIndex)("CategoryName");
            valueFunFlag = dvMainFoodsCategory(cbxFoodCategory.SelectedIndex)("FunctionFlag");
        }
        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);
        }

        foreach (DataRowView vRow in dvFoods)    // dsSetup.Tables("FoodTable").Rows
        {
            if (vRow("FoodID") == valueFoodID)
            {
                vRow("CategoryID") = valueCatID;
                vRow("CategoryName") = valueCatName;
                vRow("FunctionFlag") = valueFunFlag;
            }
            break;
        }

    }

    private void cbxWineParring_SelectedIndexChanged(object sender, EventArgs e)
    {
        // 444      If newDrink.DrinkNameIndex = 0 Or oldDrink.DrinkNameIndex = 0 Then Exit Sub

        int valueCatID;
        string valueCatName;

        if (FoodCurrencyMan.Position == -1)
            return;

        valueCatID = dsSetup.Tables("WineParring").Rows(cbxWineParring.SelectedIndex)("DrinkID");
        valueCatName = dsSetup.Tables("WineParring").Rows(cbxWineParring.SelectedIndex)("DrinkName");

        if (dvFoods.Count > 0)
        {
            if (!(dvFoods(this.FoodCurrencyMan.Position)("WineParringID") == valueCatID))
            {
                newDrinkChangesMade = true;
                dvFoods(this.FoodCurrencyMan.Position)("WineParringID") = valueCatID;
                dvFoods(this.FoodCurrencyMan.Position)("DrinkName") = valueCatName;
            }
        }

    }

    private void cbxPrintPriority_SelectedIndexChanged(object sender, EventArgs e)
    {
        int valueCatID;
        string valueCatName;
        if (FoodCurrencyMan.Position == -1)
            return;

        valueCatID = dsSetup.Tables("PrintPriority").Rows(cbxPrintPriority.SelectedIndex)("PrintPriorityID");
        valueCatName = dsSetup.Tables("PrintPriority").Rows(cbxPrintPriority.SelectedIndex)("PrintPriorityName");

        if (dvFoods.Count > 0)
        {
            if (!(dvFoods(this.FoodCurrencyMan.Position)("PrintPriorityID") == valueCatID))
            {
                dvFoods(this.FoodCurrencyMan.Position)("PrintPriorityName") = valueCatName;
                dvFoods(this.FoodCurrencyMan.Position)("PrintPriorityID") = valueCatID;
            }
        }

    }

    private void btnFoodRecipe_Click(object sender, EventArgs e)
    {
        if (txtRecipe.Visible == false)
        {
            txtRecipe.Visible = true;
            txtRecipe.BringToFront();
        }
        else
        {
            txtRecipe.Visible = false;
        }

    }

    private void UpdateMenuJoin()
    {

        if (MenuCostChanged == false)
        {
            return;
        }
        else
        {
            // resets
            MenuCostChanged = false;
        }
        DataRow newRowDatabase;
        var menuIndex = default(int);
        bool newEntry = true;
        int valueCatID;
        string valueCatName;

        {
            var withBlock = dvMenuJoin;
            withBlock.Table = dsSetup.Tables("MenuJoin");
            withBlock.RowFilter = "FoodID = '" + newFood.ActiveFoodID + "' AND GeneralMenuID IS NULL";
            withBlock.Sort = "MenuID";
        }

        foreach (DataRowView vRow in dvActiveMenu)
        {

            if (menuCheckBox[menuIndex].Checked == true)
            {
                foreach (DataRowView vRowDatabase in dvMenuJoin)
                {
                    // passing test means menujoin already exists so just verify cost
                    if (vRowDatabase("MenuID") == vRow("MenuID"))
                    {
                        vRowDatabase("Price") = (decimal)menuCostText[menuIndex].Text;
                        vRowDatabase("Surcharge") = (decimal)menuSurchargeText[menuIndex].Text;
                        valueCatID = -1;
                        foreach (DataRow oRow in dsSetup.Tables("RoutingChoice").Rows)
                        {
                            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                            {
                                if (oRow("RoutingName") == menuRouting[menuIndex].Text)
                                {
                                    valueCatID = oRow("RoutingID");
                                    break;
                                }
                            }
                        }
                        vRowDatabase("RoutingID") = valueCatID;
                        vRowDatabase("Active") = menuCheckBox[menuIndex].Checked;
                        newEntry = false;
                    }
                }
                if (newEntry == true)
                {
                    newRowDatabase = dsSetup.Tables("MenuJoin").NewRow;
                    newRowDatabase("CompanyID") = corpID;
                    newRowDatabase("LocationID") = selectedLocation;
                    newRowDatabase("FoodID") = newFood.ActiveFoodID;
                    newRowDatabase("DrinkID") = DBNull.Value;
                    newRowDatabase("MenuID") = dvActiveMenu[menuIndex]("MenuID");
                    newRowDatabase("GeneralMenuID") = DBNull.Value;
                    if (menuCostText[menuIndex].Text == "")
                    {
                        newRowDatabase("Price") = 0;
                    }
                    else
                    {
                        newRowDatabase("Price") = (decimal)menuCostText[menuIndex].Text;
                    }
                    if (menuSurchargeText[menuIndex].Text == "")
                    {
                        newRowDatabase("Surcharge") = 0;
                    }
                    else
                    {
                        newRowDatabase("Surcharge") = (decimal)menuSurchargeText[menuIndex].Text;
                    }
                    // ***
                    if (menuRouting[menuIndex].SelectedIndex == -1)
                    {
                        valueCatID = lastSelectedRouting;
                    }
                    else
                    {
                        valueCatID = dsSetup.Tables("RoutingChoice").Rows(menuRouting[menuIndex].SelectedIndex)("RoutingID");
                        lastSelectedRouting = valueCatID;
                    }
                    newRowDatabase("RoutingID") = valueCatID;
                    newRowDatabase("MenuIndex") = 0;
                    newRowDatabase("Active") = menuCheckBox[menuIndex].Checked;
                    dsSetup.Tables("MenuJoin").Rows.Add(newRowDatabase);
                }
                newEntry = true;
            }

            else if (menuCheckBox[menuIndex].Checked == false)
            {


                // vRowDatabase("Active") = menuCheckBox(menuIndex).Checked
            }
            menuIndex += 1;
        }

        menuBoxUpdated = true;
        // 444    UpdateMenuJoinDatabase()

    }

    private void UpdateMenuJoinDatabase()
    {

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlMenuMenuJoin.Update(dsSetup, "MenuJoin");
            sql.cn.Close();
            dsSetup.Tables("MenuJoin").AcceptChanges();
            menuBoxUpdated = false;
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

    }

    private void ButtonFoodJoinLink_Click(object sender, EventArgs e)
    {
        if (cbxFoodCategory.Text == default)
        {
            Interaction.MsgBox("Please select a Category");
            return;
        }
        // If cbxFoodRouting.Text = Nothing Then 'And newFood.FunctionID = 1 Then
        // MsgBox("Please Select a Food Routing")
        // Exit Sub
        // End If
        // If cbxFoodTax.Text = Nothing Then
        // MsgBox("Please Select a Tax")
        // Exit Sub
        // End If

        TabControl1.SelectedTab = TabFoodJoin;

    }

    private void tabFood_Enter(object sender, EventArgs e)
    {
        DataRowView vRow;

        dvMainFoodsCategory = new DataView();

        {
            var withBlock = dvMainFoodsCategory;
            withBlock.Table = dsSetup.Tables("MainCategory");
            withBlock.RowFilter = "Active = True AND (FunctionFlag = 'F' OR FunctionFlag = 'O')";
            withBlock.Sort = "FunctionID, CategoryOrder";
        }


        cbxNewFoodCategory.Items.Clear();
        cbxFoodCategory.Items.Clear();
        cbxFoodFilter.Items.Clear();
        cbxFoodFilterModifiers.Items.Clear();

        foreach (DataRowView currentVRow in dvMainFoodsCategory)
        {
            vRow = currentVRow;
            cbxNewFoodCategory.Items.Add(vRow("CategoryName"));
            cbxFoodCategory.Items.Add(vRow("CategoryName"));
            cbxFoodFilter.Items.Add(vRow("CategoryName"));
        }

        // 666 
        dvModifierCategory = new DataView();

        {
            var withBlock1 = dvModifierCategory;
            withBlock1.Table = dsSetup.Tables("MainCategory");
            withBlock1.RowFilter = "Active = True AND (FunctionFlag = 'M')";
            withBlock1.Sort = "FunctionID, CategoryOrder";
        }
        foreach (DataRowView currentVRow1 in dvModifierCategory)
        {
            vRow = currentVRow1;
            // 444         cbxNewFoodCategory.Items.Add(vRow("CategoryName"))
            // cbxFoodCategory.Items.Add(vRow("CategoryName"))
            cbxFoodFilterModifiers.Items.Add(vRow("CategoryName"));
        }


        // With dvFoods
        // .Table = dsSetup.Tables("FoodTable")
        // .RowFilter = "CategoryID = " & Me.globalJoinValueCategoryID
        // End With

        // Me.cbxFoodFilter.SelectedIndex = -1

        // grdJoinFoodChoice.DataSource = Nothing
        // grdFoodList.DataSource = dsSetup.Tables("FoodTable")

        // Me.grdJoinFoodChoice.Enabled = False
        // grdFoodList.Enabled = True

        // Me.grdFoodList.CurrentRowIndex = FoodCurrencyMan.Position
        // AdjustPosition()
        // FoodCurrencyMan.ResumeBinding()
        // JoinCurrencyMan.SuspendBinding()

        // grdJoinFoodChoice.SuspendLayout()
        // grdFoodList.ResumeLayout()


    }
    // Private Sub tabFoodJoin_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabFoodJoin.Enter

    // GenerateTables.ClearingDataToRepopulate()
    // GenerateTables.RepopulateDataSets(selectedLocation)

    // grdFoodList.DataSource = Nothing
    // grdJoinFoodChoice.DataSource = dsSetup.Tables("FoodTable")

    // grdFoodList.Enabled = False
    // Me.grdJoinFoodChoice.Enabled = True

    // Me.grdJoinFoodChoice.CurrentRowIndex = FoodCurrencyMan.Position
    // adjustposition

    // JoinCurrencyMan.ResumeBinding()
    // FoodCurrencyMan.SuspendBinding()
    // grdFoodList.ResumeLayout()
    // grdJoinFoodChoice.SuspendLayout()

    // End Sub

    // ***********************
    // new food
    private void StartNewFood()
    {

        this.pnlNewFood.Visible = true;
        this.pnlNewFood.BringToFront();
        this.txtNewFoodName.Focus();
        int valueID;
        string valueName;
        DataRow oRow;

        try
        {
            if (!(this.cbxFoodFilter.SelectedIndex == -1))
            {
                this.cbxNewFoodCategory.SelectedIndex = cbxFoodFilter.SelectedIndex;
            }
            else if (!(this.cbxFoodFilterModifiers.SelectedIndex == -1)) // 666
            {
                this.cbxNewFoodCategory.SelectedIndex = cbxFoodFilterModifiers.SelectedIndex;
            }
            else
            {
                this.cbxNewFoodCategory.SelectedIndex = cbxFoodCategory.SelectedIndex;
            }
        }
        catch (Exception ex)
        {
        }

        ClearMenuCostGroupBox();
        this.lstModifierJoin.Items.Clear();


    }

    private void txtNewAbrevFoodName_Enter(object sender, EventArgs e)
    {
        if (txtNewAbrevFoodName.Text.Length == 0)
        {
            txtNewAbrevFoodName.Text = this.txtNewFoodName.Text;
        }

    }

    private void txtNewChitFoodName_Enter(object sender, EventArgs e)
    {
        if (txtNewChitFoodName.Text.Length == 0)
        {
            txtNewChitFoodName.Text = this.txtNewFoodName.Text;
        }

    }


    private void txtNewFoodName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
    }

    private void txtNewAbrevFoodName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
    }

    private void txtNewChitFoodName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
    }


    private void txtNewFoodPrepare_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {

    }

    private void btnNewFoodAccept_Click(object sender, EventArgs e)
    {
        ValidateString(ref this.txtNewFoodName);
        ValidateString(ref this.txtNewAbrevFoodName);
        ValidateString(ref this.txtNewChitFoodName);
        ValidateNumeric(ref txtNewFoodPrepare, false);


        if (ErrorProvider1.GetError(this.txtNewFoodName).Length > 0)
        {
            return;
        }
        if (ErrorProvider1.GetError(this.txtNewAbrevFoodName).Length > 0)
        {
            txtNewAbrevFoodName.Text = this.txtNewFoodName.Text;
        }
        if (ErrorProvider1.GetError(this.txtNewChitFoodName).Length > 0)
        {
            this.txtNewChitFoodName.Text = this.txtNewAbrevFoodName.Text;
        }
        if (ErrorProvider1.GetError(this.txtNewFoodPrepare).Length > 0)
        {
            Interaction.MsgBox("Prepare time must be a numeric value.");
            return;
            // Me.txtNewFoodPrepare.Text = 0
        }
        // If cbxFoodCategory.Text = Nothing Then
        // MsgBox("Please select a Category")
        // Exit Sub
        // End If
        if (this.cbxNewFoodCategory.SelectedIndex == -1)
        {
            Interaction.MsgBox("You must choose a Category");
            return;
        }
        EnteringNewFood();

    }

    private void btnNewFoodCancel_Click(object sender, EventArgs e)
    {

        this.pnlNewFood.Visible = false;
        PopulateMenuCostGroupBox();
        PopulateModifierListBox();

    }

    private void EnteringNewFood()
    {

        // If filledFirstFood = True Then
        justAdjustingPosition = true;
        AdjustPosition();
        justAdjustingPosition = false;
        UpdateDatabaseFoods();
        // 444     UpdateMenuJoin()
        // End If

        int valueID;
        string valueName;
        DataRow oRow;
        try
        {
            // 444      If Not Me.cbxNewFoodCategory.SelectedIndex = -1 Then
            if (!(cbxFoodFilter.SelectedIndex == -1))
            {
                valueID = dvMainFoodsCategory(cbxNewFoodCategory.SelectedIndex)("CategoryID");
                valueName = dvMainFoodsCategory(cbxNewFoodCategory.SelectedIndex)("CategoryName");
            }
            else if (!(cbxFoodFilterModifiers.SelectedIndex == -1))
            {
                valueID = dvModifierCategory(cbxNewFoodCategory.SelectedIndex)("CategoryID");
                valueName = dvModifierCategory(cbxNewFoodCategory.SelectedIndex)("CategoryName");
            }
            else
            {
                // just fallback
                valueID = dvMainFoodsCategory(cbxNewFoodCategory.SelectedIndex)("CategoryID");
                valueName = dvMainFoodsCategory(cbxNewFoodCategory.SelectedIndex)("CategoryName");
            }
        }

        catch (Exception ex)
        {
            valueID = 0;
            valueName = "";
            Interaction.MsgBox(ex.Message);
            return;
        }

        // ClearFoodInput()             'clears menu info
        int newFoodId;

        oRow = dsSetup.Tables("FoodTable").NewRow;

        oRow("CompanyID") = corpID;
        oRow("LocationID") = selectedLocation;
        oRow("FoodName") = this.txtNewFoodName.Text; // "   ** Empty Food **"
        oRow("AbrevFoodName") = this.txtNewAbrevFoodName.Text; // ""
        oRow("ChitFoodName") = this.txtNewChitFoodName.Text; // ""
        oRow("FoodDesc") = "";
        oRow("CategoryID") = valueID;
        oRow("CategoryName") = valueName;
        oRow("FoodCost") = 0;
        oRow("InvMultiplier") = 1;
        oRow("FoodCostManual") = 0;  // Me.chkManual.Checked  
        oRow("WineParringID") = 0;
        oRow("PrintPriorityID") = 3;
        oRow("Active") = 1;
        if (this.txtNewFoodPrepare.TextLength == 0)
        {
            oRow("PrepareTime") = 0;
        }
        else
        {
            oRow("PrepareTime") = this.txtNewFoodPrepare.Text;
        }


        dsSetup.Tables("FoodTable").Rows.Add(oRow);
        oRow("FoodID") = InsertingNewFood(ref oRow);
        // UpdateDatabaseFoods()

        dsSetup.Tables("FoodTable").AcceptChanges();

        // Me.pnlNewFood.Visible = False
        txtNewFoodName.Text = "";
        this.txtNewAbrevFoodName.Text = "";
        this.txtNewChitFoodName.Text = "";

        // Me.PopulateMenuCostGroupBox()
        // Me.PopulateModifierListBox()

        newFood.ActiveFoodID = oRow("FoodID");
        MenuCostChanged = true;
        UpdateMenuJoin();

        {
            var withBlock = dvFoods;
            withBlock.Table = dsSetup.Tables("FoodTable");
            withBlock.RowFilter = "CategoryID = " + valueID;
        }

        this.grdFoodList.CurrentRowIndex = dvFoods.Count - 1;
        txtNewFoodName.Focus();

    }

    private object InsertingNewFood(ref DataRow orow)
    {
        var newFoodID = default(int);

        sql.SqlInsertCommandMenuFoods.Parameters("@CompanyID").Value = orow("CompanyID");
        sql.SqlInsertCommandMenuFoods.Parameters("@LocationID").Value = orow("LocationID");
        sql.SqlInsertCommandMenuFoods.Parameters("@FoodName").Value = orow("FoodName");
        sql.SqlInsertCommandMenuFoods.Parameters("@AbrevFoodName").Value = orow("AbrevFoodName");
        sql.SqlInsertCommandMenuFoods.Parameters("@ChitFoodName").Value = orow("ChitFoodName");
        sql.SqlInsertCommandMenuFoods.Parameters("@CategoryID").Value = orow("CategoryID");
        sql.SqlInsertCommandMenuFoods.Parameters("@NoPortions").Value = 1;
        sql.SqlInsertCommandMenuFoods.Parameters("@FoodCost").Value = orow("FoodCost");
        sql.SqlInsertCommandMenuFoods.Parameters("@FoodCostManual").Value = orow("FoodCostManual");
        sql.SqlInsertCommandMenuFoods.Parameters("@FoodDesc").Value = orow("FoodDesc");
        sql.SqlInsertCommandMenuFoods.Parameters("@WineParringID").Value = orow("WineParringID");
        sql.SqlInsertCommandMenuFoods.Parameters("@PrintPriorityID").Value = orow("PrintPriorityID");
        sql.SqlInsertCommandMenuFoods.Parameters("@Active").Value = 1;
        sql.SqlInsertCommandMenuFoods.Parameters("@PrepareTime").Value = orow("PrepareTime");
        sql.SqlInsertCommandMenuFoods.Parameters("@InvMultiplier").Value = orow("InvMultiplier");
        sql.SqlInsertCommandMenuFoods.Parameters("@FoodInvOn").Value = 0;
        sql.SqlInsertCommandMenuFoods.Parameters("@FoodInv").Value = 0;
        sql.SqlInsertCommandMenuFoods.Parameters("@AvailForExtraNo").Value = 0;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            newFoodID = (int)sql.SqlInsertCommandMenuFoods.ExecuteScalar();
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
            Interaction.MsgBox(ex.Message);
        }

        return newFoodID;

    }

    private void ResetNewFoodPanel()
    {



    }




    private void tabFood_Leave(object sender, EventArgs e)
    {
        if (cbxFoodCategory.Text == default)
        {
            Interaction.MsgBox("Please select a Category");
            return;
        }
        // If cbxFoodRouting.Text = Nothing Then 'And newFood.FunctionID = 1 Then
        // MsgBox("Please Select a Food Routing")
        // Exit Sub
        // End If
        // If cbxFoodTax.Text = Nothing Then
        // MsgBox("Please Select a Tax")
        // Exit Sub
        // End If

        justAdjustingPosition = true;
        AdjustPosition();
        justAdjustingPosition = false;

        UpdateMenuJoin();
        if (menuBoxUpdated == true)
        {
            UpdateMenuJoinDatabase();
        }

        if (dsSetup.HasChanges(DataRowState.Modified | DataRowState.Added))
        {
            UpdateDatabaseFoods();
            ResetNewFoodPanel();
            this.pnlNewFood.Visible = false;
            dvMainFoodsCategory.Dispose();
            // GenerateTables.ClearingDataToRepopulate()
            // GenerateTables.RepopulateDataSets(selectedLocation)
        }

    }

    // ******************************************************************
    // Modifiers
    // ******************************************************************

    private void tabModifier_Enter(object sender, EventArgs e)
    {

        dvModifierCategory = new DataView();

        {
            var withBlock = dvModifierCategory;
            withBlock.Table = dsSetup.Tables("MainCategory");
            withBlock.RowFilter = "Active = True AND (FunctionFlag = 'M')";
            withBlock.Sort = "FunctionID, CategoryOrder";
        }

        cbxModifierFilter.Items.Clear();

        foreach (DataRowView vRow in dvModifierCategory)
            cbxModifierFilter.Items.Add(vRow("CategoryName"));

    }

    private void tabModifier_Leave(object sender, EventArgs e)
    {
        UpdateDatabaseModifiers();
        SaveModifierChanges();
        ResetNewModifier();
        this.pnlNewModifier.Visible = false;
        dvModifierCategory.Dispose();

    }

    private void cbxModifierFilter_SelectedIndexChanged(object sender, EventArgs e)
    {

        ClearNewModifier();

        int valueCatID;
        valueCatID = dvModifierCategory(cbxModifierFilter.SelectedIndex)("CategoryID");
        newModifier.ActiveModifierCategoryID = valueCatID;
        newModifier.ActiveModifierID = -1;

        this.lblSelectModifierFilter.Text = cbxModifierFilter.Text;

        PopulateModifierDetail();

    }

    private void PopulateModifierDetail()
    {

        {
            var withBlock = dvModifiers;
            withBlock.Table = dsSetup.Tables("Modifiers");
            withBlock.RowFilter = "CategoryID = '" + newModifier.ActiveModifierCategoryID + "'";
            withBlock.Sort = "MenuIndex";
        }

        {
            var withBlock1 = dvModifierStaging;
            withBlock1.Table = dsSetup.Tables("Modifiers");
            withBlock1.RowFilter = "CategoryID = '" + newModifier.ActiveModifierCategoryID + "' AND MenuIndex = 0";
        }

        newModifier.PageIndex = 1;
        if (dvModifiers.Count > 0)
        {
            newModifier.MaxIndex = dvModifiers(dvModifiers.Count - 1)("MenuIndex");
        }
        else
        {
            newModifier.MaxIndex = 0;
        };
#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
           at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

        Input:

                ReDim modifierID(newModifier.MaxIndex + 48)

         */
        ;
#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
           at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

        Input:
                ReDim modifierName(newModifier.MaxIndex + 48)

         */
        ;
        // ReDim modifierDataViewIndex(newModifier.MaxIndex + 32)

#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
                   at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
                   at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
                   at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
                   at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
                   at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
                   at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
                   at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
                   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

                Input:
                        ReDim modifierIndex(newModifier.MaxIndex + 48)

                 */
        PopulateModifierDataFromTable();
        DisplayModifierPage(newModifier.PageIndex);
        DisplayModifierStagingPage();

        return;
        // 222

        string tempCommandString = sql.SqlSelectCommandModifiers.CommandText;

        dsSetup.Tables("Modifiers").Clear();
        // Me.SqlInsertCommandModifiers.Parameters("@CategoryID").Value = newModifier.ActiveModifierCategoryID
        sql.SqlSelectCommandModifiers.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandModifiers.Parameters("@LocationID").Value = selectedLocation;

        sql.SqlSelectCommandModifiers.CommandText = sql.SqlSelectCommandModifiers.CommandText + " AND Foods.CategoryID = '" + newModifier.ActiveModifierCategoryID + "'";
        sql.cn.Open();
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
        sql.SqlMenuModifiers.Fill(dsSetup.Tables("Modifiers"));
        sql.cn.Close();
        sql.SqlSelectCommandModifiers.CommandText = tempCommandString;

        newModifier.PageIndex = 1;
        try
        {
            newModifier.MaxIndex = dsSetup.Tables("Modifiers").Compute("Max(MenuIndex)", "");
        }
        catch (Exception ex)
        {
            newModifier.MaxIndex = 0;
        };
#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
           at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

        Input:

                ReDim modifierID(newModifier.MaxIndex + 48)

         */
        ;
#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
           at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

        Input:
                ReDim modifierName(newModifier.MaxIndex + 48)

         */
        ;

#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
                   at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
                   at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
                   at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
                   at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
                   at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
                   at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
                   at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
                   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

                Input:
                        ReDim modifierIndex(newModifier.MaxIndex + 48)

                 */
        PopulateModifierDataFromTable();
        // CreateModifierStagingDataView()
        DisplayModifierPage(newModifier.PageIndex);
        DisplayModifierStagingPage();


    }

    private void PopulateModifierDataFromTable()
    {
        int dataViewCount = 0;

        foreach (DataRowView vRow in dvModifiers)    // dsSetup.Tables("Modifiers").Rows
        {
            this.modifierID(vRow("MenuIndex")) = vRow("FoodID");
            this.modifierName(vRow("MenuIndex")) = vRow("FoodName");
            if (vRow("MenuIndex") > 0)
            {
                // we need this b/c a zero is still staging
                this.modifierIndex(vRow("MenuIndex")) = vRow("MenuIndex");
            }
            // Me.modifierDataViewIndex(vRow("MenuIndex")) = dataViewCount
            dataViewCount += 1;
        }

    }

    private void DisplayModifierPage(int pageNumber)
    {
        int index;
        var startPosition = default(int);
        var stopPosition = default(int);
        int position = 1;

        // do not need this for modifiers b/c only the same 8 staging panels always
        // Me.pnlOrderModifierStaging.Controls.Clear()

        // 444    Me.ModifierCurrencyMan.SuspendBinding()
        this.pnlModifierItems.Controls.Clear();

        if (pageNumber == 1)
        {
            startPosition = 1;
            stopPosition = startPosition + 23;
        }
        else if (pageNumber > 1)
        {
            startPosition = (pageNumber - 1) * 24 + 1;     // this increases it by 14 every page
            stopPosition = startPosition + 23;
        }

        this.pnlModifierItems.SuspendLayout();
        int mi;
        DataRowView vRow;

        var loopTo = stopPosition;
        for (index = startPosition; index <= loopTo; index++)
        {
            // For Each vRow In dvModifiers
            // If vRow("MenuIndex") = index Then
            mi = (newModifier.PageIndex - 1) * 24 + position;
            if (pageNumber > 1 & index == startPosition)
            {
                DisplayOrderModifiers(1, mi, -1, "Previous", default, default, default, default, default, default);
            }
            else if (index == stopPosition & newModifier.MaxIndex > index)
            {
                // this is the last panel on page 
                // must add 1 b/c the 1st of next page is the same as the last of this page
                DisplayOrderModifiers(24, mi, -2, "Next", default, default, default, default, default, default);
            }

            else
            {
                // MsgBox(modifierIndex(index))
                // If modifierIndex(index) > 0 Then
                DisplayOrderModifiers(position, mi, modifierID[index], modifierName[index], default, default, default, default, default, default);
                // Else
                // this might be the same as above : foodname is nothing if foodindex = 0
                // DisplayOrderModifiers(position, mi, Nothing, "")
                // End If
            }
            position += 1;
            // End If
            // Exit For
            // Next
        }

        this.pnlModifierItems.ResumeLayout();
        newModifierChangesMade = false;

    }

    private void DisplayOrderModifiers(int position, int Index, int menuJoinId, string name, int fID, decimal sur, int rout, int dID, int GenMenuID, int cm)
    {
        float w = (this.pnlModifierItems.Width - 15) / 4;
        float h = (this.pnlModifierItems.Height - 23) / 6;
        string dTable = "Modifiers";
        object price = null;     // keep in case we want to add

        switch (position)
        {
            case 1:
                {
                    modifierOrderPanel1 = new FoodOrderPanel(cs1, cs2, 1, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel1);
                    break;
                }
            case 2:
                {
                    modifierOrderPanel2 = new FoodOrderPanel(cs1, cs2, 2, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel2);
                    break;
                }
            case 3:
                {
                    modifierOrderPanel3 = new FoodOrderPanel(cs1, cs2, 3, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel3);
                    break;
                }
            case 4:
                {
                    modifierOrderPanel4 = new FoodOrderPanel(cs1, cs2, 4, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel4);
                    break;
                }
            case 5:
                {
                    modifierOrderPanel5 = new FoodOrderPanel(cs1, cs2, 5, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel5);
                    break;
                }
            case 6:
                {
                    modifierOrderPanel6 = new FoodOrderPanel(cs1, cs2, 6, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel6);
                    break;
                }
            case 7:
                {
                    modifierOrderPanel7 = new FoodOrderPanel(cs1, cs2, 7, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel7);
                    break;
                }
            case 8:
                {
                    modifierOrderPanel8 = new FoodOrderPanel(cs1, cs2, 8, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel8);
                    break;
                }
            case 9:
                {
                    modifierOrderPanel9 = new FoodOrderPanel(cs1, cs2, 9, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel9);
                    break;
                }
            case 10:
                {
                    modifierOrderPanel10 = new FoodOrderPanel(cs1, cs2, 10, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel10);
                    break;
                }
            case 11:
                {
                    modifierOrderPanel11 = new FoodOrderPanel(cs1, cs2, 11, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel11);
                    break;
                }
            case 12:
                {
                    modifierOrderPanel12 = new FoodOrderPanel(cs1, cs2, 12, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel12);
                    break;
                }
            case 13:
                {
                    modifierOrderPanel13 = new FoodOrderPanel(cs1, cs2, 13, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel13);
                    break;
                }
            case 14:
                {
                    modifierOrderPanel14 = new FoodOrderPanel(cs1, cs2, 14, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel14);
                    break;
                }
            case 15:
                {
                    modifierOrderPanel15 = new FoodOrderPanel(cs1, cs2, 15, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel15);
                    break;
                }
            case 16:
                {
                    modifierOrderPanel16 = new FoodOrderPanel(cs1, cs2, 16, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel16);
                    break;
                }
            case 17:
                {
                    modifierOrderPanel17 = new FoodOrderPanel(cs1, cs2, 17, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel17);
                    break;
                }
            case 18:
                {
                    modifierOrderPanel18 = new FoodOrderPanel(cs1, cs2, 18, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel18);
                    break;
                }
            case 19:
                {
                    modifierOrderPanel19 = new FoodOrderPanel(cs1, cs2, 19, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel19);
                    break;
                }
            case 20:
                {
                    modifierOrderPanel20 = new FoodOrderPanel(cs1, cs2, 20, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel20);
                    break;
                }
            case 21:
                {
                    modifierOrderPanel21 = new FoodOrderPanel(cs1, cs2, 21, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel21);
                    break;
                }
            case 22:
                {
                    modifierOrderPanel22 = new FoodOrderPanel(cs1, cs2, 22, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel22);
                    break;
                }
            case 23:
                {
                    modifierOrderPanel23 = new FoodOrderPanel(cs1, cs2, 23, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel23);
                    break;
                }
            case 24:
                {
                    modifierOrderPanel24 = new FoodOrderPanel(cs1, cs2, 24, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlModifierItems.Controls.Add(modifierOrderPanel24);
                    break;
                }
                // Case 25
                // modifierOrderPanel25 = New FoodOrderPanel(cs1, cs2, 25, w, h, Index, menuJoinId, name, price, False, dTable, fID, sur, rout, dID, GenMenuID, cm)
                // Me.pnlModifierItems.Controls.Add(modifierOrderPanel25)
        }

    }

    private void DisplayModifierStagingPage()
    {
        int index = 1;
        int counter = 1;
        this.pnlOrderModifierStaging.Controls.Clear();

        foreach (DataRowView vRow in dvModifierStaging)
        {
            DisplayStagingPanelForModifierItem(counter, 0, vRow("FoodID"), vRow("FoodName"), default, default, default, default, default, default, default);
            counter += 1;
        }
        for (index = counter; index <= 8; index++)
            DisplayStagingPanelForModifierItem(index, 0, default, "", default, default, default, default, default, default, default);

    }

    private void DisplayStagingPanelForModifierItem(int position, int Index, int menuJoinID, string name, decimal price, int fID, decimal sur, int rout, int dID, int GenMenuID, int cm)
    {
        float w = (this.pnlOrderModifierStaging.Width - 15) / 4;    // spacing is 3 
        float h = (this.pnlOrderModifierStaging.Height - 9) / 2; // 3 times #of panels + 3(extra space)
        string dTable = "Modifiers";

        switch (position)
        {
            case 1:
                {
                    modifierOrderStaging1 = new FoodOrderPanel((object)null, (object)null, position, w, h, Index, menuJoinID, name, price, true, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging1);
                    break;
                }
            case 2:
                {
                    modifierOrderStaging2 = new FoodOrderPanel((object)null, (object)null, position, w, h, Index, menuJoinID, name, price, true, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging2);
                    break;
                }
            case 3:
                {
                    modifierOrderStaging3 = new FoodOrderPanel((object)null, (object)null, position, w, h, Index, menuJoinID, name, price, true, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging3);
                    break;
                }
            case 4:
                {
                    modifierOrderStaging4 = new FoodOrderPanel((object)null, (object)null, position, w, h, Index, menuJoinID, name, price, true, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging4);
                    break;
                }
            case 5:
                {
                    modifierOrderStaging5 = new FoodOrderPanel((object)null, (object)null, position, w, h, Index, menuJoinID, name, price, true, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging5);
                    break;
                }
            case 6:
                {
                    modifierOrderStaging6 = new FoodOrderPanel((object)null, (object)null, position, w, h, Index, menuJoinID, name, price, true, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging6);
                    break;
                }
            case 7:
                {
                    modifierOrderStaging7 = new FoodOrderPanel((object)null, (object)null, position, w, h, Index, menuJoinID, name, price, true, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging7);
                    break;
                }
            case 8:
                {
                    modifierOrderStaging8 = new FoodOrderPanel((object)null, (object)null, position, w, h, Index, menuJoinID, name, price, true, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging8);
                    break;
                }
        }

        // modifierOrderStaging(position) = New FoodOrderPanel(Nothing, Nothing, position, w, h, Index, menuJoinID, name, price, True, dTable)
        // Me.pnlOrderModifierStaging.Controls.Add(modifierOrderStaging(position))

    }

    private void ModifierPanelClick(object sender, EventArgs e)
    {
        FoodPanelControl currentOrderPanel;
        currentOrderPanel = (FoodPanelControl)sender;
        DataRow oRow;
        int index = -1;
        var counter = default(int);

        // Me.ModifierCurrencyMan.ResumeBinding()

        // do not know why the following does not work?????
        if (currentOrderPanel.MenuJoinID == -1)
        {
            // Previous
            newModifier.PageIndex -= 1;
            PopulateModifierDataFromTable();
            DisplayModifierPage(newModifier.PageIndex);
            return;
        }

        if (currentOrderPanel.MenuJoinID == -2)
        {
            // Next
            newModifier.PageIndex += 1;
            PopulateModifierDataFromTable();
            DisplayModifierPage(newModifier.PageIndex);
            return;
        }

        TestForModifierChanges();



        // If currentOrderPanel.MenuJoinID > 0 Then

        // For Each vRow In dvModifiers
        // If vRow("FoodID") = currentOrderPanel.MenuJoinID Then
        // txtModifierName.Text = vRow("FoodName")
        // txtModifierAbrev.Text = vRow("AbrevFoodName")
        // txtModifierChit.Text = vRow("ChitFoodName")
        // If Not vRow("FoodCost") Is DBNull.Value Then
        // '        txtModifierCost.Text = vRow("FoodCost")
        // Else
        // txtModifierCost.Text = "0"
        // End If
        // '   If Not vRow("Surcharge") Is DBNull.Value Then
        // txtModifierSurcharge.Text = vRow("Surcharge")
        // Else
        // txtModifierSurcharge.Text = "0"
        // End If
        // cbxModifierRouting.SelectedIndex = -1
        // If Not vRow("RoutingName") Is DBNull.Value Then
        // '         For Each oRow In dsSetup.Tables("RoutingChoice").Rows
        // If oRow("RoutingName") = vRow("RoutingName") Then
        // '        cbxModifierRouting.SelectedText = vRow("RoutingName")
        // End If
        // Next
        // End If
        // If Not vRow("FoodDesc") Is DBNull.Value Then
        // txtModifierDescription.Text = vRow("FoodDesc")
        // '      Else
        // txtModifierDescription.Text = ""
        // End If
        // 
        // '        Exit For
        // End If
        // Next

        // Else
        // txtModifierName.Text = ""
        // txtModifierAbrev.Text = ""
        // txtModifierChit.Text = ""
        // txtModifierCost.Text = "0"
        // txtModifierSurcharge.Text = "0"
        // cbxModifierRouting.SelectedIndex = -1
        // txtModifierDescription.Text = ""

        // End If

        foreach (DataRowView vRow in dvModifiers)    // dsSetup.Tables("Modifiers").Rows
        {
            // If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
            if (!object.ReferenceEquals(vRow("FoodID"), DBNull.Value))
            {
                if (vRow("FoodID") == currentOrderPanel.MenuJoinID)
                {
                    index = counter;
                    break;
                }
            }
            counter += 1;
            // End If
        }

        if (index != -1)
        {
            this.ModifierCurrencyMan.ResumeBinding();
            this.ModifierCurrencyMan.Position = index;
        }
        else
        {
            // Me.pnlNewCategory.Visible = True
            this.ModifierCurrencyMan.SuspendBinding();
        }

        newModifierChangesMade = false; // keep false until info changes
        RecordLastPanel(ref currentOrderPanel);
        this.txtModifierName.Focus();

    }

    private void TestForModifierChanges()
    {

        if (newModifierChangesMade == true)
        {
            if (this.txtModifierName.Text.Length > 0)
            {
                if (this.txtModifierAbrev.Text.Length == 0)
                {
                    this.txtModifierAbrev.Text = this.txtModifierName.Text;
                }
                if (this.txtModifierChit.Text.Length == 0)
                {
                    this.txtModifierChit.Text = this.txtModifierName.Text;
                }
            }
            newModifier.ActiveModifierName = this.txtModifierName.Text;
            newModifier.ActiveAbrevText = this.txtModifierAbrev.Text;

            UpdateDatabaseModifiers();
            UpdateNewModifierPanel();

            newModifierChangesMade = false;
        }

    }

    private void UpdateNewModifierPanel()
    {
        // If newModifier.ActiveModifierID = Nothing Then
        // newModifier.ActiveModifierID = GetMaximumID("FoodID", "Foods")
        // End If
        try
        {
            newModifier.ChangingPanel.MenuJoinID = newModifier.ActiveModifierID; // this is FoodID
            newModifier.ChangingPanel.FoodName = newModifier.ActiveModifierName; // oRow("FoodName")
            newModifier.ChangingPanel.Text = newModifier.ActiveAbrevText; // oRow("FoodName")
            newModifier.ChangingPanel.MenuIndex = newModifier.MenuIndex;
        }

        // SaveNewPanelDisplay()
        // 444     KeepModifierPanelBlank()
        catch (Exception ex)
        {

        }

    }

    private void SaveNewPanelDisplay()
    {
        // ************ does not work

        this.modifierID(newModifier.ChangingPanel.Position) = newModifier.ActiveModifierID;
        this.modifierName(newModifier.ChangingPanel.Position) = newModifier.ActiveModifierName;
        this.modifierIndex(newModifier.ChangingPanel.Position) = newModifier.MenuIndex;


    }

    private void ModifierMouseDown(object sender, MouseEventArgs e)
    {

        TestForModifierChanges();
        // Dim currentOrderPanel As FoodPanelControl
        // currentOrderPanel = CType(sender, FoodPanelControl)
        // 
        // RecordLastPanel(currentOrderPanel)

    }

    private void ModifierMouseMove(object sender, EventArgs e)
    {

        KeepModifierPanelBlank();
        SaveModifierChanges();

    }


    private void RecordLastPanel(ref FoodPanelControl currentOrderPanel)
    {

        newModifier.ActiveModifierID = currentOrderPanel.MenuJoinID;
        newModifier.ActiveModifierName = currentOrderPanel.Name;
        newModifier.ActiveAbrevText = currentOrderPanel.Text;
        newModifier.ChangingPanel = currentOrderPanel;

        if (newModifier.PageIndex == 1)
        {
            newModifier.MenuIndex = currentOrderPanel.Position;
        }
        else
        {
            newModifier.MenuIndex = currentOrderPanel.Position + (newModifier.PageIndex - 1) * 22 + 1;
        }

    }

    private void KeepModifierPanelBlank()
    {

        this.modifierID(newModifier.MenuIndex) = (object)null;
        this.modifierName(newModifier.MenuIndex) = (object)null;
        this.modifierIndex(newModifier.MenuIndex) = (object)null;

    }

    private void ModifierChangesMade(object sender, EventArgs e)
    {

        newModifierChangesMade = true;

    }


    private void btnUpdateModifiers_Click(object sender, EventArgs e)
    {

        // we must update panel first because
        if (newModifierChangesMade == true)
        {
            newModifier.ActiveModifierName = this.txtModifierName.Text;
            newModifier.ActiveAbrevText = this.txtModifierAbrev.Text;
            UpdateNewModifierPanel();
            UpdateDatabaseModifiers();
            newModifierChangesMade = false;
        }
        else
        {

            // this must be outside in order to update moving panels
            SaveModifierChanges();
        }


    }


    private void btnRemoveModifier_Click(object sender, EventArgs e)
    {

        DataRow oRow;

        foreach (DataRow currentORow in dsSetup.Tables("Modifiers").Rows)
        {
            oRow = currentORow;
            if (oRow("FoodID") == newModifier.ActiveModifierID)
            {
                oRow("MenuIndex") = 0;
                break;
            }
        }
        KeepModifierPanelBlank();
        SaveModifierChanges();

        return;
        // below 222

        if (Interaction.MsgBox("Are you sure you want to remove the " + txtModifierName.Text + " Modifier and all its Joins?", MsgBoxStyle.OkCancel) == MsgBoxResult.Ok)
        {
            // Dim oRow As DataRow
            SaveModifierChanges();
            this.ModifierCurrencyMan.SuspendBinding();

            if (newModifier.ActiveModifierID != default)
            {
                foreach (DataRow currentORow1 in dsSetup.Tables("Modifiers").Rows)
                {
                    oRow = currentORow1;   // dvModifiers    '
                    if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                    {
                        if (oRow("FoodID") == newModifier.ActiveModifierID)
                        {
                            break;
                        }
                    }
                }
                // oRow = dsSetup.Tables("Modifiers").Rows.Find(newModifier.ActiveModifierID)
                if (!(oRow.RowState == DataRowState.Deleted))
                {
                    oRow.Delete();
                }

                newModifier.ActiveModifierName = "";
                newModifier.ActiveAbrevText = "";
                // newModifier.MenuIndex = Nothing


                var modifierDeleteCommand = new SqlClient.SqlCommand("DELETE FROM FoodJoin WHERE ModifierID = '" + newModifier.ActiveModifierID + "'", sql.cn);
                try
                {
                    sql.cn.Open();
                    sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
                    modifierDeleteCommand.ExecuteNonQuery();
                    sql.cn.Close();
                }
                catch (Exception ex)
                {
                    CloseConnection();
                }

                newModifier.ActiveModifierID = (object)null;

                UpdateNewModifierPanel();
                SaveModifierChanges();

            }

        }

    }

    private void UpdateDatabaseModifiers()
    {

        DataRow oRow;
        DataRowView vRow;

        if (newModifier.ActiveModifierID == default)
        {
            if (this.txtModifierName.Text.Length == 0)
            {
                // 777  ???            Me.ModifierCurrencyMan.ResumeBinding()
                return;
            }
            else
            {

            }
            // If ErrorProvider1.GetError(Me.txtNewModifierName).Length > 0 Then
            // Exit Sub
            // End If
            // If ErrorProvider1.GetError(Me.txtNewModifierAbrev).Length > 0 Then
            // txtNewModifierAbrev.Text = Me.txtNewModifierName.Text
            // End If
            // ' If ErrorProvider1.GetError(Me.txtNewModifierChit).Length > 0 Then
            // Me.txtNewModifierChit.Text = Me.txtNewModifierAbrev.Text
            // End If

            EnteringNewModifier();
        }
        // Me.pnlNewModifier.Visible = True
        // need to show new modifier panel
        else
        {
            return;    // 444

            foreach (DataRowView currentVRow in dvModifiers)
            {
                vRow = currentVRow;    // dsSetup.Tables("Modifiers").Rows
                // If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
                if (vRow("FoodID") == newModifier.ActiveModifierID)
                    break;
                // End If
            }
            vRow("CompanyID") = corpID;
            vRow("LocationID") = selectedLocation;
            vRow("FoodName") = this.txtModifierName.Text;
            vRow("AbrevFoodName") = this.txtModifierAbrev.Text;
            vRow("ChitFoodName") = this.txtModifierChit.Text;
            vRow("CategoryID") = newModifier.ActiveModifierCategoryID;
            try
            {
                vRow("FoodCost") = (decimal)this.txtModifierCost.Text;
            }
            catch (Exception ex)
            {
                vRow("FoodCost") = 0;
            }

            try
            {
                vRow("Surcharge") = (decimal)this.txtModifierSurcharge.Text;
            }
            catch (Exception ex)
            {
                vRow("Surcharge") = 0;
            }
            vRow("FoodDesc") = this.txtModifierDescription.Text;
            vRow("MenuIndex") = newModifier.MenuIndex;
            try
            {
                if (this.cbxModifierRouting.SelectedIndex == -1)
                {
                    vRow("RoutingID") = DBNull.Value;
                }
                else
                {
                    vRow("RoutingID") = dsSetup.Tables("RoutingChoice").Rows(this.cbxModifierRouting.SelectedIndex)("RoutingID");
                }
            }
            catch (Exception ex)
            {
                vRow("RoutingID") = DBNull.Value;
            }
            vRow("Active") = 1;

        }


        return;

        oRow("CompanyID") = corpID;
        oRow("LocationID") = selectedLocation;
        oRow("FoodName") = this.txtModifierName.Text;
        oRow("AbrevFoodName") = this.txtModifierAbrev.Text;
        oRow("ChitFoodName") = this.txtModifierChit.Text;
        oRow("CategoryID") = newModifier.ActiveModifierCategoryID;
        try
        {
            oRow("FoodCost") = (decimal)this.txtModifierCost.Text;
        }
        catch (Exception ex)
        {
            oRow("FoodCost") = 0;
        }

        try
        {
            oRow("Surcharge") = (decimal)this.txtModifierSurcharge.Text;
        }
        catch (Exception ex)
        {
            oRow("Surcharge") = 0;
        }
        oRow("FoodDesc") = this.txtModifierDescription.Text;
        oRow("MenuIndex") = newModifier.MenuIndex;
        try
        {
            oRow("RoutingID") = dsSetup.Tables("RoutingChoice").Rows(this.cbxModifierRouting.SelectedIndex)("RoutingID");
        }
        catch (Exception ex)
        {
            oRow("RoutingID") = DBNull.Value;
        }

        if (newModifier.ActiveModifierID == default)
        {
            oRow("Active") = 1;
            newModifier.ActiveModifierID = oRow("FoodID");
            dsSetup.Tables("Modifiers").Rows.Add(oRow);
        }
        else
        {
            // 777            ModifierCurrencyMan.Position += 1
            // 777           ModifierCurrencyMan.Position -= 1
        }

        SaveModifierChanges();

    }


    private void SaveModifierChanges()
    {
        DataSet dsChangedData;
        DataRow oRow;

        // cleans up data (needed especially for drag & drop)
        // For Each oRow In dsSetup.Tables("Modifiers").Rows
        // If oRow("AbrevFoodName") = "" Or oRow("AbrevFoodName") = Nothing Then
        // oRow.Delete()
        // End If
        // Next

        sql.cn.Open();
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
        sql.SqlMenuModifiers.Update(dsSetup, "Modifiers");  // or dsSetup
        sql.cn.Close();

        dsSetup.Tables("Modifiers").AcceptChanges();
        newModifierChangesMade = false;

        return;

        if (dsSetup.HasChanges)
        {

            dsChangedData = dsSetup.GetChanges(); // (DataRowState.Modified Or DataRowState.Added)

            if (dsSetup.HasChanges)
            {
                sql.cn.Open();
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
                sql.SqlMenuModifiers.Update(dsChangedData, "Modifiers");  // or dsSetup
                sql.cn.Close();
            }

            dsSetup.AcceptChanges();
            dsChangedData.Clear();
            newModifierChangesMade = false;
            // ClearNewModifier()
        }

    }

    private void ClearNewModifier()
    {
        {
            var withBlock = newModifier;
            withBlock.ChangesMade = false;
            withBlock.ActiveModifierID = (object)null;
            withBlock.ActiveModifierName = (object)null;
            withBlock.ActiveAbrevText = (object)null;
            // .MenuIndex = Nothing            not sure about(we may need)
        }
    }

    private void cbxModifierRouting_SelectedIndexChanged(object sender, EventArgs e)
    {
        int valueCatID;
        string valueCatName;
        DataRowView vRow;

        if (this.cbxModifierRouting.SelectedItem == "Route w/ Food") // dsSetup.Tables("RoutingChoice").Rows.Count Then
        {
            dvModifiers(this.ModifierCurrencyMan.Position)("RoutingID") = DBNull.Value;
            dvModifiers(this.ModifierCurrencyMan.Position)("RoutingName") = DBNull.Value;
            // Me.cbxModifierRouting.SelectedIndex = -1
            this.newModifierChangesMade = true;
        }
        else
        {
            valueCatID = dsSetup.Tables("RoutingChoice").Rows(cbxModifierRouting.SelectedIndex)("RoutingID");
            valueCatName = dsSetup.Tables("RoutingChoice").Rows(cbxModifierRouting.SelectedIndex)("RoutingName");

            if (!(dvModifiers(this.ModifierCurrencyMan.Position)("RoutingID") == valueCatID))
            {
                dvModifiers(this.ModifierCurrencyMan.Position)("RoutingID") = valueCatID;
                dvModifiers(this.ModifierCurrencyMan.Position)("RoutingName") = valueCatName;
            }

        }

        // dsSetup.Tables("Modifiers").Rows(Me.ModifierCurrencyMan.Position)("RoutingID") = valueCatID
        // dsSetup.Tables("Modifiers").Rows(Me.ModifierCurrencyMan.Position)("RoutingName") = valueCatName

    }

    private void btnModifierAddPage_Click(object sender, EventArgs e)
    {
        // this is so we don't create another page unless this one has info

        if (newModifier.PageIndex * 24 - 24 > newModifier.MaxIndex)
            return;

        // this should be +1 or +2  ??????
        if (this.modifierOrderPanel24.foodPanel.MenuJoinID > 0)
        {
            foreach (DataRow oRow in dsSetup.Tables("Modifiers").Rows)
            {
                if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                {
                    if (oRow("FoodID") == this.modifierOrderPanel24.foodPanel.MenuJoinID)
                    {
                        oRow("MenuIndex") = oRow("MenuIndex") + 2;
                        this.modifierIndex(oRow("MenuIndex")) = oRow("MenuIndex");
                        this.modifierID(oRow("MenuIndex")) = oRow("FoodID");
                        this.modifierName(oRow("MenuIndex")) = oRow("FoodName");
                        break;
                    }
                }
            }
        }


        newModifier.MaxIndex += 24;
        // UpdateOrderModifiers()
        // newModifierChangesMade = True
        SaveModifierChanges();

        // this means we are on the last page so we increase the dimension
        if (newModifier.PageIndex * 24 > newModifier.MaxIndex)
        {
            ;
#error Cannot convert ReDimStatementSyntax - see comment for details
            /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
               at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
               at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
               at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
               at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

            Input:
                        '   this means we are on the last page so we increase the dimension
                        ReDim modifierID((newModifier.PageIndex * 24) + 24)

             */
            ;
#error Cannot convert ReDimStatementSyntax - see comment for details
            /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
               at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
               at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
               at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
               at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

            Input:
                        ReDim modifierName((newModifier.PageIndex * 24) + 24)

             */
            ;
#error Cannot convert ReDimStatementSyntax - see comment for details
            /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
                           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
                           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
                           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
                           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
                           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
                           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
                           at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
                           at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

                        Input:
                                    ReDim modifierIndex((newModifier.PageIndex * 24) + 24)

                         */
            PopulateModifierDataFromTable();
        }
        newModifier.PageIndex += 1;

        DisplayModifierPage(newModifier.PageIndex);

    }

    private void btnModifierRemovePage_Click(object sender, EventArgs e)
    {

        foreach (DataRow oRow in dsSetup.Tables("Modifiers").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                if (oRow("MenuIndex") > (newModifier.PageIndex - 1) * 24)
                {
                    Interaction.MsgBox("You can not Remove a Page until all Modifiers are located on Previous Pages or Staging.");
                    return;
                }
            }
        }
        newModifier.PageIndex -= 1;

        // newModifier.MaxIndex = dsSetup.Tables("Modifiers").Compute("Max(MenuIndex)", "")

        DisplayModifierPage(newModifier.PageIndex);

    }

    private void txtAbrevModifierName_Enter(object sender, EventArgs e)
    {
        if (txtModifierAbrev.Text.Length == 0)
        {
            txtModifierAbrev.Text = this.txtModifierName.Text;
        }
    }

    private void txtChitModifierName_Enter(object sender, EventArgs e)
    {
        if (txtModifierChit.Text.Length == 0)
        {
            txtModifierChit.Text = this.txtModifierName.Text;
        }
    }

    // new modifiers
    private void txtNewAbrevModifierName_Enter(object sender, EventArgs e)
    {
        if (txtNewModifierAbrev.Text.Length == 0)
        {
            txtNewModifierAbrev.Text = this.txtNewModifierName.Text;
        }
    }

    private void txtNewChitModifierName_Enter(object sender, EventArgs e)
    {
        if (txtNewModifierChit.Text.Length == 0)
        {
            txtNewModifierChit.Text = this.txtNewModifierName.Text;
        }
    }

    private void txtNewModifierName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        ValidateString(ref this.txtNewModifierName);
    }

    private void txtNewModifierAbrev_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        ValidateString(ref this.txtNewModifierAbrev);
    }

    private void txtNewModifierChit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        ValidateString(ref this.txtNewModifierChit);
    }

    private void txtNewModifierDescription_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        ValidateStringAcceptBlanks(ref this.txtNewModifierDescription);
    }

    private void btnAcceptModifier_Click(object sender, EventArgs e)
    {
        if (ErrorProvider1.GetError(this.txtNewModifierName).Length > 0)
        {
            return;
        }
        if (ErrorProvider1.GetError(this.txtNewModifierAbrev).Length > 0)
        {
            txtNewModifierAbrev.Text = this.txtNewModifierName.Text;
        }
        if (ErrorProvider1.GetError(this.txtNewModifierChit).Length > 0)
        {
            this.txtNewModifierChit.Text = this.txtNewModifierAbrev.Text;
        }

        EnteringNewModifier();
        ResetNewModifier();
        this.pnlNewModifier.Visible = false;

    }

    private void EnteringNewModifier()
    {
        // 666   ***********************
        // trying something new
        // we will only enter new modifier under Foods
        // ******************************

        DataRow oRow;
        int newFoodId;

        oRow = dsSetup.Tables("Modifiers").NewRow;

        oRow("CompanyID") = corpID;
        oRow("LocationID") = selectedLocation;
        oRow("FoodName") = this.txtModifierName.Text; // "   ** Empty Food **"
        oRow("AbrevFoodName") = this.txtModifierAbrev.Text; // ""
        oRow("ChitFoodName") = this.txtModifierChit.Text; // ""
        oRow("FoodDesc") = this.txtModifierDescription.Text;
        oRow("CategoryID") = newModifier.ActiveModifierCategoryID;

        try
        {
            oRow("FoodCost") = (decimal)this.txtModifierCost.Text;
        }
        catch (Exception ex)
        {
            oRow("FoodCost") = 0;
        }

        try
        {
            oRow("Surcharge") = (decimal)this.txtModifierSurcharge.Text;
        }
        catch (Exception ex)
        {
            oRow("Surcharge") = 0;
        }
        oRow("InvMultiplier") = 1;
        oRow("FoodDesc") = this.txtModifierDescription.Text;
        oRow("MenuIndex") = newModifier.MenuIndex;
        if (this.cbxModifierRouting.SelectedIndex == -1)
        {
            oRow("RoutingID") = DBNull.Value;
        }
        else
        {
            oRow("RoutingID") = dsSetup.Tables("RoutingChoice").Rows(this.cbxModifierRouting.SelectedIndex)("RoutingID");
        }
        oRow("Active") = 1;

        dsSetup.Tables("Modifiers").Rows.Add(oRow);

        oRow("FoodID") = InsertingNewModifier(ref oRow);

        newModifier.ActiveModifierID = oRow("FoodID");
        UpdateNewModifierPanel();

        dsSetup.Tables("Modifiers").AcceptChanges();

        // ???        UpdateModifierPanel(oRow)

        // 666
        // UpdateMenuJoin()

    }
    private object InsertingNewModifier(ref DataRow orow)
    {
        var newFoodID = default(int);

        sql.SqlInsertCommandModifiers.Parameters("@CompanyID").Value = orow("CompanyID");
        sql.SqlInsertCommandModifiers.Parameters("@LocationID").Value = orow("LocationID");
        sql.SqlInsertCommandModifiers.Parameters("@FoodName").Value = orow("FoodName");
        sql.SqlInsertCommandModifiers.Parameters("@AbrevFoodName").Value = orow("AbrevFoodName");
        sql.SqlInsertCommandModifiers.Parameters("@ChitFoodName").Value = orow("ChitFoodName");
        sql.SqlInsertCommandModifiers.Parameters("@CategoryID").Value = orow("CategoryID");
        sql.SqlInsertCommandModifiers.Parameters("@FoodCost").Value = orow("FoodCost");
        // sql.SqlInsertCommandModifiers.Parameters("@TaxID").Value = DBNull.Value 'this is not used
        sql.SqlInsertCommandModifiers.Parameters("@FoodDesc").Value = orow("FoodDesc");
        sql.SqlInsertCommandModifiers.Parameters("@Surcharge").Value = orow("Surcharge");
        sql.SqlInsertCommandModifiers.Parameters("@RoutingID").Value = orow("RoutingID");
        sql.SqlInsertCommandModifiers.Parameters("@Active").Value = 1;
        sql.SqlInsertCommandModifiers.Parameters("@MenuIndex").Value = orow("MenuIndex");
        sql.SqlInsertCommandModifiers.Parameters("@InvMultiplier").Value = orow("InvMultiplier");

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            newFoodID = (int)sql.SqlInsertCommandModifiers.ExecuteScalar();
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        return newFoodID;

    }

    private void UpdateModifierPanel222(ref DataRow oRow)
    {
        int mi;

        mi = (newModifier.PageIndex - 1) * 24 + newModifier.MenuIndex;
        this.modifierID(newModifier.MenuIndex) = oRow("FoodID");
        this.modifierName(newModifier.MenuIndex) = oRow("FoodName");
        this.modifierIndex(newModifier.MenuIndex) = oRow("MenuIndex");
        DisplayOrderModifiers(newModifier.MenuIndex, mi, modifierID(newModifier.MenuIndex), modifierName(newModifier.MenuIndex), default, default, default, default, default, default);

    }

    private void btnCancelModifier_Click(object sender, EventArgs e)
    {
        ResetNewModifier();
        this.pnlNewModifier.Visible = false;

    }

    private void ResetNewModifier()
    {

        this.txtNewModifierName.Text = "";
        this.txtNewModifierAbrev.Text = "";
        this.txtNewModifierChit.Text = "";
        this.txtNewModifierSurcharge.Text = "0";
        this.cbxNewModifierRouting.SelectedIndex = -1;
        this.txtNewModifierCost.Text = "0";
        this.txtNewModifierDescription.Text = "";

    }


    // ************************************************************************************
    // Food Joins
    // ************************************************************************************

    private void DisplayFoodJoinGrids()
    {


        // ***************************
        // Join Food Choice
        var tsJoinFoodChoice = new DataGridTableStyle();
        tsJoinFoodChoice.MappingName = "FoodTable";
        tsJoinFoodChoice.RowHeadersVisible = false;
        tsJoinFoodChoice.GridLineColor = Color.White;

        var csJoinFoodID = new DataGridTextBoxColumn();
        csJoinFoodID.MappingName = "FoodID";
        csJoinFoodID.Width = 0;

        var csJoinFoodName = new DataGridTextBoxColumn();
        csJoinFoodName.MappingName = "FoodName";
        csJoinFoodName.Width = this.grdJoinFoodChoice.Width * 0.85d;

        tsJoinFoodChoice.GridColumnStyles.Add(csJoinFoodID);
        tsJoinFoodChoice.GridColumnStyles.Add(csJoinFoodName);
        grdJoinFoodChoice.TableStyles.Add(tsJoinFoodChoice);

        // ***************************
        // Join Food Category Joins
        var tsJoinFoodCategoryJoins = new DataGridTableStyle();
        tsJoinFoodCategoryJoins.MappingName = "JoinFoodCategoryJoins";
        tsJoinFoodCategoryJoins.RowHeadersVisible = false;
        tsJoinFoodCategoryJoins.GridLineColor = Color.White;

        var csJoinFoodJoinID = new DataGridTextBoxColumn();
        csJoinFoodJoinID.MappingName = "FoodJoinID";
        csJoinFoodJoinID.Width = 0;

        var csJoinFoodJoinCategoryName = new DataGridTextBoxColumn();
        csJoinFoodJoinCategoryName.MappingName = "CategoryName";
        // csJoinFoodJoinCategoryName.ReadOnly = True
        csJoinFoodJoinCategoryName.Width = this.grdJoinFoodCategoryJoins.Width * 0.65d;
        csJoinFoodJoinCategoryName.NullText = "";

        // Dim csJoinFoodCost As New DataGridTextBoxColumn 'BoolColumn
        // csJoinFoodCost.MappingName = "NumberFree"
        // csJoinFoodCost.Width = Me.grdJoinFoodCategoryJoins.Width * 0.2

        var csJoinFoodFree = new DataGridTextBoxColumn(); // BoolColumn
        csJoinFoodFree.MappingName = "FreeFlag";
        csJoinFoodFree.Width = this.grdJoinFoodCategoryJoins.Width * 0.1d;
        csJoinFoodFree.NullText = "";

        var csJoinGTC = new DataGridTextBoxColumn(); // BoolColumn
        csJoinGTC.MappingName = "GTCFlag";
        csJoinGTC.Width = this.grdJoinFoodCategoryJoins.Width * 0.1d;
        csJoinGTC.NullText = "";

        var csJoinFoodReq = new DataGridTextBoxColumn(); // BoolColumn
        csJoinFoodReq.MappingName = "ReqFlag";
        csJoinFoodReq.Width = this.grdJoinFoodCategoryJoins.Width * 0.1d;
        csJoinFoodReq.NullText = "";

        tsJoinFoodCategoryJoins.GridColumnStyles.Add(csJoinFoodJoinID);
        tsJoinFoodCategoryJoins.GridColumnStyles.Add(csJoinFoodJoinCategoryName);
        tsJoinFoodCategoryJoins.GridColumnStyles.Add(csJoinFoodFree);
        tsJoinFoodCategoryJoins.GridColumnStyles.Add(csJoinGTC);
        tsJoinFoodCategoryJoins.GridColumnStyles.Add(csJoinFoodReq);

        grdJoinFoodCategoryJoins.TableStyles.Add(tsJoinFoodCategoryJoins);

        // ***************************
        // Join Food Modifier Joins
        var tsJoinFoodModifierJoins = new DataGridTableStyle();
        tsJoinFoodModifierJoins.MappingName = "JoinFoodModifierJoins";
        tsJoinFoodModifierJoins.RowHeadersVisible = false;
        tsJoinFoodModifierJoins.GridLineColor = Color.White;

        var csJoinFoodJoinModifierID = new DataGridTextBoxColumn();
        csJoinFoodJoinModifierID.MappingName = "FoodJoinID";
        csJoinFoodJoinModifierID.Width = 0;

        var csJoinFoodJoinModifierName = new DataGridTextBoxColumn();
        csJoinFoodJoinModifierName.MappingName = "FoodName";
        // csJoinFoodJoinModifierName.ReadOnly = True
        csJoinFoodJoinModifierName.Width = this.grdJoinFoodModifierJoins.Width * 0.75d;
        csJoinFoodJoinModifierName.NullText = "";

        // Dim csJoinFoodJoinModifierCost As New DataGridTextBoxColumn 'BoolColumn
        // csJoinFoodJoinModifierCost.MappingName = "NumberFree"
        // csJoinFoodJoinModifierCost.Width = Me.grdJoinFoodModifierJoins.Width * 0.2

        var csJoinFoodJoinModifierFree = new DataGridTextBoxColumn(); // BoolColumn
        csJoinFoodJoinModifierFree.MappingName = "FreeFlag";
        csJoinFoodJoinModifierFree.Width = this.grdJoinFoodModifierJoins.Width * 0.1d;
        csJoinFoodJoinModifierFree.NullText = "";

        var csJoinFoodJoinModifierGroup = new DataGridTextBoxColumn(); // BoolColumn
        csJoinFoodJoinModifierGroup.MappingName = "GroupFlag";
        csJoinFoodJoinModifierGroup.Width = this.grdJoinFoodModifierJoins.Width * 0.1d;
        csJoinFoodJoinModifierGroup.NullText = "";

        // Dim csJoinFoodJoinModifierReq As New DataGridTextBoxColumn 'BoolColumn
        // csJoinFoodJoinModifierReq.MappingName = "ReqFlag"
        // csJoinFoodJoinModifierReq.Width = Me.grdJoinFoodModifierJoins.Width * 0.1
        // csJoinFoodJoinModifierReq.NullText = ""

        tsJoinFoodModifierJoins.GridColumnStyles.Add(csJoinFoodJoinModifierID);
        tsJoinFoodModifierJoins.GridColumnStyles.Add(csJoinFoodJoinModifierName);
        tsJoinFoodModifierJoins.GridColumnStyles.Add(csJoinFoodJoinModifierFree);
        tsJoinFoodModifierJoins.GridColumnStyles.Add(csJoinFoodJoinModifierGroup);
        // tsJoinFoodModifierJoins.GridColumnStyles.Add(csJoinFoodJoinModifierReq)
        grdJoinFoodModifierJoins.TableStyles.Add(tsJoinFoodModifierJoins);

        // dsSetup.Tables("JoinFoodCategoryJoins").Clear()
        // dsSetup.Tables("JoinFoodModifierJoins").Clear()


        // ************************
        // Join Possible Categories
        var tsJoinPossibleCategories = new DataGridTableStyle();
        tsJoinPossibleCategories.MappingName = "MainCategory"; // "Main_ModifierCategory2"
        tsJoinPossibleCategories.RowHeadersVisible = false;
        tsJoinPossibleCategories.GridLineColor = Color.White;

        var csJoinCategoryID = new DataGridTextBoxColumn();
        csJoinCategoryID.MappingName = "CategoryID";
        csJoinCategoryID.Width = 0;

        var csJoinCategoryName = new DataGridTextBoxColumn();
        csJoinCategoryName.MappingName = "CategoryName";
        csJoinCategoryName.Width = this.grdJoinPossibleCategories.Width * 0.85d;

        tsJoinPossibleCategories.GridColumnStyles.Add(csJoinCategoryID);
        tsJoinPossibleCategories.GridColumnStyles.Add(csJoinCategoryName);
        grdJoinPossibleCategories.TableStyles.Add(tsJoinPossibleCategories);


        // *************************
        // Join Individual Modifiers
        // Dim tsJoinIndividualModifiers As New DataGridTableStyle
        tsJoinIndividualModifiers.MappingName = "Modifiers"; // "Modifiers2"
        tsJoinIndividualModifiers.RowHeadersVisible = false;
        tsJoinIndividualModifiers.GridLineColor = Color.White;

        var csJoinModifierID = new DataGridTextBoxColumn();
        csJoinModifierID.MappingName = "FoodID";
        csJoinModifierID.Width = 0;

        var csJoinModifierName = new DataGridTextBoxColumn();
        csJoinModifierName.MappingName = "FoodName";
        csJoinModifierName.Width = this.grdJoinIndividualModifiers.Width * 0.85d;

        tsJoinIndividualModifiers.GridColumnStyles.Add(csJoinModifierID);
        tsJoinIndividualModifiers.GridColumnStyles.Add(csJoinModifierName);
        grdJoinIndividualModifiers.TableStyles.Add(tsJoinIndividualModifiers);

    }

    private void cbxJoinCategorySelect_SelectedIndexChanged(object sender, EventArgs e)
    {
        int valueCatID;

        valueCatID = dvFoodJoinMainFoodsCagtegory(cbxJoinCategorySelect.SelectedIndex)("CategoryID");
        globalJoinValueCategoryID = valueCatID;

        // With dvFoods
        // .Table = dsSetup.Tables("FoodTable")
        // .RowFilter = "CategoryID = " & valueCatID
        // End With

        {
            var withBlock = dvFoodsJoins;
            withBlock.Table = dsSetup.Tables("FoodTable");
            withBlock.RowFilter = "CategoryID = " + valueCatID;
        }

        // this is if we only have one food in category
        if (dsSetup.Tables("FoodTable").Rows.Count == 1)
        {
            PopulateFoodJoinData(ref this.grdJoinFoodChoice);
            // this resets out choices
            GridFoodJoinJustClicked();
        }






        // :    dsSetup.Tables("FoodTable").Clear()

        // sql.SqlSelectCommandMenuFoods.Parameters("@CompanyID").Value = corpID
        // sql.SqlSelectCommandMenuFoods.Parameters("@LocationID").Value = selectedLocation
        // sql.SqlSelectCommandMenuFoods.Parameters("@CategoryID").Value = valueCatID

        // Try
        // sql.cn.Open()
        // sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        // sql.SqlMenuFoods.Fill(dsSetup.Tables("FoodTable"))
        // sql.cn.Close()
        // Catch ex As Exception
        // '       CloseConnection()
        // End Try




    }

    private void cbxJoinIndividualModifierSelect_SelectedIndexChanged(object sender, EventArgs e)
    {
        int valueCatID;
        string valueFunFlag;
        // valueCatID = dsSetup.Tables("Main_ModifierCategory2").Rows(cbxJoinIndividualModifierSelect.SelectedIndex)("CategoryID")
        // valueFunFlag = dsSetup.Tables("Main_ModifierCategory2").Rows(cbxJoinIndividualModifierSelect.SelectedIndex)("FunctionFlag")
        valueCatID = dvFoodJoinCategory(cbxJoinIndividualModifierSelect.SelectedIndex)("CategoryID");
        valueFunFlag = dvFoodJoinCategory(cbxJoinIndividualModifierSelect.SelectedIndex)("FunctionFlag");

        // Dim tempCommandString As String
        // sql.SqlSelectCommandModifiers.Parameters("@CompanyID").Value = corpID
        // sql.SqlSelectCommandModifiers.Parameters("@LocationID").Value = selectedLocation

        if (valueFunFlag == "M") // valueCatID > 100 Then
        {
            tsJoinIndividualModifiers.MappingName = "Modifiers";
            {
                var withBlock = dvModifiers2;
                withBlock.Table = dsSetup.Tables("Modifiers");
                withBlock.RowFilter = "CategoryID = '" + valueCatID + "'";
                withBlock.Sort = "CategoryID, FoodName";
            }
        }

        // tempCommandString = sql.SqlSelectCommandModifiers.CommandText()
        // dsSetup.Tables("Modifiers2").Clear()
        // sql.SqlSelectCommandModifiers.CommandText = sql.SqlSelectCommandModifiers.CommandText & " AND Foods.CategoryID = '" & valueCatID & "'"
        // sql.cn.Open()
        // sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        // '        sql.SqlMenuModifiers.Fill(dsSetup.Tables("Modifiers2"))
        // sql.cn.Close()
        // sql.SqlSelectCommandModifiers.CommandText = tempCommandString
        else
        {
            tsJoinIndividualModifiers.MappingName = "FoodTable";
            {
                var withBlock1 = dvModifiers2;
                withBlock1.Table = dsSetup.Tables("FoodTable");
                withBlock1.RowFilter = "CategoryID = '" + valueCatID + "'"; // AND FunctionFlag = 'O'"
                withBlock1.Sort = "CategoryID, FoodName";
            }

            // changed below .. probably need to change above for consistency 
            // dsSetup.Tables("Modifiers2").Clear()
            // sql.SqlSelectCommandMenuFoods.Parameters("@CategoryID").Value = valueCatID
            // sql.cn.Open()
            // '              sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            // sql.SqlMenuFoods.Fill(dsSetup.Tables("Modifiers2"))
            // sql.cn.Close()
        }

    }

    private void grdJoinFoodChoice_Clicked(object sender, EventArgs e)
    {

        GridFoodJoinJustClicked();

    }

    private void GridFoodJoinJustClicked()
    {


        if (updatedFoodJoin == true)
        {
            UpdateDatabaseFoodJoin();
        }

        PopulateFoodJoinData(ref this.grdJoinFoodChoice);

        newFoodJoin.ActiveCategoryRow = -1;
        newFoodJoin.ActiveModifierRow = -1;


        // Me.grdJoinPossibleCategories.CurrentRowIndex = Nothing
        // Me.grdJoinIndividualModifiers.CurrentRowIndex = Nothing

        // '    grdJoinFoodModifierJoins.CurrentRowIndex = 0
        // Me.grdJoinFoodCategoryJoins.CurrentRowIndex = -1
        // Me.grdJoinFoodModifierJoins.CurrentRowIndex = -1

        // grdJoinFoodCategoryJoins.Focus()
        // grdJoinFoodModifierJoins.Focus()

        // Me.grdJoinFoodChoice.Focus()

    }

    private void PopulateFoodJoinData(ref DataGrid grd)
    {
        int rowNum = grd.CurrentCell.RowNumber;

        // If dvFoods.Count = 0 Then Exit Sub
        if (dvFoodsJoins.Count == 0)
            return;

        if (object.ReferenceEquals(grd.Item(rowNum, 0), DBNull.Value))
            return;

        int valueFoodID;
        string valueFoodName;

        valueFoodID = DetermineID(grd, 0);
        valueFoodName = DetermineString(grd, 1);

        newFoodJoin.ActiveJoinFoodID = valueFoodID;
        lblJoinFoodSelected.Text = valueFoodName;

        dsSetup.Tables("FoodJoin").Clear();

        sql.SqlSelectCommandJoinFoodJoin.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandJoinFoodJoin.Parameters("@LocationID").Value = selectedLocation;
        sql.SqlSelectCommandJoinFoodJoin.Parameters("@FoodID").Value = newFoodJoin.ActiveJoinFoodID;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlJoinFoodJoin.Fill(dsSetup.Tables("FoodJoin"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
            Interaction.MsgBox(ex.Message);
        }

        PopulateMinorJoins(valueFoodID);

        if (dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count == 0)
        {
            newFoodJoin.ActiveCategoryRow = -1;
        }
        else
        {
            // newFoodJoin.ActiveCategoryRow = 0
        }
        if (dsSetup.Tables("JoinFoodModifierJoins").Rows.Count == 0)
        {
            newFoodJoin.ActiveModifierRow = -1;
        }
        else
        {
            // newFoodJoin.ActiveModifierRow = 0
        }


        return;
        // 222


        string sqlstatement;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sqlstatement = "SELECT FoodJoin.FoodJoinID, FoodJoin.FoodID, FoodJoin.CategoryID, FoodJoin.NumberFree, FoodJoin.FreeFlag, FoodJoin.GroupFlag, FoodJoin.GTCFlag, Category.CategoryName FROM FoodJoin LEFT OUTER JOIN Category ON FoodJoin.CategoryID = Category.CategoryID WHERE FoodJoin.CompanyID = '" + corpID + "' AND FoodJoin.LocationID = '" + selectedLocation + "' AND FoodJoin.FoodID ='" + valueFoodID + "' AND FoodJoin.CategoryID <> 0";
            dsSetup = sql.PopulateSelectedItemTable("JoinFoodCategoryJoins", sqlstatement, dsSetup);

            sqlstatement = "SELECT FoodJoin.FoodJoinID, FoodJoin.FoodID, FoodJoin.NumberFree, FoodJoin.FreeFlag, FoodJoin.GroupFlag, FoodJoin.ModifierID, Foods.FoodID, Foods.CategoryID, Foods.FoodName FROM FoodJoin LEFT OUTER JOIN Foods ON FoodJoin.ModifierID = Foods.FoodID WHERE FoodJoin.CompanyID = '" + corpID + "' AND FoodJoin.LocationID = '" + selectedLocation + "' AND FoodJoin.FoodID ='" + valueFoodID + "' AND FoodJoin.ModifierID <> 0";
            dsSetup = sql.PopulateSelectedItemTable("JoinFoodModifierJoins", sqlstatement, dsSetup);

            // Dim sqlstatement As String
            dsSetup.Tables("FoodJoin").Clear();
            // add this if updating foodjoin gets too expensive
            // and we must update every time we hit a new food choice
            sqlstatement = "SELECT CompanyID, LocationID, FoodJoinID, FoodID, CategoryID, ModifierID, NumberFree, FreeFlag, GroupFlag, GTCFlag FROM FoodJoin WHERE CompanyID = '" + corpID + "' AND LocationID = '" + selectedLocation + "' AND FoodID = '" + newFoodJoin.ActiveJoinFoodID + "'";
            dsSetup = sql.PopulateSelectedItemTable("FoodJoin", sqlstatement, dsSetup);

            sql.cn.Close();
        }

        catch (Exception ex)
        {
            CloseConnection();
        }



        if (dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count == 0)
        {
            newFoodJoin.ActiveCategoryRow = -1;
        }
        if (dsSetup.Tables("JoinFoodModifierJoins").Rows.Count == 0)
        {
            newFoodJoin.ActiveModifierRow = -1;
        }


    }

    private void PopulateMinorJoins(int valueFoodID)
    {

        dsSetup.Tables("JoinFoodCategoryJoins").Clear();
        dsSetup.Tables("JoinFoodModifierJoins").Clear();

        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@LocationID").Value = selectedLocation;
        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@FoodID").Value = valueFoodID;

        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@LocationID").Value = selectedLocation;
        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@FoodID").Value = valueFoodID;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlJoinFoodCategoryJoins.Fill(dsSetup.Tables("JoinFoodCategoryJoins"));
            sql.SqlJoinFoodModiferJoins.Fill(dsSetup.Tables("JoinFoodModifierJoins"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
            Interaction.MsgBox(ex.Message);
        }

        if (dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count == 0)
        {
            newFoodJoin.ActiveCategoryRow = -1;
        }
        if (dsSetup.Tables("JoinFoodModifierJoins").Rows.Count == 0)
        {
            newFoodJoin.ActiveModifierRow = -1;
        }

    }

    private void grdJoinFoodCategoryJoins_Click(object sender, Global.System.Windows.Forms.MouseEventArgs e)
    {

        if (dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count == 0)
        {
            newFoodJoin.ActiveCategoryRow = -1;
        }
        else
        {
            newFoodJoin.ActiveCategoryRow = this.grdJoinFoodCategoryJoins.CurrentRowIndex;
        }
        newFoodJoin.ActiveModifierRow = -1;

        // currentJoinCategoryRow = Me.grdJoinFoodCategoryJoins.CurrentRowIndex
        // currentJoinModifierRow = -1
    }

    private void grdJoinFoodModifierJoins_Click(object sender, Global.System.Windows.Forms.MouseEventArgs e)
    {



        if (dsSetup.Tables("JoinFoodModifierJoins").Rows.Count == 0)
        {
            newFoodJoin.ActiveModifierRow = -1;
        }
        else
        {
            newFoodJoin.ActiveModifierRow = this.grdJoinFoodModifierJoins.CurrentRowIndex;
        }
        newFoodJoin.ActiveCategoryRow = -1;

        // currentJoinModifierRow = Me.grdJoinFoodModifierJoins.CurrentRowIndex
        // currentJoinCategoryRow = -1
    }

    private void btnJoinGTC_Click(object sender, EventArgs e)
    {
        // these tell us row number
        var modifierIndex = default(int);
        var categoryIndex = default(int);

        foreach (DataRow oRow in dsSetup.Tables("FoodJoin").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                if (object.ReferenceEquals(oRow("CategoryID"), DBNull.Value))
                {
                    modifierIndex += 1;
                }
                else
                {
                    // If currentJoinCategoryRow = categoryIndex Then
                    if (newFoodJoin.ActiveCategoryRow == categoryIndex)
                    {
                        if (this.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 3) == "-")
                        {
                            this.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 3) = "C";
                        }
                        else
                        {
                            this.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 3) = "-";
                        }
                        oRow("GTCFlag") = this.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 3);
                        // oRow("NumberFree") = Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 2)
                    }
                    categoryIndex += 1;
                }
            }
        }

        // UpdateDatabaseFoodJoin()
        updatedFoodJoin = true;


    }

    private void btnJoinReq_Click(object sender, EventArgs e)
    {
        // these tell us row number
        // Dim modifierIndex As Integer
        var categoryIndex = default(int);

        foreach (DataRow oRow in dsSetup.Tables("FoodJoin").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                // not using now.... this means only requiring FULL categories
                // If oRow("CategoryID") Is DBNull.Value Then
                // If newFoodJoin.ActiveModifierRow = modifierIndex Then
                // If Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 4) = "-" Then
                // Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 4) = "R"
                // Else
                // Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 4) = "-"
                // End If
                // oRow("ReqFlag") = Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 4)

                // End If
                // modifierIndex += 1
                // End If

                if (object.ReferenceEquals(oRow("ModifierID"), DBNull.Value))
                {
                    // If currentJoinCategoryRow = categoryIndex Then
                    if (newFoodJoin.ActiveCategoryRow == categoryIndex)
                    {
                        if (this.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 4) == "-")
                        {
                            this.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 4) = "R";
                        }
                        else
                        {
                            this.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 4) = "-";
                        }
                        oRow("ReqFlag") = this.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 4);
                        // oRow("NumberFree") = Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 2)
                    }
                    categoryIndex += 1;
                }
            }
        }

        // UpdateDatabaseFoodJoin()
        updatedFoodJoin = true;


    }

    private void btnJoinFree_Click(object sender, EventArgs e)
    {
        // these tell us row number
        var modifierIndex = default(int);
        var categoryIndex = default(int);

        foreach (DataRow oRow in dsSetup.Tables("FoodJoin").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                if (object.ReferenceEquals(oRow("CategoryID"), DBNull.Value))
                {
                    // If currentJoinModifierRow = modifierIndex Then
                    if (newFoodJoin.ActiveModifierRow == modifierIndex)
                    {
                        if (this.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 2) == "F")
                        {
                            this.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 2) = "S";
                        }
                        else
                        {
                            this.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 2) = "F";
                        }
                        oRow("FreeFlag") = this.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 2);
                        // oRow("NumberFree") = Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 2)
                    }
                    modifierIndex += 1;
                }

                if (object.ReferenceEquals(oRow("ModifierID"), DBNull.Value))
                {
                    // If currentJoinCategoryRow = categoryIndex Then
                    if (newFoodJoin.ActiveCategoryRow == categoryIndex)
                    {
                        if (this.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 2) == "F")
                        {
                            this.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 2) = "S";
                        }
                        else
                        {
                            this.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 2) = "F";
                        }
                        oRow("FreeFlag") = this.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 2);
                        // oRow("NumberFree") = Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 2)
                    }
                    categoryIndex += 1;
                }
            }
        }

        // UpdateDatabaseFoodJoin()
        updatedFoodJoin = true;

    }

    private void btnJoinGroup_Click(object sender, EventArgs e)
    {
        // these tell us row number
        var modifierIndex = default(int);
        // Dim categoryIndex As Integer

        foreach (DataRow oRow in dsSetup.Tables("FoodJoin").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                if (object.ReferenceEquals(oRow("CategoryID"), DBNull.Value))
                {
                    // If currentJoinModifierRow = modifierIndex Then
                    if (newFoodJoin.ActiveModifierRow == modifierIndex)
                    {
                        if (this.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 3) == "A")
                        {
                            this.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 3) = "G";
                        }
                        else
                        {
                            this.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 3) = "A";
                        }
                        oRow("GroupFlag") = this.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 3);
                        // oRow("NumberFree") = Me.grdJoinFoodModifierJoins(newFoodJoin.ActiveModifierRow, 2)
                    }
                    modifierIndex += 1;
                }

                // we don't use this for Category
                // If oRow("ModifierID") Is DBNull.Value Then
                // ' If currentJoinCategoryRow = categoryIndex Then
                // If newFoodJoin.ActiveCategoryRow = categoryIndex Then
                // If Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 3) = "A" Then
                // Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 3) = "G"
                // Else
                // Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 3) = "A"
                // '       End If
                // oRow("GroupFlag") = Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 3)
                // '     oRow("NumberFree") = Me.grdJoinFoodCategoryJoins(newFoodJoin.ActiveCategoryRow, 2)
                // '       End If
                // categoryIndex += 1
                // End If
            }
        }

        // UpdateDatabaseFoodJoin()
        updatedFoodJoin = true;


    }



    private void grdJoinPossibleCategories_Clicked(object sender, Global.System.Windows.Forms.MouseEventArgs e)
    {
        if (newFoodJoin.ActiveJoinFoodID == default)
        {
            Interaction.MsgBox("Please Select A Food Item");
            return;
        }

        int valueCatID;
        string valueCatName;
        DataRow nRow;
        // first determine which categoryID is selected
        valueCatID = DetermineID(grdJoinPossibleCategories, 0);
        valueCatName = DetermineString(grdJoinPossibleCategories, 1);

        UpdateDatabaseFoodJoin();

        nRow = dsSetup.Tables("FoodJoin").NewRow;
        nRow("CompanyID") = corpID;
        nRow("LocationID") = selectedLocation;
        nRow("FoodID") = newFoodJoin.ActiveJoinFoodID;
        nRow("CategoryID") = valueCatID;
        nRow("ModifierID") = DBNull.Value;
        nRow("NumberFree") = 1;          // default
        nRow("FreeFlag") = "S";
        nRow("GroupFlag") = "G"; // will always be grouped
        nRow("GTCFlag") = "-";
        nRow("ReqFlag") = "-";
        // nRow("TempFoodJoinIndex") = newFoodJoin.ActiveTempIndex
        dsSetup.Tables("FoodJoin").Rows.Add(nRow);
        newFoodJoin.ActiveCategoryRow = dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count;
        newFoodJoin.ActiveModifierRow = -1;

        nRow("FoodJoinID") = InsertingNewFoodJoin(ref nRow);
        dsSetup.Tables("FoodJoin").AcceptChanges();

        PopulateMinorJoins(newFoodJoin.ActiveJoinFoodID);    // valueFoodID)
        this.grdJoinFoodCategoryJoins.Focus();
        updatedFoodJoin = true;

        return;





        newFoodJoin.ActiveCategoryRow = dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count;
        newFoodJoin.ActiveModifierRow = -1;
        // currentJoinCategoryRow = dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count
        // currentJoinModifierRow = -1

        nRow = dsSetup.Tables("JoinFoodCategoryJoins").NewRow;
        nRow("CompanyID") = corpID;
        nRow("LocationID") = selectedLocation;
        nRow("FoodID") = newFoodJoin.ActiveJoinFoodID;
        nRow("CategoryID") = valueCatID;
        nRow("CategoryName") = valueCatName;
        nRow("NumberFree") = 1;          // default
        nRow("FreeFlag") = "S";
        nRow("GroupFlag") = "G";
        nRow("GTCFlag") = "-";
        nRow("ReqFlag") = "-";
        nRow("TempFoodJoinIndex") = newFoodJoin.ActiveTempIndex;
        dsSetup.Tables("JoinFoodCategoryJoins").Rows.Add(nRow);

        newFoodJoin.ActiveTempIndex += 1;

        this.grdJoinFoodCategoryJoins.Focus();
        updatedFoodJoin = true;

        // UpdateDatabaseFoodJoin()

    }

    private void grdJoinIndividualModifiers_Clicked(object sender, MouseEventArgs e)
    {

        if (newFoodJoin.ActiveJoinFoodID == default)
        {
            Interaction.MsgBox("Please Select A Food Item");
            return;
        }

        int valueModID;
        string valueModName;
        // Dim sqlStatement As String
        DataRow nRow;
        // first determine which categoryID is selected
        valueModID = DetermineID(grdJoinIndividualModifiers, 0);
        valueModName = DetermineString(grdJoinIndividualModifiers, 1);


        UpdateDatabaseFoodJoin();

        nRow = dsSetup.Tables("FoodJoin").NewRow;
        nRow("CompanyID") = corpID;
        nRow("LocationID") = selectedLocation;
        nRow("FoodID") = newFoodJoin.ActiveJoinFoodID;
        nRow("CategoryID") = DBNull.Value;
        nRow("ModifierID") = valueModID;
        nRow("NumberFree") = 1;          // default
        nRow("FreeFlag") = "S";
        nRow("GroupFlag") = "G"; // will always be grouped
        nRow("GTCFlag") = "-";
        nRow("ReqFlag") = "-";
        // nRow("TempFoodJoinIndex") = newFoodJoin.ActiveTempIndex
        dsSetup.Tables("FoodJoin").Rows.Add(nRow);

        newFoodJoin.ActiveModifierRow = dsSetup.Tables("JoinFoodModifierJoins").Rows.Count;
        newFoodJoin.ActiveCategoryRow = -1;
        nRow("FoodJoinID") = InsertingNewFoodJoin(ref nRow);
        dsSetup.Tables("FoodJoin").AcceptChanges();

        PopulateMinorJoins(newFoodJoin.ActiveJoinFoodID);    // valueFoodID)
        updatedFoodJoin = true;
        grdJoinFoodModifierJoins.Focus();


        return;





        nRow = dsSetup.Tables("FoodJoin").NewRow;
        nRow("CompanyID") = corpID;
        nRow("LocationID") = selectedLocation;
        nRow("FoodID") = newFoodJoin.ActiveJoinFoodID;
        nRow("ModifierID") = valueModID;
        nRow("NumberFree") = 1;          // default
        nRow("FreeFlag") = "S";
        nRow("GroupFlag") = "G";
        nRow("GTCFlag") = "-";
        nRow("ReqFlag") = "-";
        nRow("TempFoodJoinIndex") = newFoodJoin.ActiveTempIndex;
        dsSetup.Tables("FoodJoin").Rows.Add(nRow);

        newFoodJoin.ActiveModifierRow = dsSetup.Tables("JoinFoodModifierJoins").Rows.Count;
        newFoodJoin.ActiveCategoryRow = -1;
        // currentJoinModifierRow = dsSetup.Tables("JoinFoodModifierJoins").Rows.Count
        // currentJoinCategoryRow = -1

        nRow = dsSetup.Tables("JoinFoodModifierJoins").NewRow;
        nRow("CompanyID") = corpID;
        nRow("LocationID") = selectedLocation;
        nRow("FoodID") = newFoodJoin.ActiveJoinFoodID;
        nRow("ModifierID") = valueModID;
        nRow("FoodName") = valueModName;
        nRow("NumberFree") = 1;          // default
        nRow("FreeFlag") = "S";
        nRow("GroupFlag") = "G";
        nRow("ReqFlag") = "-";
        nRow("TempFoodJoinIndex") = newFoodJoin.ActiveTempIndex;
        dsSetup.Tables("JoinFoodModifierJoins").Rows.Add(nRow);

        newFoodJoin.ActiveTempIndex += 1;

        this.grdJoinFoodModifierJoins.Focus();
        // UpdateDatabaseFoodJoin()
        updatedFoodJoin = true;

    }

    private object InsertingNewFoodJoin(ref DataRow orow)
    {
        var newFoodJoinID = default(int);

        sql.SqlInsertCommandJoinFoodJoin.Parameters("@CompanyID").Value = orow("CompanyID");
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@LocationID").Value = orow("LocationID");
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@FoodID").Value = orow("FoodID");
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@CategoryID").Value = orow("CategoryID");
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@ModifierID").Value = orow("ModifierID");
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@NumberFree").Value = orow("NumberFree");
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@FreeFlag").Value = orow("FreeFlag");
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@GroupFlag").Value = orow("GroupFlag");
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@GTCFlag").Value = orow("GTCFlag");
        sql.SqlInsertCommandJoinFoodJoin.Parameters("@ReqFlag").Value = orow("ReqFlag");

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            newFoodJoinID = (int)sql.SqlInsertCommandJoinFoodJoin.ExecuteScalar();
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        return newFoodJoinID;

    }

    private void btnJoinFoodRemoveCategory_Click(object sender, EventArgs e)
    {

        if (newFoodJoin.ActiveCategoryRow == -1)
            return;

        DataRow dRow;
        int valueFoodJoinID;

        valueFoodJoinID = dsSetup.Tables("JoinFoodCategoryJoins").Rows(newFoodJoin.ActiveCategoryRow)("FoodJoinID");
        // this will take forever with a large food join
        foreach (DataRow currentDRow in dsSetup.Tables("FoodJoin").Rows)
        {
            dRow = currentDRow;
            if (!(dRow.RowState == DataRowState.Deleted) & !(dRow.RowState == DataRowState.Detached))
            {
                if (!object.ReferenceEquals(dRow("FoodJoinID"), DBNull.Value))
                {
                    if (dRow("FoodJoinID") == valueFoodJoinID)
                    {
                        dRow.Delete();
                        if (newFoodJoin.ActiveCategoryRow == dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count - 1)
                        {
                            newFoodJoin.ActiveCategoryRow -= 1;
                        }
                        break;
                    }
                }
            }
        }

        // *** there is a concurrecy erro in Update only for Category
        // anytime we delete a datarow we must update database
        // otherwise it hits deleted row b/c we pull off of rowIndex of grid
        UpdateDatabaseFoodJoin();
        PopulateFoodJoinData(ref this.grdJoinFoodChoice);
        // grdJoinFoodCategoryJoins.Focus()
        if (newFoodJoin.ActiveCategoryRow >= 0)
        {
            grdJoinFoodCategoryJoins.CurrentRowIndex = newFoodJoin.ActiveCategoryRow;
        }


        return;
        // 222


        if (!object.ReferenceEquals(dsSetup.Tables("JoinFoodCategoryJoins").Rows(newFoodJoin.ActiveCategoryRow)("FoodJoinID"), DBNull.Value))
        {
            valueFoodJoinID = dsSetup.Tables("JoinFoodCategoryJoins").Rows(newFoodJoin.ActiveCategoryRow)("FoodJoinID");
            // this will take forever with a large food join
            foreach (DataRow currentDRow1 in dsSetup.Tables("FoodJoin").Rows)
            {
                dRow = currentDRow1;
                if (!(dRow.RowState == DataRowState.Deleted) & !(dRow.RowState == DataRowState.Detached))
                {
                    if (!object.ReferenceEquals(dRow("FoodJoinID"), DBNull.Value))
                    {
                        if (dRow("FoodJoinID") == valueFoodJoinID)
                        {
                            dRow.Delete();
                            if (newFoodJoin.ActiveCategoryRow == dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count - 1)
                            {
                                newFoodJoin.ActiveCategoryRow -= 1;
                            }
                            break;
                        }
                    }
                }

            }
        }
        else
        {
            // ***  for new entries
            valueFoodJoinID = dsSetup.Tables("JoinFoodCategoryJoins").Rows(newFoodJoin.ActiveCategoryRow)("TempFoodJoinIndex");
            // this will take forever with a large food join
            foreach (DataRow currentDRow2 in dsSetup.Tables("FoodJoin").Rows)
            {
                dRow = currentDRow2;
                if (!(dRow.RowState == DataRowState.Deleted) & !(dRow.RowState == DataRowState.Detached))
                {
                    if (!object.ReferenceEquals(dRow("TempFoodJoinIndex"), DBNull.Value))
                    {
                        if (dRow("TempFoodJoinIndex") == valueFoodJoinID)
                        {
                            dRow.Delete();
                            if (newFoodJoin.ActiveCategoryRow == dsSetup.Tables("JoinFoodCategoryJoins").Rows.Count - 1)
                            {
                                newFoodJoin.ActiveCategoryRow -= 1;
                            }
                            break;
                        }
                    }
                }

            }
        }

        // *** there is a concurrecy erro in Update only for Category
        // anytime we delete a datarow we must update database
        // otherwise it hits deleted row b/c we pull off of rowIndex of grid
        UpdateDatabaseFoodJoin();
        PopulateFoodJoinData(ref this.grdJoinFoodChoice);

    }


    private void btnJoinFoodRemoveIndividual_Click(object sender, EventArgs e)
    {

        if (newFoodJoin.ActiveModifierRow == -1)
            return;

        DataRow dRow;
        int valueFoodJoinID;

        valueFoodJoinID = dsSetup.Tables("JoinFoodModifierJoins").Rows(newFoodJoin.ActiveModifierRow)("FoodJoinID");
        foreach (DataRow currentDRow in dsSetup.Tables("FoodJoin").Rows)
        {
            dRow = currentDRow;
            if (!(dRow.RowState == DataRowState.Deleted) & !(dRow.RowState == DataRowState.Detached))
            {
                if (!object.ReferenceEquals(dRow("FoodJoinID"), DBNull.Value))
                {
                    if (dRow("FoodJoinID") == valueFoodJoinID)
                    {
                        dRow.Delete();
                        // grdJoinFoodModifierJoins.UnSelect(newFoodJoin.ActiveModifierRow)
                        // If newFoodJoin.ActiveModifierRow > 0 Then
                        if (newFoodJoin.ActiveModifierRow) // dsSetup.Tables("JoinFoodModifierJoins").Rows.Count - 1 Then
                        {
                            newFoodJoin.ActiveModifierRow -= 1;
                        }
                        break;
                    }
                }
            }
        }

        // anytime we delete a datarow we must update database
        // otherwise it hits deleted row b/c we pull off of rowIndex of grid
        UpdateDatabaseFoodJoin();
        PopulateFoodJoinData(ref this.grdJoinFoodChoice);
        // grdJoinFoodModifierJoins.Focus()
        if (newFoodJoin.ActiveModifierRow >= 0)
        {
            grdJoinFoodModifierJoins.CurrentRowIndex = newFoodJoin.ActiveModifierRow;
        }


        return;
        // 222

        if (!object.ReferenceEquals(dsSetup.Tables("JoinFoodModifierJoins").Rows(newFoodJoin.ActiveModifierRow)("FoodJoinID"), DBNull.Value))
        {
            valueFoodJoinID = dsSetup.Tables("JoinFoodModifierJoins").Rows(newFoodJoin.ActiveModifierRow)("FoodJoinID");
            foreach (DataRow currentDRow1 in dsSetup.Tables("FoodJoin").Rows)
            {
                dRow = currentDRow1;
                if (!(dRow.RowState == DataRowState.Deleted) & !(dRow.RowState == DataRowState.Detached))
                {
                    if (!object.ReferenceEquals(dRow("FoodJoinID"), DBNull.Value))
                    {
                        if (dRow("FoodJoinID") == valueFoodJoinID)
                        {
                            dRow.Delete();
                            // grdJoinFoodModifierJoins.UnSelect(newFoodJoin.ActiveModifierRow)
                            if (newFoodJoin.ActiveModifierRow == dsSetup.Tables("JoinFoodModifierJoins").Rows.Count - 1)
                            {
                                newFoodJoin.ActiveModifierRow -= 1;
                            }
                            break;
                        }
                    }
                }

            }
        }
        else
        {
            // *** for new entries
            valueFoodJoinID = dsSetup.Tables("JoinFoodModifierJoins").Rows(newFoodJoin.ActiveModifierRow)("TempFoodJoinIndex");
            foreach (DataRow currentDRow2 in dsSetup.Tables("FoodJoin").Rows)
            {
                dRow = currentDRow2;
                if (!(dRow.RowState == DataRowState.Deleted) & !(dRow.RowState == DataRowState.Detached))
                {
                    if (!object.ReferenceEquals(dRow("TempFoodJoinIndex"), DBNull.Value))
                    {
                        if (dRow("TempFoodJoinIndex") == valueFoodJoinID)
                        {
                            dRow.Delete();
                            if (newFoodJoin.ActiveModifierRow == dsSetup.Tables("JoinFoodModifierJoins").Rows.Count - 1)
                            {
                                newFoodJoin.ActiveModifierRow -= 1;
                            }
                            break;
                        }
                    }
                }
            }
        }


        // anytime we delete a datarow we must update database
        // otherwise it hits deleted row b/c we pull off of rowIndex of grid
        UpdateDatabaseFoodJoin();
        PopulateFoodJoinData(ref this.grdJoinFoodChoice);

    }

    private void TabFoodJoin_Enter(object sender, EventArgs e)
    {

        DataRowView vRow;

        dvFoodJoinCategory = new DataView();

        {
            var withBlock = dvFoodJoinCategory;
            withBlock.Table = dsSetup.Tables("MainCategory");
            withBlock.RowFilter = "Active = True AND (FunctionFlag = 'O' OR FunctionFlag = 'M')";
            withBlock.Sort = "FunctionID, CategoryOrder";
        }

        cbxJoinIndividualModifierSelect.Items.Clear();
        foreach (DataRowView currentVRow in dvFoodJoinCategory)
        {
            vRow = currentVRow; // dsSetup.Tables("Main_ModifierCategory2").Rows
            cbxJoinIndividualModifierSelect.Items.Add(vRow("CategoryName"));
        }

        dvFoodJoinMainFoodsCagtegory = new DataView();
        {
            var withBlock1 = dvFoodJoinMainFoodsCagtegory;
            withBlock1.Table = dsSetup.Tables("MainCategory");
            withBlock1.RowFilter = "Active = True AND (FunctionFlag = 'F' OR FunctionFlag = 'O')";
            withBlock1.Sort = "FunctionID, CategoryOrder";
        }

        this.cbxJoinCategorySelect.Items.Clear();

        foreach (DataRowView currentVRow1 in dvFoodJoinMainFoodsCagtegory)
        {
            vRow = currentVRow1; // dsSetup.Tables("MainCategory").Rows
            this.cbxJoinCategorySelect.Items.Add(vRow("CategoryName"));
        }

        {
            var withBlock2 = dvMainCategoryFoodJoin;
            withBlock2.Table = dsSetup.Tables("MainCategory");
            // .RowFilter = "FunctionFlag = 'F' OR FunctionFlag = 'O' OR FunctionFlag = 'M' AND Active = True" ' AND CategoryOrder < 11"
            withBlock2.RowFilter = "Active = True"; // AND CategoryOrder < 11"
            // .Sort = "CategoryOrder"
        }

        // With dvFoodsJoins
        // .Table = dsSetup.Tables("FoodTable")
        // .RowFilter = "CategoryID = " & Me.globalJoinValueCategoryID
        // End With
        // JoinCurrencyMan.ResumeBinding()
        // FoodCurrencyMan.SuspendBinding()

    }

    private void TabFoodJoin_Leave(object sender, EventArgs e)
    {

        justAdjustingPosition = true;
        AdjustPosition();
        justAdjustingPosition = false;
        // this is only for updating lstModifiers on MainFoodTab

        if (updatedFoodJoin == true)
        {
            UpdateDatabaseFoodJoin();
        }

        dvFoodJoinCategory.Dispose();
        dvFoodJoinMainFoodsCagtegory.Dispose();

    }

    private void UpdateDatabaseFoodJoin()
    {

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlJoinFoodJoin.Update(dsSetup, "FoodJoin");
            sql.cn.Close();
            dsSetup.Tables("FoodJoin").AcceptChanges();
        }
        catch (Exception ex)
        {
            CloseConnection();

        }

        updatedFoodJoin = false;

    }






    // *****************************************************************
    // Drink Category
    // *****************************************************************

    private void DisplayDrinkCategoryPanel()
    {

        if (dsSetup.Tables("DrinkCategory").Rows.Count == 0)
        {
            try
            {
                CreateDrinkCategoryDataTable();
                sql.cn.Open();
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
                sql.SqlMenuDrinkCategory.Update(dsSetup, "DrinkCategory");
                dsSetup.Tables("DrinkCategory").AcceptChanges();

                dsSetup.Tables("DrinkCategory").Clear();
                sql.SqlSelectCommandMenuDrinkCategory.Parameters("@CompanyID").Value = corpID;
                sql.SqlSelectCommandMenuDrinkCategory.Parameters("@LocationID").Value = selectedLocation;
                sql.SqlMenuDrinkCategory.Fill(dsSetup.Tables("DrinkCategory"));
                sql.cn.Close();
                // dsSetup.Tables("DrinkCategory").Rows(0).Delete()    'this deletes the (-1 Drink Row)
                // dsSetup.Tables("DrinkCategory").AcceptChanges()
                ReadDrinkCategoryID();
            }
            catch (Exception ex)
            {
                CloseConnection();
            }
        }
        else if (generalDrinkCategoryID == -1)
        {
            ReadDrinkCategoryID();
        }

        int index;
        var count = default(int);
        int x = buttonSpace;
        int y = buttonSpace;
        int btnWidth;
        int btnHeight;
        this.pnlDrinks.Size = new Size(pnlDrinkCategory.Width, pnlDrinkCategory.Height);

        btnWidth = (pnlDrinkCategory.Width - 5 * buttonSpace) / 4;
        btnHeight = (pnlDrinkCategory.Height - 9 * buttonSpace) / 8;

        for (index = 1; index <= 32; index++)
        {
            btnCategory[index] = new DrinkButton();
            {
                var withBlock = btnCategory[index];
                withBlock.Size = new Size(btnWidth, btnHeight);
                withBlock.Location = new Point(x, y);
                withBlock.TabStop = false;
                withBlock.Position = index;

                // dtDrinkCateogy is "DrinkCategory" Table
                if (dsSetup.Tables("DrinkCategory").Rows.Count > 0)
                {
                    if (!object.ReferenceEquals(dsSetup.Tables("DrinkCategory").Rows(index - 1)("DrinkCategoryName"), DBNull.Value))
                    {
                        withBlock.Text = dtDrinkCategory.Rows(index - 1)("DrinkCategoryName");
                        if (!object.ReferenceEquals(dtDrinkCategory.Rows(index - 1)("ButtonColor"), DBNull.Value))
                        {
                            withBlock.BackColor = Color.FromArgb(dtDrinkCategory.Rows(index - 1)("ButtonColor"));
                            withBlock.ForeColor = Color.FromArgb(dtDrinkCategory.Rows(index - 1)("ButtonForeColor"));
                        }
                        else
                        {
                            withBlock.BackColor = c16;
                            withBlock.ForeColor = c3;
                        }
                    }
                    else
                    {
                        withBlock.Text = "";
                        withBlock.BackColor = c2;
                    }

                    withBlock.IsALiquorType = dtDrinkCategory.Rows(index - 1)("IsALiquorType");
                    withBlock.ID = dtDrinkCategory.Rows(index - 1)("DrinkCategoryID");  // index
                    withBlock.MenuIndex = dtDrinkCategory.Rows(index - 1)("DrinkCategoryNumber");  // index
                }


                // Else
                // .BackColor = c2
                // End If
                else
                {

                }

                pnlDrinkCategory.Controls.Add(btnCategory[index]);
                // pnlDrinks.Controls.Add(btnCategory(index))
                btnCategory[index].Click += pnlDrinkCategory_Click;

            }
            count += 1;
            if (count < 4)
            {
                x = x + buttonSpace + btnWidth;
            }
            else
            {
                x = buttonSpace;
                y = y + btnHeight + buttonSpace;
                count = 0;
            }
        }

    }

    private void DisplayDrinkCategoryPanel2()
    {
        // we use both display panels (1 and 2) b/c buttons are arrays
        int index;
        var count = default(int);
        int x = buttonSpace;
        int y = buttonSpace;
        int btnWidth;
        int btnHeight;
        this.pnlDrinks.Size = new Size(pnlDrinkCategory.Width, pnlDrinkCategory.Height);

        btnWidth = (pnlDrinkCategory.Width - 5 * buttonSpace) / 4;
        btnHeight = (pnlDrinkCategory.Height - 9 * buttonSpace) / 8;

        for (index = 1; index <= 32; index++)
        {
            btnCategory2[index] = new DrinkButton();
            {
                var withBlock = btnCategory2[index];
                withBlock.Size = new Size(btnWidth, btnHeight);
                withBlock.Location = new Point(x, y);
                withBlock.TabStop = false;
                withBlock.Position = index;
                // .ID = index     'will change if make more possible categories
                if (dsSetup.Tables("DrinkCategory").Rows.Count > 0)
                {
                    if (!object.ReferenceEquals(dsSetup.Tables("DrinkCategory").Rows(index - 1)("DrinkCategoryName"), DBNull.Value))
                    {
                        withBlock.Text = dtDrinkCategory.Rows(index - 1)("DrinkCategoryName");
                        if (!object.ReferenceEquals(dtDrinkCategory.Rows(index - 1)("ButtonColor"), DBNull.Value))
                        {
                            withBlock.BackColor = Color.FromArgb(dtDrinkCategory.Rows(index - 1)("ButtonColor"));
                            withBlock.ForeColor = Color.FromArgb(dtDrinkCategory.Rows(index - 1)("ButtonForeColor"));
                        }
                        else
                        {
                            withBlock.BackColor = c16;
                            withBlock.ForeColor = c3;
                        }
                    }
                    else
                    {
                        withBlock.Text = "";
                        withBlock.BackColor = c2;
                    }
                    withBlock.ID = dtDrinkCategory.Rows(index - 1)("DrinkCategoryID");  // index
                    withBlock.IsALiquorType = dtDrinkCategory.Rows(index - 1)("IsALiquorType");
                    withBlock.MenuIndex = dtDrinkCategory.Rows(index - 1)("DrinkCategoryNumber"); // index
                }
                // Else
                // .BackColor = c2
                // End If
                else
                {

                }

                // pnlDrinkCategory.Controls.Add(btnCategory(index))
                pnlDrinks.Controls.Add(btnCategory2[index]);
                btnCategory2[index].Click += pnlDrinks_Click;

            }
            count += 1;
            if (count < 4)
            {
                x = x + buttonSpace + btnWidth;
            }
            else
            {
                x = buttonSpace;
                y = y + btnHeight + buttonSpace;
                count = 0;
            }
        }

    }


    private void pnlDrinkCategory_Click(object sender, EventArgs e)
    {

        if (newDrinkChangesMade == true)
        {
            UpdateDrinkCategory();
            newDrinkChangesMade = false;
        }
        try
        {
            DrinkButton objButton = (DrinkButton)sender;
            this.txtDrinkCategoryName.Text = objButton.Text;
            this.chkLiquorType.Checked = objButton.IsALiquorType;

            if (objButton.Text == "")
            {
                this.btnDrinkCategoryColor.BackColor = c16;
                this.btnDrinkCategoryColor.ForeColor = c3;
            }

            else
            {
                this.btnDrinkCategoryColor.BackColor = objButton.BackColor;
                this.btnDrinkCategoryColor.ForeColor = objButton.ForeColor;
            }
            newDrink = new ActiveDrink();
            newDrink.DrinkCategoryID = objButton.ID;
            newDrink.DrinkCategoryIndex = objButton.MenuIndex;
            newDrinkChangesMade = false;
        }
        // txtDrinkCategoryName.Focus()

        catch (Exception ex)
        {
            return;
        }

    }

    private void pnlDrinks_Click(object sender, EventArgs e)
    {

        DrinkButton objButton;

        try
        {
            objButton = (DrinkButton)sender;
        }

        catch (Exception ex)
        {
            return;
        }

        this.pnlDrinks.Visible = false;
        this.pnlDrinkByCategory.Visible = true;
        newDrink.DrinkCategoryIndex = objButton.MenuIndex;  // objButton.Position
        PopulateDrinkByCategoryPanel(objButton.ID);

    }

    private void DrinkCategoryNameChanges(object sender, MouseEventArgs e)
    {
        newDrinkChangesMade = true;

    }

    private void DrinkCategoryLiquorTypeChanges(object sender, Global.System.Windows.Forms.MouseEventArgs e)
    {
        newDrinkChangesMade = true;

    }

    private void LeaveDrinkCategory(object sender, EventArgs e)
    {

        if (newDrinkChangesMade == true)
        {
            UpdateDrinkCategory();
        }

    }

    private void UpdateDrinkCategory()
    {

        if (txtDrinkCategoryName.Text == "")
        {
        }
        // Exit Sub
        // was for removing drinks
        // dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("DrinkCategoryName") = DBNull.Value
        // dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("IsALiquorType") = 0 'Me.chkLiquorType.Checked
        else
        {
            dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("DrinkCategoryName") = txtDrinkCategoryName.Text;
            dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("IsALiquorType") = this.chkLiquorType.Checked;
            dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("ButtonColor") = this.btnDrinkCategoryColor.BackColor.ToArgb;
            dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("ButtonForeColor") = this.btnDrinkCategoryColor.ForeColor.ToArgb;

        }

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlMenuDrinkCategory.Update(dsSetup, "DrinkCategory");
            sql.cn.Close();
            dsSetup.Tables("DrinkCategory").AcceptChanges();
        }

        catch (Exception ex)
        {
            CloseConnection();
        }

        btnCategory(newDrink.DrinkCategoryIndex).Text = txtDrinkCategoryName.Text;
        btnCategory(newDrink.DrinkCategoryIndex).IsALiquorType = this.chkLiquorType.Checked;
        btnCategory(newDrink.DrinkCategoryIndex).BackColor = this.btnDrinkCategoryColor.BackColor;
        btnCategory(newDrink.DrinkCategoryIndex).ForeColor = this.btnDrinkCategoryColor.ForeColor;
        btnCategory2(newDrink.DrinkCategoryIndex).Text = txtDrinkCategoryName.Text;
        btnCategory2(newDrink.DrinkCategoryIndex).IsALiquorType = this.chkLiquorType.Checked;
        btnCategory2(newDrink.DrinkCategoryIndex).BackColor = this.btnDrinkCategoryColor.BackColor;
        btnCategory2(newDrink.DrinkCategoryIndex).ForeColor = this.btnDrinkCategoryColor.ForeColor;

        PopulateDrinkCategoriesNames();

    }

    private void btnDrinkCategoryName_Click(object sender, EventArgs e)
    {
        // this was the update buttton
        // now remove category

        dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("DrinkCategoryName") = DBNull.Value;
        dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("ButtonColor") = DBNull.Value;
        dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("ButtonForeColor") = DBNull.Value;
        dsSetup.Tables("DrinkCategory").Rows(newDrink.DrinkCategoryIndex - 1)("IsALiquorType") = 0; // Me.chkLiquorType.Checked

        txtDrinkCategoryName.Text = "";
        this.chkLiquorType.Checked = false;
        this.btnDrinkCategoryColor.BackColor = c2;
        this.btnDrinkCategoryColor.ForeColor = c3;

        // Try
        // sql.cn.Open()
        // sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        // adt.Update(dsSetup, "DrinkCategory")
        // sql.cn.Close()
        // dsSetup.Tables("DrinkCategory").AcceptChanges()
        // Catch ex As Exception
        // CloseConnection()
        // End Try

        btnCategory(newDrink.DrinkCategoryIndex).Text = "";
        btnCategory(newDrink.DrinkCategoryIndex).IsALiquorType = 0;
        btnCategory(newDrink.DrinkCategoryIndex).BackColor = c2; // c16
        btnCategory(newDrink.DrinkCategoryIndex).ForeColor = c3;

        btnCategory2(newDrink.DrinkCategoryIndex).Text = "";
        btnCategory2(newDrink.DrinkCategoryIndex).IsALiquorType = 0;
        btnCategory2(newDrink.DrinkCategoryIndex).BackColor = c2;    // c16
        btnCategory2(newDrink.DrinkCategoryIndex).BackColor = c3;

        newDrinkChangesMade = true;

    }

    private void CreateDrinkCategoryDataTable()
    {
        DataRow oRow;
        int i;

        oRow = dsSetup.Tables("DrinkCategory").NewRow;
        oRow("CompanyID") = corpID;
        oRow("LocationID") = selectedLocation;
        oRow("DrinkCategoryNumber") = -1;
        oRow("DrinkCategoryName") = "Drinks";
        oRow("DrinkCategoryOrder") = DBNull.Value;

        oRow("ButtonColor") = this.btnDrinkCategoryColor.BackColor.ToArgb; // -3318692   ??
        oRow("ButtonForeColor") = this.btnDrinkCategoryColor.ForeColor.ToArgb; // -16777216
        oRow("IsALiquorType") = 0;

        dsSetup.Tables("DrinkCategory").Rows.Add(oRow);

        for (i = 1; i <= 32; i++)
        {
            oRow = dsSetup.Tables("DrinkCategory").NewRow;
            oRow("CompanyID") = corpID;
            oRow("LocationID") = selectedLocation;
            oRow("DrinkCategoryNumber") = i;
            oRow("DrinkCategoryName") = DBNull.Value;
            oRow("DrinkCategoryOrder") = DBNull.Value;
            oRow("ButtonColor") = DBNull.Value;
            oRow("ButtonForeColor") = DBNull.Value;

            oRow("IsALiquorType") = 0;

            dsSetup.Tables("DrinkCategory").Rows.Add(oRow);
        }

    }

    private void ReadDrinkCategoryID()
    {

        SqlClient.SqlCommand cmd;
        SqlClient.SqlDataReader dtr;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            cmd = new SqlClient.SqlCommand("SELECT DrinkCategoryID FROM DrinkCategory WHERE DrinkCategoryNumber = -1 AND CompanyID = '" + corpID + "' AND LocationID = '" + selectedLocation + "'", sql.cn);
            dtr = cmd.ExecuteReader;
            dtr.Read();
            if (dtr.HasRows)
            {
                generalDrinkCategoryID = dtr("DrinkCategoryID");
            }

            dtr.Close();
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
            Interaction.MsgBox("Issue with your General Drink Button");
            generalDrinkCategoryID = 0;
            return;
        }

    }

    private void CreateDrinkModifierDataTable222()
    {
        DataRow oRow;
        int i;
        var drinkNameString = new string[7];
        drinkNameString[1] = "Double";
        drinkNameString[2] = "Rocks";
        drinkNameString[3] = "Up";
        drinkNameString[4] = "Tall";
        drinkNameString[5] = "Splash";

        for (i = 1; i <= 5; i++)
        {
            oRow = dsSetup.Tables("DrinkModifiers").NewRow;
            oRow("CompanyID") = corpID;
            oRow("LocationID") = selectedLocation;
            oRow("DrinkModifierID") = i;
            oRow("DrinkID") = -1;
            oRow("DrinkName") = drinkNameString[i];
            oRow("DrinkPrice") = 0;

            dsSetup.Tables("DrinkModifiers").Rows.Add(oRow);
        }

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlMenuDrinkModifiers.Update(dsSetup, "DrinkModifiers");
            sql.cn.Close();
            dsSetup.Tables("DrinkModifiers").AcceptChanges();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

    }


    private void DisplayDrinkByCategoryPanel()
    {
        int index;
        var count = default(int);
        int x = buttonSpace;
        int y = buttonSpace;
        int btnWidth;
        int btnHeight;


        btnWidth = (pnlDrinkByCategory.Width - 7 * buttonSpace) / 6;
        btnHeight = (pnlDrinkByCategory.Height - 11 * buttonSpace) / 10;

        for (index = 1; index <= 60; index++) // 48
        {

            btnDrinks[index] = new DrinkButton();
            {
                var withBlock = btnDrinks[index];
                withBlock.Size = new Size(btnWidth, btnHeight);
                withBlock.Location = new Point(x, y);
                withBlock.TabStop = false;
                withBlock.Position = index;
                withBlock.BackColor = c2;
                withBlock.ID = 0;
                // pnlDrinkByCategory.Controls.Add(btnDrinks(index))
                // AddHandler btnDrinks(index).Click, AddressOf pnlDrinkByCategory_Click

            }
            count += 1;
            if (count < 6)
            {
                x = x + buttonSpace + btnWidth;
            }
            else
            {
                x = buttonSpace;
                y = y + btnHeight + buttonSpace;
                count = 0;
            }
        }

        // PopulateDrinkByCategoryPanel(0)

    }

    private void PopulateDrinkByCategoryPanel(int catID)
    {
        int index;
        int count;
        currentDrinkCategoryID = catID;

        {
            var withBlock = dvDrinksByCategory;
            withBlock.Table = dsSetup.Tables("Drinks");
            withBlock.RowFilter = "DrinkCategoryID = '" + catID + "'";
        }


        // **********************
        // btnDrinks are no longer used as buttons
        // they just hold info to populate foodOrderPanel

        pnlDrinkByCategory.Controls.Clear();
        for (index = 1; index <= 60; index++)
        {
            btnDrinks[index].BackColor = Color.White;
            // btnDrinks(index).ForeColor()
            btnDrinks[index].ID = 0;
            btnDrinks[index].DrinkIndex = 0;
            btnDrinks[index].Text = "";

        }

        foreach (DataRowView vRow in dvDrinksByCategory)
        {

            index = vRow("DrinkIndex");

            btnDrinks[index].Text = vRow("DrinkName");
            if (!object.ReferenceEquals(vRow("DrinkID"), DBNull.Value))
            {
                btnDrinks[index].ID = vRow("DrinkID");
            }
            else
            {
                btnDrinks[index].ID = 0;
            }

            // btnDrinks(index).DrinkCategoryID = vRow("DrinkCategoryID")
            btnDrinks[index].DrinkIndex = vRow("DrinkIndex");
            // btnDrinks(index).dRowNumber = count
            btnDrinks[index].BackColor = c16;
            btnDrinks[index].ForeColor = c3;
            // btnDrinks(index).DrinkPrice = vRow("DrinkPrice")
            // btnDrinks(index).CallPrice = vRow("CallPrice")
            // btnDrinks(index).AddOnPrice = vRow("AddOnPrice")
            // btnDrinks(index).DrinkFunctionID = vRow("DrinkFunctionID")
            // btnDrinks(index).DrinkDesc = vRow("DrinkDesc")
            // btnDrinks(index).DrinkAddOnChoice = vRow("DrinkAddOnChoice")
            // btnDrinks(index).IsDrinkAdd = vRow("IsDrinkAdd")
            // btnDrinks(index).IsWineParring = vRow("IsWineParring")
            // btnDrinks(index).LiquorTypeID = vRow("LiquorTypeID")

            // count += 1
        }


        for (index = 1; index <= 60; index++)

            DisplayOrderDrinks(btnDrinks[index].BackColor, btnDrinks[index].ForeColor, index, index, btnDrinks[index].DrinkIndex, btnDrinks[index].Text, default, default, default, btnDrinks[index].ID, default, default);


    }



    private void DisplayOrderDrinks(Color bColor, Color fColor, int position, int Index, int menuJoinId, string name, int fID, decimal sur, int rout, int dID, int GenMenuID, int cm)
    {



        float w = (pnlDrinkByCategory.Width - 6 * buttonSpace) / 6;
        float h = (pnlDrinkByCategory.Height - 10 * buttonSpace) / 10;
        string dTable = "Drinks";
        object price = null;     // keep in case we want to add

        switch (position)
        {
            case 1:
                {
                    DrinkOrderPanel1 = new FoodOrderPanel(bColor, fColor, 1, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel1);
                    break;
                }
            case 2:
                {
                    DrinkOrderPanel2 = new FoodOrderPanel(bColor, fColor, 2, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel2);
                    break;
                }
            case 3:
                {
                    DrinkOrderPanel3 = new FoodOrderPanel(bColor, fColor, 3, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel3);
                    break;
                }
            case 4:
                {
                    DrinkOrderPanel4 = new FoodOrderPanel(bColor, fColor, 4, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel4);
                    break;
                }
            case 5:
                {
                    DrinkOrderPanel5 = new FoodOrderPanel(bColor, fColor, 5, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel5);
                    break;
                }
            case 6:
                {
                    DrinkOrderPanel6 = new FoodOrderPanel(bColor, fColor, 6, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel6);
                    break;
                }
            case 7:
                {
                    DrinkOrderPanel7 = new FoodOrderPanel(bColor, fColor, 7, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel7);
                    break;
                }
            case 8:
                {
                    DrinkOrderPanel8 = new FoodOrderPanel(bColor, fColor, 8, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel8);
                    break;
                }
            case 9:
                {
                    DrinkOrderPanel9 = new FoodOrderPanel(bColor, fColor, 9, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel9);
                    break;
                }
            case 10:
                {
                    DrinkOrderPanel10 = new FoodOrderPanel(bColor, fColor, 10, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel10);
                    break;
                }
            case 11:
                {
                    DrinkOrderPanel11 = new FoodOrderPanel(bColor, fColor, 11, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel11);
                    break;
                }
            case 12:
                {
                    DrinkOrderPanel12 = new FoodOrderPanel(bColor, fColor, 12, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel12);
                    break;
                }
            case 13:
                {
                    DrinkOrderPanel13 = new FoodOrderPanel(bColor, fColor, 13, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel13);
                    break;
                }
            case 14:
                {
                    DrinkOrderPanel14 = new FoodOrderPanel(bColor, fColor, 14, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel14);
                    break;
                }
            case 15:
                {
                    DrinkOrderPanel15 = new FoodOrderPanel(bColor, fColor, 15, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel15);
                    break;
                }
            case 16:
                {
                    DrinkOrderPanel16 = new FoodOrderPanel(bColor, fColor, 16, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel16);
                    break;
                }
            case 17:
                {
                    DrinkOrderPanel17 = new FoodOrderPanel(bColor, fColor, 17, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel17);
                    break;
                }
            case 18:
                {
                    DrinkOrderPanel18 = new FoodOrderPanel(bColor, fColor, 18, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel18);
                    break;
                }
            case 19:
                {
                    DrinkOrderPanel19 = new FoodOrderPanel(bColor, fColor, 19, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel19);
                    break;
                }
            case 20:
                {
                    DrinkOrderPanel20 = new FoodOrderPanel(bColor, fColor, 20, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel20);
                    break;
                }
            case 21:
                {
                    DrinkOrderPanel21 = new FoodOrderPanel(bColor, fColor, 21, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel21);
                    break;
                }
            case 22:
                {
                    DrinkOrderPanel22 = new FoodOrderPanel(bColor, fColor, 22, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel22);
                    break;
                }
            case 23:
                {
                    DrinkOrderPanel23 = new FoodOrderPanel(bColor, fColor, 23, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel23);
                    break;
                }
            case 24:
                {
                    DrinkOrderPanel24 = new FoodOrderPanel(bColor, fColor, 24, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel24);
                    break;
                }
            case 25:
                {
                    DrinkOrderPanel25 = new FoodOrderPanel(bColor, fColor, 25, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel25);
                    break;
                }
            case 26:
                {
                    DrinkOrderPanel26 = new FoodOrderPanel(bColor, fColor, 26, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel26);
                    break;
                }
            case 27:
                {
                    DrinkOrderPanel27 = new FoodOrderPanel(bColor, fColor, 27, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel27);
                    break;
                }
            case 28:
                {
                    DrinkOrderPanel28 = new FoodOrderPanel(bColor, fColor, 28, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel28);
                    break;
                }
            case 29:
                {
                    DrinkOrderPanel29 = new FoodOrderPanel(bColor, fColor, 29, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel29);
                    break;
                }
            case 30:
                {
                    DrinkOrderPanel30 = new FoodOrderPanel(bColor, fColor, 30, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel30);
                    break;
                }
            case 31:
                {
                    DrinkOrderPanel31 = new FoodOrderPanel(bColor, fColor, 31, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel31);
                    break;
                }
            case 32:
                {
                    DrinkOrderPanel32 = new FoodOrderPanel(bColor, fColor, 32, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel32);
                    break;
                }
            case 33:
                {
                    DrinkOrderPanel33 = new FoodOrderPanel(bColor, fColor, 33, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel33);
                    break;
                }
            case 34:
                {
                    DrinkOrderPanel34 = new FoodOrderPanel(bColor, fColor, 34, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel34);
                    break;
                }
            case 35:
                {
                    DrinkOrderPanel35 = new FoodOrderPanel(bColor, fColor, 35, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel35);
                    break;
                }
            case 36:
                {
                    DrinkOrderPanel36 = new FoodOrderPanel(bColor, fColor, 36, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel36);
                    break;
                }
            case 37:
                {
                    DrinkOrderPanel37 = new FoodOrderPanel(bColor, fColor, 37, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel37);
                    break;
                }
            case 38:
                {
                    DrinkOrderPanel38 = new FoodOrderPanel(bColor, fColor, 38, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel38);
                    break;
                }
            case 39:
                {
                    DrinkOrderPanel39 = new FoodOrderPanel(bColor, fColor, 39, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel39);
                    break;
                }
            case 40:
                {
                    DrinkOrderPanel40 = new FoodOrderPanel(bColor, fColor, 40, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel40);
                    break;
                }
            case 41:
                {
                    DrinkOrderPanel41 = new FoodOrderPanel(bColor, fColor, 41, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel41);
                    break;
                }
            case 42:
                {
                    DrinkOrderPanel42 = new FoodOrderPanel(bColor, fColor, 42, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel42);
                    break;
                }
            case 43:
                {
                    DrinkOrderPanel43 = new FoodOrderPanel(bColor, fColor, 43, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel43);
                    break;
                }
            case 44:
                {
                    DrinkOrderPanel44 = new FoodOrderPanel(bColor, fColor, 44, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel44);
                    break;
                }
            case 45:
                {
                    DrinkOrderPanel45 = new FoodOrderPanel(bColor, fColor, 45, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel45);
                    break;
                }
            case 46:
                {
                    DrinkOrderPanel46 = new FoodOrderPanel(bColor, fColor, 46, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel46);
                    break;
                }
            case 47:
                {
                    DrinkOrderPanel47 = new FoodOrderPanel(bColor, fColor, 47, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel47);
                    break;
                }
            case 48:
                {
                    DrinkOrderPanel48 = new FoodOrderPanel(bColor, fColor, 48, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel48);
                    break;
                }
            case 49:
                {
                    DrinkOrderPanel49 = new FoodOrderPanel(bColor, fColor, 49, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel49);
                    break;
                }
            case 50:
                {
                    DrinkOrderPanel50 = new FoodOrderPanel(bColor, fColor, 50, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel50);
                    break;
                }
            case 51:
                {
                    DrinkOrderPanel51 = new FoodOrderPanel(bColor, fColor, 51, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel51);
                    break;
                }
            case 52:
                {
                    DrinkOrderPanel52 = new FoodOrderPanel(bColor, fColor, 52, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel52);
                    break;
                }
            case 53:
                {
                    DrinkOrderPanel53 = new FoodOrderPanel(bColor, fColor, 53, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel53);
                    break;
                }
            case 54:
                {
                    DrinkOrderPanel54 = new FoodOrderPanel(bColor, fColor, 54, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel54);
                    break;
                }
            case 55:
                {
                    DrinkOrderPanel55 = new FoodOrderPanel(bColor, fColor, 55, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel55);
                    break;
                }
            case 56:
                {
                    DrinkOrderPanel56 = new FoodOrderPanel(bColor, fColor, 56, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel56);
                    break;
                }
            case 57:
                {
                    DrinkOrderPanel57 = new FoodOrderPanel(bColor, fColor, 57, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel57);
                    break;
                }
            case 58:
                {
                    DrinkOrderPanel58 = new FoodOrderPanel(bColor, fColor, 58, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel58);
                    break;
                }
            case 59:
                {
                    DrinkOrderPanel59 = new FoodOrderPanel(bColor, fColor, 59, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel59);
                    break;
                }
            case 60:
                {
                    DrinkOrderPanel60 = new FoodOrderPanel(bColor, fColor, 60, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlDrinkByCategory.Controls.Add(DrinkOrderPanel60);
                    break;
                }

        }

    }


    private void DrinkMouseMove(object sender, EventArgs e)
    {

        currentDrinkPanelLast = (FoodPanelControl)sender;

        // KeepDrinkPanelBlank()
        currentDrinkPanelLast.Text = "";
        currentDrinkPanelLast.DrinkID = 0;
        currentDrinkPanelLast.FoodName = "";
        currentDrinkPanelLast.FoodPrice = 0;

        updatedDrink = true;

        // SaveDrinkhanges()

    }


    private void RecordLastPanelDrink222(ref FoodPanelControl currentOrderPanel)
    {

        newDrink.DrinkNameIndex = currentOrderPanel.MenuJoinID;
        newDrink.DrinkName = currentOrderPanel.Name;
        // newDrink.DrinkName = currentOrderPanel.Text
        // newDrink.ChangingPane = currentOrderPanel


    }

    private void KeepDrinkPanelBlank()
    {

        // currentDrinkPanel.Text = ""
        // currentDrinkPanel.DrinkID = 0

        // newDrink.DrinkNameID = 0

        // 
        return;


        btnDrinks(newModifier.MenuIndex).ID = (object)null;
        this.btnDrinks(newModifier.MenuIndex).Name = (object)null;
        this.btnDrinks(newModifier.MenuIndex).DrinkIndex = (object)null;
        updatedDrink = true; // b/c we changed position

    }

    private void pnlDrinkByCategory_Click(object sender, EventArgs e)
    {
        // Dim currentOrderPanel As FoodPanelControl


        drinkDisplaying = true;  // this is telling us in the middle of displaying
        DataRow oRow;
        var vRow = default(DataRowView);

        // newDrink here is last Drink hit
        // If Not currentDrinkPanel Is Nothing Then
        if (newDrink.DrinkNameIndex == default)
        {
            CreateOldDrink(newDrink.DrinkNameIndex, default);    // currentDrinkPanel.Position, Nothing)
        }
        else
        {
            CreateOldDrink(newDrink.DrinkNameIndex, newDrink.dRowNumber);
        }
        // End If


        UpdateDrink();
        currentDrinkPanel = (FoodPanelControl)sender;

        ClearDrinkInfo();
        this.cbxDrinkFunction.Text = "";

        // must init newDrink before Update so for new entrys we can place Index
        newDrink = new ActiveDrink();
        newDrink.DrinkNameID = currentDrinkPanel.DrinkID;
        newDrink.DrinkCategoryID = currentDrinkCategoryID;

        // MsgBox(newDrink.DrinkNameID)

        if (!(newDrink.DrinkNameID == 0))
        {
            addingNewDrinkTest = false;
            foreach (DataRowView currentVRow in dvDrinksByCategory)
            {
                vRow = currentVRow;
                if (vRow("DrinkID") == newDrink.DrinkNameID)
                {
                    break;
                }
            }
            newDrink.DrinkNameIndex = vRow("DrinkIndex");
            newDrink.DrinkName = vRow("DrinkName");

            newDrink.DrinkFunctionID = vRow("DrinkFunctionID");
            newDrink.DrinkPrice = vRow("DrinkPrice");
            newDrink.DrinkHappyPrice = vRow("DrinkHappyPrice");
            newDrink.AddOnPrice = vRow("AddOnPrice");
            newDrink.DrinkDesc = vRow("DrinkDesc");
            newDrink.DrinkAddOnChoice = vRow("DrinkAddOnChoice");
            newDrink.IsDrinkAdd = vRow("IsDrinkAdd");
            newDrink.IsWineParring = vRow("IsWineParring");
            newDrink.LiquorType = vRow("LiquorTypeID");
            newDrink.CallPrice = vRow("CallPrice");

            newDrinkChangesMade = false;


            txtDrinkName.Text = newDrink.DrinkName;
            txtDrinkPrice.Text = Strings.Format(newDrink.DrinkPrice, "##,###.00");
            txtDrinkHappyPrice.Text = Strings.Format(newDrink.DrinkHappyPrice, "##,###.00");
            txtDrinkDesc.Text = newDrink.DrinkDesc;
            txtCallPrice.Text = Strings.Format(newDrink.CallPrice, "####.00");
            txtAddOnPrice.Text = Strings.Format(newDrink.AddOnPrice, "####.00");
            this.chkSelectAddOn.Checked = newDrink.DrinkAddOnChoice;
            this.chkIsAddOn.Checked = newDrink.IsDrinkAdd;
            this.chkWineParring.Checked = newDrink.IsWineParring;
            foreach (DataRow currentORow in dsSetup.Tables("DrinkFunctions").Rows)
            {
                oRow = currentORow;
                if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                {
                    if (oRow("FunctionID") == newDrink.DrinkFunctionID)
                    {
                        this.cbxDrinkFunction.Text = oRow("FunctionName");
                        break;
                    }
                }
            }

            if (newDrink.LiquorType == 0)
            {
                this.cbxLiquorType.Text = "No Liquor Type";
            }
            else
            {
                foreach (DataRow currentORow1 in dsSetup.Tables("LiquorTypes").Rows)
                {
                    oRow = currentORow1;
                    if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                    {
                        if (oRow("DrinkCategoryID") == newDrink.LiquorType)
                        {
                            this.cbxLiquorType.Text = oRow("DrinkCategoryName");
                            break;
                        }
                    }
                }
            }


            foreach (DataRow currentORow2 in dsSetup.Tables("DrinkFunctions").Rows)
            {
                oRow = currentORow2;
                if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                {
                    if (oRow("FunctionID") == newDrink.DrinkFunctionID)
                    {
                        this.cbxDrinkFunction.Text = oRow("FunctionName");
                        break;
                    }
                }
            }
        }
        else
        {

            addingNewDrinkTest = true;
            newDrinkChangesMade = false;

        }

        txtDrinkName.Focus();
        drinkDisplaying = false;
        // RecordLastPanelDrink(currentOrderPanel)

    }

    private void pnlDrinkByCategory_Click222(object sender, EventArgs e) // Handles pnlDrinkByCategory.Click
    {
        DrinkButton objbutton;
        if (!object.ReferenceEquals(sender.GetType(), btnDrinks[1].GetType))
        {
            return;
        }
        objbutton = (DrinkButton)sender;

        if (newDrink.DrinkNameID > 0 & newDrink.DrinkFunctionID == 0)
        {
            // MsgBox("Please select a Tax Category")
        }
        drinkDisplaying = true;  // this is telling us in the middle of displaying
        DataRow oRow;

        // newDrink here is last Drink hit
        if (newDrink.DrinkNameIndex == default)
        {
            CreateOldDrink(objbutton.Position, objbutton.dRowNumber);
        }
        else
        {
            CreateOldDrink(newDrink.DrinkNameIndex, newDrink.dRowNumber);
        }

        UpdateDrink();
        ClearDrinkInfo();
        this.cbxDrinkFunction.Text = "";

        // must init newDrink before Update so for new entrys we can place Index
        newDrink = new ActiveDrink();
        newDrink.DrinkNameID = objbutton.ID;
        newDrink.DrinkNameIndex = objbutton.Position;
        newDrink.dRowNumber = objbutton.dRowNumber;

        // If objbutton.ID >= 0 Then
        try
        {
            // ClearDrinkInfo()
            txtDrinkName.Text = objbutton.Text;
            txtDrinkPrice.Text = Strings.Format(objbutton.DrinkPrice, "##,###.00");
            txtDrinkDesc.Text = objbutton.DrinkDesc;
            txtCallPrice.Text = Strings.Format(objbutton.CallPrice, "####.00");
            txtAddOnPrice.Text = Strings.Format(objbutton.AddOnPrice, "####.00");
            this.chkSelectAddOn.Checked = objbutton.DrinkAddOnChoice;
            this.chkIsAddOn.Checked = objbutton.IsDrinkAdd;
            this.chkWineParring.Checked = objbutton.IsWineParring;
            foreach (DataRow currentORow in dsSetup.Tables("DrinkFunctions").Rows)
            {
                oRow = currentORow;
                if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                {
                    if (oRow("FunctionID") == objbutton.DrinkFunctionID)
                    {
                        this.cbxDrinkFunction.Text = oRow("FunctionName");
                        break;
                    }
                }
            }

            if (objbutton.LiquorTypeID == 0)
            {
                this.cbxLiquorType.Text = "No Liquor Type";
            }
            else
            {
                foreach (DataRow currentORow1 in dsSetup.Tables("LiquorTypes").Rows)
                {
                    oRow = currentORow1;
                    if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                    {
                        if (oRow("DrinkCategoryID") == objbutton.LiquorTypeID)
                        {
                            this.cbxLiquorType.Text = oRow("DrinkCategoryName");
                            break;
                        }
                    }
                }
            }


            foreach (DataRow currentORow2 in dsSetup.Tables("DrinkFunctions").Rows)
            {
                oRow = currentORow2;
                if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                {
                    if (oRow("FunctionID") == objbutton.DrinkFunctionID)
                    {
                        this.cbxDrinkFunction.Text = oRow("FunctionName");
                        break;
                    }
                }
            }

            newDrink.DrinkName = objbutton.Text;
            newDrink.DrinkNameID = objbutton.ID;
            newDrink.DrinkFunctionID = objbutton.DrinkFunctionID;
            newDrink.DrinkPrice = objbutton.DrinkPrice;
            newDrink.CallPrice = objbutton.CallPrice;
            newDrink.AddOnPrice = objbutton.AddOnPrice;
            newDrink.DrinkDesc = objbutton.DrinkDesc;
            newDrink.DrinkAddOnChoice = objbutton.DrinkAddOnChoice;
            newDrink.IsDrinkAdd = objbutton.IsDrinkAdd;
            newDrink.IsWineParring = objbutton.IsWineParring;

            newDrinkChangesMade = false;
        }

        catch (Exception ex)
        {
            // Exit Sub

        }
        // End If

        txtDrinkName.Focus();

        if (objbutton.ID == -1)
        {
            addingNewDrinkTest = true;
        }
        else
        {
            addingNewDrinkTest = false;
        }

        drinkDisplaying = false;
    }

    private void CreateOldDrink(int dni, int dRowNum)
    {
        oldDrink = new ActiveDrink();
        DataRow oRow;

        // currentDrinkPanel.Text = Me.txtDrinkName.Text
        // currentDrinkPanel.DrinkID = newDrink.DrinkNameID

        oldDrink.DrinkName = this.txtDrinkName.Text;
        oldDrink.DrinkNameID = newDrink.DrinkNameID;
        oldDrink.DrinkCategoryIndex = currentDrinkCategoryID;
        oldDrink.DrinkCategoryID = currentDrinkCategoryID;

        oldDrink.ChangesMade = newDrinkChangesMade;
        oldDrink.DrinkNameIndex = newDrink.DrinkNameIndex;       // dni '
        oldDrink.dRowNumber = dRowNum;  // newDrink.dRowNumber
        try
        {
            if (this.txtDrinkPrice.Text.Length > 0)
            {
                oldDrink.DrinkPrice = Strings.Format((decimal)this.txtDrinkPrice.Text, "#,###.00");
            }
            else
            {
                oldDrink.DrinkPrice = 0;
            }
        }
        catch (Exception ex)
        {
            oldDrink.DrinkPrice = 0;
        }
        try
        {
            if (this.txtDrinkHappyPrice.Text.Length > 0)
            {
                oldDrink.DrinkHappyPrice = Strings.Format((decimal)this.txtDrinkHappyPrice.Text, "#,###.00");
            }
            else
            {
                oldDrink.DrinkHappyPrice = 0;
            }
        }
        catch (Exception ex)
        {
            oldDrink.DrinkHappyPrice = 0;
        }
        try
        {
            if (this.txtCallPrice.Text.Length > 0)
            {
                oldDrink.CallPrice = Strings.Format((decimal)this.txtCallPrice.Text, "###.00");
            }
            else
            {
                oldDrink.CallPrice = 0;
            }
        }
        catch (Exception ex)
        {
            oldDrink.CallPrice = 0;
        }
        try
        {
            if (!(this.txtAddOnPrice.Text == "Add-on Price"))
            {
                oldDrink.AddOnPrice = Strings.Format((decimal)this.txtAddOnPrice.Text, "###.00");
            }
            else
            {
                oldDrink.AddOnPrice = 0;
            }
        }
        catch (Exception ex)
        {
            oldDrink.AddOnPrice = 0;
        }
        if (this.txtDrinkDesc.Text.Length > 0)
        {
            oldDrink.DrinkDesc = this.txtDrinkDesc.Text;
        }
        else
        {
            oldDrink.DrinkDesc = "";
        }


        oldDrink.DrinkAddOnChoice = this.chkSelectAddOn.Checked;
        oldDrink.IsDrinkAdd = this.chkIsAddOn.Checked;
        oldDrink.IsWineParring = this.chkWineParring.Checked;

        // liquor Type is going to be an integer value related to drink Category ?????
        if (!(this.cbxLiquorType.Text == "No Liquor Type"))
        {
            foreach (DataRow currentORow in dsSetup.Tables("LiquorTypes").Rows)
            {
                oRow = currentORow;
                if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                {
                    if (oRow("DrinkCategoryName") == this.cbxLiquorType.Text)
                    {
                        oldDrink.LiquorType = oRow("DrinkCategoryID");
                        break;
                    }
                }
            }
        }

        foreach (DataRow currentORow1 in dsSetup.Tables("DrinkFunctions").Rows)
        {
            oRow = currentORow1;
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                if (oRow("FunctionName") == this.cbxDrinkFunction.Text) // objbutton.DrinkFunctionID Then
                {
                    // MsgBox(oRow("FunctionID"))
                    oldDrink.DrinkFunctionID = oRow("FunctionID");
                    break;
                }
            }
        }

    }



    private void DisplayDrinkByCategoryPanel222()
    {
        int index;
        var count = default(int);
        int x = buttonSpace;
        int y = buttonSpace;
        int btnWidth;
        int btnHeight;

        // Me.pnlDrinkByCategory.Size = New Size(pnlDrinkCategory.Width, pnlDrinkCategory.Height)
        btnWidth = (pnlDrinkByCategory.Width - 7 * buttonSpace) / 6;
        btnHeight = (pnlDrinkByCategory.Height - 11 * buttonSpace) / 10;

        for (index = 1; index <= 60; index++) // 48
        {
            btnDrinks[index] = new DrinkButton();
            {
                var withBlock = btnDrinks[index];
                withBlock.Size = new Size(btnWidth, btnHeight);
                withBlock.Location = new Point(x, y);
                withBlock.TabStop = false;
                withBlock.Position = index;
                withBlock.BackColor = c2;
                withBlock.ID = -1;
                pnlDrinkByCategory.Controls.Add(btnDrinks[index]);
                btnDrinks[index].Click += pnlDrinkByCategory_Click;

            }
            count += 1;
            if (count < 6)
            {
                x = x + buttonSpace + btnWidth;
            }
            else
            {
                x = buttonSpace;
                y = y + btnHeight + buttonSpace;
                count = 0;
            }
        }

    }

    private void PopulateDrinkByCategoryPanel222(int catID)
    {
        int index;
        var count = default(int);
        currentDrinkCategoryID = catID;

        {
            var withBlock = dvDrinksByCategory;
            withBlock.Table = dsSetup.Tables("Drinks");
            withBlock.RowFilter = "DrinkCategoryID = '" + catID + "'";
        }

        // dsSetup.Tables("Drinks").Clear()
        // dsSetup = sql.PopulateSelectedItemTable("Drinks", "SELECT CompanyID, LocationID, DrinkID, DrinkIndex, DrinkName, DrinkCategoryID, DrinkPrice, DrinkFunctionID, DrinkDesc, DrinkAddOnChoice, IsDrinkAdd, IsWineParring, LiquorTypeID, CallPrice, AddOnPrice, Active FROM Drinks WHERE DrinkCategoryID = '" & catID & "' AND CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "' ORDER BY DrinkIndex", dsSetup)

        newDrink = new ActiveDrink();

        foreach (DataRowView vRow in dvDrinksByCategory) // dsSetup.Tables("Drinks").Rows
        {
            // If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
            index = vRow("DrinkIndex");
            // newDrink.dRow = oRow
            btnDrinks[index].Text = vRow("DrinkName");
            if (!object.ReferenceEquals(vRow("DrinkID"), DBNull.Value))
            {
                btnDrinks[index].ID = vRow("DrinkID");
            }
            else
            {
                btnDrinks[index].ID = -1;
            }
            btnDrinks[index].ID = vRow("DrinkID");
            btnDrinks[index].DrinkCategoryID = vRow("DrinkCategoryID");
            btnDrinks[index].DrinkIndex = vRow("DrinkIndex");
            btnDrinks[index].dRowNumber = count;
            btnDrinks[index].BackColor = c16;
            btnDrinks[index].ForeColor = c3;
            btnDrinks[index].DrinkPrice = vRow("DrinkPrice");
            btnDrinks[index].CallPrice = vRow("CallPrice");
            btnDrinks[index].AddOnPrice = vRow("AddOnPrice");
            btnDrinks[index].DrinkFunctionID = vRow("DrinkFunctionID");
            btnDrinks[index].DrinkDesc = vRow("DrinkDesc");
            btnDrinks[index].DrinkAddOnChoice = vRow("DrinkAddOnChoice");
            btnDrinks[index].IsDrinkAdd = vRow("IsDrinkAdd");
            btnDrinks[index].IsWineParring = vRow("IsWineParring");
            btnDrinks[index].LiquorTypeID = vRow("LiquorTypeID");

            // End If
            count += 1;
        }

    }

    // Private Sub MarkChangesBecauseMouse(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDrinkName.MouseEnter
    // 
    // If newDrink.DrinkNameIndex = 0 Or oldDrink.DrinkNameIndex = 0 Then Exit Sub
    // 
    // newDrinkChangesMade = True
    // 
    // End Sub
    // 

    // Private Sub MarkChangesMade(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDrinkName.Enter, txtDrinkPrice.Enter, txtDrinkDesc.Enter, txtAddOnPrice.Enter, chkIsAddOn.Enter, chkSelectAddOn.Enter, chkWineParring.Enter, txtCallPrice.Enter

    // If newDrink.DrinkNameIndex = 0 Or oldDrink.DrinkNameIndex = 0 Then Exit Sub

    // If drinkDisplaying = False Then
    // newDrinkChangesMade = True
    // End If
    // End Sub

    private void MarkChangesMadeMouseDown(object sender, MouseEventArgs e)
    {

        if (newDrink.DrinkNameID == 0)
            return; // Or oldDrink.DrinkNameIndex = 0 Then Exit Sub
        newDrinkChangesMade = true;

    }

    private void MarkForWineParringChange(object sender, EventArgs e)
    {
        updatedWPI = true;
        updatedDrink = true;

    }

    private void ClearDrinkInfo()
    {

        txtDrinkName.Text = "";
        txtDrinkPrice.Text = 0;
        txtDrinkDesc.Text = (object)null;
        txtCallPrice.Text = 0;
        txtAddOnPrice.Text = 0;
        this.chkSelectAddOn.Checked = false;
        this.chkIsAddOn.Checked = false;
        this.chkWineParring.Checked = false;
        this.cbxLiquorType.Text = "No Liquor Type";


    }

    private void ClearDrinkButtons()
    {
        int index;
        DataRow blankRow;

        for (index = 1; index <= 60; index++)
        {
            btnDrinks[index].Text = "";
            btnDrinks[index].ID = 0;
            // btnDrinks(index).dRow = blankRow
            // btnDrinks(index).Text = Nothing
            // btnDrinks(index).ID = Nothing
            // btnDrinks(index).dRow = Nothing
            btnDrinks[index].BackColor = Color.White;
        }
    }

    private void ButtonDrinkCatColor_Click(object sender, EventArgs e)
    {

        this.DrinkColorChoice = new ButtonColor_UC();
        this.DrinkColorChoice.Location = new Point(480, 25);
        this.Controls.Add(DrinkColorChoice);
        DrinkColorChoice.BringToFront();

    }

    private void ChangingDrinkButtonColor(int cc, int foreCC)
    {

        this.btnDrinkCategoryColor.BackColor = Color.FromArgb(cc);
        this.btnDrinkCategoryColor.ForeColor = Color.FromArgb(foreCC);
        btnCategory(newDrink.DrinkCategoryIndex).BackColor = this.btnDrinkCategoryColor.BackColor;
        btnCategory(newDrink.DrinkCategoryIndex).ForeColor = this.btnDrinkCategoryColor.ForeColor;

        newDrinkChangesMade = true;

        // newCategory.ColorInt = cc
        // newCategory.ColorForeInt = foreCC
        // newCategory.Updated = True

    }


    private void pnlDrinkModifiers_Paint(object sender, EventArgs e)
    {

        this.btnDrinkPrices.ForeColor = Color.White;

    }

    private void btnDeleteDrink_Click(object sender, EventArgs e)
    {
        // If MsgBox("Are you sure you want to remove " & Me.txtDrinkName.Text & " ?", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
        DataRow oRow;
        var deletedDrink = default(bool);

        // do this so if any added drinks - we have a drinkID
        // dsSetup.Tables("Drink").Clear()
        // dsSetup = sql.PopulateSelectedItemTable("Drink", "SELECT CompanyID, LocationID, DrinkID, DrinkIndex, DrinkName, DrinkCategoryID, DrinkPrice, DrinkFunctionID, DrinkDesc, DrinkAddOnChoice, IsDrinkAdd, IsWineParring, LiquorTypeID, CallPrice, AddOnPrice, Active FROM Drinks WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'", dsSetup)

        if (newDrink.DrinkNameID != default)
        {
            foreach (DataRow currentORow in dsSetup.Tables("Drinks").Rows)
            {
                oRow = currentORow;
                if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                {
                    if (oRow("DrinkID") == newDrink.DrinkNameID)
                    {
                        Interaction.MsgBox(oRow("DrinkName") + " Deleted");
                        oRow.Delete();
                        deletedDrink = true;
                        break;
                    }
                    // If oRow("DrinkCategoryID") = currentDrinkCategoryID Then
                    // If oRow("DrinkIndex") = newDrink.DrinkNameIndex Then
                    // MsgBox(oRow("DrinkName") & " Deleted")
                    // oRow.Delete()
                    // deletedDrink = True
                    // Exit For
                    // End If
                    // End If
                }
            }
        }

        if (deletedDrink == false)
            return;

        foreach (DataRow currentORow1 in dsSetup.Tables("FoodTable").Rows)
        {
            oRow = currentORow1;
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                if (!object.ReferenceEquals(oRow("WineParringID"), DBNull.Value))
                {
                    if (oRow("WineParringID") == newDrink.DrinkNameID)
                    {
                        oRow("WineParringID") = 0;
                        updatedWPI = true;
                        // Exit For
                    }
                }
            }
        }

        // SaveDrink()
        updatedDrink = true;
        ClearDrinkInfo();
        currentDrinkPanel.Text = "";
        currentDrinkPanel.DrinkID = 0;
        currentDrinkPanel.FoodName = "";
        currentDrinkPanel.FoodPrice = 0;

        // btnDrinks(newDrink.DrinkNameIndex).Text = txtDrinkName.Text
        // If btnDrinks(newDrink.DrinkNameIndex).Text = "" Then
        // btnDrinks(newDrink.DrinkNameIndex).BackColor = c2
        // oldDrink = New ActiveDrink
        // oldDrink.DrinkNameIndex = newDrink.DrinkNameIndex
        // '222       UpdateDrinkButton()
        // End If
        // 
        // newDrink = New ActiveDrink

    }

    private void LeaveDrinkTab(object sender, EventArgs e)
    {
        if (!(newDrink.DrinkFunctionID > 0))
        {
            // MsgBox("Please select a Tax Category")
        }
        DataRow oRow;

        // If Not currentDrinkPanel Is Nothing Then
        CreateOldDrink(newDrink.DrinkNameIndex, newDrink.dRowNumber);
        // End If

        UpdateDrink();

        if (updatedDrink == true)
        {
            SaveDrink();
        }

        oldDrink.ChangesMade = false;

    }

    private void AddNewDrink()
    {

        DataRow oRow;
        SaveDrink();

        // If newDrink.DrinkNameID = Nothing Then
        oRow = dsSetup.Tables("Drinks").NewRow;
        // oRow("DrinkID") = newDrink.DrinkNameIndex       'need to do a get drink ID
        oRow("CompanyID") = corpID;
        oRow("LocationID") = selectedLocation;
        oRow("DrinkIndex") = currentDrinkPanel.Position;      // oldDrink.DrinkNameIndex
        oRow("DrinkName") = oldDrink.DrinkName; // txtDrinkName.Text
        oRow("DrinkCategoryID") = oldDrink.DrinkCategoryID;
        oRow("DrinkPrice") = oldDrink.DrinkPrice;
        oRow("DrinkHappyPrice") = oldDrink.DrinkHappyPrice;
        oRow("DrinkFunctionID") = oldDrink.DrinkFunctionID;
        oRow("TaxID") = 0;   // i don't think this is anything, we use TAX from funtionID
        oRow("DrinkDesc") = oldDrink.DrinkDesc;
        oRow("DrinkAddOnChoice") = oldDrink.DrinkAddOnChoice;
        oRow("IsDrinkAdd") = oldDrink.IsDrinkAdd;
        oRow("IsWineParring") = oldDrink.IsWineParring;
        oRow("LiquorTypeID") = oldDrink.LiquorType;

        oRow("AddOnPrice") = oldDrink.AddOnPrice;
        oRow("CallPrice") = oldDrink.CallPrice;
        oRow("Active") = 1;
        oRow("DrinkInvOn") = 0;
        oRow("DrinkInv") = 0;

        // we need this count before we add row (b/c zero based)
        oldDrink.dRowNumber = dsSetup.Tables("Drinks").Rows.Count;

        dsSetup.Tables("Drinks").Rows.Add(oRow);
        oRow("DrinkID") = InsertingNewDrink(ref oRow);
        dsSetup.Tables("Drinks").AcceptChanges();

        if (currentDrinkPanel is not null)
        {
            currentDrinkPanel.Text = this.txtDrinkName.Text;
            currentDrinkPanel.DrinkID = oRow("DrinkID");
            currentDrinkPanel.FoodName = this.txtDrinkName.Text;
            currentDrinkPanel.FoodPrice = oldDrink.DrinkPrice;
        }

        // newDrink.dRow = oRow

        // UpdateDrinkButton()

    }

    private object InsertingNewDrink(ref DataRow orow)
    {
        var newDrinkID = default(int);

        sql.SqlInsertCommandMenuDrinks.Parameters("@CompanyID").Value = orow("CompanyID");
        sql.SqlInsertCommandMenuDrinks.Parameters("@LocationID").Value = orow("LocationID");
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkIndex").Value = orow("DrinkIndex");
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkName").Value = orow("DrinkName");
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkCategoryID").Value = orow("DrinkCategoryID");
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkPrice").Value = orow("DrinkPrice");
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkHappyPrice").Value = orow("DrinkHappyPrice");
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkFunctionID").Value = orow("DrinkFunctionID");
        sql.SqlInsertCommandMenuDrinks.Parameters("@TaxID").Value = 0;
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkDesc").Value = orow("DrinkDesc");
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkAddOnChoice").Value = orow("DrinkAddOnChoice");
        sql.SqlInsertCommandMenuDrinks.Parameters("@IsDrinkAdd").Value = orow("IsDrinkAdd");
        sql.SqlInsertCommandMenuDrinks.Parameters("@IsWineParring").Value = orow("IsWineParring");
        sql.SqlInsertCommandMenuDrinks.Parameters("@LiquorTypeID").Value = orow("LiquorTypeID");
        sql.SqlInsertCommandMenuDrinks.Parameters("@CallPrice").Value = orow("CallPrice");
        sql.SqlInsertCommandMenuDrinks.Parameters("@AddOnPrice").Value = orow("AddOnPrice");
        sql.SqlInsertCommandMenuDrinks.Parameters("@Active").Value = orow("Active");
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkInvOn").Value = 0;
        sql.SqlInsertCommandMenuDrinks.Parameters("@DrinkInv").Value = 0;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            newDrinkID = (int)sql.SqlInsertCommandMenuDrinks.ExecuteScalar();
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        return newDrinkID;

    }

    private void MakeChangesExistingDrink()
    {
        var oRow = default(DataRow);

        // If Not newDrink.DrinkNameIndex = Nothing Then
        foreach (DataRow currentORow in dsSetup.Tables("Drinks").Rows)
        {
            oRow = currentORow;
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                if (oRow("DrinkID") == oldDrink.DrinkNameID)
                {
                    // MsgBox(oRow("DrinkCategoryID"))
                    // MsgBox(oRow("DrinkName"))
                    break;
                }
                // If oRow("DrinkCategoryID") = currentDrinkCategoryID Then
                // If oRow("DrinkIndex") = newDrink.DrinkNameIndex Then
                // Exit For
                // End If
                // End If
            }
        }
        // End If

        // oRow = dsSetup.Tables("Drinks").Rows(newDrink.dRowNumber)

        // oRow("DrinkIndex") = oldDrink.DrinkNameIndex
        oRow("DrinkName") = oldDrink.DrinkName; // txtDrinkName.Text
        oRow("DrinkCategoryID") = oldDrink.DrinkCategoryID;
        oRow("DrinkPrice") = oldDrink.DrinkPrice;
        oRow("DrinkHappyPrice") = oldDrink.DrinkHappyPrice;
        oRow("DrinkFunctionID") = oldDrink.DrinkFunctionID;
        // oRow("TaxID") = 2
        oRow("DrinkDesc") = oldDrink.DrinkDesc;
        oRow("DrinkAddOnChoice") = oldDrink.DrinkAddOnChoice;
        oRow("IsDrinkAdd") = oldDrink.IsDrinkAdd;
        oRow("IsWineParring") = oldDrink.IsWineParring;
        oRow("LiquorTypeID") = oldDrink.LiquorType;
        oRow("CallPrice") = oldDrink.CallPrice;
        oRow("AddOnPrice") = oldDrink.AddOnPrice;

        if (currentDrinkPanel is not null)
        {
            currentDrinkPanel.Text = oldDrink.DrinkName; // Me.txtDrinkName.Text
            currentDrinkPanel.FoodName = oldDrink.DrinkName;
            currentDrinkPanel.FoodPrice = oldDrink.DrinkPrice;
            // currentdrinkpanel.MenuJoinID =
            // currentDrinkPanel.DrinkID = oRow("DrinkID")
        }


        // will add 
        // orow("Acitve")
        // orow("DrinkInvOn")
        // oRow("DrinkInv")

        // newDrink.dRow = oRow  ?????

        // UpdateDrinkButton()

    }

    private void UpdateDrinkButton222()
    {
        DataRow oRow;
        int newDrinkID;
        // If oldDrink.DrinkNameIndex = 0 Then Exit Sub

        btnDrinks(oldDrink.DrinkNameIndex).Text = oldDrink.DrinkName;
        btnDrinks(oldDrink.DrinkNameIndex).DrinkFunctionID = oldDrink.DrinkFunctionID;
        btnDrinks(oldDrink.DrinkNameIndex).DrinkCategoryID = oldDrink.DrinkCategoryID;
        btnDrinks(oldDrink.DrinkNameIndex).DrinkIndex = oldDrink.DrinkNameIndex;
        btnDrinks(oldDrink.DrinkNameIndex).dRowNumber = oldDrink.dRowNumber;


        btnDrinks(oldDrink.DrinkNameIndex).DrinkPrice = oldDrink.DrinkPrice;
        btnDrinks(oldDrink.DrinkNameIndex).DrinkDesc = oldDrink.DrinkDesc;
        btnDrinks(oldDrink.DrinkNameIndex).DrinkAddOnChoice = oldDrink.DrinkAddOnChoice;
        btnDrinks(oldDrink.DrinkNameIndex).IsDrinkAdd = oldDrink.IsDrinkAdd;
        btnDrinks(oldDrink.DrinkNameIndex).IsWineParring = oldDrink.IsWineParring;
        btnDrinks(oldDrink.DrinkNameIndex).CallPrice = oldDrink.CallPrice;
        btnDrinks(oldDrink.DrinkNameIndex).AddOnPrice = oldDrink.AddOnPrice;
        btnDrinks(oldDrink.DrinkNameIndex).LiquorTypeID = oldDrink.LiquorType;

        if (btnDrinks(oldDrink.DrinkNameIndex).Text == "")
        {
            btnDrinks(oldDrink.DrinkNameIndex).BackColor = c2;
        }


        if (addingNewDrinkTest == true)           // newDrink.DrinkNameID = Nothing Then
        {
            // just add drink.... just change color
            btnDrinks(oldDrink.DrinkNameIndex).BackColor = c1;

            // newDrinkID = GetMaximumID("DrinkID", "Drinks")
            // btnDrinks(newDrink.DrinkNameIndex).ID = newDrinkID
            // btnDrinks(newDrink.DrinkNameIndex).dRow = newDrink.dRow
            // btnDrinks(newDrink.DrinkNameIndex).DrinkFunctionID = newDrink.DrinkFunctionID
        }

    }

    private void UpdateDrink()
    {

        if (addingNewDrinkTest == true)
        {
            // this is when the last drink panel hit was blank
            if (txtDrinkName.Text.Length > 0)
            {
                AddNewDrink();
                updatedDrink = true;
            }
        }
        else if (newDrinkChangesMade == true)
        {
            MakeChangesExistingDrink();
            newDrinkChangesMade = false;
            updatedDrink = true;
        }
        else
        {
            // ClearDrinkInfo()
        }

    }

    private void SaveDrink()
    {

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlMenuDrinks.Update(dsSetup, "Drinks");
            sql.cn.Close();
            dsSetup.Tables("Drinks").AcceptChanges();
            updatedDrink = false;
        }

        catch (Exception ex)
        {
            CloseConnection();
            Interaction.MsgBox(ex.Message);
        }

        if (updatedWPI == true)
        {
            UpdateDatabaseFoods();
            dsSetup.Tables("WineParring").Clear();
            sql.SqlSelectCommandMenuWineParring.Parameters("@CompanyID").Value = corpID;
            sql.SqlSelectCommandMenuWineParring.Parameters("@LocationID").Value = selectedLocation;

            try
            {
                sql.cn.Open();
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
                sql.SqlMenuWineParring.Fill(dsSetup.Tables("WineParring"));
                sql.cn.Close();
            }
            catch (Exception ex)
            {
                CloseConnection();
            }

            cbxWineParring.Items.Clear();
            foreach (DataRow oRow in dsSetup.Tables("WineParring").Rows)
            {
                if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                {
                    cbxWineParring.Items.Add(oRow("DrinkName"));
                }
            }
            updatedWPI = false;
        }

    }

    private void cbxDrinkFunction_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (newDrink.DrinkNameIndex == 0)
            return; // Or oldDrink.DrinkNameIndex = 0 Then Exit Sub

        int valueTypeID;
        valueTypeID = dsSetup.Tables("DrinkFunctions").Rows(this.cbxDrinkFunction.SelectedIndex)("FunctionID");

        newDrink.DrinkFunctionID = valueTypeID;
        newDrinkChangesMade = true;

    }

    private void cbxLiquorType_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (newDrink.DrinkNameIndex == 0)
            return; // Or oldDrink.DrinkNameIndex = 0 Then Exit Sub

        // MsgBox(newDrink.LiquorType)
        // MsgBox(newDrink.DrinkName)
        // MsgBox(oldDrink.DrinkName)

        if (this.cbxLiquorType.SelectedIndex == 0)
        {
            newDrink.LiquorType = 0;
        }
        else
        {
            int valueTypeID;
            valueTypeID = dsSetup.Tables("LiquorTypes").Rows(cbxLiquorType.SelectedIndex - 1)("DrinkCategoryID");

            // MsgBox(valueTypeID)
            // MsgBox(dsSetup.Tables("LiquorTypes").Rows(cbxLiquorType.SelectedIndex)("DrinkCategoryName"))

            newDrink.LiquorType = valueTypeID;
        }

        newDrinkChangesMade = true;

    }

    private void btnBackToCategory_Click(object sender, EventArgs e)
    {


        // If Not currentDrinkPanel Is Nothing Then
        CreateOldDrink(newDrink.DrinkNameIndex, newDrink.dRowNumber);
        // End If

        UpdateDrink();

        if (updatedDrink == true)
        {
            SaveDrink();
        }

        ClearDrinkInfo();
        ClearDrinkButtons();
        addingNewDrinkTest = false;
        newDrinkChangesMade = false;
        newDrink.DrinkNameID = (object)null;
        newDrink.dRowNumber = (object)null;

        this.pnlDrinks.Visible = true;
        this.pnlDrinkByCategory.Visible = false;
        newDrink.DrinkNameID = (object)null;
        // newDrink.DrinkCategoryIndex = objButton.Position

    }

    private void DisplayDrinkModifiers222()
    {

        if (dsSetup.Tables("DrinkModifiers").Rows.Count == 0)
        {
            CreateDrinkModifierDataTable222();
        }

        txtDrinkDouble.Text = Strings.Format(dsSetup.Tables("DrinkModifiers").Rows(0)("DrinkPrice"), "###.00");
        txtDrinkRocks.Text = Strings.Format(dsSetup.Tables("DrinkModifiers").Rows(1)("DrinkPrice"), "###.00");
        txtDrinkUp.Text = Strings.Format(dsSetup.Tables("DrinkModifiers").Rows(2)("DrinkPrice"), "###.00");
        txtDrinkTall.Text = Strings.Format(dsSetup.Tables("DrinkModifiers").Rows(3)("DrinkPrice"), "###.00");
        txtDrinkSplash.Text = Strings.Format(dsSetup.Tables("DrinkModifiers").Rows(4)("DrinkPrice"), "###.00");

    }



    // ********************************
    // 
    // Drink Prep
    // 
    // ********************************

    private void DisplayDrinkPrep()
    {

        int count;
        var index = default(int);

        // sizes
        int xMenu = 63;   // name (check box)
        int xMenu2 = 35;  // price & orderBy
        int yMenu = 24;
        // locations
        int xMenuLocation = 10;
        int yMenuLocation = 50;   // (3 * buttonSpace)

        foreach (DataRow oRow in dsSetup.Tables("DrinkPrep").Rows)
        {

            if (index == 0 | index == 15 | index == 30 | index == 45 | index == 60)
            {
                var priceLabel = new Label();
                var orderByLabel = new Label();
                var InvLabel = new Label();

                priceLabel.Text = " Price";
                priceLabel.ForeColor = Color.White;
                priceLabel.Size = new Size(xMenu2, 15);
                priceLabel.Location = new Point(xMenu + 15 + xMenuLocation, yMenuLocation);
                priceLabel.TextAlign = ContentAlignment.MiddleRight;
                orderByLabel.Text = "Ord";
                orderByLabel.ForeColor = Color.White;
                orderByLabel.Size = new Size(yMenu, 15);
                orderByLabel.Location = new Point(xMenu + 15 + xMenu2 + xMenuLocation + 2, yMenuLocation);
                orderByLabel.TextAlign = ContentAlignment.MiddleRight;
                InvLabel.Text = "Inv";
                InvLabel.ForeColor = Color.White;
                InvLabel.Size = new Size(yMenu, 15);
                InvLabel.Location = new Point(xMenu + 15 + xMenu2 + yMenu + xMenuLocation + 4, yMenuLocation);
                InvLabel.TextAlign = ContentAlignment.MiddleRight;

                this.TabDrinkPrep.Controls.Add(priceLabel);
                this.TabDrinkPrep.Controls.Add(orderByLabel);
                this.TabDrinkPrep.Controls.Add(InvLabel);
                yMenuLocation = yMenuLocation + 15 + buttonSpace;
            }

            prepCheckBox[index] = new CheckBox();
            {
                var withBlock = prepCheckBox[index];
                // .Checked = True 
                withBlock.ForeColor = Color.White;
                withBlock.Name = index; // oRow("DrinkPrepID")
                withBlock.Text = oRow("DrinkPrepName");
                withBlock.Size = new Size(xMenu, yMenu);
                withBlock.Location = new Point(xMenuLocation, yMenuLocation);
                this.TabDrinkPrep.Controls.Add(prepCheckBox[index]);
                xMenuLocation += xMenu + 2;
            }
            prepCheckBox[index].Enter += prepCheckBox_Changed;

            prepMethod[index] = new Label();
            {
                var withBlock1 = prepMethod[index];
                withBlock1.Size = new Size(15, 21);
                withBlock1.BackColor = System.Drawing.Color.FromArgb(0, 78, 152);
                withBlock1.ForeColor = Color.White;
                withBlock1.Name = index; // oRow("DrinkPrepID")
                withBlock1.Location = new Point(xMenuLocation, yMenuLocation);
                withBlock1.TextAlign = HorizontalAlignment.Center;
                this.TabDrinkPrep.Controls.Add(prepMethod[index]);
                xMenuLocation += 15;
            }
            prepMethod[index].DoubleClick += prepMethod_Clicked;

            prepPriceText[index] = new TextBox();
            {
                var withBlock2 = prepPriceText[index];
                withBlock2.Size = new Size(xMenu2, yMenu);
                withBlock2.Name = index; // oRow("DrinkPrepID")
                withBlock2.Location = new Point(xMenuLocation, yMenuLocation);
                withBlock2.TextAlign = HorizontalAlignment.Right;
                this.TabDrinkPrep.Controls.Add(prepPriceText[index]);
                xMenuLocation += xMenu2 + buttonSpace;
            }
            prepPriceText[index].Validating += prepPriceText_Changed;

            prepOrderByText[index] = new TextBox();
            {
                var withBlock3 = prepOrderByText[index];
                withBlock3.Size = new Size(yMenu, yMenu);
                withBlock3.Name = index;   // oRow("DrinkPrepID")
                withBlock3.Location = new Point(xMenuLocation, yMenuLocation);
                withBlock3.TextAlign = HorizontalAlignment.Right;
                this.TabDrinkPrep.Controls.Add(prepOrderByText[index]);
                xMenuLocation += yMenu + buttonSpace;
                // .TextAlign = HorizontalAlignment.Right
            }
            prepOrderByText[index].Validating += prepOrderByText_Changed;

            prepInvMultiplier[index] = new TextBox();
            {
                var withBlock4 = prepInvMultiplier[index];
                withBlock4.Size = new Size(yMenu, yMenu);
                withBlock4.Name = index;   // oRow("DrinkPrepID")
                withBlock4.Location = new Point(xMenuLocation, yMenuLocation);
                withBlock4.TextAlign = HorizontalAlignment.Right;
                this.TabDrinkPrep.Controls.Add(prepInvMultiplier[index]);
                // xMenuLocation += (xMenu2 + buttonSpace)
                // .TextAlign = HorizontalAlignment.Right
            }
            prepInvMultiplier[index].Validating += prepInvMultiplier_Changed;

            foreach (DataRow dRow in dsSetup.Tables("DrinkPrepLocation").Rows)
            {
                if (oRow("DrinkPrepID") == dRow("DrinkPrepID"))
                {
                    // this restaurant is using this prep
                    if (dRow("Active") == true)
                    {
                        prepCheckBox[index].Checked = dRow("Active");
                        prepPriceText[index].Text = dRow("DrinkPrepPrice");
                        if (!(dRow("DrinkPrepOrder") == 999999))
                        {
                            prepOrderByText[index].Text = dRow("DrinkPrepOrder");
                        }
                        if (!(dRow("InvMultiplier") == 1))
                        {
                            prepInvMultiplier[index].Text = dRow("InvMultiplier");
                        }
                        if (dRow("DrinkPrepMethod") == "USdol")
                        {
                            prepMethod[index].Text = "$";
                        }
                        else if (dRow("DrinkPrepMethod") == "percent")
                        {
                            prepMethod[index].Text = "%";
                        }
                    }
                    break;
                }
            }

            index += 1;
            if (index == 15 | index == 30 | index == 45 | index == 60)
            {
                xMenuLocation += xMenu2 + 30;
                yMenuLocation = 50;
            }
            else
            {
                xMenuLocation -= 2 + xMenu + 15 + xMenu2 + yMenu + 2 * buttonSpace;
                yMenuLocation = yMenuLocation + yMenu + buttonSpace;
            }
        }

    }

    private void prepCheckBox_Changed(object sender, EventArgs e)
    {

        DataRow oRow;
        DataRow dRow;
        int currentPrepID;

        currentPrepID = dsSetup.Tables("DrinkPrep").Rows(sender.name)("DrinkPrepID");
        prepDrinkUpdated = true;

        // we ENTER before we change state
        // this is backwards on purpose, we are changing to Unchecked
        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(sender.@checked, true, false)))
        {
            foreach (DataRow currentDRow in dsSetup.Tables("DrinkPrepLocation").Rows)
            {
                dRow = currentDRow;
                if (dRow("DrinkPrepID") == currentPrepID)
                {
                    dRow("Active") = false;
                    break;
                }
            }
        }

        else
        {
            foreach (DataRow currentDRow1 in dsSetup.Tables("DrinkPrepLocation").Rows)
            {
                dRow = currentDRow1;
                if (dRow("DrinkPrepID") == currentPrepID)
                {
                    dRow("Active") = true;
                    prepPriceText(sender.name).Text = dRow("DrinkPrepPrice");
                    if (!(dRow("DrinkPrepOrder") == 999999))
                    {
                        prepOrderByText(sender.name).Text = dRow("DrinkPrepOrder");
                    }
                    if (!(dRow("InvMultiplier") == 1))
                    {
                        prepInvMultiplier(sender.name).Text = dRow("InvMultiplier");
                    }
                    if (dRow("DrinkPrepMethod") == "USdol")
                    {
                        prepMethod(sender.name).Text = "$";
                    }
                    else if (dRow("DrinkPrepMethod") == "percent")
                    {
                        prepMethod(sender.name).Text = "%";
                    }
                    return;
                }
            }

            // we must need to add row to DrinkPrepLocation
            oRow = dsSetup.Tables("DrinkPrepLocation").NewRow;

            oRow("CompanyID") = corpID;
            oRow("LocationID") = selectedLocation;
            oRow("DrinkPrepID") = currentPrepID;
            if (lastPrepMethod == "USdol")
            {
                oRow("DrinkPrepMethod") = "USdol";
                prepMethod(sender.name).Text = "$";
            }
            else
            {
                oRow("DrinkPrepMethod") = "percent";
                prepMethod(sender.name).Text = "%";
            }
            if (prepPriceText(sender.name).Text == "")
            {
                oRow("DrinkPrepPrice") = 0;
            }
            else
            {
                oRow("DrinkPrepPrice") = (decimal)prepPriceText(sender.name).Text;
            }
            oRow("Active") = 1;
            if (prepOrderByText(sender.name).Text == "")
            {
                oRow("DrinkPrepOrder") = 999999;
            }
            else
            {
                oRow("DrinkPrepOrder") = (int)prepOrderByText(sender.name).Text;
            }
            if (prepOrderByText(sender.name).Text == "")
            {
                oRow("InvMultiplier") = 1;
            }
            else
            {
                oRow("InvMultiplier") = (int)prepInvMultiplier(sender.name).Text;
            }

            dsSetup.Tables("DrinkPrepLocation").Rows.Add(oRow);
            oRow("DrinkPrepLocationID") = InsertingNewDrinkPrep(ref oRow);
            dsSetup.Tables("DrinkPrepLocation").AcceptChanges();

        }

    }


    private void prepMethod_Clicked(object sender, EventArgs e) // Handles prepMethod.DoubleClick
    {
        int currentPrepID;

        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(sender.text, "", false)))
            return;

        currentPrepID = dsSetup.Tables("DrinkPrep").Rows(sender.name)("DrinkPrepID");
        prepDrinkUpdated = true;

        foreach (DataRow dRow in dsSetup.Tables("DrinkPrepLocation").Rows)
        {
            if (dRow("DrinkPrepID") == currentPrepID)
            {
                if (dRow("DrinkPrepMethod") == "USdol")
                {
                    dRow("DrinkPrepMethod") = "percent";
                    sender.Text = "%";
                    lastPrepMethod = "percent";
                }
                // Format(prepPriceText(sender.name), decimal)
                else if (dRow("DrinkPrepMethod") == "percent")
                {
                    dRow("DrinkPrepMethod") = "USdol";
                    sender.Text = "$";
                    lastPrepMethod = "USdol";
                }
                return;
            }
        }

    }


    private void prepPriceText_Changed(object sender, System.ComponentModel.CancelEventArgs e)
    {

        int currentPrepID;
        bool isValid;

        isValid = Conversions.ToBoolean(ValidateNumeric(ref sender, false));

        if (isValid == false)
            return;

        currentPrepID = dsSetup.Tables("DrinkPrep").Rows(sender.name)("DrinkPrepID");
        prepDrinkUpdated = true;

        foreach (DataRow dRow in dsSetup.Tables("DrinkPrepLocation").Rows)
        {
            if (dRow("DrinkPrepID") == currentPrepID)
            {
                dRow("DrinkPrepPrice") = Conversions.ToDecimal(sender.text);
                return;
            }
        }

    }

    private void prepOrderByText_Changed(object sender, System.ComponentModel.CancelEventArgs e)
    {

        int currentPrepID;
        int newPrepOrder;

        if (Information.IsNumeric(sender.Text) == false)
        {
            newPrepOrder = 999999;
            sender.text = "";
        }
        else
        {
            sender.text = (object)Conversions.ToInteger(sender.text);
            newPrepOrder = Conversions.ToInteger(sender.text);
        }

        currentPrepID = dsSetup.Tables("DrinkPrep").Rows(sender.name)("DrinkPrepID");
        prepDrinkUpdated = true;

        foreach (DataRow dRow in dsSetup.Tables("DrinkPrepLocation").Rows)
        {
            if (dRow("DrinkPrepID") == currentPrepID)
            {
                dRow("DrinkPrepOrder") = newPrepOrder;
                return;
            }
        }

    }

    private void prepInvMultiplier_Changed(object sender, System.ComponentModel.CancelEventArgs e)
    {

        // **********
        return;

        int currentPrepID;
        int newPrepOrder;

        if (Information.IsNumeric(sender.Text) == false)
        {
            newPrepOrder = 999999;
            sender.text = "";
        }
        else
        {
            sender.text = (object)Conversions.ToInteger(sender.text);
            newPrepOrder = Conversions.ToInteger(sender.text);
        }

        currentPrepID = dsSetup.Tables("DrinkPrep").Rows(sender.name)("DrinkPrepID");
        prepDrinkUpdated = true;

        foreach (DataRow dRow in dsSetup.Tables("DrinkPrepLocation").Rows)
        {
            if (dRow("DrinkPrepID") == currentPrepID)
            {
                dRow("DrinkPrepOrder") = newPrepOrder;
                return;
            }
        }

    }

    private object InsertingNewDrinkPrep(ref DataRow orow)
    {
        var newDrinkPrepID = default(int);

        sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@CompanyID").Value = orow("CompanyID");
        sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@LocationID").Value = orow("LocationID");
        sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@DrinkPrepID").Value = orow("DrinkPrepID");
        sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@DrinkPrepMethod").Value = orow("DrinkPrepMethod");
        sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@DrinkPrepPrice").Value = orow("DrinkPrepPrice");
        // sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@DrinkPrepCost").Value = 0
        // sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@DrinkPrepManual").Value = 0
        // sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@TaxID").Value = DBNull.Value
        sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@Active").Value = orow("Active");
        sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@DrinkPrepOrder").Value = orow("DrinkPrepOrder");
        sql.SqlInsertCommandMenuDrinkPrepLocation.Parameters("@InvMultiplier").Value = orow("InvMultiplier");

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            newDrinkPrepID = (int)sql.SqlInsertCommandMenuDrinkPrepLocation.ExecuteScalar();
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
            Interaction.MsgBox(ex.Message);
        }

        return newDrinkPrepID;

    }

    private void UpdateDrinkPrep()
    {

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlMenuDrinkPrepLocation.Update(dsSetup, "DrinkPrepLocation");
            sql.cn.Close();
            dsSetup.Tables("DrinkPrepLocation").AcceptChanges();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        prepDrinkUpdated = false;

    }

    private void LeaveDrinkPrepTab(object sender, EventArgs e)
    {

        if (prepDrinkUpdated == true)
        {
            UpdateDrinkPrep();
        }

    }




    private void btnDrinkPrices_Click(object sender, EventArgs e)
    {

        try
        {
            dsSetup.Tables("DrinkModifiers").Rows(0)("DrinkPrice") = (float)this.txtDrinkDouble.Text;
        }
        catch (Exception ex)
        {
            dsSetup.Tables("DrinkModifiers").Rows(0)("DrinkPrice") = 0;
        }

        try
        {
            dsSetup.Tables("DrinkModifiers").Rows(1)("DrinkPrice") = (float)this.txtDrinkRocks.Text;
        }
        catch (Exception ex)
        {
            dsSetup.Tables("DrinkModifiers").Rows(1)("DrinkPrice") = 0;
        }

        try
        {
            dsSetup.Tables("DrinkModifiers").Rows(2)("DrinkPrice") = (float)this.txtDrinkUp.Text;
        }
        catch (Exception ex)
        {
            dsSetup.Tables("DrinkModifiers").Rows(2)("DrinkPrice") = 0;
        }

        try
        {
            dsSetup.Tables("DrinkModifiers").Rows(3)("DrinkPrice") = (float)this.txtDrinkTall.Text;
        }
        catch (Exception ex)
        {
            dsSetup.Tables("DrinkModifiers").Rows(3)("DrinkPrice") = 0;
        }

        try
        {
            dsSetup.Tables("DrinkModifiers").Rows(4)("DrinkPrice") = (float)this.txtDrinkSplash.Text;
        }
        catch (Exception ex)
        {
            dsSetup.Tables("DrinkModifiers").Rows(4)("DrinkPrice") = 0;
        }

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlMenuDrinkModifiers.Update(dsSetup, "DrinkModifiers");
            sql.cn.Close();
            dsSetup.Tables("DrinkModifiers").AcceptChanges();
        }

        catch (Exception ex)
        {
            CloseConnection();
            Interaction.MsgBox(ex.Message);
        }

        this.btnDrinkPrices.ForeColor = Color.Black;
        // 444    DisplayDrinkModifiers()

    }


    // ********************************************************************
    // Menu
    // ********************************************************************

    private void DisplayMenuSelectionPanel()
    {

        int index;
        // newMenu = New ActiveMenu


        numberOfMenuSelections = GetButtonCount("Menus");
        if (numberOfMenuSelections > 10)
            ;
#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
                       at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
                       at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
                       at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
                       at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
                       at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
                       at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
                       at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
                       at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

                    Input:
                    ReDim menuActive(20)

                     */
        int xMenu = 96;
        int yMenu = 24;
        int yMenuLocation = 5 * buttonSpace;

        menuActiveBox.Size = new Size(xMenu + 8, (yMenu + buttonSpace) * (numberOfMenuSelections + 3) + 5 * buttonSpace);

        if (numberOfMenuSelections > 0)
        {
            var loopTo = numberOfMenuSelections - 1;
            for (index = 0; index <= loopTo; index++)
            {
                menuActive[index] = new CustomCheckBox();
                {
                    var withBlock = menuActive[index];
                    withBlock.Text = dsSetup.Tables("Menus").Rows(index)("MenuName");
                    withBlock.ID = dsSetup.Tables("Menus").Rows(index)("MenuID");
                    if (dsSetup.Tables("Menus").Rows(index)("Active") == true)
                    {
                        menuActive[index].Checked = true;
                    }
                    withBlock.Size = new Size(xMenu, yMenu);
                    withBlock.Location = new Point(buttonSpace, yMenuLocation);

                    menuActive[index].Click += MenuActive_Click;

                }
                menuActiveBox.Controls.Add(menuActive[index]);
                yMenuLocation = yMenuLocation + yMenu + buttonSpace;
            }
        }

        btnMenuAdd.Text = "Enter New Menu";
        btnMenuAdd.Size = new Size(xMenu, 2 * yMenu);
        btnMenuAdd.Location = new Point(buttonSpace, yMenuLocation);
        yMenuLocation = yMenuLocation + 2 * yMenu + buttonSpace;
        txtMenuUpdate.Size = new Size(xMenu, 1.5d * yMenu);
        txtMenuUpdate.Location = new Point(buttonSpace, yMenuLocation);

        menuActiveBox.Controls.Add(btnMenuAdd);
        menuActiveBox.Controls.Add(txtMenuUpdate);

        // Dim pnlMenuUpdate As Panel
        // pnlMenuUpdate.Size = New Size(xMenu + 8, yMenu * 2 + 3 * buttonSpace)


    }

    private void ButtonMenuAdd_Click(object sender, EventArgs e)
    {

        BtnUpdateMenu_Click();
        txtMenuUpdate.Clear();
        newMenu.ActiveMenuID = (object)null;
        newMenu.ActiveMenuName = (object)null;

    }

    private void MenuActive_Click(object sender, EventArgs e)
    {
        var objBox = sender;

        txtMenuUpdate.Text = objBox.text;
        newMenu.ActiveMenuID = objBox.id;
        newMenu.ActiveMenuName = objBox.text;

        updatedMenu = true;

    }

    private void TextMenu_Change(object sender, EventArgs e)
    {
        newMenu.ActiveMenuName = txtMenuUpdate.Text;

        updatedMenu = true;

    }

    private void BtnUpdateMenu_Click() // (ByVal sender As System.Object, ByVal e As System.EventArgs)
    {
        if (this.txtMenuUpdate.Text.Length == 0)
        {
            DataSet_Builder.Information_UC info;
            info = new DataSet_Builder.Information_UC("Please enter a menu name.");
            info.Location = new Point((this.Width - info.Width) / 2, (this.Height - info.Height) / 2);
            this.Controls.Add(info);
            info.BringToFront();
            return;
        }

        DataRow oRow;
        int newMenuID;

        if (newMenu.ActiveMenuID != default)
        {
            foreach (DataRow currentORow in dsSetup.Tables("Menus").Rows)
            {
                oRow = currentORow;
                if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                {
                    if (oRow("MenuID") == newMenu.ActiveMenuID)
                    {
                        oRow("CompanyID") = corpID;
                        oRow("LocationID") = selectedLocation;
                        oRow("MenuName") = newMenu.ActiveMenuName;
                        oRow("LastOrder") = dsSetup.Tables("Menus").Rows.Count;
                        try
                        {
                            sql.cn.Open();
                            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
                            sql.SqlMenuMenuChoice.Update(dsSetup, "Menus");
                            sql.cn.Close();
                            dsSetup.Tables("Menus").AcceptChanges();
                        }
                        catch (Exception ex)
                        {
                            CloseConnection();
                        }

                        UpdateMenuPanel();
                        PopulateMenuSelectionComboBox();
                        DisplayMenuCostGroupBox();

                    }
                }
            }
        }
        else
        {
            oRow = dsSetup.Tables("Menus").NewRow;
            oRow("CompanyID") = corpID;
            oRow("LocationID") = selectedLocation;
            oRow("MenuName") = newMenu.ActiveMenuName;
            oRow("LastOrder") = DBNull.Value; // dsSetup.Tables("Menus").Rows.Count
            oRow("AutoChange") = DBNull.Value;
            oRow("Active") = 1;

            dsSetup.Tables("Menus").Rows.Add(oRow);
            oRow("MenuID") = InsertingNewMenu(ref oRow);
            dsSetup.Tables("Menus").AcceptChanges();

            DisplayMenuSelectionPanel();
            // UpdateNewMenuPanel()
            PopulateMenuSelectionComboBox();
            DisplayMenuCostGroupBox();
        }

    }
    private object InsertingNewMenu(ref DataRow orow)
    {
        var newMenuID = default(int);

        sql.SqlInsertCommandMenuMenuChoice.Parameters("@CompanyID").Value = orow("CompanyID");
        sql.SqlInsertCommandMenuMenuChoice.Parameters("@LocationID").Value = orow("LocationID");
        sql.SqlInsertCommandMenuMenuChoice.Parameters("@MenuName").Value = orow("MenuName");
        sql.SqlInsertCommandMenuMenuChoice.Parameters("@LastOrder").Value = orow("LastOrder");
        sql.SqlInsertCommandMenuMenuChoice.Parameters("@AutoChange").Value = orow("AutoChange");
        sql.SqlInsertCommandMenuMenuChoice.Parameters("@Active").Value = 1;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            newMenuID = (int)sql.SqlInsertCommandMenuMenuChoice.ExecuteScalar();
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        return newMenuID;

    }

    private void UpdateMenuPanel()
    {
        int index;

        var loopTo = numberOfMenuSelections - 1;
        for (index = 0; index <= loopTo; index++)
        {
            if (menuActive[index].ID == newMenu.ActiveMenuID)
            {
                menuActive[index].Text = newMenu.ActiveMenuName;
            }
        }

    }

    private void DisplayMenuPages()
    {

        int btnWidth = 125;
        int btnheight = 35;
        pnlMenuPage1.Size = new System.Drawing.Size(btnWidth + 2 * buttonSpace, 10 * btnheight + 11 * buttonSpace);
        pnlMenuPage2.Size = new System.Drawing.Size(btnWidth + 2 * buttonSpace, 10 * btnheight + 11 * buttonSpace);

        int index;
        int x = buttonSpace;
        int y = buttonSpace;

        for (index = 1; index <= 10; index++)
        {
            btnMenu[index] = new OrderButton();
            {
                var withBlock = btnMenu[index];
                withBlock.Size = new Size(btnWidth, btnheight);
                withBlock.Location = new Point(x, y);
                withBlock.TabStop = false;
                withBlock.BtnIndex = index;
                withBlock.Text = (object)null;
                pnlMenuPage1.Controls.Add(btnMenu[index]);
                btnMenu[index].Click += UpdateMenuOrderIndex;
            }
            y = y + btnheight + buttonSpace;
        }


        y = buttonSpace;
        for (index = 11; index <= 20; index++)
        {
            btnMenu[index] = new OrderButton();
            {
                var withBlock1 = btnMenu[index];
                withBlock1.Size = new Size(btnWidth, btnheight);
                withBlock1.Location = new Point(x, y);
                withBlock1.TabStop = false;
                withBlock1.BtnIndex = index;

                pnlMenuPage2.Controls.Add(btnMenu[index]);
                btnMenu[index].Click += UpdateMenuOrderIndex;
            }
            y = y + btnheight + buttonSpace;
        }

    }

    private void btnMenuBartender_Click(object sender, EventArgs e)
    {

        if (updatedMenu == true)
        {
            SaveMenuChanges();
            updatedMenu = false;
        }

        if (updatedMenuDetail == true)
        {
            SaveMenuDetail();
            updatedMenuDetail = false;
        }

        if (this.bartnerderMenuMode == "Table Service")
        {
            // next is bartender
            // Me.btnMenuBartender.BackColor = Color.Red
            this.bartnerderMenuMode = "Bartender";
            this.btnMenuBartender.Text = "Bartender";

            PopulateMenuSelection();
            AssignNextAvailButton();
        }
        else if (this.bartnerderMenuMode == "Bartender")
        {
            // next is Quick Service
            // Me.btnMenuBartender.BackColor = SystemColors.Desktop
            this.bartnerderMenuMode = "Quick Service";
            this.btnMenuBartender.Text = "Quick Service";

            PopulateMenuSelection();
            AssignNextAvailButton();
        }
        else if (this.bartnerderMenuMode == "Quick Service")
        {
            // next is Table Service
            this.bartnerderMenuMode = "Table Service";
            this.btnMenuBartender.Text = "Table Service";

            PopulateMenuSelection();
            AssignNextAvailButton();
        }

        // If Me.bartnerderMenuMode = False Then
        // Me.btnMenuBartender.BackColor = Color.Red
        // Me.bartnerderMenuMode = True
        // PopulateMenuSelection()
        // AssignNextAvailButton()
        // Else
        // Me.btnMenuBartender.BackColor = SystemColors.Desktop
        // Me.bartnerderMenuMode = False'
        // PopulateMenuSelection()
        // AssignNextAvailButton()
        // End If

    }

    private void cbxMenuSelection_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (updatedMenu == true)
        {
            SaveMenuChanges();
            updatedMenu = false;
        }

        if (updatedMenuDetail == true)
        {
            SaveMenuDetail();
            updatedMenuDetail = false;
        }

        valueMenuID = dsSetup.Tables("Menus").Rows(cbxMenuSelection.SelectedIndex)("MenuID");
        valueMenuName = dsSetup.Tables("Menus").Rows(cbxMenuSelection.SelectedIndex)("MenuName");
        valueMenuActive = dsSetup.Tables("Menus").Rows(cbxMenuSelection.SelectedIndex)("Active");
        if (valueMenuActive == false)
        {
            valueMenuName = valueMenuName + "  ** INACTIVE **";
        }

        PopulateMenuSelection();
        AssignNextAvailButton();

    }

    internal void PopulateMenuSelection()
    {


        string tempCommandStringFoods = sql.SqlSelectCommandMenuMenuFoods.CommandText;
        string tempCommandStringDrinks = sql.SqlSelectCommandMenuMenuDrinks.CommandText;
        int index = 1;

        // not sure about next stmt  ***************
        // newMenu = New ActiveMenu

        dsSetup.Tables("MenuDetail").Clear();

        // sql.SqlSelectCommandMenus.Parameters("@CompanyID").Value = corpID
        if (usingDefaults == true)
        {
            sql.SqlSelectCommandMenuMenuFoods.Parameters("@LocationID").Value = "000000";
            sql.SqlSelectCommandMenuMenuDrinks.Parameters("@LocationID").Value = "000000";
        }

        else
        {
            sql.SqlSelectCommandMenuMenuFoods.Parameters("@LocationID").Value = selectedLocation; // "000000"
            sql.SqlSelectCommandMenuMenuDrinks.Parameters("@LocationID").Value = selectedLocation;

        } // "000000"

        if (this.bartnerderMenuMode == "Table Service")
        {


            sql.SqlSelectCommandMenuMenuFoods.CommandText = sql.SqlSelectCommandMenuMenuFoods.CommandText + " AND MenuDetail.MenuID = '" + valueMenuID + "' ORDER BY MenuDetail.OrderIndex";
            sql.SqlSelectCommandMenuMenuDrinks.CommandText = sql.SqlSelectCommandMenuMenuDrinks.CommandText + " AND MenuDetail.MenuID = '" + valueMenuID + "' ORDER BY MenuDetail.OrderIndex";
        }

        else if (this.bartnerderMenuMode == "Bartender")
        {

            sql.SqlSelectCommandMenuMenuFoods.CommandText = sql.SqlSelectCommandMenuMenuFoods.CommandText + " AND MenuDetail.BartenderMenuID = '" + valueMenuID + "' ORDER BY MenuDetail.OrderIndex";
            sql.SqlSelectCommandMenuMenuDrinks.CommandText = sql.SqlSelectCommandMenuMenuDrinks.CommandText + " AND MenuDetail.BartenderMenuID = '" + valueMenuID + "' ORDER BY MenuDetail.OrderIndex";
        }


        else if (this.bartnerderMenuMode == "Quick Service")
        {

            sql.SqlSelectCommandMenuMenuFoods.CommandText = sql.SqlSelectCommandMenuMenuFoods.CommandText + " AND MenuDetail.QuickMenuID = '" + valueMenuID + "' ORDER BY MenuDetail.OrderIndex";
            sql.SqlSelectCommandMenuMenuDrinks.CommandText = sql.SqlSelectCommandMenuMenuDrinks.CommandText + " AND MenuDetail.QuickMenuID = '" + valueMenuID + "' ORDER BY MenuDetail.OrderIndex";

        }
        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlMenuMenuFoods.Fill(dsSetup.Tables("MenuDetail"));
            sql.SqlMenuMenuDrinks.Fill(dsSetup.Tables("MenuDetail"));

            sql.cn.Close();
            sql.SqlSelectCommandMenuMenuFoods.CommandText = tempCommandStringFoods;
            sql.SqlSelectCommandMenuMenuDrinks.CommandText = tempCommandStringDrinks;
        }
        catch (Exception ex)
        {
            CloseConnection();
        }



        for (index = 1; index <= 20; index++)
        {
            btnMenu[index].Text = (object)null;
            btnMenu[index].BackColor = Color.AliceBlue;
        }

        foreach (DataRow oRow in dsSetup.Tables("MenuDetail").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {

                if (oRow("CategoryID") > 0)
                {
                    btnMenu(oRow("OrderIndex")).Text = oRow("CategoryName").ToString;
                }
                else if (oRow("DrinkCategoryID") > 0)
                {
                    btnMenu(oRow("OrderIndex")).Text = oRow("DrinkCategoryName").ToString;
                }
                else if (oRow("DrinkCategoryID") == -1)
                {
                    btnMenu(oRow("OrderIndex")).Text = "Drinks";
                }
                btnMenu(oRow("OrderIndex")).ID = oRow("MenuDetailID");
                btnMenu(oRow("OrderIndex")).BackColor = c1;
                // index += 1
            }
        }

        newMenu.ActiveMenuID = valueMenuID;
        this.lblMenuSetup.Text = valueMenuName;

        // AssignNextAvailButton()

        // newMenu.dRow = dsSetup.Tables("MenuDetail").Rows(cbxMenuSelection.SelectedIndex)

    }

    private void AssignNextAvailButton()
    {
        int index;

        // this picks next avail open button
        for (index = 1; index <= 20; index++)
        {
            if (btnMenu[index].Text.Length == 0)
            {
                btnMenu[index].BackColor = c1;
                newMenu.ActiveMenuOrderIndex = index;
                break;
            }
        }

        // AddNewMenuRow(newMenu.ActiveMenuOrderIndex)

    }

    private void UpdateMenuOrderIndex(object sender, EventArgs e)
    {
        OrderButton objButton;
        DataRow oRow;
        int index;

        // resets color for non-populated buttons
        for (index = 1; index <= 20; index++)
        {
            if (btnMenu[index].Text.Length == 0)
            {
                btnMenu[index].BackColor = Color.AliceBlue;
            }
        }

        try
        {
            objButton = (OrderButton)sender;

            newMenu.ActiveMenuOrderIndex = objButton.BtnIndex;
            newMenu.ActiveDetialID = objButton.ID;
            objButton.BackColor = c1;
        }

        // For Each oRow In dsSetup.Tables("MenuDetail").Rows
        // If oRow("OrderIndex") = objButton.BtnIndex Then
        // newMenu.dRow = oRow
        // Exit For
        // '         End If
        // Next

        catch (Exception ex)
        {
            return;
        }
    }

    private void AddNewMenuRow(int index, int catID, int drkID)
    {

        DataRow oRow;

        oRow = dsSetup.Tables("MenuDetail").NewRow;
        if (this.bartnerderMenuMode == "Table Service")
        {
            oRow("MenuID") = newMenu.ActiveMenuID;
            oRow("BartenderMenuID") = DBNull.Value;
            oRow("QuickMenuID") = DBNull.Value;
        }

        else if (this.bartnerderMenuMode == "Bartender")
        {
            oRow("MenuID") = DBNull.Value;
            oRow("BartenderMenuID") = newMenu.ActiveMenuID;
            oRow("QuickMenuID") = DBNull.Value;
        }

        else if (this.bartnerderMenuMode == "Quick Service")
        {
            oRow("MenuID") = DBNull.Value;
            oRow("BartenderMenuID") = DBNull.Value;
            oRow("QuickMenuID") = newMenu.ActiveMenuID;
        }

        oRow("CompanyID") = corpID;
        oRow("LocationID") = selectedLocation;
        oRow("CategoryID") = catID;
        oRow("DrinkCategoryID") = drkID;
        oRow("OrderIndex") = index;
        dsSetup.Tables("MenuDetail").Rows.Add(oRow);

    }

    private void UpdateMenuRow(int index, int catID, int drkID)
    {

        foreach (DataRow oRow in dsSetup.Tables("MenuDetail").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached) | !(oRow.RowState == DataRowState.Added))
            {
                if (oRow("MenuDetailID") == newMenu.ActiveDetialID)
                {

                    if (this.bartnerderMenuMode == "Table Service")
                    {
                        oRow("MenuID") = newMenu.ActiveMenuID;
                        oRow("BartenderMenuID") = DBNull.Value;
                        oRow("QuickMenuID") = DBNull.Value;
                    }

                    else if (this.bartnerderMenuMode == "Bartender")
                    {
                        oRow("MenuID") = DBNull.Value;
                        oRow("BartenderMenuID") = newMenu.ActiveMenuID;
                        oRow("QuickMenuID") = DBNull.Value;
                    }

                    else if (this.bartnerderMenuMode == "Quick Service")
                    {
                        oRow("MenuID") = DBNull.Value;
                        oRow("BartenderMenuID") = DBNull.Value;
                        oRow("QuickMenuID") = newMenu.ActiveMenuID;
                    }
                    oRow("CategoryID") = catID;
                    oRow("DrinkCategoryID") = drkID;
                    oRow("OrderIndex") = index;
                    break;
                }
            }
        }

    }

    private void cbxMenuMainFood_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (newMenu.ActiveMenuID == default)
        {
            Interaction.MsgBox("You must First Select a Menu to Design");
            cbxMenuMainFood.SelectedIndex = -1;
            return;
        }
        // ** not using below anymore
        if (newMenu.ActiveMenuOrderIndex == default)
        {
            Interaction.MsgBox("You must first select a Category Button to Update");
            cbxMenuMainFood.SelectedIndex = -1;
            return;
        }

        int valueCatID;
        string valueCatName;

        valueCatID = dvFoodJoinMainFoodsCagtegory(cbxMenuMainFood.SelectedIndex)("CategoryID");
        valueCatName = dvFoodJoinMainFoodsCagtegory(cbxMenuMainFood.SelectedIndex)("CategoryName");

        if (btnMenu(newMenu.ActiveMenuOrderIndex).Text.Length == 0)
        {
            AddNewMenuRow(newMenu.ActiveMenuOrderIndex, valueCatID, 0);
        }
        else if (valueCatID > 0)
        {
            UpdateMenuRow(newMenu.ActiveMenuOrderIndex, valueCatID, 0);
        }

        newMenu.ActiveMenuCategoryID = valueCatID;
        newMenu.ActiveMenuDrinkCategoryID = 0;   // Nothing
        btnMenu(newMenu.ActiveMenuOrderIndex).Text = valueCatName;
        btnMenu(newMenu.ActiveMenuOrderIndex).BackColor = c1;

        // newMenu.dRow("CategoryID") = newMenu.ActiveMenuCategoryID
        // newMenu.dRow("DrinkCategoryID") = newMenu.ActiveMenuDrinkCategoryID

        updatedMenuDetail = true;
        AssignNextAvailButton();

    }

    private void cbxMenuDrink_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (newMenu.ActiveMenuID == default)
        {
            Interaction.MsgBox("You must First Select a Menu to Design");
            cbxMenuDrink.SelectedIndex = -1;
            return;
        }
        // *** not using anymore
        if (newMenu.ActiveMenuOrderIndex == default)
        {
            Interaction.MsgBox("You must first select a Category Button to Update");
            cbxMenuDrink.SelectedIndex = -1;
            return;
        }
        var valueCatID = default(int);
        var valueCatName = default(string);
        var counter = default(int);

        foreach (DataRow oRow in dsSetup.Tables("DrinkCategory").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                if (!object.ReferenceEquals(oRow("DrinkCategoryName"), DBNull.Value))
                {
                    if (counter == this.cbxMenuDrink.SelectedIndex)
                    {
                        valueCatID = oRow("DrinkCategoryID");
                        valueCatName = oRow("DrinkCategoryName");
                        break;
                    }
                    counter += 1;
                }
            }
        }

        if (btnMenu(newMenu.ActiveMenuOrderIndex).Text.Length == 0)
        {
            AddNewMenuRow(newMenu.ActiveMenuOrderIndex, 0, valueCatID);
        }
        else if (valueCatID > 0)
        {
            UpdateMenuRow(newMenu.ActiveMenuOrderIndex, 0, valueCatID);
        }

        newMenu.ActiveMenuDrinkCategoryID = valueCatID;
        newMenu.ActiveMenuCategoryID = 0;    // Nothing

        btnMenu(newMenu.ActiveMenuOrderIndex).Text = valueCatName;
        btnMenu(newMenu.ActiveMenuOrderIndex).BackColor = c1;

        // newMenu.dRow("CategoryID") = newMenu.ActiveMenuCategoryID
        // newMenu.dRow("DrinkCategoryID") = newMenu.ActiveMenuDrinkCategoryID

        updatedMenuDetail = true;
        AssignNextAvailButton();

    }

    private void btnMenuGeneralDrink_Click(object sender, EventArgs e)
    {
        if (newMenu.ActiveMenuID == default)
        {
            Interaction.MsgBox("You must First Select a Menu to Design");
            return;
        }
        if (newMenu.ActiveMenuOrderIndex == default)
        {
            Interaction.MsgBox("You must first select a Category Button to Update");
            return;
        }

        if (btnMenu(newMenu.ActiveMenuOrderIndex).Text.Length == 0)
        {
            AddNewMenuRow(newMenu.ActiveMenuOrderIndex, 0, generalDrinkCategoryID);
        }
        else
        {
            UpdateMenuRow(newMenu.ActiveMenuOrderIndex, 0, generalDrinkCategoryID);
        }

        newMenu.ActiveMenuDrinkCategoryID = generalDrinkCategoryID;
        newMenu.ActiveMenuCategoryID = 0;    // Nothing
        btnMenu(newMenu.ActiveMenuOrderIndex).Text = "Drink";
        btnMenu(newMenu.ActiveMenuOrderIndex).BackColor = c1;

        // newMenu.dRow("CategoryID") = newMenu.ActiveMenuCategoryID
        // newMenu.dRow("DrinkCategoryID") = newMenu.ActiveMenuDrinkCategoryID

        updatedMenuDetail = true;
        AssignNextAvailButton();

    }

    private void SaveMenuDetail()
    {

        // *******************************************
        // might have to keep this one setup like this
        // we pull from 2 different tables
        var adt = new SqlClient.SqlDataAdapter("SELECT CompanyID, LocationID, MenuDetailID, MenuID, BartenderMenuID, QuickMenuID, CategoryID, DrinkCategoryID, OrderIndex FROM MenuDetail", sql.cn); // WHERE MenuID = '" & newMenu.ActiveMenuID & "'", sql.cn)
        var cbd = new SqlClient.SqlCommandBuilder(adt);

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            adt.Update(dsSetup, "MenuDetail");
            sql.cn.Close();

            dsSetup.Tables("MenuDetail").AcceptChanges();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

    }

    private void btnRemoveMenuChoices_Click(object sender, EventArgs e)
    {

        if (newMenu.ActiveMenuID == default)
        {
            Interaction.MsgBox("You must First Select a Menu to Update");
            return;
        }
        if (newMenu.ActiveMenuOrderIndex == default)
        {
            Interaction.MsgBox("You must first select a Category Button to Remove");
            return;
        }

        SaveMenuDetail();
        PopulateMenuSelection();

        foreach (DataRow oRow in dsSetup.Tables("MenuDetail").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                if (this.bartnerderMenuMode == "Table Service")
                {
                    if (oRow("MenuID") == newMenu.ActiveMenuID & oRow("OrderIndex") == newMenu.ActiveMenuOrderIndex)
                    {
                        oRow.Delete();
                        break;
                    }
                }
                else if (this.bartnerderMenuMode == "Bartender")
                {
                    if (oRow("BartenderMenuID") == newMenu.ActiveMenuID & oRow("OrderIndex") == newMenu.ActiveMenuOrderIndex)
                    {
                        oRow.Delete();
                        break;
                    }
                }
            }
            else if (this.bartnerderMenuMode == "Quick Service")
            {

            }
        }

        updatedMenuDetail = true;

        newMenu.ActiveMenuCategoryID = (object)null;
        newMenu.ActiveMenuDrinkCategoryID = (object)null;
        btnMenu(newMenu.ActiveMenuOrderIndex).Text = (object)null;
        btnMenu(newMenu.ActiveMenuOrderIndex).BackColor = Color.White;

    }

    private void TabMenuSetup_Enter(object sender, EventArgs e)
    {

        dvFoodJoinMainFoodsCagtegory = new DataView();
        {
            var withBlock = dvFoodJoinMainFoodsCagtegory;
            withBlock.Table = dsSetup.Tables("MainCategory");
            withBlock.RowFilter = "Active = True AND (FunctionFlag = 'F' OR FunctionFlag = 'O' OR FunctionFlag = 'G')";
            withBlock.Sort = "FunctionID, CategoryOrder";
        }

        this.cbxMenuMainFood.Items.Clear();

        foreach (DataRowView vRow in dvFoodJoinMainFoodsCagtegory)   // dsSetup.Tables("MainCategory").Rows
            this.cbxMenuMainFood.Items.Add(vRow("CategoryName"));

    }

    private void TabMenuSetup_Leave(object sender, EventArgs e)
    {

        if (updatedMenu == true)
        {
            SaveMenuChanges();
            updatedMenu = false;
        }

        if (updatedMenuDetail == true)
        {
            SaveMenuDetail();
            updatedMenuDetail = false;
        }

        dvFoodJoinMainFoodsCagtegory.Dispose();

    }

    private void SaveMenuChanges()
    {

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlMenuMenuChoice.Update(dsSetup, "Menus");
            sql.cn.Close();
            dsSetup.Tables("Menus").AcceptChanges();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

    }

    // ********************************************************
    // Order Categories are for the Food Order By Category


    private void CreateStagingPanel()
    {

        int index = 1;

        for (index = 1; index <= 10; index++)
            DisplayStagingPanelForFoodItem(index, 0, default, "", default);

    }

    private void TabFoodOrder_Enter(object sender, EventArgs e)
    {
        if (!(this.cbxOrderMenuSelection.SelectedIndex == -1))
        {
            cbxOrderMenuSelection_SelectedIndexChanged(sender, e);
        }

    }

    private void cbxOrderMenuSelection_SelectedIndexChanged(object sender, EventArgs e)
    {
        bool valueMenuActive;
        string valueMenuName;

        // '''   ccccc(newFoodOrder.CurrentCategory)

        newFoodOrder = new ActiveFoodOrder();
        if (isOrderQuickService == true)
        {
            newFoodOrder.MorePanels = 60;
        }
        else
        {
            newFoodOrder.MorePanels = 32;
        }

        newFoodOrder.CurrentMenu = dsSetup.Tables("Menus").Rows(this.cbxOrderMenuSelection.SelectedIndex)("MenuID");
        valueMenuActive = dsSetup.Tables("Menus").Rows(cbxOrderMenuSelection.SelectedIndex)("Active");
        valueMenuName = cbxOrderMenuSelection.Text;
        this.cbxOrderSubCategroy.Visible = false;

        if (valueMenuActive == false)
        {
            valueMenuName = valueMenuName + "  ** INACTIVE **";
        }



        // Dim tempCommandString As String = sql.SqlSelectCommandMenus.CommandText
        this.lblOrderMenuName.Text = valueMenuName;
        int index;

        dsSetup.Tables("OrderMenuDetail").Clear();
        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlSelectCommandMenuDetail.Parameters("@CompanyID").Value = corpID;
            if (usingDefaults == true)
            {
                sql.SqlSelectCommandMenuDetail.Parameters("@LocationID").Value = "000000";
            }
            else
            {
                sql.SqlSelectCommandMenuDetail.Parameters("@LocationID").Value = selectedLocation;
            }
            sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "G";
            sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetail"));
            sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "F";
            sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetail"));
            sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "O";
            sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetail"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        this.cbxOrderCategorySelection.Items.Clear();
        foreach (DataRow oRow in dsSetup.Tables("OrderMenuDetail").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                this.cbxOrderCategorySelection.Items.Add(oRow("CategoryName"));
            }
        }
        this.cbxOrderCategorySelection.Text = "Select Category";

        this.lblOrderCategoryName.Text = "";
        this.pnlOrderFoodItems.Controls.Clear();
        ClearTheRestOfStagingPage(1);


        dsSetup.Tables("OrderCategoryDetail").Clear();
        sql.cn.Open();
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
        sql.SqlSelectMenuOrderCategory.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectMenuOrderCategory.Parameters("@LocationID").Value = selectedLocation;
        sql.SqlSelectMenuOrderCategory.Parameters("@MenuID").Value = newFoodOrder.CurrentMenu;
        // sql.SqlSelectCommandCategoryDetail.Parameters("@CategoryID").Value = newFoodOrder.CurrentCategory
        sql.SqlMenuOrderCategory.Fill(dsSetup.Tables("OrderCategoryDetail"));
        sql.cn.Close();

        // newFoodOrder.MaxIndex = dsSetup.Tables("OrderCategoryDetail").Compute("Max(MenuIndex)", "")
        // If newFoodOrder.MaxIndex > 64 Then
        // ReDim foodMenuJoinID(newFoodOrder.MaxIndex + 64)
        // ReDim foodName(newFoodOrder.MaxIndex + 64)
        // ReDim foodPrice(newFoodOrder.MaxIndex + 64)
        // ReDim foodIndex(newFoodOrder.MaxIndex + 64)
        // ReDim foodFoodID(newFoodOrder.MaxIndex + 64)
        // '       ReDim foodSurcharge(newFoodOrder.MaxIndex + 64)
        // '       ReDim foodRoutingID(newFoodOrder.MaxIndex + 64)
        // ReDim foodDrinkID(newFoodOrder.MaxIndex + 64)
        // ReDim foodGeneralMenuID(newFoodOrder.MaxIndex + 64)
        // ReDim foodCurrentMenu(newFoodOrder.MaxIndex + 64)
        // End If

    }

    private void cbxOrderCategorySelection_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.pnlOrderFoodItems.Controls.Clear();

        if (newFoodOrder.CurrentMenu == default)
            return;

        newFoodOrder.CurrentCategory = dsSetup.Tables("OrderMenuDetail").Rows(this.cbxOrderCategorySelection.SelectedIndex)("CategoryID");
        newFoodOrder.FunFlag = dsSetup.Tables("OrderMenuDetail").Rows(this.cbxOrderCategorySelection.SelectedIndex)("FunctionFlag");
        newFoodOrder.ExtendedDisplay = dsSetup.Tables("OrderMenuDetail").Rows(this.cbxOrderCategorySelection.SelectedIndex)("Extended");

        if (newFoodOrder.ExtendedDisplay == true)
        {
            newFoodOrder.MorePanels = 60;
        }
        else
        {
            newFoodOrder.MorePanels = 32;
        }

        if (newFoodOrder.FunFlag == "G")
        {
            // dvCategory = New DataView
            // 444    newFoodOrder.MorePanels = 60
            // 444       Me.pnlOrderFoodItems.Height = 296

            {
                var withBlock = dvCategory;
                withBlock.Table = dsSetup.Tables("OrderCategoryDetail");
                withBlock.RowFilter = "GeneralMenuID = " + newFoodOrder.CurrentCategory;
            }

            // dvDrinkCats = New DataView
            {
                var withBlock1 = dvDrinkCats;
                withBlock1.Table = dsSetup.Tables("DrinkCategory");
                withBlock1.RowFilter = "DrinkCategoryName IS NOT NULL";
            }

            // 444      With dvSubCategory
            // .Table = dsSetup.Tables("OrderMenuDetail")
            // .RowFilter = "NOT FunctionFlag = 'G'"
            // End With

            // 666
            dsSetup.Tables("OrderMenuDetailSecond").Clear();
            try
            {
                sql.cn.Open();
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
                sql.SqlSelectCommandMenuDetail.Parameters("@CompanyID").Value = corpID;
                if (usingDefaults == true)
                {
                    sql.SqlSelectCommandMenuDetail.Parameters("@LocationID").Value = "000000";
                }
                else
                {
                    sql.SqlSelectCommandMenuDetail.Parameters("@LocationID").Value = selectedLocation;
                }
                sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "F";
                sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetailSecond"));
                sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "O";
                sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetailSecond"));
                sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "M";
                sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetailSecond"));
                sql.cn.Close();
            }
            catch (Exception ex)
            {
                CloseConnection();
            }

            newFoodOrder.FunFlagsub = "G";   // resets
            this.cbxOrderSubCategroy.Visible = true;
            this.btnOrderAdd.Visible = false;
            this.btnOrderRemove.Visible = false;

            this.cbxOrderSubCategroy.Items.Clear();
            foreach (DataRow oRow in dsSetup.Tables("OrderMenuDetailSecond").Rows)
            {
                if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                {
                    this.cbxOrderSubCategroy.Items.Add(oRow("CategoryName"));
                }
            }
            // For Each vRow In dvSubCategory
            // Me.cbxOrderSubCategroy.Items.Add(vRow("CategoryName"))
            // Next
            foreach (DataRowView vRow in dvDrinkCats)
                this.cbxOrderSubCategroy.Items.Add(vRow("DrinkCategoryName"));

            this.cbxOrderSubCategroy.Text = "Select Sub Category";

            PopulateCategoryDetail();
        }
        // PopulateSubOrderDataFromTable()
        // PopulateSubCategoryDetail()
        else
        {
            // 444    newFoodOrder.MorePanels = 32
            // 444         Me.pnlOrderFoodItems.Height = 376
            this.cbxOrderSubCategroy.Visible = false;
            // Me.btnOrderAdd.Visible = True
            // Me.btnOrderRemove.Visible = True
            this.lblOrderCategoryName.Text = cbxOrderCategorySelection.Text;
            newFoodOrder.CatIsDrink = false;

            PopulateCategoryDetail();
        }

    }

    private void PopulateCategoryDetail()
    {
        newFoodOrderStagingIndex = 0;

        // dsSetup.Tables("OrderCategoryDetail").Clear()
        // sql.cn.Open()
        // sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        // sql.SqlSelectCommandCategoryDetail.Parameters("@CompanyID").Value = corpID
        // sql.SqlSelectCommandCategoryDetail.Parameters("@LocationID").Value = selectedLocation
        // sql.SqlSelectCommandCategoryDetail.Parameters("@MenuID").Value = newFoodOrder.CurrentMenu
        // '     sql.SqlSelectCommandCategoryDetail.Parameters("@CategoryID").Value = newFoodOrder.CurrentCategory
        // sql.SqlMenuCategoryDetail.Fill(dsSetup.Tables("OrderCategoryDetail"))
        // sql.cn.Close()

        int index;
        int stagingPosition = 1;
        newFoodOrder.PageIndex = 1;
        // newFoodOrder.MaxIndex = dsSetup.Tables("OrderCategoryDetail").Compute("Max(MenuIndex)", "")

        // ReDim foodMenuJoinID(newFoodOrder.MaxIndex + 64)
        // ReDim foodName(newFoodOrder.MaxIndex + 64)
        // ReDim foodPrice(newFoodOrder.MaxIndex + 64)
        // ReDim foodIndex(newFoodOrder.MaxIndex + 64)
        CreateStagingDataView();
        CreateOrderDataViews();

        if (dvOrderMenu.Count > 0)
        {
            newFoodOrder.MaxIndex = dvOrderMenu(dvOrderMenu.Count - 1)("MenuIndex");
        }
        else
        {
            newFoodOrder.MaxIndex = 0;

            // If newFoodOrder.MaxIndex > 64 Then
        };
#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
           at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

        Input:

                '     If newFoodOrder.MaxIndex > 64 Then
                ReDim foodMenuJoinID(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)

         */
        ;
#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
           at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

        Input:
                ReDim foodName(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)

         */
        ;
#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
           at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

        Input:
                ReDim foodPrice(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)

         */
        ;
#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
           at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

        Input:
                ReDim foodIndex(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)

         */
        ;
#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
           at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

        Input:
                ReDim foodFoodID(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)

         */
        ;
#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
           at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

        Input:
                ReDim foodSurcharge(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)

         */
        ;
#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
           at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

        Input:
                ReDim foodRoutingID(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)

         */
        ;
#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
           at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

        Input:
                ReDim foodDrinkID(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)

         */
        ;
#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
           at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
           at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

        Input:
                ReDim foodGeneralMenuID(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)

         */
        ;
        // End If

#error Cannot convert ReDimStatementSyntax - see comment for details
        /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
                   at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
                   at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
                   at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
                   at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
                   at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
                   at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
                   at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
                   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

                Input:
                        ReDim foodCurrentMenu(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)

                 */
        PopulateOrderDataFromTable();
        DisplayCategoryPage(newFoodOrder.PageIndex);
        DisplayStagingPage(newFoodOrderStagingIndex);       // 1 is for the start (might be 0)?

    }


    private void cbxOrderSubCategroy_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (newFoodOrder.CurrentMenu == default)
            return;

        // "OrderMenuDetail" needs to include drink categories too
        if (this.cbxOrderSubCategroy.SelectedIndex > dsSetup.Tables("OrderMenuDetailSecond").Rows.Count - 1) // (dsSetup.Tables("OrderMenuDetail").Rows.Count - 1) Then
        {
            newFoodOrder.CatIsDrink = true;
            newFoodOrder.CurrentCategorySub = dvDrinkCats(this.cbxOrderSubCategroy.SelectedIndex - dsSetup.Tables("OrderMenuDetailSecond").Rows.Count)("DrinkCategoryID");
            newFoodOrder.FunFlagsub = "D";
        }
        else
        {
            newFoodOrder.CatIsDrink = false;
            newFoodOrder.CurrentCategorySub = dsSetup.Tables("OrderMenuDetailSecond").Rows(this.cbxOrderSubCategroy.SelectedIndex)("CategoryID");
            newFoodOrder.FunFlagsub = dsSetup.Tables("OrderMenuDetailSecond").Rows(this.cbxOrderSubCategroy.SelectedIndex)("FunctionFlag");

        }

        if (newFoodOrder.FunFlagsub == "G")
        {
            PopulateSubCategoryDetail();
            return;
        }
        else
        {
            this.lblOrderCategoryName.Text = cbxOrderSubCategroy.Text;

            PopulateSubCategoryDetail();
        }

    }


    private void PopulateSubCategoryDetail()
    {

        newFoodOrderStagingIndex = 0;

        // dsSetup.Tables("OrderCategoryDetail").Clear()
        // dsSetup.Tables("OrderAllMenuDetail").Clear()
        // sql.cn.Open()
        // sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        // sql.SqlSelectCommandCategoryDetail.Parameters("@CompanyID").Value = corpID
        // sql.SqlSelectCommandCategoryDetail.Parameters("@LocationID").Value = selectedLocation
        // sql.SqlSelectCommandCategoryDetail.Parameters("@MenuID").Value = newFoodOrder.CurrentMenu
        // sql.SqlSelectCommandCategoryDetail.Parameters("@CategoryID").Value = newFoodOrder.CurrentCategorySub
        // sql.SqlMenuCategoryDetail.Fill(dsSetup.Tables("OrderCategoryDetail"))
        // 
        // sql.SqlSelectCommandOrderAllMenuDetail.Parameters("@CompanyID").Value = corpID
        // sql.SqlSelectCommandOrderAllMenuDetail.Parameters("@LocationID").Value = selectedLocation
        // sql.SqlSelectCommandOrderAllMenuDetail.Parameters("@MenuID").Value = newFoodOrder.CurrentMenu
        // '       '     sql.SqlSelectCommandOrderAllMenuDetail.Parameters("@CategoryID").Value = newFoodOrder.CurrentCategorySub
        // sql.SqlMenuOrderAllMenuDetail.Fill(dsSetup.Tables("OrderAllMenuDetail"))
        // sql.cn.Close()

        // Dim index As Integer
        // Dim stagingPosition As Integer = 1
        // newFoodOrder.PageIndex = 1
        // newFoodOrder.MaxIndex = dsSetup.Tables("OrderCategoryDetail").Compute("Max(MenuIndex)", "")

        // ReDim foodMenuJoinID(newFoodOrder.MaxIndex + 64)
        // ReDim foodName(newFoodOrder.MaxIndex + 64)
        // ReDim foodPrice(newFoodOrder.MaxIndex + 64)
        // ReDim foodIndex(newFoodOrder.MaxIndex + 64)


        // PopulateSubOrderDataFromTable()

        CreateStagingDataView();
        // PopulateOrderDataFromTable()
        // DisplayCategoryPage(newFoodOrder.PageIndex)
        DisplayStagingPage(newFoodOrderStagingIndex);       // 1 is for the start (might be 0)?

    }



    private void PopulateOrderDataFromTable()
    {
        int i;

        // this can be more effiecient
        var loopTo = newFoodOrder.MaxIndex + newFoodOrder.MorePanels;
        for (i = 0; i <= loopTo; i++)
        {
            foodMenuJoinID[i] = (object)null;
            foodName[i] = "";
            foodPrice[i] = (object)null;
            foodIndex[i] = (object)null;
            foodFoodID[i] = (object)null;
            foodSurcharge[i] = (object)null;
            foodRoutingID[i] = (object)null;
            foodDrinkID[i] = (object)null;
            foodGeneralMenuID[i] = (object)null;
            foodCurrentMenu[i] = (object)null;

        }


        // change this to for 1 to 32 type of for stmt, 32 to 62 for 2nd page...
        foreach (DataRowView oRow in dvOrderMenu) // dsSetup.Tables("OrderCategoryDetail").Rows
        {
            // If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
            foodMenuJoinID(oRow("MenuIndex")) = oRow("MenuJoinID");
            foodPrice(oRow("MenuIndex")) = oRow("Price");

            if (!object.ReferenceEquals(oRow("FoodID"), DBNull.Value) & !(oRow("FoodID") == 0))
            {
                // If oRow("AbrevFoodName") Is DBNull.Value Then
                // MsgBox(oRow("FoodID"))
                // End If
                foodName(oRow("MenuIndex")) = oRow("AbrevFoodName");
                foodFoodID(oRow("MenuIndex")) = oRow("FoodID");
                foodDrinkID(oRow("MenuIndex")) = (object)null;
            }
            else
            {
                foodName(oRow("MenuIndex")) = oRow("DrinkName");
                foodFoodID(oRow("MenuIndex")) = (object)null;
                foodDrinkID(oRow("MenuIndex")) = oRow("DrinkID");
            }
            if (!object.ReferenceEquals(oRow("Surcharge"), DBNull.Value))
            {
                foodSurcharge(oRow("MenuIndex")) = oRow("Surcharge");
            }
            else
            {
                foodSurcharge(oRow("MenuIndex")) = (object)null;
            }
            if (!object.ReferenceEquals(oRow("RoutingID"), DBNull.Value))
            {
                foodRoutingID(oRow("MenuIndex")) = oRow("RoutingID");
            }
            else
            {
                foodRoutingID(oRow("MenuIndex")) = (object)null;
            }
            if (!object.ReferenceEquals(oRow("GeneralMenuID"), DBNull.Value))
            {
                foodGeneralMenuID(oRow("MenuIndex")) = oRow("GeneralMenuID");
            }
            else
            {
                foodGeneralMenuID(oRow("MenuIndex")) = (object)null;
            }

            if (!object.ReferenceEquals(oRow("MenuID"), DBNull.Value))
            {
                foodCurrentMenu(oRow("MenuIndex")) = oRow("MenuID");
            }
            else
            {
                foodCurrentMenu(oRow("MenuIndex")) = (object)null;
            }

            if (oRow("MenuIndex") > 0)
            {
                foodIndex(oRow("MenuIndex")) = oRow("MenuIndex");
            }
            // End If
        }

    }

    private void PopulateSubOrderDataFromTable()
    {
        DataRow dRow;
        // change this to for 1 to 32 type of for stmt, 32 to 62 for 2nd page...

        // dsSetup.Tables("OrderAllMenuDetail").Clear()
        // sql.cn.Open()
        // sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
        // sql.SqlSelectCommandOrderAllMenuDetail.Parameters("@CompanyID").Value = corpID
        // sql.SqlSelectCommandOrderAllMenuDetail.Parameters("@LocationID").Value = selectedLocation
        // sql.SqlSelectCommandOrderAllMenuDetail.Parameters("@MenuID").Value = newFoodOrder.CurrentMenu
        // '     '     sql.SqlSelectCommandOrderAllMenuDetail.Parameters("@CategoryID").Value = newFoodOrder.CurrentCategorySub
        // sql.SqlMenuOrderAllMenuDetail.Fill(dsSetup.Tables("OrderAllMenuDetail"))
        // sql.cn.Close()

        foreach (DataRow oRow in dsSetup.Tables("OrderAllMenuDetail").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                foodMenuJoinID(oRow("MenuIndex")) = oRow("MenuJoinID");
                foodName(oRow("MenuIndex")) = oRow("AbrevFoodName");
                foodPrice(oRow("MenuIndex")) = oRow("Price");
                foodBackColor(oRow("MenuIndex")) = oRow("ButtonColor");
                foodForeColor(oRow("MenuIndex")) = oRow("ButtonForeColor");

                if (oRow("MenuIndex") > 0)
                {
                    foodIndex(oRow("MenuIndex")) = oRow("MenuIndex");
                }
            }
        }

    }

    private void DisplayCategoryPage(int pageNumber)
    {
        int index;
        var startPosition = default(int);
        var stopPosition = default(int);
        int numPanels;
        int position = 1;     // position is actual panel (so always between 1 and 32)
        this.pnlOrderFoodItems.Controls.Clear();

        // 444       If Me.isOrderQuickService = True Then
        // numPanels = 59
        // Else
        // numPanels = 31
        // End If
        numPanels = newFoodOrder.MorePanels - 1;

        if (pageNumber == 1)
        {
            startPosition = 1;
            stopPosition = startPosition + numPanels;
        }
        else if (pageNumber > 1)
        {
            startPosition = (pageNumber - 1) * (numPanels + 1) + 1;   // this increases it by 30 every page
            stopPosition = startPosition + numPanels;
        }
        // resets any next or previous panels
        // DisplayOrderCategories(1, 1, Nothing, "", Nothing)
        // DisplayOrderCategories((numPanels + 1), 1, Nothing, "", Nothing)

        this.pnlOrderFoodItems.SuspendLayout();
        int mi;

        var loopTo = stopPosition;
        for (index = startPosition; index <= loopTo; index++)
        {
            // If index = 32 Then
            // MsgBox(index)
            // End If

            mi = (newFoodOrder.PageIndex - 1) * (numPanels + 1) + position;
            if (pageNumber > 1 & index == startPosition)
            {
                DisplayOrderCategories(1, mi, -1, "Previous", default, default, default, default, default, default, default);
            }

            else if (index == stopPosition & newFoodOrder.MaxIndex > index & isOrderQuickService == false)
            {
                // this is the last panel on page 
                // must add 1 b/c the 1st of next page is the same as the last of this page
                DisplayOrderCategories(numPanels + 1, mi, -2, "Next", default, default, default, default, default, default, default);
            }
            // DisplayDummyPanel(32, "Next")

            else if (foodIndex[index] > 0)        // will always be this for quick service and full page
            {
                // 444   If newFoodOrder.MorePanels = 60 Then
                if (newFoodOrder.FunFlag == "G")
                {
                    DisplayOrderCategories(position, mi, foodMenuJoinID[index], foodName[index], foodPrice[index], foodFoodID[index], foodSurcharge[index], foodRoutingID[index], foodDrinkID[index], newFoodOrder.CurrentCategory, foodCurrentMenu[index]);
                }
                else
                {
                    DisplayOrderCategories(position, mi, foodMenuJoinID[index], foodName[index], foodPrice[index], foodFoodID[index], foodSurcharge[index], foodRoutingID[index], foodDrinkID[index], 0, foodCurrentMenu[index]);
                }
            }
            else
            {
                // this might be the same as above : foodname is nothing if foodindex = 0
                DisplayOrderCategories(position, mi, default, "", default, default, default, default, default, newFoodOrder.CurrentCategory, default);
            }

            position += 1;
        }

        this.pnlOrderFoodItems.ResumeLayout();

    }

    private void DisplayOrderCategories(int position, int Index, int menuJoinId, string name, decimal price, int fID, decimal sur, int rout, int dID, int GenMenuID, int cm)
    {
        float w;
        float h;
        string dTable; // = "OrderCategoryDetail"

        // 444     If isOrderQuickService = False Then
        // dTable = "OrderCategoryDetail"
        // Else
        // dTable = "Quick"
        // End If

        if (newFoodOrder.MorePanels == 60)
        {
            dTable = "Quick";
            w = (this.pnlOrderFoodItems.Width - 17) / 6;
            h = (this.pnlOrderFoodItems.Height - 33) / 10;
        }
        else
        {
            dTable = "OrderCategoryDetail";
            w = (this.pnlOrderFoodItems.Width - 15) / 4;
            h = (this.pnlOrderFoodItems.Height - 27) / 8;
        }

        switch (position)
        {
            case 1:
                {
                    foodOrderPanel1 = new FoodOrderPanel(cs1, cs2, 1, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel1);
                    break;
                }
            case 2:
                {
                    foodOrderPanel2 = new FoodOrderPanel(cs1, cs2, 2, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel2);
                    break;
                }
            case 3:
                {
                    foodOrderPanel3 = new FoodOrderPanel(cs1, cs2, 3, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel3);
                    break;
                }
            case 4:
                {
                    foodOrderPanel4 = new FoodOrderPanel(cs1, cs2, 4, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel4);
                    break;
                }
            case 5:
                {
                    foodOrderPanel5 = new FoodOrderPanel(cs1, cs2, 5, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel5);
                    break;
                }
            case 6:
                {
                    foodOrderPanel6 = new FoodOrderPanel(cs1, cs2, 6, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel6);
                    break;
                }
            case 7:
                {
                    foodOrderPanel7 = new FoodOrderPanel(cs1, cs2, 7, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel7);
                    break;
                }
            case 8:
                {
                    foodOrderPanel8 = new FoodOrderPanel(cs1, cs2, 8, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel8);
                    break;
                }
            case 9:
                {
                    foodOrderPanel9 = new FoodOrderPanel(cs1, cs2, 9, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel9);
                    break;
                }
            case 10:
                {
                    foodOrderPanel10 = new FoodOrderPanel(cs1, cs2, 10, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel10);
                    break;
                }
            case 11:
                {
                    foodOrderPanel11 = new FoodOrderPanel(cs1, cs2, 11, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel11);
                    break;
                }
            case 12:
                {
                    foodOrderPanel12 = new FoodOrderPanel(cs1, cs2, 12, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel12);
                    break;
                }
            case 13:
                {
                    foodOrderPanel13 = new FoodOrderPanel(cs1, cs2, 13, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel13);
                    break;
                }
            case 14:
                {
                    foodOrderPanel14 = new FoodOrderPanel(cs1, cs2, 14, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel14);
                    break;
                }
            case 15:
                {
                    foodOrderPanel15 = new FoodOrderPanel(cs1, cs2, 15, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel15);
                    break;
                }
            case 16:
                {
                    foodOrderPanel16 = new FoodOrderPanel(cs1, cs2, 16, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel16);
                    break;
                }
            case 17:
                {
                    foodOrderPanel17 = new FoodOrderPanel(cs1, cs2, 17, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel17);
                    break;
                }
            case 18:
                {
                    foodOrderPanel18 = new FoodOrderPanel(cs1, cs2, 18, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel18);
                    break;
                }
            case 19:
                {
                    foodOrderPanel19 = new FoodOrderPanel(cs1, cs2, 19, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel19);
                    break;
                }
            case 20:
                {
                    foodOrderPanel20 = new FoodOrderPanel(cs1, cs2, 20, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel20);
                    break;
                }
            case 21:
                {
                    foodOrderPanel21 = new FoodOrderPanel(cs1, cs2, 21, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel21);
                    break;
                }
            case 22:
                {
                    foodOrderPanel22 = new FoodOrderPanel(cs1, cs2, 22, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel22);
                    break;
                }
            case 23:
                {
                    foodOrderPanel23 = new FoodOrderPanel(cs1, cs2, 23, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel23);
                    break;
                }
            case 24:
                {
                    foodOrderPanel24 = new FoodOrderPanel(cs1, cs2, 24, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel24);
                    break;
                }
            case 25:
                {
                    foodOrderPanel25 = new FoodOrderPanel(cs1, cs2, 25, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel25);
                    break;
                }
            case 26:
                {
                    foodOrderPanel26 = new FoodOrderPanel(cs1, cs2, 26, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel26);
                    break;
                }
            case 27:
                {
                    foodOrderPanel27 = new FoodOrderPanel(cs1, cs2, 27, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel27);
                    break;
                }
            case 28:
                {
                    foodOrderPanel28 = new FoodOrderPanel(cs1, cs2, 28, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel28);
                    break;
                }
            case 29:
                {
                    foodOrderPanel29 = new FoodOrderPanel(cs1, cs2, 29, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel29);
                    break;
                }
            case 30:
                {
                    foodOrderPanel30 = new FoodOrderPanel(cs1, cs2, 30, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel30);
                    break;
                }
            case 31:
                {
                    foodOrderPanel31 = new FoodOrderPanel(cs1, cs2, 31, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel31);
                    break;
                }
            case 32:
                {
                    foodOrderPanel32 = new FoodOrderPanel(cs1, cs2, 32, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel32);
                    break;
                }
            case 33:
                {
                    foodOrderPanel33 = new FoodOrderPanel(cs1, cs2, 33, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel33);
                    break;
                }
            case 34:
                {
                    foodOrderPanel34 = new FoodOrderPanel(cs1, cs2, 34, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel34);
                    break;
                }
            case 35:
                {
                    foodOrderPanel35 = new FoodOrderPanel(cs1, cs2, 35, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel35);
                    break;
                }
            case 36:
                {
                    foodOrderPanel36 = new FoodOrderPanel(cs1, cs2, 36, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel36);
                    break;
                }
            case 37:
                {
                    foodOrderPanel37 = new FoodOrderPanel(cs1, cs2, 37, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel37);
                    break;
                }
            case 38:
                {
                    foodOrderPanel38 = new FoodOrderPanel(cs1, cs2, 38, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel38);
                    break;
                }
            case 39:
                {
                    foodOrderPanel39 = new FoodOrderPanel(cs1, cs2, 39, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel39);
                    break;
                }
            case 40:
                {
                    foodOrderPanel40 = new FoodOrderPanel(cs1, cs2, 40, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel40);
                    break;
                }
            case 41:
                {
                    foodOrderPanel41 = new FoodOrderPanel(cs1, cs2, 41, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel41);
                    break;
                }
            case 42:
                {
                    foodOrderPanel42 = new FoodOrderPanel(cs1, cs2, 42, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel42);
                    break;
                }
            case 43:
                {
                    foodOrderPanel43 = new FoodOrderPanel(cs1, cs2, 43, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel43);
                    break;
                }
            case 44:
                {
                    foodOrderPanel44 = new FoodOrderPanel(cs1, cs2, 44, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel44);
                    break;
                }
            case 45:
                {
                    foodOrderPanel45 = new FoodOrderPanel(cs1, cs2, 45, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel45);
                    break;
                }
            case 46:
                {
                    foodOrderPanel46 = new FoodOrderPanel(cs1, cs2, 46, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel46);
                    break;
                }
            case 47:
                {
                    foodOrderPanel47 = new FoodOrderPanel(cs1, cs2, 47, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel47);
                    break;
                }
            case 48:
                {
                    foodOrderPanel48 = new FoodOrderPanel(cs1, cs2, 48, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel48);
                    break;
                }
            case 49:
                {
                    foodOrderPanel49 = new FoodOrderPanel(cs1, cs2, 49, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel49);
                    break;
                }
            case 50:
                {
                    foodOrderPanel50 = new FoodOrderPanel(cs1, cs2, 50, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel50);
                    break;
                }
            case 51:
                {
                    foodOrderPanel51 = new FoodOrderPanel(cs1, cs2, 51, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel51);
                    break;
                }
            case 52:
                {
                    foodOrderPanel52 = new FoodOrderPanel(cs1, cs2, 52, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel52);
                    break;
                }
            case 53:
                {
                    foodOrderPanel53 = new FoodOrderPanel(cs1, cs2, 53, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel53);
                    break;
                }
            case 54:
                {
                    foodOrderPanel54 = new FoodOrderPanel(cs1, cs2, 54, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel54);
                    break;
                }
            case 55:
                {
                    foodOrderPanel55 = new FoodOrderPanel(cs1, cs2, 55, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel55);
                    break;
                }
            case 56:
                {
                    foodOrderPanel56 = new FoodOrderPanel(cs1, cs2, 56, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel56);
                    break;
                }
            case 57:
                {
                    foodOrderPanel57 = new FoodOrderPanel(cs1, cs2, 57, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel57);
                    break;
                }
            case 58:
                {
                    foodOrderPanel58 = new FoodOrderPanel(cs1, cs2, 58, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel58);
                    break;
                }
            case 59:
                {
                    foodOrderPanel59 = new FoodOrderPanel(cs1, cs2, 59, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel59);
                    break;
                }
            case 60:
                {
                    foodOrderPanel60 = new FoodOrderPanel(cs1, cs2, 60, w, h, Index, menuJoinId, name, price, false, dTable, fID, sur, rout, dID, GenMenuID, cm);
                    this.pnlOrderFoodItems.Controls.Add(foodOrderPanel60);
                    break;
                }

        }

    }

    private void CreateStagingDataView()
    {

        if (newFoodOrder.FunFlag == "G")
        {
            if (newFoodOrder.FunFlagsub == "G")
            {
                // this resets staging or beginning of general menu
                {
                    var withBlock = dvOrderStaging;
                    withBlock.Table = dsSetup.Tables("OrderCategoryDetail");
                    withBlock.RowFilter = "MenuIndex = 0 AND GeneralMenuID = " + newFoodOrder.CurrentCategory;
                    withBlock.RowStateFilter = DataViewRowState.CurrentRows;
                }
            }
            else
            {
                // fills staging with current sub category
                {
                    var withBlock1 = dvOrderStaging;

                    if (newFoodOrder.CatIsDrink == true)
                    {
                        withBlock1.Table = dsSetup.Tables("Drinks");
                        withBlock1.RowFilter = "DrinkCategoryID = " + newFoodOrder.CurrentCategorySub; // & " AND (GeneralMenuID IS NULL OR NOT GeneralMenuID = " & newFoodOrder.CurrentCategory & ")"
                    }
                    else if (newFoodOrder.FunFlag == "G")
                    {
                        // 
                        withBlock1.Table = dsSetup.Tables("OrderCategoryDetail");
                        // .RowFilter = "MenuIndex = 0 AND CategoryID = " & newFoodOrder.CurrentCategorySub
                        // .RowFilter = "CategoryID = '" & newFoodOrder.CurrentCategorySub & "' AND MenuIndex = 0 AND GeneralMenuID = '" & newFoodOrder.CurrentCategory & "'"
                        withBlock1.RowFilter = "CategoryID = " + newFoodOrder.CurrentCategorySub + " AND (GeneralMenuID IS NULL OR GeneralMenuID = " + newFoodOrder.CurrentCategory + ")";
                        withBlock1.Sort = "GeneralMenuID DESC";
                    }
                    // we are populating all without MenuIndex, but then later removing any dupolicated
                    // we must sort b/c we need to make sure we are dealing with the General Menu ID first
                    // we may have a foodItem w/o GMI and then we use this, this creates a entry with GMI
                    else
                    {
                        // will never be here, this whole section is Sub under "G" Flag
                        withBlock1.Table = dsSetup.Tables("OrderCategoryDetail");
                        withBlock1.RowFilter = "CategoryID = " + newFoodOrder.CurrentCategorySub + " AND (GeneralMenuID IS NULL OR NOT GeneralMenuID = " + newFoodOrder.CurrentCategory + ")";

                    }
                    // .RowFilter = "NOT GeneralMenuID = " & newFoodOrder.CurrentCategory
                    // .RowFilter = "MenuIndex = 0 AND CategoryID = " & newFoodOrder.CurrentCategorySub
                    withBlock1.RowStateFilter = DataViewRowState.CurrentRows;
                }
                // 999 new, this is what is already displaying
                {
                    var withBlock2 = dvCategory;
                    withBlock2.Table = dsSetup.Tables("OrderCategoryDetail");
                    // .RowFilter = "(MenuIndex > 0 AND GeneralMenuID = " & newFoodOrder.CurrentCategory & ") OR GeneralMenuID IS NULL"
                    withBlock2.RowFilter = "CategoryID = " + newFoodOrder.CurrentCategorySub + " AND MenuIndex > 0 AND GeneralMenuID = '" + newFoodOrder.CurrentCategory + "'";
                    // .RowFilter = "CategoryID = " & newFoodOrder.CurrentCategorySub & " AND MenuIndex > 0"
                }
            }
        }

        else
        {
            // fills staging with current category
            {
                var withBlock3 = dvOrderStaging;
                withBlock3.Table = dsSetup.Tables("OrderCategoryDetail");
                withBlock3.RowFilter = "MenuIndex = 0 AND GeneralMenuID IS NULL AND CategoryID = " + newFoodOrder.CurrentCategory;
                withBlock3.RowStateFilter = DataViewRowState.CurrentRows;
            }
        }

    }

    private void CreateOrderDataViews()
    {

        if (newFoodOrder.FunFlag == "G")
        {
            {
                var withBlock = dvOrderMenu;
                withBlock.Table = dsSetup.Tables("OrderCategoryDetail");
                withBlock.RowFilter = "MenuIndex > 0 AND GeneralMenuID = " + newFoodOrder.CurrentCategory;
                withBlock.RowStateFilter = DataViewRowState.CurrentRows;
                withBlock.Sort = "MenuIndex";
            }
        }
        else
        {
            {
                var withBlock1 = dvOrderMenu;
                withBlock1.Table = dsSetup.Tables("OrderCategoryDetail");
                withBlock1.RowFilter = "MenuIndex > 0 AND GeneralMenuID IS NULL AND CategoryID = " + newFoodOrder.CurrentCategory;
                withBlock1.RowStateFilter = DataViewRowState.CurrentRows;
                withBlock1.Sort = "MenuIndex";
            }
        }

    }

    private void DisplayStagingPanelForFoodItem(int position, int Index, int menuJoinID, string name, decimal price)
    {
        float w = this.pnlOrderFoodStaging.Width - 6;      // spacing is 3 
        float h = (this.pnlOrderFoodStaging.Height - 33) / 10;
        string dTable = "OrderCategoryDetail";

        // currently just displaying empty panels??????
        foodOrderStaging[position] = new FoodOrderPanel(cs1, cs2, position, w, h, Index, menuJoinID, name, price, true, dTable, (object)null, (object)null, (object)null, (object)null, (object)null, (object)null);
        foodOrderStaging[position].BlankOldModifierPanel += OrderMouseMove;

        this.pnlOrderFoodStaging.Controls.Add(foodOrderStaging[position]);

    }

    private void DisplayStagingPage(int dvIndex)
    {

        // go through each vRow as Dataview
        int dvCounter;
        int position = 1;
        int dvEnd = dvIndex + 7;
        DataRowView vRow;
        DataRowView cRow;
        bool isAlreadyDisplayed;
        var foodIDIndex = new ArrayList();

        if (dvIndex > 0)
        {
            // this is for GMI, so we don't repeat them,
            // they are sorted with GMI > 0 at top
            var loopTo = dvIndex - 1;
            for (dvCounter = 0; dvCounter <= loopTo; dvCounter++)
            {
                // for food only
                if (newFoodOrder.CatIsDrink == false)
                {
                    vRow = dvOrderStaging[dvCounter];
                    foodIDIndex.Add(vRow("FoodID"));
                }
            }
        }

        // dvcouter is zero based
        // 444    For dvCounter = dvIndex To dvEnd
        // 444If dvCounter + 1 > dvOrderStaging.Count Then Exit For

        var loopTo1 = dvOrderStaging.Count - 1;
        for (dvCounter = dvIndex; dvCounter <= loopTo1; dvCounter++) // dvEnd
        {
            if (position > 8)
                break;


            vRow = dvOrderStaging[dvCounter];
            isAlreadyDisplayed = false;

            if (newFoodOrder.CatIsDrink == true)
            {
                if (!object.ReferenceEquals(vRow("DrinkID"), DBNull.Value))
                {
                    if (newFoodOrder.FunFlag == "G")
                    {
                        // skip if already displayed
                        foreach (DataRowView currentCRow in dvCategory)
                        {
                            cRow = currentCRow;
                            if (!object.ReferenceEquals(cRow("DrinkID"), DBNull.Value))
                            {
                                if (vRow("DrinkID") == cRow("DrinkID"))
                                {
                                    isAlreadyDisplayed = true;
                                }
                            }
                        }
                    }

                    if (isAlreadyDisplayed == false)
                    {
                        if (newFoodOrder.FunFlag == "G")
                        {
                            foodOrderStaging[position].UpdateStagingPanel(0, vRow("DrinkName"), vRow("DrinkPrice"), default, default, default, vRow("DrinkID"), newFoodOrder.CurrentCategory, newFoodOrder.CurrentMenu);
                        }
                        else
                        {
                            foodOrderStaging[position].UpdateStagingPanel(0, vRow("DrinkName"), vRow("DrinkPrice"), default, default, default, vRow("DrinkID"), 0, newFoodOrder.CurrentMenu);
                        }
                        position += 1;
                    }
                }
            }

            else if (!object.ReferenceEquals(vRow("FoodID"), DBNull.Value))
            {
                if (newFoodOrder.FunFlag == "G")
                {
                    // skip if already displayed
                    foreach (DataRowView currentCRow1 in dvCategory)
                    {
                        cRow = currentCRow1;
                        if (!object.ReferenceEquals(cRow("FoodID"), DBNull.Value))
                        {
                            if (vRow("FoodID") == cRow("FoodID"))
                            {
                                isAlreadyDisplayed = true;
                            }
                        }
                    }
                    // does the same thing, but this one works better 
                    // for General Menu ID (b/c we need to display specific MenuJoinID
                    foreach (int fID in foodIDIndex)
                    {
                        if (vRow("FoodID") == fID)
                        {
                            isAlreadyDisplayed = true;
                        }
                    }
                }

                if (isAlreadyDisplayed == false)
                {
                    foodIDIndex.Add(vRow("FoodID"));

                    if (newFoodOrder.FunFlag == "G")
                    {
                        foodOrderStaging[position].UpdateStagingPanel(vRow("MenuJoinID"), vRow("FoodName"), vRow("Price"), vRow("FoodID"), vRow("Surcharge"), vRow("RoutingID"), default, newFoodOrder.CurrentCategory, newFoodOrder.CurrentMenu);
                    }
                    else
                    {
                        foodOrderStaging[position].UpdateStagingPanel(vRow("MenuJoinID"), vRow("FoodName"), vRow("Price"), vRow("FoodID"), vRow("Surcharge"), vRow("RoutingID"), default, 0, newFoodOrder.CurrentMenu);
                    }
                    position += 1;
                }
            }

        }

        ClearTheRestOfStagingPage(position);

    }

    private void ClearTheRestOfStagingPage(int position)
    {
        int index;

        for (index = position; index <= 10; index++)
            foodOrderStaging[index].UpdateStagingPanel(default, "", default, default, default, default, default, default, default);

    }


    private void btnOrderUpdateStaging_Click(object sender, EventArgs e)
    {

        SaveUpdatedMenuOrderCategoryDetail();
        DisplayStagingPage(newFoodOrderStagingIndex);

    }

    private void UpdateOrderDetail222()
    {
        // changed to SaveUpdatedOrderMenuDetail

        // *******************************************
        // might have to keep this one setup like this
        // we pull from 2 different tables

        var adt = new SqlClient.SqlDataAdapter("SELECT MenuJoinID, MenuIndex FROM MenuJoin", sql.cn);
        var cbd = new SqlClient.SqlCommandBuilder(adt);

        if (dsSetup.HasChanges)
        {
            try
            {
                sql.cn.Open();
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
                adt.Update(dsSetup, "OrderCategoryDetail");
                sql.cn.Close();
                dsSetup.Tables("OrderCategoryDetail").AcceptChanges();
            }

            // DisplayStagingPage(newFoodOrder.StagingIndex)
            // newFoodOrder.MaxIndex = dsSetup.Tables("OrderCategoryDetail").Compute("Max(MenuIndex)", "")
            catch (Exception ex)
            {
                CloseConnection();
            }

        }

    }

    private void OrderMouseMove(object sender, EventArgs e) // , FoodOrderStaging1.BlankOldModifierPanel, FoodOrderStaging2.BlankOldModifierPanel, FoodOrderStaging3.BlankOldModifierPanel, FoodOrderStaging4.BlankOldModifierPanel, FoodOrderStaging5.BlankOldModifierPanel, FoodOrderStaging6.BlankOldModifierPanel, FoodOrderStaging7.BlankOldModifierPanel, FoodOrderStaging8.BlankOldModifierPanel, FoodOrderStaging9.BlankOldModifierPanel, FoodOrderStaging10.BlankOldModifierPanel
    {

        SaveUpdatedMenuOrderCategoryDetail();
        // DisplayStagingPage(newFoodOrder.StagingIndex)

        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(sender.DrinkID, 0, false))) // = "Drinks" Then
        {
            currentDrinkPanelLast = (FoodPanelControl)sender;
            currentDrinkPanelLast.Text = "";
            currentDrinkPanelLast.DrinkID = 0;
            currentDrinkPanelLast.FoodName = "";
            currentDrinkPanelLast.FoodPrice = 0;
            updatedDrink = true;
        }

    }

    private void btnOrderUp_Click(object sender, EventArgs e)
    {
        if (newFoodOrderStagingIndex > 0)
        {
            newFoodOrderStagingIndex -= 1;
            DisplayStagingPage(newFoodOrderStagingIndex);
        }

    }
    private void btnOrderDown_Click(object sender, EventArgs e)
    {
        if (newFoodOrderStagingIndex < dvOrderStaging.Count)
        {
            newFoodOrderStagingIndex += 1;
            DisplayStagingPage(newFoodOrderStagingIndex);
        }

    }

    private void FoodOrderPreviousPanelClick(object sender, EventArgs e)
    {

        FoodPanelControl currentOrderPanel;
        currentOrderPanel = (FoodPanelControl)sender;

        if (currentOrderPanel.MenuJoinID == -1)
        {
            SaveUpdatedMenuOrderCategoryDetail();
            newFoodOrder.PageIndex -= 1;
            DisplayCategoryPage(newFoodOrder.PageIndex);
        }

    }

    private void FoodOrderNextPanelClick(object sender, EventArgs e) // , foodOrderPanel60.MyPanelClick
    {

        FoodPanelControl currentOrderPanel;
        currentOrderPanel = (FoodPanelControl)sender;

        if (currentOrderPanel.MenuJoinID == -2)
        {
            SaveUpdatedMenuOrderCategoryDetail();
            newFoodOrder.PageIndex += 1;
            DisplayCategoryPage(newFoodOrder.PageIndex);
        }

    }

    private void btnOrderRemove_Click(object sender, EventArgs e)
    {
        if (cbxOrderCategorySelection.SelectedIndex == -1)
        {
            return;
        }
        return;    // currently not allowing more than one page
        // so no reason to delete any

        foreach (DataRow oRow in dsSetup.Tables("OrderCategoryDetail").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                if (oRow("MenuIndex") > (newFoodOrder.PageIndex - 1) * 32)
                {
                    Interaction.MsgBox("You can not Remove a Page until all Food Items are located on Previous Pages or Staging.");
                    return;
                }
            }
        }
        newFoodOrder.PageIndex -= 1;
        // newFoodOrder.MaxIndex = dsSetup.Tables("OrderCategoryDetail").Compute("Max(MenuIndex)", "")

        SaveUpdatedMenuOrderCategoryDetail();
        DisplayCategoryPage(newFoodOrder.PageIndex);

    }

    private void btnOrderAdd_Click(object sender, EventArgs e)
    {
        DataRow oRow;
        // ***     temp    not letting add more than one page
        // If newFoodOrder.PageIndex = 2 Then Exit Sub
        if (cbxOrderCategorySelection.SelectedIndex == -1)
        {
            return;
        }
        return;

        if (newFoodOrder.FunFlag == "G")
        {
            if (foodOrderPanel60.foodPanel.MenuJoinID > 0)
            {
                foreach (DataRow currentORow in dsSetup.Tables("OrderCategoryDetail").Rows)
                {
                    oRow = currentORow;
                    if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                    {
                        if (oRow("MenuJoinID") == this.foodOrderPanel60.foodPanel.MenuJoinID)
                        {
                            oRow("MenuIndex") = oRow("MenuIndex") + 2;
                            this.foodMenuJoinID(oRow("MenuIndex")) = oRow("MenuJoinID");
                            this.foodName(oRow("MenuIndex")) = oRow("AbrevFoodName");
                            this.foodIndex(oRow("MenuIndex")) = oRow("MenuIndex");
                            break;
                        }
                    }
                }
            }
        }
        else if (foodOrderPanel32.foodPanel.MenuJoinID > 0)
        {
            foreach (DataRow currentORow1 in dsSetup.Tables("OrderCategoryDetail").Rows)
            {
                oRow = currentORow1;
                if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                {
                    if (oRow("MenuJoinID") == this.foodOrderPanel32.foodPanel.MenuJoinID)
                    {
                        oRow("MenuIndex") = oRow("MenuIndex") + 2;
                        this.foodMenuJoinID(oRow("MenuIndex")) = oRow("MenuJoinID");
                        this.foodName(oRow("MenuIndex")) = oRow("AbrevFoodName");
                        this.foodIndex(oRow("MenuIndex")) = oRow("MenuIndex");
                        break;
                    }
                }
            }

        }

        newFoodOrder.MaxIndex += newFoodOrder.MorePanels;
        SaveUpdatedMenuOrderCategoryDetail();

        if (newFoodOrder.PageIndex * newFoodOrder.MorePanels > newFoodOrder.MaxIndex)
        {
            ;
#error Cannot convert ReDimStatementSyntax - see comment for details
            /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
               at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
               at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
               at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
               at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

            Input:
                        ReDim foodMenuJoinID(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)

             */
            ;
#error Cannot convert ReDimStatementSyntax - see comment for details
            /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
               at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
               at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
               at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
               at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

            Input:
                        ReDim foodName(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)

             */
            ;
#error Cannot convert ReDimStatementSyntax - see comment for details
            /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
               at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
               at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
               at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
               at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
               at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

            Input:
                        ReDim foodPrice(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)

             */
            ;
#error Cannot convert ReDimStatementSyntax - see comment for details
            /* Cannot convert ReDimStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Symbols.ErrorTypeSymbol' to type 'Microsoft.CodeAnalysis.IArrayTypeSymbol'.
                           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.CreateNewArrayAssignment(ExpressionSyntax vbArrayExpression, ExpressionSyntax csArrayExpression, List`1 convertedBounds) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 423
                           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.ConvertRedimClauseAsync(RedimClauseSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 321
                           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.<VisitReDimStatement>b__41_0(RedimClauseSyntax arrayExpression) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
                           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectAsync[TArg,TResult](IEnumerable`1 source, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
                           at ICSharpCode.CodeConverter.Common.AsyncEnumerableTaskExtensions.SelectManyAsync[TArg,TResult](IEnumerable`1 nodes, Func`2 selector) in D:\GitWorkspace\CodeConverter\CodeConverter\Common\AsyncEnumerableTaskExtensions.cs:line 0
                           at ICSharpCode.CodeConverter.CSharp.MethodBodyExecutableStatementVisitor.VisitReDimStatement(ReDimStatementSyntax node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\MethodBodyExecutableStatementVisitor.cs:line 303
                           at ICSharpCode.CodeConverter.CSharp.PerScopeStateVisitorDecorator.AddLocalVariablesAsync(VisualBasicSyntaxNode node, SyntaxKind exitableType, Boolean isBreakableInCs) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\PerScopeStateVisitorDecorator.cs:line 38
                           at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisitInnerAsync(SyntaxNode node) in D:\GitWorkspace\CodeConverter\CodeConverter\CSharp\CommentConvertingMethodBodyVisitor.cs:line 24

                        Input:
                                    ReDim foodIndex(newFoodOrder.MaxIndex + newFoodOrder.MorePanels)

                         */
            PopulateOrderDataFromTable();
        }
        newFoodOrder.PageIndex += 1;
        DisplayCategoryPage(newFoodOrder.PageIndex);

    }

















    private void grdJoinFoodModifierJoins_CurrentCellChanged(object sender, EventArgs e)
    {
        // If dsSetup.HasChanges Then
        // UpdateDatabaseFoodJoin()
        // End If

    }

    private void grdJoinFoodCategoryJoins_CurrentCellChanged(object sender, EventArgs e)
    {
        // If dsSetup.HasChanges Then
        // UpdateDatabaseFoodJoin()
        // End If

    }

    private void menuCheckBox_Changed(object sender, EventArgs e)
    {

        menuBoxUpdated = true;
        var menuID = default(int);
        // we ENTER before we change state
        // this is backwards on purpose, we are changing to Unchecked
        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(sender.@checked, true, false)))
        {

            foreach (DataRowView vRow in dvActiveMenu)
            {
                if (Operators.ConditionalCompareObjectEqual(vRow("MenuName"), sender.text, false))
                {
                    menuID = vRow("MenuID");
                    break;
                }
            }
            foreach (DataRow vRowDatabase in dsSetup.Tables("MenuJoin").Rows)
            {
                if (vRowDatabase("MenuID") == menuID & vRowDatabase("FoodID") == newFood.ActiveFoodID)
                {
                    // 444   vRowDatabase("Active") = False  'sender.Checked
                    vRowDatabase("MenuIndex") = 0;
                }
            }
        }

        // UpdateMenuJoinDatabase()
    }

    private void menuCostBoxes_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        TextBox objTextBox;

        try
        {
            objTextBox = (TextBox)sender;
        }
        catch (Exception ex)
        {
            return;
        }

        ValidateNumeric(ref objTextBox, false);

    }

    // Private Sub txtSurcharge_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) 
    // ValidateNumeric(txtSurcharge, True)
    // End Sub

    private object ValidateNumeric(ref TextBox txtValNumeric, bool isSurcharge)
    {

        if (txtValNumeric.Text == "")
        {
            txtValNumeric.Text = 0;
        }
        // Me.ErrorProvider1.SetError(txtValNumeric, "Is this item Free?")

        else if (!Information.IsNumeric(txtValNumeric.Text))
        {
            this.ErrorProvider1.SetError(txtValNumeric, "This must be a numeric value.");
            txtValNumeric.Text = 0;
            txtValNumeric.Focus();
            Interaction.Beep();
            if ((decimal)txtValNumeric.Text == 0m)
            {
                if (isSurcharge == true)
                {
                }
                // Me.ErrorProvider1.SetError(txtValNumeric, "There is NO surcharge for this item.")
                else
                {
                    // Me.ErrorProvider1.SetError(txtValNumeric, "Is this item Free?")
                }
            }
            return false;
        }
        else
        {
            // cancels the error
            this.ErrorProvider1.Dispose();
            return true;
            // Me.ErrorProvider1.SetError(txtValNumeric, "")

        }

        return default;
    }


    private void cbxTax_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {

        // 222     ValidateNotBlank(Me.cbxFoodTax)

    }

    private void cbxCaqtegory_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {

        ValidateNotBlank(this.cbxFoodCategory);

    }

    private void cbxPrint_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {

        if (this.cbxPrintPriority.SelectedIndex == -1)
        {
            this.cbxPrintPriority.SelectedIndex = 2;
        }

        // ValidateNotBlank(Me.cbxPrintPriority)

    }
    private void cbxRouting_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {

        // 222      ValidateNotBlank(Me.cbxFoodRouting)

    }

    private void ValidateNotBlank(ComboBox cbxValBlank)
    {

        if (cbxValBlank.SelectedIndex == -1)
        {
            ErrorProvider1.SetError(cbxValBlank, "You must make a selection.");
            cbxValBlank.Focus();
            Interaction.Beep();
        }
        else
        {
            ErrorProvider1.Dispose();
            // ErrorProvider1.SetError(cbxValBlank, "")

        }

    }

    private void BtnUpdateMenuChoices_Click(object sender, EventArgs e)
    {
        // *** don't need anymore
        SaveMenuDetail();

    }







    private void UpdateNewMenuPanel222()
    {
        numberOfMenuSelections = GetButtonCount("Menus");
        int xMenu = 96;
        int yMenu = 24;
        int yMenuLocation = 2 * buttonSpace + (yMenu + buttonSpace) * (numberOfMenuSelections - 1);

        menuActiveBox.Size = new Size(xMenu + 8, (yMenu + buttonSpace) * (numberOfMenuSelections + 3) + 5 * buttonSpace);
        // menuActiveBox.Size = New Size(xMenu + 8, ((yMenu + buttonSpace) * (numberOfMenuSelections + 2) + (3 * buttonSpace)))

        menuActive(numberOfMenuSelections - 1) = new CustomCheckBox();
        {
            var withBlock = menuActive(numberOfMenuSelections - 1);
            withBlock.Text = dsSetup.Tables("Menus").Rows(numberOfMenuSelections - 1)("MenuName");
            withBlock.ID = dsSetup.Tables("Menus").Rows(numberOfMenuSelections - 1)("MenuID");
            if (dsSetup.Tables("Menus").Rows(numberOfMenuSelections - 1)("Active") == true)
            {
                menuActive(numberOfMenuSelections - 1).Checked = true;
            }
            withBlock.Size = new Size(xMenu, yMenu);
            withBlock.Location = new Point(buttonSpace, yMenuLocation);

            menuActive(numberOfMenuSelections - 1).Click += MenuActive_Click;

        }
        menuActiveBox.Controls.Add(menuActive(numberOfMenuSelections - 1));

        yMenuLocation = yMenuLocation + yMenu + buttonSpace;
        btnMenuAdd.Location = new Point(buttonSpace, yMenuLocation);
        yMenuLocation = yMenuLocation + yMenu + buttonSpace;
        txtMenuUpdate.Location = new Point(buttonSpace, yMenuLocation);

    }









    // below is needed for ICollection
    // i don't know why we have ICollection though

    public void CopyTo(Array array, int index)
    {

    }

    public int Count
    {
        get
        {
            return default;

        }
    }

    public bool IsSynchronized
    {
        get
        {
            return default;

        }
    }

    public object SyncRoot
    {
        get
        {
            return default;

        }
    }

    public IEnumerator GetEnumerator()
    {
        return default;

    }

    // above is needed for ICollection
    // i don't know why we have ICollection though








}
