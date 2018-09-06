using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicPlayer : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip clip1;
    public AudioClip clip2;
    private readonly List<AudioClip> clips = new List<AudioClip>();

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        clips.Add(clip1);
        if (clip2 != null)
        {
            clips.Add(clip2);
        }
        StartCoroutine(PlayList());
    }


    private IEnumerator PlayList()
    {
        while (true)
        {
            var clip = clips[Random.Range(0, clips.Count)];
            audioSource.clip = clip;
            audioSource.Play();
            yield return new WaitForSeconds(clip.length);
        }
    }
}