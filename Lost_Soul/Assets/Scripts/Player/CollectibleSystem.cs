using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSystem : MonoBehaviour
{
    static int collectiblesInGame = 8;

    private void BonusEndingCheck()
    {
        if(collectiblesInGame > 0)
        {
            Destroy(this.gameObject);
            collectiblesInGame--;
            Debug.Log("Touched!");
        }

        else if(collectiblesInGame == 0)
        {
            // Load bonus ending.
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            BonusEndingCheck();
        }
    }
}
