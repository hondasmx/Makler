using TMPro;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Update()
    {
        var test = FindObjectsOfType<CompanyCardData>();
        var text = "";
        foreach (var a in test)
        {
            text += a.name;
            text += " - ";
            text += a.MinimumDelta();
            text += " - ";
            text += a.MaximumDelta();
            text += "\n";
        }

        GetComponent<TextMeshProUGUI>().text = text;
    }
}