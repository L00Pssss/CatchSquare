using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySquare : SquareBase
{
    protected override void OnPointerDown(Vector3 Target)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
