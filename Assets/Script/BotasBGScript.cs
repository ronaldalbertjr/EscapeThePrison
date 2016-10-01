using UnityEngine;
using System.Collections;

public class BotasBGScript : MonoBehaviour
{
    //Pegar as botas na sala secreta
    public GameObject player;
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player" && player.GetComponent<PlayerBehaviour>().holdingKey)
        {
            this.GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }     
}
