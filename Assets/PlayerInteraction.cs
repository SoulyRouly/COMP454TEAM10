using UnityEngine;

public class BartenderInteraction : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;
    public AudioClip[] voiceLines; // drag multiple clips in here

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        animator.SetTrigger("Wave");
        PlayRandomVoiceLine();
    }

    void PlayRandomVoiceLine()
    {
        if (voiceLines.Length == 0) return;

        int randomIndex = Random.Range(0, voiceLines.Length);
        audioSource.PlayOneShot(voiceLines[randomIndex]);
    }
}