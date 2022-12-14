using UnityEngine;

public class ScoreCollector : MonoBehaviour
{
    private int Scores;

    #region Unity Events
    private void Start()
    {
        Scores = 0;
    }

    private void Awake()
    {
        GlobalEventManager.OnScoreAdd.AddListener(AddScores);
    }
    #endregion

    #region Methods

    public void AddScores(int scores)
    {
        Scores += scores;
        GlobalEventManager.UpdateScores(Scores);
    }
    #endregion
}