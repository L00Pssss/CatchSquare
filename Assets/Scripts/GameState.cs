using UnityEngine.SceneManagement;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
