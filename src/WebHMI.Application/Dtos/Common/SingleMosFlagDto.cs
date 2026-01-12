namespace WebHMI.Dtos.Common
{
    public class SingleMosFlagDto
    {
        public SingleMosFlagDto() { }

        public SingleMosFlagDto(string name, short value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public short Value { get; set; }
    }
}
