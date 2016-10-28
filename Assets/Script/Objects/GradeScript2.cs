using UnityEngine;
using System.Collections;

public class GradeScript2 : MonoBehaviour
{
    [SerializeField] private GameObject player;
	[SerializeField] private AudioSource audio;
    bool unlocked = false;
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player" && player.GetComponent<PlayerBehaviour>().holdingKey && !unlocked)
        {
            StartCoroutine(gradeMoving());
            unlocked = true;
        }
    }  
    IEnumerator gradeMoving()
    {
        audio.Play();
        for (int i = 0; i < 30; i++)
        {
            this.transform.position -= new Vector3(0f, 0.1f);
            yield return new WaitForSeconds(0.01f);
        }

        yield return null;
    }      	
}
