using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    private Hurtbox player;
    public TextMeshProUGUI m_HealthText;
    public Slider m_HealthBar;
    [SerializeField] Image m_HealthBarFill;
   
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<Hurtbox>();
        player.damagedEvent.AddListener(UpdateHealthUI);
        UpdateMaxHealth();
    }

	private void Start()
	{
        UpdateHealthUI();
	}

	// Update is called once per frame
	void Update()
    {
        
    }

    public void UpdateHealthUI()
    {
        int health = player.currentHealth;
        m_HealthText.text = "HP: " + health.ToString();
        m_HealthBar.value = health;

        if(health <= 0)
        {
            m_HealthBarFill.enabled = false; 
        }
        else { m_HealthBarFill.enabled = true;}
    }

    void UpdateMaxHealth()
    {
        m_HealthBar.maxValue = player.maxHealth;
    }
}
