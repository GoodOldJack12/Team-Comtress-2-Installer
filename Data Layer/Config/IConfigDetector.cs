using Domain;

namespace Data_Layer
{
    public interface IConfigDetector
    {
        Config MakeAutoConfig();
        bool TryMakeAutoConfig(out Config config);
    }
}