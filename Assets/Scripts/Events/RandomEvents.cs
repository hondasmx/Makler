using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class RandomEvents : MonoBehaviour
    {
        private Player player;
        private readonly List<Event> events = new List<Event>();
        public GameObject eventWindowPrefab;

        private void Start()
        {
            player = FindObjectOfType<Player>();
            GenerateEvents();
        }

        private void GenerateEvents()
        {
            events.Add(new Event(EventTexts.Event1(), 0, 0));
            events.Add(new Event(EventTexts.Event2(), 0, 0));
            events.Add(new Event(EventTexts.Event3(), -50, -200));
            events.Add(new Event(EventTexts.Event4(), 5, 40));
            events.Add(new Event(EventTexts.Event5(), -200, -500));
            events.Add(new Event(EventTexts.Event6(), -200, -500));
        }

        public void RandomEvent()
        {
            var rand = Random.Range(0, events.Count);
            var randomEvent = events[rand];
            player.ChangeMoneyAmount(randomEvent.amount);
            var prefab = Instantiate(eventWindowPrefab, transform.position, Quaternion.identity,
                transform);
            Time.timeScale = 0;
            prefab.GetComponent<EventWindow>().SetText(randomEvent.eventText);
        }
    }
}