using Domain;

namespace DataLayer
{
    public interface IConfigSerializer
    {
        void Save(Config config);
        Config Load();
    }
}