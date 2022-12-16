using UnityEngine.SceneManagement;
using UnityEngine;


namespace Square
{
    public class GameState : MonoBehaviour
    {
        public static void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}