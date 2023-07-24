using System.Diagnostics;
using System.Runtime.CompilerServices;

public partial class PromoData : System.Windows.Forms.UserControl
{

    #region  Windows Form Designer generated code 

    public PromoData() : base()
    {

        // This call is required by the Windows Form Designer.
        InitializeComponent();

        // Add any initialization after the InitializeComponent() call
        ReInitializeSQLConnection();

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
    private System.Data.SqlClient.SqlConnection _SqlConnection1;

    internal virtual System.Data.SqlClient.SqlConnection SqlConnection1
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _SqlConnection1;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _SqlConnection1 = value;
        }
    }
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        _SqlConnection1 = new System.Data.SqlClient.SqlConnection();
        // 
        // SqlConnection1
        // 
        _SqlConnection1.ConnectionString = "workstation id=VAIO;packet size=4096;integrated security=SSPI;data source=VAIO;pe" + "rsist security info=False;initial catalog=Restaurant_Server";
        // 
        // PromoData
        // 
        this.Name = "PromoData";

    }

    private void ReInitializeSQLConnection()
    {
        string connectserver;

        // connectServer = "localhost"
        connectserver = @"LABMAIN\labmain";
        // connectServer = "vaio"
        // connectServer = "Phoenix"
        if (System.Windows.Forms.SystemInformation.ComputerName == "VAIO")
        {
            connectserver = "vaio";
        }
        // 
        // SqlConnection1
        // 

        SqlConnection1.ConnectionString = "packet size=4096;integrated security=SSPI;data source='" + connectserver + "';pe" + "rsist security info=False;initial catalog=Restaurant_Server";

    }

    #endregion



}