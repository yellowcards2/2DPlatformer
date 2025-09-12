using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private MoneyText _moneyText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _moneyText.IncrementCoin();
            Destroy(gameObject);
        }
    }
}
