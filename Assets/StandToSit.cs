using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandToSit : MonoBehaviour
{
    public Transform SitPosition; 
    public GameObject Player;

    public void Onsitdown(bool sit)
    {
        if (sit)
        {
            if (Player.GetComponent<Animator>().GetBool("sitting"))
            { return; }
            Player.GetComponent<CharacterCtrl>().enabled = false;
            Player.transform.position = SitPosition.position;
            Player.GetComponent<Animator>().SetTrigger("sit");
            Player.GetComponent<Animator>().SetBool("sitting",true);
        }
        else
        {
            if (Player.GetComponent<Animator>().GetBool("sitting"))
            { 
                Player.GetComponent<CharacterCtrl>().enabled = true;
                Player.GetComponent<Animator>().SetTrigger("stand up");
                Player.GetComponent<Animator>().SetBool("sitting", false); 
            }
        }
    }
}
