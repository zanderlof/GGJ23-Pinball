using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurtbox : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    [SerializeField] private int defense;

    private int currentHealth;

	private void Start()
	{
		currentHealth = maxHealth;
	}

	public void TakeDamage(int damage, float knockback)
	{
        int actualDamage = damage - defense;
		currentHealth -= actualDamage;
		if (currentHealth <= 0)
		{
			Die();
		}

		// TODO: Handle knockback
	}

	private void Die()
	{
		Debug.Log(gameObject.name + " Died");
	}
}