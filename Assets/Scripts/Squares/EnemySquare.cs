using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySquare : SquareBase
{
    private new AudioSource audio;

    protected override void OnStart()
    {
        audio = GetComponent<AudioSource>();
    }
    protected override void OnPointerDown(Vector3 Target)
    {
          GlobalEventManager.PlayAudioSource(audio);
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
