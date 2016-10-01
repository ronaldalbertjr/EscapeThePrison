using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed;
    float movementHorizontal;
    float movementVertical;
    Vector3 mousePosition;
    Vector3 lookPosition;
    Quaternion rotation;
	void Start ()
    {
	
	}
	void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lookPosition = mousePosition - this.transform.position;
        rotation = Quaternion.LookRotation(lookPosition);
        rotation = new Quaternion(0f, 0f, rotation.z/2, rotation.w/2);
        this.transform.rotation = rotation;
    }
	void FixedUpdate ()
    {
        movementHorizontal = Input.GetAxis("Horizontal");
        movementVertical = Input.GetAxis("Vertical");

        this.GetComponent<Rigidbody2D>().velocity = new Vector2(movementHorizontal * speed, movementVertical * speed);
	
	}
}
