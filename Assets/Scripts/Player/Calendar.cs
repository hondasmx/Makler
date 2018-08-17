using System;
using System.Collections;
using Boo.Lang;
using DefaultNamespace;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Calendar : MonoBehaviour
{
    private readonly int[] daysInMonth =
    {
        31, 28, 31,
        30, 31, 30,
        31, 31, 30,
        31, 30, 31
    };

    private int currentMonth;
    private int currentDay = 1;

    private float dayInSeconds;
    private readonly int[] gameSpeed = {1, 2, 5, 0};
    public int currentGameSpeed;

    private Player player;

    //Events
    private int daysWithoutEvent;

    private int eventsPasses;

    //References
    public GameObject dayProgressObject;
    public GameObject gameSpeedObject;
    public GameObject currentDayObject;
    public GameObject currentMonthObject;

    private float timeSinceTick;

    private void Start()
    {
        currentGameSpeed = gameSpeed[0];
        Time.timeScale = currentGameSpeed;
        SetGameSpeedText();
        SetCurrentDateText();
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        dayInSeconds += Time.deltaTime;
        dayProgressObject.GetComponent<Image>().fillAmount = dayInSeconds / GameManager.dayLength;
        timeSinceTick += Time.deltaTime;
        if (timeSinceTick >= 2)
        {
            timeSinceTick -= 2;
            var companies = FindObjectsOfType<CompanyCardData>();
            foreach (var company in companies)
            {
                company.UpdatePrice();
            }
        }

        if (dayInSeconds >= GameManager.dayLength)
        {
            StartNewDay();
        }
    }


    //Button
    public void ChangeGameSpeed()
    {
        var index = Array.IndexOf(gameSpeed, currentGameSpeed);
        if (index != 3)
        {
            currentGameSpeed = gameSpeed[index + 1];
            Time.timeScale = currentGameSpeed;
        }
        else
        {
            currentGameSpeed = gameSpeed[0];
            Time.timeScale = currentGameSpeed;
        }

        SetGameSpeedText();
    }


    private void SetGameSpeedText()
    {
        gameSpeedObject.GetComponent<TextMeshProUGUI>().text = "x" + currentGameSpeed;
    }

    private static void CheckNumberOfCompanies()
    {
        var amount = FindObjectsOfType<CompanyCard>().Length;
        FindObjectOfType<GenerateCompanies>().InstantiateCompany(18 - amount);
    }

    private void StartNewDay()
    {
        CheckNumberOfCompanies();
        CheckForRandomEvent();
        player.ChangeMoneyAmount(-10);
        dayInSeconds = 0;
        currentDay += 1;
        if (daysInMonth[currentMonth] < currentDay)
        {
            currentMonth += 1;
            currentDay = 1;
        }

        if (currentMonth == 12)
        {
            EndGame();
        }

        SetCurrentDateText();
        var companies = FindObjectsOfType<CompanyCardData>();
        foreach (var company in companies)
        {
            company.StartNewDay();
        }
    }

    private void SetCurrentDateText()
    {
        currentDayObject.GetComponent<TextMeshProUGUI>().text = currentDay.ToString();
        currentMonthObject.GetComponent<TextMeshProUGUI>().text = Months(currentMonth);
    }

    private static string Months(int month)
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return new[]
                {
                    "января", "февраля", "марта",
                    "апреля", "мая", "июня",
                    "июля", "августа", "сентября",
                    "октября", "ноября", "декабря"
                }[month];
            case Language.UKRAIN:
                return new[]
                {
                    "января", "февраля", "марта",
                    "апреля", "мая", "июня",
                    "июля", "серпня", "сентября",
                    "октября", "ноября", "декабря"
                }[month];
            case Language.GERMAN:
                return new[]
                {
                    "января", "февраля", "марта",
                    "апреля", "мая", "июня",
                    "июля", "августа", "сентября",
                    "октября", "ноября", "декабря"
                }[month];
            case Language.ENGLISH:
                return new[]
                {
                    "january", "febuary", "march",
                    "april", "may", "june",
                    "july", "august", "september",
                    "october", "november", "december"
                }[month];
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void CheckForRandomEvent()
    {
        //Events are started every 2 months
        if (currentMonth < eventsPasses)
        {
            return;
        }

        daysWithoutEvent += 1;
        var daysInTwoMonth = daysInMonth[eventsPasses] + daysInMonth[eventsPasses + 1];
        var rand = Random.Range(1, daysInTwoMonth);
        if (rand <= daysWithoutEvent)
        {
            FindObjectOfType<RandomEvents>().RandomEvent();
            eventsPasses += 2;
            daysWithoutEvent = 0;
        }
    }

    private void EndGame()
    {
        Time.timeScale = 0;
        //TODO 
    }
}