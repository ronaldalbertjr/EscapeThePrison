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
	void Update()
    {
        // Faz o personagem olhar para o mouse
        
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(mousePosition.x, mousePosition.y), Vector2.zero, 0);
        lookPosition = mousePosition - this.transform.position;
        rotation = Quaternion.LookRotation(lookPosition);
        rotation = new Quaternion(0f, 0f, rotation.z / 8, rotation.w / 8);
        this.transform.rotation = rotation;
        
    }
	void FixedUpdate ()
    {
        //Movimenta o personagem nas 8 direcões
        movementHorizontal = Input.GetAxis("Horizontal");
        movementVertical = Input.GetAxis("Vertical");

        this.GetComponent<Rigidbody2D>().velocity = new Vector2(movementHorizontal * speed, movementVertical * speed); 

    }
}
