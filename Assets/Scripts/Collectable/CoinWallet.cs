using UnityEngine;

public class CoinWallet : MonoBehaviour
{
    private int _amount = 0;

    public void IncreaseCount()
    {
        _amount++;
        Debug.Log($"���������� �����: {_amount}");
    }
}
