class MapData
{
	public string PropertyName { get; set; }
	public Dictionary<string, Source> Sources { get; set; } = new();
}