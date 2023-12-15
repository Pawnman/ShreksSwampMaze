using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]

public class EnemyD : MonoBehaviour
{
    public Transform player;
    NavMeshAgent agent;
    public List<Transform> targets;
    int i;
    Animator animator;
    float distance;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    public void TargetUpdate()
    {
        i = Random.Range(0, targets.Count);
    }
    // Update is called once per frame
    private void Update()
    {
        distance = Vector3.Distance(transform.position, player.position);
        if (agent.transform.position == agent.pathEndPosition)
        {
      
            TargetUpdate();
           
        }

        if (distance > 1.5)
        {
            Walk();
            agent.SetDestination(targets[i].position);
        }

        if (distance <= 1.5 & distance > 0.7)
        {
            Walk();
            agent.SetDestination(player.position);
        }

        if (distance < 0.7)
        {
            Attack();
            //agent.SetDestination(targets[i].position);
        }
        //agent.SetDestination(targets[i].position);
    }

    void Idle()
    {
        agent.enabled = false;
        animator.SetBool("idle", true);
        animator.SetBool("walk", false);
        animator.SetBool("attack", false);
    }

    void Walk()
    {
        agent.enabled = true;
        animator.SetBool("idle", false);
        animator.SetBool("walk", true);
        animator.SetBool("attack", false);
    }
    void Attack()
    {
        agent.enabled = false;
        animator.SetBool("idle", false);
        animator.SetBool("walk", false);
        animator.SetBool("attack", true);
    }

}