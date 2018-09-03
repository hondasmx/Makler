using System;
using System.Globalization;
using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class Player : MonoBehaviour
    {
        public GameObject moneyObject;
        public GameObject healthObject;
        public GameObject winWindow;
        public GameObject bottleObject;

        [NonSerialized] public float money = 0;
        public float health = 100.0f;

        private const float winConditionAmount = 1000000;
        private int healthPerDay;
        private int sickDaysLeft;
        private int daysWithHealthLosing;

        private int daysWithHealthLoosingStraight;
        private bool isLastDayWithIllness;

        private const int daysWithHealthLosing_max = 5;
        private const int daysWithHealthLosingStraight_max = 3;


        public bool isSick;

        private void Start()
        {
            bottleObject.SetActive(false);
            UpdateMoneyUI();
            UpdateHealthUI();
        }

        private void UpdateHealthUI()
        {
            healthObject.GetComponent<TextMeshProUGUI>().text = health.ToString();
        }

        private void UpdateMoneyUI()
        {
            var text = string.Format("{0,5:#### ###.00}", money);
            moneyObject.GetComponent<TextMeshProUGUI>().text = text;
        }

        public void DailyChangeMoneyAmount(float amount)
        {
            if (isSick)
            {
                HealUp();
            }
            else
            {
                if (money + amount < 0)
                {
                    ChangeHealthAmount(-5);
                    return;
                }

                ChangeMoneyAmount(amount);
            }
        }

        public void ChangeMoneyAmount(float amount)
        {
            money += amount;
            UpdateMoneyUI();
            CheckForTheEndGame();
        }

        private void CheckForTheEndGame()
        {
            if (money >= winConditionAmount)
            {
                Time.timeScale = 0;
                Instantiate(winWindow, transform.position, Quaternion.identity, transform);
            }
        }

        private void HealUp()
        {
            if (sickDaysLeft > 0)
            {
                bottleObject.SetActive(true);
                ChangeHealthAmount(healthPerDay);
                sickDaysLeft--;
            }

            if (sickDaysLeft == 0)
            {
                bottleObject.SetActive(false);
                isSick = false;
            }
        }

        private void ChangeHealthAmount(int amount)
        {
            health += amount;
            health = Math.Min(100, health);
            if (amount < 0)
            {
                daysWithHealthLosing++;
                if (isLastDayWithIllness)
                {
                    daysWithHealthLoosingStraight++;
                    isLastDayWithIllness = true;
                }
                else
                {
                    daysWithHealthLoosingStraight = 0;
                    isLastDayWithIllness = false;
                }
            }

            if (daysWithHealthLosing == daysWithHealthLosing_max ||
                daysWithHealthLoosingStraight == daysWithHealthLosingStraight_max)
            {
                isSick = true;
                sickDaysLeft = (int) Math.Max(5, (100 - health) / 5);
                healthPerDay = (int) ((100 - health) / sickDaysLeft);
                if ((100 - health) % 5 > 0)
                {
                    sickDaysLeft++;
                }

                daysWithHealthLosing = 0;
            }

            UpdateHealthUI();
        }
    }
}