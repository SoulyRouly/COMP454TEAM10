using UnityEngine;

public class BartenderInteraction : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;
    public AudioClip[] voiceLines;
    int lastIndex = -1;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (audioSource.isPlaying) return; // ignore clicks while audio is playing

        animator.SetTrigger("Wave");
        PlayRandomVoiceLine();
    }

    void PlayRandomVoiceLine()
    {
        if (voiceLines.Length == 0) return;

        int randomIndex;
        do {
            randomIndex = Random.Range(0, voiceLines.Length);
        } while (randomIndex == lastIndex && voiceLines.Length > 1);

        lastIndex = randomIndex;
        audioSource.PlayOneShot(voiceLines[randomIndex]);
    }
}