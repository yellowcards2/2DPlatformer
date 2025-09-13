using TMPro;
using UnityEngine;
using System;

public class MoneyText : MonoBehaviour
{
    private TextMeshProUGUI _text;

    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void UpdateCoinText(int coins)
    {
        _text.text = coins.ToString();
    }

    private void OnEnable()
    {
        Player player = FindAnyObjectByType<Player>();

        if (player != null)
        {
            player.onCoinPicked += UpdateCoinText;
        }
    }


    private void OnDisable()
    {
        Player player = FindAnyObjectByType<Player>();

        if (player != null)
        {
            player.onCoinPicked -= UpdateCoinText;
        }
    }
}
