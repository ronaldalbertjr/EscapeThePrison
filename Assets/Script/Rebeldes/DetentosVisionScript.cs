using UnityEngine;
using System.Collections;

public class DetentosVisionScript : MonoBehaviour
{
	public GameObject player;
	public GameObject detento;

	void OnTriggerStay2D(Collider2D col)
	{
		//Setando o comportamento dos detentos para seguir o player
		if (col.gameObject.tag == "Player" && player.GetComponent<PlayerBehaviour>().wearingCopClothes)
		{
			detento.GetComponent<RebeldesBehaviour>().followingPlayer = true;
		}
	}
}
