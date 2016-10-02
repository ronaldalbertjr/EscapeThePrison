using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
    public Vector3 offset;
    public GameObject player;

	void Update()
	{
        //Mudando a posicão da camera de acordo com as cenas
        this.transform.position = new Vector3(player.transform.position.x + offset.x, player.transform.position.y + offset.y, player.transform.position.z + offset.z);
    }
}
