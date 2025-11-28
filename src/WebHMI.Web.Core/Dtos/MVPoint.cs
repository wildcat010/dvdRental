namespace WebHMI.Dtos
{
    public class MVPoint
    {
        public float?[] MeasuredValues { get; }
        public float Length { get; }

        public MVPoint(float length, float?[] measuredValues)
        {
            MeasuredValues = measuredValues;
            Length = length;
        }
    }
}
