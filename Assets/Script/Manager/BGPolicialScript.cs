using UnityEngine;
using System.Collections;

public class BGPolicialScript : MonoBehaviour
{
    public GameObject enemy;
    void OnTriggerEnter2D(Collider2D col)
    {
        enemy.GetComponent<EnemyBehaviour>().canSeePlayer = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        enemy.GetComponent<EnemyBehaviour>().canSeePlayer = false;
    }
	
}
