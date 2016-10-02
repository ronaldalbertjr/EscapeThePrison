using UnityEngine;
using System.Collections;

public class GradeScript3 : MonoBehaviour
{
    public GameObject[] prisioneiros;
    public GameObject outraGrade;
	[SerializeField] private AudioSource audio;
    void OnTriggerStay2D(Collider2D col)
    {
        if(Input.GetKey(KeyCode.Return) && col.tag == "Player")
        {
            foreach(GameObject i in prisioneiros)
            {
                i.GetComponent<RebeldesBehaviour>().revolution = true;
            }
        }
        if(col.tag == "Prisioneiros")
        {
            Destroy(this.gameObject);
            Destroy(outraGrade);
			audio.Play();
            foreach (GameObject i in prisioneiros)
            {
                i.GetComponent<RebeldesBehaviour>().revolution = false;
                i.GetComponent<RebeldesBehaviour>().revolution2 = true;
            }
        }
    }
}
