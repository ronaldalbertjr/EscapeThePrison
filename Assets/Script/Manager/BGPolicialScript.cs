using UnityEngine;
using System.Collections;

public class BGPolicialScript : MonoBehaviour
{
    public GameObject enemy;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            enemy.GetComponent<EnemyBehaviour>().canSeePlayer = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            enemy.GetComponent<EnemyBehaviour>().canSeePlayer = false;
        }
    }
	
}
