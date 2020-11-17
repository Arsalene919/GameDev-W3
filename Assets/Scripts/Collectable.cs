using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public GameManager GM;
    //when the coin will be hitten by the player
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag== "Player")
        {
            Destroy(this.gameObject);
            GM.Score++;
        }
    }

    
}
