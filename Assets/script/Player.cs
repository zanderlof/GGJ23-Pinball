using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField] UIController ui;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Attack"))
		{
            Attack();
		}
    }

    private void Attack()
	{
        animator.SetTrigger("Attack");
	}


}
