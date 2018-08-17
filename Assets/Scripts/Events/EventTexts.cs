using System;
using DefaultNamespace;

public static class EventTexts
{
    public static string Event1()
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Поздравляем, операция по увеличению груди (ушей) - прошла успешно.";
            case Language.UKRAIN:
                return "Вітаємо, операція по збільшенню грудей (вух) - пройшла успішно.";
            case Language.GERMAN:
                return "Gratulation, ihre Brustvergrößerungs-OP (Ohrvergrößerungs-OP) war erfolgreich.";
            case Language.ENGLISH:
                return "Congratulations! Your breast (ears) correction surgery was successfull.";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public static string Event2()
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return
                    "Средство для волос дало эффект! Увы, радикально обратный. Выше нос - теперь не нужно расчёсываться!";
            case Language.UKRAIN:
                return
                    "Засіб для волосся дав ефект! На жаль, радикально зворотній. Вище ніс - наразі не потрібно розчісувати! ";
            case Language.GERMAN:
                return
                    "Das Haarwuchsmittel zeige eine Wirkung! Leider eine komplett umgekehrte…  Die gute Nachricht: Sie müssen sich nicht mehr kämmen!";

            case Language.ENGLISH:
                return
                    "Your hair remedy has given an effect. Probably, this is not what you expected. Buck up, you don’t need a hairbrush! ";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public static string Event3()
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "В ресторане Вы объявили друзьям, что всё за ваш счёт! К оплате ";
            case Language.UKRAIN:
                return "В ресторані Ви оголосили друзям, що все за ваш рахунок! До сплати ";
            case Language.GERMAN:
                return "Sie haben ihren Freunden im Restaurant einen ausgegeben. Die Rechnung beträgt ";
            case Language.ENGLISH:
                return
                    "«Gentlemen, It's My Treat!»-Event with your friends has passed in the restaurant. You are billed ";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public static string Event4()
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Ваш выигрыш в лотерее составил ";
            case Language.UKRAIN:
                return "Ваш виграш в лотереї склав ";
            case Language.GERMAN:
                return "Sie haben in der Lotterie gewonnen! ";
            case Language.ENGLISH:
                return "Your winning the lottery is ";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public static string Event5()
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return
                    "После праздника болит голова, а во рту \"ночевали кошки\"? Похоже, салат был не свежим. Визит к доктору ";
            case Language.UKRAIN:
                return
                    "Після свята болить голова, а в роті \"ночували кішки\"? Схоже, салат не був свіжим. Візит до лікаря ";
            case Language.GERMAN:
                return "Nach der gestrigen Fete haben sie einen schmerzvollen Kater. Der Arztbesuch kostet Sie ";
            case Language.ENGLISH:
                return
                    "Is your head pounding after holidays? Do you have a taste of roadie out of your mouth? You may have a food poisoning. Doctor’s visit will be cost ";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public static string Event6()
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "За появление на публике в непристойном виде - штраф ";
            case Language.UKRAIN:
                return "За появу на публіці в непристойному вигляді - штраф ";
            case Language.GERMAN:
                return "Für die Erregung öffentlichen Ärgernisses haben Sie eine Strafe von ";
            case Language.ENGLISH:
                return "Indecent exposure is punishable by a fine ";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}