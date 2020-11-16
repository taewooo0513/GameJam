using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Object;
    public AudioClip Clip;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Object.transform.GetComponent<BlockSpawn>().ObjectList.Count != 0)
        {
            if (Object.transform.GetComponent<BlockSpawn>().ObjectList[0].transform.position.x - this.transform.position.x == 0)
            {
                if (Object.transform.GetComponent<BlockSpawn>().ObjectList[0].transform.position.y - this.transform.position.y > 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().ObjectList[0].transform.position, this.transform.position) < 3)
                    {
                        if (Input.GetKeyDown(KeyCode.UpArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>().ObjectList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>().ObjectList.Remove(Object.transform.GetComponent<BlockSpawn>().ObjectList[0]);
                        }
                    }

                }
                else if (Object.transform.GetComponent<BlockSpawn>().ObjectList[0].transform.position.y - this.transform.position.y < 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().ObjectList[0].transform.position, this.transform.position) <3)
                    {
                        if (Input.GetKeyDown(KeyCode.DownArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>().ObjectList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>().ObjectList.Remove(Object.transform.GetComponent<BlockSpawn>().ObjectList[0]);
                        }
                    }
                }
            }
            if (Object.transform.GetComponent<BlockSpawn>().ObjectList[0].transform.position.y - this.transform.position.y == 0)
            {

                if (Object.transform.GetComponent<BlockSpawn>().ObjectList[0].transform.position.x - this.transform.position.x > 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().ObjectList[0].transform.position, this.transform.position) < 3)
                    {
                        if (Input.GetKeyDown(KeyCode.RightArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>().ObjectList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>().ObjectList.Remove(Object.transform.GetComponent<BlockSpawn>().ObjectList[0]);
                        }
                    }
                }
                else if (Object.transform.GetComponent<BlockSpawn>().ObjectList[0].transform.position.x - this.transform.position.x < 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().ObjectList[0].transform.position, this.transform.position) < 3)
                    {
                        if (Input.GetKeyDown(KeyCode.LeftArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>().ObjectList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>().ObjectList.Remove(Object.transform.GetComponent<BlockSpawn>().ObjectList[0]);
                        }
                    }
                }
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Block"))
        {
            audioSource = gameObject.AddComponent<AudioSource>();

            audioSource.Stop();
            audioSource.clip = Clip;
            audioSource.loop = false;
            audioSource.time = 0;
            audioSource.Play();

            Object.transform.GetComponent<BlockSpawn>().ObjectList.Remove(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}
