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

    private void FixedUpdate()
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

    private static string RandomEvent()
    {
        currentEventNumber++;
        if (currentEventNumber == 5)
        {
            currentEventNumber = 0;
        }

        MarqueeEvent _event;
        switch (currentEventNumber)
        {
            case 0:
                _event = new MarqueeEvent(Colors.BIR);
                if (_event.isGenerated)
                {
                    return "   :::   " + _event.eventText;
                }

                return "";

            case 1:
                _event = new MarqueeEvent(Colors.BLACK);
                if (_event.isGenerated)
                {
                    return "   :::   " + _event.eventText;
                }

                return "";
            case 2:
                _event = new MarqueeEvent(Colors.GREEN);
                if (_event.isGenerated)
                {
                    return "   :::   " + _event.eventText;
                }

                return "";
            case 3:
                _event = new MarqueeEvent(Colors.RED);
                if (_event.isGenerated)
                {
                    return "   :::   " + _event.eventText;
                }

                return "";
            case 4:
                _event = new MarqueeEvent(Colors.VIOLET);
                if (_event.isGenerated)
                {
                    return "   :::   " + _event.eventText;
                }

                return "";
            default:
                return null;
        }
    }
}