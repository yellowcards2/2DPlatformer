using TMPro;
using UnityEngine;

public class MoneyText : MonoBehaviour
{
    private TextMeshProUGUI _text;

    public int Coin { get; private set; }

    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        _text.text = Coin.ToString();
    }

    public void IncrementCoin()
    {
        Coin++;
    }
}
