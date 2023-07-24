using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public partial class Tab_Category : System.Windows.Forms.Form
{

    private OrderButton[] btnMain;


    #region  Windows Form Designer generated code 

    public Tab_Category() : base()
    {

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
    private Global.System.Windows.Forms.Button _Button2;

    internal virtual Global.System.Windows.Forms.Button Button2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Button2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Button2 = value;
        }
    }
    private Global.System.Windows.Forms.Button _Add_Main_Category;

    internal virtual Global.System.Windows.Forms.Button Add_Main_Category
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _Add_Main_Category;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_Add_Main_Category != null)
            {
                _Add_Main_Category.Click -= Add_Main_Category_Click;
            }

            _Add_Main_Category = value;
            if (_Add_Main_Category != null)
            {
                _Add_Main_Category.Click += Add_Main_Category_Click;
            }
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
            if (_MainCategoryPanel != null)
            {
                _MainCategoryPanel.Click -= UpdateCategory;
            }

            _MainCategoryPanel = value;
            if (_MainCategoryPanel != null)
            {
                _MainCategoryPanel.Click += UpdateCategory;
            }
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
    private Global.System.Windows.Forms.Label _lblCategoryFunction;

    internal virtual Global.System.Windows.Forms.Label lblCategoryFunction
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblCategoryFunction;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lblCategoryFunction = value;
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
    private Global.System.Windows.Forms.Button _btnUpdateCategory;

    internal virtual Global.System.Windows.Forms.Button btnUpdateCategory
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnUpdateCategory;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnUpdateCategory != null)
            {
                _btnUpdateCategory.Click -= btnUpdateCategory_Click;
            }

            _btnUpdateCategory = value;
            if (_btnUpdateCategory != null)
            {
                _btnUpdateCategory.Click += btnUpdateCategory_Click;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnRemoveCategory;

    internal virtual Global.System.Windows.Forms.Button btnRemoveCategory
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnRemoveCategory;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnRemoveCategory = value;
        }
    }
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        _Add_Main_Category = new System.Windows.Forms.Button();
        _Add_Main_Category.Click += Add_Main_Category_Click;
        _Button2 = new System.Windows.Forms.Button();
        _MainCategoryPanel = new System.Windows.Forms.Panel();
        _MainCategoryPanel.Click += UpdateCategory;
        _btnUpdateCategory = new System.Windows.Forms.Button();
        _btnUpdateCategory.Click += btnUpdateCategory_Click;
        _btnRemoveCategory = new System.Windows.Forms.Button();
        _txtNewCategoryName = new System.Windows.Forms.TextBox();
        _cbxCategoryFunction = new System.Windows.Forms.ComboBox();
        _txtNewCategoryAbrev = new System.Windows.Forms.TextBox();
        _lblCategoryName = new System.Windows.Forms.Label();
        _lblCategoryAbrev = new System.Windows.Forms.Label();
        _lblCategoryFunction = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // Add_Main_Category
        // 
        _Add_Main_Category.BackColor = System.Drawing.SystemColors.ActiveBorder;
        _Add_Main_Category.Location = new System.Drawing.Point(8, 8);
        _Add_Main_Category.Name = "_Add_Main_Category";
        _Add_Main_Category.Size = new System.Drawing.Size(200, 32);
        _Add_Main_Category.TabIndex = 0;
        _Add_Main_Category.Text = "Add Main Category";
        // 
        // Button2
        // 
        _Button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
        _Button2.Location = new System.Drawing.Point(8, 48);
        _Button2.Name = "_Button2";
        _Button2.Size = new System.Drawing.Size(200, 32);
        _Button2.TabIndex = 1;
        _Button2.Text = "Add Secondary Category";
        // 
        // MainCategoryPanel
        // 
        _MainCategoryPanel.BackColor = System.Drawing.Color.White;
        _MainCategoryPanel.Location = new System.Drawing.Point(360, 104);
        _MainCategoryPanel.Name = "_MainCategoryPanel";
        _MainCategoryPanel.Size = new System.Drawing.Size(160, 184);
        _MainCategoryPanel.TabIndex = 2;
        // 
        // btnUpdateCategory
        // 
        _btnUpdateCategory.BackColor = System.Drawing.SystemColors.ActiveBorder;
        _btnUpdateCategory.Location = new System.Drawing.Point(88, 384);
        _btnUpdateCategory.Name = "_btnUpdateCategory";
        _btnUpdateCategory.Size = new System.Drawing.Size(200, 32);
        _btnUpdateCategory.TabIndex = 3;
        _btnUpdateCategory.Text = "Update Category";
        // 
        // btnRemoveCategory
        // 
        _btnRemoveCategory.BackColor = System.Drawing.SystemColors.ActiveBorder;
        _btnRemoveCategory.Location = new System.Drawing.Point(88, 432);
        _btnRemoveCategory.Name = "_btnRemoveCategory";
        _btnRemoveCategory.Size = new System.Drawing.Size(200, 32);
        _btnRemoveCategory.TabIndex = 4;
        _btnRemoveCategory.Text = "Remove Category";
        // 
        // txtNewCategoryName
        // 
        _txtNewCategoryName.Location = new System.Drawing.Point(88, 136);
        _txtNewCategoryName.Name = "_txtNewCategoryName";
        _txtNewCategoryName.Size = new System.Drawing.Size(208, 20);
        _txtNewCategoryName.TabIndex = 5;
        _txtNewCategoryName.Text = "TextBox1";
        // 
        // cbxCategoryFunction
        // 
        _cbxCategoryFunction.Location = new System.Drawing.Point(88, 264);
        _cbxCategoryFunction.Name = "_cbxCategoryFunction";
        _cbxCategoryFunction.Size = new System.Drawing.Size(208, 21);
        _cbxCategoryFunction.TabIndex = 6;
        _cbxCategoryFunction.Text = "ComboBox1";
        // 
        // txtNewCategoryAbrev
        // 
        _txtNewCategoryAbrev.Location = new System.Drawing.Point(88, 192);
        _txtNewCategoryAbrev.Name = "_txtNewCategoryAbrev";
        _txtNewCategoryAbrev.Size = new System.Drawing.Size(208, 20);
        _txtNewCategoryAbrev.TabIndex = 7;
        _txtNewCategoryAbrev.Text = "TextBox2";
        // 
        // lblCategoryName
        // 
        _lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblCategoryName.Location = new System.Drawing.Point(88, 112);
        _lblCategoryName.Name = "_lblCategoryName";
        _lblCategoryName.Size = new System.Drawing.Size(208, 16);
        _lblCategoryName.TabIndex = 8;
        _lblCategoryName.Text = "Category Name";
        // 
        // lblCategoryAbrev
        // 
        _lblCategoryAbrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblCategoryAbrev.Location = new System.Drawing.Point(88, 168);
        _lblCategoryAbrev.Name = "_lblCategoryAbrev";
        _lblCategoryAbrev.Size = new System.Drawing.Size(216, 16);
        _lblCategoryAbrev.TabIndex = 9;
        _lblCategoryAbrev.Text = "Category Abreviation";
        // 
        // lblCategoryFunction
        // 
        _lblCategoryFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
        _lblCategoryFunction.Location = new System.Drawing.Point(88, 232);
        _lblCategoryFunction.Name = "_lblCategoryFunction";
        _lblCategoryFunction.Size = new System.Drawing.Size(200, 24);
        _lblCategoryFunction.TabIndex = 10;
        _lblCategoryFunction.Text = "Category Function";
        // 
        // Tab_Category
        // 
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
        this.ClientSize = new System.Drawing.Size(792, 573);
        this.ControlBox = false;
        this.Controls.Add(_lblCategoryFunction);
        this.Controls.Add(_lblCategoryAbrev);
        this.Controls.Add(_lblCategoryName);
        this.Controls.Add(_txtNewCategoryAbrev);
        this.Controls.Add(_cbxCategoryFunction);
        this.Controls.Add(_txtNewCategoryName);
        this.Controls.Add(_btnRemoveCategory);
        this.Controls.Add(_btnUpdateCategory);
        this.Controls.Add(_MainCategoryPanel);
        this.Controls.Add(_Button2);
        this.Controls.Add(_Add_Main_Category);
        this.Name = "Tab_Category";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Tab_Category";
        this.ResumeLayout(false);

    }

    #endregion


    private void InitializeOther()
    {

        GenerateCategoryDataSets();

        BindData();

        DisplayMainCategoryPanel();


    }



    private void GenerateCategoryDataSets()
    {

        string sqlStatement;
        string tableCreating;
        string bindingColumn;

        numberOfMainCategories = GetButtonCount("Main");
        numberOfDrinkCategories = GetButtonCount("Drink");
        numberOfModifierCategories = GetButtonCount("Modifier");
        numberOfCategories = numberOfMainCategories + numberOfDrinkCategories + numberOfModifierCategories;
        maximumCategories = GetCategoryMaximum();

        bindingColumn = "CategoryAbrev";
        tableCreating = "MainCategory";
        sqlStatement = "SELECT CategoryID, CategoryName, CategoryAbrev, CategoryOrder, FunctionID FROM Category WHERE FunctionID = 1 OR FunctionID = 2";     // Panel = 'Main'"
        ds = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, ds);

        bindingColumn = "CategoryName";
        tableCreating = "ModifierCategory";
        sqlStatement = "SELECT CategoryID, CategoryName, CategoryAbrev, CategoryOrder, FunctionID FROM Category WHERE FunctionID > 2";   // Panel = 'Modifier'"
        ds = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, ds);

        bindingColumn = "CategoryName";
        tableCreating = "Functions";
        sqlStatement = "SELECT FunctionID, FunctionName FROM Functions";
        ds = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, ds);



    }

    private void BindData()
    {

        cbxCategoryFunction.DataSource = ds.Tables("Functions");
        cbxCategoryFunction.DisplayMember = "FunctionName";


    }

    private void DisplayMainCategoryPanel()
    {

        // readjust size of panel
        if (numberOfMainCategories == 0)
        {
            // MainCategoryPanel.Size = New Size(ssX * 0.1, ssY * 0.2)


        }
        // at this point keeping the same
        MainCategoryPanel.Size = new System.Drawing.Size(160, 184);
        int btnWidth = 150;
        int btnheight = 40;





        btnMain = new OrderButton[numberOfMainCategories + numberOfDrinkCategories + numberOfModifierCategories + 1];
        int index;
        int x = buttonSpace;
        int y = buttonSpace;

        var loopTo = numberOfMainCategories + numberOfDrinkCategories;
        for (index = 0; index <= loopTo; index++)
        {
            btnMain[index] = new OrderButton();
            {
                ref var withBlock = ref btnMain[index];
                withBlock.Size = new Size(btnWidth, btnheight);
                withBlock.Location = new Point(x, y);
                try
                {
                    withBlock.ID = dtMainCategory.Rows(index)("CategoryID");
                    withBlock.Name = dtMainCategory.Rows(index)("CategoryName");
                    withBlock.Text = dtMainCategory.Rows(index)("CategoryAbrev");
                }
                catch
                {
                    withBlock.Text = "";
                }
                withBlock.BackColor = Color.AliceBlue;
                MainCategoryPanel.Controls.Add(btnMain[index]);

                this.btnMain[index].Click += UpdateCategory;

            }
            y = y + btnheight + buttonSpace;

        }



    }

    private void UpdateCategory(object sender, EventArgs e)
    {

        try
        {
            OrderButton objButton = (OrderButton)sender;

            txtNewCategoryName.Text = objButton.Name;
            txtNewCategoryAbrev.Text = objButton.Text;
        }
        catch
        {
            return;
        }



    }



    private void Add_Main_Category_Click(object sender, EventArgs e)
    {

        // determine how many main categories

        // determine the size of the panel


        // determine the size of the button


        // determine the size of the button space

        // determine the location of the next button


    }



    private void btnUpdateCategory_Click(object sender, EventArgs e)
    {



    }


}