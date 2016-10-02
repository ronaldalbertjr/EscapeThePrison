using UnityEngine;
using System.Collections;

public class BotasPickScript : MonoBehaviour
{
	public GameObject player;
	public GameObject bg;

	void OnTriggerEnter2D(Collider2D col)
	{
		//faz o player pegar a bota e aumentar a velocidade e mudando o HUD
		if(col.gameObject.tag == "Player" && player.GetComponent<PlayerBehaviour>().holdingKey)
		{
			player.GetComponent<PlayerBehaviour>().wearingBoots = true;
			bg.tag = "Serio";
			Destroy(this.gameObject);
		}
	}
}
