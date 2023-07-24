using System;

internal static partial class ControlConstants
{

    // Public oExcel As New SkySof.Excel

    public const double ssX = 800d;
    public const double ssY = 600d;
    internal static Rectangle wa = Screen.PrimaryScreen.WorkingArea;
    // Public Const ssX As Double = 800 * 0.8
    // Public Const ssY As Double = 480 * 0.8

    public const double orderPanelWidth = ssX * 0.6d;
    public const double orderPanelHeight = ssY * 0.7d;
    public const double viewOrderWidth = ssX * 0.98d;
    public const double viewOrderHeight = ssY * 0.7d;

    // Public Const entreeCategoryID As Integer = 3
    public const int buttonSpace = 4;
    public const int totalPanelButtons = 15;
    public static string totalOrderLabelString = "Check Sub Total";

    public static Color c1 = Color.PowderBlue;
    public static Color c2 = Color.AliceBlue;
    internal static Color c3 = Color.White;

    internal static Color c6 = Color.FromArgb(100, 149, 237);
    internal static Color c16 = Color.FromArgb(59, 96, 141);  // Drinks 

    public static string corpID; // = "001111"
    public static string selectedLocation;   // = "000001"
    public static string corpPhysicalLocation;
    public static bool usingDefaults; // = True
    public static DayOfWeek endOfWeek;


}