using Domain;

namespace DataLayer
{
    public interface IConfigDetector
    {
        Config MakeAutoConfig();
        bool TryMakeAutoConfig(out Config config);
    }
}