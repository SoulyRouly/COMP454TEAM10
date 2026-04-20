using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] songs;

    public void PlaySong(int songIndex)
    {
        if (songIndex >= 0 && songIndex < songs.Length)
        {
            audioSource.clip = songs[songIndex];
            audioSource.Play();
        }
    }
}