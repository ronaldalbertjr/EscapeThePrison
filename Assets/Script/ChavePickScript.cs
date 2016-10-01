using UnityEngine;
using System.Collections;

public class ChavePickScript : MonoBehaviour
{
    public GameObject player;
    void OnTriggerStay2D(Collider2D col)
    {
        //Faz o player segurar a chave
        if(col.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerBehaviour>().holdingKey = true;
            Destroy(this.gameObject);
        }
    }
}
