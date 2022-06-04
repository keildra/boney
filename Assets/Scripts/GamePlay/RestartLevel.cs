using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartLevel : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            Player.transform.position = startPoint.transform.position;
        }
    }
}
