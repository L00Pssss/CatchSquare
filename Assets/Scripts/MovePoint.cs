using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Square
{
    public class MovePoint : MonoBehaviour
    {
        [SerializeField]
        private GameObject CenterSpwner;

        [SerializeField]
        private float AngelX;
        [SerializeField]
        private float AngelY;  
        [SerializeField]
        private float AngelZ;


        private void FixedUpdate()
        {
            CenterSpwner.transform.Rotate(AngelX, AngelY, AngelZ * Time.deltaTime);
        }
    }
}