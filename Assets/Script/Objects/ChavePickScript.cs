using UnityEngine;
using System.Collections;

public class ChavePickScript : MonoBehaviour
{
    public GameObject player;
	public GameObject bg;

    void OnTriggerStay2D(Collider2D col)
    {
        //Faz o player segurar a chave e mudando o HUD
        if(col.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerBehaviour>().holdingKey = true;
			bg.tag = "Serio";
            Destroy(this.gameObject);
        }
    }
}
