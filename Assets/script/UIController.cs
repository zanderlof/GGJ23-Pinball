using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] PlayerHealthUI healthUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BumperHit(Transform pos)
    {

    }
    
    public void MoveTable(string leaving, string entering)
    {

    }

    public void ItemAcquire(string item)
    {

    }

    public void ItemUse(string item)
    {

    }

   /* Taking/healing damage + amount
        Hitting bumpers
        Damaging enemies
        Moving to another table
        Acquire/Use/Lose item
        Fall into gutter

    Also want to add player states for attacks executed., 
    when they're in cooldown and recharged.*/
}
