using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent), typeof(Animator))]
public class MeleeEnemy : MonoBehaviour
{
	[Tooltip("Recalculate pathing to reach the player every n frames.")]
	[SerializeField] private int updateRateInFrames;
	[Tooltip("Attack when within this distance of the player character")]
	[SerializeField] private float attackDistanceThreshold;
	[SerializeField] private float attackDuration;

	private GameObject player;
	private NavMeshAgent navMeshAgent;
	private Animator animator;

	private void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		navMeshAgent = GetComponent<NavMeshAgent>();
		animator = GetComponent<Animator>();
	}

	private void Start()
	{
		StartCoroutine(EnemyRoutine());
	}

	private IEnumerator EnemyRoutine()
	{
		// Start off with a random offset so enemies don't all update on the same frame
		int numberFramesToWait = Random.Range(0, updateRateInFrames);

		while (enabled)
		{
			navMeshAgent.SetDestination(player.transform.position);

			for (int i = 0; i < numberFramesToWait; ++i)
			{
				if (Vector3.Distance(transform.position, player.transform.position) <= attackDistanceThreshold)
				{
					yield return StartCoroutine(Attack());
					break;
				}
				else
				{
					yield return null;
				}
			}

			numberFramesToWait = updateRateInFrames;
		}
	}

	private IEnumerator Attack()
	{
		Debug.Log("Attack!");
		animator.SetTrigger("Attack");
		yield return new WaitForSeconds(attackDuration);
	}
}
