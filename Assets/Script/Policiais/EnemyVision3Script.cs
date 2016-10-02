using UnityEngine;
using System.Collections;

public class EnemyVision3Script : MonoBehaviour
{
    public GameObject player;
	[SerializeField]
    public GameObject[] enemy;

    void OnTriggerStay2D(Collider2D col)
    {
		//Setando o comportamento do inimigo para seguir o player
        if (col.gameObject.tag == "Player" && !player.GetComponent<PlayerBehaviour>().wearingCopClothes)
        {
			foreach(GameObject i in enemy)
			{
	            i.GetComponent<EnemyBehaviour3>().followingPlayer = true;
			}
        }
    }
}
