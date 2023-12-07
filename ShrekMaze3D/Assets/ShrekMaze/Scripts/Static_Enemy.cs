using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static_Enemy : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetTrigger("stand");
    }
}
