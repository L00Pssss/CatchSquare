using UnityEngine;
using UnityEngine.SceneManagement;


namespace Square
{
    public class EnemySquare : SquareBase
    {
        private AudioSource m_audio;

        protected override void OnAwake()
        {
            m_audio = GetComponent<AudioSource>();
        }
        protected override void OnPointerDown(Vector3 Target)
        {
            GlobalEventManager.PlayAudioSource(m_audio);
            //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}