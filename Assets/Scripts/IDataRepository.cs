public interface IDataRepository
{
    SaveData LoadData();
    void UpdateHighestScore(SaveData data);
}