using UnityEngine;
using TMPro;

public class PoolTableTrigger : MonoBehaviour
{
    public GameObject promptText;

    void Start()
    {
        promptText.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            promptText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            promptText.SetActive(false);
        }
    }
}