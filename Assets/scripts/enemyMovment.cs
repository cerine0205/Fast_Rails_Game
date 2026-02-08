using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class enemyMovment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public NavMeshAgent agent;
    public Transform player;

    public Animator enemyAnimator;
    public Rigidbody enemyRb;

    public float jumbForce;
    public bool isStop = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            // ملاحقه اللاعب
            if (Vector3.Distance(transform.position, player.position) <= agent.stoppingDistance)
                enemyAnimator.SetBool("isRunning", false);


            else
            {
                //enemyAnimator.SetBool("isAttacking", false);
                enemyAnimator.SetBool("isRunning", true);


                agent.SetDestination(player.position);



            }
            


        }

        


        
    }

