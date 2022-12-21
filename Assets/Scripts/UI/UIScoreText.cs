using UnityEngine;
using UnityEngine.UI;

namespace Square
{
    public class UIScoreText : MonoBehaviour
    {
        [SerializeField]
        private Text Text;

        private void Awake()
        {
            GlobalEventManager.UpdateScoreText.AddListener(UpdateText);
        }

        private void UpdateText(int score)
        {
            Text.text = score.ToString();
        }
    }
}