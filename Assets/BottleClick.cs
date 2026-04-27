using UnityEngine;

public class BottleClick : MonoBehaviour
{
    public Animator npcAnimator;

    void OnMouseDown()
    {
        npcAnimator.SetTrigger("ShoulderRub");
    }
}