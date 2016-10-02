using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyVisionScript : MonoBehaviour
{
	public GameObject enemy;
	public GameObject player;
	public GameObject dontFollow;

    void OnTriggerEnter2D(Collider2D col)
    {
        //Setando o comportamento do inimigo para seguir o player
		if (col.gameObject.tag == "Player" && !player.GetComponent<PlayerBehaviour>().enemy1DontFollow && !player.GetComponent<PlayerBehaviour>().wearingCopClothes && enemy.GetComponent<EnemyBehaviour>().canSeePlayer)
        {
			enemy.GetComponent<EnemyBehaviour>().followingPlayer = true;
        }
    }
}
