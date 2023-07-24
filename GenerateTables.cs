using System;
using System.Linq;


internal static partial class GenerateTables
{

    // Friend numberOfMainCategories As Integer
    // Friend numberOfDrinkCategories As Integer
    // Friend numberOfModifierCategories As Integer
    // Friend numberOfCategories As Integer
    // Friend maximumCategories As Integer
    internal static int numberOfMenuSelections;

    internal static DataSet dsSetup = new DataSet("Menu");
    // Friend tmrCardRead_DSB As Timer

    internal static Color cs1 = Color.PowderBlue;
    internal static Color cs2 = Color.Black;

    // Friend WithEvents sql.cn As New System.Data.SqlClient.SqlConnection("integrated security=SSPI;data source=VAIO;initial catalog=Restaurant_Server") ';User ID=VAIO\Administrator;Password=;") '("Data Source=\SC_Restaurant.sdf")

    internal static DataSet_Builder.SQLHelper sql = new DataSet_Builder.SQLHelper();
    internal static DataSet ds = new DataSet("Menu");
    // Friend dtCategory As DataTable = dsSetup.Tables.Add("Category")
    internal static DataTable dtLocationOpening = dsSetup.Tables.Add("LocationOpening");
    internal static DataTable dtMainCategory = dsSetup.Tables.Add("MainCategory");
    internal static DataTable dtModifierCategory = dsSetup.Tables.Add("ModifierCategory");
    // Friend dtMainModifierCategory As DataTable = dsSetup.Tables.Add("Main_ModifierCategory")
    internal static DataTable dtFunctions = dsSetup.Tables.Add("Functions");
    internal static DataTable dtPromotion = dsSetup.Tables.Add("Promotion");
    internal static DataTable dtPromoBSGS = dsSetup.Tables.Add("PromoBSGS");
    internal static DataTable dtPromoBSGSBuy = dsSetup.Tables.Add("PromoBSGSBuy");
    internal static DataTable dtPromoBSGSGet = dsSetup.Tables.Add("PromoBSGSGet");
    internal static DataTable dtPromoComboDetail = dsSetup.Tables.Add("PromoComboDetail");
    internal static DataTable dtPromoCombo = dsSetup.Tables.Add("PromoCombo");
    internal static DataTable dtPromoCoupon = dsSetup.Tables.Add("PromoCoupon");
    internal static DataTable dtPromoCouponDiscount = dsSetup.Tables.Add("PromoCouponDiscount");
    internal static DataTable dtPromoCouponAtleast = dsSetup.Tables.Add("PromoCouponAtleast");

    internal static DataTable dtOrderMenuDetail = dsSetup.Tables.Add("OrderMenuDetail");
    internal static DataTable dtOrderMenuDetailSecond = dsSetup.Tables.Add("OrderMenuDetailSecond");
    internal static DataTable dtOrderCategoryDetail = dsSetup.Tables.Add("OrderCategoryDetail");
    internal static DataTable dtOrderAllMenuDetail = dsSetup.Tables.Add("OrderAllMenuDetail");

    internal static DataTable dtDrinkCategory = dsSetup.Tables.Add("DrinkCategory");
    internal static DataTable dtDrink = dsSetup.Tables.Add("Drinks");
    internal static DataTable dtDrinkAdds = dsSetup.Tables.Add("DrinkAdds");
    internal static DataTable dtDrinkModifiers = dsSetup.Tables.Add("DrinkModifiers");
    internal static DataTable dtWineParring = dsSetup.Tables.Add("WineParring");
    internal static DataTable dtLiquorTypes = dsSetup.Tables.Add("LiquorTypes");
    internal static DataTable dtDrinkPrep = dsSetup.Tables.Add("DrinkPrep");
    internal static DataTable dtDrinkPrepLocation = dsSetup.Tables.Add("DrinkPrepLocation");

    internal static DataTable dtActiveEmployee = dsSetup.Tables.Add("ActiveEmployee");
    internal static DataTable dtJobCodes = dsSetup.Tables.Add("JobCodes");

    internal static DataTable dtRawCategories = dsSetup.Tables.Add("RawCategories");
    internal static DataTable dtRawMaterials = dsSetup.Tables.Add("RawMaterials");
    internal static DataTable dtRawUsageByItem = dsSetup.Tables.Add("RawUsageByItem");

    internal static DataTable dtTermGroups = dsSetup.Tables.Add("TermGroups");
    internal static DataTable dtTerminals = dsSetup.Tables.Add("Terminals");
    internal static DataTable dtTerminalsUseOrder = dsSetup.Tables.Add("TerminalsUseOrder");
    internal static DataTable dtTermsFloor = dsSetup.Tables.Add("TermsFloor");
    internal static DataTable dtTermsTables = dsSetup.Tables.Add("TermsTables");
    internal static DataTable dtTermsWalls = dsSetup.Tables.Add("TermsWalls");



    internal static DataColumn dcTempFoodJoinIndex;
    internal static DataColumn dcTempFoodCategoryJoinIndex;
    internal static DataColumn dcTempFoodModifierJoinIndex;


    internal static DataTable dtFoods = dsSetup.Tables.Add("FoodTable");
    internal static DataTable dtModifiers = dsSetup.Tables.Add("Modifiers");
    internal static DataTable dtFoodJoin = dsSetup.Tables.Add("FoodJoin");
    internal static DataTable dtJoinFoodCategoryJoins = dsSetup.Tables.Add("JoinFoodCategoryJoins");
    internal static DataTable dtJoinFoodModiferJoins = dsSetup.Tables.Add("JoinFoodModifierJoins");
    internal static DataTable dtMenuJoin = dsSetup.Tables.Add("MenuJoin");
    internal static DataTable dtMenus = dsSetup.Tables.Add("Menus");
    internal static DataTable dtMenuDetail = dsSetup.Tables.Add("MenuDetail");


    internal static int lastSelectedRouting;

    internal static DataView dvFoods = new DataView();
    internal static DataView dvFoodsJoins = new DataView();
    internal static DataView dvMainCategory = new DataView();
    internal static DataView dvMainCategoryFoodJoin = new DataView();
    internal static DataView dvDrinksByCategory = new DataView();
    internal static DataView dvDrinks = new DataView();
    // Friend dvModifierCategory As DataView = New DataView
    // Friend dvModifierJoins As DataView = New DataView

    internal static int menuJoinDragSource;
    internal static int indexDragSource;
    internal static string nameDragSource;
    internal static decimal priceDragSource;
    // .............
    internal static int foodIDDragSource;
    internal static decimal surchargeDragSource;
    internal static int routingIDDragSource;
    internal static int drinkIDDragSource;
    internal static int generalMenuIDDragSource;
    internal static int currentMenuDragSource;

    // Friend dvFood As DataView = New DataView
    // Friend dvModifier As DataView = New DataView
    // Friend dvAdjustment As DataView = New DataView
    // Friend dvDrink As DataView = New DataView
    // Friend dvFoodJoin As DataView = New DataView
    // Friend dvFreeFood As DataView = New DataView




    internal static void GenerateCategoryDataSets(ref string corpID, ref string locID)
    {

        string sqlStatement;
        string tableCreating;
        string bindingColumn;


        tableCreating = "LocationOverview";
        sqlStatement = "SELECT CompanyID, LocationID, City, State, UsingDefaults FROM LocationOverview WHERE CompanyID = '" + corpID + "' AND LocationID = '" + selectedLocation + "'";
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup);


        // we are just creating the table in order to create its structure
        tableCreating = "MenuDetail";
        sqlStatement = "SELECT MenuDetail.MenuDetailID, MenuDetail.CompanyID, MenuDetail.LocationID, MenuDetail.MenuID, MenuDetail.CategoryID, MenuDetail.DrinkCategoryID, MenuDetail.OrderIndex, Category.CategoryName, DrinkCategory.DrinkCategoryName FROM MenuDetail LEFT OUTER JOIN Category ON MenuDetail.CategoryID = Category.CategoryID LEFT OUTER JOIN DrinkCategory ON MenuDetail.DrinkCategoryID = DrinkCategory.DrinkCategoryID";
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup);


        // *** must figure out what to do with functions
        // no need to repeat them for every location
        // just repeat the taxID for each function ?????
        tableCreating = "Functions";
        sqlStatement = "SELECT FunctionID, CompanyID, LocationID, FunctionGroupID, FunctionName, FunctionFlag, TaxID, DrinkRoutingID, AlwaysReport, ReportOrder, Active FROM AABFunctions WHERE (FunctionFlag = 'F' OR FunctionFlag = 'M' OR FunctionFlag = 'O' OR FunctionFlag = 'G') AND CompanyID = '" + corpID + "' AND AABFunctions.LocationID = '" + selectedLocation + "' ORDER BY ReportOrder";
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup);

        tableCreating = "DrinkFunctions";
        sqlStatement = "SELECT FunctionID, CompanyID, LocationID, FunctionGroupID, FunctionName, FunctionFlag, TaxID, DrinkRoutingID, AlwaysReport, ReportOrder, Active FROM AABFunctions WHERE FunctionFlag = 'D' AND CompanyID = '" + corpID + "' AND AABFunctions.LocationID = '" + selectedLocation + "' ORDER BY ReportOrder";
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup);

        tableCreating = "RoutingChoice";
        sqlStatement = "SELECT RoutingID, CompanyID, LocationID, RoutingName FROM RoutingChoice WHERE CompanyID = '" + corpID + "' AND LocationID = '" + selectedLocation + "' AND (RoutingName = 'Do Not Route' OR IsServicePrinter = '1')";
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup);
        if (dsSetup.Tables("RoutingChoice").Rows.Count > 0)
        {
            lastSelectedRouting = dsSetup.Tables("RoutingChoice").Rows(0)("RoutingID");
        }
        else
        {
            lastSelectedRouting = -1;
        }

        // do not need to do by Company, the same codes for all
        tableCreating = "PrintPriority";
        sqlStatement = "SELECT PrintPriorityID, PrintPriorityName FROM PrintPriority";
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup);

        tableCreating = "TaxTable";
        sqlStatement = "SELECT TaxID, TaxName, TaxPercent FROM AABTaxTable";
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup);


        // numberOfMainCategories = GetButtonCount("Main")
        // numberOfDrinkCategories = GetButtonCount("Drink")
        // numberOfModifierCategories = GetButtonCount("Modifier")
        // numberOfCategories = (numberOfMainCategories) + numberOfDrinkCategories + numberOfModifierCategories
        // maximumCategories = GetCategoryMaximum("CategoryID", "Category")


        // bindingColumn = "CategoryAbrev"
        // tableCreating = "MainCategory"
        // sqlStatement = "SELECT Category.CompanyID, Category.LocationID, Category.CategoryID, Category.CategoryName, Category.CategoryAbrev, Category.CategoryOrder, Category.FunctionID, Category.Priority, Category.ButtonColor, Category.ButtonForeColor, Category.HalfSplit, Category.Active, Functions.FunctionGroupID, Functions.FunctionFlag FROM Category LEFT OUTER JOIN Functions ON Category.FunctionID = Functions.FunctionID WHERE (Functions.FunctionFlag = 'F' OR Functions.FunctionFlag = 'O' OR Functions.FunctionFlag = 'G') AND Category.CompanyID = '" & corpID & "' AND Category.LocationID = '" & selectedLocation & "' ORDER BY Category.Active DESC, Category.CategoryID"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        // tableCreating = "ModifierCategory"
        // sqlStatement = "SELECT Category.CompanyID, Category.LocationID, Category.CategoryID, Category.CategoryName, Category.CategoryAbrev, Category.CategoryOrder, Category.FunctionID, Category.Priority, Category.ButtonColor, Category.ButtonForeColor, Category.HalfSplit, Category.Active, Functions.FunctionGroupID, Functions.FunctionFlag FROM Category LEFT OUTER JOIN Functions ON Category.FunctionID = Functions.FunctionID WHERE Functions.FunctionFlag = 'M' AND Category.CompanyID = '" & corpID & "' AND Category.LocationID = '" & selectedLocation & "' ORDER BY Category.Active DESC, Category.CategoryID"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        // tableCreating = "Main_ModifierCategory"     ' for join tables
        // sqlStatement = "SELECT CategoryID, CategoryName FROM Category ORDER BY FunctionID"   'Panel = 'Modifier'"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        // *** need to update  currently pulling functionID > 1
        // 444     tableCreating = "Main_ModifierCategory2"     ' for grdJoinPossibleCategories
        // sqlStatement = "SELECT Category.CompanyID, Category.LocationID, Category.CategoryID, Category.CategoryName, Category.CategoryAbrev, Category.CategoryOrder, Category.FunctionID, Category.Priority, Category.ButtonColor, Category.ButtonForeColor, Category.HalfSplit, Category.Active, AABFunctions.FunctionGroupID, AABFunctions.FunctionFlag FROM Category LEFT OUTER JOIN AABFunctions ON Category.FunctionID = AABFunctions.FunctionID WHERE Category.Active = '1' AND Category.CompanyID = '" & corpID & "' AND Category.LocationID = '" & selectedLocation & "'" 'CompanyID, LocationID, CategoryID, CategoryName, FunctionID, Active FROM Category WHERE FunctionID > 1 ORDER BY FunctionID"   'Panel = 'Modifier'"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        // tableCreating = "WineParring"
        // sqlStatement = "SELECT CompanyID, LocationID, DrinkID, DrinkName FROM Drinks WHERE IsWineParring = 1 AND CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "' ORDER BY DrinkName"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        // tableCreating = "LiquorTypes"
        // sqlStatement = "SELECT CompanyID, LocationID, DrinkCategoryID, DrinkCategoryName, DrinkCategoryOrder FROM DrinkCategory WHERE IsALiquorType = 1 AND CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        // 444        tableCreating = "FoodTable"
        // sqlStatement = "SELECT CompanyID, LocationID, FoodID, FoodName, AbrevFoodName, ChitFoodName, CategoryID, FoodCost, TaxID, Foods.FoodDesc, Foods.WineParringID, PrintPriorityID, Active, PrepareTime FROM Foods WHERE CompanyID = '" & corpID & "' AND LocationID = '" & locID & "'"
        // '''''     '      sqlStatement = "SELECT Foods.FoodID, Foods.FoodName, Foods.AbrevFoodName, Foods.ChitFoodName, Foods.CategoryID, Foods.FoodCost, Foods.FoodDesc, Foods.RoutingID, Foods.TaxID, Foods.Surcharge, Foods.PrintPriorityID, Foods.Active, Category.CategoryName, RoutingChoice.RoutingName, PrintPriority.PrintPriorityName FROM Foods LEFT OUTER JOIN Category ON Foods.CategoryID = Category.CategoryID LEFT OUTER JOIN RoutingChoice ON Foods.RoutingID = RoutingChoice.RoutingID LEFT OUTER JOIN PrintPriority ON Foods.PrintPriorityID = PrintPriority.PrintPriorityID"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        // tableCreating = "FoodTableSupplement"
        // sqlStatement = "SELECT Foods.FoodID, Foods.RoutingID, Foods.PrintPriorityID, RoutingChoice.RoutingName, PrintPriority.PrintPriorityName FROM Foods LEFT OUTER JOIN RoutingChoice ON Foods.RoutingID = RoutingChoice.RoutingID LEFT OUTER JOIN PrintPriority ON Foods.PrintPriorityID = PrintPriority.PrintPriorityID"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        // 444       tableCreating = "Menus"
        // sqlStatement = "SELECT MenuID, CompanyID, LocationID, MenuName, Active FROM MenuChoice WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        // tableCreating = "MenuJoin"
        // sqlStatement = "SELECT MenuJoinID, CompanyID, LocationID, FoodID, DrinkID, MenuID, GeneralMenuID, Price, Surcharge, RoutingID, MenuIndex, Active FROM MenuJoin WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        // 444        tableCreating = "Modifiers"
        // sqlStatement = "SELECT Foods.CompanyID, Foods.LocationID, Foods.FoodID, Foods.CategoryID, Foods.FoodName, Foods.AbrevFoodName, Foods.ChitFoodName, Foods.TaxID, Foods.Surcharge, Foods.FoodDesc, Foods.PrintPriorityID, Foods.RoutingID, Foods.PrepareTime, Foods.MenuIndex, Category.FunctionID, AABFunctions.FunctionID, AABFunctions.FunctionGroupID, AABFunctions.FunctionFlag FROM Foods LEFT OUTER JOIN Category ON Foods.CategoryID = Category.CategoryID LEFT OUTER JOIN AABFunctions ON Category.FunctionID = AABFunctions.FunctionID WHERE AABFunctions.FunctionFlag = 'M' AND (Foods.CompanyID = '" & corpID & "') AND (Foods.LocationID = '" & selectedLocation & "')"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        // this is for individual modifier join 
        // 444      tableCreating = "Modifiers2"
        // sqlStatement = "SELECT Foods.CompanyID, Foods.LocationID, Foods.FoodID, Foods.CategoryID, Foods.FoodName, Foods.AbrevFoodName, Foods.ChitFoodName, Foods.TaxID, Foods.Surcharge, Foods.FoodDesc, Foods.PrintPriorityID, Foods.RoutingID, Foods.PrepareTime, Foods.MenuIndex, Category.FunctionID, AABFunctions.FunctionID, AABFunctions.FunctionGroupID, AABFunctions.FunctionFlag FROM Foods LEFT OUTER JOIN Category ON Foods.CategoryID = Category.CategoryID LEFT OUTER JOIN AABFunctions ON Category.FunctionID = AABFunctions.FunctionID WHERE AABFunctions.FunctionFlag = 'M' AND (Foods.CompanyID = '" & corpID & "') AND (Foods.LocationID = '" & selectedLocation & "')"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        // 444        tableCreating = "FoodJoin"
        // 444      sqlStatement = "SELECT CompanyID, LocationID, FoodJoinID, FoodID, CategoryID, ModifierID, NumberFree, FreeFlag, GroupFlag, GTCFlag FROM FoodJoin WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'"
        // 444      dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)
        // dcTempFoodJoinIndex = dsSetup.Tables("FoodJoin").Columns("TempFoodJoinIndex")
        // dsSetup.Tables("FoodJoin").Columns.Add("TempFoodJoinIndex")

        // 444       tableCreating = "JoinFoodCategoryJoins"
        // 444       sqlStatement = "SELECT FoodJoin.CompanyID, FoodJoin.LocationID, FoodJoin.FoodJoinID, FoodJoin.FoodID, FoodJoin.CategoryID, FoodJoin.NumberFree, FoodJoin.FreeFlag, FoodJoin.GroupFlag, FoodJoin.GTCFlag, Category.CategoryName FROM FoodJoin LEFT OUTER JOIN Category ON FoodJoin.CategoryID = Category.CategoryID WHERE FoodJoin.CompanyID = '" & corpID & "' AND FoodJoin.LocationID = '" & selectedLocation & "'"
        // 444      dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)
        // dcTempFoodJoinIndex = dsSetup.Tables("JoinFoodCategoryJoins").Columns("TempFoodJoinIndex")
        // dsSetup.Tables("JoinFoodCategoryJoins").Columns.Add("TempFoodJoinIndex")

        // 444       tableCreating = "JoinFoodModifierJoins"
        // 444      sqlStatement = "SELECT FoodJoin.CompanyID, FoodJoin.LocationID, FoodJoin.FoodJoinID, FoodJoin.FoodID, FoodJoin.NumberFree, FoodJoin.FreeFlag, FoodJoin.GroupFlag, FoodJoin.ModifierID, Foods.FoodID, Foods.CategoryID, Foods.FoodName FROM FoodJoin LEFT OUTER JOIN Foods ON FoodJoin.ModifierID = Foods.FoodID WHERE FoodJoin.CompanyID = '" & corpID & "' AND FoodJoin.LocationID = '" & selectedLocation & "'"
        // 444       dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)
        // dcTempFoodJoinIndex = dsSetup.Tables("JoinFoodModifierJoins").Columns("TempFoodJoinIndex")
        // dsSetup.Tables("JoinFoodModifierJoins").Columns.Add("TempFoodJoinIndex")

        // currently DrinkCategoryOrder is nothing
        // tableCreating = "DrinkCategory"
        // sqlStatement = "SELECT DrinkCategoryID, CompanyID, LocationID, DrinkCategoryNumber, DrinkCategoryName, DrinkCategoryOrder, ButtonColor, ButtonForeColor, IsALiquorType FROM DrinkCategory WHERE DrinkCategoryNumber > 0 AND CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "' ORDER BY DrinkCategoryNumber"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        // tableCreating = "DrinkModifiers"
        // sqlStatement = "SELECT DrinkModifierPrimaryKey, CompanyID, LocationID, DrinkModifierID, DrinkID, DrinkName, DrinkPrice FROM DrinkModifiers WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'"
        // '   ***     ***    ***   need to change
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        // tableCreating = "Promotion"
        // sqlStatement = "SELECT PromoID, CompanyID, LocationID, PromoName, BSGS, Combo, Coupon, StartDate, EndDate, MaxAmount, MaxCheck, MaxTable, TaxPromoAmount, TaxFoodCost, EstFoodCost, GuestPayTax, ManagerLevel, TipPromo, Active FROM Promotion WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "'"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        // 444
        // tableCreating = "Drink"
        // sqlStatement = "SELECT DrinkID, CompanyID, LocationID, DrinkIndex, DrinkName, DrinkCategoryID, DrinkPrice, DrinkFunctionID, DrinkDesc, DrinkAddOnChoice, IsDrinkAdd, IsWineParring, LiquorTypeID, CallPrice, AddOnPrice, Active FROM Drinks WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "' ORDER BY DrinkIndex"
        // sqlStatement = "SELECT DrinkID, CompanyID, LocationID, DrinkIndex, DrinkName, DrinkCategoryID, DrinkPrice, DrinkFunctionID, TaxID, DrinkDesc, DrinkAddOnChoice, IsDrinkAdd, IsWineParring, LiquorTypeID, AddOnPrice, CallPrice, Active, DrinkInvOn, DrinkInv FROM Drinks WHERE CompanyID = '" & corpID & "' AND LocationID = '" & selectedLocation & "' ORDER BY DrinkIndex"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        // tableCreating = "DrinkAdds"
        // sqlStatement = "SELECT DrinkAddID, DrinkAddName, DrinkAddCost FROM DrinkAdds"
        // '      dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        // tableCreating = "FreeFood"
        // sqlStatement = "SELECT FreeFoodID, FoodID, CategoryID, ModifierID, NumberFree FROM FreeFood"
        // ds = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, ds)

        // will remove
        // tableCreating = "FoodJoinModifier"
        // sqlStatement = "SELECT FoodJoin.FoodJoinID, FoodJoin.FoodID, FoodJoin.CategoryID, Modifiers.ModifierID, Modifiers.CategoryID, Modifiers.ModifierName, Modifiers.ModifierCost, Modifiers.ModifierDesc, Category.CategoryName FROM FoodJoin LEFT OUTER JOIN Modifiers ON FoodJoin.ModifierID = Modifiers.ModifierID LEFT OUTER JOIN Category ON FoodJoin.CategoryID = Category.CategoryID"
        // ds = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, ds)

        // will remove
        // tableCreating = "FreeFoodJoin"
        // sqlStatement = "SELECT FreeFood.FreeFoodID, FreeFood.FoodID, FreeFood.CategoryID, FreeFood.ModifierID, FreeFood.NumberFree, Modifiers.ModifierName, Category.CategoryName FROM FreeFood LEFT OUTER JOIN Category ON FreeFood.CategoryID = Category.CategoryID LEFT OUTER JOIN Modifiers ON FreeFood.ModifierID = Modifiers.ModifierID"
        // ds = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, ds)


        // tableCreating = "JoinFreeFoodsCategory"
        // sqlStatement = "SELECT FreeFood.FreeFoodID, FreeFood.FoodID, FreeFood.CategoryID, FreeFood.NumberFree, Category.CategoryName FROM FreeFood RIGHT OUTER JOIN Category ON FreeFood.CategoryID = Category.CategoryID"
        // ds = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, ds)
        // 
        // tableCreating = "JoinFreeFoodsModifier"
        // sqlStatement = "SELECT FreeFood.FreeFoodID, FreeFood.FoodID, FreeFood.ModifierID, FreeFood.NumberFree, Modifiers.ModifierName FROM FreeFood RIGHT OUTER JOIN Modifiers ON FreeFood.ModifierID = Modifiers.ModifierID"
        // ds = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, ds)


        // tableCreating = "PromoBSGS"
        // sqlStatement = "SELECT PromoBSGS.PromoBSGSID, PromoBSGS.CateogryID, PromoBSGS.BSGSCategoryAmount, PromoBSGS.DrinkCategoryID, PromoBSGS.BSGSDrinkCategoryAmount, Category.CategoryName, DrinkCategory.DrinkCategoryName FROM PromoBSGS"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        // numberOfMainCategories = dsSetup.Tables("MainCategory").Rows.Count
        // numberOfDrinkCategories = dsSetup.Tables("DrinkCategory").Rows.Count
        // numberOfModifierCategories = dsSetup.Tables("ModifierCategory").Rows.Count
        // numberOfCategories = (numberOfMainCategories) + numberOfDrinkCategories + numberOfModifierCategories

    }

    internal static void AddColumnsToJoinTables()
    {

        dcTempFoodJoinIndex = dsSetup.Tables("FoodJoin").Columns("TempFoodJoinIndex");
        dsSetup.Tables("FoodJoin").Columns.Add("TempFoodJoinIndex");

        dcTempFoodJoinIndex = dsSetup.Tables("JoinFoodCategoryJoins").Columns("TempFoodJoinIndex");
        dsSetup.Tables("JoinFoodCategoryJoins").Columns.Add("TempFoodJoinIndex");

        dcTempFoodJoinIndex = dsSetup.Tables("JoinFoodModifierJoins").Columns("TempFoodJoinIndex");
        dsSetup.Tables("JoinFoodModifierJoins").Columns.Add("TempFoodJoinIndex");

    }

    internal static void ClearingDataToRepopulate()
    {

        dsSetup.Tables("Menus").Clear();
        dsSetup.Tables("MenuJoin").Clear();
        dsSetup.Tables("FoodJoin").Clear();
        dsSetup.Tables("JoinFoodCategoryJoins").Clear();
        dsSetup.Tables("JoinFoodModifierJoins").Clear();

    }

    internal static void RepopulateDataSets(ref string locID)
    {

        dsSetup.Tables("Menus").Clear();
        sql.SqlSelectCommandMenuMenuChoice.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandMenuMenuChoice.Parameters("@LocationID").Value = locID;

        dsSetup.Tables("MenuJoin").Clear();
        sql.SqlSelectCommandMenuMenuJoin.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandMenuMenuJoin.Parameters("@LocationID").Value = locID;

        dsSetup.Tables("FoodJoin").Clear();
        sql.SqlSelectCommandJoinFoodJoin.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandJoinFoodJoin.Parameters("@LocationID").Value = locID;
        sql.SqlSelectCommandJoinFoodJoin.Parameters("@FoodID").Value = 0;

        dsSetup.Tables("JoinFoodCategoryJoins").Clear();
        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@LocationID").Value = locID;
        sql.SqlSelectCommandJoinFoodCategoryJoins.Parameters("@FoodID").Value = 0;

        dsSetup.Tables("JoinFoodModifierJoins").Clear();
        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@LocationID").Value = locID;
        sql.SqlSelectCommandJoinFoodModiferJoins.Parameters("@FoodID").Value = 0;

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlMenuMenuChoice.Fill(dsSetup.Tables("Menus"));
            sql.SqlMenuMenuJoin.Fill(dsSetup.Tables("MenuJoin"));
            sql.SqlJoinFoodJoin.Fill(dsSetup.Tables("FoodJoin"));
            sql.SqlJoinFoodCategoryJoins.Fill(dsSetup.Tables("JoinFoodCategoryJoins"));
            sql.SqlJoinFoodModiferJoins.Fill(dsSetup.Tables("JoinFoodModifierJoins"));
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        // ****
        // below is old, but not sure about FoodID = 0  (above)
        return;

        string sqlStatement;
        string tableCreating;

        tableCreating = "Menus";
        sqlStatement = "SELECT MenuID, CompanyID, LocationID, MenuName, Active FROM MenuChoice WHERE CompanyID = '" + corpID + "' AND LocationID = '" + locID + "'";
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup);

        tableCreating = "MenuJoin";
        sqlStatement = "SELECT MenuJoinID, CompanyID, LocationID, FoodID, DrinkID, MenuID, GeneralMenuID, Price, Surcharge, RoutingID, MenuIndex, Active FROM MenuJoin WHERE CompanyID = '" + corpID + "' AND LocationID = '" + locID + "'";
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup);

        tableCreating = "FoodJoin";
        sqlStatement = "SELECT FoodJoinID, CompanyID, LocationID, FoodID, CategoryID, ModifierID, NumberFree, FreeFlag, GroupFlag FROM FoodJoin WHERE CompanyID = '" + corpID + "' AND LocationID = '" + locID + "'";
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup);

        tableCreating = "JoinFoodCategoryJoins";
        sqlStatement = "SELECT FoodJoin.FoodJoinID, FoodJoin.CompanyID, FoodJoin.LocationID, FoodJoin.FoodID, FoodJoin.CategoryID, FoodJoin.NumberFree, FoodJoin.FreeFlag, FoodJoin.GroupFlag, Category.CategoryName FROM FoodJoin LEFT OUTER JOIN Category ON FoodJoin.CategoryID = Category.CategoryID WHERE FoodJoin.CompanyID = '" + corpID + "' AND FoodJoin.LocationID = '" + locID + "'";
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup);

        tableCreating = "JoinFoodModifierJoins";
        sqlStatement = "SELECT FoodJoin.FoodJoinID, FoodJoin.CompanyID, FoodJoin.LocationID, FoodJoin.FoodID, FoodJoin.NumberFree, FoodJoin.FreeFlag, FoodJoin.GroupFlag, FoodJoin.ModifierID, Foods.FoodID, Foods.CategoryID, Foods.FoodName FROM FoodJoin LEFT OUTER JOIN Foods ON FoodJoin.ModifierID = Foods.FoodID WHERE FoodJoin.CompanyID = '" + corpID + "' AND FoodJoin.LocationID = '" + locID + "'";
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup);

    }

    internal static void GenerateEmployeeDataSets()
    {
        string sqlStatement;
        string tableCreating;

        tableCreating = "UsedEmployeeNumber";
        sqlStatement = "SELECT EmployeeNumber FROM AAAEmployee WHERE CompanyID = '" + corpID + "' AND LocationID = '" + corpPhysicalLocation + "' ORDER BY EmployeeNumber";
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup);

        tableCreating = "TaxFilingStatus";
        sqlStatement = "SELECT FilingStatusName FROM TaxFilingStatus";
        dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup);


        dsSetup.Tables("ActiveEmployee").Clear();
        sql.SqlSelectCommandEmployeeActiveEmployee.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandEmployeeActiveEmployee.Parameters("@LocationID").Value = corpPhysicalLocation;

        dsSetup.Tables("JobCodes").Clear();
        sql.SqlSelectCommandEmployeeJobCodes.Parameters("@CompanyID").Value = corpID;
        sql.SqlSelectCommandEmployeeJobCodes.Parameters("@LocationID").Value = corpPhysicalLocation;

        sql.SqlEmployeeActiveEmployee.Fill(dsSetup.Tables("ActiveEmployee"));
        sql.SqlEmployeeJobCodes.Fill(dsSetup.Tables("JobCodes"));


        // we need to join this table with Job Code Table (for Job Names)
        // tableCreating = "ActiveEmployee"
        // sqlStatement = "SELECT EmployeeID, CompanyID, LocationID, EmployeeNumber, LastName, FirstName, MiddleName, NickName, SSN, Passcode, BirthDate, HireDate, Address1, Address2, City, State, Zip, HomePhone, CellPhone, Notes, ReportsTo, Training, Terminated, ClockInReq, ReportMgmtAll, ReportMgmtLimited, OperationMgmtAll, OperationMgmtLimited, SystemMgmtAll, SystemMgmtLimited, EmployeeMgmtAll, EmployeeMgmtLimited, JobCodeID1, JobRate1, JobCodeID2, JobRate2, JobCodeID3, JobRate3, JobCodeID4, JobRate4, JobCodeID5, JobRate5, JobCodeID6, JobRate6, JobCodeID7, JobRate7 FROM AAAEmployee WHERE Terminated = 0 AND CompanyID = '" & corpID & "' AND LocationID = '" & corpPhysicalLocation & "' ORDER BY LastName"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)

        // tableCreating = "JobCodes"
        // sqlStatement = "SELECT JobCodeID, CompanyID, LocationID, JobCodeName, Manager, Cashier, Bartender, Server, Hostess, PasswordReq, ClockInReq, ReportTipsReq, ShareTipsReq FROM AABJobCodes WHERE CompanyID = '" & corpID & "' AND LocationID = '" & corpPhysicalLocation & "' ORDER BY JobCodeName"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        // tableCreating = "JobCodeEmployee"
        // sqlStatement = "SELECT JobCodeEmployee.EmployeeID, JobCodeEmployee.JobCodeID, JobCodes.JobCodeName FROM JobCodeEmployee LEFT OUTER JOIN JobCodes ON JobCodeEmployee.JobCodeID = JobCodes.JobCodeID ORDER BY EmployeeID"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)


        // Dim index As Integer
        // tableCreating = "JobCodesIndividualEmployee"
        // For index = 1 To 7
        // sqlStatement = "SELECT Employee.EmployeeID, Employee.JobID" & index & ", Employee.Rate" & index & ", JobCodes.JobCodeName FROM Employee LEFT OUTER JOIN JobCodes ON Employee.JobID" & index & " = JobCodes.JobCodeID WHERE Employee.EmployeeID = 1234"
        // dsSetup = sql.PopulateSelectedItemTable(tableCreating, sqlStatement, dsSetup)
        // Next


    }

    internal static void SetUpPrimaryKeys()
    {

        // dsSetup.Tables("FoodTable").PrimaryKey = New DataColumn() {dsSetup.Tables("FoodTable").Columns("FoodID")}
        // dsSetup.Tables("Modifiers").PrimaryKey = New DataColumn() {dsSetup.Tables("Modifiers").Columns("FoodID")}
        dsSetup.Tables("RoutingChoice").PrimaryKey = new DataColumn[] { dsSetup.Tables("RoutingChoice").Columns("RoutingID") };

        // dsSetup.Tables("LocationOverview").PrimaryKey = New DataColumn() {dsSetup.Tables("LocationOverview").Columns("LocationID")}


    }



    internal static object GetButtonCount(ref string categoryType)
    {

        // Dim cn As System.Data.SqlClient.SqlConnection
        var cmd = default(System.Data.SqlClient.SqlCommand);
        System.Data.SqlClient.SqlDataReader dtr;
        int _numberofbuttons;

        // ***************** provider removed
        // cn = New SqlClient.SqlConnection("Data Source=\SC_Restaurant.sdf")
        sql.cn.Open();
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
        if (ReferenceEquals(categoryType, "Menus"))
        {
            cmd = new SqlClient.SqlCommand("SELECT COUNT(MenuID) panel_count From MenuChoice WHERE CompanyID = '" + corpID + "' AND LocationID = '" + selectedLocation + "'", sql.cn);
        }
        else if (ReferenceEquals(categoryType, "ActiveMenus"))
        {
            cmd = new SqlClient.SqlCommand("SELECT COUNT(MenuID) panel_count From MenuChoice WHERE CompanyID = '" + corpID + "' AND LocationID = '" + selectedLocation + "' AND Active = 1", sql.cn);
        }
        // cmd = New SqlServerCe.SqlCeCommand("SELECT COUNT(Panel) panel_count From Category WHERE Panel ='" & categoryType & "'", cn)
        dtr = cmd.ExecuteReader();

        dtr.Read();

        _numberofbuttons = Conversions.ToInteger(dtr["panel_count"]);

        dtr.Close();
        sql.cn.Close();

        return _numberofbuttons;

    }

    internal static object GetCategoryMaximum222(string idName, string tn)
    {

        // Dim cn As System.Data.SqlClient.SqlConnection
        System.Data.SqlClient.SqlCommand cmd;
        System.Data.SqlClient.SqlDataReader dtr;
        int _maxCategory;

        // until database is set
        _maxCategory = 7;
        return _maxCategory;

        // ***************** provider removed
        // cn = New SqlClient.SqlConnection("Data Source=\SC_Restaurant.sdf")
        sql.cn.Open();
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();

        cmd = new SqlClient.SqlCommand("SELECT MAX('" + idName + "') max_category From '" + tn + "'", sql.cn);
        // cmd = New SqlClient.SqlCommand("SELECT MAX(CategoryID) max_category From Modifiers", sql.cn)
        dtr = cmd.ExecuteReader();

        dtr.Read();

        _maxCategory = Conversions.ToInteger(dtr["max_category"]);

        dtr.Close();
        sql.cn.Close();

        return _maxCategory;

    }

    internal static object GetMaximumID(string idName, string tn)
    {

        System.Data.SqlClient.SqlCommand cmd;
        System.Data.SqlClient.SqlDataReader dtr;
        var _maxCategory = default(int);

        // ***************** provider removed
        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();

            cmd = new SqlClient.SqlCommand("SELECT MAX(" + idName + ") max_category From " + tn, sql.cn);
            dtr = cmd.ExecuteReader();

            dtr.Read();

            _maxCategory = Conversions.ToInteger(dtr["max_category"]);

            dtr.Close();
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

        return _maxCategory;


    }

    public static DataSet PopulateSelectedItemTable(string strSelectedCategoy, string sqlString, ref DataSet dsItem)
    {

        sql.cn.Open();
        sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
        var itemAdapter = new SqlClient.SqlDataAdapter();

        itemAdapter.TableMappings.Add("Table", strSelectedCategoy);
        var cmdItemTable = new SqlClient.SqlCommand(sqlString, sql.cn);

        itemAdapter.SelectCommand = cmdItemTable;
        itemAdapter.Fill(dsItem);

        sql.cn.Close();

        return dsItem;


    }

    internal static void CloseConnection()
    {
        if (sql.cn.State == ConnectionState.Open)
        {
            sql.cn.Close();
        }
    }

    public static void ReInitializeSQLConnection(string leusername)
    {
        string connectserver;
        if (leusername == "e" | leusername == "eGlobal")
        {
            leusername = "eglobalmain";
        }

        if (System.Windows.Forms.SystemInformation.ComputerName == "EGLOBALMAIN")
        {
            if (leusername == "eglobal")
            {
                // below makes me able to access data base on demo
                connectserver = @"eglobalmain\eglobalmain";
            }
            else
            {
                // below makes me able to access every account from my computer
                connectserver = @"Phoenix\Phoenix";
            }
        }

        else if (leusername == "rasoi2")
        {
            connectserver = @"rasoi2\rasoi2";
        }
        else
        {
            connectserver = @"Phoenix\Phoenix";
        }

        // 444     sql.cn.ConnectionString = "packet size=4096;integrated security=SSPI;Pooling=False;data source='" & connectserver & "';initial catalog=Restaurant_Server"
        sql.cn.ConnectionString = "packet size=4096;integrated security=SSPI;data source='" + connectserver + "';pe" + "rsist security info=False;Pooling=False;initial catalog=Restaurant_Server";

    }

    internal static object DetermineID(DataGrid grdUsed, int colNum)
    {
        int rowNum = grdUsed.CurrentCell.RowNumber;

        if (grdUsed.CurrentRowIndex == -1)
            return default;
        if (object.ReferenceEquals(grdUsed.Item(rowNum, colNum), DBNull.Value))
            return default;
        var valueID = default(int);

        try
        {
            valueID = (int)grdUsed.Item(rowNum, colNum);
        }
        catch (Exception ex)
        {

        }

        return valueID;

    }

    internal static object DetermineString(DataGrid grdUsed, int colNum)
    {
        int rowNum = grdUsed.CurrentCell.RowNumber;

        if (grdUsed.CurrentRowIndex == -1)
            return default;
        if (object.ReferenceEquals(grdUsed.Item(rowNum, colNum), DBNull.Value))
            return default;
        var valueName = default(string);

        try
        {
            valueName = (string)grdUsed.Item(rowNum, colNum);
        }
        catch (Exception ex)
        {

        }

        return valueName;
    }


    public static void UpdateDatabaseFoods()
    {
        DataRow oRow;
        DataSet dsChangedData;

        if (dsSetup.HasChanges)
        {
            try
            {
                sql.cn.Open();
                sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
                sql.SqlMenuFoods.Update(dsSetup, "FoodTable");
                sql.cn.Close();

                dsSetup.Tables("FoodTable").AcceptChanges();
            }
            catch (Exception ex)
            {
                // MsgBox(ex.Message)
                CloseConnection();
            }
        }

    }


    internal static void SaveUpdatedMenuOrderCategoryDetail()
    {

        try
        {
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlMenuOrderCategory.Update(dsSetup, "OrderCategoryDetail");
            sql.cn.Close();
            dsSetup.Tables("OrderCategoryDetail").AcceptChanges();
        }
        catch (Exception ex)
        {
            CloseConnection();
        }

    }

    // Friend Function PadQuotes(ByVal stringIn As String) As String
    // Try
    // PadQuotes = stringIn.Replace("'", "''")
    // Catch ex As Exception
    // '
    // End Try
    // End Function


    // 

}