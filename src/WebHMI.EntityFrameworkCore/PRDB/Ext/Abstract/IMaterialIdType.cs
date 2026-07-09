namespace WebHMI.API.Prdb.Abstract
{
    public interface IMaterialIdType
    {
        int Meid { get; set; }
        short Mesid { get; set; }
        string Mecreator { get; set; }
        string Source { get; set; }
    }
}
