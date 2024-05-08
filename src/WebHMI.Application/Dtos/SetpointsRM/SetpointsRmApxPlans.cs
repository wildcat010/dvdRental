namespace WebHMI.Dtos.SetpointsRM
{
    public class SetpointsRmApxPlans
    {
        public SourceSet<int?> Shifting { get; set; } = new();
        public SourceSet<int?> Flatness { get; set; } = new();
    }
}