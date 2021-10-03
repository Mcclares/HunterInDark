using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 target;
    public Vector2 offset ;
    public float dumping = 1.5f;
    private Transform player;
    public bool isLeft;
    public bool isUp;
    private int lastX;
    private int lastY;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindObjectOfType<Hunter>().transform;
        transform.position = player.transform.position;
        offset = new Vector2(Mathf.Abs(offset.x), Mathf.Abs(offset.y));
        
    }

    // Update is called once per frame
    void Update()
    {
          
            if(player) {
                int currentX = Mathf.RoundToInt(player.position.x);
                int currentY = Mathf.RoundToInt(player.position.y);
           
                if(currentX > lastX) isLeft = false;
                else if(currentX < lastX) isLeft = true;
                lastX = Mathf.RoundToInt(player.position.x);
                if(currentY > lastY) isUp = true;
                else if(currentY < lastY) isUp = false;
                lastY = Mathf.RoundToInt(player.position.y);
                Vector3 target;
                if(isLeft) {
                target  = new Vector3 (player.position.x - offset.x,player.position.y  ,-10);
                    }
                else {
                target = new Vector3 (player.position.x + offset.x, player.position.y ,-10);
                }
                if(isUp) {
                    target = new Vector3(player.position.x, player.position.y + offset.y, - 10);
                }else {
                    target = new Vector3(player.position.x, player.position.y - offset.y, - 10);
                }
                Vector3 currentPosition = Vector3.Lerp(transform.position,target, dumping * Time.deltaTime);
                transform.position = currentPosition;
                }
    }
    public void FindPlayer(bool playerIsLeft) {
        player = GameObject.FindObjectOfType<Hunter>().transform;
        
        if(playerIsLeft) {
            // transform.position = new Vector3 (player.position.x - offset.x, 0.0f,transform.position.z);
            transform.position = new Vector3 (player.position.x - offset.x, 0.0f,transform.position.z);
        }
        else {
            //  transform.position = new Vector3 (player.position.x + offset.x, 0.0f ,transform.position.z);
              transform.position = new Vector3 (player.position.x + offset.x, 0.0f,transform.position.z);
        }

    }
}
