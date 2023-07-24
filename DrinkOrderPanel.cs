using System;
using System.Diagnostics;
using System.Linq;

public partial class DrinkOrderPanel : System.Windows.Forms.UserControl
{
    private Rectangle dragBoxFromMouseDown;
    private Point screenOffset;



    public event GridMouseDownEventHandler GridMouseDown;

    public delegate void GridMouseDownEventHandler(object sender, MouseEventArgs e);
    public event GridMouseUpEventHandler GridMouseUp;

    public delegate void GridMouseUpEventHandler(object sender, MouseEventArgs e);
    public event GridMouseMoveEventHandler GridMouseMove;

    public delegate void GridMouseMoveEventHandler(object sender, MouseEventArgs e);
    public event GridDragOverEventHandler GridDragOver;

    public delegate void GridDragOverEventHandler(object sender, DragEventArgs e);
    public event GridDragDropEventHandler GridDragDrop;

    public delegate void GridDragDropEventHandler(object sender, DragEventArgs e);
    public event GridQueryContinueDragEventHandler GridQueryContinueDrag;

    public delegate void GridQueryContinueDragEventHandler(object sender, QueryContinueDragEventArgs e);

    #region  Windows Form Designer generated code 

    public DrinkOrderPanel() : base()
    {

        // This call is required by the Windows Form Designer.
        InitializeComponent();
        base.MouseDown += ListDragSource_MouseDown;
        base.MouseMove += ListDragSource_MouseMove;
        base.DragOver += ListDragTarget_DragOver;
        base.DragDrop += ListDragTarget_DragDrop;
        base.QueryContinueDrag += ListDragSource_QueryContinueDrag;

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
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
    }

    #endregion


    private void ListDragSource_MouseDown(object sender, MouseEventArgs e)
    {

        menuJoinDragSource = this.ID;
        indexDragSource = this.Position;
        nameDragSource = this.Text;
        priceDragSource = this.DrinkPrice;

        // Remember the point where the mouse down occurred. The DragSize indicates
        // the size that the mouse can move before a drag event should be started.                
        Size dragSize = SystemInformation.DragSize;

        // Create a rectangle using the DragSize, with the mouse position being
        // at the center of the rectangle.
        dragBoxFromMouseDown = new Rectangle(new Point(e.X - dragSize.Width / 2, e.Y - dragSize.Height / 2), dragSize);

        GridMouseDown?.Invoke(sender, e);

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

                string data;
                data = this.Text;

                DragDropEffects dropEffect = this.DoDragDrop(data, DragDropEffects.Move);

                // If the drag operation was a move then remove the item.
                if (dropEffect == DragDropEffects.Move)
                {

                    // If foodPanel.MenuIndex = 0 Then
                    // when 0 item came from staging so readjust all sraging buttons

                    this.Text = "";
                    this.MenuIndex = (object)null;
                    this.Text = (object)null;
                    this.DrinkPrice = (object)null;
                    this.ID = (object)null;

                }

            }
        }

        GridMouseMove?.Invoke(sender, e);
    }


    private void ListDragTarget_DragOver(object sender, DragEventArgs e)
    {

        // Determine whether string data exists in the drop data. If not, then
        // the drop effect reflects that the drop cannot occur.
        if (!e.Data.GetDataPresent(typeof(string)))
        {

            e.Effect = DragDropEffects.None;
            // DropLocationLabel.Text = "None - no string data."
            return;
        }

        // Set the effect based upon the KeyState.
        if ((e.KeyState & 8 + 32) == 8 + 32 & (e.AllowedEffect & DragDropEffects.Link) == DragDropEffects.Link)
        {
            // KeyState 8 + 32 = CTL + ALT

            // Link drag and drop effect.
            e.Effect = DragDropEffects.Link;
        }

        else if ((e.KeyState & 32) == 32 & (e.AllowedEffect & DragDropEffects.Link) == DragDropEffects.Link)
        {

            // ALT KeyState for link.
            e.Effect = DragDropEffects.Link;
        }

        else if ((e.KeyState & 4) == 4 & (e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
        {

            // SHIFT KeyState for move.
            e.Effect = DragDropEffects.Move;
        }

        else if ((e.KeyState & 8) == 8 & (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
        {

            // CTL KeyState for copy.
            e.Effect = DragDropEffects.Copy;
        }

        else if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
        {

            // By default, the drop action should be move, if allowed.
            e.Effect = DragDropEffects.Move;
        }

        else
        {
            e.Effect = DragDropEffects.None;
        }


        GridDragOver?.Invoke(sender, e);
    }


    private void ListDragTarget_DragDrop(object sender, DragEventArgs e)
    {

        int newPosition;
        newPosition = this.Position;

        // test to see if panel is empty
        // if not makes e.effects = none
        if (this.ID == 0)
        {

            if (e.Data.GetDataPresent(typeof(string)))
            {

                object item = (object)e.Data.GetData(typeof(string));

                // Perform drag and drop, depending upon the effect.
                if (e.Effect == DragDropEffects.Copy | e.Effect == DragDropEffects.Move)
                {

                    this.Text = nameDragSource;
                    this.ID = menuJoinDragSource;
                    // foodPanel.FoodName = nameDragSource
                    this.DrinkPrice = priceDragSource;

                    UpdateDrinkIndex(menuJoinDragSource, this.Position);

                }
            }
        }
        else
        {

            e.Effect = DragDropEffects.None;

            GridDragDrop?.Invoke(sender, e);
        }
    }


    private void ListDragSource_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
    {
        // Cancel the drag if the mouse moves off the form.
        ListBox lb = (Global.System.Windows.Forms.ListBox)sender;

        if (lb is not null)
        {

            Form f = lb.FindForm();

            // Cancel the drag if the mouse moves off the form. The screenOffset
            // takes into account any desktop bands that may be at the top or left
            // side of the screen.
            if (Control.MousePosition.X - screenOffset.X < f.DesktopBounds.Left | Control.MousePosition.X - screenOffset.X > f.DesktopBounds.Right | Control.MousePosition.Y - screenOffset.Y < f.DesktopBounds.Top | Control.MousePosition.Y - screenOffset.Y > f.DesktopBounds.Bottom)


            {

                e.Action = DragAction.Cancel;
            }
        }

        GridQueryContinueDrag?.Invoke(sender, e);
    }

    private void UpdateDrinkIndex(int mji, int newIndex)
    {

        foreach (DataRow updatingRow in dsSetup.Tables("OrderCategoryDetail").Rows)
        {
            if (updatingRow("DrinkID") == mji)
            {
                updatingRow("DrinkIndex") = newIndex;
                break;
            }
        }

    }
}