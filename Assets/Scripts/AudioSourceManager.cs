using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioSourceManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    #region Unity Events

    private void Awake()
    {
        GlobalEventManager.OnAudioSourcePlay.AddListener(PlayAudioSoursceScores);
    }
    #endregion

    #region Methods

    public void PlayAudioSoursceScores()
    {
       this.audioSource.Play();
    }
    #endregion
}
