using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CardMovement : MonoBehaviour
{
    private Image image;

    // Use this for initialization
    private void Start()
    {
        image = GetComponent<Image>();
        var xPosition = Random.Range(Screen.width, 0);
        var yPosition = Random.Range(Screen.height, 0);
		transform.position  = new Vector3(xPosition, yPosition);
        StartCoroutine("RotateCard");
    }

    private IEnumerator RotateCard()
    {
        while (image.color.a <= 1.0f)
        {
            image.color += new Color(0, 0, 0, 0.02f);
            gameObject.transform.Rotate(new Vector3(0, 0, 1));
            gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
            yield return new WaitForSeconds(0.01f);
        }
        Destroy(gameObject);
    }
}
