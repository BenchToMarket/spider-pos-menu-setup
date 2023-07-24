using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

public partial class PromoBSGS : System.Windows.Forms.UserControl
{

    // Friend BSGSBuyCurrencyMan As CurrencyManager
    // Friend BSGSGetCurrencyMan As CurrencyManager
    internal bool updatedData;
    internal int bsgsPromoID;
    internal bool NewRowFlag;


    #region  Windows Form Designer generated code 

    public PromoBSGS(int PromoID) : base()
    {

        // This call is required by the Windows Form Designer.
        InitializeComponent();

        // Add any initialization after the InitializeComponent() call
        InitializeOther(PromoID);

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
    private Global.System.Windows.Forms.TextBox _txtPrBuy;

    internal virtual Global.System.Windows.Forms.TextBox txtPrBuy
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtPrBuy;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtPrBuy != null)
            {
                _txtPrBuy.TextChanged -= txtPrBuy_TextChanged;
            }

            _txtPrBuy = value;
            if (_txtPrBuy != null)
            {
                _txtPrBuy.TextChanged += txtPrBuy_TextChanged;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtPrGet;

    internal virtual Global.System.Windows.Forms.TextBox txtPrGet
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtPrGet;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtPrGet != null)
            {
                _txtPrGet.TextChanged -= txtPrGet_TextChanged;
            }

            _txtPrGet = value;
            if (_txtPrGet != null)
            {
                _txtPrGet.TextChanged += txtPrGet_TextChanged;
            }
        }
    }
    private Tahsc_server.PromoCategoryBox _PromoCategoryBoxBuy;

    internal virtual Tahsc_server.PromoCategoryBox PromoCategoryBoxBuy
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _PromoCategoryBoxBuy;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_PromoCategoryBoxBuy != null)
            {
                _PromoCategoryBoxBuy.AddingPromoRow -= AddFromBSGSBox;
            }

            _PromoCategoryBoxBuy = value;
            if (_PromoCategoryBoxBuy != null)
            {
                _PromoCategoryBoxBuy.AddingPromoRow += AddFromBSGSBox;
            }
        }
    }
    private Tahsc_server.PromoCategoryBox _PromoCategoryBoxGet;

    internal virtual Tahsc_server.PromoCategoryBox PromoCategoryBoxGet
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _PromoCategoryBoxGet;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_PromoCategoryBoxGet != null)
            {
                _PromoCategoryBoxGet.AddingPromoRow -= AddFromBSGSBox;
            }

            _PromoCategoryBoxGet = value;
            if (_PromoCategoryBoxGet != null)
            {
                _PromoCategoryBoxGet.AddingPromoRow += AddFromBSGSBox;
            }
        }
    }
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        _Label1 = new System.Windows.Forms.Label();
        _Label2 = new System.Windows.Forms.Label();
        _txtPrBuy = new System.Windows.Forms.TextBox();
        _txtPrBuy.TextChanged += txtPrBuy_TextChanged;
        _txtPrGet = new System.Windows.Forms.TextBox();
        _txtPrGet.TextChanged += txtPrGet_TextChanged;
        _Label3 = new System.Windows.Forms.Label();
        _Label5 = new System.Windows.Forms.Label();
        _Label4 = new System.Windows.Forms.Label();
        _PromoCategoryBoxBuy = new Tahsc_server.PromoCategoryBox();
        _PromoCategoryBoxBuy.AddingPromoRow += AddFromBSGSBox;
        _PromoCategoryBoxGet = new Tahsc_server.PromoCategoryBox();
        _PromoCategoryBoxGet.AddingPromoRow += AddFromBSGSBox;
        this.SuspendLayout();
        // 
        // Label1
        // 
        _Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label1.Location = new System.Drawing.Point(56, 120);
        _Label1.Name = "_Label1";
        _Label1.Size = new System.Drawing.Size(128, 24);
        _Label1.TabIndex = 0;
        _Label1.Text = "Buy Something:";
        _Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label2
        // 
        _Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label2.Location = new System.Drawing.Point(40, 168);
        _Label2.Name = "_Label2";
        _Label2.Size = new System.Drawing.Size(144, 24);
        _Label2.TabIndex = 1;
        _Label2.Text = "Get Something Free:";
        _Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtPrBuy
        // 
        _txtPrBuy.Location = new System.Drawing.Point(352, 120);
        _txtPrBuy.Name = "_txtPrBuy";
        _txtPrBuy.Size = new System.Drawing.Size(48, 20);
        _txtPrBuy.TabIndex = 4;
        _txtPrBuy.Text = "";
        // 
        // txtPrGet
        // 
        _txtPrGet.Location = new System.Drawing.Point(352, 168);
        _txtPrGet.Name = "_txtPrGet";
        _txtPrGet.Size = new System.Drawing.Size(48, 20);
        _txtPrGet.TabIndex = 5;
        _txtPrGet.Text = "";
        // 
        // Label3
        // 
        _Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label3.Location = new System.Drawing.Point(344, 80);
        _Label3.Name = "_Label3";
        _Label3.Size = new System.Drawing.Size(64, 24);
        _Label3.TabIndex = 6;
        _Label3.Text = "Number";
        _Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Label5
        // 
        _Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label5.Location = new System.Drawing.Point(48, 16);
        _Label5.Name = "_Label5";
        _Label5.Size = new System.Drawing.Size(344, 32);
        _Label5.TabIndex = 23;
        _Label5.Text = "Buy Something Get Something Free";
        _Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Label4
        // 
        _Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label4.Location = new System.Drawing.Point(208, 88);
        _Label4.Name = "_Label4";
        _Label4.Size = new System.Drawing.Size(88, 16);
        _Label4.TabIndex = 24;
        _Label4.Text = "Category";
        _Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // PromoCategoryBoxBuy
        // 
        _PromoCategoryBoxBuy.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _PromoCategoryBoxBuy.Location = new System.Drawing.Point(184, 120);
        _PromoCategoryBoxBuy.Name = "_PromoCategoryBoxBuy";
        _PromoCategoryBoxBuy.Size = new System.Drawing.Size(160, 24);
        _PromoCategoryBoxBuy.TabIndex = 27;
        // 
        // PromoCategoryBoxGet
        // 
        _PromoCategoryBoxGet.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _PromoCategoryBoxGet.Location = new System.Drawing.Point(184, 168);
        _PromoCategoryBoxGet.Name = "_PromoCategoryBoxGet";
        _PromoCategoryBoxGet.Size = new System.Drawing.Size(160, 24);
        _PromoCategoryBoxGet.TabIndex = 28;
        // 
        // PromoBSGS
        // 
        this.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        this.Controls.Add(_PromoCategoryBoxGet);
        this.Controls.Add(_PromoCategoryBoxBuy);
        this.Controls.Add(_Label4);
        this.Controls.Add(_Label5);
        this.Controls.Add(_Label3);
        this.Controls.Add(_txtPrGet);
        this.Controls.Add(_txtPrBuy);
        this.Controls.Add(_Label2);
        this.Controls.Add(_Label1);
        this.Name = "PromoBSGS";
        this.Size = new System.Drawing.Size(432, 256);
        this.ResumeLayout(false);

    }

    #endregion

    private void InitializeOther(int promoID)
    {

        var index = default(int);
        DataRow oRow;
        bsgsPromoID = promoID;

        if (dsSetup.Tables("PromoBSGS").Rows.Count > 0)
        {
            foreach (DataRow currentORow in dsSetup.Tables("PromoBSGSBuy").Rows)
            {
                oRow = currentORow;
                if (oRow("PromoID") == promoID)
                    break;
                index += 1;
            }

            // my concern is can you ever get here without a PromoID
            // need some kind of defense for this something like:
            // If index > dssetup.tables("PromoBSGS").count then ????
            if (index < dsSetup.Tables("PromoBSGS").Rows.Count & NewRowFlag == false)
            {
                // newrowflag = true means we already initalized a new row (kind of)
                if (dsSetup.Tables("PromoBSGSBuy").Rows(index)("BuyFD_flag") == "F")
                {
                    PromoCategoryBoxBuy.FoodDrink_Flag = "F";
                }
                else if (dsSetup.Tables("PromoBSGSBuy").Rows(index)("BuyFD_flag") == "D")
                {
                    PromoCategoryBoxBuy.FoodDrink_Flag = "D";
                }
                if (!object.ReferenceEquals(dsSetup.Tables("PromoBSGSBuy").Rows(index)("BuyCategoryAmount"), DBNull.Value))
                {
                    txtPrBuy.Text = dsSetup.Tables("PromoBSGSBuy").Rows(index)("BuyCategoryAmount");
                }

                PromoCategoryBoxBuy.PositionIndex = index;
                PromoCategoryBoxBuy.PromoID = promoID;
                PromoCategoryBoxBuy.PrimaryTable = dsSetup.Tables("PromoBSGS");
                PromoCategoryBoxBuy.SupportingTable = dsSetup.Tables("PromoBSGSBuy");
                PromoCategoryBoxBuy.PrimaryColumn = "Buy";
                PromoCategoryBoxBuy.InitializeUserControl();
            }
            else
            {
                InitializeEmptyBSGSBoxBuy(promoID);
            }

            index = 0;
            foreach (DataRow currentORow1 in dsSetup.Tables("PromoBSGSGet").Rows)
            {
                oRow = currentORow1;
                if (oRow("PromoID") == promoID)
                    break;
                index += 1;
            }
            if (index < dsSetup.Tables("PromoBSGS").Rows.Count & NewRowFlag == false)
            {
                // newrowflag = true means we already initalized a new row (kind of)
                if (dsSetup.Tables("PromoBSGSGet").Rows(index)("GetFD_flag") == "F")
                {
                    PromoCategoryBoxGet.FoodDrink_Flag = "F";
                }
                else if (dsSetup.Tables("PromoBSGSGet").Rows(index)("GetFD_flag") == "D")
                {
                    PromoCategoryBoxGet.FoodDrink_Flag = "D";
                }
                if (!object.ReferenceEquals(dsSetup.Tables("PromoBSGSGet").Rows(index)("GetCategoryAmount"), DBNull.Value))
                {
                    txtPrGet.Text = dsSetup.Tables("PromoBSGSGet").Rows(index)("GetCategoryAmount");
                }
                PromoCategoryBoxGet.PositionIndex = index;
                PromoCategoryBoxGet.PromoID = promoID;
                PromoCategoryBoxGet.PrimaryTable = dsSetup.Tables("PromoBSGS");
                PromoCategoryBoxGet.SupportingTable = dsSetup.Tables("PromoBSGSGet");
                PromoCategoryBoxGet.PrimaryColumn = "Get";
                PromoCategoryBoxGet.InitializeUserControl();
            }
            else
            {
                InitializeEmptyBSGSBoxGet(promoID);
            }
        }

        else
        {

            InitializeEmptyBSGSBoxBuy(promoID);
            InitializeEmptyBSGSBoxGet(promoID);
        }

    }

    private void InitializeEmptyBSGSBoxBuy(int promoID)
    {
        PromoCategoryBoxBuy.FoodDrink_Flag = "F";
        PromoCategoryBoxBuy.PositionIndex = -1;
        PromoCategoryBoxBuy.PromoID = promoID;
        PromoCategoryBoxBuy.PrimaryTable = dsSetup.Tables("PromoBSGSBuy");
        PromoCategoryBoxBuy.PrimaryColumn = "Buy";
        PromoCategoryBoxBuy.NewRowFlag = true;
        NewRowFlag = true;
        PromoCategoryBoxBuy.InitializeUserControl();

    }

    private void InitializeEmptyBSGSBoxGet(int promoID)
    {
        PromoCategoryBoxGet.FoodDrink_Flag = "F";
        PromoCategoryBoxGet.PositionIndex = -1;
        PromoCategoryBoxGet.PromoID = promoID;
        PromoCategoryBoxGet.PrimaryTable = dsSetup.Tables("PromoBSGSGet");
        PromoCategoryBoxGet.PrimaryColumn = "Get";
        PromoCategoryBoxGet.NewRowFlag = true;
        NewRowFlag = true;
        PromoCategoryBoxGet.InitializeUserControl();


    }


    private void AddFromBSGSBox(ref DataRow oRow)
    {

        if (NewRowFlag == true)
        {
            NewRowFlag = false;
            oRow("PromoBSGSID") = InsertIntoBSGSPromo(ref oRow);
        }

    }

    private object InsertIntoBSGSPromo(ref DataRow oRow)
    {

        var newPromoID = default(int);

        sql.SqlInsertCommandPromoBSGS.Parameters("@CompanyID").Value = oRow("CompanyID");
        sql.SqlInsertCommandPromoBSGS.Parameters("@LocationID").Value = oRow("LocationID");
        sql.SqlInsertCommandPromoBSGS.Parameters("@PromoID").Value = oRow("PromoID");
        sql.SqlInsertCommandPromoBSGS.Parameters("@BuyFD_flag").Value = oRow("BuyFD_flag");
        sql.SqlInsertCommandPromoBSGS.Parameters("@BuyCategoryID").Value = oRow("BuyCategoryID");
        sql.SqlInsertCommandPromoBSGS.Parameters("@BuyCategoryAmount").Value = oRow("BuyCategoryAmount");
        sql.SqlInsertCommandPromoBSGS.Parameters("@BuyDrinkCategoryID").Value = oRow("BuyDrinkCategoryID");
        sql.SqlInsertCommandPromoBSGS.Parameters("@GetFD_flag").Value = oRow("GetFD_flag");
        sql.SqlInsertCommandPromoBSGS.Parameters("@GetCategoryID").Value = oRow("GetCategoryID");
        sql.SqlInsertCommandPromoBSGS.Parameters("@GetCategoryAmount").Value = oRow("GetCategoryAmount");
        sql.SqlInsertCommandPromoBSGS.Parameters("@GetQuantityDiscount").Value = oRow("GetQuantityDiscount");
        sql.SqlInsertCommandPromoBSGS.Parameters("@GetDrinkCategoryID").Value = oRow("GetDrinkCategoryID");

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            newPromoID = (int)sql.SqlInsertCommandPromoBSGS.ExecuteScalar();
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        return newPromoID;

    }



    private void txtPrBuy_TextChanged(object sender, EventArgs e)
    {

        foreach (DataRow oRow in dsSetup.Tables("PromoBSGS").Rows)
        {
            if (oRow("PromoID") == bsgsPromoID)
            {
                oRow("BuyCategoryAmount") = txtPrBuy.Text;
                break;
            }
        }

    }

    private void txtPrGet_TextChanged(object sender, EventArgs e)
    {

        foreach (DataRow oRow in dsSetup.Tables("PromoBSGS").Rows)
        {
            if (oRow("PromoID") == bsgsPromoID)
            {
                oRow("BuyCategoryAmount") = txtPrBuy.Text;
                break;
            }
        }

    }


}