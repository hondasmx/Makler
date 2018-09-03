using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicPlayer : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip clip1;
    public AudioClip clip2;
    private AudioClip[] clips;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        clips = new[] {clip1, clip2};
        StartCoroutine(PlayList());
    }


    private IEnumerator PlayList()
    {
        while (true)
        {
            var clip = clips[Random.Range(0, 2)];
            audioSource.clip = clip;
            audioSource.Play();
            yield return new WaitForSeconds(clip.length);
        }
    }
}