using UnityEngine;
using UnityEngine.UI;

namespace Platformer // Ensure this matches the namespace of your GameManager
{
    public class Coin : MonoBehaviour
    {
        [SerializeField] private QuizSO quizSO;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.GetComponent<PlayerController>() != null)
            {
                EventManager.Instance.coinEvents.CoinCollect(1);

                if (quizSO)
                {
                    Debug.Log("Entering Quiz");
                    QuizManager.Instance.EnterQuizMode(quizSO);
                }

                Destroy(gameObject);
            }
        }
    }
}