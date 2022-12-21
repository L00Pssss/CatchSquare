using UnityEngine;

namespace Square
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioSourceManager : MonoBehaviour
    {
        #region Unity Events

        private void Awake()
        {
            GlobalEventManager.OnAudioSourcePlay.AddListener(PlayAudioSoursceScores);
        }
        #endregion

        #region Methods

        public void PlayAudioSoursceScores(AudioSource audio)
        {
            audio.Play();
        }
        #endregion
    }
}