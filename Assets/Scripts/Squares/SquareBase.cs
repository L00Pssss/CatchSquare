using UnityEngine;

public abstract class SquareBase : MonoBehaviour
{
    protected virtual void OnPointerDown(Vector3 Target) { }
    protected virtual void OnStart() { }

    protected Vector3 Target;
    private float TargetX = 2.8f;
    private float TargetY = 5f;
    [SerializeField]
    protected Animator animator;
    [SerializeField]
    protected float MovementSpeed;



    #region Unity Events
    private void Start()
    {
        UpdateTargetPosition();
        OnStart();
    }

    private void OnMouseDown()
    {
        
        OnPointerDown(Target);    
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