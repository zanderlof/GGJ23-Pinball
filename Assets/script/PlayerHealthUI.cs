using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] Player m_Player;
    public TextMeshProUGUI m_HealthText;
    public Slider m_HealthBar;
    [SerializeField] Image m_HealthBarFill;
   
    private void Awake()
    {
        m_Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        UpdateMaxHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealthUI(int health)
    {
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
        m_HealthBar.maxValue = m_Player.GetHealthMax();
    }
}
