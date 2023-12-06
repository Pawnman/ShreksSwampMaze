using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyS : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    private GameObject Player;
    public float speed = 2f;
    public float rotationSpeed = 10f;
    public int EH = 2;
    // public GameObject theNPC;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter(Collision scream)
        {
            if (scream.gameObject.CompareTag("Scream"))
            {
                //Destroy(colission.gameObject);
                EH -= 1;
                Debug.Log("Enemy lifes");
                Debug.Log(EH);
                if (EH <= 0)
                {
                    animator.SetBool("Pnear", false);
                    animator.SetBool("die", true);

                    //Destroy(colission.gameObject);
                    gameObject.SetActive(false);
                }
            }
        }

        float Dist_Player = Vector3.Distance(Player.transform.position, gameObject.transform.position);
        if (Dist_Player < 2f)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(Player.transform.position - transform.position), rotationSpeed * Time.deltaTime);

            animator.SetBool("Pnear", true);

        }
        else
        {
            animator.SetBool("Pnear", false);

        }

    }
}
