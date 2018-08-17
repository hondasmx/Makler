using MarqueeEvents;
using TMPro;
using UnityEngine;

public class RandomMarqueeEvents : MonoBehaviour
{
    public float speed;
    private static int currentEventNumber;
    private float startPosition;
    private float width;
    private bool instantiatedNew;

    private void Start()
    {
        GetComponent<TextMeshProUGUI>().text += RandomEvent();
        width = GetComponent<TextMeshProUGUI>().preferredWidth;
        GetComponent<RectTransform>().sizeDelta = new Vector2(width, 60);
        transform.position = new Vector3(width / 2 + Screen.width, transform.position.y);
    }

    private void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (width >= 0 && Screen.width - width / 2 >= transform.position.x && !instantiatedNew)
        {
            Instantiate(gameObject, transform.position, Quaternion.identity, transform.parent);
            instantiatedNew = true;
        }

        if (transform.position.x < -width / 2 - Screen.width / 2)
        {
            Destroy(gameObject);
        }
    }

    private string RandomEvent()
    {
        currentEventNumber++;
        if (currentEventNumber == 5)
        {
            currentEventNumber = 0;
        }

        switch (currentEventNumber)
        {
            case 0:
                return "   :::   " + new MarqueeEvent(Colors.BIR).eventText;
            case 1:
                return "   :::   " + new MarqueeEvent(Colors.BLACK).eventText;
            case 2:
                return "   :::   " + new MarqueeEvent(Colors.GREEN).eventText;
            case 3:
                return "   :::   " + new MarqueeEvent(Colors.RED).eventText;
            case 4:
                return "   :::   " + new MarqueeEvent(Colors.VIOLET).eventText;
            default:
                return null;
        }
    }
}