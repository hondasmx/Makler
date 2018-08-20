using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class Player : MonoBehaviour
    {
        public GameObject moneyObject;
        public GameObject healthObject;

        public float money = 100000;
        public float health = 100.0f;

        private void Start()
        {
            UpdateMoneyUI();
            UpdateHealthUI();
        }

        private void UpdateHealthUI()
        {
            healthObject.GetComponent<TextMeshProUGUI>().text = health.ToString();
        }

        private void UpdateMoneyUI()
        {
            moneyObject.GetComponent<TextMeshProUGUI>().text = money.ToString();
        }

        public void ChangeMoneyAmount(float amount)
        {
            money += amount;
            UpdateMoneyUI();
        }

        public void ChangeHealthAmount(int amount)
        {
            health += amount;
            UpdateHealthUI();
        }
    }
}