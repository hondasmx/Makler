using System;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class CompanyCardData : MonoBehaviour
{
    public GameObject startPriceObjectCompact;
    public GameObject startPriceObjectAdvanced;
    public GameObject currentPriceObjectCompact;
    public GameObject currentPriceObjectAdvanced;
    public GameObject currentPricePercentObjectCompact;
    public GameObject currentPricePercentObjectAdvanced;
    public GameObject stocksCountObjectCompact;
    public GameObject stocksCountObjectAdvanced;
    public GameObject avgPriceObject;
    public GameObject stockPriceDeltaObject;
    public GameObject totalValueObject;

    private float minimumStartPrice;
    private float maximumStartPrice;

    private Player player;

    private float startPrice;
    private float currentPrice;
    public int stocksCount;
    [SerializeField] private float moneySpent;
    [SerializeField] private float avgPrice;
    private float currentPriceDelta;
    private float currentPriceDeltaPercent;

    public List<DeltaModifier> deltaModifiers = new List<DeltaModifier>();

    private void Start()
    {
        player = FindObjectOfType<Player>();
        GenerateInitialValues();
        currentPrice = startPrice;
        UpdateUI();
    }

    public void StartNewDay()
    {
        CheckForModifierToDisappear();
        startPrice = currentPrice;
    }

    public void UpdatePrice()
    {
        currentPrice = Random.Range(startPrice * MinimumDelta(), startPrice * MaximumDelta());
        if (currentPrice <= 1.0f)
        {
            Destroy(gameObject);
        }

        UpdateUI();
    }

    private void CheckForModifierToDisappear()
    {
        foreach (var deltaModifier in deltaModifiers)
        {
            deltaModifier.days -= 1;
        }

        deltaModifiers = deltaModifiers.FindAll(modifier => modifier.days != 0);
    }

    private float CalculateDelta()
    {
        var result = 0f;
        foreach (var deltaModifier in deltaModifiers)
        {
            result += deltaModifier.value;
        }

        return result;
    }

    public float MaximumDelta()
    {
        return CalculateDelta() > 0 ? GameManager.maximumDelta + CalculateDelta() : GameManager.maximumDelta;
    }

    public float MinimumDelta()
    {
        return CalculateDelta() < 0 ? GameManager.minimumDelta + CalculateDelta() : GameManager.minimumDelta;
    }

    #region Buttons

    //Button Buy stocks
    public void BuyStocks(int amount)
    {
        if (player.isSick) return;
        if (currentPrice * amount <= player.money)
        {
            moneySpent += currentPrice * amount;
            player.ChangeMoneyAmount(-currentPrice * amount);
            stocksCount += amount;
        }
        else
        {
            while (player.money >= currentPrice)
            {
                player.ChangeMoneyAmount(-currentPrice);
                moneySpent += currentPrice;
                stocksCount++;
            }
        }

        UpdateUI();
    }

    //Button Sell stocks
    public void SellStocks(int amount)
    {
        if (player.isSick) return;
        if (amount > stocksCount)
        {
            player.ChangeMoneyAmount(currentPrice * stocksCount);
            stocksCount = 0;
            moneySpent = 0;
        }
        else
        {
            stocksCount -= amount;
            moneySpent -= currentPrice * amount;
            player.ChangeMoneyAmount(currentPrice * amount);
        }

        UpdateUI();

    }

    #endregion

    private void GenerateInitialValues()
    {
        var color = GetComponent<CompanyCard>().color;
        switch (color)
        {
            case Colors.RED:
                minimumStartPrice = 150;
                maximumStartPrice = 180;
                break;
            case Colors.GREEN:
                minimumStartPrice = 50;
                maximumStartPrice = 60;
                break;
            case Colors.VIOLET:
                minimumStartPrice = 300;
                maximumStartPrice = 350;
                break;
            case Colors.BLACK:
                minimumStartPrice = 220;
                maximumStartPrice = 260;
                break;
            case Colors.BIR:
                minimumStartPrice = 100;
                maximumStartPrice = 120;
                break;
            case Colors.BLUE:
                minimumStartPrice = 70;
                maximumStartPrice = 90;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        startPrice = Random.Range(minimumStartPrice, maximumStartPrice);
    }

    #region Values

    //3) Текущий курс акции (на данный момент) в условных единицах.
    private string CurrentPriceDelta()
    {
        return ColoredText(Math.Round(currentPrice - startPrice, 1));
    }

    //4) Текущий курс акции (на данный момент) в процентах.
    private string CurrentPriceDeltaPercent()
    {
        return ColoredText(Math.Round((currentPrice - startPrice) / startPrice * 100, 1), true);
    }

    //5) Количество акций у игрока (если их число = 0, то ничего не пишется).
    private string StocksCount()
    {
        if (stocksCount == 0)
        {
            moneySpent = 0;
        }

        return stocksCount == 0 ? "" : stocksCount.ToString();
    }

    //6) Стоимость одной акции (среднее арифметическое) на момент покупки игроком.

    private string AvgPrice()
    {
        avgPrice = stocksCount != 0 ? moneySpent / stocksCount : 0;
        return Math.Round(avgPrice, 2).ToString();
    }

    //7) Курс акции относительно цены покупки игроком.
    private string StockPriceDelta()
    {
        var price = avgPrice != 0 ? currentPrice - avgPrice : 0;
        return ColoredText(Math.Round(price, 2));
    }

    //8) Возможная прибыль/убыток, относительно всех акций этой компании на руках игрока.
    private string TotalValue()
    {
        return ColoredText(Math.Round(currentPrice * stocksCount - moneySpent, 1));
    }

    #endregion

    private string ColoredText(double price, bool percent = false)
    {
        var priceStr = price.ToString();
        if (percent)
        {
            priceStr += "%";
        }

        if (price > 0)
        {
            return "<color=" + AllColors.greenColor + ">+" + priceStr + "</color>";
        }

        if (price == 0)
        {
            return "<color=" + AllColors.defaultColor + ">" + 0 + "</color>";
        }

        return "<color=" + AllColors.redColor + ">" + priceStr + "</color>";
    }

    private void UpdateUI()
    {
        startPriceObjectCompact.GetComponent<TextMeshProUGUI>().text = Math.Round(startPrice).ToString();
        startPriceObjectAdvanced.GetComponent<TextMeshProUGUI>().text = Math.Round(startPrice).ToString();
        currentPriceObjectCompact.GetComponent<TextMeshProUGUI>().text = CurrentPriceDelta();
        currentPriceObjectAdvanced.GetComponent<TextMeshProUGUI>().text = CurrentPriceDelta();
        currentPricePercentObjectCompact.GetComponent<TextMeshProUGUI>().text = CurrentPriceDeltaPercent();
        currentPricePercentObjectAdvanced.GetComponent<TextMeshProUGUI>().text = CurrentPriceDeltaPercent();
        stocksCountObjectCompact.GetComponent<TextMeshProUGUI>().text = StocksCount();
        stocksCountObjectAdvanced.GetComponent<TextMeshProUGUI>().text = StocksCount();
        avgPriceObject.GetComponent<TextMeshProUGUI>().text = AvgPrice();
        stockPriceDeltaObject.GetComponent<TextMeshProUGUI>().text = StockPriceDelta();
        totalValueObject.GetComponent<TextMeshProUGUI>().text = TotalValue();
    }
}