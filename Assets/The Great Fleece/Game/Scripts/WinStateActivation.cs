using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winCutscene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (GameManager.Instance.HasCard == true)
            {
                winCutscene.SetActive(true);
            }
            else
            {
                Debug.Log("You Musr Grab The Key Card!");
            }
        }
    }
}
 