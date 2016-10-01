using UnityEngine;
using System.Collections;

public class EnemyVision3Script : MonoBehaviour {
    public GameObject player;
    public GameObject enemy;
    void OnTriggerEnter2D(Collider2D col)
    {
        //Setando o comportamento do inimigo para seguir o player
        if (col.gameObject.tag == "Player" && !player.GetComponent<PlayerBehaviour>().wearingCopClothes)
        {
            enemy.GetComponent<EnemyBehaviour3>().followingPlayer = true;
        }
    }
}
