
public partial class custButton : Button
{

    private Color _backcolor;
    private int _xlocation;
    private int _ylocation;
    private int _custNumber;
    private string _text;

    private BorderStyle bStyle;

    public custButton(int cn)
    {
        bStyle = BorderStyle.FixedSingle;
        _custNumber = cn;
        _text = cn.ToString();

        Width = 15;
        Height = 15;


        _xlocation = cn * Width - Width;
        _ylocation = 0;
        Location = new Point(_xlocation, _ylocation);

        if (cn == 11)
            Width = 30; // ****  just temporary

    }

    public int custNumber
    {
        get
        {
            return _custNumber;
        }
        set
        {
            _custNumber = value;
        }
    }


    public BorderStyle BorderStyle
    {
        get
        {
            return bStyle;
        }
        set
        {
            bStyle = value;
        }
    }

    public override string Text
    {
        get
        {
            return _text;
        }
        set
        {
            _text = value;
        }
    }



}