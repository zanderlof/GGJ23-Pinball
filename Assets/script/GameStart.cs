using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("Pinball(Clone)") == null)
        {
            Instantiate(player);
            player.transform.position = spawnPoint.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
