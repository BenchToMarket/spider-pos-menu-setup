using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;


public partial class PromoCoupon : System.Windows.Forms.UserControl
{

    internal bool updatedData;
    internal int couponPromoID;
    internal bool NewRowFlag;
    private bool justCheckingBoxes;


    #region  Windows Form Designer generated code 

    public PromoCoupon(int promoID) : base()
    {

        // This call is required by the Windows Form Designer.
        InitializeComponent();

        // Add any initialization after the InitializeComponent() call
        InitializeOther(promoID);

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
    private Global.System.Windows.Forms.GroupBox _GroupBox1;

    internal virtual Global.System.Windows.Forms.GroupBox GroupBox1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _GroupBox1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _GroupBox1 = value;
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
    private Global.System.Windows.Forms.RadioButton _rdbCouponDollar;

    internal virtual Global.System.Windows.Forms.RadioButton rdbCouponDollar
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _rdbCouponDollar;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_rdbCouponDollar != null)
            {
                _rdbCouponDollar.CheckedChanged -= rdbCouponDollar_CheckedChanged;
            }

            _rdbCouponDollar = value;
            if (_rdbCouponDollar != null)
            {
                _rdbCouponDollar.CheckedChanged += rdbCouponDollar_CheckedChanged;
            }
        }
    }
    private Global.System.Windows.Forms.RadioButton _rdbCouponPercent;

    internal virtual Global.System.Windows.Forms.RadioButton rdbCouponPercent
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _rdbCouponPercent;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_rdbCouponPercent != null)
            {
                _rdbCouponPercent.CheckedChanged -= rdbCouponPercent_CheckedChanged;
            }

            _rdbCouponPercent = value;
            if (_rdbCouponPercent != null)
            {
                _rdbCouponPercent.CheckedChanged += rdbCouponPercent_CheckedChanged;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtCouponDollar;

    internal virtual Global.System.Windows.Forms.TextBox txtCouponDollar
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtCouponDollar;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtCouponDollar != null)
            {
                _txtCouponDollar.TextChanged -= txtCouponDollar_TextChanged;
            }

            _txtCouponDollar = value;
            if (_txtCouponDollar != null)
            {
                _txtCouponDollar.TextChanged += txtCouponDollar_TextChanged;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtCouponPercent;

    internal virtual Global.System.Windows.Forms.TextBox txtCouponPercent
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtCouponPercent;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtCouponPercent != null)
            {
                _txtCouponPercent.TextChanged -= txtCouponPercent_TextChanged;
            }

            _txtCouponPercent = value;
            if (_txtCouponPercent != null)
            {
                _txtCouponPercent.TextChanged += txtCouponPercent_TextChanged;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtCouponNumber;

    internal virtual Global.System.Windows.Forms.TextBox txtCouponNumber
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtCouponNumber;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtCouponNumber != null)
            {
                _txtCouponNumber.TextChanged -= txtCouponNumber_TextChanged;
            }

            _txtCouponNumber = value;
            if (_txtCouponNumber != null)
            {
                _txtCouponNumber.TextChanged += txtCouponNumber_TextChanged;
            }
        }
    }
    private Global.System.Windows.Forms.TextBox _txtCouponMin;

    internal virtual Global.System.Windows.Forms.TextBox txtCouponMin
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtCouponMin;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_txtCouponMin != null)
            {
                _txtCouponMin.TextChanged -= txtCouponMin_TextChanged;
            }

            _txtCouponMin = value;
            if (_txtCouponMin != null)
            {
                _txtCouponMin.TextChanged += txtCouponMin_TextChanged;
            }
        }
    }
    private Tahsc_server.PromoCategoryBox _PromoCategoryBoxCouponDiscount;

    internal virtual Tahsc_server.PromoCategoryBox PromoCategoryBoxCouponDiscount
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _PromoCategoryBoxCouponDiscount;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_PromoCategoryBoxCouponDiscount != null)
            {
                _PromoCategoryBoxCouponDiscount.AddingPromoRow -= AddFromBSGSBox;
            }

            _PromoCategoryBoxCouponDiscount = value;
            if (_PromoCategoryBoxCouponDiscount != null)
            {
                _PromoCategoryBoxCouponDiscount.AddingPromoRow += AddFromBSGSBox;
            }
        }
    }
    private Tahsc_server.PromoCategoryBox _PromoCategoryBoxCouponAtleast;

    internal virtual Tahsc_server.PromoCategoryBox PromoCategoryBoxCouponAtleast
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _PromoCategoryBoxCouponAtleast;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_PromoCategoryBoxCouponAtleast != null)
            {
                _PromoCategoryBoxCouponAtleast.AddingPromoRow -= AddFromBSGSBox;
            }

            _PromoCategoryBoxCouponAtleast = value;
            if (_PromoCategoryBoxCouponAtleast != null)
            {
                _PromoCategoryBoxCouponAtleast.AddingPromoRow += AddFromBSGSBox;
            }
        }
    }
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        _GroupBox1 = new System.Windows.Forms.GroupBox();
        _txtCouponPercent = new System.Windows.Forms.TextBox();
        _txtCouponPercent.TextChanged += txtCouponPercent_TextChanged;
        _txtCouponDollar = new System.Windows.Forms.TextBox();
        _txtCouponDollar.TextChanged += txtCouponDollar_TextChanged;
        _rdbCouponPercent = new System.Windows.Forms.RadioButton();
        _rdbCouponPercent.CheckedChanged += rdbCouponPercent_CheckedChanged;
        _rdbCouponDollar = new System.Windows.Forms.RadioButton();
        _rdbCouponDollar.CheckedChanged += rdbCouponDollar_CheckedChanged;
        _Label1 = new System.Windows.Forms.Label();
        _txtCouponNumber = new System.Windows.Forms.TextBox();
        _txtCouponNumber.TextChanged += txtCouponNumber_TextChanged;
        _Label3 = new System.Windows.Forms.Label();
        _txtCouponMin = new System.Windows.Forms.TextBox();
        _txtCouponMin.TextChanged += txtCouponMin_TextChanged;
        _Label2 = new System.Windows.Forms.Label();
        _Label4 = new System.Windows.Forms.Label();
        _Label5 = new System.Windows.Forms.Label();
        _Label6 = new System.Windows.Forms.Label();
        _PromoCategoryBoxCouponDiscount = new Tahsc_server.PromoCategoryBox();
        _PromoCategoryBoxCouponDiscount.AddingPromoRow += AddFromBSGSBox;
        _PromoCategoryBoxCouponAtleast = new Tahsc_server.PromoCategoryBox();
        _PromoCategoryBoxCouponAtleast.AddingPromoRow += AddFromBSGSBox;
        _GroupBox1.SuspendLayout();
        this.SuspendLayout();
        // 
        // GroupBox1
        // 
        _GroupBox1.Controls.Add(_txtCouponPercent);
        _GroupBox1.Controls.Add(_txtCouponDollar);
        _GroupBox1.Controls.Add(_rdbCouponPercent);
        _GroupBox1.Controls.Add(_rdbCouponDollar);
        _GroupBox1.Location = new System.Drawing.Point(272, 16);
        _GroupBox1.Name = "_GroupBox1";
        _GroupBox1.Size = new System.Drawing.Size(144, 72);
        _GroupBox1.TabIndex = 0;
        _GroupBox1.TabStop = false;
        _GroupBox1.Text = "Discount Type";
        // 
        // txtCouponPercent
        // 
        _txtCouponPercent.Location = new System.Drawing.Point(80, 40);
        _txtCouponPercent.Name = "_txtCouponPercent";
        _txtCouponPercent.Size = new System.Drawing.Size(56, 20);
        _txtCouponPercent.TabIndex = 3;
        _txtCouponPercent.Text = "";
        // 
        // txtCouponDollar
        // 
        _txtCouponDollar.Location = new System.Drawing.Point(80, 16);
        _txtCouponDollar.Name = "_txtCouponDollar";
        _txtCouponDollar.Size = new System.Drawing.Size(56, 20);
        _txtCouponDollar.TabIndex = 2;
        _txtCouponDollar.Text = "";
        // 
        // rdbCouponPercent
        // 
        _rdbCouponPercent.Location = new System.Drawing.Point(8, 48);
        _rdbCouponPercent.Name = "_rdbCouponPercent";
        _rdbCouponPercent.Size = new System.Drawing.Size(72, 16);
        _rdbCouponPercent.TabIndex = 1;
        _rdbCouponPercent.Text = "Percent";
        // 
        // rdbCouponDollar
        // 
        _rdbCouponDollar.Location = new System.Drawing.Point(8, 24);
        _rdbCouponDollar.Name = "_rdbCouponDollar";
        _rdbCouponDollar.Size = new System.Drawing.Size(72, 16);
        _rdbCouponDollar.TabIndex = 0;
        _rdbCouponDollar.Text = "Dollar";
        // 
        // Label1
        // 
        _Label1.Location = new System.Drawing.Point(64, 144);
        _Label1.Name = "_Label1";
        _Label1.Size = new System.Drawing.Size(96, 24);
        _Label1.TabIndex = 1;
        _Label1.Text = "Discount upto:";
        _Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtCouponNumber
        // 
        _txtCouponNumber.Location = new System.Drawing.Point(176, 144);
        _txtCouponNumber.Name = "_txtCouponNumber";
        _txtCouponNumber.Size = new System.Drawing.Size(40, 20);
        _txtCouponNumber.TabIndex = 4;
        _txtCouponNumber.Text = "";
        // 
        // Label3
        // 
        _Label3.Location = new System.Drawing.Point(24, 184);
        _Label3.Name = "_Label3";
        _Label3.Size = new System.Drawing.Size(136, 16);
        _Label3.TabIndex = 5;
        _Label3.Text = "Must Order at Least:";
        _Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtCouponMin
        // 
        _txtCouponMin.Location = new System.Drawing.Point(176, 184);
        _txtCouponMin.Name = "_txtCouponMin";
        _txtCouponMin.Size = new System.Drawing.Size(40, 20);
        _txtCouponMin.TabIndex = 6;
        _txtCouponMin.Text = "";
        // 
        // Label2
        // 
        _Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label2.Location = new System.Drawing.Point(168, 112);
        _Label2.Name = "_Label2";
        _Label2.Size = new System.Drawing.Size(56, 16);
        _Label2.TabIndex = 8;
        _Label2.Text = "Number";
        _Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Label4
        // 
        _Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label4.Location = new System.Drawing.Point(240, 112);
        _Label4.Name = "_Label4";
        _Label4.Size = new System.Drawing.Size(104, 16);
        _Label4.TabIndex = 9;
        _Label4.Text = "Category";
        _Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Label5
        // 
        _Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label5.Location = new System.Drawing.Point(80, 200);
        _Label5.Name = "_Label5";
        _Label5.Size = new System.Drawing.Size(72, 16);
        _Label5.TabIndex = 10;
        _Label5.Text = "(optional)";
        // 
        // Label6
        // 
        _Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label6.Location = new System.Drawing.Point(32, 24);
        _Label6.Name = "_Label6";
        _Label6.Size = new System.Drawing.Size(168, 32);
        _Label6.TabIndex = 23;
        _Label6.Text = "Coupon Promotion";
        _Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // PromoCategoryBoxCouponDiscount
        // 
        _PromoCategoryBoxCouponDiscount.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _PromoCategoryBoxCouponDiscount.Location = new System.Drawing.Point(232, 144);
        _PromoCategoryBoxCouponDiscount.Name = "_PromoCategoryBoxCouponDiscount";
        _PromoCategoryBoxCouponDiscount.Size = new System.Drawing.Size(160, 24);
        _PromoCategoryBoxCouponDiscount.TabIndex = 24;
        // 
        // PromoCategoryBoxCouponAtleast
        // 
        _PromoCategoryBoxCouponAtleast.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _PromoCategoryBoxCouponAtleast.Location = new System.Drawing.Point(232, 184);
        _PromoCategoryBoxCouponAtleast.Name = "_PromoCategoryBoxCouponAtleast";
        _PromoCategoryBoxCouponAtleast.Size = new System.Drawing.Size(160, 24);
        _PromoCategoryBoxCouponAtleast.TabIndex = 25;
        // 
        // PromoCoupon
        // 
        this.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        this.Controls.Add(_PromoCategoryBoxCouponAtleast);
        this.Controls.Add(_PromoCategoryBoxCouponDiscount);
        this.Controls.Add(_Label6);
        this.Controls.Add(_Label5);
        this.Controls.Add(_Label4);
        this.Controls.Add(_Label2);
        this.Controls.Add(_txtCouponMin);
        this.Controls.Add(_Label3);
        this.Controls.Add(_txtCouponNumber);
        this.Controls.Add(_Label1);
        this.Controls.Add(_GroupBox1);
        this.Name = "PromoCoupon";
        this.Size = new System.Drawing.Size(432, 256);
        _GroupBox1.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private void InitializeOther(int promoID)
    {

        var index = default(int);
        DataRow oRow;
        couponPromoID = promoID;

        if (dsSetup.Tables("PromoCoupon").Rows.Count > 0)
        {
            foreach (DataRow currentORow in dsSetup.Tables("PromoCouponDiscount").Rows)
            {
                oRow = currentORow;
                if (oRow("PromoID") == promoID)
                    break;
                index += 1;
            }

            if (index < dsSetup.Tables("PromoCoupon").Rows.Count)
            {
                if (!object.ReferenceEquals(dsSetup.Tables("PromoCoupon").Rows(index)("CouponDollarFlag"), DBNull.Value))
                {
                    rdbCouponDollar.Checked = dsSetup.Tables("PromoCoupon").Rows(index)("CouponDollarFlag");
                }
                if (!object.ReferenceEquals(dsSetup.Tables("PromoCoupon").Rows(index)("CouponPercentFlag"), DBNull.Value))
                {
                    rdbCouponPercent.Checked = dsSetup.Tables("PromoCoupon").Rows(index)("CouponPercentFlag");
                }

                if (!object.ReferenceEquals(dsSetup.Tables("PromoCoupon").Rows(index)("CouponDollarAmount"), DBNull.Value))
                {
                    txtCouponDollar.Text = dsSetup.Tables("PromoCoupon").Rows(index)("CouponDollarAmount");
                }
                if (!object.ReferenceEquals(dsSetup.Tables("PromoCoupon").Rows(index)("CouponPercentAmount"), DBNull.Value))
                {
                    txtCouponPercent.Text = dsSetup.Tables("PromoCoupon").Rows(index)("CouponPercentAmount");
                }

            }
            // my concern is can you ever get here without a PromoID
            // need some kind of defense for this something like:
            // If index > dssetup.tables("PromoBSGS").count then ????
            if (index < dsSetup.Tables("PromoCoupon").Rows.Count & NewRowFlag == false)
            {
                if (dsSetup.Tables("PromoCouponDiscount").Rows(index)("DiscountFD_flag") == "F")
                {
                    PromoCategoryBoxCouponDiscount.FoodDrink_Flag = "F";
                }
                else if (dsSetup.Tables("PromoCouponDiscount").Rows(index)("DiscountFD_flag") == "D")
                {
                    PromoCategoryBoxCouponDiscount.FoodDrink_Flag = "D";
                }
                if (!object.ReferenceEquals(dsSetup.Tables("PromoCouponDiscount").Rows(index)("DiscountCategoryAmount"), DBNull.Value))
                {
                    txtCouponNumber.Text = dsSetup.Tables("PromoCouponDiscount").Rows(index)("DiscountCategoryAmount");
                }
                PromoCategoryBoxCouponDiscount.PositionIndex = index;
                PromoCategoryBoxCouponDiscount.PromoID = promoID;
                PromoCategoryBoxCouponDiscount.PrimaryTable = dsSetup.Tables("PromoCoupon");
                PromoCategoryBoxCouponDiscount.SupportingTable = dsSetup.Tables("PromoCouponDiscount");
                PromoCategoryBoxCouponDiscount.PrimaryColumn = "Discount";
                PromoCategoryBoxCouponDiscount.InitializeUserControl();
            }
            else
            {
                InitializeEmptyCouponBoxDiscount(promoID);

            }

            index = 0;
            foreach (DataRow currentORow1 in dsSetup.Tables("PromoCouponAtleast").Rows)
            {
                oRow = currentORow1;
                if (oRow("PromoID") == promoID)
                    break;
                index += 1;
            }

            if (index < dsSetup.Tables("PromoCoupon").Rows.Count & NewRowFlag == false)
            {
                if (dsSetup.Tables("PromoCouponAtleast").Rows(index)("AtleastFD_flag") == "F")
                {
                    PromoCategoryBoxCouponAtleast.FoodDrink_Flag = "F";
                }
                else if (dsSetup.Tables("PromoCouponAtleast").Rows(index)("AtleastFD_flag") == "D")
                {
                    PromoCategoryBoxCouponAtleast.FoodDrink_Flag = "D";
                }
                if (!object.ReferenceEquals(dsSetup.Tables("PromoCouponAtleast").Rows(index)("AtleastCategoryAmount"), DBNull.Value))
                {
                    txtCouponMin.Text = dsSetup.Tables("PromoCouponAtleast").Rows(index)("AtleastCategoryAmount");
                }
                PromoCategoryBoxCouponAtleast.PositionIndex = index;
                PromoCategoryBoxCouponAtleast.PromoID = promoID;
                PromoCategoryBoxCouponAtleast.PrimaryTable = dsSetup.Tables("PromoCoupon");
                PromoCategoryBoxCouponAtleast.SupportingTable = dsSetup.Tables("PromoCouponAtleast");
                PromoCategoryBoxCouponAtleast.PrimaryColumn = "Atleast";
                PromoCategoryBoxCouponAtleast.InitializeUserControl();
            }
            else
            {
                InitializeEmptyCouponBoxAtleast(promoID);

            }
        }

        else
        {
            InitializeEmptyCouponBoxDiscount(promoID);
            InitializeEmptyCouponBoxAtleast(promoID);
        }

    }

    private void AddFromBSGSBox(ref DataRow oRow)
    {

        if (NewRowFlag == true)
        {
            NewRowFlag = false;
            oRow("PromoCouponID") = InsertIntoCouponPromo(ref oRow);
        }

    }

    private object InsertIntoCouponPromo(ref DataRow oRow)
    {

        var newPromoID = default(int);

        sql.SqlInsertCommandCoupon.Parameters("@CompanyID").Value = oRow("CompanyID");
        sql.SqlInsertCommandPromoBSGS.Parameters("@LocationID").Value = oRow("LocationID");
        sql.SqlInsertCommandPromoBSGS.Parameters("@PromoID").Value = oRow("PromoID");
        sql.SqlInsertCommandCoupon.Parameters("@DiscountFD_flag").Value = oRow("DiscountFD_flag");
        sql.SqlInsertCommandCoupon.Parameters("@DiscountCategoryID").Value = oRow("DiscountCategoryID");
        sql.SqlInsertCommandCoupon.Parameters("@DiscountCategoryAmount").Value = oRow("DiscountCategoryAmount");
        sql.SqlInsertCommandCoupon.Parameters("@DiscountDrinkCategoryID").Value = oRow("DiscountDrinkCategoryID");
        sql.SqlInsertCommandCoupon.Parameters("@AtLeastFD_flag").Value = oRow("AtLeastFD_flag");
        sql.SqlInsertCommandCoupon.Parameters("@AtLeastCategoryID").Value = oRow("AtLeastCategoryID");
        sql.SqlInsertCommandCoupon.Parameters("@AtLeastCategoryAmount").Value = oRow("AtLeastCategoryAmount");
        sql.SqlInsertCommandCoupon.Parameters("@AtLeastDrinkCategoryID").Value = oRow("AtLeastDrinkCategoryID");
        sql.SqlInsertCommandCoupon.Parameters("@CouponDollarFlag").Value = oRow("CouponDollarFlag");
        sql.SqlInsertCommandCoupon.Parameters("@CouponDollarAmount").Value = oRow("CouponDollarAmount");
        sql.SqlInsertCommandCoupon.Parameters("@CouponPercentFlag").Value = oRow("CouponPercentFlag");
        sql.SqlInsertCommandCoupon.Parameters("@CouponPercentAmount").Value = oRow("CouponPercentAmount");

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            newPromoID = (int)sql.SqlInsertCommandCoupon.ExecuteScalar();
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        return newPromoID;

    }



    private void InitializeEmptyCouponBoxDiscount(int promoID)
    {
        PromoCategoryBoxCouponDiscount.PositionIndex = -1;
        PromoCategoryBoxCouponDiscount.FoodDrink_Flag = "F";
        PromoCategoryBoxCouponDiscount.PromoID = promoID;
        PromoCategoryBoxCouponDiscount.PrimaryTable = dsSetup.Tables("PromoCoupon");
        PromoCategoryBoxCouponDiscount.SupportingTable = dsSetup.Tables("PromoCouponDiscount");
        PromoCategoryBoxCouponDiscount.PrimaryColumn = "Discount";
        PromoCategoryBoxCouponDiscount.NewRowFlag = true;
        NewRowFlag = true;
        PromoCategoryBoxCouponDiscount.InitializeUserControl();
    }

    private void InitializeEmptyCouponBoxAtleast(int promoID)
    {
        PromoCategoryBoxCouponAtleast.PositionIndex = -1;
        PromoCategoryBoxCouponAtleast.FoodDrink_Flag = "F";
        PromoCategoryBoxCouponAtleast.PromoID = promoID;
        PromoCategoryBoxCouponAtleast.PrimaryTable = dsSetup.Tables("PromoCoupon");
        PromoCategoryBoxCouponAtleast.SupportingTable = dsSetup.Tables("PromoCouponAtleast");
        PromoCategoryBoxCouponAtleast.PrimaryColumn = "Atleast";
        PromoCategoryBoxCouponAtleast.NewRowFlag = true;
        NewRowFlag = true;
        PromoCategoryBoxCouponAtleast.InitializeUserControl();
    }


    private void rdbCouponDollar_CheckedChanged(object sender, EventArgs e)
    {

        foreach (DataRow oRow in dsSetup.Tables("PromoCoupon").Rows)
        {
            if (oRow("PromoID") == couponPromoID)
            {
                oRow("CouponDollarFlag") = rdbCouponDollar.Checked;
            }
        }

    }

    private void rdbCouponPercent_CheckedChanged(object sender, EventArgs e)
    {

        foreach (DataRow oRow in dsSetup.Tables("PromoCoupon").Rows)
        {
            if (oRow("PromoID") == couponPromoID)
            {
                oRow("CouponPercentFlag") = rdbCouponPercent.Checked;
                break;
            }
        }

    }


    private void txtCouponDollar_TextChanged(object sender, EventArgs e)
    {
        decimal newDollar;

        foreach (DataRow oRow in dsSetup.Tables("PromoCoupon").Rows)
        {
            if (oRow("PromoID") == couponPromoID)
            {
                if (txtCouponDollar.Text == "")
                {
                    oRow("CouponDollarAmount") = DBNull.Value;
                }
                else
                {
                    try
                    {
                        newDollar = (decimal)txtCouponDollar.Text;
                        oRow("CouponDollarAmount") = Strings.Format(newDollar, "###.00");
                    }
                    catch (Exception ex)
                    {
                        oRow("CouponDollarAmount") = DBNull.Value;
                    }

                }
                break;
            }
        }

    }

    private void txtCouponPercent_TextChanged(object sender, EventArgs e)
    {
        decimal newPercent;

        foreach (DataRow oRow in dsSetup.Tables("PromoCoupon").Rows)
        {
            if (oRow("PromoID") == couponPromoID)
            {
                if (txtCouponDollar.Text == "")
                {
                    oRow("CouponPercentAmount") = DBNull.Value;
                }
                else
                {
                    try
                    {
                        newPercent = (decimal)txtCouponPercent.Text;
                        if (newPercent > 1m)
                        {
                            newPercent = newPercent / 100m;
                        }
                        Strings.Format(newPercent, "###.00");
                        oRow("CouponPercentAmount") = newPercent;
                    }
                    catch (Exception ex)
                    {
                        oRow("CouponPercentAmount") = DBNull.Value;
                    }

                }
                break;
            }
        }

    }

    private void txtCouponNumber_TextChanged(object sender, EventArgs e)
    {

        foreach (DataRow oRow in dsSetup.Tables("PromoCoupon").Rows)
        {
            if (oRow("PromoID") == couponPromoID)
            {
                oRow("DiscountCategoryAmount") = txtCouponNumber.Text;
                break;
            }
        }

    }


    private void txtCouponMin_TextChanged(object sender, EventArgs e)
    {

        foreach (DataRow oRow in dsSetup.Tables("PromoCoupon").Rows)
        {
            if (oRow("PromoID") == couponPromoID)
            {
                oRow("AtleastCategoryAmount") = txtCouponMin.Text;
                break;
            }
        }

    }
}