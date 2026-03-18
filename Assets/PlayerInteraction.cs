using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionDistance = 5f;
    public Animator bartenderAnimator;

    void Update()
    {
        // Check for Left Mouse Click
        if (Input.GetMouseButtonDown(0))
        {
            // Create a ray from the center of the screen
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, interactionDistance))
            {
                // If we hit the Bartender
                if (hit.collider.CompareTag("NPC"))
                {
                    bartenderAnimator.SetTrigger("Wave");
                }
                // If we hit the Bottle
                else if (hit.collider.CompareTag("Bottle"))
                {
                    bartenderAnimator.SetTrigger("Prepare");
                }
            }
        }
    }
}