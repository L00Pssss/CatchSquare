using UnityEngine;

namespace Square
{
    public abstract class SquareBase : MonoBehaviour
    {
        protected virtual void OnPointerDown(Vector3 Target) { }
        protected virtual void OnStart() { }
        protected virtual void OnAwake() { }

        private Vector3 m_Target;
        private float m_TargetX = 2.8f;
        private float m_TargetY = 5f;
        //[SerializeField]
        //protected Animator animator;
        [SerializeField] [Space(5)] [Header("Propertes")]
        private float m_MovementSpeed;

        #region Unity Events
        private void Start()
        {
            UpdateTargetPosition();
            OnStart();
        }

        private void Awake()
        {
            OnAwake();
        }

        private void OnMouseDown()
        {

            OnPointerDown(m_Target);
        }
        #endregion
        private void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, m_Target, m_MovementSpeed * Time.deltaTime);

            if (transform.position == m_Target)
            {
                UpdateTargetPosition();
            }
        }

        #region Methods
        private void UpdateTargetPosition()
        {
            m_Target.x = Random.Range(-m_TargetX, m_TargetX);
            m_Target.y = Random.Range(-m_TargetY, m_TargetY);
        }

        #endregion
    }
}