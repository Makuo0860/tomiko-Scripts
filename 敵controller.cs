using UnityEngine;
using UnityEngine.AI;

public class 敵controller : MonoBehaviour
{
    [SerializeField] private 走るモーション playerController;
    [SerializeField] Transform points;

    //感知距離
    [SerializeField] private float runningRange = 50f;
    [SerializeField] private float walkingRange = 30f;
    [SerializeField] private float squatRange = 10f;
    //スピード
    [SerializeField] private float patrolSpeed = 2.0f;
    [SerializeField] private float chaseSpeed = 5.0f;

    //警戒度
    [SerializeField] private float attentionIncrease = 0.01f;
    [SerializeField] private float attentionDecrease = 0.003f;

    bool isChasing;
    Transform player;
    NavMeshAgent agent;
    float attention;
    private Animator anim;

    void Start()
    {
        player = playerController.transform;
        agent = GetComponent<NavMeshAgent>();
        agent.destination = GetDestinationRandomly();
        agent.speed = patrolSpeed;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        float hearingRange = 0f;
        if (playerController.IsRunning())
            hearingRange = runningRange;
        else if(playerController.IsWalking())
            hearingRange = walkingRange;
        else if(playerController.IsSquating())
            hearingRange = squatRange;

        if(distance <= hearingRange)
        {
            float distanceRate = 1f - (distance / hearingRange);
            attention += attentionIncrease * distanceRate;
            if (attention >= 1f)
            {
                attention = 1f;
                isChasing = true;
            }
        }

        else
        {
            attention -= attentionDecrease;
            if(attention <= 0f)
            {
                attention = 0f;
                if (isChasing)
                {
                    agent.destination = GetDestinationRandomly();
                }
                isChasing = false;
            }
        }

        if (isChasing)
        {
            agent.speed = chaseSpeed;
            agent.destination = player.position;
            anim.SetBool("見つけた", true);
        }
        else
        {
            anim.SetBool("見つけた", false);
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            {
                agent.destination = GetDestinationRandomly();
            }
        }
    }

    Vector3 GetDestinationRandomly()
    {
        return points
            .GetChild(Random.Range(0, points.childCount))
            .transform.position;
    }
}