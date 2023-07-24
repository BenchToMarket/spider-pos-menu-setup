using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using DataSet_Builder;

public partial class Terminal_UC : System.Windows.Forms.UserControl
{

    private string _termType; // terminal, table, wall
    private int _index;
    internal Wall tempWall = new Wall();
    internal Terminal tempTerminal = new Terminal();
    internal PhysicalTable tempTable = new PhysicalTable();
    private bool _isNewTerminal;
    private int _term_table_Num;
    private int _floorPlanID;
    private bool _isNewTable;
    private bool _isActive;
    // Private _tableNum As Integer

    internal string TermType
    {
        get
        {
            return _termType;
        }
        set
        {
            _termType = value;
        }
    }

    internal int Index
    {
        get
        {
            return _index;
        }
        set
        {
            _index = value;
        }
    }

    internal bool IsNewTerminal
    {
        get
        {
            return _isNewTerminal;
        }
        set
        {
            _isNewTerminal = value;
        }
    }

    internal int Term_Table_Num
    {
        get
        {
            return _term_table_Num;
        }
        set
        {
            _term_table_Num = value;
        }
    }

    internal int FloorPlanID
    {
        get
        {
            return _floorPlanID;
        }
        set
        {
            _floorPlanID = value;
        }
    }

    internal bool IsNewTable
    {
        get
        {
            return _isNewTable;
        }
        set
        {
            _isNewTable = value;
        }
    }

    internal bool IsActive
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

    // Friend Property TableNum() As Integer
    // '       Get
    // Return _tableNum
    // End Get
    // Set(ByVal Value As Integer)
    // _tableNum = Value
    // End Set
    // End Property


    private int xCorrection;
    private int yCorrection;



    // Private indexOfItemUnderMouseToDrag As Integer
    // Private indexOfItemUnderMouseToDrop As Integer

    private Rectangle dragBoxFromMouseDown;
    private Point screenOffset;
    public event GridMouseDownEventHandler GridMouseDown;

    public delegate void GridMouseDownEventHandler(object sender, MouseEventArgs e);
    public event GridMouseUpEventHandler GridMouseUp;

    public delegate void GridMouseUpEventHandler(object sender, MouseEventArgs e);
    public event GridMouseMoveEventHandler GridMouseMove;

    public delegate void GridMouseMoveEventHandler(object sender, MouseEventArgs e);
    // Event GridDragOver(ByVal sender As Object, ByVal e As DragEventArgs)
    // Event GridDragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
    // Event GridQueryContinueDrag(ByVal sender As Object, ByVal e As QueryContinueDragEventArgs)
    public event TerminalMovedEventHandler TerminalMoved;

    public delegate void TerminalMovedEventHandler(int i);
    public event TerminalInfoReviewEventHandler TerminalInfoReview;

    public delegate void TerminalInfoReviewEventHandler(int i);
    public event TerminalNewInfoNeededEventHandler TerminalNewInfoNeeded;

    public delegate void TerminalNewInfoNeededEventHandler(); // ByVal i As Integer)

    public event TableMovedEventHandler TableMoved;

    public delegate void TableMovedEventHandler(int i);
    public event TableInfoReviewEventHandler TableInfoReview;

    public delegate void TableInfoReviewEventHandler(int i);
    public event TableNewInfoNeededEventHandler TableNewInfoNeeded;

    public delegate void TableNewInfoNeededEventHandler(); // ByVal i As Integer)

    public event WallMovedEventHandler WallMoved;

    public delegate void WallMovedEventHandler(int i);
    public event WallInfoReviewEventHandler WallInfoReview;

    public delegate void WallInfoReviewEventHandler(int i);
    public event WallNewInfoNeededEventHandler WallNewInfoNeeded;

    public delegate void WallNewInfoNeededEventHandler(); // ByVal i As Integer)



    #region  Windows Form Designer generated code 

    public Terminal_UC(string tt, int i, float x, float y, float w, float h, int tn, int fp, bool isAct) : base()
    {

        _termType = tt;
        _index = i;
        this.Location = new System.Drawing.Point((int)Math.Round(x), (int)Math.Round(y));
        _floorPlanID = fp;
        this.Width = w;
        this.Height = h;
        _term_table_Num = tn;    // this is index for walls
        _isActive = isAct;

        switch (TermType ?? "")
        {

            case "Terminal":
                {
                    this.BackColor = Color.IndianRed;
                    this.ForeColor = Color.White;
                    break;
                }

            case "Table":
                {
                    // _tableNum = tn
                    this.BackColor = Color.DarkBlue;
                    this.ForeColor = Color.White;
                    break;
                }

            case "Wall":
                {
                    this.BackColor = System.Drawing.Color.FromArgb(59, 96, 141);
                    this.ForeColor = Color.White;
                    break;
                }
        }



        // This call is required by the Windows Form Designer.
        InitializeComponent();

        // Add any initialization after the InitializeComponent() call
        InitializeOther();
        base.MouseDown += ListDragSource_MouseDown;
        base.MouseUp += ListDragSource_MouseUp;
        base.MouseMove += ListDragSource_MouseMove;
        base.DoubleClick += ChangeInfo_DoubleClick;


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
    private Global.System.Windows.Forms.Label _lblTermNum;

    internal virtual Global.System.Windows.Forms.Label lblTermNum
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _lblTermNum;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_lblTermNum != null)
            {
                _lblTermNum.MouseDown -= ListDragSource_MouseDown;
                _lblTermNum.MouseUp -= ListDragSource_MouseUp;
                _lblTermNum.MouseMove -= ListDragSource_MouseMove;
                _lblTermNum.DoubleClick -= ChangeInfo_DoubleClick;
            }

            _lblTermNum = value;
            if (_lblTermNum != null)
            {
                _lblTermNum.MouseDown += ListDragSource_MouseDown;
                _lblTermNum.MouseUp += ListDragSource_MouseUp;
                _lblTermNum.MouseMove += ListDragSource_MouseMove;
                _lblTermNum.DoubleClick += ChangeInfo_DoubleClick;
            }
        }
    }
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        _lblTermNum = new System.Windows.Forms.Label();
        _lblTermNum.MouseDown += ListDragSource_MouseDown;
        _lblTermNum.MouseUp += ListDragSource_MouseUp;
        _lblTermNum.MouseMove += ListDragSource_MouseMove;
        _lblTermNum.DoubleClick += ChangeInfo_DoubleClick;
        this.SuspendLayout();
        // 
        // lblTermNum
        // 
        _lblTermNum.Anchor = (Global.System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

        _lblTermNum.ForeColor = System.Drawing.Color.White;
        _lblTermNum.Location = new System.Drawing.Point(0, 8);
        _lblTermNum.Name = "_lblTermNum";
        _lblTermNum.Size = new System.Drawing.Size(30, 16);
        _lblTermNum.TabIndex = 0;
        _lblTermNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Terminal_UC
        // 
        this.Controls.Add(_lblTermNum);
        this.ForeColor = System.Drawing.Color.White;
        this.Name = "Terminal_UC";
        this.Size = new System.Drawing.Size(30, 30);
        this.ResumeLayout(false);

    }

    #endregion

    private void InitializeOther()
    {

        if (!(Term_Table_Num == 0) & !(TermType == "Wall"))
        {
            lblTermNum.Text = Term_Table_Num;
        }


    }

    internal void AssignSizeValues()
    {
        switch (TermType ?? "")
        {

            case "Terminal":
                {
                    break;
                }

            case "Table":
                {
                    tempTable.myWidth = this.Width;
                    tempTable.myHeight = this.Height;
                    tempTable.Index = Index;
                    tempTable.OldWidth = this.Width;
                    tempTable.OldHeight = this.Height;
                    tempTable.Active = IsActive;
                    break;
                }

            case "Wall":
                {
                    tempWall.xLoc = this.Location.X;
                    tempWall.yLoc = this.Location.Y;
                    tempWall.myWidth = this.Width;
                    tempWall.myHeight = this.Height;
                    tempWall.OldWidth = this.Width;
                    tempWall.OldHeight = this.Height;
                    tempWall.IndexTableNumber = Index;
                    break;
                }

        }

    }
    private void ListDragSource_MouseDown(object sender, Global.System.Windows.Forms.MouseEventArgs e)
    {

        try
        {
            // Remember the point where the mouse down occurred. The DragSize indicates
            // the size that the mouse can move before a drag event should be started.                
            Size dragSize = SystemInformation.DragSize;

            // Create a rectangle using the DragSize, with the mouse position being
            // at the center of the rectangle.
            dragBoxFromMouseDown = new Rectangle(0 - this.Location.X, 0 - this.Location.Y, this.Parent.Width, this.Parent.Height);
            xCorrection = e.X;
            yCorrection = e.Y;

            if (Term_Table_Num == 0)
            {
                IsNewTerminal = true;
            }

            GridMouseDown?.Invoke(sender, e);
        }
        catch (Exception ex)
        {
        }

    }

    private void ListDragSource_MouseUp(object sender, MouseEventArgs e)
    {

        if (e.X == xCorrection & e.Y == yCorrection)
        {
            // panel did not move
            return;
        }

        int xLoc = this.Location.X;
        int yLoc = this.Location.Y;

        switch (TermType ?? "")
        {

            case "Terminal":
                {

                    if (IsNewTerminal == true)
                    {
                        tempTerminal.xLoc = e.X - 60; // - 96
                        tempTerminal.yLoc = e.Y - 90; // - 24

                        // define new terminal
                        tempTerminal.TermID = DetermineNextAvailTermNumber();
                        tempTerminal.TermGroupID = 0;
                        tempTerminal.TermMethod = "Table";       // just the defaults
                                                                 // tempTerminal.FloorPlanID = _floorPlanID

                        TerminalNewInfoNeeded?.Invoke(); // Index) 'index?
                        tempTerminal.TermName = "";
                    }
                    else
                    {
                        tempTerminal.xLoc = e.X + xLoc - xCorrection;
                        tempTerminal.yLoc = e.Y + yLoc - yCorrection;

                        this.Location = new Point(tempTerminal.xLoc, tempTerminal.yLoc);
                        TerminalMoved?.Invoke(Index);
                    }

                    break;
                }

            case "Table":
                {

                    if (IsNewTerminal == true)
                    {
                        tempTable.xLoc = e.X;
                        tempTable.yLoc = e.Y;

                        // define new table
                        tempTable.Seats = 4;
                        tempTable.Available = 1;
                        tempTable.IsRound = 0;
                        tempTable.myWidth = 40;
                        tempTable.myHeight = 40;
                        tempTable.Index = Index;
                        tempTable.OldWidth = 40;
                        tempTable.OldHeight = 40;
                        tempTable.Active = 1;

                        // tempTable.TableNumber = DetermineNextAvailTermNumber()
                        // tempTable.FloorPlanID = _floorPlanID

                        TableNewInfoNeeded?.Invoke(); // 1)
                    }
                    else
                    {
                        tempTable.xLoc = e.X + xLoc - xCorrection;
                        tempTable.yLoc = e.Y + yLoc - yCorrection;

                        this.Location = new Point(tempTable.xLoc, tempTable.yLoc);
                        TableMoved?.Invoke(Index);
                    }

                    break;
                }

            case "Wall":
                {

                    if (IsNewTerminal == true)
                    {
                        tempWall.xLoc = e.X;
                        tempWall.yLoc = e.Y;

                        tempWall.IsRound = 0;
                        tempWall.myWidth = 150;
                        tempWall.myHeight = 20;

                        WallNewInfoNeeded?.Invoke(); // 2)
                    }
                    else
                    {
                        tempWall.xLoc = e.X + xLoc - xCorrection;
                        tempWall.yLoc = e.Y + yLoc - yCorrection;

                        this.Location = new Point(tempWall.xLoc, tempWall.yLoc);
                        WallMoved?.Invoke(Index);
                    }

                    break;
                }

        }



    }

    private object DetermineNextAvailTermNumber()
    {
        int openTermNum = 1;

        foreach (DataRow oRow in dsSetup.Tables("terminals").Rows)
        {
            if (!(oRow("TerminalID") < 1)) // in case there is a number zero screwing up our routine
            {
                if (!(oRow("TerminalID") == openTermNum))
                {
                    // this is our first open terminal number
                    tempTerminal.TermID = openTermNum;
                }
                else
                {
                    openTermNum += 1;

                }
            }
        }

        return openTermNum;

    }
    private void ListDragSource_MouseMove(object sender, MouseEventArgs e)
    {

        if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
        {

            // If the mouse moves outside the rectangle, start the drag.
            if (Rectangle.op_Inequality(dragBoxFromMouseDown, Rectangle.Empty) & !dragBoxFromMouseDown.Contains(e.X, e.Y))
            {

                // The screenOffset is used to account for any desktop bands 
                // that may be at the top or left side of the screen when 
                // determining when to cancel the drag drop operation.
                screenOffset = SystemInformation.WorkingArea.Location;

                // Proceed with the drag and drop, passing in the list item.                    
                DragDropEffects dropEffect = this.DoDragDrop(this, DragDropEffects.All | DragDropEffects.Link);

            }
        }

        GridMouseMove?.Invoke(sender, e);
    }

    private void ChangeInfo_DoubleClick(object sender, EventArgs e)
    {

        if (Index > 0)
        {
            switch (TermType ?? "")
            {

                case "Terminal":
                    {
                        TerminalInfoReview?.Invoke(Index);
                        break;
                    }

                case "Table":
                    {
                        TableInfoReview?.Invoke(Index);
                        break;
                    }

                case "Wall":
                    {
                        WallInfoReview?.Invoke(Index);
                        break;
                    }

            }
        }

    }
}