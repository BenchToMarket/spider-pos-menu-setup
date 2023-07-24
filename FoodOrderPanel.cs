using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;


public partial class FoodOrderPanel : System.Windows.Forms.UserControl
{

    private FoodPanelControl _foodPanel;

    internal virtual FoodPanelControl foodPanel
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _foodPanel;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            if (_foodPanel != null)
            {
                _foodPanel.MouseDown -= ListDragSource_MouseDown;
                _foodPanel.MouseMove -= ListDragSource_MouseMove;
                _foodPanel.DragOver -= ListDragTarget_DragOver;
                _foodPanel.DragDrop -= ListDragTarget_DragDrop;
                _foodPanel.QueryContinueDrag -= ListDragSource_QueryContinueDrag;
                _foodPanel.Click -= PanelClick;
            }

            _foodPanel = value;
            if (_foodPanel != null)
            {
                _foodPanel.MouseDown += ListDragSource_MouseDown;
                _foodPanel.MouseMove += ListDragSource_MouseMove;
                _foodPanel.DragOver += ListDragTarget_DragOver;
                _foodPanel.DragDrop += ListDragTarget_DragDrop;
                _foodPanel.QueryContinueDrag += ListDragSource_QueryContinueDrag;
                _foodPanel.Click += PanelClick;
            }
        }
    }

    private int indexOfItemUnderMouseToDrag;
    private int indexOfItemUnderMouseToDrop;

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
    public event MyPanelClickEventHandler MyPanelClick;

    public delegate void MyPanelClickEventHandler(object sender, EventArgs e);
    public event BlankOldModifierPanelEventHandler BlankOldModifierPanel;

    public delegate void BlankOldModifierPanelEventHandler(object sender, EventArgs e);


    #region  Windows Form Designer generated code 

    public FoodOrderPanel(Color bColor, Color fColor, int foodOrderNumber, float w, float h, int foodIndex, int menuJoinID, string foodName, string price, bool isStaging, string dTable, int fID, decimal sur, int rout, int dID, int GenMenuID, int cm) : base()
    {

        // This call is required by the Windows Form Designer.
        InitializeComponent();

        // Add any initialization after the InitializeComponent() call
        InitializeOther(bColor, fColor, foodOrderNumber, w, h, foodIndex, menuJoinID, foodName, price, isStaging, dTable, fID, sur, rout, dID, GenMenuID, cm);

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


    private void InitializeOther(Color bColor, Color fColor, int foodOrderNumber, float w, float h, int foodindex, int menuJoinID, string foodName, decimal price, bool isStaging, string dTable, int fID, decimal sur, int rout, int dID, int GenMenuID, int cm)
    {


        // w and h are the width and height of the parent panel
        float width = w;
        float height = h;
        float panelSpace = 3f;
        var x = default(float);
        var y = default(float);

        foodPanel = new FoodPanelControl(bColor, fColor, foodOrderNumber, foodindex, menuJoinID, foodName, price, width, height, isStaging, dTable, fID, sur, rout, dID, GenMenuID, cm);

        if (foodPanel.UpdatingTable == "OrderCategoryDetail")
        {
            if (foodOrderNumber < 5)
            {
                if (isStaging == true)
                {
                    x = panelSpace;
                    y = panelSpace * foodOrderNumber + (foodOrderNumber - 1) * height;
                }
                else
                {
                    x = panelSpace * foodOrderNumber + (foodOrderNumber - 1) * width;
                    y = panelSpace;
                }
            }
            else if (foodOrderNumber < 9)
            {
                if (isStaging == true)
                {
                    x = panelSpace;
                    y = panelSpace * foodOrderNumber + (foodOrderNumber - 1) * height;
                }
                else
                {
                    x = panelSpace * (foodOrderNumber - 4) + (foodOrderNumber - 5) * width;
                    y = 2f * panelSpace + height;
                }
            }
            else if (foodOrderNumber < 13)
            {
                if (isStaging == true)
                {
                    x = panelSpace;
                    y = panelSpace * foodOrderNumber + (foodOrderNumber - 1) * height;
                }
                else
                {
                    x = panelSpace * (foodOrderNumber - 8) + (foodOrderNumber - 9) * width;
                    y = 3f * panelSpace + 2f * height;
                }
            }
            else if (foodOrderNumber < 17)
            {
                x = panelSpace * (foodOrderNumber - 12) + (foodOrderNumber - 13) * width;
                y = 4f * panelSpace + 3f * height;
            }
            else if (foodOrderNumber < 21)
            {
                x = panelSpace * (foodOrderNumber - 16) + (foodOrderNumber - 17) * width;
                y = 5f * panelSpace + 4f * height;
            }
            else if (foodOrderNumber < 25)
            {
                x = panelSpace * (foodOrderNumber - 20) + (foodOrderNumber - 21) * width;
                y = 6f * panelSpace + 5f * height;
            }
            else if (foodOrderNumber < 29)
            {
                x = panelSpace * (foodOrderNumber - 24) + (foodOrderNumber - 25) * width;
                y = 7f * panelSpace + 6f * height;
            }
            else if (foodOrderNumber < 33)
            {
                x = panelSpace * (foodOrderNumber - 28) + (foodOrderNumber - 29) * width;
                y = 8f * panelSpace + 7f * height;
            }
            else if (foodOrderNumber < 37)
            {
                x = panelSpace * (foodOrderNumber - 32) + (foodOrderNumber - 33) * width;
                y = 9f * panelSpace + 8f * height;
            }
            else if (foodOrderNumber < 41)
            {
                x = panelSpace * (foodOrderNumber - 36) + (foodOrderNumber - 37) * width;
                y = 10f * panelSpace + 9f * height;

            }
            if (foodOrderNumber <= 24)
            {
                foodPanel.BackColor = Color.PowderBlue;
            }
            else
            {
                foodPanel.BackColor = Color.Lavender;
            }
        }
        else if (foodPanel.UpdatingTable == "Quick" | foodPanel.UpdatingTable == "Drinks")
        {
            if (foodOrderNumber < 7)
            {
                if (isStaging == true)
                {
                    x = panelSpace;
                    y = panelSpace * foodOrderNumber + (foodOrderNumber - 1) * height;
                }
                else
                {
                    x = panelSpace * foodOrderNumber + (foodOrderNumber - 1) * width;
                    y = panelSpace;
                }
            }
            else if (foodOrderNumber < 13)
            {
                if (isStaging == true)
                {
                    x = panelSpace;
                    y = panelSpace * foodOrderNumber + (foodOrderNumber - 1) * height;
                }
                else
                {
                    x = panelSpace * (foodOrderNumber - 6) + (foodOrderNumber - 7) * width;
                    y = 2f * panelSpace + height;
                }
            }
            else if (foodOrderNumber < 19)
            {
                if (isStaging == true)
                {
                    x = panelSpace;
                    y = panelSpace * foodOrderNumber + (foodOrderNumber - 1) * height;
                }
                else
                {
                    x = panelSpace * (foodOrderNumber - 12) + (foodOrderNumber - 13) * width;
                    y = 3f * panelSpace + 2f * height;
                }
            }
            else if (foodOrderNumber < 25)
            {
                x = panelSpace * (foodOrderNumber - 18) + (foodOrderNumber - 19) * width;
                y = 4f * panelSpace + 3f * height;
            }
            else if (foodOrderNumber < 31)
            {
                x = panelSpace * (foodOrderNumber - 24) + (foodOrderNumber - 25) * width;
                y = 5f * panelSpace + 4f * height;
            }
            else if (foodOrderNumber < 37)
            {
                x = panelSpace * (foodOrderNumber - 30) + (foodOrderNumber - 31) * width;
                y = 6f * panelSpace + 5f * height;
            }
            else if (foodOrderNumber < 43)
            {
                x = panelSpace * (foodOrderNumber - 36) + (foodOrderNumber - 37) * width;
                y = 7f * panelSpace + 6f * height;
            }
            else if (foodOrderNumber < 49)
            {
                x = panelSpace * (foodOrderNumber - 42) + (foodOrderNumber - 43) * width;
                y = 8f * panelSpace + 7f * height;
            }
            else if (foodOrderNumber < 55)
            {
                x = panelSpace * (foodOrderNumber - 48) + (foodOrderNumber - 49) * width;
                y = 9f * panelSpace + 8f * height;
            }
            else if (foodOrderNumber < 61)
            {
                x = panelSpace * (foodOrderNumber - 54) + (foodOrderNumber - 55) * width;
                y = 10f * panelSpace + 9f * height;

            }

            // foodPanel.BackColor = bColor
            // foodPanel.ForeColor = fColor
            foodPanel.BackColor = Color.PowderBlue;
        }

        else if (foodPanel.UpdatingTable == "Modifiers")
        {
            if (isStaging == true)
            {
                // for staging modifiers
                if (foodOrderNumber < 3)
                {
                    x = panelSpace;
                    y = panelSpace * foodOrderNumber + (foodOrderNumber - 1) * height;
                }
                else if (foodOrderNumber < 5)
                {
                    x = 2f * panelSpace + width;
                    y = panelSpace * (foodOrderNumber - 2) + (foodOrderNumber - 3) * height;
                }
                else if (foodOrderNumber < 7)
                {
                    x = 3f * panelSpace + 2f * width;
                    y = panelSpace * (foodOrderNumber - 4) + (foodOrderNumber - 5) * height;
                }
                else
                {
                    x = 4f * panelSpace + 3f * width;
                    y = panelSpace * (foodOrderNumber - 6) + (foodOrderNumber - 7) * height;
                }
                foodPanel.BackColor = bColor;
                foodPanel.ForeColor = fColor;
            }

            else
            {
                // for regular modifiers
                if (foodOrderNumber < 5)
                {
                    x = panelSpace * foodOrderNumber + (foodOrderNumber - 1) * width;
                    y = panelSpace;
                }
                else if (foodOrderNumber < 9)
                {
                    x = panelSpace * (foodOrderNumber - 4) + (foodOrderNumber - 5) * width;
                    y = 2f * panelSpace + height;
                }
                else if (foodOrderNumber < 13)
                {
                    x = panelSpace * (foodOrderNumber - 8) + (foodOrderNumber - 9) * width;
                    y = 3f * panelSpace + 2f * height;
                }
                else if (foodOrderNumber < 17)
                {
                    x = panelSpace * (foodOrderNumber - 12) + (foodOrderNumber - 13) * width;
                    y = 4f * panelSpace + 3f * height;
                }
                else if (foodOrderNumber < 21)
                {
                    x = panelSpace * (foodOrderNumber - 16) + (foodOrderNumber - 17) * width;
                    y = 5f * panelSpace + 4f * height;
                }
                else
                {
                    x = panelSpace * (foodOrderNumber - 20) + (foodOrderNumber - 21) * width;
                    y = 6f * panelSpace + 5f * height;
                }
                foodPanel.BackColor = bColor;
                foodPanel.ForeColor = fColor;

            }





        }


        this.Size = new Size(width, height);
        this.Location = new Point(x, y);
        this.AllowDrop = true;


        foodPanel.Size = new Size(width, height);
        foodPanel.Location = new Point(0, 0);

        // **************
        // the below is resetting all colors
        // If foodOrderNumber <= 24 Then
        // foodPanel.BackColor = Color.PowderBlue
        // Else
        // foodPanel.BackColor = Color.Lavender
        // End If
        foodPanel.AllowDrop = true;

        // Me.foodPanel.Controls.Add(foodNamePanel)
        // Me.foodPanel.Controls.Add(foodPricePanel)
        this.Controls.Add(foodPanel);

    }

    private void ListDragSource_MouseDown(object sender, MouseEventArgs e)
    {

        menuJoinDragSource = foodPanel.MenuJoinID;
        indexDragSource = foodPanel.MenuIndex;
        nameDragSource = foodPanel.FoodName;
        priceDragSource = foodPanel.FoodPrice;
        foodIDDragSource = foodPanel.FoodID;
        surchargeDragSource = foodPanel.Surcharge;
        routingIDDragSource = foodPanel.RoutingID;
        drinkIDDragSource = foodPanel.DrinkID;
        generalMenuIDDragSource = foodPanel.GeneralMenuID;
        currentMenuDragSource = foodPanel.CurrentMenu;

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
        if (foodPanel.MenuJoinID == -1 | foodPanel.MenuJoinID == -2)
        {
            return;
        }

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
                data = foodPanel.Text;

                DragDropEffects dropEffect = this.DoDragDrop(data, DragDropEffects.Move);

                // If the drag operation was a move then remove the item.
                if (dropEffect == DragDropEffects.Move)
                {

                    // If foodPanel.MenuIndex = 0 Then
                    // when 0 item came from staging so readjust all sraging buttons

                    if (foodPanel.UpdatingTable == "Drinks")
                    {
                        BlankOldModifierPanel?.Invoke(sender, e);
                        // Else
                    }

                    foodPanel.Text = "";
                    // 'old         foodPanel.MenuIndex = Nothing
                    foodPanel.FoodName = (object)null;
                    foodPanel.FoodPrice = (object)null;
                    // foodPanel.MenuJoinID = Nothing
                    foodPanel.MenuJoinID = 0;

                }
            }
        }

        GridMouseMove?.Invoke(sender, e);
    }

    private void ListDragTarget_DragOver(object sender, DragEventArgs e)
    {
        if (foodPanel.MenuJoinID == -1 | foodPanel.MenuJoinID == -2)
        {
            e.Effect = DragDropEffects.None;
            return;
        }

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
        newPosition = foodPanel.MenuIndex;

        // test to see if panel is empty
        // if not makes e.effects = none
        if (foodPanel.MenuJoinID == 0)
        {

            if (e.Data.GetDataPresent(typeof(string)))
            {

                object item = (object)e.Data.GetData(typeof(string));

                // Perform drag and drop, depending upon the effect.
                if (e.Effect == DragDropEffects.Copy | e.Effect == DragDropEffects.Move)
                {

                    foodPanel.Text = nameDragSource;
                    foodPanel.MenuJoinID = menuJoinDragSource;
                    foodPanel.FoodName = nameDragSource;
                    foodPanel.FoodPrice = priceDragSource;

                    foodPanel.FoodID = foodIDDragSource;
                    foodPanel.Surcharge = surchargeDragSource;
                    foodPanel.RoutingID = routingIDDragSource;
                    foodPanel.DrinkID = drinkIDDragSource;
                    foodPanel.GeneralMenuID = generalMenuIDDragSource;
                    foodPanel.CurrentMenu = currentMenuDragSource;

                    if (foodPanel.StagingPanel == true)
                    {
                        foodPanel.MenuIndex = 0;
                    }
                    else
                    {
                        foodPanel.MenuIndex = newPosition;
                    }

                    if (foodPanel.UpdatingTable == "OrderCategoryDetail" | foodPanel.UpdatingTable == "Quick")
                    {
                        UpdateMenuJoinIndex(menuJoinDragSource, foodPanel.MenuIndex);
                        BlankOldModifierPanel?.Invoke(sender, e); // also saves
                    }
                    else if (foodPanel.UpdatingTable == "Modifiers")
                    {
                        // UpdateMenuJoinIndex(menuJoinDragSource, foodPanel.MenuIndex)
                        UpdateModifierIndex(menuJoinDragSource, foodPanel.MenuIndex);
                        BlankOldModifierPanel?.Invoke(sender, e);
                    }
                    else if (foodPanel.UpdatingTable == "Drinks")
                    {
                        UpdateDrinkIndex(drinkIDDragSource, foodPanel.MenuIndex);
                        // 444      RaiseEvent BlankOldModifierPanel(sender, e)


                    }
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

    private void UpdateMenuJoinIndex(int mji, int newIndex)
    {
        DataRow oRow;
        bool needToAddItemOnMenuJoin = true;

        try
        {
            if (foodPanel.GeneralMenuID > 0)
            {
                foreach (DataRow currentORow in dsSetup.Tables("OrderCategoryDetail").Rows)
                {
                    oRow = currentORow;
                    if (oRow("MenuJoinID") == foodPanel.MenuJoinID) // mji (same thing)
                    {
                        if (!object.ReferenceEquals(oRow("GeneralMenuID"), DBNull.Value))   // just in case
                        {
                            // If oRow("GeneralMenuID") = foodPanel.GeneralMenuID Then
                            oRow("MenuIndex") = newIndex;
                            // End If
                            needToAddItemOnMenuJoin = false;
                            return;
                        }
                    }
                }
            }
            else
            {
                foreach (DataRow currentORow1 in dsSetup.Tables("OrderCategoryDetail").Rows)
                {
                    oRow = currentORow1;
                    if (oRow("MenuJoinID") == foodPanel.MenuJoinID)
                    {
                        oRow("MenuIndex") = newIndex;
                        needToAddItemOnMenuJoin = false;
                        return;
                    }
                }
            }
        }

        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);
        }

        // never need to add index for food, we add index when we add food
        // *** we may need to add a drink
        try
        {
            if (needToAddItemOnMenuJoin == true)
            {
                // add item to MenuJoin
                DataRow newRowDatabase;

                // *********** we need to do this like terminal add 
                // so we can load the menuJoinIndex
                SaveUpdatedMenuOrderCategoryDetail();

                newRowDatabase = dsSetup.Tables("OrderCategoryDetail").NewRow;
                newRowDatabase("CompanyID") = corpID;
                newRowDatabase("LocationID") = selectedLocation;
                newRowDatabase("FoodID") = foodPanel.FoodID;
                newRowDatabase("DrinkID") = foodPanel.DrinkID;

                // insert AbrevFoodName and DrinkName here
                // If foodPanel.FoodID > 0 Then
                // newRowDatabase("AbrevFoodName") = foodPanel.FoodName
                // Else
                // newRowDatabase("DrinkName") = foodPanel.FoodName
                // End If
                newRowDatabase("MenuID") = foodPanel.CurrentMenu;
                newRowDatabase("GeneralMenuID") = foodPanel.GeneralMenuID;
                newRowDatabase("Price") = foodPanel.FoodPrice;
                newRowDatabase("Surcharge") = foodPanel.Surcharge;
                newRowDatabase("RoutingID") = foodPanel.RoutingID;
                newRowDatabase("MenuIndex") = newIndex;
                newRowDatabase("Active") = true;
                dsSetup.Tables("OrderCategoryDetail").Rows.Add(newRowDatabase);
                // dsSetup.Tables("MenuJoin").Rows.Add(newRowDatabase)

                newRowDatabase("MenuJoinID") = InsertingNewMenuJoin(ref newRowDatabase);
                foodPanel.MenuJoinID = newRowDatabase("MenuJoinID");
                dsSetup.Tables("OrderCategoryDetail").AcceptChanges();
            }
            // dsSetup.Tables("MenuJoin").AcceptChanges()

            else
            {
                foreach (DataRow menuJoinRow in dsSetup.Tables("OrderCategoryDetail").Rows)
                {
                    if (menuJoinRow("MenuJoinID") == mji)
                    {
                        menuJoinRow("MenuIndex") = newIndex;
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);
        }

        // MsgBox(foodPanel.Text)
        // MsgBox(foodPanel.MenuJoinID)
        // MsgBox(foodPanel.FoodName)
        // MsgBox(foodPanel.FoodPrice)
        // MsgBox(foodPanel.FoodID)
        // MsgBox(foodPanel.Surcharge)
        // MsgBox(foodPanel.RoutingID)
        // MsgBox(foodPanel.DrinkID)
        // MsgBox(foodPanel.GeneralMenuID)
        // '     MsgBox(foodPanel.CurrentMenu)

    }

    private object InsertingNewMenuJoin(ref DataRow oRow)
    {
        var newMenuJoinID = default(int);

        sql.SqlInsertMenuOrderCategory.Parameters("@CompanyID").Value = oRow("CompanyID");
        sql.SqlInsertMenuOrderCategory.Parameters("@LocationID").Value = oRow("LocationID");
        sql.SqlInsertMenuOrderCategory.Parameters("@FoodID").Value = oRow("FoodID");
        sql.SqlInsertMenuOrderCategory.Parameters("@DrinkID").Value = oRow("DrinkID");
        sql.SqlInsertMenuOrderCategory.Parameters("@MenuID").Value = oRow("MenuID");
        sql.SqlInsertMenuOrderCategory.Parameters("@GeneralMenuID").Value = oRow("GeneralMenuID");
        sql.SqlInsertMenuOrderCategory.Parameters("@Price").Value = oRow("Price");
        sql.SqlInsertMenuOrderCategory.Parameters("@Surcharge").Value = oRow("Surcharge");
        sql.SqlInsertMenuOrderCategory.Parameters("@RoutingID").Value = oRow("RoutingID");
        sql.SqlInsertMenuOrderCategory.Parameters("@MenuIndex").Value = oRow("MenuIndex");
        sql.SqlInsertMenuOrderCategory.Parameters("@Active").Value = oRow("Active");

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            newMenuJoinID = (int)sql.SqlInsertMenuOrderCategory.ExecuteScalar();
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
            Interaction.MsgBox(ex.Message);
        }

        return newMenuJoinID;

    }

    private void UpdateModifierIndex(int mji, int newIndex)
    {

        foreach (DataRow modifierRow in dsSetup.Tables("Modifiers").Rows)
        {
            if (modifierRow("FoodID") == mji)
            {
                modifierRow("MenuIndex") = newIndex;
                break;
            }
        }

    }

    private void UpdateDrinkIndex(int mji, int newIndex)
    {

        foreach (DataRow drinkRow in dsSetup.Tables("Drinks").Rows)
        {
            if (drinkRow("DrinkID") == mji)
            {
                drinkRow("DrinkIndex") = newIndex;
                break;
            }
        }

    }

    internal void UpdateStagingPanel(int menujoinID, string name, decimal price, int fID, decimal sur, int rout, int dID, int GenMenuID, int cm)
    {

        foodPanel.Text = name;
        foodPanel.MenuJoinID = menujoinID;
        foodPanel.FoodName = name;
        foodPanel.FoodPrice = price;
        foodPanel.FoodID = fID;
        foodPanel.Surcharge = sur;
        foodPanel.RoutingID = rout;
        foodPanel.DrinkID = dID;
        foodPanel.GeneralMenuID = GenMenuID;
        foodPanel.CurrentMenu = cm;

    }

    private void PanelClick(object sender, EventArgs e)
    {
        MyPanelClick?.Invoke(sender, e);

    }

}