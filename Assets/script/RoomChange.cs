using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomChange : MonoBehaviour
{
    [SerializeField] string room;
    [SerializeField] Transform point;

    private float x;
    private float y;
    private float z;
    // Start is called before the first frame update
    void Start()
    {
        x = point.position.x;
        y = point.position.y;
        z = point.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 holder;
        switch (tag)
        {
            case "Left/Right":
                holder = point.position;
                holder.x = x;
                collision.gameObject.transform.position = holder;
                break;
            case "Up/Down":
                holder = point.position;
                holder.y = y;
                holder.z = z;
                collision.gameObject.transform.position = holder;
                break;
            default:
                break;
        }

        SceneManager.LoadScene(room);
    }
}
