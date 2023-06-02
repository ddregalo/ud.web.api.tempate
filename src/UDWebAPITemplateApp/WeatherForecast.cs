namespace UDWebAPITemplateApp
{
    public record MyRecord(string Name, int Age);
    public record WeatherForecast
    {
        public DateTime Date { get; init; }

        public int TemperatureC { get; init; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; init; }

        public void CreateRecord()
        {
            var myRecord = new MyRecord("Joao", 21);
            var recordCopy = myRecord with { Name = "Daniel" };
        }
    }
}