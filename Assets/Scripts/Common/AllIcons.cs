using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AllIcons : MonoBehaviour
{
    //Music and sound
    public static readonly Sprite musicOn = Resources.Load<Sprite>("Images/Settings/MusicOn");
    public static readonly Sprite musicOff = Resources.Load<Sprite>("Images/Settings/MusicOff");
    public static readonly Sprite soundOn = Resources.Load<Sprite>("Images/Settings/SoundOn");
    public static readonly Sprite soundOff = Resources.Load<Sprite>("Images/Settings/SoundOff");

    //Languages
    public static readonly Sprite german = Resources.Load<Sprite>("Images/Languages/German");
    public static readonly Sprite russian = Resources.Load<Sprite>("Images/Languages/Russian");
    public static readonly Sprite ukr = Resources.Load<Sprite>("Images/Languages/Ukrain");
    public static readonly Sprite chinese = Resources.Load<Sprite>("Images/Languages/Chinese");
    public static readonly Sprite english = Resources.Load<Sprite>("Images/Languages/English");

    //Blue 
    private static readonly Sprite blueFlag = Resources.Load<Sprite>("Images/Companies/Blue/BlueFlag");
    private static readonly Sprite blueBackground = Resources.Load<Sprite>("Images/Companies/Blue/BlueBackground");
    private static readonly Sprite blue1 = Resources.Load<Sprite>("Images/Companies/Blue/blue1");
    private static readonly Sprite blue2 = Resources.Load<Sprite>("Images/Companies/Blue/blue2");
    private static readonly Sprite blue3 = Resources.Load<Sprite>("Images/Companies/Blue/blue3");
    private static readonly Sprite blue4 = Resources.Load<Sprite>("Images/Companies/Blue/blue4");
    private static readonly Sprite blue5 = Resources.Load<Sprite>("Images/Companies/Blue/blue5");
    private static readonly Sprite blue6 = Resources.Load<Sprite>("Images/Companies/Blue/blue6");
    private static readonly Sprite[] blues = {blue1, blue2, blue3, blue4, blue5, blue6};

    //Bir
    private static readonly Sprite birFlag = Resources.Load<Sprite>("Images/Companies/Bir/BirFlag");
    private static readonly Sprite birBackground = Resources.Load<Sprite>("Images/Companies/Bir/BirBackground");
    private static readonly Sprite bir1 = Resources.Load<Sprite>("Images/Companies/Bir/bir1");
    private static readonly Sprite bir2 = Resources.Load<Sprite>("Images/Companies/Bir/bir2");
    private static readonly Sprite bir3 = Resources.Load<Sprite>("Images/Companies/Bir/bir3");
    private static readonly Sprite bir4 = Resources.Load<Sprite>("Images/Companies/Bir/bir4");
    private static readonly Sprite bir5 = Resources.Load<Sprite>("Images/Companies/Bir/bir5");
    private static readonly Sprite bir6 = Resources.Load<Sprite>("Images/Companies/Bir/bir6");
    private static readonly Sprite[] birs = {bir1, bir2, bir3, bir4, bir5, bir6};

    //Black
    private static readonly Sprite blackFlag = Resources.Load<Sprite>("Images/Companies/Black/BlackFlag");
    private static readonly Sprite blackBackground = Resources.Load<Sprite>("Images/Companies/Black/BlackBackground");
    private static readonly Sprite black1 = Resources.Load<Sprite>("Images/Companies/Black/black1");
    private static readonly Sprite black2 = Resources.Load<Sprite>("Images/Companies/Black/black2");
    private static readonly Sprite black3 = Resources.Load<Sprite>("Images/Companies/Black/black3");
    private static readonly Sprite black4 = Resources.Load<Sprite>("Images/Companies/Black/black4");
    private static readonly Sprite black5 = Resources.Load<Sprite>("Images/Companies/Black/black5");
    private static readonly Sprite black6 = Resources.Load<Sprite>("Images/Companies/Black/black6");
    private static readonly Sprite[] blacks = {black1, black2, black3, black4, black5, black6};

    //Violet
    private static readonly Sprite violetFlag = Resources.Load<Sprite>("Images/Companies/Violet/VioletFlag");
    private static readonly Sprite
        violetBackground = Resources.Load<Sprite>("Images/Companies/Violet/VioletBackground");
    private static readonly Sprite violet1 = Resources.Load<Sprite>("Images/Companies/Violet/fiol1");
    private static readonly Sprite violet2 = Resources.Load<Sprite>("Images/Companies/Violet/fiol2");
    private static readonly Sprite violet3 = Resources.Load<Sprite>("Images/Companies/Violet/fiol3");
    private static readonly Sprite violet4 = Resources.Load<Sprite>("Images/Companies/Violet/fiol4");
    private static readonly Sprite violet5 = Resources.Load<Sprite>("Images/Companies/Violet/fiol5");
    private static readonly Sprite violet6 = Resources.Load<Sprite>("Images/Companies/Violet/fiol6");
    private static readonly Sprite[] violets = {violet1, violet2, violet3, violet4, violet5, violet6};

    //Red
    private static readonly Sprite redFlag = Resources.Load<Sprite>("Images/Companies/Red/RedFlag");
    private static readonly Sprite redBackground = Resources.Load<Sprite>("Images/Companies/Red/RedBackground");
    private static readonly Sprite red1 = Resources.Load<Sprite>("Images/Companies/Red/red1");
    private static readonly Sprite red2 = Resources.Load<Sprite>("Images/Companies/Red/red2");
    private static readonly Sprite red3 = Resources.Load<Sprite>("Images/Companies/Red/red3");
    private static readonly Sprite red4 = Resources.Load<Sprite>("Images/Companies/Red/red4");
    private static readonly Sprite red5 = Resources.Load<Sprite>("Images/Companies/Red/red5");
    private static readonly Sprite red6 = Resources.Load<Sprite>("Images/Companies/Red/red6");
    private static readonly Sprite[] reds = {red1, red2, red3, red4, red5, red6};

    //Green
    private static readonly Sprite greenFlag = Resources.Load<Sprite>("Images/Companies/Green/GreenFlag");
    private static readonly Sprite greenBackground = Resources.Load<Sprite>("Images/Companies/Green/GreenBackground");
    private static readonly Sprite green1 = Resources.Load<Sprite>("Images/Companies/Green/green1");
    private static readonly Sprite green2 = Resources.Load<Sprite>("Images/Companies/Green/green2");
    private static readonly Sprite green3 = Resources.Load<Sprite>("Images/Companies/Green/green3");
    private static readonly Sprite green4 = Resources.Load<Sprite>("Images/Companies/Green/green4");
    private static readonly Sprite green5 = Resources.Load<Sprite>("Images/Companies/Green/green5");
    private static readonly Sprite green6 = Resources.Load<Sprite>("Images/Companies/Green/green6");
    private static readonly Sprite[] greens = {green1, green2, green3, green4, green5, green6};


    public static Sprite RandomCompanyIcon(Colors color, int id)
    {
        switch (color)
        {
            case Colors.RED:
                return reds[id];
            case Colors.GREEN:
                return greens[id];
            case Colors.VIOLET:
                return violets[id];
            case Colors.BLACK:
                return blacks[id];
            case Colors.BIR:
                return birs[id];
            case Colors.BLUE:
                return blues[id];
            default:
                throw new ArgumentOutOfRangeException("color", color, null);
        }
    }

    public static Sprite CompanyBackground(Colors color)
    {
        switch (color)
        {
            case Colors.RED:
                return redBackground;
            case Colors.GREEN:
                return greenBackground;
            case Colors.VIOLET:
                return violetBackground;
            case Colors.BLACK:
                return blackBackground;
            case Colors.BIR:
                return birBackground;
            case Colors.BLUE:
                return blueBackground;
            default:
                throw new ArgumentOutOfRangeException("color", color, null);
        }
    }

    public static Sprite CompanyFlag(Colors color)
    {
        switch (color)
        {
            case Colors.RED:
                return redFlag;
            case Colors.GREEN:
                return greenFlag;
            case Colors.VIOLET:
                return violetFlag;
            case Colors.BLACK:
                return blackFlag;
            case Colors.BIR:
                return birFlag;
            case Colors.BLUE:
                return blueFlag;
            default:
                throw new ArgumentOutOfRangeException("color", color, null);
        }
    }
}

public enum Colors
{
    RED,
    GREEN,
    VIOLET,
    BLACK,
    BIR,
    BLUE
}