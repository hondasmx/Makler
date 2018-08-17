using DefaultNamespace;
using UnityEngine;

public class GenerateCompanies : MonoBehaviour
{
    public GameObject companyPrefab;
    

    private void Start()
    {
        InstantiateCompany(18);
    }

    public void InstantiateCompany(int amount)
    {
        for (var i = 0; i < amount; i++)
        {
            var position = new Vector3(transform.position.x + 400, transform.position.y - 110);
            Instantiate(companyPrefab, position, Quaternion.identity, transform);
        }
    }

    private void Update()
    {
        CalculateMarginsAndContentHeight();
    }


    private void CalculateMarginsAndContentHeight()
    {
        transform.GetChild(0).transform.position = new Vector3(transform.position.x + 400, transform.position.y - 110);
        var childCount = transform.childCount;
        var height = 0;
        for (var i = 0; i < childCount; i++)
        {
            var compactActive = transform.GetChild(i).GetChild(0).gameObject.activeSelf;
            if (compactActive)
            {
                height += GameManager.compactHeight;
                if (i < childCount - 1)
                {
                    transform.GetChild(i + 1).transform.position =
                        transform.GetChild(i).transform.position + Vector3.down * GameManager.compactHeight;
                }
            }
            else
            {
                height += GameManager.advancedHeight;
                if (i < childCount - 1)
                {
                    transform.GetChild(i + 1).transform.position =
                        transform.GetChild(i).transform.position + Vector3.down * GameManager.advancedHeight;
                }
            }
        }

        transform.GetComponent<RectTransform>().sizeDelta = new Vector2(0, height);
    }
}