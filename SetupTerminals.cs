using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using DataSet_Builder;


public partial class SetupTerminals : System.Windows.Forms.UserControl
{

    public int currentFloorPlanID;
    private bool changedTable;
    private bool changedTerminal;
    // Dim changedTable As Boolean
    private Label lblWall;
    private Label lblTerminal;
    private Label lblTableSquare;

    private WallInfo_UC _currentWallInfo;

    private WallInfo_UC currentWallInfo
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _currentWallInfo;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_currentWallInfo != null)
            {
                _currentWallInfo.NewWallAccepted -= NewWallAcceptedFrom_UC;
                _currentWallInfo.UpdateOldWall -= WallUpdatesAccepted;
                _currentWallInfo.WallCancel -= WallUpdatesCanceled;
            }

            _currentWallInfo = value;
            if (_currentWallInfo != null)
            {
                _currentWallInfo.NewWallAccepted += NewWallAcceptedFrom_UC;
                _currentWallInfo.UpdateOldWall += WallUpdatesAccepted;
                _currentWallInfo.WallCancel += WallUpdatesCanceled;
            }
        }
    }
    private TerminalInfo_UC _currentTermInfo;

    private TerminalInfo_UC currentTermInfo
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _currentTermInfo;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_currentTermInfo != null)
            {
                _currentTermInfo.NewTerminalAccepted -= NewTerminalAcceptedFrom_UC;
                _currentTermInfo.NewUseOrderRow -= NewTerminalUseOrder_UC;
                _currentTermInfo.UpdateOldTerminal -= TerminalUpdatesAccepted;
                _currentTermInfo.TerminalCancel -= TerminalUpdatesCanceled;
            }

            _currentTermInfo = value;
            if (_currentTermInfo != null)
            {
                _currentTermInfo.NewTerminalAccepted += NewTerminalAcceptedFrom_UC;
                _currentTermInfo.NewUseOrderRow += NewTerminalUseOrder_UC;
                _currentTermInfo.UpdateOldTerminal += TerminalUpdatesAccepted;
                _currentTermInfo.TerminalCancel += TerminalUpdatesCanceled;
            }
        }
    }
    private TableInfo_UC _currentTableInfo;

    private TableInfo_UC currentTableInfo
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _currentTableInfo;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_currentTableInfo != null)
            {
                _currentTableInfo.NewTableAccepted -= NewTableAcceptedFrom_UC;
                _currentTableInfo.UpdateOldTable -= TableUpdatesAccepted;
                _currentTableInfo.TableCancel -= TableUpdatesCanceled;
            }

            _currentTableInfo = value;
            if (_currentTableInfo != null)
            {
                _currentTableInfo.NewTableAccepted += NewTableAcceptedFrom_UC;
                _currentTableInfo.UpdateOldTable += TableUpdatesAccepted;
                _currentTableInfo.TableCancel += TableUpdatesCanceled;
            }
        }
    }
    private TerminalGroup_UC _terminalGroupPanel;

    private TerminalGroup_UC terminalGroupPanel
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _terminalGroupPanel;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _terminalGroupPanel = value;
        }
    }
    private Terminal_UC[] terminalPanel = new Terminal_UC[201];
    private int numberOfTerms = 200;
    private int i = 9;

    private int FloorPlanFirst;
    private int FloorPlanSecond;


    #region  Windows Form Designer generated code 

    public SetupTerminals() : base()
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
            if (_TabControl1 != null)
            {
                _TabControl1.Click -= ChangeFloorPlan;
            }

            _TabControl1 = value;
            if (_TabControl1 != null)
            {
                _TabControl1.Click += ChangeFloorPlan;
            }
        }
    }
    private Global.System.Windows.Forms.TabPage _FloorPlan1;

    internal virtual Global.System.Windows.Forms.TabPage FloorPlan1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _FloorPlan1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_FloorPlan1 != null)
            {
                _FloorPlan1.Leave -= tabFllorPlan1_Leave;
            }

            _FloorPlan1 = value;
            if (_FloorPlan1 != null)
            {
                _FloorPlan1.Leave += tabFllorPlan1_Leave;
            }
        }
    }
    private Global.System.Windows.Forms.TabPage _FloorPlan2;

    internal virtual Global.System.Windows.Forms.TabPage FloorPlan2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _FloorPlan2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_FloorPlan2 != null)
            {
                _FloorPlan2.Leave -= tabFllorPlan2_Leave;
            }

            _FloorPlan2 = value;
            if (_FloorPlan2 != null)
            {
                _FloorPlan2.Leave += tabFllorPlan2_Leave;
            }
        }
    }
    private Global.System.Windows.Forms.Panel _pnlFloorPlan1;

    internal virtual Global.System.Windows.Forms.Panel pnlFloorPlan1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlFloorPlan1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlFloorPlan1 = value;
        }
    }
    private Global.System.Windows.Forms.Panel _pnlFloorPlan2;

    internal virtual Global.System.Windows.Forms.Panel pnlFloorPlan2
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _pnlFloorPlan2;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pnlFloorPlan2 = value;
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
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        _TabControl1 = new System.Windows.Forms.TabControl();
        _TabControl1.Click += ChangeFloorPlan;
        _FloorPlan1 = new System.Windows.Forms.TabPage();
        _FloorPlan1.Leave += tabFllorPlan1_Leave;
        _Panel1 = new System.Windows.Forms.Panel();
        _pnlFloorPlan1 = new System.Windows.Forms.Panel();
        _FloorPlan2 = new System.Windows.Forms.TabPage();
        _FloorPlan2.Leave += tabFllorPlan2_Leave;
        _Panel2 = new System.Windows.Forms.Panel();
        _pnlFloorPlan2 = new System.Windows.Forms.Panel();
        _TabControl1.SuspendLayout();
        _FloorPlan1.SuspendLayout();
        _Panel1.SuspendLayout();
        _FloorPlan2.SuspendLayout();
        _Panel2.SuspendLayout();
        this.SuspendLayout();
        // 
        // TabControl1
        // 
        _TabControl1.Controls.Add(_FloorPlan1);
        _TabControl1.Controls.Add(_FloorPlan2);
        _TabControl1.Location = new System.Drawing.Point(24, 140);
        _TabControl1.Name = "_TabControl1";
        _TabControl1.SelectedIndex = 0;
        _TabControl1.Size = new System.Drawing.Size(744, 544);
        _TabControl1.TabIndex = 0;
        // 
        // FloorPlan1
        // 
        _FloorPlan1.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _FloorPlan1.Controls.Add(_Panel1);
        _FloorPlan1.Location = new System.Drawing.Point(4, 22);
        _FloorPlan1.Name = "_FloorPlan1";
        _FloorPlan1.Size = new System.Drawing.Size(736, 518);
        _FloorPlan1.TabIndex = 0;
        _FloorPlan1.Text = "Floor Plan 1";
        // 
        // Panel1
        // 
        _Panel1.BackColor = System.Drawing.Color.DarkBlue;
        _Panel1.Controls.Add(_pnlFloorPlan1);
        _Panel1.Location = new System.Drawing.Point(80, 88);
        _Panel1.Name = "_Panel1";
        _Panel1.Size = new System.Drawing.Size(504, 336);
        _Panel1.TabIndex = 1;
        // 
        // pnlFloorPlan1
        // 
        _pnlFloorPlan1.BackColor = System.Drawing.Color.Black;
        _pnlFloorPlan1.Location = new System.Drawing.Point(8, 8);
        _pnlFloorPlan1.Name = "_pnlFloorPlan1";
        _pnlFloorPlan1.Size = new System.Drawing.Size(488, 320);
        _pnlFloorPlan1.TabIndex = 0;
        // 
        // FloorPlan2
        // 
        _FloorPlan2.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        _FloorPlan2.Controls.Add(_Panel2);
        _FloorPlan2.Location = new System.Drawing.Point(4, 22);
        _FloorPlan2.Name = "_FloorPlan2";
        _FloorPlan2.Size = new System.Drawing.Size(736, 518);
        _FloorPlan2.TabIndex = 1;
        _FloorPlan2.Text = "Floor Plan 2";
        // 
        // Panel2
        // 
        _Panel2.BackColor = System.Drawing.Color.DarkBlue;
        _Panel2.Controls.Add(_pnlFloorPlan2);
        _Panel2.Location = new System.Drawing.Point(104, 80);
        _Panel2.Name = "_Panel2";
        _Panel2.Size = new System.Drawing.Size(544, 344);
        _Panel2.TabIndex = 2;
        // 
        // pnlFloorPlan2
        // 
        _pnlFloorPlan2.BackColor = System.Drawing.Color.Black;
        _pnlFloorPlan2.Location = new System.Drawing.Point(8, 8);
        _pnlFloorPlan2.Name = "_pnlFloorPlan2";
        _pnlFloorPlan2.Size = new System.Drawing.Size(528, 328);
        _pnlFloorPlan2.TabIndex = 0;
        // 
        // SetupTerminals
        // 
        this.BackColor = System.Drawing.Color.FromArgb(0, 78, 152);
        this.Controls.Add(_TabControl1);
        this.Name = "SetupTerminals";
        this.Size = new System.Drawing.Size(792, 696);
        _TabControl1.ResumeLayout(false);
        _FloorPlan1.ResumeLayout(false);
        _Panel1.ResumeLayout(false);
        _FloorPlan2.ResumeLayout(false);
        _Panel2.ResumeLayout(false);
        this.ResumeLayout(false);

    }




    #endregion

    private void InitializeOther()
    {

        PopulateTerminalData();

        PopulateFloorPlanData();

        DisplayPermanentUserControls();

        DisplayWalls();

        DisplayTables();

        DisplayTerminals();

    }

    private void PopulateFloorPlanData()
    {
        int fpCount = 1;

        pnlFloorPlan1.Controls.Clear();
        pnlFloorPlan2.Controls.Clear();

        foreach (DataRow fpRow in dsSetup.Tables("TermsFloor").Rows)
        {
            switch (fpCount)
            {
                case 1:
                    {
                        FloorPlan1.Text = fpRow("FloorPlanName") + "   ";
                        FloorPlanFirst = fpRow("FloorPlanID");
                        Panel1.Size = new Size(fpRow("meWidth"), fpRow("meHeight"));
                        Panel1.Location = new Point((FloorPlan1.Width - fpRow("meWidth")) / 2, (FloorPlan1.Height - fpRow("meHeight")) / 2);
                        pnlFloorPlan1.Size = new Size(fpRow("meWidth") - 16, fpRow("meHeight") - 16);
                        pnlFloorPlan1.Location = new Point(8, 8);
                        currentFloorPlanID = fpRow("FloorPlanID");
                        break;
                    }
                case 2:
                    {
                        FloorPlan2.Text = fpRow("FloorPlanName") + "   ";
                        FloorPlanSecond = fpRow("FloorPlanID");
                        Panel2.Size = new Size(fpRow("meWidth"), fpRow("meHeight"));
                        Panel2.Location = new Point((FloorPlan2.Width - fpRow("meWidth")) / 2, (FloorPlan2.Height - fpRow("meHeight")) / 2);
                        pnlFloorPlan2.Size = new Size(fpRow("meWidth") - 16, fpRow("meHeight") - 16);
                        pnlFloorPlan2.Location = new Point(8, 8);
                        break;
                    }
            }

            fpCount += 1;
        }

    }

    private void PopulateTerminalData()
    {

        dsSetup.Tables("TermGroups").Clear();
        dsSetup.Tables("Terminals").Clear();
        dsSetup.Tables("TerminalsUseOrder").Clear();

        dsSetup.Tables("TermsFloor").Clear();
        dsSetup.Tables("TermsTables").Clear();
        dsSetup.Tables("TermsWalls").Clear();

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlSelectCommandTermGroups.Parameters("@LocationID").Value = corpPhysicalLocation;
            sql.SqlSelectCommandTerms.Parameters("@LocationID").Value = corpPhysicalLocation;
            sql.SqlSelectCommandTermsUse.Parameters("@LocationID").Value = corpPhysicalLocation;

            sql.SqlSelectCommandTermsFloor.Parameters("@LocationID").Value = corpPhysicalLocation;
            sql.SqlSelectCommandTermsTables.Parameters("@LocationID").Value = corpPhysicalLocation;
            sql.SqlSelectCommandTermsWalls.Parameters("@LocationID").Value = corpPhysicalLocation;

            sql.SqlTermGroups.Fill(dsSetup.Tables("TermGroups"));
            sql.SqlTerms.Fill(dsSetup.Tables("Terminals"));
            sql.SqlTermsUse.Fill(dsSetup.Tables("TerminalsUseOrder"));

            sql.SqlTermsFloor.Fill(dsSetup.Tables("TermsFloor"));
            sql.SqlTermsTables.Fill(dsSetup.Tables("TermsTables"));
            sql.SqlTermsWalls.Fill(dsSetup.Tables("TermsWalls"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);
            CloseConnection();
        }

        TestArray();

    }

    private void TestArray()
    {
        int terminalCount;

        terminalCount = dsSetup.Tables("Terminals").Rows.Count + dsSetup.Tables("TermsTables").Rows.Count + dsSetup.Tables("TermsWalls").Rows.Count + 10;

        if (terminalCount > numberOfTerms)
        {
            numberOfTerms = terminalCount + 200;
            try
            {
                // place in try b/c if we start too low we can't dispose of these not yet created panels
                terminalPanel[0].Dispose();
                terminalPanel[1].Dispose();
                terminalPanel[2].Dispose();
            }
            catch (Exception ex)
            {

            }
            terminalPanel = new Terminal_UC[numberOfTerms + 1];
            i = 9;

            PopulateFloorPlanData();
            DisplayPermanentUserControls();
            DisplayWalls();
            DisplayTables();
            DisplayTerminals();
        }

    }

    private void DisplayPermanentUserControls()
    {

        lblWall = new Label();
        lblWall.Location = new System.Drawing.Point(250, 64);
        lblWall.Size = new Size(60, 20);
        lblWall.Text = "Wall";
        lblWall.ForeColor = Color.White;
        lblWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);

        lblTerminal = new Label();
        lblTerminal.Location = new System.Drawing.Point(84, 64);
        lblTerminal.Size = new Size(60, 20);
        lblTerminal.Text = "Terminal";
        lblTerminal.ForeColor = Color.White;
        lblTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);

        lblTableSquare = new Label();
        lblTableSquare.Location = new System.Drawing.Point(176, 64);
        lblTableSquare.Size = new Size(60, 20);
        lblTableSquare.Text = "Table";
        lblTableSquare.ForeColor = Color.White;
        lblTableSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);

        terminalPanel[0] = new Terminal_UC("Terminal", 0, 96, 24, 30, 30, 0, 0, true);
        terminalPanel[0].Location = new System.Drawing.Point(96, 84);
        terminalPanel[0].Size = new System.Drawing.Size(30, 30);
        terminalPanel[0].BackColor = Color.IndianRed;
        terminalPanel[0].ForeColor = Color.White;
        // terminalPanel(0).AssignSizeValues()
        this.terminalPanel[0].TerminalNewInfoNeeded += TerminalBeingAdded;
        this.terminalPanel[0].TerminalMoved += TerminalMoved_Mouse;
        this.terminalPanel[0].TerminalInfoReview += TerminalBeingReviewed;

        terminalPanel[1] = new Terminal_UC("Table", 0, 176, 24, 40, 40, 0, 0, true);
        terminalPanel[1].Location = new System.Drawing.Point(176, 84);
        terminalPanel[1].Size = new System.Drawing.Size(40, 40);
        terminalPanel[1].BackColor = Color.DarkBlue;
        terminalPanel[1].ForeColor = Color.White;
        terminalPanel[1].AssignSizeValues();
        this.terminalPanel[1].TableNewInfoNeeded += TableBeingAdded;
        this.terminalPanel[1].TableMoved += TableMoved_Mouse;
        this.terminalPanel[1].TableInfoReview += TableBeingReviewed;

        terminalPanel[2] = new Terminal_UC("Wall", 0, 250, 24, 150, 20, 0, 0, true);
        terminalPanel[2].Location = new System.Drawing.Point(250, 84);
        terminalPanel[2].Size = new System.Drawing.Size(150, 20);
        terminalPanel[2].BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
        terminalPanel[2].ForeColor = Color.White;
        terminalPanel[2].AssignSizeValues();
        this.terminalPanel[2].WallNewInfoNeeded += WallBeingAdded;
        this.terminalPanel[2].WallMoved += WallMoved_Mouse;
        this.terminalPanel[2].WallInfoReview += WallBeingReviewed;

        this.Controls.Add(lblTerminal);
        this.Controls.Add(lblTableSquare);
        this.Controls.Add(lblWall);
        this.Controls.Add(terminalPanel[0]);
        this.Controls.Add(terminalPanel[1]);
        this.Controls.Add(terminalPanel[2]);


    }

    private void DisplayWalls()
    {

        foreach (DataRow oRow in dsSetup.Tables("TermsWalls").Rows)
        {
            DisplayEachWall(ref oRow, i);
            i += 1;
        }

    }

    private void DisplayTables()
    {

        foreach (DataRow oRow in dsSetup.Tables("TermsTables").Rows)
        {
            DisplayEachTable(ref oRow, i);
            i += 1;
        }

    }

    private void DisplayEachWall(ref DataRow oRow, int i)
    {

        terminalPanel[i] = new Terminal_UC("Wall", i, oRow("xLoc"), oRow("yLoc"), oRow("myWidth"), oRow("myHeight"), i, oRow("FloorPlanID"), oRow("Active"));
        terminalPanel[i].Size = new System.Drawing.Size(oRow("myWidth"), oRow("myHeight"));
        terminalPanel[i].AssignSizeValues();

        terminalPanel[i].tempWall.FloorPlanID = oRow("FloorPlanID");
        terminalPanel[i].tempWall.IsRound = false;

        this.terminalPanel[i].WallNewInfoNeeded += WallBeingAdded;
        this.terminalPanel[i].WallMoved += WallMoved_Mouse;
        this.terminalPanel[i].WallInfoReview += WallBeingReviewed;

        switch (oRow("FloorPlanID"))
        {
            case var @case when @case == FloorPlanFirst:
                {

                    pnlFloorPlan1.Controls.Add(terminalPanel[i]);
                    break;
                }
            case var case1 when case1 == FloorPlanSecond:
                {
                    pnlFloorPlan2.Controls.Add(terminalPanel[i]);
                    break;
                }

        }
    }

    private void DisplayEachTable(ref DataRow oRow, int i)
    {

        terminalPanel[i] = new Terminal_UC("Table", i, oRow("xLoc"), oRow("yLoc"), oRow("myWidth"), oRow("myHeight"), oRow("TableNumber"), oRow("FloorPlanID"), true); // (true for active table deleted from sql) oRow("Active"))
        terminalPanel[i].Size = new System.Drawing.Size(oRow("myWidth"), oRow("myHeight"));
        terminalPanel[i].AssignSizeValues();

        {
            var withBlock = terminalPanel[i].tempTable;
            withBlock.PhysicalTableNumber = oRow("TableNumber");
            withBlock.FloorPlanID = oRow("FloorPlanID");
            withBlock.Seats = oRow("Seats");
            withBlock.Available = oRow("Available");
            withBlock.IsRound = oRow("isRound");
            // .Active = orow("Active")   'not sure if using

        }

        this.terminalPanel[i].TableNewInfoNeeded += TableBeingAdded;
        this.terminalPanel[i].TableMoved += TableMoved_Mouse;
        this.terminalPanel[i].TableInfoReview += TableBeingReviewed;


        switch (oRow("FloorPlanID"))
        {
            case var @case when @case == FloorPlanFirst:
                {

                    pnlFloorPlan1.Controls.Add(terminalPanel[i]);
                    break;
                }
            case var case1 when case1 == FloorPlanSecond:
                {
                    pnlFloorPlan2.Controls.Add(terminalPanel[i]);
                    break;
                }

        }

    }

    private void DisplayTerminals()
    {

        foreach (DataRow oRow in dsSetup.Tables("terminals").Rows)
        {
            DisplayEachTerminal(ref oRow, i);
            i += 1;
        }

    }

    private void DisplayEachTerminal(ref DataRow oRow, int i)
    {

        terminalPanel[i] = new Terminal_UC("Terminal", i, oRow("TermX"), oRow("TermY"), 30, 30, oRow("TerminalID"), oRow("FloorPlanID"), true);
        terminalPanel[i].Size = new System.Drawing.Size(30, 30);

        {
            var withBlock = terminalPanel[i].tempTerminal;
            withBlock.TermID = oRow("TerminalID");
            withBlock.FloorPlanID = oRow("FloorPlanID");
            withBlock.TermName = oRow("TerminalName");
            withBlock.TermMethod = oRow("TerminalMethod");
            withBlock.TermGroupID = oRow("TerminalsGroupID");
            withBlock.TermPrimaryKey = oRow("TerminalsPrimaryKey");


            if (!(oRow("TerminalsGroupID") == 0))
            {
                foreach (DataRow gRow in dsSetup.Tables("TermGroups").Rows)
                {
                    if (gRow("TerminalsGroupID") == oRow("TerminalsGroupID"))
                    {
                        withBlock.TermGroupName = gRow("TerminalsGroupName");
                    }
                }

            }

        }

        this.terminalPanel[i].TerminalNewInfoNeeded += TerminalBeingAdded;
        this.terminalPanel[i].TerminalMoved += TerminalMoved_Mouse;
        this.terminalPanel[i].TerminalInfoReview += TerminalBeingReviewed;


        switch (oRow("FloorPlanID"))
        {
            case var @case when @case == FloorPlanFirst:
                {

                    pnlFloorPlan1.Controls.Add(terminalPanel[i]);
                    break;
                }
            case var case1 when case1 == FloorPlanSecond:
                {
                    pnlFloorPlan2.Controls.Add(terminalPanel[i]);
                    break;
                }

        }

    }

    private void DisplayGroupPanels()
    {

        foreach (DataRow oRow in dsSetup.Tables("termGroups").Rows)
            DisplayEachGroupPanel(ref oRow);

    }

    private void DisplayEachGroupPanel(ref DataRow oRow)
    {

        terminalGroupPanel = new TerminalGroup_UC(oRow("GroupX"), oRow("GroupY"), oRow("GroupW"), oRow("GroupH"));
        pnlFloorPlan1.Controls.Add(terminalGroupPanel);

    }

    private void WallMoved_Mouse(int ii) // Handles WallMoved
    {

        foreach (DataRow oRow in dsSetup.Tables("TermsWalls").Rows)
        {
            if (oRow("TableNumber") == terminalPanel[ii].tempWall.IndexTableNumber)    // Term_Table_Num Then
            {
                oRow("xLoc") = terminalPanel[ii].tempWall.xLoc;
                oRow("yLoc") = terminalPanel[ii].tempWall.yLoc;
                break;
            }
        }
        changedTable = true;

    }

    private void WallBeingReviewed(int ii)
    {

        DisposeOfTerminalInfo();
        currentWallInfo = new WallInfo_UC(false, terminalPanel[ii].tempWall);
        var argcurrentWallInfo = currentWallInfo;
        DisplayWallInfo(ref argcurrentWallInfo, ii);
        currentWallInfo = argcurrentWallInfo;

    }

    private void WallBeingAdded() // ByVal i As Integer)
    {

        DisposeOfTerminalInfo();
        currentWallInfo = new WallInfo_UC(true, terminalPanel[2].tempWall);
        terminalPanel[2].tempWall.IndexTableNumber = i;
        terminalPanel[2].tempWall.FloorPlanID = currentFloorPlanID;
        var argcurrentWallInfo = currentWallInfo;
        DisplayWallInfo(ref argcurrentWallInfo, 2);
        currentWallInfo = argcurrentWallInfo;

    }

    private void TableMoved_Mouse(int ii) // Handles TerminalMoved
    {

        foreach (DataRow oRow in dsSetup.Tables("TermsTables").Rows)
        {
            if (oRow("TableNumber") == terminalPanel[ii].Term_Table_Num)
            {
                oRow("xLoc") = terminalPanel[ii].tempTable.xLoc;
                oRow("yLoc") = terminalPanel[ii].tempTable.yLoc;
                break;
            }
        }
        changedTable = true;

    }

    private void TableBeingReviewed(int ii)
    {

        DisposeOfTerminalInfo();
        currentTableInfo = new TableInfo_UC(false, terminalPanel[ii].tempTable);
        var argcurrentTableInfo = currentTableInfo;
        DisplayTableInfo(ref argcurrentTableInfo, ii);
        currentTableInfo = argcurrentTableInfo;

    }

    private void TableBeingAdded() // Handles terminalPanel.TerminalNewInfoNeeded 'ByVal i As Integer) 
    {

        DisposeOfTerminalInfo();
        currentTableInfo = new TableInfo_UC(true, terminalPanel[1].tempTable);
        terminalPanel[1].tempTable.FloorPlanID = currentFloorPlanID;
        var argcurrentTableInfo = currentTableInfo;
        DisplayTableInfo(ref argcurrentTableInfo, 1);
        currentTableInfo = argcurrentTableInfo;

    }

    private void TerminalMoved_Mouse(int ii) // Handles TerminalMoved
    {

        foreach (DataRow oRow in dsSetup.Tables("terminals").Rows)
        {
            if (oRow("TerminalID") == terminalPanel[ii].Term_Table_Num)
            {
                oRow("TermX") = terminalPanel[ii].tempTerminal.xLoc;
                oRow("TermY") = terminalPanel[ii].tempTerminal.yLoc;
                break;
            }
        }
        changedTerminal = true;

    }

    private void TerminalBeingReviewed(int ii)
    {
        DataRow oRow;

        DisposeOfTerminalInfo();
        // If terminalPanel(ii).tempTerminal.TermPrimaryKey.ToString Is DBNull.Value Then
        // MsgBox("here")
        // UpdateTerminalData()
        // changedTerminal = False
        // PopulateTerminalData()
        // End If

        currentTermInfo = new TerminalInfo_UC(false, terminalPanel[ii].tempTerminal);

        var argcurrentTermInfo = currentTermInfo;
        DisplayTermInfo(ref argcurrentTermInfo, ii);
        currentTermInfo = argcurrentTermInfo;

    }

    private void TerminalBeingAdded()    // ByVal i As Integer) 'Handles terminalPanel.TerminalNewInfoNeeded
    {

        DisposeOfTerminalInfo();
        currentTermInfo = new TerminalInfo_UC(true, terminalPanel[0].tempTerminal);
        terminalPanel[0].tempTerminal.FloorPlanID = currentFloorPlanID;

        var argcurrentTermInfo = currentTermInfo;
        DisplayTermInfo(ref argcurrentTermInfo, 0);
        currentTermInfo = argcurrentTermInfo;

    }

    private void DisposeOfTerminalInfo()
    {

        try
        {
            if (currentTermInfo is not null)
            {
                currentTermInfo.Dispose();
            }
            if (currentTableInfo is not null)
            {
                currentTableInfo.Dispose();
            }
            if (currentWallInfo is not null)
            {
                currentWallInfo.Dispose();
            }
        }
        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);
        }

    }

    private void NewWallAcceptedFrom_UC()
    {

        TestArray();

        DataRow oRow;

        oRow = dsSetup.Tables("TermsWalls").NewRow;
        oRow("CompanyID") = corpID;
        oRow("LocationID") = corpPhysicalLocation;
        oRow("TableNumber") = i;
        oRow("FloorPlanID") = currentWallInfo.CurrentWall.FloorPlanID;
        oRow("isTable") = 0;
        oRow("isWall") = 1;
        oRow("isOther") = 0;
        oRow("isRound") = 0;
        oRow("xLoc") = currentWallInfo.CurrentWall.xLoc;
        oRow("yLoc") = currentWallInfo.CurrentWall.yLoc;
        oRow("myWidth") = currentWallInfo.CurrentWall.myWidth;
        oRow("myHeight") = currentWallInfo.CurrentWall.myHeight;
        oRow("Active") = 1;  // currentWallInfo.CurrentWall.Active

        dsSetup.Tables("TermsWalls").Rows.Add(oRow);

        currentWallInfo.Dispose();
        changedTable = true;
        DisplayEachWall(ref oRow, i);
        i += 1;

    }

    private void NewTableAcceptedFrom_UC()
    {

        DataRow oRow;

        // do a check to verify table number is not duplicated
        foreach (DataRow currentORow in dsSetup.Tables("TermsTables").Rows)
        {
            oRow = currentORow;
            if (oRow("TableNumber") == currentTableInfo.CurrentTable.PhysicalTableNumber)
            {
                Interaction.MsgBox("Table " + oRow("TableNumber") + " already exists.");
                return;
            }
        }

        TestArray();

        oRow = dsSetup.Tables("TermsTables").NewRow;
        oRow("CompanyID") = corpID;
        oRow("LocationID") = corpPhysicalLocation;
        oRow("TableNumber") = currentTableInfo.CurrentTable.PhysicalTableNumber;
        oRow("FloorPlanID") = currentTableInfo.CurrentTable.FloorPlanID;
        oRow("Seats") = currentTableInfo.CurrentTable.Seats;
        oRow("Available") = currentTableInfo.CurrentTable.Available;
        oRow("isTable") = 1;
        oRow("isWall") = 0;
        oRow("isOther") = 0;
        oRow("isRound") = currentTableInfo.CurrentTable.IsRound;
        oRow("xLoc") = currentTableInfo.CurrentTable.xLoc;
        oRow("yLoc") = currentTableInfo.CurrentTable.yLoc;
        oRow("myWidth") = currentTableInfo.CurrentTable.myWidth;
        oRow("myHeight") = currentTableInfo.CurrentTable.myHeight;
        // 444      oRow("Active") = currentTableInfo.CurrentTable.Active

        dsSetup.Tables("TermsTables").Rows.Add(oRow);

        currentTableInfo.Dispose();
        changedTable = true;
        DisplayEachTable(ref oRow, i);
        i += 1;

    }

    private void NewTerminalAcceptedFrom_UC()
    {

        if (currentTermInfo.txtTermName.Text == "")
        {
            Interaction.MsgBox("Incorrect Terminal Name");
            return;
        }

        DataRow oRow;
        UpdateTerminalData();    // this accepts changes as well
        TestArray();

        oRow = dsSetup.Tables("Terminals").NewRow;
        oRow("CompanyID") = corpID;
        oRow("LocationID") = corpPhysicalLocation;
        oRow("TerminalID") = currentTermInfo.CurrentTerminal.TermID;
        oRow("TerminalName") = currentTermInfo.txtTermName.Text;     // currentTermInfo.CurrentTerminal.TermName
        oRow("TerminalMethod") = currentTermInfo.CurrentTerminal.TermMethod;
        if (currentTermInfo.CurrentTerminal.TermGroupID == default)
        {
            oRow("TerminalsGroupID") = 0;
        }
        else
        {
            oRow("TerminalsGroupID") = currentTermInfo.CurrentTerminal.TermGroupID;
        }
        oRow("FloorPlanID") = currentTermInfo.CurrentTerminal.FloorPlanID;
        oRow("TermX") = currentTermInfo.CurrentTerminal.xLoc;
        oRow("TermY") = currentTermInfo.CurrentTerminal.yLoc;

        dsSetup.Tables("Terminals").Rows.Add(oRow);
        oRow("TerminalsPrimaryKey") = InsertingNewTerminal(ref oRow);
        currentTermInfo.CurrentTerminal.TermPrimaryKey = oRow("TerminalsPrimaryKey");
        dsSetup.Tables("Terminals").AcceptChanges();

        i += 1;
        DisplayEachTerminal(ref oRow, i);

    }

    private object InsertingNewTerminal(ref DataRow oRow)
    {
        var newTerminalsPrimaryKey = default(int);

        sql.SqlInsertCommandTerms.Parameters("@CompanyID").Value = oRow("CompanyID");
        sql.SqlInsertCommandTerms.Parameters("@LocationID").Value = oRow("LocationID");
        sql.SqlInsertCommandTerms.Parameters("@TerminalID").Value = oRow("TerminalID");
        sql.SqlInsertCommandTerms.Parameters("@TerminalName").Value = oRow("TerminalName");
        sql.SqlInsertCommandTerms.Parameters("@TerminalMethod").Value = oRow("TerminalMethod");
        sql.SqlInsertCommandTerms.Parameters("@TerminalsGroupID").Value = oRow("TerminalsGroupID");
        sql.SqlInsertCommandTerms.Parameters("@FloorPlanID").Value = oRow("FloorPlanID");
        sql.SqlInsertCommandTerms.Parameters("@TermX").Value = oRow("TermX");
        sql.SqlInsertCommandTerms.Parameters("@TermY").Value = oRow("TermY");

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            newTerminalsPrimaryKey = (int)sql.SqlInsertCommandTerms.ExecuteScalar();
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);
        }

        return newTerminalsPrimaryKey;

    }

    private void NewTerminalUseOrder_UC(int useOrder, string newUse)
    {

        DataRow oRow;

        oRow = dsSetup.Tables("TerminalsUseOrder").NewRow;
        oRow("TerminalsPrimaryKey") = currentTermInfo.CurrentTerminal.TermPrimaryKey;
        oRow("CompanyID") = corpID;
        oRow("LocationID") = corpPhysicalLocation;
        oRow("MethodUse") = newUse;
        oRow("UsePriority") = useOrder;
        oRow("Active") = 1;

        dsSetup.Tables("TerminalsUseOrder").Rows.Add(oRow);

        changedTerminal = true;

        // currentTermInfo.Dispose()
        // DisplayEachTerminal(oRow, i)
        // i += 1

    }


    private void WallUpdatesAccepted()
    {
        int count = 0;

        foreach (DataRow oRow in dsSetup.Tables("TermsWalls").Rows)
        {
            if (oRow("TableNumber") == currentWallInfo.CurrentWall.IndexTableNumber)
            {
                // oRow("isRound") = CInt(currentWallInfo..Text)
                oRow("xLoc") = currentWallInfo.NewWall.xLoc;
                oRow("yLoc") = currentWallInfo.NewWall.yLoc;
                oRow("myWidth") = currentWallInfo.NewWall.myWidth;
                oRow("myHeight") = currentWallInfo.NewWall.myHeight;
                break;
            }
        }

        if (currentWallInfo.CurrentWall.OldWidth != currentWallInfo.CurrentWall.myWidth | currentWallInfo.CurrentWall.OldHeight != currentWallInfo.CurrentWall.myHeight)
        {
            terminalPanel[currentWallInfo.NewWall.IndexTableNumber].Size = new System.Drawing.Size(currentWallInfo.NewWall.myWidth, currentWallInfo.NewWall.myHeight);
        }
        if (currentWallInfo.locationHasChanged == true)
        {
            terminalPanel[currentWallInfo.NewWall.IndexTableNumber].Location = new Point(currentWallInfo.NewWall.xLoc, currentWallInfo.NewWall.yLoc);
        }

        changedTable = true;
        currentWallInfo.Dispose();

    }

    private void TableUpdatesAccepted()
    {
        DataRow oRow;
        int count = 0;

        // do a check to verify table number is not duplicated
        foreach (DataRow currentORow in dsSetup.Tables("TermsTables").Rows)
        {
            oRow = currentORow;
            if (oRow("TableNumber") == currentTableInfo.CurrentTable.PhysicalTableNumber)
            {
                count += 1;
                if (count == 2)
                {
                    Interaction.MsgBox("Table " + oRow("TableNumber") + " already exists.");
                    return;
                }
            }
        }

        foreach (DataRow currentORow1 in dsSetup.Tables("TermsTables").Rows)
        {
            oRow = currentORow1;
            if (oRow("TableNumber") == currentTableInfo.CurrentTable.PhysicalTableNumber)
            {
                oRow("Seats") = currentTableInfo.CurrentTable.Seats; // CInt(currentTableInfo.txtSeats.Text)
                oRow("Available") = currentTableInfo.chbAvailable.Checked;
                // oRow("isRound") = CInt(currentTableInfo..Text)
                oRow("myWidth") = currentTableInfo.CurrentTable.myWidth; // CInt(currentTableInfo.txtWidth.Text)
                oRow("myHeight") = currentTableInfo.CurrentTable.myHeight; // CInt(currentTableInfo.txtHeight.Text)
                break;

            }
        }

        if (currentTableInfo.CurrentTable.OldWidth != currentTableInfo.CurrentTable.myWidth | currentTableInfo.CurrentTable.OldHeight != currentTableInfo.CurrentTable.myHeight)
        {
            terminalPanel[currentTableInfo.CurrentTable.Index].Size = new System.Drawing.Size(currentTableInfo.CurrentTable.myWidth, currentTableInfo.CurrentTable.myHeight);
        }

        changedTable = true;
        currentTableInfo.Dispose();

    }

    private void TerminalUpdatesAccepted()
    {

        if (currentTermInfo.txtTermName.Text == "")
        {
            Interaction.MsgBox("Incorrect Terminal Name");
            return;
        }

        foreach (DataRow oRow in dsSetup.Tables("Terminals").Rows)
        {
            if (oRow("TerminalID") == currentTermInfo.CurrentTerminal.TermID)
            {
                oRow("TerminalName") = currentTermInfo.txtTermName.Text;
                oRow("TerminalMethod") = currentTermInfo.CurrentTerminal.TermMethod;
                oRow("TerminalsGroupID") = currentTermInfo.CurrentTerminal.TermGroupID;
                break;
            }
        }

        changedTerminal = true;
        currentTermInfo.Dispose();

    }

    private void WallUpdatesCanceled()
    {
        DisposeOfTerminalInfo();

    }

    private void TableUpdatesCanceled()
    {
        DisposeOfTerminalInfo();

    }

    private void TerminalUpdatesCanceled()
    {
        DisposeOfTerminalInfo();

    }

    private void DisplayWallInfo(ref WallInfo_UC currentWallInfo, int ii)
    {

        switch (terminalPanel[ii].tempWall.FloorPlanID)
        {
            case var @case when @case == FloorPlanFirst:
                {
                    if (terminalPanel[ii].Location.X < Panel1.Width / 2)
                    {
                        currentWallInfo.Location = new Point(400, 100);
                    }
                    else
                    {
                        currentWallInfo.Location = new Point(50, 100);
                    }
                    FloorPlan1.Controls.Add(currentWallInfo);
                    break;
                }
            case var case1 when case1 == FloorPlanSecond:
                {
                    if (terminalPanel[ii].Location.X < Panel2.Width / 2)
                    {
                        currentWallInfo.Location = new Point(400, 100);
                    }
                    else
                    {
                        currentWallInfo.Location = new Point(50, 100);
                    }
                    FloorPlan2.Controls.Add(currentWallInfo);
                    break;
                }

        }

        currentWallInfo.BringToFront();
        currentWallInfo.Focus();

    }

    private void DisplayTableInfo(ref TableInfo_UC currentTableInfo, int ii)
    {

        switch (terminalPanel[ii].tempTable.FloorPlanID)
        {
            case var @case when @case == FloorPlanFirst:
                {
                    if (terminalPanel[ii].Location.X < Panel1.Width / 2)
                    {
                        currentTableInfo.Location = new Point(400, 100);
                    }
                    else
                    {
                        currentTableInfo.Location = new Point(50, 100);
                    }
                    FloorPlan1.Controls.Add(currentTableInfo);
                    break;
                }
            case var case1 when case1 == FloorPlanSecond:
                {
                    if (terminalPanel[ii].Location.X < Panel2.Width / 2)
                    {
                        currentTableInfo.Location = new Point(400, 100);
                    }
                    else
                    {
                        currentTableInfo.Location = new Point(50, 100);
                    }
                    FloorPlan2.Controls.Add(currentTableInfo);
                    break;
                }

        }

        currentTableInfo.BringToFront();
        currentTableInfo.Focus();

    }

    private void DisplayTermInfo(ref TerminalInfo_UC currentTermInfo, int ii)
    {

        switch (terminalPanel[ii].tempTerminal.FloorPlanID)
        {
            case var @case when @case == FloorPlanFirst:
                {
                    if (terminalPanel[ii].Location.X < Panel1.Width / 2)
                    {
                        currentTermInfo.Location = new Point(400, 100);
                    }
                    else
                    {
                        currentTermInfo.Location = new Point(50, 100);
                    }
                    FloorPlan1.Controls.Add(currentTermInfo);
                    break;
                }
            case var case1 when case1 == FloorPlanSecond:
                {
                    if (terminalPanel[ii].Location.X < Panel2.Width / 2)
                    {
                        currentTermInfo.Location = new Point(400, 100);
                    }
                    else
                    {
                        currentTermInfo.Location = new Point(50, 100);
                    }
                    FloorPlan2.Controls.Add(currentTermInfo);
                    break;
                }

        }
        currentTermInfo.BringToFront();
        currentTermInfo.Focus();

    }

    private void tabFllorPlan1_Leave(object sender, EventArgs e)
    {

        RunTerminalSavingRoutine();

    }

    private void tabFllorPlan2_Leave(object sender, EventArgs e)
    {

        RunTerminalSavingRoutine();

    }

    private void RunTerminalSavingRoutine()
    {

        if (changedTerminal == true)
        {
            UpdateTerminalData();
            changedTerminal = false;
        }
        if (changedTable == true)
        {
            UpdateTablesData();
            changedTable = false;
        }

    }
    private void UpdateTablesData()
    {

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlTermsFloor.Update(dsSetup, "TermsFloor");
            sql.SqlTermsTables.Update(dsSetup, "TermsTables");
            sql.SqlTermsWalls.Update(dsSetup, "TermsWalls");
            sql.cn.Close();

            dsSetup.Tables("TermsFloor").AcceptChanges();
            dsSetup.Tables("TermsTables").AcceptChanges();
            dsSetup.Tables("TermsWalls").AcceptChanges();
        }

        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);

            CloseConnection();
        }
    }

    private void UpdateTerminalData()
    {

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlTermGroups.Update(dsSetup, "TermGroups");
            sql.SqlTerms.Update(dsSetup, "Terminals");
            sql.SqlTermsUse.Update(dsSetup, "TerminalsUseOrder");
            sql.cn.Close();

            dsSetup.Tables("TermGroups").AcceptChanges();
            dsSetup.Tables("Terminals").AcceptChanges();
            dsSetup.Tables("TerminalsUseOrder").AcceptChanges();
        }

        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);

            CloseConnection();
        }
    }

    private void ChangeFloorPlan(object sender, EventArgs e) // FloorPlan2.MouseEnter
    {

        if (FloorPlan1.Focus == true)
        {
            currentFloorPlanID = 1;
        }
        else if (FloorPlan2.Focus == true)
        {
            currentFloorPlanID = 2;
        }

    }

}