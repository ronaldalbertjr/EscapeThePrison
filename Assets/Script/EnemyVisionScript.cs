using UnityEngine;
using System.Collections;

public class EnemyVisionScript : MonoBehaviour
{
    public GameObject enemy;

    void OnTriggerEnter2D(Collider2D col)
    {
        //Setando o comportamento do inimigo para seguir o player
        if (col.gameObject.tag == "Player")
        {
            enemy.GetComponent<EnemyBehaviour>().followingEnemy = true;
        }
    }
}
