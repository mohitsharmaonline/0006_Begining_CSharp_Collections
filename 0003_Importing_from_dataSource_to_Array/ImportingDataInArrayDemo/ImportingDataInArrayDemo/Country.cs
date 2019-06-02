namespace ImportingDataInArrayDemo
{
    internal class Country
    {
        public int Population { get;}
        public string Name { get; }
        public string Region { get; }
        public string Code { get; }

        public Country(string name, string code, string region, int population)
        {
            Name = name;
            Code = code;
            Region = region;
            Population = population;
        }
    }
}