using System.Diagnostics;
using System.Runtime.CompilerServices;

public partial class PromoCombo : System.Windows.Forms.UserControl
{


    // ********************************************
    // this is NOT correct
    // we need to do similiar to Coupon and BSGS
    // 
    // ********************************************

    #region  Windows Form Designer generated code 

    public PromoCombo(int promoID) : base()
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
    private Global.System.Windows.Forms.Label _lblPromoComboPrice;

    internal virtual Global.System.Windows.Forms.Label lblPromoComboPrice
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblPromoComboPrice;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblPromoComboPrice = value;
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
    private Global.System.Windows.Forms.TextBox _txtComboPrice;

    internal virtual Global.System.Windows.Forms.TextBox txtComboPrice
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtComboPrice;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtComboPrice = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtCombo1;

    internal virtual Global.System.Windows.Forms.TextBox txtCombo1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtCombo1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtCombo1 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtCombo2;

    internal virtual Global.System.Windows.Forms.TextBox txtCombo2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtCombo2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtCombo2 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtCombo3;

    internal virtual Global.System.Windows.Forms.TextBox txtCombo3
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtCombo3;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtCombo3 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtCombo4;

    internal virtual Global.System.Windows.Forms.TextBox txtCombo4
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtCombo4;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtCombo4 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtCombo5;

    internal virtual Global.System.Windows.Forms.TextBox txtCombo5
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtCombo5;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtCombo5 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtCombo6;

    internal virtual Global.System.Windows.Forms.TextBox txtCombo6
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtCombo6;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtCombo6 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtCombo7;

    internal virtual Global.System.Windows.Forms.TextBox txtCombo7
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtCombo7;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtCombo7 = value;
        }
    }
    private Global.System.Windows.Forms.TextBox _txtCombo8;

    internal virtual Global.System.Windows.Forms.TextBox txtCombo8
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _txtCombo8;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _txtCombo8 = value;
        }
    }
    private Tahsc_server.PromoCategoryBox _catboxCombo1;

    internal virtual Tahsc_server.PromoCategoryBox catboxCombo1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _catboxCombo1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _catboxCombo1 = value;
        }
    }
    private Tahsc_server.PromoCategoryBox _catboxCombo2;

    internal virtual Tahsc_server.PromoCategoryBox catboxCombo2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _catboxCombo2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _catboxCombo2 = value;
        }
    }
    private Tahsc_server.PromoCategoryBox _catboxCombo3;

    internal virtual Tahsc_server.PromoCategoryBox catboxCombo3
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _catboxCombo3;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _catboxCombo3 = value;
        }
    }
    private Tahsc_server.PromoCategoryBox _catboxCombo4;

    internal virtual Tahsc_server.PromoCategoryBox catboxCombo4
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _catboxCombo4;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _catboxCombo4 = value;
        }
    }
    private Tahsc_server.PromoCategoryBox _catboxCombo5;

    internal virtual Tahsc_server.PromoCategoryBox catboxCombo5
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _catboxCombo5;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _catboxCombo5 = value;
        }
    }
    private Tahsc_server.PromoCategoryBox _catboxCombo6;

    internal virtual Tahsc_server.PromoCategoryBox catboxCombo6
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _catboxCombo6;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _catboxCombo6 = value;
        }
    }
    private Tahsc_server.PromoCategoryBox _catboxCombo7;

    internal virtual Tahsc_server.PromoCategoryBox catboxCombo7
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _catboxCombo7;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _catboxCombo7 = value;
        }
    }
    private Tahsc_server.PromoCategoryBox _catboxCombo8;

    internal virtual Tahsc_server.PromoCategoryBox catboxCombo8
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _catboxCombo8;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _catboxCombo8 = value;
        }
    }
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        _txtComboPrice = new System.Windows.Forms.TextBox();
        _lblPromoComboPrice = new System.Windows.Forms.Label();
        _Label1 = new System.Windows.Forms.Label();
        _Label2 = new System.Windows.Forms.Label();
        _txtCombo1 = new System.Windows.Forms.TextBox();
        _txtCombo2 = new System.Windows.Forms.TextBox();
        _txtCombo3 = new System.Windows.Forms.TextBox();
        _txtCombo4 = new System.Windows.Forms.TextBox();
        _Label3 = new System.Windows.Forms.Label();
        _Label4 = new System.Windows.Forms.Label();
        _txtCombo5 = new System.Windows.Forms.TextBox();
        _txtCombo6 = new System.Windows.Forms.TextBox();
        _txtCombo7 = new System.Windows.Forms.TextBox();
        _txtCombo8 = new System.Windows.Forms.TextBox();
        _Label5 = new System.Windows.Forms.Label();
        _catboxCombo1 = new Tahsc_server.PromoCategoryBox();
        _catboxCombo2 = new Tahsc_server.PromoCategoryBox();
        _catboxCombo3 = new Tahsc_server.PromoCategoryBox();
        _catboxCombo4 = new Tahsc_server.PromoCategoryBox();
        _catboxCombo5 = new Tahsc_server.PromoCategoryBox();
        _catboxCombo6 = new Tahsc_server.PromoCategoryBox();
        _catboxCombo7 = new Tahsc_server.PromoCategoryBox();
        _catboxCombo8 = new Tahsc_server.PromoCategoryBox();
        this.SuspendLayout();
        // 
        // txtComboPrice
        // 
        _txtComboPrice.Location = new System.Drawing.Point(336, 16);
        _txtComboPrice.Name = "_txtComboPrice";
        _txtComboPrice.Size = new System.Drawing.Size(72, 20);
        _txtComboPrice.TabIndex = 0;
        _txtComboPrice.Text = "";
        // 
        // lblPromoComboPrice
        // 
        _lblPromoComboPrice.Location = new System.Drawing.Point(280, 16);
        _lblPromoComboPrice.Name = "_lblPromoComboPrice";
        _lblPromoComboPrice.Size = new System.Drawing.Size(56, 16);
        _lblPromoComboPrice.TabIndex = 1;
        _lblPromoComboPrice.Text = "Price:";
        _lblPromoComboPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label1
        // 
        _Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label1.Location = new System.Drawing.Point(32, 72);
        _Label1.Name = "_Label1";
        _Label1.Size = new System.Drawing.Size(96, 16);
        _Label1.TabIndex = 2;
        _Label1.Text = "Category";
        _Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Label2
        // 
        _Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label2.Location = new System.Drawing.Point(168, 72);
        _Label2.Name = "_Label2";
        _Label2.Size = new System.Drawing.Size(32, 16);
        _Label2.TabIndex = 3;
        _Label2.Text = "Max";
        _Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtCombo1
        // 
        _txtCombo1.Location = new System.Drawing.Point(168, 104);
        _txtCombo1.Name = "_txtCombo1";
        _txtCombo1.Size = new System.Drawing.Size(32, 20);
        _txtCombo1.TabIndex = 8;
        _txtCombo1.Text = "";
        // 
        // txtCombo2
        // 
        _txtCombo2.Location = new System.Drawing.Point(168, 136);
        _txtCombo2.Name = "_txtCombo2";
        _txtCombo2.Size = new System.Drawing.Size(32, 20);
        _txtCombo2.TabIndex = 9;
        _txtCombo2.Text = "";
        // 
        // txtCombo3
        // 
        _txtCombo3.Location = new System.Drawing.Point(168, 168);
        _txtCombo3.Name = "_txtCombo3";
        _txtCombo3.Size = new System.Drawing.Size(32, 20);
        _txtCombo3.TabIndex = 10;
        _txtCombo3.Text = "";
        // 
        // txtCombo4
        // 
        _txtCombo4.Location = new System.Drawing.Point(168, 200);
        _txtCombo4.Name = "_txtCombo4";
        _txtCombo4.Size = new System.Drawing.Size(32, 20);
        _txtCombo4.TabIndex = 11;
        _txtCombo4.Text = "";
        // 
        // Label3
        // 
        _Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label3.Location = new System.Drawing.Point(256, 72);
        _Label3.Name = "_Label3";
        _Label3.Size = new System.Drawing.Size(96, 16);
        _Label3.TabIndex = 12;
        _Label3.Text = "Category";
        _Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Label4
        // 
        _Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label4.Location = new System.Drawing.Point(392, 72);
        _Label4.Name = "_Label4";
        _Label4.Size = new System.Drawing.Size(32, 16);
        _Label4.TabIndex = 13;
        _Label4.Text = "Max";
        _Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtCombo5
        // 
        _txtCombo5.Location = new System.Drawing.Point(392, 104);
        _txtCombo5.Name = "_txtCombo5";
        _txtCombo5.Size = new System.Drawing.Size(32, 20);
        _txtCombo5.TabIndex = 18;
        _txtCombo5.Text = "";
        // 
        // txtCombo6
        // 
        _txtCombo6.Location = new System.Drawing.Point(392, 136);
        _txtCombo6.Name = "_txtCombo6";
        _txtCombo6.Size = new System.Drawing.Size(32, 20);
        _txtCombo6.TabIndex = 19;
        _txtCombo6.Text = "";
        // 
        // txtCombo7
        // 
        _txtCombo7.Location = new System.Drawing.Point(392, 168);
        _txtCombo7.Name = "_txtCombo7";
        _txtCombo7.Size = new System.Drawing.Size(32, 20);
        _txtCombo7.TabIndex = 20;
        _txtCombo7.Text = "";
        // 
        // txtCombo8
        // 
        _txtCombo8.Location = new System.Drawing.Point(392, 200);
        _txtCombo8.Name = "_txtCombo8";
        _txtCombo8.Size = new System.Drawing.Size(32, 20);
        _txtCombo8.TabIndex = 21;
        _txtCombo8.Text = "";
        // 
        // Label5
        // 
        _Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
        _Label5.Location = new System.Drawing.Point(72, 16);
        _Label5.Name = "_Label5";
        _Label5.Size = new System.Drawing.Size(168, 32);
        _Label5.TabIndex = 22;
        _Label5.Text = "Combo Promotion";
        _Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // catboxCombo1
        // 
        _catboxCombo1.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _catboxCombo1.Location = new System.Drawing.Point(8, 104);
        _catboxCombo1.Name = "_catboxCombo1";
        _catboxCombo1.Size = new System.Drawing.Size(160, 24);
        _catboxCombo1.TabIndex = 23;
        // 
        // catboxCombo2
        // 
        _catboxCombo2.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _catboxCombo2.Location = new System.Drawing.Point(8, 136);
        _catboxCombo2.Name = "_catboxCombo2";
        _catboxCombo2.Size = new System.Drawing.Size(160, 24);
        _catboxCombo2.TabIndex = 24;
        // 
        // catboxCombo3
        // 
        _catboxCombo3.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _catboxCombo3.Location = new System.Drawing.Point(8, 168);
        _catboxCombo3.Name = "_catboxCombo3";
        _catboxCombo3.Size = new System.Drawing.Size(160, 24);
        _catboxCombo3.TabIndex = 25;
        // 
        // catboxCombo4
        // 
        _catboxCombo4.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _catboxCombo4.Location = new System.Drawing.Point(8, 200);
        _catboxCombo4.Name = "_catboxCombo4";
        _catboxCombo4.Size = new System.Drawing.Size(160, 24);
        _catboxCombo4.TabIndex = 26;
        // 
        // catboxCombo5
        // 
        _catboxCombo5.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _catboxCombo5.Location = new System.Drawing.Point(232, 104);
        _catboxCombo5.Name = "_catboxCombo5";
        _catboxCombo5.Size = new System.Drawing.Size(160, 24);
        _catboxCombo5.TabIndex = 27;
        // 
        // catboxCombo6
        // 
        _catboxCombo6.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _catboxCombo6.Location = new System.Drawing.Point(232, 136);
        _catboxCombo6.Name = "_catboxCombo6";
        _catboxCombo6.Size = new System.Drawing.Size(160, 24);
        _catboxCombo6.TabIndex = 28;
        // 
        // catboxCombo7
        // 
        _catboxCombo7.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _catboxCombo7.Location = new System.Drawing.Point(232, 168);
        _catboxCombo7.Name = "_catboxCombo7";
        _catboxCombo7.Size = new System.Drawing.Size(160, 24);
        _catboxCombo7.TabIndex = 29;
        // 
        // catboxCombo8
        // 
        _catboxCombo8.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _catboxCombo8.Location = new System.Drawing.Point(232, 200);
        _catboxCombo8.Name = "_catboxCombo8";
        _catboxCombo8.Size = new System.Drawing.Size(160, 24);
        _catboxCombo8.TabIndex = 30;
        // 
        // PromoCombo
        // 
        this.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        this.Controls.Add(_catboxCombo8);
        this.Controls.Add(_catboxCombo7);
        this.Controls.Add(_catboxCombo6);
        this.Controls.Add(_catboxCombo5);
        this.Controls.Add(_catboxCombo4);
        this.Controls.Add(_catboxCombo3);
        this.Controls.Add(_catboxCombo2);
        this.Controls.Add(_catboxCombo1);
        this.Controls.Add(_Label5);
        this.Controls.Add(_txtCombo8);
        this.Controls.Add(_txtCombo7);
        this.Controls.Add(_txtCombo6);
        this.Controls.Add(_txtCombo5);
        this.Controls.Add(_Label4);
        this.Controls.Add(_Label3);
        this.Controls.Add(_txtCombo4);
        this.Controls.Add(_txtCombo3);
        this.Controls.Add(_txtCombo2);
        this.Controls.Add(_txtCombo1);
        this.Controls.Add(_Label2);
        this.Controls.Add(_Label1);
        this.Controls.Add(_lblPromoComboPrice);
        this.Controls.Add(_txtComboPrice);
        this.Name = "PromoCombo";
        this.Size = new System.Drawing.Size(432, 256);
        this.ResumeLayout(false);

    }

    #endregion

    private void InitializeOther(int promoID)
    {
        var catboxIndex = default(int);      // starts at 1
        var bindingIndex = default(int);     // starts as 0

        foreach (DataRow oRow in dsSetup.Tables("PromoCombo").Rows)
        {
            if (oRow("PromoID") == promoID)
            {
                catboxIndex += 1;

                switch (catboxIndex)
                {
                    case var @case when @case == 1:
                        {
                            var argcomboBox = catboxCombo1;
                            InitializeComboBox(ref argcomboBox, bindingIndex, promoID);
                            catboxCombo1 = argcomboBox;
                            break;
                        }
                    case var case1 when case1 == 2:
                        {
                            var argcomboBox1 = catboxCombo2;
                            InitializeComboBox(ref argcomboBox1, bindingIndex, promoID);
                            catboxCombo2 = argcomboBox1;
                            break;
                        }
                    case var case2 when case2 == 3:
                        {
                            var argcomboBox2 = catboxCombo3;
                            InitializeComboBox(ref argcomboBox2, bindingIndex, promoID);
                            catboxCombo3 = argcomboBox2;
                            break;
                        }
                    case var case3 when case3 == 4:
                        {
                            var argcomboBox3 = catboxCombo4;
                            InitializeComboBox(ref argcomboBox3, bindingIndex, promoID);
                            catboxCombo4 = argcomboBox3;
                            break;
                        }
                    case var case4 when case4 == 5:
                        {
                            var argcomboBox4 = catboxCombo5;
                            InitializeComboBox(ref argcomboBox4, bindingIndex, promoID);
                            catboxCombo5 = argcomboBox4;
                            break;
                        }
                    case var case5 when case5 == 6:
                        {
                            var argcomboBox5 = catboxCombo6;
                            InitializeComboBox(ref argcomboBox5, bindingIndex, promoID);
                            catboxCombo6 = argcomboBox5;
                            break;
                        }
                    case var case6 when case6 == 7:
                        {
                            var argcomboBox6 = catboxCombo7;
                            InitializeComboBox(ref argcomboBox6, bindingIndex, promoID);
                            catboxCombo7 = argcomboBox6;
                            break;
                        }
                    case var case7 when case7 == 8:
                        {
                            var argcomboBox7 = catboxCombo8;
                            InitializeComboBox(ref argcomboBox7, bindingIndex, promoID);
                            catboxCombo8 = argcomboBox7;
                            break;
                        }

                }
            }
            bindingIndex += 1;
        }

        if (catboxIndex < 1)
        {
            var argcomboBox8 = catboxCombo1;
            InitializeEmptyComboBox(ref argcomboBox8, promoID);
            catboxCombo1 = argcomboBox8;
        }
        if (catboxIndex < 2)
        {
            var argcomboBox9 = catboxCombo2;
            InitializeEmptyComboBox(ref argcomboBox9, promoID);
            catboxCombo2 = argcomboBox9;
        }
        if (catboxIndex < 3)
        {
            var argcomboBox10 = catboxCombo3;
            InitializeEmptyComboBox(ref argcomboBox10, promoID);
            catboxCombo3 = argcomboBox10;
        }
        if (catboxIndex < 4)
        {
            var argcomboBox11 = catboxCombo4;
            InitializeEmptyComboBox(ref argcomboBox11, promoID);
            catboxCombo4 = argcomboBox11;
        }
        if (catboxIndex < 5)
        {
            var argcomboBox12 = catboxCombo5;
            InitializeEmptyComboBox(ref argcomboBox12, promoID);
            catboxCombo5 = argcomboBox12;
        }
        if (catboxIndex < 6)
        {
            var argcomboBox13 = catboxCombo6;
            InitializeEmptyComboBox(ref argcomboBox13, promoID);
            catboxCombo6 = argcomboBox13;
        }
        if (catboxIndex < 7)
        {
            var argcomboBox14 = catboxCombo7;
            InitializeEmptyComboBox(ref argcomboBox14, promoID);
            catboxCombo7 = argcomboBox14;
        }
        if (catboxIndex < 8)
        {
            var argcomboBox15 = catboxCombo8;
            InitializeEmptyComboBox(ref argcomboBox15, promoID);
            catboxCombo8 = argcomboBox15;
        }


        BindData();

    }

    private void InitializeComboBox(ref PromoCategoryBox comboBox, int bindingIndex, int promoID)
    {
        if (dsSetup.Tables("PromoCombo").Rows(bindingIndex)("ComboFD_flag") == "F")
        {
            comboBox.FoodDrink_Flag = "F";
        }
        else if (dsSetup.Tables("PromoCombo").Rows(bindingIndex)("ComboFD_flag") == "D")
        {
            comboBox.FoodDrink_Flag = "D";
        }

        comboBox.PositionIndex = bindingIndex;
        comboBox.PromoID = promoID;
        comboBox.PrimaryTable = dsSetup.Tables("PromoCombo");
        comboBox.SupportingTable = dsSetup.Tables("PromoCombo");
        comboBox.PrimaryColumn = "Combo";
        comboBox.InitializeUserControl();

    }

    private void InitializeEmptyComboBox(ref PromoCategoryBox comboBox, int promoID)
    {

        comboBox.PositionIndex = -1;
        comboBox.FoodDrink_Flag = "F";
        comboBox.PromoID = promoID;
        comboBox.PrimaryTable = dsSetup.Tables("PromoCombo");
        comboBox.SupportingTable = dsSetup.Tables("PromoCombo");
        comboBox.PrimaryColumn = "Combo";
        comboBox.NewRowFlag = true;
        comboBox.InitializeUserControl();

    }
    private void BindData()
    {

        return;

        // *******************************
        // we need to add this back
        // ********************************

        txtComboPrice.DataBindings.Add("Text", dsSetup.Tables("PromoComboDetail"), "ComboPrice");

    }

}