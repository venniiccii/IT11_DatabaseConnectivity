using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    [Header("Coin UI")]
    [SerializeField] private TextMeshProUGUI coinTxt;

    private void Start()
    {
        if (StatsManager.Instance != null)
        {
            coinTxt.text = $"x {StatsManager.Instance.GetCoins()}";
        }
    }

    private void OnEnable()
    {
        if (EventManager.Instance != null)
        {
            EventManager.Instance.coinEvents.OnCoinChangeValue += CoinEvents_OnCoinChangeValue;
        }
    }

    private void OnDisable()
    {
        if (EventManager.Instance != null)
        {
            EventManager.Instance.coinEvents.OnCoinChangeValue -= CoinEvents_OnCoinChangeValue;
        }
    }

    private void CoinEvents_OnCoinChangeValue(int obj)
    {
        coinTxt.text = $"x {obj}";
    }
}
