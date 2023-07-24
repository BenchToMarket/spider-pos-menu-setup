using System;
using System.Diagnostics;
using System.Linq;
using DataSet_Builder;

public partial class Terminal_Button : Button
{

    private string _termType; // terminal, table, wall
    private int _index;
    internal Terminal tempTerminal = new Terminal();
    internal DinnerTable tempTable = new DinnerTable();
    private bool _isNewTerminal;
    private int _term_table_Num;
    private int _floorPlan;
    private bool _isNewTable;
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

    public delegate void TerminalNewInfoNeededEventHandler(int i);

    public event TableMovedEventHandler TableMoved;

    public delegate void TableMovedEventHandler(int i);
    public event TableInfoReviewEventHandler TableInfoReview;

    public delegate void TableInfoReviewEventHandler(int i);
    public event TableNewInfoNeededEventHandler TableNewInfoNeeded;

    public delegate void TableNewInfoNeededEventHandler(int i);

    #region  Windows Form Designer generated code 

    public Terminal_Button(string tt, int i, float x, float y, float w, float h, int tn, int fp) : base()
    {

        _termType = tt;
        _index = i;
        this.Location = new System.Drawing.Point((int)Math.Round(x), (int)Math.Round(y));
        _floorPlan = fp;
        this.Width = w;
        this.Height = h;
        _term_table_Num = tn;
        this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.TextAlign = ContentAlignment.MiddleCenter;

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
                    this.BackColor = Color.Black;
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
    // Friend WithEvents lblTermNum As System.Windows.Forms.Label

    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        // Me.lblTermNum = New System.Windows.Forms.Label
        this.SuspendLayout();
        // 
        // lblTermNum
        // 
        // Me.lblTermNum.ForeColor = System.Drawing.Color.White
        // Me.lblTermNum.Location = New System.Drawing.Point(0, 8)
        // Me.lblTermNum.Name = "lblTermNum"
        // Me.lblTermNum.Size = New System.Drawing.Size(30, 16)
        // Me.lblTermNum.TabIndex = 0
        // Me.lblTermNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        // 
        // Terminal_UC
        // 
        // Me.Controls.Add(Me.lblTermNum)
        this.Name = "Terminal_UC";
        this.Size = new System.Drawing.Size(30, 30);
        this.ResumeLayout(false);

    }

    #endregion

    private void InitializeOther()
    {

        if (!(Term_Table_Num == 0))
        {
            this.Text = Term_Table_Num;
        }

    }


    private void ListDragSource_MouseDown(object sender, Global.System.Windows.Forms.MouseEventArgs e) // , lblTermNum.MouseDown
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

    private void ListDragSource_MouseUp(object sender, MouseEventArgs e) // , lblTermNum.MouseUp
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
                    tempTerminal.xLoc = e.X + xLoc - xCorrection;
                    tempTerminal.yLoc = e.Y + yLoc - yCorrection;

                    if (IsNewTerminal == true)
                    {
                        // define new terminal
                        tempTerminal.TermID = DetermineNextAvailTermNumber();
                        tempTerminal.FloorPlanID = _floorPlan;

                        TerminalNewInfoNeeded?.Invoke(Index);
                    }
                    else
                    {
                        this.Location = new Point(tempTerminal.xLoc, tempTerminal.yLoc);
                        TerminalMoved?.Invoke(Index);
                    }

                    break;
                }

            case "Table":
                {
                    tempTable.xLoc = e.X + xLoc - xCorrection;
                    tempTable.yLoc = e.Y + yLoc - yCorrection;

                    if (IsNewTerminal == true)
                    {
                        // define new table
                        // tempTable.TableNumber = DetermineNextAvailTermNumber()
                        tempTable.FloorPlanID = _floorPlan;

                        TableNewInfoNeeded?.Invoke(Index);
                    }
                    else
                    {
                        this.Location = new Point(tempTable.xLoc, tempTable.yLoc);
                        TableMoved?.Invoke(Index);
                    }

                    break;
                }

            case "Wall":
                {
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
    private void ListDragSource_MouseMove(object sender, MouseEventArgs e) // , lblTermNum.MouseMove
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

    private void ChangeInfo_DoubleClick(object sender, EventArgs e) // , lblTermNum.DoubleClick
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
                    break;
                }

        }


    }

}