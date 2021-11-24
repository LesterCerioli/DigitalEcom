namespace DigitalEcom.Domain.Core
{
    public class District
    {
        public District() { }

        public District(long id)
        {
            Id = id;
        }

        public long StateOrProvinceId { get; private set; }

        public StateOrProvince StateOrProvince { get; private set; }

        public string Name { get; private set; }

        public string Type { get; private set; }

        public string Location { get; private set; }
    }
}