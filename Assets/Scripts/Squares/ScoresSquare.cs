using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEngine.GraphicsBuffer;

public class ScoresSquare : SquareBase
{
    [SerializeField]
    private int ScoresAmount;
    private new AudioSource audio;

    //[SerializeField]
    //private float ScoresWait;

    private ScoreCollector Score;
    protected override void OnStart()
    {
        Score = GameObject.FindObjectOfType<ScoreCollector>();

        if (Score == null)
        {
            Debug.LogError("ScoreCollectornot on the scene");
        }
        audio = GetComponent<AudioSource>();
    }

    //private IEnumerator CoroutineSqure()
    //{
    //    MovementSpeed = 0f;
    //    animator.SetTrigger("TRPressStart");
    //    yield return new WaitForSeconds(ScoresWait);
    //    transform.position = Target;
    //    animator.SetTrigger("TRPressEnd");
    //    yield return new WaitForSeconds(0.1f);
    //    MovementSpeed = 5f;

    //}
    protected override void OnPointerDown(Vector3 Target)
    {
        //StartCoroutine(CoroutineSqure());
        transform.position = Target;
        GlobalEventManager.PlayAudioSource(audio);
        GlobalEventManager.SendScoreAdd(ScoresAmount);
    }
}
