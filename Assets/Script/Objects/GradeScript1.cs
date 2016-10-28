using UnityEngine;
using System.Collections;

public class GradeScript1 : MonoBehaviour
{
    [SerializeField]
    private GameObject prisioneiro;
    [SerializeField]
    private AudioSource audio;
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player" && Input.GetKey(KeyCode.Return))
        {
            audio.Play();
            Destroy(this.gameObject);
            prisioneiro.GetComponent<Rebelde1Behaviour>().canWalk = true;
            prisioneiro.GetComponent<Animator>().SetBool("IsWalking", true);
        }
    }
}
