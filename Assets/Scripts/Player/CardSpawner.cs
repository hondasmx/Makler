using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
    public class CardSpawner : MonoBehaviour
    {
        public GameObject cardGameobject;

        private void Start()
        {
            StartCoroutine("InstantiateCards");
        }

        private IEnumerator InstantiateCards()
        {
            while (true)
            {
                Instantiate(cardGameobject, transform.position, Quaternion.identity, transform);
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}