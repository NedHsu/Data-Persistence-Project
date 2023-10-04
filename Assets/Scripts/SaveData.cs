[System.Serializable]
public class SaveData
{
    public int HighestScore;
    public string HighestName;
    public string PlayerName;
    public string HighestRecord { get { return $"Best Score: {HighestName}: {HighestScore}"; } }
}