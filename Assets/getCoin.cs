using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getCoin : MonoBehaviour
{
    public int amount = 10;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            other.GetComponent<Player>().getCoin(amount);
            Destroy(this.gameObject);
        }
    }
}
