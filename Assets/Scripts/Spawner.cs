using UnityEngine;

namespace Square
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject m_Prefab;

        [SerializeField]
        private float m_Rate;

        [SerializeField]
        private Transform PositionSpawn;

        private float m_GlobalTime;

        private void Update()
        {
            m_GlobalTime += Time.deltaTime;

            if (m_GlobalTime > m_Rate)
            {
                Instantiate(m_Prefab, PositionSpawn.position, Quaternion.identity);
                m_GlobalTime = 0.0f;
            }
        }


    }
}