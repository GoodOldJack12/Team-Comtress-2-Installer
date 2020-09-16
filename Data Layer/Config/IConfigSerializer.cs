using Domain;

namespace Data_Layer
{
    public interface IConfigSerializer
    {
        void Save(Config config);
        Config Load();
    }
}