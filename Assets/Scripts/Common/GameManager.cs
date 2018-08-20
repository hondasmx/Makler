using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class GameManager : MonoBehaviour
    {
        private bool soundOn = true;
        private bool musicOn = true;
        public static Language language;
        public GameObject musicIcon;
        public GameObject soundIcon;
        public GameObject languageIcon;

        public GameObject newGameTextObject;
        public GameObject tutorialTextObject;
        public GameObject creditsTextObject;
        public GameObject exitTextObject;
        
        public const int compactHeight = 70; //Высота свернутой компании
        public const int advancedHeight = 210; //Высота развернутой компани
        public const float minimumDelta = 0.8f; //-20%
        public const float maximumDelta = 1.2f; //+20%
        public const float dayLength = 18.0f; //длительность дня - 18секунд

        public const float minimumEventValue = 0.05f;
        public const float averageEventValue = 0.20f;
        public const float maximumEventValue = 0.5f;

        public const int numberOfMarqueeEvents = 4;
        
        private void Awake()
        {
            language = Language.RUSSIAN;
            DontDestroyOnLoad(gameObject);
        }

        
        
        private void SetTexts()
        {
            switch (language)
            {
                case Language.RUSSIAN:
                    newGameTextObject.GetComponent<TextMeshProUGUI>().text = "новая игра";
                    tutorialTextObject.GetComponent<TextMeshProUGUI>().text = "обучение";
                    creditsTextObject.GetComponent<TextMeshProUGUI>().text = "авторы";
                    exitTextObject.GetComponent<TextMeshProUGUI>().text = "выход";
                    break;
                case Language.UKRAIN:
                    newGameTextObject.GetComponent<TextMeshProUGUI>().text = "НОВАЯ ИГРА";
                    tutorialTextObject.GetComponent<TextMeshProUGUI>().text = "НОВАЯ ИГРА";
                    creditsTextObject.GetComponent<TextMeshProUGUI>().text = "НОВАЯ ИГРА";
                    exitTextObject.GetComponent<TextMeshProUGUI>().text = "НОВАЯ ИГРА";
                    break;
                case Language.GERMAN:
                    newGameTextObject.GetComponent<TextMeshProUGUI>().text = "Neues spiel";
                    tutorialTextObject.GetComponent<TextMeshProUGUI>().text = "Wie spiele ich";
                    creditsTextObject.GetComponent<TextMeshProUGUI>().text = "Credits";
                    exitTextObject.GetComponent<TextMeshProUGUI>().text = "Verlassen";
                    break;
                case Language.ENGLISH:
                    newGameTextObject.GetComponent<TextMeshProUGUI>().text = "new game";
                    tutorialTextObject.GetComponent<TextMeshProUGUI>().text = "how to play";
                    creditsTextObject.GetComponent<TextMeshProUGUI>().text = "credits";
                    exitTextObject.GetComponent<TextMeshProUGUI>().text = "quit";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
       //Button
        public void NewGame()
        {
            SceneManager.LoadScene("Game", LoadSceneMode.Single);
        }
        //Button
        public void ToggleMusic()
        {
            musicOn = !musicOn;
            musicIcon.GetComponent<Image>().sprite = musicOn ? AllIcons.musicOn : AllIcons.musicOff;
        }
        //Button
        public void ToggleSound()
        {
            soundOn = !soundOn;
            soundIcon.GetComponent<Image>().sprite = soundOn ? AllIcons.soundOn : AllIcons.soundOff;
        }
        //Button
        public void ChangeLanguage()
        {
            var langArray = new[]
                {Language.RUSSIAN, Language.UKRAIN, Language.GERMAN, Language.ENGLISH};
            var index = Array.IndexOf(langArray, language);

            language = index < langArray.Length - 1 ? (Language) langArray.GetValue(index + 1) : Language.RUSSIAN;
            switch (language)
            {
                case Language.RUSSIAN:
                    languageIcon.GetComponent<Image>().sprite = AllIcons.russian;
                    break;
                case Language.UKRAIN:
                    languageIcon.GetComponent<Image>().sprite = AllIcons.ukr;
                    break;
                case Language.GERMAN:
                    languageIcon.GetComponent<Image>().sprite = AllIcons.german;
                    break;
                case Language.ENGLISH:
                    languageIcon.GetComponent<Image>().sprite = AllIcons.english;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            SetTexts();
        }
    }

    public enum Language
    {
        RUSSIAN,
        UKRAIN,
        GERMAN,
        ENGLISH
    }
}