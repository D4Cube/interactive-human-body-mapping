namespace InteractiveHumanBody;

public class Regist
{
    public string Data1 { get; set; }
    public string Data2 { get; set; }
    public string Data3 { get; set; }
    public string Data4 { get; set; }
    public string Data5 { get; set; }
    public Image SaveImage { get; set; }

    public override string ToString()
    {
        return $"{Data5} - {Data1} - {Data4}";
    }
}