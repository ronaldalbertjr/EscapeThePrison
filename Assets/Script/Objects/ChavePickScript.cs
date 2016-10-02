using UnityEngine;
using System.Collections;

public class ChavePickScript : MonoBehaviour
{
    public GameObject player;
	public GameObject bg;
    [SerializeField]
    private AudioSource audio;
    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerBehaviour>().holdingKey = true;
            audio.Play();
			bg.tag = "Serio";
            Destroy(this.gameObject);
        }
    }
}
