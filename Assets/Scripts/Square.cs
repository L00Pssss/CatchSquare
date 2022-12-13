using UnityEngine;

public class Square : MonoBehaviour
{
    private Vector3 Target;

    private float TargetX = 2.8f;
    private float TargetY = 5f;

    [SerializeField]
    private float MovementSpeed;

    #region Unity Events
    private void Start()
    {
        UpdateTargetPosition();
    }

    private void OnMouseDown()
    {
        transform.position = Target;
        GlobalEventManager.SendScoreAdd(2);
    }
    #endregion
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target, MovementSpeed * Time.deltaTime);

        if (transform.position == Target)
        {
            UpdateTargetPosition();
        }
    }

    #region Methods
    private void UpdateTargetPosition()
    {
        Target.x = Random.Range(-TargetX, TargetX);
        Target.y = Random.Range(-TargetY, TargetY);
    }

    #endregion
}
