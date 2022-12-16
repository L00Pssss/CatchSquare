using UnityEngine;

public class ScoreCollector : MonoBehaviour
{
    private int m_Scores;

    #region Unity Events
    private void Start()
    {
        m_Scores = 0;
    }
    private void Awake()
    {
        GlobalEventManager.OnScoreAdd.AddListener(AddScores);
    }
    #endregion

    #region Methods

    public void AddScores(int scores)
    {
        m_Scores += scores;
        GlobalEventManager.UpdateScores(m_Scores);
    }
    #endregion
}