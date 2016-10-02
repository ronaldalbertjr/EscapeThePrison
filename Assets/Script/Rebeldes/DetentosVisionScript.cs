using UnityEngine;
using System.Collections;

public class DetentosVisionScript : MonoBehaviour
{
	[SerializeField] private GameObject player;
	[SerializeField] private GameObject[] detento;

	void OnTriggerStay2D(Collider2D col)
	{
		//Setando o comportamento dos detentos para seguir o player
		if (col.gameObject.tag == "Player" && player.GetComponent<PlayerBehaviour>().wearingCopClothes)
		{
            foreach (GameObject i in detento)
            {
                i.GetComponent<RebeldesBehaviour>().followingPlayer = true;
            }
		}
	}
}
