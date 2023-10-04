using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public Text highestScoreText;
    public TMP_InputField playerName;
    private SaveData data;

    public IDataRepository dataRepository;

    // Start is called before the first frame update
    void Start()
    {
        dataRepository = new DataRepository();
        data = dataRepository.LoadData();
        if (data.HighestScore > 0)
        {
            highestScoreText.text = data.HighestRecord;
        }
        playerName.text = data.PlayerName;

        playerName.onValueChanged.AddListener((v) =>
        {
            data.PlayerName = v;
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        dataRepository.UpdateHighestScore(data);
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        dataRepository.UpdateHighestScore(data);
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
