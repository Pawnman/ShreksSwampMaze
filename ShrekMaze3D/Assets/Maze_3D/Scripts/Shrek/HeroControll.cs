using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControll : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    public float speed = 2f;
    public float rotationSpeed = 10f;
    // public GameObject theNPC;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorz, 0.0f, moveVert);
        if (movement.magnitude > Mathf.Abs(0.05f))
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(movement), Time.deltaTime * rotationSpeed);

        animator.SetFloat("speed", Vector3.ClampMagnitude(movement, 1).magnitude);

        rb.velocity = Vector3.ClampMagnitude(movement, 1) * speed;

        rb.angularVelocity = Vector3.zero;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Scream();

        }

        void Scream()
        {
            animator.SetTrigger("scream");
            AudioManager.instance.Play("Scream");
            animator.SetTrigger("calm");
        }
    }
}