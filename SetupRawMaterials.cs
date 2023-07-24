using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;


public partial class SetupRawMaterials : System.Windows.Forms.UserControl
{

    // Dim sql As New DataSet_Builder.SQLHelper
    // Dim sqlrm As New DataSet_Builder.SQLHelperRaw

    private CurrencyManager RawCurrencyMan;
    private CurrencyManager RawIngredientCurrencyMan;
    private CurrencyManager RawFoodCurrencyMan;
    // Dim RawAddingIngredientCurrencyMan As CurrencyManager

    private int searchFoodID;
    private string searchFoodName;
    private DataView dvRawUsageByItem = new DataView();
    private DataView dvRawMaterials = new DataView();
    private int usageCount;
    private bool rawUsageChanged;
    private decimal itemCost;
    private bool removingFromCurrentIngredients;
    private string rawUsageFunFlag;

    private Global.System.Windows.Forms.ComboBox _cbxNewRawMatExistingCat;

    internal virtual Global.System.Windows.Forms.ComboBox cbxNewRawMatExistingCat
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxNewRawMatExistingCat;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxNewRawMatExistingCat != null)
            {
                _cbxNewRawMatExistingCat.SelectedIndexChanged -= cbxNewRawMatExistingCat_SelectedIndexChanged;
            }

            _cbxNewRawMatExistingCat = value;
            if (_cbxNewRawMatExistingCat != null)
            {
                _cbxNewRawMatExistingCat.SelectedIndexChanged += cbxNewRawMatExistingCat_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.DataGrid _grdRawDrinkNames;

    internal virtual Global.System.Windows.Forms.DataGrid grdRawDrinkNames
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _grdRawDrinkNames;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_grdRawDrinkNames != null)
            {
                _grdRawDrinkNames.MouseUp -= grdRawDrinkNames_Clicked;
            }

            _grdRawDrinkNames = value;
            if (_grdRawDrinkNames != null)
            {
                _grdRawDrinkNames.MouseUp += grdRawDrinkNames_Clicked;
            }
        }
    }
    private DataGridTableStyle tsRawDrinkNames = new DataGridTableStyle();
    private Global.System.Windows.Forms.DataGrid _grdRawDrinkList;

    internal virtual Global.System.Windows.Forms.DataGrid grdRawDrinkList
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _grdRawDrinkList;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_grdRawDrinkList != null)
            {
                _grdRawDrinkList.CurrentCellChanged -= grdRawDrinkList_Changed;
            }

            _grdRawDrinkList = value;
            if (_grdRawDrinkList != null)
            {
                _grdRawDrinkList.CurrentCellChanged += grdRawDrinkList_Changed;
            }
        }
    }
    private Global.System.Windows.Forms.DataGridTableStyle _tsRawDrinksItems;

    internal virtual Global.System.Windows.Forms.DataGridTableStyle tsRawDrinksItems
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _tsRawDrinksItems;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _tsRawDrinksItems = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _DataGridTextBoxColumn1;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _DataGridTextBoxColumn1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _DataGridTextBoxColumn1 = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _DataGridTextBoxColumn2;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _DataGridTextBoxColumn2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _DataGridTextBoxColumn2 = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTableStyle _tsFoodList;

    internal virtual Global.System.Windows.Forms.DataGridTableStyle tsFoodList
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _tsFoodList;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _tsFoodList = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dcRawFoodID;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dcRawFoodID
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dcRawFoodID;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dcRawFoodID = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dcRawFoodName;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dcRawFoodName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dcRawFoodName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dcRawFoodName = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblRawDirections;

    internal virtual Global.System.Windows.Forms.Label lblRawDirections
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblRawDirections;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblRawDirections = value;
        }
    }

    private int newRawCategoryID;



    #region  Windows Form Designer generated code 

    public SetupRawMaterials() : base()
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
    private Global.System.Windows.Forms.TabPage _TabRawMaterials;

    internal virtual Global.System.Windows.Forms.TabPage TabRawMaterials
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _TabRawMaterials;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_TabRawMaterials != null)
            {
                _TabRawMaterials.Leave -= TabRawMaterial_Leave;
            }

            _TabRawMaterials = value;
            if (_TabRawMaterials != null)
            {
                _TabRawMaterials.Leave += TabRawMaterial_Leave;
            }
        }
    }
    private Global.System.Windows.Forms.DataGrid _grdRawMaterialList;

    internal virtual Global.System.Windows.Forms.DataGrid grdRawMaterialList
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _grdRawMaterialList;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _grdRawMaterialList = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnRawMatUpdate;

    internal virtual Global.System.Windows.Forms.Button btnRawMatUpdate
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnRawMatUpdate;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnRawMatUpdate != null)
            {
                _btnRawMatUpdate.Click -= BtnRawMatUpdate_Click;
            }

            _btnRawMatUpdate = value;
            if (_btnRawMatUpdate != null)
            {
                _btnRawMatUpdate.Click += BtnRawMatUpdate_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnRawMatDelete;

    internal virtual Global.System.Windows.Forms.Button btnRawMatDelete
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnRawMatDelete;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnRawMatDelete != null)
            {
                _btnRawMatDelete.Click -= btnRawMatDelete_Click;
            }

            _btnRawMatDelete = value;
            if (_btnRawMatDelete != null)
            {
                _btnRawMatDelete.Click += btnRawMatDelete_Click;
            }
        }
    }
    private Global.System.Windows.Forms.TabPage _TabRawIngredients;

    internal virtual Global.System.Windows.Forms.TabPage TabRawIngredients
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _TabRawIngredients;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_TabRawIngredients != null)
            {
                _TabRawIngredients.Leave -= TabRawIngredients_Leave;
            }

            _TabRawIngredients = value;
            if (_TabRawIngredients != null)
            {
                _TabRawIngredients.Leave += TabRawIngredients_Leave;
            }
        }
    }
    private Global.System.Windows.Forms.DataGrid _grdRawFoodList;

    internal virtual Global.System.Windows.Forms.DataGrid grdRawFoodList
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _grdRawFoodList;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_grdRawFoodList != null)
            {
                _grdRawFoodList.CurrentCellChanged -= grdRawFoodList_Changed;
            }

            _grdRawFoodList = value;
            if (_grdRawFoodList != null)
            {
                _grdRawFoodList.CurrentCellChanged += grdRawFoodList_Changed;
            }
        }
    }
    private Global.System.Windows.Forms.Label _lblRawFoodName;

    internal virtual Global.System.Windows.Forms.Label lblRawFoodName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblRawFoodName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_lblRawFoodName != null)
            {
                _lblRawFoodName.TextChanged -= lblRawFoodName_Changed;
            }

            _lblRawFoodName = value;
            if (_lblRawFoodName != null)
            {
                _lblRawFoodName.TextChanged += lblRawFoodName_Changed;
            }
        }
    }
    private Global.System.Windows.Forms.DataGrid _grdRawMaterielListIngredients;

    internal virtual Global.System.Windows.Forms.DataGrid grdRawMaterielListIngredients
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _grdRawMaterielListIngredients;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_grdRawMaterielListIngredients != null)
            {
                _grdRawMaterielListIngredients.MouseUp -= grdRawMaterielListIngredients_Enter;
            }

            _grdRawMaterielListIngredients = value;
            if (_grdRawMaterielListIngredients != null)
            {
                _grdRawMaterielListIngredients.MouseUp += grdRawMaterielListIngredients_Enter;
            }
        }
    }
    private Global.System.Windows.Forms.DataGridTableStyle _DataGridTableStyleRawIngredMat;

    internal virtual Global.System.Windows.Forms.DataGridTableStyle DataGridTableStyleRawIngredMat
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _DataGridTableStyleRawIngredMat;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _DataGridTableStyleRawIngredMat = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRawIngMatID;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRawIngMatID
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRawIngMatID;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRawIngMatID = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRawIngMatName;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRawIngMatName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRawIngMatName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRawIngMatName = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRawIngBreakPercent;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRawIngBreakPercent
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRawIngBreakPercent;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRawIngBreakPercent = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRawIngCost;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRawIngCost
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRawIngCost;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRawIngCost = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlRawUsageList;

    internal virtual Global.System.Windows.Forms.Panel pnlRawUsageList
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlRawUsageList;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlRawUsageList = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnRawMatRemove;

    internal virtual Global.System.Windows.Forms.Button btnRawMatRemove
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnRawMatRemove;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnRawMatRemove != null)
            {
                _btnRawMatRemove.Click -= btnRawMatRemove_Click;
            }

            _btnRawMatRemove = value;
            if (_btnRawMatRemove != null)
            {
                _btnRawMatRemove.Click += btnRawMatRemove_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnRawAdd;

    internal virtual Global.System.Windows.Forms.Button btnRawAdd
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnRawAdd;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnRawAdd != null)
            {
                _btnRawAdd.Click -= btnRawAdd_Click;
            }

            _btnRawAdd = value;
            if (_btnRawAdd != null)
            {
                _btnRawAdd.Click += btnRawAdd_Click;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtRawAdd;

    internal virtual Global.System.Windows.Forms.TextBox txtRawAdd
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtRawAdd;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtRawAdd = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblRawMatLabel;

    internal virtual Global.System.Windows.Forms.Label lblRawMatLabel
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblRawMatLabel;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblRawMatLabel = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblRawMatCost;

    internal virtual Global.System.Windows.Forms.Label lblRawMatCost
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblRawMatCost;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblRawMatCost = value;
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
            if (_btnShowAllFood != null)
            {
                _btnShowAllFood.Click -= btnShowAllFood_Click;
            }

            _btnShowAllFood = value;
            if (_btnShowAllFood != null)
            {
                _btnShowAllFood.Click += btnShowAllFood_Click;
            }
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
            if (_cbxFoodFilter != null)
            {
                _cbxFoodFilter.SelectedIndexChanged -= cbxFoodFilter_SelectedIndexChanged;
            }

            _cbxFoodFilter = value;
            if (_cbxFoodFilter != null)
            {
                _cbxFoodFilter.SelectedIndexChanged += cbxFoodFilter_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxRawMaterialCategory;

    internal virtual Global.System.Windows.Forms.ComboBox cbxRawMaterialCategory
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxRawMaterialCategory;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxRawMaterialCategory != null)
            {
                _cbxRawMaterialCategory.SelectedIndexChanged -= cbxRawMaterialCategory_SelectedIndexChanged;
            }

            _cbxRawMaterialCategory = value;
            if (_cbxRawMaterialCategory != null)
            {
                _cbxRawMaterialCategory.SelectedIndexChanged += cbxRawMaterialCategory_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.Label _lblRawPurchasing;

    internal virtual Global.System.Windows.Forms.Label lblRawPurchasing
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblRawPurchasing;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblRawPurchasing = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblRawRecipe;

    internal virtual Global.System.Windows.Forms.Label lblRawRecipe
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblRawRecipe;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblRawRecipe = value;
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
    private Global.System.Windows.Forms.Panel _pnlNewRawMaterial;

    internal virtual Global.System.Windows.Forms.Panel pnlNewRawMaterial
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlNewRawMaterial;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlNewRawMaterial = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlNewRawQuestion;

    internal virtual Global.System.Windows.Forms.Panel pnlNewRawQuestion
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlNewRawQuestion;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlNewRawQuestion = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnNewRawCopy;

    internal virtual Global.System.Windows.Forms.Button btnNewRawCopy
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnNewRawCopy;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnNewRawCopy != null)
            {
                _btnNewRawCopy.Click -= btnNewRawCopy_Click;
            }

            _btnNewRawCopy = value;
            if (_btnNewRawCopy != null)
            {
                _btnNewRawCopy.Click += btnNewRawCopy_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnRawCancel;

    internal virtual Global.System.Windows.Forms.Button btnRawCancel
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnRawCancel;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnRawCancel != null)
            {
                _btnRawCancel.Click -= btnRawCancel_Click;
            }

            _btnRawCancel = value;
            if (_btnRawCancel != null)
            {
                _btnRawCancel.Click += btnRawCancel_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnRawCreate;

    internal virtual Global.System.Windows.Forms.Button btnRawCreate
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnRawCreate;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnRawCreate != null)
            {
                _btnRawCreate.Click -= btnRawCreate_Click;
            }

            _btnRawCreate = value;
            if (_btnRawCreate != null)
            {
                _btnRawCreate.Click += btnRawCreate_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnRawNew;

    internal virtual Global.System.Windows.Forms.Button btnRawNew
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnRawNew;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnRawNew != null)
            {
                _btnRawNew.Click -= btnRawNew_Click;
            }

            _btnRawNew = value;
            if (_btnRawNew != null)
            {
                _btnRawNew.Click += btnRawNew_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnNewRawReset;

    internal virtual Global.System.Windows.Forms.Button btnNewRawReset
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnNewRawReset;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnNewRawReset != null)
            {
                _btnNewRawReset.Click -= btnNewRawReset_Click;
            }

            _btnNewRawReset = value;
            if (_btnNewRawReset != null)
            {
                _btnNewRawReset.Click += btnNewRawReset_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Panel _pnlRawInfo;

    internal virtual Global.System.Windows.Forms.Panel pnlRawInfo
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlRawInfo;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_pnlRawInfo != null)
            {
                _pnlRawInfo.Click -= pnlRawInfo_click;
            }

            _pnlRawInfo = value;
            if (_pnlRawInfo != null)
            {
                _pnlRawInfo.Click += pnlRawInfo_click;
            }
        }
    }
    private Global.System.Windows.Forms.Label _lblRawName;

    internal virtual Global.System.Windows.Forms.Label lblRawName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblRawName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblRawName = value;
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
    private Global.System.Windows.Forms.TextBox _txtPurchaseUnits;

    internal virtual Global.System.Windows.Forms.TextBox txtPurchaseUnits
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtPurchaseUnits;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtPurchaseUnits = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtPurchaseCost;

    internal virtual Global.System.Windows.Forms.TextBox txtPurchaseCost
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtPurchaseCost;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtPurchaseCost != null)
            {
                _txtPurchaseCost.Leave -= txtPurchaseCost_TextChanged;
            }

            _txtPurchaseCost = value;
            if (_txtPurchaseCost != null)
            {
                _txtPurchaseCost.Leave += txtPurchaseCost_TextChanged;
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
    private Global.System.Windows.Forms.TextBox _txtRecipeConversion;

    internal virtual Global.System.Windows.Forms.TextBox txtRecipeConversion
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtRecipeConversion;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtRecipeConversion != null)
            {
                _txtRecipeConversion.Leave -= txtRecipeConversion_TextChanged;
                _txtRecipeConversion.Click -= txtRecipeConversion_Click;
            }

            _txtRecipeConversion = value;
            if (_txtRecipeConversion != null)
            {
                _txtRecipeConversion.Leave += txtRecipeConversion_TextChanged;
                _txtRecipeConversion.Click += txtRecipeConversion_Click;
            }
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
            if (_Label7 != null)
            {
                _Label7.Click -= Label7_Click;
            }

            _Label7 = value;
            if (_Label7 != null)
            {
                _Label7.Click += Label7_Click;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtRecipeUnits;

    internal virtual Global.System.Windows.Forms.TextBox txtRecipeUnits
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtRecipeUnits;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtRecipeUnits = value;
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
    private Global.System.Windows.Forms.TextBox _txtPhysicalConversion;

    internal virtual Global.System.Windows.Forms.TextBox txtPhysicalConversion
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtPhysicalConversion;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtPhysicalConversion != null)
            {
                _txtPhysicalConversion.Click -= txtPhysicalConversion_Click;
            }

            _txtPhysicalConversion = value;
            if (_txtPhysicalConversion != null)
            {
                _txtPhysicalConversion.Click += txtPhysicalConversion_Click;
            }
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
            if (_Label10 != null)
            {
                _Label10.Click -= Label10_Click;
            }

            _Label10 = value;
            if (_Label10 != null)
            {
                _Label10.Click += Label10_Click;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtPhysicalUnits;

    internal virtual Global.System.Windows.Forms.TextBox txtPhysicalUnits
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtPhysicalUnits;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtPhysicalUnits = value;
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
    private Global.System.Windows.Forms.TextBox _txtRawName;

    internal virtual Global.System.Windows.Forms.TextBox txtRawName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtRawName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtRawName = value;
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
    private Global.System.Windows.Forms.ComboBox _cbxNewCategory;

    internal virtual Global.System.Windows.Forms.ComboBox cbxNewCategory
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxNewCategory;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxNewCategory != null)
            {
                _cbxNewCategory.SelectedIndexChanged -= cbxNewCategory_SelectedIndexChanged;
            }

            _cbxNewCategory = value;
            if (_cbxNewCategory != null)
            {
                _cbxNewCategory.SelectedIndexChanged += cbxNewCategory_SelectedIndexChanged;
            }
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
    private Global.System.Windows.Forms.TextBox _txtPhysicalOnHand;

    internal virtual Global.System.Windows.Forms.TextBox txtPhysicalOnHand
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtPhysicalOnHand;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtPhysicalOnHand = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTableStyle _DataGridTableStyleRawIngredients;

    internal virtual Global.System.Windows.Forms.DataGridTableStyle DataGridTableStyleRawIngredients
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _DataGridTableStyleRawIngredients;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _DataGridTableStyleRawIngredients = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRawIngName;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRawIngName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRawIngName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRawIngName = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRawIngUsageAmount;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRawIngUsageAmount
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRawIngUsageAmount;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRawIngUsageAmount = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRawIngRecipeUnit;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRawIngRecipeUnit
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRawIngRecipeUnit;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRawIngRecipeUnit = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRawIngUnitCost;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRawIngUnitCost
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRawIngUnitCost;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRawIngUnitCost = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRawIngExtCost;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRawIngExtCost
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRawIngExtCost;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRawIngExtCost = value;
        }
    }
    private Global.System.Windows.Forms.DataGrid _grdRawIngredients;

    internal virtual Global.System.Windows.Forms.DataGrid grdRawIngredients
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _grdRawIngredients;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_grdRawIngredients != null)
            {
                _grdRawIngredients.Enter -= grdRawIngredients_Enter;
            }

            _grdRawIngredients = value;
            if (_grdRawIngredients != null)
            {
                _grdRawIngredients.Enter += grdRawIngredients_Enter;
            }
        }
    }
    private Global.System.Windows.Forms.DataGridTableStyle _DataGridTableStyleRawMaterials;

    internal virtual Global.System.Windows.Forms.DataGridTableStyle DataGridTableStyleRawMaterials
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _DataGridTableStyleRawMaterials;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _DataGridTableStyleRawMaterials = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRawMatName;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRawMatName
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRawMatName;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRawMatName = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRawPurchaseUnit;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRawPurchaseUnit
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRawPurchaseUnit;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRawPurchaseUnit = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRawPurchaseUnitPrice;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRawPurchaseUnitPrice
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRawPurchaseUnitPrice;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRawPurchaseUnitPrice = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgBlank;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgBlank
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgBlank;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgBlank = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRecipeUnits;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRecipeUnits
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRecipeUnits;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRecipeUnits = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRecipeConversion;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRecipeConversion
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRecipeConversion;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRecipeConversion = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRecipeUnitCost;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRecipeUnitCost
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRecipeUnitCost;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRecipeUnitCost = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgBlank2;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgBlank2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgBlank2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgBlank2 = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgPhysicalUnit;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgPhysicalUnit
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgPhysicalUnit;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgPhysicalUnit = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgPhysicalConversion;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgPhysicalConversion
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgPhysicalConversion;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgPhysicalConversion = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgPhysicalUnitCost;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgPhysicalUnitCost
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgPhysicalUnitCost;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgPhysicalUnitCost = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgPhysicalOnHand;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgPhysicalOnHand
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgPhysicalOnHand;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgPhysicalOnHand = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgPhysicalTotalAmount;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgPhysicalTotalAmount
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgPhysicalTotalAmount;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgPhysicalTotalAmount = value;
        }
    }
    private Global.System.Windows.Forms.ComboBox _cbxRawMatIngredients;

    internal virtual Global.System.Windows.Forms.ComboBox cbxRawMatIngredients
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxRawMatIngredients;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxRawMatIngredients != null)
            {
                _cbxRawMatIngredients.SelectedIndexChanged -= cbxRawMatIngredients_SelectedIndexChanged;
            }

            _cbxRawMatIngredients = value;
            if (_cbxRawMatIngredients != null)
            {
                _cbxRawMatIngredients.SelectedIndexChanged += cbxRawMatIngredients_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRawItemID;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRawItemID
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRawItemID;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRawItemID = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnShowAllRaw2;

    internal virtual Global.System.Windows.Forms.Button btnShowAllRaw2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnShowAllRaw2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnShowAllRaw2 != null)
            {
                _btnShowAllRaw2.Click -= btnShowAllRaw2_Click;
            }

            _btnShowAllRaw2 = value;
            if (_btnShowAllRaw2 != null)
            {
                _btnShowAllRaw2.Click += btnShowAllRaw2_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnShowAllRaw1;

    internal virtual Global.System.Windows.Forms.Button btnShowAllRaw1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnShowAllRaw1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnShowAllRaw1 != null)
            {
                _btnShowAllRaw1.Click -= btnShowAllRaw1_Click;
            }

            _btnShowAllRaw1 = value;
            if (_btnShowAllRaw1 != null)
            {
                _btnShowAllRaw1.Click += btnShowAllRaw1_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnRawMatChange;

    internal virtual Global.System.Windows.Forms.Button btnRawMatChange
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnRawMatChange;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnRawMatChange != null)
            {
                _btnRawMatChange.Click -= btnRawMatChange_Click;
            }

            _btnRawMatChange = value;
            if (_btnRawMatChange != null)
            {
                _btnRawMatChange.Click += btnRawMatChange_Click;
            }
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
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRecipeNo;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRecipeNo
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRecipeNo;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRecipeNo = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRecipeExtra;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRecipeExtra
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRecipeExtra;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRecipeExtra = value;
        }
    }
    private Global.System.Windows.Forms.DataGridTextBoxColumn _dgRecipeExtraDollar;

    internal virtual Global.System.Windows.Forms.DataGridTextBoxColumn dgRecipeExtraDollar
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _dgRecipeExtraDollar;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _dgRecipeExtraDollar = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkRecipeSelectNo;

    internal virtual Global.System.Windows.Forms.CheckBox chkRecipeSelectNo
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkRecipeSelectNo;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkRecipeSelectNo = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtRecipeSelectNo;

    internal virtual Global.System.Windows.Forms.TextBox txtRecipeSelectNo
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtRecipeSelectNo;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtRecipeSelectNo = value;
        }
    }
    private Global.System.Windows.Forms.Label _lblRecipeUnitCost;

    internal virtual Global.System.Windows.Forms.Label lblRecipeUnitCost
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblRecipeUnitCost;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblRecipeUnitCost = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtRecipeUnitCost;

    internal virtual Global.System.Windows.Forms.TextBox txtRecipeUnitCost
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtRecipeUnitCost;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtRecipeUnitCost = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtRecipeSelectExtra;

    internal virtual Global.System.Windows.Forms.TextBox txtRecipeSelectExtra
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtRecipeSelectExtra;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtRecipeSelectExtra = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkRecipeSelectExtra;

    internal virtual Global.System.Windows.Forms.CheckBox chkRecipeSelectExtra
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkRecipeSelectExtra;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkRecipeSelectExtra = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkPhysicalTrack;

    internal virtual Global.System.Windows.Forms.CheckBox chkPhysicalTrack
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkPhysicalTrack;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkPhysicalTrack = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkPhysicalReport;

    internal virtual Global.System.Windows.Forms.CheckBox chkPhysicalReport
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkPhysicalReport;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkPhysicalReport = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtPhysicalWarning;

    internal virtual Global.System.Windows.Forms.TextBox txtPhysicalWarning
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtPhysicalWarning;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtPhysicalWarning = value;
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkPhysicalWarning;

    internal virtual Global.System.Windows.Forms.CheckBox chkPhysicalWarning
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkPhysicalWarning;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkPhysicalWarning = value;
        }
    }
    private Global.System.Windows.Forms.Button _btnRawAccept;

    internal virtual Global.System.Windows.Forms.Button btnRawAccept
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnRawAccept;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnRawAccept != null)
            {
                _btnRawAccept.Click -= btnRawAccept_Click;
            }

            _btnRawAccept = value;
            if (_btnRawAccept != null)
            {
                _btnRawAccept.Click += btnRawAccept_Click;
            }
        }
    }
    private Global.System.Windows.Forms.CheckBox _chkAvailForExtra;

    internal virtual Global.System.Windows.Forms.CheckBox chkAvailForExtra
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _chkAvailForExtra;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _chkAvailForExtra = value;
        }
    }
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        _TabControl1 = new System.Windows.Forms.TabControl();
        _TabRawMaterials = new System.Windows.Forms.TabPage();
        _TabRawMaterials.Leave += TabRawMaterial_Leave;
        _btnShowAllRaw1 = new System.Windows.Forms.Button();
        _btnShowAllRaw1.Click += btnShowAllRaw1_Click;
        _pnlNewRawMaterial = new System.Windows.Forms.Panel();
        _lblRawDirections = new System.Windows.Forms.Label();
        _grdRawDrinkNames = new System.Windows.Forms.DataGrid();
        _grdRawDrinkNames.MouseUp += grdRawDrinkNames_Clicked;
        _cbxNewRawMatExistingCat = new System.Windows.Forms.ComboBox();
        _cbxNewRawMatExistingCat.SelectedIndexChanged += cbxNewRawMatExistingCat_SelectedIndexChanged;
        _pnlRawInfo = new System.Windows.Forms.Panel();
        _pnlRawInfo.Click += pnlRawInfo_click;
        _Panel4 = new System.Windows.Forms.Panel();
        _cbxNewCategory = new System.Windows.Forms.ComboBox();
        _cbxNewCategory.SelectedIndexChanged += cbxNewCategory_SelectedIndexChanged;
        _Label11 = new System.Windows.Forms.Label();
        _Panel3 = new System.Windows.Forms.Panel();
        _txtPhysicalWarning = new System.Windows.Forms.TextBox();
        _chkPhysicalWarning = new System.Windows.Forms.CheckBox();
        _chkPhysicalReport = new System.Windows.Forms.CheckBox();
        _chkPhysicalTrack = new System.Windows.Forms.CheckBox();
        _Label12 = new System.Windows.Forms.Label();
        _txtPhysicalOnHand = new System.Windows.Forms.TextBox();
        _txtPhysicalConversion = new System.Windows.Forms.TextBox();
        _txtPhysicalConversion.Click += txtPhysicalConversion_Click;
        _Label8 = new System.Windows.Forms.Label();
        _Label9 = new System.Windows.Forms.Label();
        _Label10 = new System.Windows.Forms.Label();
        _Label10.Click += Label10_Click;
        _txtPhysicalUnits = new System.Windows.Forms.TextBox();
        _Panel2 = new System.Windows.Forms.Panel();
        _txtRecipeSelectExtra = new System.Windows.Forms.TextBox();
        _chkRecipeSelectExtra = new System.Windows.Forms.CheckBox();
        _lblRecipeUnitCost = new System.Windows.Forms.Label();
        _txtRecipeUnitCost = new System.Windows.Forms.TextBox();
        _txtRecipeSelectNo = new System.Windows.Forms.TextBox();
        _chkRecipeSelectNo = new System.Windows.Forms.CheckBox();
        _txtRecipeConversion = new System.Windows.Forms.TextBox();
        _txtRecipeConversion.Leave += txtRecipeConversion_TextChanged;
        _txtRecipeConversion.Click += txtRecipeConversion_Click;
        _Label5 = new System.Windows.Forms.Label();
        _Label6 = new System.Windows.Forms.Label();
        _Label7 = new System.Windows.Forms.Label();
        _Label7.Click += Label7_Click;
        _txtRecipeUnits = new System.Windows.Forms.TextBox();
        _txtRawName = new System.Windows.Forms.TextBox();
        _Panel1 = new System.Windows.Forms.Panel();
        _txtPurchaseCost = new System.Windows.Forms.TextBox();
        _txtPurchaseCost.Leave += txtPurchaseCost_TextChanged;
        _Label4 = new System.Windows.Forms.Label();
        _Label2 = new System.Windows.Forms.Label();
        _Label3 = new System.Windows.Forms.Label();
        _txtPurchaseUnits = new System.Windows.Forms.TextBox();
        _lblRawName = new System.Windows.Forms.Label();
        _pnlNewRawQuestion = new System.Windows.Forms.Panel();
        _btnRawAccept = new System.Windows.Forms.Button();
        _btnRawAccept.Click += btnRawAccept_Click;
        _btnNewRawReset = new System.Windows.Forms.Button();
        _btnNewRawReset.Click += btnNewRawReset_Click;
        _btnNewRawCopy = new System.Windows.Forms.Button();
        _btnNewRawCopy.Click += btnNewRawCopy_Click;
        _btnRawCreate = new System.Windows.Forms.Button();
        _btnRawCreate.Click += btnRawCreate_Click;
        _btnRawCancel = new System.Windows.Forms.Button();
        _btnRawCancel.Click += btnRawCancel_Click;
        _Label1 = new System.Windows.Forms.Label();
        _lblRawRecipe = new System.Windows.Forms.Label();
        _lblRawPurchasing = new System.Windows.Forms.Label();
        _cbxRawMaterialCategory = new System.Windows.Forms.ComboBox();
        _cbxRawMaterialCategory.SelectedIndexChanged += cbxRawMaterialCategory_SelectedIndexChanged;
        _grdRawMaterialList = new System.Windows.Forms.DataGrid();
        _DataGridTableStyleRawMaterials = new System.Windows.Forms.DataGridTableStyle();
        _dgRawMatName = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgRawPurchaseUnit = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgRawPurchaseUnitPrice = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgBlank = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgRecipeUnits = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgRecipeConversion = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgRecipeUnitCost = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgRecipeNo = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgRecipeExtra = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgRecipeExtraDollar = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgBlank2 = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgPhysicalUnit = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgPhysicalConversion = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgPhysicalUnitCost = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgPhysicalOnHand = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgPhysicalTotalAmount = new System.Windows.Forms.DataGridTextBoxColumn();
        _TabRawIngredients = new System.Windows.Forms.TabPage();
        _TabRawIngredients.Leave += TabRawIngredients_Leave;
        _grdRawDrinkList = new System.Windows.Forms.DataGrid();
        _grdRawDrinkList.CurrentCellChanged += grdRawDrinkList_Changed;
        _tsRawDrinksItems = new System.Windows.Forms.DataGridTableStyle();
        _DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
        _DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
        _chkAvailForExtra = new System.Windows.Forms.CheckBox();
        _btnShowAllRaw2 = new System.Windows.Forms.Button();
        _btnShowAllRaw2.Click += btnShowAllRaw2_Click;
        _cbxRawMatIngredients = new System.Windows.Forms.ComboBox();
        _cbxRawMatIngredients.SelectedIndexChanged += cbxRawMatIngredients_SelectedIndexChanged;
        _grdRawIngredients = new System.Windows.Forms.DataGrid();
        _grdRawIngredients.Enter += grdRawIngredients_Enter;
        _DataGridTableStyleRawIngredients = new System.Windows.Forms.DataGridTableStyle();
        _dgRawItemID = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgRawIngName = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgRawIngUsageAmount = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgRawIngRecipeUnit = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgRawIngUnitCost = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgRawIngExtCost = new System.Windows.Forms.DataGridTextBoxColumn();
        _btnShowAllFood = new System.Windows.Forms.Button();
        _btnShowAllFood.Click += btnShowAllFood_Click;
        _cbxFoodFilter = new System.Windows.Forms.ComboBox();
        _cbxFoodFilter.SelectedIndexChanged += cbxFoodFilter_SelectedIndexChanged;
        _lblRawMatCost = new System.Windows.Forms.Label();
        _lblRawMatLabel = new System.Windows.Forms.Label();
        _txtRawAdd = new System.Windows.Forms.TextBox();
        _btnRawAdd = new System.Windows.Forms.Button();
        _btnRawAdd.Click += btnRawAdd_Click;
        _btnRawMatRemove = new System.Windows.Forms.Button();
        _btnRawMatRemove.Click += btnRawMatRemove_Click;
        _grdRawMaterielListIngredients = new System.Windows.Forms.DataGrid();
        _grdRawMaterielListIngredients.MouseUp += grdRawMaterielListIngredients_Enter;
        _DataGridTableStyleRawIngredMat = new System.Windows.Forms.DataGridTableStyle();
        _dgRawIngMatID = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgRawIngBreakPercent = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgRawIngCost = new System.Windows.Forms.DataGridTextBoxColumn();
        _dgRawIngMatName = new System.Windows.Forms.DataGridTextBoxColumn();
        _lblRawFoodName = new System.Windows.Forms.Label();
        _lblRawFoodName.TextChanged += lblRawFoodName_Changed;
        _grdRawFoodList = new System.Windows.Forms.DataGrid();
        _grdRawFoodList.CurrentCellChanged += grdRawFoodList_Changed;
        _tsFoodList = new System.Windows.Forms.DataGridTableStyle();
        _dcRawFoodID = new System.Windows.Forms.DataGridTextBoxColumn();
        _dcRawFoodName = new System.Windows.Forms.DataGridTextBoxColumn();
        _pnlRawUsageList = new System.Windows.Forms.Panel();
        _btnRawMatDelete = new System.Windows.Forms.Button();
        _btnRawMatDelete.Click += btnRawMatDelete_Click;
        _btnRawMatUpdate = new System.Windows.Forms.Button();
        _btnRawMatUpdate.Click += BtnRawMatUpdate_Click;
        _btnRawNew = new System.Windows.Forms.Button();
        _btnRawNew.Click += btnRawNew_Click;
        _ErrorProvider1 = new System.Windows.Forms.ErrorProvider(components);
        _btnRawMatChange = new System.Windows.Forms.Button();
        _btnRawMatChange.Click += btnRawMatChange_Click;
        _Panel5 = new System.Windows.Forms.Panel();
        _TabControl1.SuspendLayout();
        _TabRawMaterials.SuspendLayout();
        _pnlNewRawMaterial.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_grdRawDrinkNames).BeginInit();
        _pnlRawInfo.SuspendLayout();
        _Panel4.SuspendLayout();
        _Panel3.SuspendLayout();
        _Panel2.SuspendLayout();
        _Panel1.SuspendLayout();
        _pnlNewRawQuestion.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_grdRawMaterialList).BeginInit();
        _TabRawIngredients.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_grdRawDrinkList).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_grdRawIngredients).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_grdRawMaterielListIngredients).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_grdRawFoodList).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_ErrorProvider1).BeginInit();
        _Panel5.SuspendLayout();
        this.SuspendLayout();
        // 
        // TabControl1
        // 
        _TabControl1.Controls.Add(_TabRawMaterials);
        _TabControl1.Controls.Add(_TabRawIngredients);
        _TabControl1.Location = new System.Drawing.Point(24, 140);
        _TabControl1.Name = "_TabControl1";
        _TabControl1.SelectedIndex = 0;
        _TabControl1.Size = new System.Drawing.Size(848, 544);
        _TabControl1.TabIndex = 0;
        // 
        // TabRawMaterials
        // 
        _TabRawMaterials.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _TabRawMaterials.Controls.Add(_btnShowAllRaw1);
        _TabRawMaterials.Controls.Add(_pnlNewRawMaterial);
        _TabRawMaterials.Controls.Add(_Label1);
        _TabRawMaterials.Controls.Add(_lblRawRecipe);
        _TabRawMaterials.Controls.Add(_lblRawPurchasing);
        _TabRawMaterials.Controls.Add(_cbxRawMaterialCategory);
        _TabRawMaterials.Controls.Add(_grdRawMaterialList);
        _TabRawMaterials.Location = new System.Drawing.Point(4, 22);
        _TabRawMaterials.Name = "_TabRawMaterials";
        _TabRawMaterials.Size = new System.Drawing.Size(840, 518);
        _TabRawMaterials.TabIndex = 0;
        _TabRawMaterials.Text = "Raw Materials";
        // 
        // btnShowAllRaw1
        // 
        _btnShowAllRaw1.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _btnShowAllRaw1.Location = new System.Drawing.Point(80, 32);
        _btnShowAllRaw1.Name = "_btnShowAllRaw1";
        _btnShowAllRaw1.Size = new System.Drawing.Size(96, 24);
        _btnShowAllRaw1.TabIndex = 19;
        _btnShowAllRaw1.Text = "Show All";
        _btnShowAllRaw1.UseVisualStyleBackColor = false;
        // 
        // pnlNewRawMaterial
        // 
        _pnlNewRawMaterial.BackColor = System.Drawing.Color.LightGray;
        _pnlNewRawMaterial.Controls.Add(_lblRawDirections);
        _pnlNewRawMaterial.Controls.Add(_grdRawDrinkNames);
        _pnlNewRawMaterial.Controls.Add(_cbxNewRawMatExistingCat);
        _pnlNewRawMaterial.Controls.Add(_pnlRawInfo);
        _pnlNewRawMaterial.Controls.Add(_pnlNewRawQuestion);
        _pnlNewRawMaterial.Location = new System.Drawing.Point(157, 72);
        _pnlNewRawMaterial.Name = "_pnlNewRawMaterial";
        _pnlNewRawMaterial.Size = new System.Drawing.Size(625, 416);
        _pnlNewRawMaterial.TabIndex = 5;
        _pnlNewRawMaterial.Visible = false;
        // 
        // lblRawDirections
        // 
        _lblRawDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblRawDirections.ForeColor = System.Drawing.Color.DarkBlue;
        _lblRawDirections.Location = new System.Drawing.Point(303, 352);
        _lblRawDirections.Name = "_lblRawDirections";
        _lblRawDirections.Size = new System.Drawing.Size(139, 49);
        _lblRawDirections.TabIndex = 4;
        _lblRawDirections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // grdRawDrinkNames
        // 
        _grdRawDrinkNames.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
        _grdRawDrinkNames.CaptionText = "           Drink Names";
        _grdRawDrinkNames.ColumnHeadersVisible = false;
        _grdRawDrinkNames.DataMember = "";
        _grdRawDrinkNames.HeaderForeColor = System.Drawing.SystemColors.ControlText;
        _grdRawDrinkNames.Location = new System.Drawing.Point(470, 48);
        _grdRawDrinkNames.Name = "_grdRawDrinkNames";
        _grdRawDrinkNames.ReadOnly = true;
        _grdRawDrinkNames.Size = new System.Drawing.Size(151, 353);
        _grdRawDrinkNames.TabIndex = 3;
        // 
        // cbxNewRawMatExistingCat
        // 
        _cbxNewRawMatExistingCat.Location = new System.Drawing.Point(470, 16);
        _cbxNewRawMatExistingCat.MaxDropDownItems = 25;
        _cbxNewRawMatExistingCat.Name = "_cbxNewRawMatExistingCat";
        _cbxNewRawMatExistingCat.Size = new System.Drawing.Size(151, 21);
        _cbxNewRawMatExistingCat.TabIndex = 2;
        // 
        // pnlRawInfo
        // 
        _pnlRawInfo.Controls.Add(_Panel4);
        _pnlRawInfo.Controls.Add(_Panel3);
        _pnlRawInfo.Controls.Add(_Panel2);
        _pnlRawInfo.Controls.Add(_txtRawName);
        _pnlRawInfo.Controls.Add(_Panel1);
        _pnlRawInfo.Controls.Add(_lblRawName);
        _pnlRawInfo.Location = new System.Drawing.Point(8, 8);
        _pnlRawInfo.Name = "_pnlRawInfo";
        _pnlRawInfo.Size = new System.Drawing.Size(456, 328);
        _pnlRawInfo.TabIndex = 1;
        _pnlRawInfo.Visible = false;
        // 
        // Panel4
        // 
        _Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        _Panel4.Controls.Add(_cbxNewCategory);
        _Panel4.Controls.Add(_Label11);
        _Panel4.Location = new System.Drawing.Point(16, 232);
        _Panel4.Name = "_Panel4";
        _Panel4.Size = new System.Drawing.Size(272, 88);
        _Panel4.TabIndex = 7;
        // 
        // cbxNewCategory
        // 
        _cbxNewCategory.Location = new System.Drawing.Point(8, 24);
        _cbxNewCategory.Name = "_cbxNewCategory";
        _cbxNewCategory.Size = new System.Drawing.Size(160, 21);
        _cbxNewCategory.TabIndex = 11;
        // 
        // Label11
        // 
        _Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label11.ForeColor = System.Drawing.Color.DarkBlue;
        _Label11.Location = new System.Drawing.Point(24, 8);
        _Label11.Name = "_Label11";
        _Label11.Size = new System.Drawing.Size(224, 16);
        _Label11.TabIndex = 1;
        _Label11.Text = "Category";
        _Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Panel3
        // 
        _Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        _Panel3.Controls.Add(_txtPhysicalWarning);
        _Panel3.Controls.Add(_chkPhysicalWarning);
        _Panel3.Controls.Add(_chkPhysicalReport);
        _Panel3.Controls.Add(_chkPhysicalTrack);
        _Panel3.Controls.Add(_Label12);
        _Panel3.Controls.Add(_txtPhysicalOnHand);
        _Panel3.Controls.Add(_txtPhysicalConversion);
        _Panel3.Controls.Add(_Label8);
        _Panel3.Controls.Add(_Label9);
        _Panel3.Controls.Add(_Label10);
        _Panel3.Controls.Add(_txtPhysicalUnits);
        _Panel3.Location = new System.Drawing.Point(16, 136);
        _Panel3.Name = "_Panel3";
        _Panel3.Size = new System.Drawing.Size(432, 88);
        _Panel3.TabIndex = 6;
        // 
        // txtPhysicalWarning
        // 
        _txtPhysicalWarning.Location = new System.Drawing.Point(256, 56);
        _txtPhysicalWarning.Name = "_txtPhysicalWarning";
        _txtPhysicalWarning.Size = new System.Drawing.Size(48, 20);
        _txtPhysicalWarning.TabIndex = 16;
        // 
        // chkPhysicalWarning
        // 
        _chkPhysicalWarning.ForeColor = System.Drawing.Color.DarkBlue;
        _chkPhysicalWarning.Location = new System.Drawing.Point(176, 56);
        _chkPhysicalWarning.Name = "_chkPhysicalWarning";
        _chkPhysicalWarning.Size = new System.Drawing.Size(80, 24);
        _chkPhysicalWarning.TabIndex = 15;
        _chkPhysicalWarning.Text = "Warning";
        // 
        // chkPhysicalReport
        // 
        _chkPhysicalReport.ForeColor = System.Drawing.Color.DarkBlue;
        _chkPhysicalReport.Location = new System.Drawing.Point(176, 32);
        _chkPhysicalReport.Name = "_chkPhysicalReport";
        _chkPhysicalReport.Size = new System.Drawing.Size(80, 24);
        _chkPhysicalReport.TabIndex = 13;
        _chkPhysicalReport.Text = "Report";
        // 
        // chkPhysicalTrack
        // 
        _chkPhysicalTrack.ForeColor = System.Drawing.Color.DarkBlue;
        _chkPhysicalTrack.Location = new System.Drawing.Point(176, 8);
        _chkPhysicalTrack.Name = "_chkPhysicalTrack";
        _chkPhysicalTrack.Size = new System.Drawing.Size(80, 24);
        _chkPhysicalTrack.TabIndex = 11;
        _chkPhysicalTrack.Text = "Track";
        // 
        // Label12
        // 
        _Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label12.ForeColor = System.Drawing.Color.DarkBlue;
        _Label12.Location = new System.Drawing.Point(304, 8);
        _Label12.Name = "_Label12";
        _Label12.Size = new System.Drawing.Size(48, 23);
        _Label12.TabIndex = 10;
        _Label12.Text = "Initial   on hand";
        _Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtPhysicalOnHand
        // 
        _txtPhysicalOnHand.Location = new System.Drawing.Point(360, 8);
        _txtPhysicalOnHand.Name = "_txtPhysicalOnHand";
        _txtPhysicalOnHand.Size = new System.Drawing.Size(56, 20);
        _txtPhysicalOnHand.TabIndex = 10;
        _txtPhysicalOnHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // txtPhysicalConversion
        // 
        _txtPhysicalConversion.Location = new System.Drawing.Point(80, 56);
        _txtPhysicalConversion.Name = "_txtPhysicalConversion";
        _txtPhysicalConversion.Size = new System.Drawing.Size(56, 20);
        _txtPhysicalConversion.TabIndex = 9;
        // 
        // Label8
        // 
        _Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label8.ForeColor = System.Drawing.Color.DarkBlue;
        _Label8.Location = new System.Drawing.Point(24, 8);
        _Label8.Name = "_Label8";
        _Label8.Size = new System.Drawing.Size(120, 16);
        _Label8.TabIndex = 1;
        _Label8.Text = "Physical Inventory";
        _Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Label9
        // 
        _Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label9.ForeColor = System.Drawing.Color.DarkBlue;
        _Label9.Location = new System.Drawing.Point(24, 32);
        _Label9.Name = "_Label9";
        _Label9.Size = new System.Drawing.Size(48, 23);
        _Label9.TabIndex = 1;
        _Label9.Text = "Units:";
        _Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label10
        // 
        _Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label10.ForeColor = System.Drawing.Color.DarkBlue;
        _Label10.Location = new System.Drawing.Point(0, 56);
        _Label10.Name = "_Label10";
        _Label10.Size = new System.Drawing.Size(72, 23);
        _Label10.TabIndex = 2;
        _Label10.Text = "Conversion:";
        _Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtPhysicalUnits
        // 
        _txtPhysicalUnits.Location = new System.Drawing.Point(80, 32);
        _txtPhysicalUnits.Name = "_txtPhysicalUnits";
        _txtPhysicalUnits.Size = new System.Drawing.Size(56, 20);
        _txtPhysicalUnits.TabIndex = 8;
        // 
        // Panel2
        // 
        _Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        _Panel2.Controls.Add(_txtRecipeSelectExtra);
        _Panel2.Controls.Add(_chkRecipeSelectExtra);
        _Panel2.Controls.Add(_lblRecipeUnitCost);
        _Panel2.Controls.Add(_txtRecipeUnitCost);
        _Panel2.Controls.Add(_txtRecipeSelectNo);
        _Panel2.Controls.Add(_chkRecipeSelectNo);
        _Panel2.Controls.Add(_txtRecipeConversion);
        _Panel2.Controls.Add(_Label5);
        _Panel2.Controls.Add(_Label6);
        _Panel2.Controls.Add(_Label7);
        _Panel2.Controls.Add(_txtRecipeUnits);
        _Panel2.Location = new System.Drawing.Point(144, 40);
        _Panel2.Name = "_Panel2";
        _Panel2.Size = new System.Drawing.Size(304, 88);
        _Panel2.TabIndex = 5;
        // 
        // txtRecipeSelectExtra
        // 
        _txtRecipeSelectExtra.Location = new System.Drawing.Point(240, 56);
        _txtRecipeSelectExtra.Name = "_txtRecipeSelectExtra";
        _txtRecipeSelectExtra.Size = new System.Drawing.Size(48, 20);
        _txtRecipeSelectExtra.TabIndex = 13;
        _txtRecipeSelectExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // chkRecipeSelectExtra
        // 
        _chkRecipeSelectExtra.ForeColor = System.Drawing.Color.DarkBlue;
        _chkRecipeSelectExtra.Location = new System.Drawing.Point(152, 56);
        _chkRecipeSelectExtra.Name = "_chkRecipeSelectExtra";
        _chkRecipeSelectExtra.Size = new System.Drawing.Size(88, 24);
        _chkRecipeSelectExtra.TabIndex = 12;
        _chkRecipeSelectExtra.Text = "Select Extra";
        // 
        // lblRecipeUnitCost
        // 
        _lblRecipeUnitCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblRecipeUnitCost.ForeColor = System.Drawing.Color.DarkBlue;
        _lblRecipeUnitCost.Location = new System.Drawing.Point(160, 8);
        _lblRecipeUnitCost.Name = "_lblRecipeUnitCost";
        _lblRecipeUnitCost.Size = new System.Drawing.Size(64, 23);
        _lblRecipeUnitCost.TabIndex = 10;
        _lblRecipeUnitCost.Text = "Unit Cost:";
        _lblRecipeUnitCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtRecipeUnitCost
        // 
        _txtRecipeUnitCost.BackColor = System.Drawing.Color.Gainsboro;
        _txtRecipeUnitCost.Location = new System.Drawing.Point(240, 8);
        _txtRecipeUnitCost.Name = "_txtRecipeUnitCost";
        _txtRecipeUnitCost.ReadOnly = true;
        _txtRecipeUnitCost.Size = new System.Drawing.Size(48, 20);
        _txtRecipeUnitCost.TabIndex = 11;
        _txtRecipeUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // txtRecipeSelectNo
        // 
        _txtRecipeSelectNo.Location = new System.Drawing.Point(240, 32);
        _txtRecipeSelectNo.Name = "_txtRecipeSelectNo";
        _txtRecipeSelectNo.Size = new System.Drawing.Size(48, 20);
        _txtRecipeSelectNo.TabIndex = 9;
        _txtRecipeSelectNo.Text = ".00";
        _txtRecipeSelectNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // chkRecipeSelectNo
        // 
        _chkRecipeSelectNo.ForeColor = System.Drawing.Color.DarkBlue;
        _chkRecipeSelectNo.Location = new System.Drawing.Point(152, 32);
        _chkRecipeSelectNo.Name = "_chkRecipeSelectNo";
        _chkRecipeSelectNo.Size = new System.Drawing.Size(88, 24);
        _chkRecipeSelectNo.TabIndex = 8;
        _chkRecipeSelectNo.Text = "Select No";
        // 
        // txtRecipeConversion
        // 
        _txtRecipeConversion.Location = new System.Drawing.Point(80, 56);
        _txtRecipeConversion.Name = "_txtRecipeConversion";
        _txtRecipeConversion.Size = new System.Drawing.Size(56, 20);
        _txtRecipeConversion.TabIndex = 7;
        // 
        // Label5
        // 
        _Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label5.ForeColor = System.Drawing.Color.DarkBlue;
        _Label5.Location = new System.Drawing.Point(32, 8);
        _Label5.Name = "_Label5";
        _Label5.Size = new System.Drawing.Size(96, 16);
        _Label5.TabIndex = 1;
        _Label5.Text = "Recipe";
        _Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Label6
        // 
        _Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label6.ForeColor = System.Drawing.Color.DarkBlue;
        _Label6.Location = new System.Drawing.Point(32, 32);
        _Label6.Name = "_Label6";
        _Label6.Size = new System.Drawing.Size(40, 23);
        _Label6.TabIndex = 1;
        _Label6.Text = "Units:";
        _Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label7
        // 
        _Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label7.ForeColor = System.Drawing.Color.DarkBlue;
        _Label7.Location = new System.Drawing.Point(0, 56);
        _Label7.Name = "_Label7";
        _Label7.Size = new System.Drawing.Size(72, 23);
        _Label7.TabIndex = 2;
        _Label7.Text = "Conversion:";
        _Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtRecipeUnits
        // 
        _txtRecipeUnits.Location = new System.Drawing.Point(80, 32);
        _txtRecipeUnits.Name = "_txtRecipeUnits";
        _txtRecipeUnits.Size = new System.Drawing.Size(56, 20);
        _txtRecipeUnits.TabIndex = 6;
        // 
        // txtRawName
        // 
        _txtRawName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _txtRawName.Location = new System.Drawing.Point(184, 8);
        _txtRawName.Name = "_txtRawName";
        _txtRawName.Size = new System.Drawing.Size(136, 22);
        _txtRawName.TabIndex = 3;
        // 
        // Panel1
        // 
        _Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        _Panel1.Controls.Add(_txtPurchaseCost);
        _Panel1.Controls.Add(_Label4);
        _Panel1.Controls.Add(_Label2);
        _Panel1.Controls.Add(_Label3);
        _Panel1.Controls.Add(_txtPurchaseUnits);
        _Panel1.Location = new System.Drawing.Point(16, 40);
        _Panel1.Name = "_Panel1";
        _Panel1.Size = new System.Drawing.Size(112, 88);
        _Panel1.TabIndex = 3;
        // 
        // txtPurchaseCost
        // 
        _txtPurchaseCost.Location = new System.Drawing.Point(48, 56);
        _txtPurchaseCost.Name = "_txtPurchaseCost";
        _txtPurchaseCost.Size = new System.Drawing.Size(56, 20);
        _txtPurchaseCost.TabIndex = 5;
        // 
        // Label4
        // 
        _Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label4.ForeColor = System.Drawing.Color.DarkBlue;
        _Label4.Location = new System.Drawing.Point(8, 8);
        _Label4.Name = "_Label4";
        _Label4.Size = new System.Drawing.Size(96, 16);
        _Label4.TabIndex = 1;
        _Label4.Text = "Purchase";
        _Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Label2
        // 
        _Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label2.ForeColor = System.Drawing.Color.DarkBlue;
        _Label2.Location = new System.Drawing.Point(0, 32);
        _Label2.Name = "_Label2";
        _Label2.Size = new System.Drawing.Size(40, 23);
        _Label2.TabIndex = 1;
        _Label2.Text = "Units:";
        _Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label3
        // 
        _Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label3.ForeColor = System.Drawing.Color.DarkBlue;
        _Label3.Location = new System.Drawing.Point(0, 56);
        _Label3.Name = "_Label3";
        _Label3.Size = new System.Drawing.Size(40, 23);
        _Label3.TabIndex = 2;
        _Label3.Text = "Cost:";
        _Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtPurchaseUnits
        // 
        _txtPurchaseUnits.Location = new System.Drawing.Point(48, 32);
        _txtPurchaseUnits.Name = "_txtPurchaseUnits";
        _txtPurchaseUnits.Size = new System.Drawing.Size(56, 20);
        _txtPurchaseUnits.TabIndex = 4;
        // 
        // lblRawName
        // 
        _lblRawName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblRawName.ForeColor = System.Drawing.Color.DarkBlue;
        _lblRawName.Location = new System.Drawing.Point(128, 8);
        _lblRawName.Name = "_lblRawName";
        _lblRawName.Size = new System.Drawing.Size(48, 23);
        _lblRawName.TabIndex = 0;
        _lblRawName.Text = "Name:";
        _lblRawName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // pnlNewRawQuestion
        // 
        _pnlNewRawQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        _pnlNewRawQuestion.Controls.Add(_btnRawAccept);
        _pnlNewRawQuestion.Controls.Add(_btnNewRawReset);
        _pnlNewRawQuestion.Controls.Add(_btnNewRawCopy);
        _pnlNewRawQuestion.Controls.Add(_btnRawCreate);
        _pnlNewRawQuestion.Controls.Add(_btnRawCancel);
        _pnlNewRawQuestion.Location = new System.Drawing.Point(48, 344);
        _pnlNewRawQuestion.Name = "_pnlNewRawQuestion";
        _pnlNewRawQuestion.Size = new System.Drawing.Size(224, 64);
        _pnlNewRawQuestion.TabIndex = 0;
        // 
        // btnRawAccept
        // 
        _btnRawAccept.Location = new System.Drawing.Point(8, 7);
        _btnRawAccept.Name = "_btnRawAccept";
        _btnRawAccept.Size = new System.Drawing.Size(96, 48);
        _btnRawAccept.TabIndex = 3;
        _btnRawAccept.Text = "Accept";
        // 
        // btnNewRawReset
        // 
        _btnNewRawReset.Location = new System.Drawing.Point(120, 8);
        _btnNewRawReset.Name = "_btnNewRawReset";
        _btnNewRawReset.Size = new System.Drawing.Size(96, 48);
        _btnNewRawReset.TabIndex = 2;
        _btnNewRawReset.Text = "Reset Info";
        // 
        // btnNewRawCopy
        // 
        _btnNewRawCopy.Location = new System.Drawing.Point(8, 8);
        _btnNewRawCopy.Name = "_btnNewRawCopy";
        _btnNewRawCopy.Size = new System.Drawing.Size(96, 48);
        _btnNewRawCopy.TabIndex = 1;
        _btnNewRawCopy.Text = "Copy ";
        // 
        // btnRawCreate
        // 
        _btnRawCreate.Location = new System.Drawing.Point(8, 8);
        _btnRawCreate.Name = "_btnRawCreate";
        _btnRawCreate.Size = new System.Drawing.Size(96, 48);
        _btnRawCreate.TabIndex = 0;
        _btnRawCreate.Text = "Create New";
        _btnRawCreate.Visible = false;
        // 
        // btnRawCancel
        // 
        _btnRawCancel.Location = new System.Drawing.Point(120, 8);
        _btnRawCancel.Name = "_btnRawCancel";
        _btnRawCancel.Size = new System.Drawing.Size(96, 48);
        _btnRawCancel.TabIndex = 1;
        _btnRawCancel.Text = "Cancel";
        _btnRawCancel.Visible = false;
        // 
        // Label1
        // 
        _Label1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        _Label1.Location = new System.Drawing.Point(489, 32);
        _Label1.Name = "_Label1";
        _Label1.Size = new System.Drawing.Size(162, 20);
        _Label1.TabIndex = 4;
        _Label1.Text = "PHYSICAL INVENTORY";
        _Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // lblRawRecipe
        // 
        _lblRawRecipe.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        _lblRawRecipe.Location = new System.Drawing.Point(320, 32);
        _lblRawRecipe.Name = "_lblRawRecipe";
        _lblRawRecipe.Size = new System.Drawing.Size(165, 20);
        _lblRawRecipe.TabIndex = 3;
        _lblRawRecipe.Text = "RECIPE";
        _lblRawRecipe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // lblRawPurchasing
        // 
        _lblRawPurchasing.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        _lblRawPurchasing.Location = new System.Drawing.Point(208, 32);
        _lblRawPurchasing.Name = "_lblRawPurchasing";
        _lblRawPurchasing.Size = new System.Drawing.Size(110, 20);
        _lblRawPurchasing.TabIndex = 2;
        _lblRawPurchasing.Text = "PURCHASING";
        _lblRawPurchasing.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // cbxRawMaterialCategory
        // 
        _cbxRawMaterialCategory.Location = new System.Drawing.Point(56, 8);
        _cbxRawMaterialCategory.MaxDropDownItems = 25;
        _cbxRawMaterialCategory.Name = "_cbxRawMaterialCategory";
        _cbxRawMaterialCategory.Size = new System.Drawing.Size(150, 21);
        _cbxRawMaterialCategory.TabIndex = 0;
        // 
        // grdRawMaterialList
        // 
        _grdRawMaterialList.BackgroundColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _grdRawMaterialList.CaptionVisible = false;
        _grdRawMaterialList.DataMember = "";
        _grdRawMaterialList.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        _grdRawMaterialList.Location = new System.Drawing.Point(56, 52);
        _grdRawMaterialList.Name = "_grdRawMaterialList";
        _grdRawMaterialList.RowHeadersVisible = false;
        _grdRawMaterialList.RowHeaderWidth = 0;
        _grdRawMaterialList.Size = new System.Drawing.Size(735, 450);
        _grdRawMaterialList.TabIndex = 0;
        _grdRawMaterialList.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] { _DataGridTableStyleRawMaterials });
        // 
        // DataGridTableStyleRawMaterials
        // 
        _DataGridTableStyleRawMaterials.AlternatingBackColor = System.Drawing.SystemColors.Info;
        _DataGridTableStyleRawMaterials.DataGrid = _grdRawMaterialList;
        _DataGridTableStyleRawMaterials.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] { _dgRawMatName, _dgRawPurchaseUnit, _dgRawPurchaseUnitPrice, _dgBlank, _dgRecipeUnits, _dgRecipeConversion, _dgRecipeUnitCost, _dgRecipeNo, _dgRecipeExtra, _dgRecipeExtraDollar, _dgBlank2, _dgPhysicalUnit, _dgPhysicalConversion, _dgPhysicalUnitCost, _dgPhysicalOnHand, _dgPhysicalTotalAmount });
        _DataGridTableStyleRawMaterials.HeaderBackColor = System.Drawing.SystemColors.ActiveCaption;
        _DataGridTableStyleRawMaterials.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        _DataGridTableStyleRawMaterials.MappingName = "RawMaterials";
        _DataGridTableStyleRawMaterials.RowHeadersVisible = false;
        // 
        // dgRawMatName
        // 
        _dgRawMatName.Format = "";
        _dgRawMatName.FormatInfo = (object)null;
        _dgRawMatName.HeaderText = "Raw Material Name";
        _dgRawMatName.MappingName = "RawItemName";
        _dgRawMatName.NullText = "";
        _dgRawMatName.Width = 150;
        // 
        // dgRawPurchaseUnit
        // 
        _dgRawPurchaseUnit.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
        _dgRawPurchaseUnit.Format = "";
        _dgRawPurchaseUnit.FormatInfo = (object)null;
        _dgRawPurchaseUnit.HeaderText = "Unit";
        _dgRawPurchaseUnit.MappingName = "PurchaseUnits";
        _dgRawPurchaseUnit.NullText = "";
        _dgRawPurchaseUnit.Width = 55;
        // 
        // dgRawPurchaseUnitPrice
        // 
        _dgRawPurchaseUnitPrice.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
        _dgRawPurchaseUnitPrice.Format = "##,###.00";
        _dgRawPurchaseUnitPrice.FormatInfo = (object)null;
        _dgRawPurchaseUnitPrice.HeaderText = "Cost $";
        _dgRawPurchaseUnitPrice.MappingName = "PurchaseCost";
        _dgRawPurchaseUnitPrice.NullText = "";
        _dgRawPurchaseUnitPrice.Width = 55;
        // 
        // dgBlank
        // 
        _dgBlank.Format = "";
        _dgBlank.FormatInfo = (object)null;
        _dgBlank.MappingName = "Blank";
        _dgBlank.NullText = "";
        _dgBlank.Width = 5;
        // 
        // dgRecipeUnits
        // 
        _dgRecipeUnits.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
        _dgRecipeUnits.Format = "";
        _dgRecipeUnits.FormatInfo = (object)null;
        _dgRecipeUnits.HeaderText = "Unit";
        _dgRecipeUnits.MappingName = "RecipeUnit";
        _dgRecipeUnits.NullText = "";
        _dgRecipeUnits.Width = 55;
        // 
        // dgRecipeConversion
        // 
        _dgRecipeConversion.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
        _dgRecipeConversion.Format = "";
        _dgRecipeConversion.FormatInfo = (object)null;
        _dgRecipeConversion.HeaderText = "Break";
        _dgRecipeConversion.MappingName = "RecipeConversion";
        _dgRecipeConversion.NullText = "";
        _dgRecipeConversion.Width = 55;
        // 
        // dgRecipeUnitCost
        // 
        _dgRecipeUnitCost.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
        _dgRecipeUnitCost.Format = "##,###.00";
        _dgRecipeUnitCost.FormatInfo = (object)null;
        _dgRecipeUnitCost.HeaderText = "Unit Cost $";
        _dgRecipeUnitCost.MappingName = "UnitCost";
        _dgRecipeUnitCost.NullText = "";
        _dgRecipeUnitCost.ReadOnly = true;
        _dgRecipeUnitCost.Width = 55;
        // 
        // dgRecipeNo
        // 
        _dgRecipeNo.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
        _dgRecipeNo.Format = "";
        _dgRecipeNo.FormatInfo = (object)null;
        _dgRecipeNo.MappingName = "SelectNo";
        _dgRecipeNo.NullText = "";
        _dgRecipeNo.Width = 0;
        // 
        // dgRecipeExtra
        // 
        _dgRecipeExtra.Format = "";
        _dgRecipeExtra.FormatInfo = (object)null;
        _dgRecipeExtra.MappingName = "SelectExtra";
        _dgRecipeExtra.NullText = "";
        _dgRecipeExtra.Width = 0;
        // 
        // dgRecipeExtraDollar
        // 
        _dgRecipeExtraDollar.Format = "";
        _dgRecipeExtraDollar.FormatInfo = (object)null;
        _dgRecipeExtraDollar.NullText = "";
        _dgRecipeExtraDollar.Width = 0;
        // 
        // dgBlank2
        // 
        _dgBlank2.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
        _dgBlank2.Format = "";
        _dgBlank2.FormatInfo = (object)null;
        _dgBlank2.MappingName = "Blank2";
        _dgBlank2.NullText = "";
        _dgBlank2.Width = 5;
        // 
        // dgPhysicalUnit
        // 
        _dgPhysicalUnit.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
        _dgPhysicalUnit.Format = "";
        _dgPhysicalUnit.FormatInfo = (object)null;
        _dgPhysicalUnit.HeaderText = "Inv Unit";
        _dgPhysicalUnit.MappingName = "PhysicalUnit";
        _dgPhysicalUnit.NullText = "";
        _dgPhysicalUnit.Width = 55;
        // 
        // dgPhysicalConversion
        // 
        _dgPhysicalConversion.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
        _dgPhysicalConversion.Format = "";
        _dgPhysicalConversion.FormatInfo = (object)null;
        _dgPhysicalConversion.HeaderText = "Break";
        _dgPhysicalConversion.MappingName = "PhysicalConversion";
        _dgPhysicalConversion.NullText = "";
        _dgPhysicalConversion.Width = 55;
        // 
        // dgPhysicalUnitCost
        // 
        _dgPhysicalUnitCost.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
        _dgPhysicalUnitCost.Format = "##,###.00";
        _dgPhysicalUnitCost.FormatInfo = (object)null;
        _dgPhysicalUnitCost.HeaderText = "Cost $";
        _dgPhysicalUnitCost.MappingName = "PhysicalUnitCost";
        _dgPhysicalUnitCost.NullText = "";
        _dgPhysicalUnitCost.ReadOnly = true;
        _dgPhysicalUnitCost.Width = 55;
        // 
        // dgPhysicalOnHand
        // 
        _dgPhysicalOnHand.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
        _dgPhysicalOnHand.Format = "";
        _dgPhysicalOnHand.FormatInfo = (object)null;
        _dgPhysicalOnHand.MappingName = "InvQuantity";
        _dgPhysicalOnHand.NullText = "";
        _dgPhysicalOnHand.Width = 0;
        // 
        // dgPhysicalTotalAmount
        // 
        _dgPhysicalTotalAmount.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
        _dgPhysicalTotalAmount.Format = "##,###.00";
        _dgPhysicalTotalAmount.FormatInfo = (object)null;
        _dgPhysicalTotalAmount.MappingName = "InvDollarAmount";
        _dgPhysicalTotalAmount.NullText = "";
        _dgPhysicalTotalAmount.ReadOnly = true;
        _dgPhysicalTotalAmount.Width = 0;
        // 
        // TabRawIngredients
        // 
        _TabRawIngredients.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _TabRawIngredients.Controls.Add(_grdRawDrinkList);
        _TabRawIngredients.Controls.Add(_chkAvailForExtra);
        _TabRawIngredients.Controls.Add(_btnShowAllRaw2);
        _TabRawIngredients.Controls.Add(_cbxRawMatIngredients);
        _TabRawIngredients.Controls.Add(_grdRawIngredients);
        _TabRawIngredients.Controls.Add(_btnShowAllFood);
        _TabRawIngredients.Controls.Add(_cbxFoodFilter);
        _TabRawIngredients.Controls.Add(_lblRawMatCost);
        _TabRawIngredients.Controls.Add(_lblRawMatLabel);
        _TabRawIngredients.Controls.Add(_txtRawAdd);
        _TabRawIngredients.Controls.Add(_btnRawAdd);
        _TabRawIngredients.Controls.Add(_btnRawMatRemove);
        _TabRawIngredients.Controls.Add(_grdRawMaterielListIngredients);
        _TabRawIngredients.Controls.Add(_lblRawFoodName);
        _TabRawIngredients.Controls.Add(_grdRawFoodList);
        _TabRawIngredients.Location = new System.Drawing.Point(4, 22);
        _TabRawIngredients.Name = "_TabRawIngredients";
        _TabRawIngredients.Size = new System.Drawing.Size(840, 518);
        _TabRawIngredients.TabIndex = 1;
        _TabRawIngredients.Text = "Raw Ingredients";
        // 
        // grdRawDrinkList
        // 
        _grdRawDrinkList.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
        _grdRawDrinkList.CaptionText = "            Choose Drink Item";
        _grdRawDrinkList.ColumnHeadersVisible = false;
        _grdRawDrinkList.DataMember = "";
        _grdRawDrinkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _grdRawDrinkList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
        _grdRawDrinkList.Location = new System.Drawing.Point(66, 86);
        _grdRawDrinkList.Name = "_grdRawDrinkList";
        _grdRawDrinkList.RowHeadersVisible = false;
        _grdRawDrinkList.Size = new System.Drawing.Size(184, 448);
        _grdRawDrinkList.TabIndex = 23;
        _grdRawDrinkList.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] { _tsRawDrinksItems });
        _grdRawDrinkList.Visible = false;
        // 
        // tsRawDrinksItems
        // 
        _tsRawDrinksItems.DataGrid = _grdRawDrinkList;
        _tsRawDrinksItems.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] { _DataGridTextBoxColumn1, _DataGridTextBoxColumn2 });
        _tsRawDrinksItems.GridLineColor = System.Drawing.SystemColors.Window;
        _tsRawDrinksItems.HeaderForeColor = System.Drawing.SystemColors.ControlText;
        _tsRawDrinksItems.MappingName = "Drinks";
        _tsRawDrinksItems.ReadOnly = true;
        _tsRawDrinksItems.RowHeadersVisible = false;
        // 
        // DataGridTextBoxColumn1
        // 
        _DataGridTextBoxColumn1.Format = "";
        _DataGridTextBoxColumn1.FormatInfo = (object)null;
        _DataGridTextBoxColumn1.MappingName = "DrinkID";
        _DataGridTextBoxColumn1.NullText = " ";
        _DataGridTextBoxColumn1.Width = 0;
        // 
        // DataGridTextBoxColumn2
        // 
        _DataGridTextBoxColumn2.Format = "";
        _DataGridTextBoxColumn2.FormatInfo = (object)null;
        _DataGridTextBoxColumn2.MappingName = "DrinkName";
        _DataGridTextBoxColumn2.Width = 150;
        // 
        // chkAvailForExtra
        // 
        _chkAvailForExtra.Location = new System.Drawing.Point(280, 392);
        _chkAvailForExtra.Name = "_chkAvailForExtra";
        _chkAvailForExtra.Size = new System.Drawing.Size(104, 32);
        _chkAvailForExtra.TabIndex = 22;
        _chkAvailForExtra.Text = "Track as Extra in Inventory";
        _chkAvailForExtra.Visible = false;
        // 
        // btnShowAllRaw2
        // 
        _btnShowAllRaw2.Location = new System.Drawing.Point(696, 40);
        _btnShowAllRaw2.Name = "_btnShowAllRaw2";
        _btnShowAllRaw2.Size = new System.Drawing.Size(96, 24);
        _btnShowAllRaw2.TabIndex = 21;
        _btnShowAllRaw2.Text = "Show All";
        // 
        // cbxRawMatIngredients
        // 
        _cbxRawMatIngredients.Location = new System.Drawing.Point(656, 16);
        _cbxRawMatIngredients.MaxDropDownItems = 20;
        _cbxRawMatIngredients.Name = "_cbxRawMatIngredients";
        _cbxRawMatIngredients.Size = new System.Drawing.Size(160, 21);
        _cbxRawMatIngredients.TabIndex = 20;
        // 
        // grdRawIngredients
        // 
        _grdRawIngredients.BackgroundColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _grdRawIngredients.CaptionVisible = false;
        _grdRawIngredients.DataMember = "";
        _grdRawIngredients.HeaderForeColor = System.Drawing.SystemColors.ControlText;
        _grdRawIngredients.Location = new System.Drawing.Point(208, 56);
        _grdRawIngredients.Name = "_grdRawIngredients";
        _grdRawIngredients.Size = new System.Drawing.Size(424, 304);
        _grdRawIngredients.TabIndex = 19;
        _grdRawIngredients.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] { _DataGridTableStyleRawIngredients });
        // 
        // DataGridTableStyleRawIngredients
        // 
        _DataGridTableStyleRawIngredients.AlternatingBackColor = System.Drawing.SystemColors.Info;
        _DataGridTableStyleRawIngredients.DataGrid = _grdRawIngredients;
        _DataGridTableStyleRawIngredients.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] { _dgRawItemID, _dgRawIngName, _dgRawIngUsageAmount, _dgRawIngRecipeUnit, _dgRawIngUnitCost, _dgRawIngExtCost });
        _DataGridTableStyleRawIngredients.HeaderBackColor = System.Drawing.SystemColors.ActiveCaption;
        _DataGridTableStyleRawIngredients.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        _DataGridTableStyleRawIngredients.MappingName = "RawUsageByItem";
        _DataGridTableStyleRawIngredients.ReadOnly = true;
        _DataGridTableStyleRawIngredients.RowHeadersVisible = false;
        // 
        // dgRawItemID
        // 
        _dgRawItemID.Format = "";
        _dgRawItemID.FormatInfo = (object)null;
        _dgRawItemID.MappingName = "RawItemID";
        _dgRawItemID.Width = 0;
        // 
        // dgRawIngName
        // 
        _dgRawIngName.Format = "";
        _dgRawIngName.FormatInfo = (object)null;
        _dgRawIngName.HeaderText = "      Ingredients";
        _dgRawIngName.MappingName = "RawItemName";
        _dgRawIngName.NullText = "";
        _dgRawIngName.Width = 135;
        // 
        // dgRawIngUsageAmount
        // 
        _dgRawIngUsageAmount.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
        _dgRawIngUsageAmount.Format = "##,###.##";
        _dgRawIngUsageAmount.FormatInfo = (object)null;
        _dgRawIngUsageAmount.HeaderText = "No. Units";
        _dgRawIngUsageAmount.MappingName = "RawUsageAmount";
        _dgRawIngUsageAmount.NullText = "";
        _dgRawIngUsageAmount.Width = 67;
        // 
        // dgRawIngRecipeUnit
        // 
        _dgRawIngRecipeUnit.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
        _dgRawIngRecipeUnit.Format = "";
        _dgRawIngRecipeUnit.FormatInfo = (object)null;
        _dgRawIngRecipeUnit.HeaderText = "Type Unit";
        _dgRawIngRecipeUnit.MappingName = "RecipeUnit";
        _dgRawIngRecipeUnit.NullText = "";
        _dgRawIngRecipeUnit.Width = 67;
        // 
        // dgRawIngUnitCost
        // 
        _dgRawIngUnitCost.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
        _dgRawIngUnitCost.Format = "##,###.00";
        _dgRawIngUnitCost.FormatInfo = (object)null;
        _dgRawIngUnitCost.HeaderText = "Unit Cost";
        _dgRawIngUnitCost.MappingName = "UnitCost";
        _dgRawIngUnitCost.NullText = "";
        _dgRawIngUnitCost.Width = 67;
        // 
        // dgRawIngExtCost
        // 
        _dgRawIngExtCost.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
        _dgRawIngExtCost.Format = "##,###.00";
        _dgRawIngExtCost.FormatInfo = (object)null;
        _dgRawIngExtCost.HeaderText = "Ext Cost";
        _dgRawIngExtCost.MappingName = "ExtendedCost";
        _dgRawIngExtCost.NullText = "";
        _dgRawIngExtCost.Width = 67;
        // 
        // btnShowAllFood
        // 
        _btnShowAllFood.Location = new System.Drawing.Point(56, 40);
        _btnShowAllFood.Name = "_btnShowAllFood";
        _btnShowAllFood.Size = new System.Drawing.Size(96, 24);
        _btnShowAllFood.TabIndex = 18;
        _btnShowAllFood.Text = "Show All";
        // 
        // cbxFoodFilter
        // 
        _cbxFoodFilter.Location = new System.Drawing.Point(8, 16);
        _cbxFoodFilter.MaxDropDownItems = 25;
        _cbxFoodFilter.Name = "_cbxFoodFilter";
        _cbxFoodFilter.Size = new System.Drawing.Size(184, 21);
        _cbxFoodFilter.TabIndex = 17;
        _cbxFoodFilter.Text = "Select Food Category";
        // 
        // lblRawMatCost
        // 
        _lblRawMatCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblRawMatCost.Location = new System.Drawing.Point(568, 368);
        _lblRawMatCost.Name = "_lblRawMatCost";
        _lblRawMatCost.Size = new System.Drawing.Size(48, 24);
        _lblRawMatCost.TabIndex = 8;
        _lblRawMatCost.TextAlign = System.Drawing.ContentAlignment.BottomRight;
        // 
        // lblRawMatLabel
        // 
        _lblRawMatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblRawMatLabel.Location = new System.Drawing.Point(440, 368);
        _lblRawMatLabel.Name = "_lblRawMatLabel";
        _lblRawMatLabel.Size = new System.Drawing.Size(112, 16);
        _lblRawMatLabel.TabIndex = 7;
        _lblRawMatLabel.Text = "Cost of Item:  $ ";
        _lblRawMatLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // txtRawAdd
        // 
        _txtRawAdd.Location = new System.Drawing.Point(568, 440);
        _txtRawAdd.Name = "_txtRawAdd";
        _txtRawAdd.Size = new System.Drawing.Size(40, 20);
        _txtRawAdd.TabIndex = 6;
        _txtRawAdd.Text = "1";
        _txtRawAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // btnRawAdd
        // 
        _btnRawAdd.Location = new System.Drawing.Point(448, 408);
        _btnRawAdd.Name = "_btnRawAdd";
        _btnRawAdd.Size = new System.Drawing.Size(96, 40);
        _btnRawAdd.TabIndex = 5;
        _btnRawAdd.Text = "Add";
        // 
        // btnRawMatRemove
        // 
        _btnRawMatRemove.Location = new System.Drawing.Point(448, 456);
        _btnRawMatRemove.Name = "_btnRawMatRemove";
        _btnRawMatRemove.Size = new System.Drawing.Size(96, 40);
        _btnRawMatRemove.TabIndex = 4;
        _btnRawMatRemove.Text = "Remove";
        // 
        // grdRawMaterielListIngredients
        // 
        _grdRawMaterielListIngredients.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
        _grdRawMaterielListIngredients.CaptionText = "              Raw Materials";
        _grdRawMaterielListIngredients.ColumnHeadersVisible = false;
        _grdRawMaterielListIngredients.DataMember = "";
        _grdRawMaterielListIngredients.HeaderForeColor = System.Drawing.SystemColors.ControlText;
        _grdRawMaterielListIngredients.Location = new System.Drawing.Point(648, 64);
        _grdRawMaterielListIngredients.Name = "_grdRawMaterielListIngredients";
        _grdRawMaterielListIngredients.RowHeadersVisible = false;
        _grdRawMaterielListIngredients.Size = new System.Drawing.Size(176, 448);
        _grdRawMaterielListIngredients.TabIndex = 2;
        _grdRawMaterielListIngredients.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] { _DataGridTableStyleRawIngredMat });
        // 
        // DataGridTableStyleRawIngredMat
        // 
        _DataGridTableStyleRawIngredMat.ColumnHeadersVisible = false;
        _DataGridTableStyleRawIngredMat.DataGrid = _grdRawMaterielListIngredients;
        _DataGridTableStyleRawIngredMat.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] { _dgRawIngMatID, _dgRawIngBreakPercent, _dgRawIngCost, _dgRawIngMatName });
        _DataGridTableStyleRawIngredMat.GridLineColor = System.Drawing.SystemColors.ActiveCaptionText;
        _DataGridTableStyleRawIngredMat.HeaderForeColor = System.Drawing.SystemColors.ControlText;
        _DataGridTableStyleRawIngredMat.MappingName = "RawMaterials";
        _DataGridTableStyleRawIngredMat.ReadOnly = true;
        _DataGridTableStyleRawIngredMat.RowHeadersVisible = false;
        // 
        // dgRawIngMatID
        // 
        _dgRawIngMatID.Format = "";
        _dgRawIngMatID.FormatInfo = (object)null;
        _dgRawIngMatID.MappingName = "RawItemID";
        _dgRawIngMatID.NullText = "";
        _dgRawIngMatID.Width = 0;
        // 
        // dgRawIngBreakPercent
        // 
        _dgRawIngBreakPercent.Format = "";
        _dgRawIngBreakPercent.FormatInfo = (object)null;
        _dgRawIngBreakPercent.MappingName = "RecipeUnit";
        _dgRawIngBreakPercent.NullText = "";
        _dgRawIngBreakPercent.ReadOnly = true;
        _dgRawIngBreakPercent.Width = 30;
        // 
        // dgRawIngCost
        // 
        _dgRawIngCost.Format = "";
        _dgRawIngCost.FormatInfo = (object)null;
        _dgRawIngCost.MappingName = "UnitCost";
        _dgRawIngCost.NullText = "";
        _dgRawIngCost.ReadOnly = true;
        _dgRawIngCost.Width = 0;
        // 
        // dgRawIngMatName
        // 
        _dgRawIngMatName.Format = "";
        _dgRawIngMatName.FormatInfo = (object)null;
        _dgRawIngMatName.MappingName = "RawItemName";
        _dgRawIngMatName.NullText = "";
        _dgRawIngMatName.Width = 125;
        // 
        // lblRawFoodName
        // 
        _lblRawFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblRawFoodName.ForeColor = System.Drawing.Color.White;
        _lblRawFoodName.Location = new System.Drawing.Point(232, 16);
        _lblRawFoodName.Name = "_lblRawFoodName";
        _lblRawFoodName.Size = new System.Drawing.Size(364, 32);
        _lblRawFoodName.TabIndex = 1;
        _lblRawFoodName.Text = "Food Item";
        _lblRawFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // grdRawFoodList
        // 
        _grdRawFoodList.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
        _grdRawFoodList.CaptionText = "            Choose Food Item";
        _grdRawFoodList.ColumnHeadersVisible = false;
        _grdRawFoodList.DataMember = "";
        _grdRawFoodList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _grdRawFoodList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
        _grdRawFoodList.Location = new System.Drawing.Point(8, 64);
        _grdRawFoodList.Name = "_grdRawFoodList";
        _grdRawFoodList.RowHeadersVisible = false;
        _grdRawFoodList.Size = new System.Drawing.Size(184, 448);
        _grdRawFoodList.TabIndex = 0;
        _grdRawFoodList.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] { _tsFoodList });
        // 
        // tsFoodList
        // 
        _tsFoodList.DataGrid = _grdRawFoodList;
        _tsFoodList.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] { _dcRawFoodID, _dcRawFoodName });
        _tsFoodList.GridLineColor = System.Drawing.SystemColors.Window;
        _tsFoodList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
        _tsFoodList.MappingName = "FoodTable";
        _tsFoodList.ReadOnly = true;
        _tsFoodList.RowHeadersVisible = false;
        // 
        // dcRawFoodID
        // 
        _dcRawFoodID.Format = "";
        _dcRawFoodID.FormatInfo = (object)null;
        _dcRawFoodID.MappingName = "FoodID";
        _dcRawFoodID.NullText = " ";
        _dcRawFoodID.Width = 0;
        // 
        // dcRawFoodName
        // 
        _dcRawFoodName.Format = "";
        _dcRawFoodName.FormatInfo = (object)null;
        _dcRawFoodName.MappingName = "FoodName";
        _dcRawFoodName.NullText = "";
        _dcRawFoodName.Width = 150;
        // 
        // pnlRawUsageList
        // 
        _pnlRawUsageList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _pnlRawUsageList.Location = new System.Drawing.Point(688, 24);
        _pnlRawUsageList.Name = "_pnlRawUsageList";
        _pnlRawUsageList.Size = new System.Drawing.Size(176, 104);
        _pnlRawUsageList.TabIndex = 3;
        // 
        // btnRawMatDelete
        // 
        _btnRawMatDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _btnRawMatDelete.ForeColor = System.Drawing.Color.White;
        _btnRawMatDelete.Location = new System.Drawing.Point(248, 32);
        _btnRawMatDelete.Name = "_btnRawMatDelete";
        _btnRawMatDelete.Size = new System.Drawing.Size(96, 48);
        _btnRawMatDelete.TabIndex = 2;
        _btnRawMatDelete.Text = "Delete";
        // 
        // btnRawMatUpdate
        // 
        _btnRawMatUpdate.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _btnRawMatUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _btnRawMatUpdate.ForeColor = System.Drawing.Color.White;
        _btnRawMatUpdate.Location = new System.Drawing.Point(368, 32);
        _btnRawMatUpdate.Name = "_btnRawMatUpdate";
        _btnRawMatUpdate.Size = new System.Drawing.Size(96, 48);
        _btnRawMatUpdate.TabIndex = 1;
        _btnRawMatUpdate.Text = "Calculate";
        _btnRawMatUpdate.UseVisualStyleBackColor = false;
        // 
        // btnRawNew
        // 
        _btnRawNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _btnRawNew.ForeColor = System.Drawing.Color.White;
        _btnRawNew.Location = new System.Drawing.Point(16, 32);
        _btnRawNew.Name = "_btnRawNew";
        _btnRawNew.Size = new System.Drawing.Size(96, 48);
        _btnRawNew.TabIndex = 3;
        _btnRawNew.Text = "New";
        // 
        // ErrorProvider1
        // 
        _ErrorProvider1.ContainerControl = this;
        // 
        // btnRawMatChange
        // 
        _btnRawMatChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _btnRawMatChange.ForeColor = System.Drawing.Color.White;
        _btnRawMatChange.Location = new System.Drawing.Point(128, 32);
        _btnRawMatChange.Name = "_btnRawMatChange";
        _btnRawMatChange.Size = new System.Drawing.Size(96, 48);
        _btnRawMatChange.TabIndex = 4;
        _btnRawMatChange.Text = "Change";
        // 
        // Panel5
        // 
        _Panel5.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        _Panel5.Controls.Add(_btnRawNew);
        _Panel5.Controls.Add(_btnRawMatChange);
        _Panel5.Controls.Add(_btnRawMatDelete);
        _Panel5.Controls.Add(_btnRawMatUpdate);
        _Panel5.Location = new System.Drawing.Point(208, 24);
        _Panel5.Name = "_Panel5";
        _Panel5.Size = new System.Drawing.Size(480, 100);
        _Panel5.TabIndex = 5;
        // 
        // SetupRawMaterials
        // 
        this.BackColor = System.Drawing.Color.FromArgb(0, 78, 152);
        this.Controls.Add(_Panel5);
        this.Controls.Add(_TabControl1);
        this.Controls.Add(_pnlRawUsageList);
        this.Name = "SetupRawMaterials";
        this.Size = new System.Drawing.Size(888, 696);
        _TabControl1.ResumeLayout(false);
        _TabRawMaterials.ResumeLayout(false);
        _pnlNewRawMaterial.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)_grdRawDrinkNames).EndInit();
        _pnlRawInfo.ResumeLayout(false);
        _pnlRawInfo.PerformLayout();
        _Panel4.ResumeLayout(false);
        _Panel3.ResumeLayout(false);
        _Panel3.PerformLayout();
        _Panel2.ResumeLayout(false);
        _Panel2.PerformLayout();
        _Panel1.ResumeLayout(false);
        _Panel1.PerformLayout();
        _pnlNewRawQuestion.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)_grdRawMaterialList).EndInit();
        _TabRawIngredients.ResumeLayout(false);
        _TabRawIngredients.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_grdRawDrinkList).EndInit();
        ((System.ComponentModel.ISupportInitialize)_grdRawIngredients).EndInit();
        ((System.ComponentModel.ISupportInitialize)_grdRawMaterielListIngredients).EndInit();
        ((System.ComponentModel.ISupportInitialize)_grdRawFoodList).EndInit();
        ((System.ComponentModel.ISupportInitialize)_ErrorProvider1).EndInit();
        _Panel5.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private void InitializeOther()
    {

        grdRawDrinkList.Location = new Point(8, 64);
        BindData();

    }

    private void CreateDrinkGrid()
    {


    }

    internal void StartRaw()
    {

        PopulateRawCategory();
        PopulateRawMaterialData();
        PopulateRawUsageData();
        PopulateFoodTable();     // ???? put all same place
        // 444  BindData()

    }
    private void PopulateRawCategory()
    {

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlRawCategory.Fill(dsSetup.Tables("RawCategories"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);
        }
    }

    private void PopulateRawMaterialData()
    {

        dsSetup.Tables("RawMaterials").Clear();
        sql.SqlSelectCommandRawMat.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandRawMat.Parameters("@LocationID").Value = corpPhysicalLocation;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlRawMat.Fill(dsSetup.Tables("RawMaterials"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);
        }

        // dvRawMaterials = New DataView
        {
            ref var withBlock = ref dvRawMaterials;
            withBlock.Table = dsSetup.Tables("RawMaterials");
            withBlock.RowFilter = "RawCategoryID > 0";
        }

    }

    private void PopulateRawUsageData()
    {

        sql.SqlSelectCommandRawUsageByItem.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandRawUsageByItem.Parameters("@LocationID").Value = corpPhysicalLocation;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlRawUsageByItem.Fill(dsSetup.Tables("RawUsageByItem"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);
        }

        {
            ref var withBlock = ref dvRawUsageByItem;
            withBlock.Table = dsSetup.Tables("RawUsageByItem");
            withBlock.RowFilter = "FoodID = 0";
        }

    }

    private void PopulateFoodTable()
    {

        {
            var withBlock = dvFoods;
            withBlock.Table = dsSetup.Tables("FoodTable");
            withBlock.RowFilter = "FunctionFlag = 'F'";
        }
        return;
        // 444

        dsSetup.Tables("FoodTable").Clear();

        sql.SqlSelectCommandFoodsByFunction.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandFoodsByFunction.Parameters("@LocationID").Value = selectedLocation;
        // sql.SqlSelectCommandFoodsByFunction.Parameters("@CategoryID").Value = 100

        sql.cn.Open();
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
        sql.SqlDataAdapterFoodsByFunction.Fill(dsSetup.Tables("FoodTable"));
        sql.cn.Close();

    }

    private void BindData()
    {


        PopulateRawComboBoxes();

        RawCurrencyMan = this.BindingContext(dvRawMaterials); // (dsSetup.Tables("RawMaterials"))
        RawIngredientCurrencyMan = this.BindingContext(dvRawUsageByItem);
        // RawAddingIngredientCurrencyMan = Me.BindingContext(Me.dvRawMaterials)

        grdRawMaterialList.DataSource = dvRawMaterials;   // dsSetup.Tables("RawMaterials")
        grdRawMaterielListIngredients.DataSource = dvRawMaterials;    // dsSetup.Tables("RawMaterials")
        grdRawIngredients.DataSource = dvRawUsageByItem;

        RawFoodCurrencyMan = this.BindingContext(dvFoods); // dsSetup.Tables("FoodTable"))
        grdRawFoodList.DataSource = dvFoods;  // dsSetup.Tables("FoodTable")
        grdRawDrinkList.DataSource = dvDrinks;

        // Me.lblRawFoodName.DataBindings.Add("Text", dsSetup.Tables("FoodTable"), "FoodName")
        // below is giving erro, so just temp got rid of 
        // because not much value
        // 444    Me.chkAvailForExtra.DataBindings.Add("Checked", dvFoods, "AvailForExtraNo")

        grdRawDrinkNames.DataSource = dvDrinksByCategory;



        var csRawDrinkName = new DataGridTextBoxColumn();
        // tsRawDrinkNames.MappingName = "DrinkName" '"Modifiers2"
        tsRawDrinkNames.RowHeadersVisible = false;
        tsRawDrinkNames.GridLineColor = Color.White;

        csRawDrinkName.MappingName = "DrinkName";
        csRawDrinkName.Width = grdRawDrinkNames.Width * 0.85d;

        tsRawDrinkNames.GridColumnStyles.Add(csRawDrinkName);
        grdRawDrinkNames.TableStyles.Add(tsRawDrinkNames);

    }

    private void PopulateRawComboBoxes()
    {
        DataRow oRow;
        string rawCatName;

        cbxFoodFilter.Items.Clear();
        cbxRawMatIngredients.Items.Clear();

        foreach (DataRow currentORow in dsSetup.Tables("RawCategories").Rows)
        {
            oRow = currentORow;
            if (oRow("RawCategoryID") == oRow("RawSubCategory"))
            {
                rawCatName = oRow("RawCategoryName");
            }
            else
            {
                rawCatName = " " + oRow("RawCategoryName");
            }
            cbxRawMaterialCategory.Items.Add(rawCatName); // Material Tab
            cbxNewCategory.Items.Add(rawCatName);         // Material Tab
            cbxRawMatIngredients.Items.Add(rawCatName);
        }


        {
            var withBlock = dvMainCategory;
            withBlock.Table = dsSetup.Tables("MainCategory");
            withBlock.RowFilter = "FunctionFlag = 'F' OR FunctionFlag = 'O' AND Active = True"; // AND CategoryOrder < 11"
            // .Sort = "CategoryOrder"
        }

        foreach (DataRowView vRow in dvMainCategory)     // dsSetup.Tables("MainCategory").Rows
            cbxFoodFilter.Items.Add(vRow("CategoryName"));

        if (dsSetup.Tables("DrinkCategory").Rows.Count > 0)
        {
            foreach (DataRow currentORow1 in dsSetup.Tables("DrinkCategory").Rows)
            {
                oRow = currentORow1;
                if (!object.ReferenceEquals(oRow("DrinkCategoryName"), DBNull.Value))
                {
                    cbxFoodFilter.Items.Add(oRow("DrinkCategoryName"));
                }
            }
        }


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
            // sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "G"
            // sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetail"))
            // sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "F"
            // sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetail"))
            // sql.SqlSelectCommandMenuDetail.Parameters("@Flag").Value = "O"
            // sql.SqlMenuMenuDetail.Fill(dsSetup.Tables("OrderMenuDetail"))
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        cbxNewRawMatExistingCat.Items.Clear();
        // dtDrinkCateogy is "DrinkCategory" Table
        if (dsSetup.Tables("DrinkCategory").Rows.Count > 0)
        {
            foreach (DataRow currentORow2 in dsSetup.Tables("DrinkCategory").Rows)
            {
                oRow = currentORow2;
                if (!object.ReferenceEquals(oRow("DrinkCategoryName"), DBNull.Value))
                {
                    cbxNewRawMatExistingCat.Items.Add(oRow("DrinkCategoryName"));
                }
            }
        }

        foreach (DataRow currentORow3 in dsSetup.Tables("OrderMenuDetail").Rows)
        {
            oRow = currentORow3;
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                // not pulling food right now

            }
        }

        // For Each oRow In dsSetup.Tables("ModifierCategory").Rows
        // If Not oRow.RowState = DataRowState.Deleted And Not oRow.RowState = DataRowState.Detached Then
        // If oRow("Active") = True Then
        // Me.cbxFoodFilter.Items.Add(oRow("CategoryName"))
        // Me.cbxRawMatIngredients.Items.Add(oRow("CategoryName"))
        // End If
        // End If
        // Next

    }

    private void cbxRawMaterialCategory_SelectedIndexChanged(object sender, EventArgs e)
    {

        int valueRawID;
        int valueSubID;
        string filterString;

        valueRawID = dsSetup.Tables("RawCategories").Rows(cbxRawMaterialCategory.SelectedIndex)("RawCategoryID");
        valueSubID = dsSetup.Tables("RawCategories").Rows(cbxRawMaterialCategory.SelectedIndex)("RawSubCategory");

        if (valueRawID == valueSubID)
        {
            filterString = "RawCategoryID = " + valueRawID;
            foreach (DataRow oRow in dsSetup.Tables("RawCategories").Rows)
            {
                if (oRow("RawSubCategory") == valueRawID)
                {
                    filterString = filterString + " OR RawCategoryID = " + oRow("RawCategoryID").ToString;
                }
            }
        }

        else
        {
            filterString = "RawCategoryID = " + valueRawID;
        }

        dvRawMaterials.RowFilter = filterString;

    }

    private void cbxRawMatIngredients_SelectedIndexChanged(object sender, EventArgs e)
    {

        int valueRawID;
        int valueSubID;
        string filterString;

        valueRawID = dsSetup.Tables("RawCategories").Rows(cbxRawMatIngredients.SelectedIndex)("RawCategoryID");
        valueSubID = dsSetup.Tables("RawCategories").Rows(cbxRawMatIngredients.SelectedIndex)("RawSubCategory");

        if (valueRawID == valueSubID)
        {
            filterString = "RawCategoryID = " + valueRawID;
            foreach (DataRow oRow in dsSetup.Tables("RawCategories").Rows)
            {
                if (oRow("RawSubCategory") == valueRawID)
                {
                    filterString = filterString + " OR RawCategoryID = " + oRow("RawCategoryID").ToString;
                }
            }
        }

        else
        {
            filterString = "RawCategoryID = " + valueRawID;
        }

        dvRawMaterials.RowFilter = filterString;

    }

    private void TabRawMaterial_Leave(object sender, EventArgs e)
    {

        if (dsSetup.HasChanges)
        {
            UpdateRawMaterials();
            // UpdateRawUsageData()

            // If MsgBox("Are you sure you want to leave Raw Materials without saving?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            // Me.Focus()
            // Else
            // Exit Sub
            // End If
        }

    }

    private void TabRawIngredients_Leave(object sender, EventArgs e)
    {

        if (dsSetup.HasChanges)
        {
            UpdateRawUsageData();
            UpdateDatabaseFoods();

        }

    }

    private void UpdateRawMaterials()
    {
        var corpIDTable = new DataSet();

        try
        {
            corpIDTable = dsSetup.GetChanges;

            if (corpIDTable.Tables("RawMaterials").Rows.Count > 0)
            {
                foreach (DataRow oRow in corpIDTable.Tables("RawMaterials").Rows)    // dsSetup.Tables("RawMaterials").Rows
                {
                    if (object.ReferenceEquals(oRow("CompanyID"), DBNull.Value))
                    {
                        oRow("CompanyID") = corpID;
                    }
                }

                sql.cn.Open();
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
                sql.SqlRawMat.Update(corpIDTable.Tables("RawMaterials"));
                sql.cn.Close();
            }

            dsSetup.Tables("RawMaterials").AcceptChanges();
        }

        catch (Exception ex)
        {

        }


    }

    private void BtnRawMatUpdate_Click(object sender, EventArgs e)
    {

        if (TabRawMaterials.Focus.ToString == true)
        {
            UpdateRawMaterials();
            PopulateRawMaterialData();
        }
        else if (TabRawIngredients.Focus.ToString == true)
        {
            UpdateRawUsageData();
        }

    }

    private void btnRawMatDelete_Click(object sender, EventArgs e)
    {

        return;
        // will not work yet b/c CurrencyMan is on dataview

        DataRow oRow;

        UpdateRawMaterials();

        oRow = dsSetup.Tables("RawMaterials").Rows(RawCurrencyMan.Position);
        oRow.Delete();

        sql.cn.Open();
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
        sql.SqlRawMat.Update(dsSetup.Tables("RawMaterials"));
        sql.cn.Close();

    }





    // *****************************************



    private void grdRawFoodList_Changed(object sender, EventArgs e)
    {

        // UpdateRawUsageData()
        // grdRawIngredients.ResetBackColor()

        // Dim valueFoodID As Integer
        // Dim valueFoodName As String
        if (rawUsageChanged == true)
        {
            UpdateRawUsageData();
        }

        searchFoodID = DetermineID(grdRawFoodList, 0);
        searchFoodName = DetermineString(grdRawFoodList, 1);
        lblRawFoodName.Text = searchFoodName;

        {
            ref var withBlock = ref dvRawUsageByItem;
            withBlock.Table = dsSetup.Tables("RawUsageByItem");
            withBlock.RowFilter = "FoodID = " + searchFoodID;
        }
        // dvRawUsageByItem.RowFilter = "FoodID = " & searchFoodID

        // 444     If dvRawUsageByItem.Count = 1 Then
        // chkAvailForExtra.Enabled = True
        // Else
        // chkAvailForExtra.Enabled = False
        // End If

        DisplayCostofItem();

    }

    private void grdRawDrinkList_Changed(object sender, EventArgs e)
    {

        if (rawUsageChanged == true)
        {
            UpdateRawUsageData();
        }

        searchFoodID = DetermineID(grdRawDrinkList, 0);
        searchFoodName = DetermineString(grdRawDrinkList, 1);
        lblRawFoodName.Text = searchFoodName;

        {
            ref var withBlock = ref dvRawUsageByItem;
            withBlock.Table = dsSetup.Tables("RawUsageByItem");
            withBlock.RowFilter = "DrinkID = " + searchFoodID;
        }

        return;
        // 999   below needs change

        if (dvRawUsageByItem.Count == 1)
        {
            chkAvailForExtra.Enabled = true;
        }
        else
        {
            chkAvailForExtra.Enabled = false;
        }

        // DisplayCostofItem()

    }


    private void UpdateRawUsageData()
    {

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlRawUsageByItemUpdate.Update(dsSetup, "RawUsageByItem");
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);
        }

        UpdateFoodCostInFoodTable();
        dsSetup.AcceptChanges();
        rawUsageChanged = false;

    }

    private void UpdateFoodCostInFoodTable()
    {
        foreach (DataRowView vRow in dvFoods)
        {
            if (!object.ReferenceEquals(vRow("FoodID"), DBNull.Value))
            {
                if (vRow("FoodID") == searchFoodID)
                {
                    if (vRow("FoodCostManual") == false)
                    {
                        vRow("FoodCost") = Strings.Format(itemCost, "#,###.00");
                        break;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlMenuFoods.Update(dsSetup, "FoodTable");
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);
        }

    }

    private void DisplayCostofItem()
    {
        itemCost = 0m;

        foreach (DataRowView vrow in dvRawUsageByItem)
        {
            if (!object.ReferenceEquals(vrow("UnitCost"), DBNull.Value) & !object.ReferenceEquals(vrow("RawUsageAmount"), DBNull.Value))
            {
                itemCost += vrow("UnitCost") * vrow("RawUsageAmount");
                vrow("ExtendedCost") = vrow("UnitCost") * vrow("RawUsageAmount");
            }
        }

        lblRawMatCost.Text = Strings.Format(itemCost, "#,###.00");

    }


    private void btnRawAdd_Click(object sender, EventArgs e)
    {

        int searchRawID;
        // Dim searchRawName As String
        // MsgBox(DetermineString(Me.grdRawMaterielListIngredients, 3))

        if (removingFromCurrentIngredients == true)
        {
            if (grdRawIngredients.CurrentRowIndex == -1)
            {
                Interaction.MsgBox("Please select a Ingredient to Add");
                return;
            }
            searchRawID = grdRawIngredients.Item(grdRawIngredients.CurrentRowIndex, 0);
        }
        else
        {
            searchRawID = grdRawMaterielListIngredients.Item(grdRawMaterielListIngredients.CurrentRowIndex, 0);
        }

        DataRow oRow;

        // this is if selection is already an ingredient
        foreach (DataRowView vRow in dvRawUsageByItem)
        {
            if (vRow("RawItemID") == searchRawID)
            {
                vRow("RawUsageAmount") += (decimal)txtRawAdd.Text;
                rawUsageChanged = true;
                DisplayCostofItem();
                // FilterRawUsageData()
                return;
            }
        }

        UpdateRawUsageData();
        oRow = dsSetup.Tables("RawUsageByItem").NewRow; // 

        oRow("CompanyID") = corpID;
        oRow("LocationID") = corpPhysicalLocation;
        if (rawUsageFunFlag == "D")
        {
            oRow("FoodID") = 0;
            oRow("DrinkID") = searchFoodID;
        }
        else
        {
            oRow("FoodID") = searchFoodID;
            oRow("DrinkID") = 0;
        }
        oRow("RawItemID") = grdRawMaterielListIngredients.Item(grdRawMaterielListIngredients.CurrentRowIndex, 0);
        oRow("RawUsageAmount") = (decimal)txtRawAdd.Text;
        oRow("RawItemName") = grdRawMaterielListIngredients.Item(grdRawMaterielListIngredients.CurrentRowIndex, 3);
        oRow("RecipeUnit") = grdRawMaterielListIngredients.Item(grdRawMaterielListIngredients.CurrentRowIndex, 1);
        oRow("UnitCost") = grdRawMaterielListIngredients.Item(grdRawMaterielListIngredients.CurrentRowIndex, 2);
        if (!object.ReferenceEquals(oRow("UnitCost"), DBNull.Value) & !object.ReferenceEquals(oRow("RawUsageAmount"), DBNull.Value))
        {
            oRow("ExtendedCost") = oRow("UnitCost") * oRow("RawUsageAmount");
        }

        dsSetup.Tables("RawUsageByItem").Rows.Add(oRow);
        oRow("RawUsageID") = InsertingNewRawUsageByItem(ref oRow);
        dsSetup.Tables("RawUsageByItem").AcceptChanges();

        if (dvRawUsageByItem.Count == 1 & oRow("FoodID") > 0)
        {
            // MsgBox(String.Compare(searchFoodName, oRow("RawItemName"), True))
            if (string.Compare(searchFoodName, oRow("RawItemName"), true) == 0)
            {
                chkAvailForExtra.Checked = true;
            }
            chkAvailForExtra.Enabled = true;
        }
        else
        {
            chkAvailForExtra.Checked = false;
            chkAvailForExtra.Enabled = false;
        }

        DisplayCostofItem();

        // rawUsageChanged = True
        // FilterRawUsageData()

    }

    private object InsertingNewRawUsageByItem(ref DataRow oRow)
    {
        var newRawUsageID = default(int);

        sql.SqlInsertCommandRawUsageByItem.Parameters("@CompanyID").Value = corpID;
        sql.SqlInsertCommandRawUsageByItem.Parameters("@LocationID").Value = corpPhysicalLocation;
        sql.SqlInsertCommandRawUsageByItem.Parameters("@FoodID").Value = oRow("FoodID");
        sql.SqlInsertCommandRawUsageByItem.Parameters("@DrinkID").Value = oRow("DrinkID");
        sql.SqlInsertCommandRawUsageByItem.Parameters("@RawItemID").Value = oRow("RawItemID");
        sql.SqlInsertCommandRawUsageByItem.Parameters("@RawUsageAmount").Value = oRow("RawUsageAmount");
        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            newRawUsageID = (int)sql.SqlInsertCommandRawUsageByItem.ExecuteScalar;
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);
        }

        return newRawUsageID;

    }

    private void btnRawMatRemove_Click(object sender, EventArgs e)
    {
        int searchRawID;

        if (removingFromCurrentIngredients == true)
        {
            if (grdRawIngredients.CurrentRowIndex == -1)
            {
                return;
            }
            searchRawID = grdRawIngredients.Item(grdRawIngredients.CurrentRowIndex, 0);
        }
        else
        {
            searchRawID = grdRawMaterielListIngredients.Item(grdRawMaterielListIngredients.CurrentRowIndex, 0);
        }

        foreach (DataRowView vRow in dvRawUsageByItem)
        {
            if (vRow("RawItemID") == searchRawID)
            {
                vRow("RawUsageAmount") -= (decimal)txtRawAdd.Text;
                rawUsageChanged = true;
                DisplayCostofItem();
                if (vRow("RawUsageAmount") <= 0)
                {
                    vRow.Delete();
                    break;
                }
                break;
            }
        }

        if (dvRawUsageByItem.Count == 1)
        {
            chkAvailForExtra.Enabled = true;
        }
        else
        {
            chkAvailForExtra.Checked = false;
            chkAvailForExtra.Enabled = false;
        }
        // FilterRawUsageData()
        // UpdateRawUsageData()
    }


    private void btnRawNew_Click(object sender, EventArgs e)
    {
        pnlRawInfo.Visible = false;
        btnNewRawCopy.Visible = true;
        btnNewRawReset.Visible = true;
        btnRawAccept.Visible = false;
        btnRawCreate.Visible = false;
        btnRawCancel.Visible = false;
        pnlNewRawMaterial.Visible = true;

    }


    private void btnNewRawCopy_Click(object sender, EventArgs e)
    {
        // we are copying last raw materia
        btnNewRawCopy.Visible = false;
        btnNewRawReset.Visible = false;
        btnRawCreate.Visible = true;
        btnRawCancel.Visible = true;
        txtRawName.Text = "";

        InsertRawMatData(true);

        pnlRawInfo.Visible = true;
        txtRawName.Focus();

    }



    private void btnRawMatChange_Click(object sender, EventArgs e)
    {

        // we are copying last raw materia
        btnNewRawCopy.Visible = false;
        btnNewRawReset.Visible = false;
        btnRawCreate.Visible = false;
        btnRawAccept.Visible = true;
        btnRawCancel.Visible = true;

        InsertRawMatData(false);

        pnlNewRawMaterial.Visible = true;
        pnlRawInfo.Visible = true;
        txtRawName.Focus();

    }

    private void InsertRawMatData(bool isNew)
    {

        DataRowView vRow;
        if (RawCurrencyMan.Position == -1)
        {
            cbxNewCategory.SelectedIndex = cbxRawMaterialCategory.SelectedIndex;
            newRawCategoryID = dsSetup.Tables("RawCategories").Rows(cbxRawMaterialCategory.SelectedIndex)("RawCategoryID");
            return;
        }

        vRow = this.dvRawMaterials(RawCurrencyMan.Position);

        if (isNew == false)
        {
            if (!object.ReferenceEquals(vRow("RawItemName"), DBNull.Value))
            {
                txtRawName.Text = vRow("RawItemName");
            }
            else
            {
                txtRawName.Text = "";
            }
        }

        if (!object.ReferenceEquals(vRow("PurchaseUnits"), DBNull.Value))
        {
            txtPurchaseUnits.Text = vRow("PurchaseUnits");
        }
        else
        {
            txtPurchaseUnits.Text = "";
        }
        if (!object.ReferenceEquals(vRow("PurchaseCost"), DBNull.Value))
        {
            txtPurchaseCost.Text = vRow("PurchaseCost");
        }
        else
        {
            txtPurchaseCost.Text = "";
        }

        // #### Recipe
        if (!object.ReferenceEquals(vRow("RecipeUnit"), DBNull.Value))
        {
            txtRecipeUnits.Text = vRow("RecipeUnit");
        }
        else
        {
            txtRecipeUnits.Text = "";
        }
        if (!object.ReferenceEquals(vRow("RecipeConversion"), DBNull.Value))
        {
            txtRecipeConversion.Text = vRow("RecipeConversion");
        }
        else
        {
            txtRecipeConversion.Text = "";
        }

        txtRecipeUnitCost.Text = Strings.Format(vRow("PurchaseCost") / vRow("RecipeConversion"), "###.00");
        chkRecipeSelectNo.Checked = vRow("SelectNo");

        chkRecipeSelectExtra.Checked = vRow("SelectExtra");
        txtRecipeSelectExtra.Text = Strings.Format(vRow("ExtraPrice"), "###.00");


        // #### Physical Inventory
        if (!object.ReferenceEquals(vRow("PhysicalUnit"), DBNull.Value))
        {
            txtPhysicalUnits.Text = vRow("PhysicalUnit");
        }
        else
        {
            txtPhysicalUnits.Text = "";
        }
        if (!object.ReferenceEquals(vRow("PhysicalConversion"), DBNull.Value))
        {
            txtPhysicalConversion.Text = vRow("PhysicalConversion");
        }
        else
        {
            txtPhysicalConversion.Text = "";
        }
        if (!object.ReferenceEquals(vRow("InvQuantity"), DBNull.Value))
        {
            txtPhysicalOnHand.Text = Strings.Format(vRow("InvQuantity"), "##,##0.0#");
        }
        else
        {
            txtPhysicalOnHand.Text = "";
        }
        chkPhysicalTrack.Checked = vRow("TrackInvLevels");
        chkPhysicalReport.Checked = vRow("PrintInReport");
        chkPhysicalWarning.Checked = vRow("Warning");
        txtPhysicalWarning.Text = vRow("WarningLevel");

        if (!object.ReferenceEquals(vRow("RawCategoryID"), DBNull.Value))
        {
            AssignNewRawCategoryComboBox(ref vRow);
            // Else
            // Me.cbxNewCategory.SelectedIndex = -1
        }

    }

    private void txtPurchaseCost_TextChanged(object sender, EventArgs e)
    {
        DetermineRecipeUnitCost();

    }

    private void txtRecipeConversion_TextChanged(object sender, EventArgs e)
    {
        DetermineRecipeUnitCost();

    }

    private void DetermineRecipeUnitCost()
    {

        if (txtPurchaseCost.Text == "" | txtRecipeConversion.Text == "")
        {
            // we do not calculate this value without both parts
            return;
        }

        if ((int)txtRecipeConversion.Text > 0)
        {
            txtRecipeUnitCost.Text = Strings.Format((decimal)txtPurchaseCost.Text / (decimal)(int)txtRecipeConversion.Text, "###.00");

        }

    }


    private void btnNewRawReset_Click(object sender, EventArgs e)
    {
        // all entrys are blank
        btnNewRawCopy.Visible = false;
        btnNewRawReset.Visible = false;
        btnRawCreate.Visible = true;
        btnRawAccept.Visible = false;
        btnRawCancel.Visible = true;

        txtPhysicalConversion.Text = "";
        txtPhysicalOnHand.Text = "";
        txtPhysicalUnits.Text = "";
        txtPurchaseCost.Text = "";
        txtPurchaseUnits.Text = "";
        txtRawName.Text = "";
        txtRecipeConversion.Text = "";
        txtRecipeUnits.Text = "";

        chkRecipeSelectNo.Checked = true;
        chkRecipeSelectExtra.Checked = true;
        chkPhysicalTrack.Checked = true;
        chkPhysicalReport.Checked = true;
        chkPhysicalWarning.Checked = false;
        txtPhysicalWarning.Text = "";

        pnlRawInfo.Visible = true;

    }

    private bool ValidateAll()
    {

        var argtxtValAlpha = txtRawName;
        ValidateAlpha(ref argtxtValAlpha);
        txtRawName = argtxtValAlpha;
        if (ErrorProvider1.GetError(txtRawName).Length > 0)
        {
            return false;
        }
        var argtxtValAlpha1 = txtPurchaseUnits;
        ValidateAlpha(ref argtxtValAlpha1);
        txtPurchaseUnits = argtxtValAlpha1;
        if (ErrorProvider1.GetError(txtPurchaseUnits).Length > 0)
        {
            return false;
        }
        var argtxtValAlpha2 = txtRecipeUnits;
        ValidateAlpha(ref argtxtValAlpha2);
        txtRecipeUnits = argtxtValAlpha2;
        if (ErrorProvider1.GetError(txtRecipeUnits).Length > 0)
        {
            return false;
        }
        var argtxtValAlpha3 = txtPhysicalUnits;
        ValidateAlpha(ref argtxtValAlpha3);
        txtPhysicalUnits = argtxtValAlpha3;
        if (ErrorProvider1.GetError(txtPhysicalUnits).Length > 0)
        {
            return false;
        }

        var argtxtValNumeric = txtPurchaseCost;
        ValidateNumeric(ref argtxtValNumeric);
        txtPurchaseCost = argtxtValNumeric;
        if (ErrorProvider1.GetError(txtPurchaseCost).Length > 0)
        {
            return false;
        }
        var argtxtValNumeric1 = txtRecipeConversion;
        ValidateNumeric(ref argtxtValNumeric1);
        txtRecipeConversion = argtxtValNumeric1;
        if (ErrorProvider1.GetError(txtRecipeConversion).Length > 0)
        {
            return false;
        }
        var argtxtValNumeric2 = txtPhysicalConversion;
        ValidateNumeric(ref argtxtValNumeric2);
        txtPhysicalConversion = argtxtValNumeric2;
        if (ErrorProvider1.GetError(txtPhysicalConversion).Length > 0)
        {
            return false;
        }
        var argtxtValNumeric3 = txtPhysicalOnHand;
        ValidateNumeric(ref argtxtValNumeric3);
        txtPhysicalOnHand = argtxtValNumeric3;
        if (ErrorProvider1.GetError(txtPhysicalOnHand).Length > 0)
        {
            return false;
        }
        var argtxtValNumeric4 = txtRecipeSelectExtra;
        ValidateNumeric(ref argtxtValNumeric4);
        txtRecipeSelectExtra = argtxtValNumeric4;
        if (ErrorProvider1.GetError(txtRecipeSelectExtra).Length > 0)
        {
            return false;
        }
        var argtxtValNumeric5 = txtPhysicalWarning;
        ValidateNumeric(ref argtxtValNumeric5);
        txtPhysicalWarning = argtxtValNumeric5;
        if (ErrorProvider1.GetError(txtPhysicalWarning).Length > 0)
        {
            return false;
        }

        return true;

    }

    private void btnRawCreate_Click(object sender, EventArgs e)
    {


        if (ValidateAll() == false)
            return;

        DataRow oRow;
        decimal initialOnHandQuantity;

        UpdateRawMaterials();
        // need to accept changes

        oRow = dsSetup.Tables("RawMaterials").NewRow;
        oRow("CompanyID") = corpID;
        oRow("LocationID") = corpPhysicalLocation;
        oRow("RawCategoryID") = newRawCategoryID;
        oRow("RawItemName") = txtRawName.Text;
        oRow("PurchaseUnits") = txtPurchaseUnits.Text;
        oRow("PurchaseCost") = (decimal)txtPurchaseCost.Text;
        oRow("Blank") = "";
        oRow("RecipeUnit") = txtRecipeUnits.Text;

        if (txtRecipeConversion.Text == "")
        {
            oRow("RecipeConversion") = 1;
            oRow("UnitCost") = oRow("PurchaseCost");
        }
        else
        {
            oRow("RecipeConversion") = (int)txtRecipeConversion.Text;
            if (oRow("RecipeConversion") > 0)
            {
                oRow("UnitCost") = oRow("PurchaseCost") / oRow("RecipeConversion");
            }
            else
            {
                oRow("UnitCost") = oRow("PurchaseCost");
            }
        }
        oRow("SelectNo") = chkRecipeSelectNo.Checked;
        oRow("NoPrice") = 0;
        oRow("SelectExtra") = chkRecipeSelectExtra.Checked;
        oRow("ExtraPrice") = (decimal)txtRecipeSelectExtra.Text;

        oRow("PhysicalUnit") = txtPhysicalUnits.Text;

        if (txtPhysicalConversion.Text == "")
        {
            oRow("PhysicalConversion") = DBNull.Value;
            oRow("PhysicalUnitCost") = DBNull.Value;
        }
        else
        {
            oRow("PhysicalConversion") = (int)txtPhysicalConversion.Text;
            if (oRow("PhysicalConversion") > 0)
            {
                oRow("PhysicalUnitCost") = oRow("PurchaseCost") / oRow("PhysicalConversion");
            }
            else
            {
                oRow("PhysicalUnitCost") = DBNull.Value;
            }
        }

        oRow("InvDate") = DBNull.Value;
        if (txtPhysicalOnHand.Text == "")
        {
            oRow("InvQuantity") = 0;
            initialOnHandQuantity = 0m;
        }
        else
        {
            oRow("InvQuantity") = Strings.Format((decimal)txtPhysicalOnHand.Text, "##,##0.0#"); // DBNull.Value
            oRow("InvDollarAmount") = oRow("PurchaseCost") * oRow("InvQuantity");
            initialOnHandQuantity = oRow("InvQuantity") * oRow("RecipeConversion");
        }

        oRow("TrackInvLevels") = chkPhysicalTrack.Checked;
        oRow("PrintInReport") = chkPhysicalReport.Checked;
        oRow("Warning") = chkPhysicalWarning.Checked;
        oRow("WarningLevel") = (int)txtRecipeSelectExtra.Text;

        dsSetup.Tables("RawMaterials").Rows.Add(oRow);
        oRow("RawItemID") = InsertNewRawMaterial(ref oRow);
        dsSetup.Tables("RawMaterials").AcceptChanges();

        DataSet_Builder.GenerateReportData.InsertNewRawMaterialInitialInventory(oRow("RawItemID"), initialOnHandQuantity, oRow("PhysicalUnitCost"), corpID, corpPhysicalLocation);

        // 444    Me.pnlNewRawMaterial.Visible = False

        RawCurrencyMan.Position += 1;
        txtRawName.Text = "";
        InsertRawMatData(true);

    }



    private void btnRawAccept_Click(object sender, EventArgs e)
    {

        // Me.UpdateRawMaterials()
        // ???need to accept changes
        if (ValidateAll() == false)
            return;

        DataRowView oRow;

        oRow = this.dvRawMaterials(RawCurrencyMan.Position);

        oRow("CompanyID") = corpID;
        oRow("LocationID") = corpPhysicalLocation;
        oRow("RawCategoryID") = newRawCategoryID;
        oRow("RawItemName") = txtRawName.Text;
        oRow("PurchaseUnits") = txtPurchaseUnits.Text;
        oRow("PurchaseCost") = (decimal)txtPurchaseCost.Text;
        oRow("Blank") = "";
        oRow("RecipeUnit") = txtRecipeUnits.Text;

        // ??    DetermineRecipeUnitCost()
        if (txtRecipeConversion.Text == "")
        {
            oRow("RecipeConversion") = 1;
            oRow("UnitCost") = oRow("PurchaseCost");
        }
        else
        {
            oRow("RecipeConversion") = (int)txtRecipeConversion.Text;
            if (oRow("RecipeConversion") > 0)
            {
                oRow("UnitCost") = oRow("PurchaseCost") / oRow("RecipeConversion");
            }
            else
            {
                oRow("UnitCost") = oRow("PurchaseCost");
            }
        }
        oRow("SelectNo") = chkRecipeSelectNo.Checked;
        oRow("NoPrice") = 0;
        oRow("SelectExtra") = chkRecipeSelectExtra.Checked;
        oRow("ExtraPrice") = (decimal)txtRecipeSelectExtra.Text;

        oRow("PhysicalUnit") = txtPhysicalUnits.Text;

        if (txtPhysicalConversion.Text == "")
        {
            oRow("PhysicalConversion") = DBNull.Value;
            oRow("PhysicalUnitCost") = DBNull.Value;
        }
        else
        {
            oRow("PhysicalConversion") = (int)txtPhysicalConversion.Text;
            if (oRow("PhysicalConversion") > 0)
            {
                oRow("PhysicalUnitCost") = oRow("PurchaseCost") / oRow("PhysicalConversion");
            }
            else
            {
                oRow("PhysicalUnitCost") = DBNull.Value;
            }
        }

        oRow("InvDate") = DBNull.Value;
        if (txtPhysicalOnHand.Text == "")
        {
            oRow("InvQuantity") = DBNull.Value;
        }
        else
        {
            oRow("InvQuantity") = Strings.Format((decimal)txtPhysicalOnHand.Text, "##,##0.0#"); // DBNull.Value
            oRow("InvDollarAmount") = oRow("PurchaseCost") * oRow("InvQuantity");
        }

        oRow("TrackInvLevels") = chkPhysicalTrack.Checked;
        oRow("PrintInReport") = chkPhysicalReport.Checked;
        oRow("Warning") = chkPhysicalWarning.Checked;
        oRow("WarningLevel") = (int)txtRecipeSelectExtra.Text;

        if (RawCurrencyMan.Position < dvRawMaterials.Count)
        {
            if (RawCurrencyMan.Position == dvRawMaterials.Count - 1)
            {
                // this is the last row
                // Me.RawCurrencyMan.Position += 1
                // InsertRawMatData(False)
                pnlNewRawMaterial.Visible = false;
            }
            else
            {
                RawCurrencyMan.Position += 1;
                InsertRawMatData(false);
            }
        }
        else
        {
            pnlRawInfo.Visible = false;
            pnlNewRawMaterial.Visible = false;
        }

    }

    private object InsertNewRawMaterial(ref DataRow oRow)
    {
        var newRawItemID = default(int);

        sql.SqlInsertCommandRawMat.Parameters("@CompanyID").Value = corpID;
        sql.SqlInsertCommandRawMat.Parameters("@LocationID").Value = corpPhysicalLocation;
        sql.SqlInsertCommandRawMat.Parameters("@RawCategoryID").Value = oRow("RawCategoryID");
        sql.SqlInsertCommandRawMat.Parameters("@RawItemName").Value = oRow("RawItemName");
        sql.SqlInsertCommandRawMat.Parameters("@PurchaseUnits").Value = oRow("PurchaseUnits");
        sql.SqlInsertCommandRawMat.Parameters("@PurchaseCost").Value = oRow("PurchaseCost");
        sql.SqlInsertCommandRawMat.Parameters("@Blank").Value = oRow("Blank");
        sql.SqlInsertCommandRawMat.Parameters("@RecipeUnit").Value = oRow("RecipeUnit");
        sql.SqlInsertCommandRawMat.Parameters("@RecipeConversion").Value = oRow("RecipeConversion");

        sql.SqlInsertCommandRawMat.Parameters("@SelectNo").Value = oRow("SelectNo");
        sql.SqlInsertCommandRawMat.Parameters("@NoPrice").Value = oRow("NoPrice");
        sql.SqlInsertCommandRawMat.Parameters("@SelectExtra").Value = oRow("SelectExtra");
        sql.SqlInsertCommandRawMat.Parameters("@ExtraPrice").Value = oRow("ExtraPrice");
        sql.SqlInsertCommandRawMat.Parameters("@PhysicalUnit").Value = oRow("PhysicalUnit");
        sql.SqlInsertCommandRawMat.Parameters("@PhysicalConversion").Value = oRow("PhysicalConversion");
        sql.SqlInsertCommandRawMat.Parameters("@InvDate").Value = oRow("InvDate");
        // sql.SqlInsertCommandRawMat.Parameters("@InvQuantity").Value = oRow("InvQuantity")

        sql.SqlInsertCommandRawMat.Parameters("@CalculatedBegInvWeek").Value = 0;
        sql.SqlInsertCommandRawMat.Parameters("@RecipeQuantity").Value = 0; // Do not use here
        // sql.SqlInsertCommandRawMat.Parameters("@TrackAs").Value = DBNull.Value
        sql.SqlInsertCommandRawMat.Parameters("@TrackInvLevels").Value = oRow("TrackInvLevels");
        sql.SqlInsertCommandRawMat.Parameters("@PrintInReport").Value = oRow("PrintInReport");
        sql.SqlInsertCommandRawMat.Parameters("@Warning").Value = oRow("Warning");
        sql.SqlInsertCommandRawMat.Parameters("@WarningLevel").Value = oRow("WarningLevel");
        sql.SqlInsertCommandRawMat.Parameters("@TempRecipeQuantity").Value = 0;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            newRawItemID = sql.SqlInsertCommandRawMat.ExecuteScalar;
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
            Interaction.MsgBox(ex.Message);
        }

        return newRawItemID;

    }



    // Private Sub txtPurchaseCost_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPurchaseCost.Validating
    // ValidateNumeric(Me.txtPurchaseCost)
    // End Sub
    // Private Sub txtRecipeConversion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRecipeConversion.Validating
    // ValidateNumeric(Me.txtRecipeConversion)
    // End Sub
    // Private Sub txtPhysicalConversion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPhysicalConversion.Validating
    // ValidateNumeric(Me.txtPhysicalConversion)
    // End Sub
    // '   Private Sub txtPhysicalOnHand_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPhysicalOnHand.Validating
    // ValidateNumeric(Me.txtPhysicalOnHand)
    // End Sub
    // Private Sub txtRecipeSelectExtra_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRecipeSelectExtra.Validating
    // ValidateNumeric(Me.txtRecipeSelectExtra)
    // End Sub
    // Private Sub txtPhysicalWarning_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPhysicalWarning.Validating
    // ValidateNumeric(Me.txtPhysicalWarning)
    // End Sub

    private void ValidateNumeric(ref TextBox txtValNumeric)
    {

        if (txtValNumeric.Text == "")
        {
            if (object.ReferenceEquals(txtValNumeric, txtRecipeConversion) | object.ReferenceEquals(txtValNumeric, txtPhysicalConversion))
            {
                ErrorProvider1.SetError(txtValNumeric, "This must be a non-zero numeric value.");
                ErrorProvider1.SetIconAlignment(txtValNumeric, ErrorIconAlignment.TopLeft);

                // txtValNumeric.Text = "1"
                txtValNumeric.Focus();
                Interaction.Beep();
            }
            else
            {
                // they should default to Null.value
                txtValNumeric.Text = "0";

            }
        }

        // ElseIf CInt(txtValNumeric.Text) = 0 Then
        // If txtValNumeric Is txtPurchaseCost Then
        // Else
        // txtValNumeric.Text = ""
        // End If

        else if (!Information.IsNumeric(txtValNumeric.Text))
        {
            ErrorProvider1.SetError(txtValNumeric, "This must be a numeric value.");
            ErrorProvider1.SetIconAlignment(txtValNumeric, ErrorIconAlignment.TopLeft);
            txtValNumeric.Focus();
            Interaction.Beep();
        }

        else
        {
            // cancels the error
            ErrorProvider1.Dispose();
        }
    }

    // Private Sub txtRawName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRawName.Validating
    // ValidateAlpha(Me.txtRawName)
    // End Sub
    // Private Sub txtPurchaseUnits_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPurchaseUnits.Validating
    // ValidateAlpha(Me.txtPurchaseUnits)
    // '   End Sub
    // Private Sub txtRecipeUnits_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRecipeUnits.Validating
    // ValidateAlpha(Me.txtRecipeUnits)
    // End Sub
    // Private Sub txtPhysicalUnits_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPhysicalUnits.Validating
    // '      ValidateAlpha(Me.txtPhysicalUnits)
    // End Sub

    private void ValidateAlpha(ref TextBox txtValAlpha)
    {

        if (txtValAlpha.Text == "")
        {
            if (object.ReferenceEquals(txtValAlpha, txtRawName) | object.ReferenceEquals(txtValAlpha, txtPurchaseUnits))
            {
                ErrorProvider1.SetError(txtValAlpha, "This TextBox can not be Blank.");
                ErrorProvider1.SetIconAlignment(txtValAlpha, ErrorIconAlignment.TopLeft);

                txtValAlpha.Focus();
                Interaction.Beep();
            }
            else
            {
                // this should default to NULL.value
            }
        }

        else if (!(Information.TypeName(txtValAlpha.Text) == "String"))
        {
            ErrorProvider1.SetError(txtValAlpha, "This must be a String value.");
            ErrorProvider1.SetIconAlignment(txtValAlpha, ErrorIconAlignment.TopLeft);
            txtValAlpha.Focus();
            Interaction.Beep();
        }

        else
        {
            // cancels the error
            ErrorProvider1.Dispose();
        }

    }



    private void btnRawCancel_Click(object sender, EventArgs e)
    {
        // reset all new raw info
        // Me.btnNewRawCopy.Visible = True
        // Me.btnNewRawReset.Visible = True
        // Me.btnRawAccept.Visible = False
        // Me.btnRawCreate.Visible = False
        // Me.btnRawCancel.Visible = False

        pnlRawInfo.Visible = false;
        pnlNewRawMaterial.Visible = false;

    }

    private void grdRawIngredients_Enter(object sender, EventArgs e)
    {

        removingFromCurrentIngredients = true;

    }
    private void grdRawMaterielListIngredients_Enter(object sender, MouseEventArgs e) // grdRawMaterielListIngredients.Enter
    {

        removingFromCurrentIngredients = false;

    }

    private void AssignNewRawCategoryComboBox(ref DataRowView vRow)
    {
        var i = default(int);

        foreach (DataRow oRow in dsSetup.Tables("RawCategories").Rows)
        {
            if (oRow("RawCategoryID") == vRow("RawCategoryID"))
            {
                cbxNewCategory.SelectedIndex = i; // oRow("RawCategoryName")
                newRawCategoryID = vRow("RawCategoryID");
                break;
            }
            i += 1;
        }

    }

    private void cbxNewCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        int valueRawID;
        // Dim valueSubID As Integer
        // Dim filterString As String

        valueRawID = dsSetup.Tables("RawCategories").Rows(cbxNewCategory.SelectedIndex)("RawCategoryID");
        // valueSubID = dsSetup.Tables("RawCategories").Rows(Me.cbxRawMaterialCategory.SelectedIndex)("RawSubCategory")

        newRawCategoryID = valueRawID;

        // make text and catid = to values

    }

    private void cbxFoodFilter_SelectedIndexChanged(object sender, EventArgs e)
    {

        UpdateRawUsageData();
        var funFlag = default(string);
        var valueCatID = default(int);
        int index;

        // "OrderMenuDetail" needs to include drink categories too??????
        if (cbxFoodFilter.SelectedIndex > dvMainCategory.Count - 1) // (dsSetup.Tables("OrderMenuDetail").Rows.Count - 1) Then
        {
            // newFoodOrder.CatIsDrink = True
            index = dvMainCategory.Count;
            foreach (DataRow oRow in dsSetup.Tables("DrinkCategory").Rows)
            {
                if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
                {
                    if (!object.ReferenceEquals(oRow("DrinkCategoryName"), DBNull.Value))
                    {
                        if (index == cbxFoodFilter.SelectedIndex)
                        {
                            valueCatID = oRow("DrinkCategoryID");
                            funFlag = "D";
                            break;
                        }
                        index += 1;
                    }
                }
            }
        }
        else
        {
            // newFoodOrder.CatIsDrink = False
            valueCatID = dvMainCategory(cbxFoodFilter.SelectedIndex)("CategoryID");
            funFlag = dvMainCategory(cbxFoodFilter.SelectedIndex)("FunctionFlag");

        }

        rawUsageFunFlag = funFlag;

        if (funFlag == "D")
        {
            {
                var withBlock = dvDrinks;
                withBlock.Table = dsSetup.Tables("Drinks");
                withBlock.RowFilter = "DrinkCategoryID = " + valueCatID;
                withBlock.Sort = "DrinkName";
            }

            grdRawFoodList.Visible = false;
            grdRawDrinkList.Visible = true;
        }
        else
        {
            {
                var withBlock1 = dvFoods;
                withBlock1.Table = dsSetup.Tables("FoodTable");
                withBlock1.RowFilter = "CategoryID = " + valueCatID;
                withBlock1.Sort = "FoodName";
            }

            grdRawDrinkList.Visible = false;
            grdRawFoodList.Visible = true;
        }

    }

    private void btnShowAllFood_Click(object sender, EventArgs e)
    {

        {
            var withBlock = dvFoods;
            withBlock.Table = dsSetup.Tables("FoodTable");
            withBlock.RowFilter = "FunctionFlag = 'F'";
        }
        return;

        dsSetup.Tables("FoodTable").Clear();

        // want to keep this from sql 
        sql.SqlSelectCommandFoodsByFunction.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandFoodsByFunction.Parameters("@LocationID").Value = selectedLocation;
        // sql.SqlSelectCommandFoodsByFunction.Parameters("@CategoryID").Value = 100

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlDataAdapterFoodsByFunction.Fill(dsSetup.Tables("FoodTable"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }
    }
    private void btnShowAllRaw1_Click(object sender, EventArgs e)
    {
        ReSetRawMatData();

    }

    private void btnShowAllRaw2_Click(object sender, EventArgs e)
    {
        ReSetRawMatData();

    }

    private void ReSetRawMatData()
    {
        // dvRawMaterials = New DataView

        {
            ref var withBlock = ref dvRawMaterials;
            withBlock.Table = dsSetup.Tables("RawMaterials");
            withBlock.RowFilter = "RawCategoryID > 0";
        }

        // Me.grdRawMaterialList.DataSource = dvRawMaterials   '  dsSetup.Tables("RawMaterials")
        // Me.grdRawMaterielListIngredients.DataSource = dvRawMaterials    'dsSetup.Tables("RawMaterials")

    }










    // *********************************
    // old     old     old 

    private void lblRawFoodName_Changed(object sender, EventArgs e)
    {

        return;

        if (lblRawFoodName.Text == "Food Item")
            return;

        if (rawUsageChanged == true)
        {
            UpdateRawUsageData();
        }

        FilterRawUsageData();

    }


    private void FilterRawUsageData()
    {

        searchFoodID = grdRawFoodList.Item(grdRawFoodList.CurrentRowIndex, 0); // Me.RawFoodCurrencyMan.Position, 0)
        pnlRawUsageList.Controls.Clear();
        usageCount = 0;
        itemCost = 0m;

        dvRawUsageByItem = new DataView();
        {
            ref var withBlock = ref dvRawUsageByItem;
            withBlock.Table = dsSetup.Tables("RawUsageByItem");
            withBlock.RowFilter = "FoodID = " + searchFoodID;
            // .Sort = "CategoryID"
        }

        foreach (DataRowView vRow in dvRawUsageByItem)
        {
            PopulateRawUsageLabels(ref vRow);
            itemCost += vRow("BreakdownPercent") * vRow("CostPerItem") * vRow("RawUsageAmount");
            usageCount += 1;
        }

        DisplayCostofItem();

    }

    private void PopulateRawUsageLabels(ref DataRowView usageRow)
    {
        var lblRawUsageName = new Label();
        var lblRawUsageAmount = new Label();
        var lblRawUsageQuanity = new Label();
        int xPosForName;
        int xPosForAmount;
        int xPosForQuanity;
        int yPos;

        yPos = 25 * usageCount;
        lblRawUsageQuanity.Size = new Size(40, 23);
        lblRawUsageQuanity.Location = new Point(5, yPos);
        lblRawUsageQuanity.TextAlign = ContentAlignment.TopLeft;
        lblRawUsageQuanity.Text = Strings.Format(usageRow("RawUsageAmount"), "###.##");

        lblRawUsageAmount.Size = new Size(80, 23);
        lblRawUsageAmount.Location = new Point(45, yPos);
        lblRawUsageAmount.Text = usageRow("BreakdownAmount");

        lblRawUsageName.Size = new Size(100, 23);
        lblRawUsageName.Location = new Point(130, yPos);
        lblRawUsageName.Text = usageRow("RawItemName");


        pnlRawUsageList.Controls.Add(lblRawUsageName);
        pnlRawUsageList.Controls.Add(lblRawUsageAmount);
        pnlRawUsageList.Controls.Add(lblRawUsageQuanity);

    }


    private void cbxNewRawMatExistingCat_SelectedIndexChanged(object sender, EventArgs e)
    {
        var valueCatID = default(int);
        string valueFunFlag;
        var index = default(int);

        foreach (DataRow oRow in dsSetup.Tables("DrinkCategory").Rows)
        {
            if (!(oRow.RowState == DataRowState.Deleted) & !(oRow.RowState == DataRowState.Detached))
            {
                if (!object.ReferenceEquals(oRow("DrinkCategoryName"), DBNull.Value))
                {
                    if (index == cbxNewRawMatExistingCat.SelectedIndex)
                    {
                        valueCatID = oRow("DrinkCategoryID");
                        break;
                    }
                    index += 1;
                }
            }
        }

        // valueCatID = dsSetup.Tables("DinkCategory").Rows(cbxNewRawMatExistingCat.SelectedIndex)("DrinkCategoryID")
        // valueFunFlag = dsSetup.Tables("DinkCategory").Rows(cbxNewRawMatExistingCat.SelectedIndex)("FunctionFlag")
        // valueCatID = dvFoodJoinCategory(cbxJoinIndividualModifierSelect.SelectedIndex)("CategoryID")
        // valueFunFlag = dvFoodJoinCategory(cbxJoinIndividualModifierSelect.SelectedIndex)("FunctionFlag")

        // If valueFunFlag = "D" Then 
        // tsJoinIndividualModifiers.MappingName = "Drinks"
        tsRawDrinkNames.MappingName = "Drinks";

        {
            var withBlock = dvDrinksByCategory;
            withBlock.Table = dsSetup.Tables("Drinks");
            withBlock.RowFilter = "DrinkCategoryID = '" + valueCatID + "'";
            withBlock.Sort = "DrinkName"; // "CategoryID, DrinkName"
        }
        // Else
        // tsJoinIndividualModifiers.MappingName = "FoodTable"
        // With dvModifiers2
        // .Table = dsSetup.Tables("FoodTable")
        // .RowFilter = "CategoryID = '" & valueCatID & "'" ' AND FunctionFlag = 'O'"
        // .Sort = "CategoryID, FoodName"
        // End With
        // End If

    }

    private void grdRawDrinkNames_Clicked(object sender, MouseEventArgs e)
    {

        // Dim valueModID As Integer
        string valueDrinkName;

        // valueModID = DetermineID(grdJoinIndividualModifiers, 0)
        valueDrinkName = DetermineString(grdRawDrinkNames, 0);

        txtRawName.Text = valueDrinkName;

    }



    private void pnlRawInfo_click(object sender, EventArgs e)
    {
        lblRawDirections.Text = "";
    }

    private void Label7_Click(object sender, EventArgs e)
    {
        RecipeText();
    }

    private void txtRecipeConversion_Click(object sender, EventArgs e)
    {
        RecipeText();
    }

    private void RecipeText()
    {
        lblRawDirections.Text = "Recipe conversion is the number of recipe units in one(1) purchase unit.";
    }



    private void Label10_Click(object sender, EventArgs e)
    {
        PhysicalConversionText();
    }

    private void txtPhysicalConversion_Click(object sender, EventArgs e)
    {
        PhysicalConversionText();
    }

    private void PhysicalConversionText()
    {
        lblRawDirections.Text = "Physical conversion is the number of physical units in one(1) purchase unit. Usually 1";
    }


}