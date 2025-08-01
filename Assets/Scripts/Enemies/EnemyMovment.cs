using UnityEngine;
using UnityEngine.AI;

public class EnemyMovment : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navigator;
    [SerializeField] private float speed = 3f;

    private void Start()
    {
        navigator = GetComponent<NavMeshAgent>();
    }
    public void EnemyTargetPlayer(Transform targetPlayer)
    {
        player = targetPlayer;
    }

    // Update is called once per frame
    private void Update()
    {
        navigator.SetDestination(player.position);
        navigator.speed = speed;
    }
}
