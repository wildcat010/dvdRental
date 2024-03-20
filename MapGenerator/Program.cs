using Spire.Xls;
using System.Reflection;
using WebHMI;

const string filePath = @"..\..\..\mapping.xlsx";
const short worksheetIndex = 0; // worksheet index in excel file (bottom tabs)
const int rowStartIndex = 5;
const int rowEndIndex = 61;

var workbook = new Workbook();
workbook.LoadFromFile(filePath);
var worksheet = workbook.Worksheets[worksheetIndex];

var scrappedMapData = new List<MapData>();

for (int i = rowStartIndex; i <= rowEndIndex; i++)
{
	var mapData = new MapData();

	string propName = worksheet.Range[i, LetterToNumber('B')].Value;
	if (string.IsNullOrWhiteSpace(propName))
		continue;

	mapData.PropertyName = propName;

	mapData.Sources.Add("L", new Source
	{
		TableName = worksheet.Range[i, LetterToNumber('C')].Value,
		OriginalSource = worksheet.Range[i, LetterToNumber('D')].Value,
		ColumnName = worksheet.Range[i, LetterToNumber('E')].Value
	});

	mapData.Sources.Add("M", new Source
	{
		TableName = worksheet.Range[i, LetterToNumber('F')].Value,
		OriginalSource = worksheet.Range[i, LetterToNumber('G')].Value,
		ColumnName = worksheet.Range[i, LetterToNumber('H')].Value
	});

	mapData.Sources.Add("S", new Source
	{
		TableName = worksheet.Range[i, LetterToNumber('I')].Value,
		OriginalSource = worksheet.Range[i, LetterToNumber('J')].Value,
		ColumnName = worksheet.Range[i, LetterToNumber('K')].Value
	});

	// mapData.Sources.Add("P", new Source
	// {
	//     ColumnName = worksheet.Range[i, LetterToNumber('B')].Value,
	// });

	mapData.Sources.Add("E", new Source
	{
		TableName = worksheet.Range[i, LetterToNumber('O')].Value,
		OriginalSource = worksheet.Range[i, LetterToNumber('P')].Value,
		ColumnName = worksheet.Range[i, LetterToNumber('Q')].Value
	});

	//mapData.Sources.Add("Status", new Source
	//{
	//	TableName = worksheet.Range[i, LetterToNumber('B')].Value,
	//	ColumnName = worksheet.Range[i, LetterToNumber('B')].Value
	//});

	scrappedMapData.Add(mapData);
}

var assembly = typeof(WebHMIEntityFrameworkModule).Assembly;


using var getWriter = new StreamWriter(@"..\..\..\get.txt");
using var updateWriter = new StreamWriter(@"..\..\..\update.txt");

foreach (var mapData in scrappedMapData)
{
	foreach (var source in mapData.Sources)
	{
		string columnPropertyName = source.Value.ColumnName;

		// Find the DB objects with a case-insensitive search
		Type tableType = assembly.GetTypes().FirstOrDefault(t => string.Equals(t.Name, source.Value.TableName, StringComparison.OrdinalIgnoreCase));

		if (tableType is not null)
		{
			PropertyInfo columnProperty = tableType.GetProperty(source.Value.ColumnName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);

			if (columnProperty is not null)
			{
				columnPropertyName = columnProperty.Name;
			}
			else
			{
				Console.WriteLine($"Column property for '{source.Value.ColumnName}' not found in '{tableType.Name}'");
			}
		}
		else
		{
			Console.WriteLine($"Table class for '{source.Value.TableName}' not found");
		}

		// Update mappings
		if (source.Key == "Status")
		{
			getWriter.Write($"result.Data.{mapData.PropertyName}.{source.Key} = dataBlob.{source.Value.TableName}?.{source.Value.ColumnName};\n");
			continue;
		}

		getWriter.Write($"result.Data.{mapData.PropertyName}.{source.Key} = dataBlob.{source.Value.TableName}s.FirstOrDefault(x => x.Source == \"{source.Value.OriginalSource}\")?.{columnPropertyName};\n");

		if (source.Key == "M")
			updateWriter.Write($"{source.Value.TableName}.{columnPropertyName} = input.DtoProperty.{mapData.PropertyName}.M;\n");
	}

	getWriter.Write('\n');
}

static int LetterToNumber(char letter)
{
	if (letter < 'A' || letter > 'Z')
		throw new ArgumentOutOfRangeException(nameof(letter), "Letter must be an uppercase A-Z");

	return letter - 'A' + 1;
}