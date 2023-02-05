using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    [SerializeField] private string startScene;

    Hurtbox player;

    IEnumerator Start()
    {
        yield return null;
        gameObject.SetActive(false);
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Hurtbox>();
        Debug.Log("Subscribing to pinball death event");
        player.deathEvent.AddListener(OnDeath);
        player.deathEvent.AddListener(() => Debug.Log("The death event is happening"));
    }

	private void OnDestroy()
	{
        player.deathEvent.RemoveListener(OnDeath);
	}

	private void OnDeath()
	{
        gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Retry()
	{
        Time.timeScale = 1f;
        player.currentHealth = player.maxHealth;
        SceneManager.LoadScene(startScene);
	}

    public void Quit()
	{
        Application.Quit();
	}
}
