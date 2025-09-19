using UnityEngine;

public class CoinDetectror : MonoBehaviour
{
    private CoinWallet _coinWallet;

    private void Awake()
    {
        _coinWallet = GetComponent<CoinWallet>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Coin>(out Coin coin))
        {
            _coinWallet.IncreaseCount();
            Destroy(coin.gameObject);
        }
    }
}
