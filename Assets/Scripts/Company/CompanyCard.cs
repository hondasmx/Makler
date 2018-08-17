using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CompanyCard : MonoBehaviour
{
    //References
    [SerializeField] private GameObject flag;
    [SerializeField] private GameObject background;
    [SerializeField] private GameObject icon;
    [SerializeField] internal Colors color;
    //Names
    [SerializeField] private GameObject fullName;
    [SerializeField] private GameObject compactName;
    public Company companyName;
    private Sprite companyIcon;
    private Sprite companyBackground;
    private Sprite companyFlag;

    //Available slots for every color
    private static readonly Dictionary<Colors, int> colors = new Dictionary<Colors, int>
    {
        {Colors.BIR, 3},
        {Colors.BLACK, 3},
        {Colors.BLUE, 3},
        {Colors.GREEN, 3},
        {Colors.RED, 3},
        {Colors.VIOLET, 3}
    };

    private readonly Company[] blueCompanies =
    {
        new Company("Nordic", "fish"),
        new Company("Ecvadoro", "fish"),
        new Company("Barents", "fish"),
        new Company("Atlantic", "bounty"),
        new Company("Sea", "food"),
        new Company("Tasty", "fish")
    };
    private readonly Company[] redCompanies =
    {
        new Company("Pifa", "cosmetic"),
        new Company("Elonia", ""),
        new Company("Rina", ""),
        new Company("Taingua", ""),
        new Company("Meloni", ""),
        new Company("Eva", "")
    };
    private readonly Company[] greenCompanies =
    {
        new Company("Eco", "frut"),
        new Company("Eco", "plast"),
        new Company("Dora", "corp"),
        new Company("Tosti", ""),
        new Company("Bubba", ""),
        new Company("Green", "land")
    };
    private readonly Company[] birCompanies =
    {
        new Company("Duki", ""),
        new Company("Mapi", "electronics"),
        new Company("Media", "group"),
        new Company("Logic+", ""),
        new Company("Radiola", ""),
        new Company("Zaza", "technics")
    };
    private readonly Company[] blackCompanies =
    {
        new Company("Global", "industries"),
        new Company("Riva", "moto"),
        new Company("Gska", "mineral"),
        new Company("Torid", "mineral"),
        new Company("Carpaki", "industries"),
        new Company("Orika", "group")
    };
    private readonly Company[] violetCompanies =
    {
        new Company("Oil", "corporation"),
        new Company("Brelly", ""),
        new Company("Oil", "trend"),
        new Company("BK", "group"),
        new Company("MoLID", "corporation"),
        new Company("Bri Oil", "group")
    };


    private void Awake()
    {
        //Generate random color for current Company
        var colorArray = Enum.GetValues(typeof(Colors));
        do
        {
            var rand = Random.Range(0, colorArray.Length);
            color = (Colors) colorArray.GetValue(rand);
        } while (colors[color] == 0);

        colors[color] -= 1;

        //Generate random name for current Company color
        do
        {
            companyName = CompanyName();
        } while (GameObject.Find(companyName.FullName()) != null);

        SetIcons();
        SetNames();
        transform.name = companyName.FullName();
    }


    private void OnDestroy()
    {
        colors[color] += 1;
    }

    private void SetIcons()
    {
        companyIcon = AllIcons.RandomCompanyIcon(color, colors[color]);
        companyBackground = AllIcons.CompanyBackground(color);
        companyFlag = AllIcons.CompanyFlag(color);
        flag.GetComponent<Image>().sprite = companyFlag;
        background.GetComponent<Image>().sprite = companyBackground;
        icon.GetComponent<Image>().sprite = companyIcon;
    }

    private void SetNames()
    {
        fullName.GetComponent<TextMeshProUGUI>().text = companyName.ToString();
        compactName.GetComponent<TextMeshProUGUI>().text = companyName.firstName;
    }

    private Company CompanyName()
    {
        var rand = Random.Range(0, 5);
        switch (color)
        {
            case Colors.RED:
                return redCompanies[rand];
            case Colors.GREEN:
                return greenCompanies[rand];
            case Colors.VIOLET:
                return violetCompanies[rand];
            case Colors.BLACK:
                return blackCompanies[rand];
            case Colors.BIR:
                return birCompanies[rand];
            case Colors.BLUE:
                return blueCompanies[rand];
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void SetHeight(float amount)
    {
        GetComponent<RectTransform>().sizeDelta = new Vector2(800, amount);
    }
}