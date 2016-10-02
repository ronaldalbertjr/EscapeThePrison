using UnityEngine;
using System.Collections;

public class GradeScript2 : MonoBehaviour
{
    [SerializeField] private GameObject player;
	[SerializeField] private AudioSource audio;
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player" && player.GetComponent<PlayerBehaviour>().holdingKey)
        {
			audio.Play();
            Destroy(this.gameObject);
        }
    }    	
}
