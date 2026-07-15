namespace WebHMI.API.Prdb.Abstract
{
    public interface IMaterialIdType
    {
        int MeId { get; set; }
        short MesId { get; set; }
        string MeCreator { get; set; }
        string Source { get; set; }
    }
}
