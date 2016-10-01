using UnityEngine;
using System.Collections;

public class EnemyVisionScript : MonoBehaviour
{
    public GameObject enemy;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            enemy.GetComponent<EnemyBehaviour>().followingEnemy = true;
        }
    }
}
