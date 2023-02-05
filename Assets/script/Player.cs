using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int healthMax;
    [SerializeField] int attack;
    [SerializeField] int shieldValue;
    [SerializeField] int healStrength;

    private int health;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        health = healthMax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Heal(int heal = -1)
    {
        if(heal < 0)
        {
            health += healStrength;
            return;
        }
        health += heal;
    }

    public void Damage(int dmg)
    {
        health -= dmg;
    }
}