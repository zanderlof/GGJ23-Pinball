using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
	[SerializeField] private int damage;
	[SerializeField] private float knockback;

	private void OnTriggerEnter(Collider other)
	{
		Hurtbox hurtbox = other.GetComponent<Hurtbox>();
		if (hurtbox)
		{
			hurtbox.TakeDamage(damage, knockback);
		}
	}
}
