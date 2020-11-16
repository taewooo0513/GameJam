using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Block : MonoBehaviour
{
    
    public Transform PlayerPos;
    private Vector3 Dir;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        

        if (PlayerPos.position.x - this.transform.position.x == 0)
        {
            if (PlayerPos.position.y - this.transform.position.y >0 )
            {
                Dir.y = speed;
            }
            else if (PlayerPos.position.y - this.transform.position.y < 0)
            {
                Dir.y = -speed;

            }
        }
        else if(PlayerPos.position.y - this.transform.position.y == 0)
        {
            if (PlayerPos.position.x - this.transform.position.x > 0)
            {
                Dir.x = speed;

            }
            else if (PlayerPos.position.x - this.transform.position.x < 0)
            {
                Dir.x = -speed;

            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Dir * Time.deltaTime;
    }
    private void OnDestroy()
    {
       
    }
}
