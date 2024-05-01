

namespace SaveDataTest
{
    internal interface ISaveData 
    {
        void Save(PlayerData player);

        PlayerData Load();
    }
}
