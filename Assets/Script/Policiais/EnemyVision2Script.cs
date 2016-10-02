using UnityEngine;
using System.Collections;

public class EnemyVision2Script : MonoBehaviour
{
    public GameObject enemy;
	public GameObject player;

    void OnTriggerEnter2D(Collider2D col)
    {
        //Setando o comportamento do inimigo para seguir o player
		if (col.gameObject.tag == "Player" && !player.GetComponent<PlayerBehaviour>().wearingCopClothes)
        {
            enemy.GetComponent<Enemy2Behaviour>().followingPlayer = true;
        }
    }
}
