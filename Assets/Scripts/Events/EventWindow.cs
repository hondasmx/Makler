using System.Collections;
using TMPro;
using UnityEngine;

public class EventWindow : MonoBehaviour
{
    public GameObject eventText;
    private float currentTimeScale;

    private void Awake()
    {
        currentTimeScale = FindObjectOfType<Calendar>().currentGameSpeed;
    }

    public void CloseWindow()
    {
        Time.timeScale = currentTimeScale;
        Destroy(gameObject);
    }
    

    public void SetText(string text)
    {
        eventText.GetComponent<TextMeshProUGUI>().text = text;
    }
}