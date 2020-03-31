using UnityEngine;
using UnityEngine.AI;

public class SpiderChase : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Animator anim;
    [SerializeField] public float attackRadius;

    private NavMeshAgent agent;

    private bool inPLay = false;
    private bool attacking;
 
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        bool isPlayerClose = IsPlayerClose();
        if (!anim.GetCurrentAnimatorStateInfo(0).IsName("DigEmerge")) inPLay = true;

        if (inPLay)
        {
            Vector3 newTargetPostition = new Vector3(target.position.x, this.transform.position.y, target.position.z);
            agent.destination = newTargetPostition;
            anim.SetBool("WalkForwards", true);
            if (attacking)
            {
                anim.SetBool("Attack", false);
                attacking = false;
            }
            if (isPlayerClose)
            {
                AttackPlayer();
            }
        }

    }

    bool IsPlayerClose()
    {
        Collider[] nearbyObjects = Physics.OverlapSphere(transform.position, attackRadius);
        foreach (Collider item in nearbyObjects)
        {
            Debug.Log(item);

            if (item.CompareTag("Player"))
            {
                target = item.transform;
                Debug.Log("Player near is true.");
                return true;
            }
        }
        return false;
    }
}