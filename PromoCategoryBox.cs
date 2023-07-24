using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public partial class PromoCategoryBox : System.Windows.Forms.UserControl
{

    private CurrencyManager PromoCatBoxCurrencyMan;
    // Dim promoDataHelper As New DataSet_Builder.SQLHelper

    private string _fdFlag;
    private int _promoID;
    private int _positionIndex;
    private DataTable _primaryTable;
    private DataTable _supportingTable;
    private string _primaryColumn;
    private bool _newRowFlag;


    internal string FoodDrink_Flag
    {
        get
        {
            return _fdFlag;
        }
        set
        {
            _fdFlag = value;
        }
    }

    internal int PromoID
    {
        get
        {
            return _promoID;
        }
        set
        {
            _promoID = value;
        }
    }

    internal int PositionIndex
    {
        get
        {
            return _positionIndex;
        }
        set
        {
            _positionIndex = value;
        }
    }

    internal DataTable PrimaryTable
    {
        get
        {
            return _primaryTable;
        }
        set
        {
            _primaryTable = value;
        }
    }

    internal DataTable SupportingTable
    {
        get
        {
            return _supportingTable;
        }
        set
        {
            _supportingTable = value;
        }
    }

    internal string PrimaryColumn
    {
        get
        {
            return _primaryColumn;
        }
        set
        {
            _primaryColumn = value;
        }
    }

    internal bool NewRowFlag
    {
        get
        {
            return _newRowFlag;
        }
        set
        {
            _newRowFlag = value;
        }
    }

    public event AddingPromoRowEventHandler AddingPromoRow;

    public delegate void AddingPromoRowEventHandler(ref DataRow oRow);


    #region  Windows Form Designer generated code 

    public PromoCategoryBox() : base() // (ByVal fd As String, ByRef primTable As DataTable, ByRef secTable As DataTable)
    {

        // _fdFlag = fd
        // _primaryTable = primTable
        // _secondaryTable = secTable

        // This call is required by the Windows Form Designer.
        InitializeComponent();

        // Add any initialization after the InitializeComponent() call
        // InitializeOther()

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
    private Global.System.Windows.Forms.ComboBox _cbxPromoCatBox;

    internal virtual Global.System.Windows.Forms.ComboBox cbxPromoCatBox
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _cbxPromoCatBox;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_cbxPromoCatBox != null)
            {
                _cbxPromoCatBox.SelectionChangeCommitted -= cbxPromoCatBox_SelectedIndexChanged;
            }

            _cbxPromoCatBox = value;
            if (_cbxPromoCatBox != null)
            {
                _cbxPromoCatBox.SelectionChangeCommitted += cbxPromoCatBox_SelectedIndexChanged;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnPromoCatBox;

    internal virtual Global.System.Windows.Forms.Button btnPromoCatBox
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnPromoCatBox;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnPromoCatBox != null)
            {
                _btnPromoCatBox.Click -= btnPromoCatBox_Click;
            }

            _btnPromoCatBox = value;
            if (_btnPromoCatBox != null)
            {
                _btnPromoCatBox.Click += btnPromoCatBox_Click;
            }
        }
    }
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        _cbxPromoCatBox = new System.Windows.Forms.ComboBox();
        _cbxPromoCatBox.SelectionChangeCommitted += cbxPromoCatBox_SelectedIndexChanged;
        _btnPromoCatBox = new System.Windows.Forms.Button();
        _btnPromoCatBox.Click += btnPromoCatBox_Click;
        this.SuspendLayout();
        // 
        // cbxPromoCatBox
        // 
        _cbxPromoCatBox.Location = new System.Drawing.Point(0, 0);
        _cbxPromoCatBox.Name = "_cbxPromoCatBox";
        _cbxPromoCatBox.Size = new System.Drawing.Size(136, 21);
        _cbxPromoCatBox.TabIndex = 0;
        // 
        // btnPromoCatBox
        // 
        _btnPromoCatBox.Location = new System.Drawing.Point(136, 0);
        _btnPromoCatBox.Name = "_btnPromoCatBox";
        _btnPromoCatBox.Size = new System.Drawing.Size(24, 24);
        _btnPromoCatBox.TabIndex = 1;
        // 
        // PromoCategoryBox
        // 
        this.BackColor = System.Drawing.SystemColors.Desktop;
        this.Controls.Add(_btnPromoCatBox);
        this.Controls.Add(_cbxPromoCatBox);
        this.Name = "PromoCategoryBox";
        this.Size = new System.Drawing.Size(160, 24);
        this.ResumeLayout(false);

    }

    #endregion


    internal void InitializeUserControl()
    {

        PromoCatBoxCurrencyMan = BindingContext(PrimaryTable);
        PromoCatBoxCurrencyMan.Position = PositionIndex;

        if (FoodDrink_Flag == "F")
        {
            PopulateForFood();
        }

        else if (FoodDrink_Flag == "D")
        {
            PopulateForDrink();

        }

    }

    private void PopulateForFood()
    {

        btnPromoCatBox.Text = "F";

        cbxPromoCatBox.Items.Clear();
        foreach (DataRow oRow in dsSetup.Tables("MainCategory").Rows)
            cbxPromoCatBox.Items.Add(oRow("CategoryName"));

        if (NewRowFlag == false)
        {
            if (!object.ReferenceEquals(SupportingTable.Rows(PromoCatBoxCurrencyMan.Position)("CategoryName"), DBNull.Value))
            {
                cbxPromoCatBox.Text = SupportingTable.Rows(PromoCatBoxCurrencyMan.Position)("CategoryName"); // CurrentRow("CategoryName")
            }
            else
            {
                cbxPromoCatBox.SelectedIndex = -1;
            }
        }
        // Me.cbxPromoCatBox.DataBindings.Clear()
        // Me.cbxPromoCatBox.DataBindings.Add("Text", PrimaryTable, "CategoryName")

    }

    private void PopulateForDrink()
    {

        btnPromoCatBox.Text = "D";

        cbxPromoCatBox.Items.Clear();
        foreach (DataRow oRow in dsSetup.Tables("DrinkCategory").Rows)
            cbxPromoCatBox.Items.Add(oRow("DrinkCategoryName"));

        if (NewRowFlag == false)
        {
            if (!object.ReferenceEquals(SupportingTable.Rows(PromoCatBoxCurrencyMan.Position)("CategoryName"), DBNull.Value))
            {
                cbxPromoCatBox.Text = SupportingTable.Rows(PromoCatBoxCurrencyMan.Position)("CategoryName"); // CurrentRow("DrinkCategoryName")
            }
            else
            {
                cbxPromoCatBox.SelectedIndex = -1;
            }
        }
        // Me.cbxPromoCatBox.DataBindings.Clear()
        // Me.cbxPromoCatBox.DataBindings.Add("Text", PrimaryTable, "DrinkCategoryName")

    }

    private void btnPromoCatBox_Click(object sender, EventArgs e)
    {
        if (FoodDrink_Flag == "F")
        {
            PopulateForDrink();

            _fdFlag = "D";
        }

        else if (FoodDrink_Flag == "D")
        {
            PopulateForFood();

            _fdFlag = "F";

        }

    }

    private void cbxPromoCatBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        int valueCatID;
        string valueCatName;

        if (NewRowFlag == true)
        {
            DataRow oRow;

            oRow = PrimaryTable.NewRow;

            oRow("CompanyID") = corpID;
            oRow("LocationID") = selectedLocation;
            oRow("PromoID") = PromoID;

            if (FoodDrink_Flag == "F")
            {
                valueCatID = dsSetup.Tables("MainCategory").Rows(cbxPromoCatBox.SelectedIndex)("CategoryID");
                valueCatName = dsSetup.Tables("MainCategory").Rows(cbxPromoCatBox.SelectedIndex)("CategoryName");

                oRow(PrimaryColumn + "FD_flag") = "F";
                // oRow("CategoryName") = valueCatName
                oRow(PrimaryColumn + "CategoryID") = valueCatID;
            }
            else
            {
                valueCatID = dsSetup.Tables("DrinkCategory").Rows(cbxPromoCatBox.SelectedIndex)("DrinkCategoryID");
                valueCatName = dsSetup.Tables("DrinkCategory").Rows(cbxPromoCatBox.SelectedIndex)("DrinkCategoryName");

                // oRow(PrimaryColumn & "FD_flag") = "D"
                oRow("DrinkCategoryName") = valueCatName;
                oRow(PrimaryColumn + "DrinkCategoryID") = valueCatID;
            }
            // PrimaryTable.Rows.Add(oRow)
            // UpdatePromoData(oRow)
            AddingPromoRow?.Invoke(ref oRow);
            NewRowFlag = false;
        }


        else if (FoodDrink_Flag == "F")
        {
            valueCatID = dsSetup.Tables("MainCategory").Rows(cbxPromoCatBox.SelectedIndex)("CategoryID");
            valueCatName = dsSetup.Tables("MainCategory").Rows(cbxPromoCatBox.SelectedIndex)("CategoryName");

            // PrimaryTable.Rows(PositionIndex)("CategoryName") = valueCatName
            PrimaryTable.Rows(PositionIndex)(PrimaryColumn + "CategoryID") = valueCatID;
            PrimaryTable.Rows(PositionIndex)(PrimaryColumn + "FD_flag") = "F";
        }
        else
        {
            valueCatID = dsSetup.Tables("DrinkCategory").Rows(cbxPromoCatBox.SelectedIndex)("DrinkCategoryID");
            valueCatName = dsSetup.Tables("DrinkCategory").Rows(cbxPromoCatBox.SelectedIndex)("DrinkCategoryName");

            // PrimaryTable.Rows(PositionIndex)("DrinkCategoryName") = valueCatName
            PrimaryTable.Rows(PositionIndex)(PrimaryColumn + "DrinkCategoryID") = valueCatID;
            PrimaryTable.Rows(PositionIndex)(PrimaryColumn + "FD_flag") = "D";

        }

    }



    private void UpdatePromoData(ref DataRow oRow)
    {

        if (object.ReferenceEquals(PrimaryTable, dsSetup.Tables("PromoCombo")))
        {
            try
            {
                sql.cn.Open();
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
                sql.SqlPromoCombo.Update(PrimaryTable);
                sql.cn.Close();
            }
            catch (Exception ex)
            {
                CloseConnection();
            }

        }

    }

}