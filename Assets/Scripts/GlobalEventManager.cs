using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManager : MonoBehaviour
{
    public static UnityEvent<int> OnScoreAdd = new();
    public static UnityEvent<int> UpdateScoreText = new();
    public static UnityEvent<AudioSource> OnAudioSourcePlay = new();
    public static UnityEvent OnAudioGameOver = new();

    public static void SendScoreAdd(int remeiningCount)
    {
        OnScoreAdd.Invoke(remeiningCount);
    }

    public static void UpdateScores(int Score)
    {
        UpdateScoreText.Invoke(Score);
    }

    public static void PlayAudioSource(AudioSource audio)
    {
        OnAudioSourcePlay.Invoke(audio);
    }
    public static void PlayAudioGameOver()
    {
        OnAudioGameOver.Invoke();
    }
}