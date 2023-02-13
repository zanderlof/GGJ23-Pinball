using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hurtbox : MonoBehaviour
{
    [SerializeField] private int m_maxHealth;
    [SerializeField] private int defense;
	[SerializeField] private UnityEvent m_damagedEvent;
	[SerializeField] private UnityEvent m_deathEvent;

	public int maxHealth
	{
		get { return m_maxHealth; }
	}

	public int currentHealth
	{
		get; set;
	}

	public UnityEvent damagedEvent
	{
		get { return m_damagedEvent; }
	}

	public UnityEvent deathEvent
	{
		get { return m_deathEvent; }
	}

	private void Awake()
	{
		currentHealth = maxHealth;
	}

	public void TakeDamage(int damage, float knockback)
	{
        int actualDamage = damage - defense;
		currentHealth -= actualDamage;
		damagedEvent.Invoke();
		Debug.Log(gameObject.name + " took " + damage + " damage.");
		if (currentHealth <= 0)
		{
			Die();
		}

		// TODO: Handle knockback
	}

	private void Die()
	{
		Debug.Log(gameObject.name + " Died");
		deathEvent.Invoke();
	}

	public void DestroyProxy(GameObject go)
	{
		Destroy(go);
	}
}