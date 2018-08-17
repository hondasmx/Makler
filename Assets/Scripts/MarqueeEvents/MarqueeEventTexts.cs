using System;
using System.Linq;
using DefaultNamespace;
using UnityEngine;
using Random = UnityEngine.Random;

public class MarqueeEventTexts : MonoBehaviour
{
    #region Violet

    private static string Violet1(string name)
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Танкер компании " + name +
                       " потерпел кораблекрушение у берегов Гренландии, экологии побережья нанесен многомиллионный ущерб";
            case Language.UKRAIN:
                return "Танкер компанії " + name +
                       " зазнав корабельної аварії у берегів Гренландії, екології узбережжя нанесено значних збитків";
            case Language.GERMAN:
                return "Ein Tanker des Unternehmens " + name +
                       " erlitt Schiffbruch vor der Küste von Grönland. Der Ökologie wurde ein Multimillionen-Dollar Schaden zugefügt.";
            case Language.ENGLISH:
                return "Tanker of the " + name +
                       " Сompany was shipwrecked off Greenland. Ecology of the coast is damaged into many millions. ";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private static string Violet2(string name)
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Компания " + name +
                       " начала разработку нового месторождения нефти, тем самым увеличив свой вклад в общую мировую добычу \"черного золота\"";
            case Language.UKRAIN:
                return "Компанія " + name +
                       " почала розробку нового родовища нафти, чим збільшила свій внесок в загальний світовий видобуток \"чорного золота\"";
            case Language.GERMAN:
                return "Das Unternehmen " + name +
                       " begann die Erschließung eines neuen Ölfeldes und erhöhte damit ihren Beitrag zur gesamten Weltförderung des \"schwarzen Goldes.\"";
            case Language.ENGLISH:
                return
                    "The Oil Trust Company began the development of a new oilfield, thereby increasing its contribution to total world production of the \"black gold\".";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private static string Violet3()
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Избыточная добыча нефти привела к перенасыщению рынка, финансовые аналитики бьют тревогу. " +
                       "Не приведёт ли это к очередному кризису...";
            case Language.UKRAIN:
                return
                    "Надлишковий видобудок нафти призвів до перенасичення ринку, фінансові аналітики бьють на сполох. Чи не призведе це до наступної кризи...";
            case Language.GERMAN:
                return
                    "Ein Überschuss der Ölförderung führte zu einer Übersättigung des Marktes. Finanzanalytiker schlagen Alarm. Ob das zu einer neuen Krise führen wird?";
            case Language.ENGLISH:
                return
                    "Excess oil production caused a glut in the market. Financial analysts are alarmed. Are we heading toward another crisis?";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    #endregion

    #region Green

    private static string Green1()
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Благоприятные погодные условия, позволили позволили вырастить рекордные урожаи зерновых " +
                       GetRandomWord(new[] {"фруктов", "орехов", "овощей"});
            case Language.UKRAIN:
                return "Сприятливі погодні умови, дозволили виростити рекордні врожаї зернових " +
                       GetRandomWord(new[] {"фруктів", "горіхів", "овочей"});
            case Language.GERMAN:
                return "Günstige Wetterbedingungen führten zu Rekordhöhen bei der Ernte von Getreide " +
                       GetRandomWord(new[] {"Obst", "Nüssen", "Gemüse"});
            case Language.ENGLISH:
                return "Favorable weather conditions allowed for good harvest of cereals " +
                       GetRandomWord(new[] {"fruits", "nuts", "vegetables"});
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private static string Green2()
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return
                    "Несмотря на благоприятные погодные условия и богатый урожай, стремительные циклоны угрожают сбору " +
                    GetRandomWord(new[] {"зерновых", "фруктов", "орехов", "овощей"});
            case Language.UKRAIN:
                return
                    "Незважаючи на сприятливі погодні умови і багатий врожай, стрімкі циклони загрожують збору " +
                    GetRandomWord(new[] {"зернових", "фруктів", "горіхів", "овочей"});
            case Language.GERMAN:
                return
                    "Trotz der günstigen Wetterbedingungen und hoher Ernte, gefährden Zyklone den Ertrag von " +
                    GetRandomWord(new[] {"Getreide", "Obst", "Nüssen", "Gemüse"});
            case Language.ENGLISH:
                return "Despite favorable weather conditions and bumper crop, the harvest of " +
                       GetRandomWord(new[] {"cereals", "fruits", "nuts", "vegetables"}) +
                       " is threatened by coming cyclones. ";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private static string Green3(string name)
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Компания " + name +
                       " разработала прототип инновационного " +
                       GetRandomWord(new[] {"эко-пластика", "экологичного упаковочного материала"}) +
                       ", однако эксперты не спешат делать прогнозов";
            case Language.UKRAIN:
                return "Компанія " + name +
                       " розробила прототип інноваційного " +
                       GetRandomWord(new[] {"еко-пластика", "екологічного пакувального матеріалу"}) +
                       ", проте експерти не спішать робити прогнози";
            case Language.GERMAN:
                return "Das Unternehmen " + name +
                       " hat den Prototyp eines innovativen " +
                       GetRandomWord(new[] {"Öko-Plastiks", "ökologisches Verpackungsmaterials"}) +
                       " entwickelt, die Experten eilen aber nicht mit den Prognosen.";
            case Language.ENGLISH:
                return "The " + name +
                       " Company has developed a prototype of the innovative " +
                       GetRandomWord(new[] {"eco-plastic", "environment-friendly packaging material"}) +
                       ", but experts are not making any forecasts";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private static string Green4(string name)
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Громкие заявления компании " + name +
                       " о разработке прототипа инновационного " +
                       GetRandomWord(new[] {"эко-пластика", "экологичного упаковочного материала"}) +
                       " оказались пустышкой, акционеры разочарованы";
            case Language.UKRAIN:
                return "Гучні заяви компанії " + name +
                       " про розробку прототипу інноваційного " +
                       GetRandomWord(new[] {"еко-пластика", "екологічного пакувального матеріалу"}) +
                       ", виявилися пустушкою, акціонери розчаровані";
            case Language.GERMAN:
                return "Voreilige Presseerklärung von " + name +
                       ": Der Prototyp eines innovativen " +
                       GetRandomWord(new[] {"Öko-Plastiks", "ökologisches Verpackungsmaterials"}) +
                       " hat sich als Flopp herausgestellt. Anleger sind enttäuscht.";
            case Language.ENGLISH:
                return "Ambiguous statements of the " + name +
                       " Company about the prototype developing of the innovative " +
                       GetRandomWord(new[] {"eco-plastic", "environment-friendly packaging material"}) +
                       " has ended up a pacifier. The Shareholders are disappointed. ";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private static string Green5(string name)
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Компания " + name +
                       " смогла наладить производство инновационного " +
                       GetRandomWord(new[] {"эко-пластика", "экологичного упаковочного материала"}) +
                       ", многие компании уже заинтересовались разработкой и спешат заключить контракты";
            case Language.UKRAIN:
                return "Компанія " + name +
                       " змогла налагодити виробництво інноваційного " +
                       GetRandomWord(new[] {"еко-пластика", "екологічного пакувального матеріалу"}) +
                       ", багато компаній вже зацікавилися розробкою і поспішають укласти контракти";
            case Language.GERMAN:
                return "Das " + name +
                       " Unternehmen konnte die Massenproduktion des innovativen " +
                       GetRandomWord(new[] {"Öko-Plastiks", "ökologisches Verpackungsmaterials"}) +
                       " einrichten. Viele Unternehmen sind interessiert und sind dabei schnellst möglich Verträge abzuschließen.";
            case Language.ENGLISH:
                return "The " + name +
                       " Company has been able to produce the innovative " +
                       GetRandomWord(new[] {"eco-plastic", "environment-friendly packaging material"}) +
                       ". Many companies have already interested in its development and are rushing to conclude the contracts. ";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private static string Green6(string name)
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Иновационный " +
                       GetRandomWord(new[] {"эко-пластик", "экологичный упаковочный материал"}) + " компании " + name +
                       "оказался украденной технологией, грядет судебное разбирательство, контракты разрываются один за одним";
            case Language.UKRAIN:
                return "Інноваційний " +
                       GetRandomWord(new[] {"эко-пластик", "экологичный упаковочный материал"}) + " компанії " + name +
                       " виявився вкраденою технологією, гряде судовий розгляд, контракти відкликаються один за одним ";
            case Language.GERMAN:
                return "Das innovative " +
                       GetRandomWord(new[] {"эко-пластик", "экологичный упаковочный материал"}) + " des " + name +
                       " Unternehmens hat sich als eine gestohlene Technologie rausgestellt. Eine gerichtliche Untersuchung droht. Verträge werden widerrufen.";
            case Language.ENGLISH:
                return "The innovative " +
                       GetRandomWord(new[] {"эко-пластик", "экологичный упаковочный материал"}) +
                       " of the " + name +
                       " Company has ended up a stolen technology. Litigation is coming. The contracts are revoked one after each other.";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    #endregion

    #region Red

    private static string Red1(string name)
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Открытие компании " + name +
                       " позволило создать препарат нового поколения, произведя фурор в косметологии";
            case Language.UKRAIN:
                return "Відкриття компанії " + name +
                       " дозволило створити препарат нового покоління, провівши фурор в косметології";
            case Language.GERMAN:
                return "Furore in der Kosmetikbranche: Die Eröffnung des " + name +
                       " Unternehmens hat Produkte einer neuen Generation ermöglicht. ";
            case Language.ENGLISH:
                return "The opening of the " + name +
                       " allowed to create a new generation medicine, that made a major impact in cosmetology.";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private static string Red2(string name)
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Недавно запущенный в продажу препарат компании " + name +
                       " неожиданно проявил новые побочные эффекты. Компания вынуждена отозвать препарат из продажи";
            case Language.UKRAIN:
                return "Нещодавно запущений в продаж препарат компанії " + name +
                       " несподівано виявив нові побічні ефекти. Компанія змушена відкликати препарат з продажу";
            case Language.GERMAN:
                return "Rückrufaktion von " + name +
                       ": ein kürzlich für den Verkauf freigegebenes Präparat ruft unerwartete Nebenwirkungen hervor.";
            case Language.ENGLISH:
                return "Recently launched medicine of the " + name +
                       " suddenly has shown new side effects. The company is forced to pull that medicine off the market.";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private static string Red3()
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Повсеместная эпидемия распираторных заболеваний повысила спрос на медикаменты";
            case Language.UKRAIN:
                return "Повсюдна епідемія респіраторних захворювань підвищила попит на медикаменти ";
            case Language.GERMAN:
                return
                    "Eine weit verbreitete Epidemie von Atemwegserkrankungen erhöht die Nachfrage nach Medikamenten.";
            case Language.ENGLISH:
                return "Widespread respiratory infections have increased the demand for medicines. ";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    #endregion

    #region Bir

    private static string Bir1(string name)
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Новая модель " + GetRandomWord(new[] {"смартфона", "телевизора"}) + " от компании " + name +
                       " вызвала небывалый ажиотаж, безусловно, потребители по достоинству оценили труд специалистов";
            case Language.UKRAIN:
                return "Нова модель " + GetRandomWord(new[] {"смартфона", "телевізора"}) + " від компанії " + name +
                       " викликала небувалий ажіотаж, безумовно, споживачі належним чином оцінили працю фахівців";
            case Language.GERMAN:
                return "Ein neues " + GetRandomWord(new[] {"Smartphone", "Fernseher"}) + " Model des Unternehmens " +
                       name +
                       " rufte eine beispiellose Aufregung hervor. Die reingesteckte Arbeit der Spezialisten wird vom Verbraucher sehr geschätzt.";
            case Language.ENGLISH:
                return "The new model of the " + GetRandomWord(new[] {"smartphone", "TV"}) + " the " + name +
                       " caused an unprecedented rush. Clearly, the work of specialists of the Company has been appreciated by consumers. ";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private static string Bir2(string name)
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Новая модель " + GetRandomWord(new[] {"смартфона", "телевизора"}) + " от компании " + name +
                       " пришлась не по вкусу потребителям, данный проект стал для компании провальным ";
            case Language.UKRAIN:
                return "Нова модель " + GetRandomWord(new[] {"смартфона", "телевізора"}) + " від компанії " + name +
                       " не прийшлась до смаку споживачам, даний проект став для компанії провальним";
            case Language.GERMAN:
                return "Ein neues " + GetRandomWord(new[] {"Smartphone", "Fernseher"}) + " Model des Unternehmens " +
                       name +
                       " ist beim Verbraucher nicht gut angekommen. Das Projekt ist eine Katastrophe für das Unternehmen.";
            case Language.ENGLISH:
                return "Consumers were frustrated with the new model of the " +
                       GetRandomWord(new[] {"smartphone", "TV"}) + " from the " + name +
                       ". This project has been just missed for the Company. ";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private static string Bir3(string name)
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Новая серия процессоров от компании " + name +
                       " была тепло встречена потребителми, что позволило компании укрепиться на рынке";
            case Language.UKRAIN:
                return "Нова серія процесорів від компанії " + name +
                       " була тепло зустрінута споживачами, що дозволило компанії зміцнитися на ринку";
            case Language.GERMAN:
                return "Die neue Prozessor Serie von " + name +
                       " ist beim Verbraucher recht gut angekommen. Das erlaubt dem Unternehmen seine Stellungen auf dem Markt zu befestigen.";
            case Language.ENGLISH:
                return "The series of new processors from the " + name +
                       " was warmly welcomed by consumers, allowing the Company to secure the market.";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    #endregion

    #region Black

    private static string Black1(string name)
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "Открытие новой шахты - укрепило позиции компании " + name +
                       " на рынке ценных бумаг. Акционеры выражают согласие с выбранным компанией курсом";
            case Language.UKRAIN:
                return "Відкриття нової шахти - зміцнило позиції компанії " + name +
                       " на ринку цінних паперів. Акціонери погоджуються з обраним компанією курсом";
            case Language.GERMAN:
                return "Die Eröffnung einer neuen Mine hat die Position des Unternehmens " + name +
                       " auf dem Aktienmarkt gestärkt. Die Aktionäre sind mit dem Kurs des Unternehmens einverstanden.";
            case Language.ENGLISH:
                return "A dominant position of the " + name +
                       ". in the financial market was achieved by the opening of a new mine. The Shareholders agree with the Company's chosen course";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private static string Black2(string name)
    {
        switch (GameManager.language)
        {
            case Language.RUSSIAN:
                return "В связи с нестабильным " + GetRandomWord(new[] {"спросом", "ценой"}) + " на " +
                       GetRandomWord(new[] {"уголь", "металл"}) + " компания " + name +
                       " вынуждена сократить объёмы производства";
            case Language.UKRAIN:
                return "В зв'язку з нестабільним " +
                       GetRandomWord(new[] {"попитом", "ціною"}) + " на " +
                       GetRandomWord(new[] {"вугілля", "метал"}) + " компанія " + name +
                       " змушена скоротити обсяги виробництва";
            case Language.GERMAN:
                return "Aufgrund der instabilen " +
                       GetRandomWord(new[] {"Nachfrage", "Preis"}) + " auf " +
                       GetRandomWord(new[] {"Kohle", "Metall"}) + " ist das Unternehmen " + name +
                       " gezwungen sein Produktionsvolumen zu reduzieren.";
            case Language.ENGLISH:
                return "The " + name + ". is forced to reduce production due to unstable " +
                       GetRandomWord(new[] {"demand", "price"}) + " for the " +
                       GetRandomWord(new[] {"coal", "metal"});
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    #endregion

    public static MarqueeEventText RandomEvent(string name, Colors colors)
    {
        MarqueeEventText[] comps;
        switch (colors)
        {
            case Colors.RED:
                comps = new[]
                {
                    new MarqueeEventText(Red1(name), GameManager.averageEventValue, true),
                    new MarqueeEventText(Red2(name), -GameManager.maximumEventValue, true),
                    new MarqueeEventText(Red3(), GameManager.averageEventValue, false)
                };
                return comps[Random.Range(0, comps.Length)];
            case Colors.GREEN:
                comps = new[]
                {
                    new MarqueeEventText(Green1(), GameManager.minimumEventValue, false),
                    new MarqueeEventText(Green2(), -GameManager.minimumEventValue, false),
                    new MarqueeEventText(Green3(name), GameManager.averageEventValue, true),
                    new MarqueeEventText(Green4(name), -GameManager.averageEventValue, true),
                    new MarqueeEventText(Green5(name), GameManager.maximumEventValue, true),
                    new MarqueeEventText(Green6(name), -GameManager.maximumEventValue, true)
                };
                return comps[Random.Range(0, comps.Length)];
            case Colors.VIOLET:
                comps = new[]
                {
                    new MarqueeEventText(Violet1(name), -GameManager.maximumEventValue, true),
                    new MarqueeEventText(Violet2(name), GameManager.averageEventValue, true),
                    new MarqueeEventText(Violet3(), -GameManager.averageEventValue, false)
                };
                return comps[Random.Range(0, comps.Length)];
            case Colors.BLACK:
                comps = new[]
                {
                    new MarqueeEventText(Black1(name), GameManager.averageEventValue, true),
                    new MarqueeEventText(Black2(name), -GameManager.averageEventValue, true)
                };
                return comps[Random.Range(0, comps.Length)];
            case Colors.BIR:
                comps = new[]
                {
                    new MarqueeEventText(Bir2(name), GameManager.averageEventValue, true),
                    new MarqueeEventText(Bir1(name), -GameManager.averageEventValue, true),
                    new MarqueeEventText(Bir3(name), GameManager.averageEventValue, true)
                };
                return comps[Random.Range(0, comps.Length)];
            case Colors.BLUE:
                break;
            default:
                throw new ArgumentOutOfRangeException("colors", colors, null);
        }

        return null;
    }

    public static string GetRandomName(Colors color)
    {
        var companies = FindObjectsOfType<CompanyCard>();
        var result = (from company in companies where company.color == color select company.companyName.FullName())
            .ToList();
        var rand = Random.Range(0, result.Count);
        try
        {
            return "\"" + result[rand] + "\"";
        }
        catch (ArgumentOutOfRangeException e)
        {
        }

        return "";
    }

    private static string GetRandomWord(string[] words)
    {
        var rand = Random.Range(0, words.Length);
        return words[rand];
    }
}