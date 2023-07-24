using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;


public partial class UpdateButtons222 : System.Windows.Forms.UserControl
{

    private int _activeButton;
    private string _activeText;
    private string _activeAbrevText;
    private int _activeFunction;


    public int ActiveButton
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

    public string ActiveText
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

    public string ActiveAbrevText
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

    public int ActiveFunction
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


    #region  Windows Form Designer generated code 

    public UpdateButtons222() : base()
    {

        // This call is required by the Windows Form Designer.
        InitializeComponent();

        // Add any initialization after the InitializeComponent() call

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
    private Global.System.Windows.Forms.Button _btnUpdate;

    internal virtual Global.System.Windows.Forms.Button btnUpdate
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnUpdate;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_btnUpdate != null)
            {
                _btnUpdate.Click -= btnUpdate_Click222;
            }

            _btnUpdate = value;
            if (_btnUpdate != null)
            {
                _btnUpdate.Click += btnUpdate_Click222;
            }
        }
    }
    private Global.System.Windows.Forms.Button _btnRemove;

    internal virtual Global.System.Windows.Forms.Button btnRemove
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _btnRemove;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _btnRemove = value;
        }
    }
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        _btnUpdate = new System.Windows.Forms.Button();
        _btnUpdate.Click += btnUpdate_Click222;
        _btnRemove = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // btnUpdate
        // 
        _btnUpdate.BackColor = System.Drawing.SystemColors.Desktop;
        _btnUpdate.Location = new System.Drawing.Point(16, 8);
        _btnUpdate.Name = "_btnUpdate";
        _btnUpdate.Size = new System.Drawing.Size(160, 32);
        _btnUpdate.TabIndex = 0;
        _btnUpdate.Text = "Update";
        // 
        // btnRemove
        // 
        _btnRemove.BackColor = System.Drawing.SystemColors.Desktop;
        _btnRemove.Location = new System.Drawing.Point(16, 56);
        _btnRemove.Name = "_btnRemove";
        _btnRemove.Size = new System.Drawing.Size(160, 32);
        _btnRemove.TabIndex = 1;
        _btnRemove.Text = "Remove";
        // 
        // UpdateButtons
        // 
        this.BackColor = System.Drawing.SystemColors.Control;
        this.Controls.Add(_btnRemove);
        this.Controls.Add(_btnUpdate);
        this.Name = "UpdateButtons";
        this.Size = new System.Drawing.Size(192, 96);
        this.ResumeLayout(false);

    }

    #endregion


    private void btnUpdate_Click222(object sender, EventArgs e)
    {
        // Dim sm As SetupMenu

        if (_activeButton == 0)
            Interaction.MsgBox("You must first select a Button to update");
        if (_activeFunction == 0)
            Interaction.MsgBox("You must select a Function");

        var adt = new SqlClient.SqlDataAdapter("SELECT CategoryID, CategoryName, CategoryAbrev, CategoryOrder, FunctionID From Category", sql.cn);
        var cbd = new SqlClient.SqlCommandBuilder(adt);
        DataRow oRow;

        // if test is successful then row is update then sub exited
        // if failed then new row is created
        foreach (DataRow currentORow in dsSetup.Tables("MainCategory").Rows)
        {
            oRow = currentORow;
            if (oRow("CategoryID") == _activeButton)
            {

                oRow("CategoryName") = _activeText;
                oRow("CategoryAbrev") = _activeAbrevText;
                oRow("FunctionID") = _activeFunction;

                sql.cn.Open();
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
                adt.Update(dsSetup, "MainCategory");
                sql.cn.Close();
                // SetupMenu.DisplayMainCategoryPanel()

                return;
            }
        }

        oRow = dsSetup.Tables("MainCategory").NewRow;

        oRow("CategoryName") = _activeText;
        oRow("CategoryAbrev") = _activeAbrevText;
        oRow("FunctionID") = _activeFunction;

        dsSetup.Tables("MainCategory").Rows.Add(oRow);

        sql.cn.Open();
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
        adt.Update(dsSetup, "MainCategory");
        sql.cn.Close();

    }

}