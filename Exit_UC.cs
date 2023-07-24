using System;


public partial class Exit_UC
{


    private void btnExitNoForce_Click(object sender, EventArgs e)
    {

        this.Parent.Dispose();
    }

    private void btnForceMenu_Click(object sender, EventArgs e)
    {

        try
        {
            dsSetup.Tables("LocationOpening").Rows(0)("menuChangeDate") = Strings.Format(this.DateTimePickerMenu.Value, "D");
            sql.cn.Open();
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery();
            sql.SqlLocationOpening.Update(dsSetup, "LocationOpening");
            sql.cn.Close();
        }
        catch (Exception ex)
        {
            CloseConnection();
            Interaction.MsgBox(ex.Message);
        }
        this.Parent.Dispose();

    }

    private void btnExitCancel_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }
}