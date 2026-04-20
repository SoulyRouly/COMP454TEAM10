using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Animator animator;
    public float speed = 5f;
    public float gravity = -9.81f;
    
    Vector3 velocity;

    void Update()
    {
        // 1. Get Input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // 2. Calculate direction relative to where the player is facing
        Vector3 move = transform.right * x + transform.forward * z;

        // 3. Apply movement
        controller.Move(move * speed * Time.deltaTime);

        float moveSpeed = new Vector3(move.x, 0, move.z).magnitude;
        animator.SetFloat("Speed", moveSpeed);

        // 4. Simple Gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}