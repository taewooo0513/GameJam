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
        audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.Stop();
        audioSource.clip = Clip;
        audioSource.loop = false;
        audioSource.time = 0;

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
                            audioSource.Play();
                        }
                    }

                }
                else if (Object.transform.GetComponent<BlockSpawn>().ObjectList[0].transform.position.y - this.transform.position.y < 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().ObjectList[0].transform.position, this.transform.position) < 3)
                    {
                        if (Input.GetKeyDown(KeyCode.DownArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>().ObjectList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>().ObjectList.Remove(Object.transform.GetComponent<BlockSpawn>().ObjectList[0]);
                            audioSource.Play();
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
                            audioSource.Play();
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
                            audioSource.Play();
                        }
                    }
                }
            }

        }

        //초록블럭
         if (Object.transform.GetComponent<BlockSpawn>().GreenList.Count != 0)
        {
            if (Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position.x - this.transform.position.x == 0)
            {
                if (Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position.y - this.transform.position.y > 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position, this.transform.position) < 3)
                    {
                        if (Input.GetKeyDown(KeyCode.UpArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>().GreenList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>().GreenList.Remove(Object.transform.GetComponent<BlockSpawn>().GreenList[0]);
                            audioSource.Play();
                        }
                    }

                }
                else if (Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position.y - this.transform.position.y < 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position, this.transform.position) < 3)
                    {
                        if (Input.GetKeyDown(KeyCode.DownArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>().GreenList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>().GreenList.Remove(Object.transform.GetComponent<BlockSpawn>().GreenList[0]);
                            audioSource.Play();
                        }
                    }
                }
            }
            if (Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position.y - this.transform.position.y == 0)
            {

                if (Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position.x - this.transform.position.x > 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position, this.transform.position) < 3)
                    {
                        if (Input.GetKeyDown(KeyCode.RightArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>().GreenList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>().GreenList.Remove(Object.transform.GetComponent<BlockSpawn>().GreenList[0]);
                            audioSource.Play();
                        }
                    }
                }
                else if (Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position.x - this.transform.position.x < 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position, this.transform.position) < 3)
                    {
                        if (Input.GetKeyDown(KeyCode.LeftArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>().GreenList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>().GreenList.Remove(Object.transform.GetComponent<BlockSpawn>().GreenList[0]);
                            audioSource.Play();
                        }
                    }
                }
            }

        }
        //핑크블럭
        if (Object.transform.GetComponent<BlockSpawn>().PinkList.Count != 0)
        {
            if (Object.transform.GetComponent<BlockSpawn>().PinkList[0].transform.position.x - this.transform.position.x == 0)
            {
                if (Object.transform.GetComponent<BlockSpawn>().PinkList[0].transform.position.y - this.transform.position.y > 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().PinkList[0].transform.position, this.transform.position) < 3)
                    {
                        if (Input.GetKeyDown(KeyCode.UpArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>().PinkList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>().PinkList.Remove(Object.transform.GetComponent<BlockSpawn>().PinkList[0]);
                            audioSource.Play();
                        }
                    }

                }
                else if (Object.transform.GetComponent<BlockSpawn>().PinkList[0].transform.position.y - this.transform.position.y < 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().PinkList[0].transform.position, this.transform.position) < 3)
                    {
                        if (Input.GetKeyDown(KeyCode.DownArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>().PinkList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>().PinkList.Remove(Object.transform.GetComponent<BlockSpawn>().PinkList[0]);
                            audioSource.Play();
                        }
                    }
                }
            }
            if (Object.transform.GetComponent<BlockSpawn>().PinkList[0].transform.position.y - this.transform.position.y == 0)
            {

                if (Object.transform.GetComponent<BlockSpawn>().PinkList[0].transform.position.x - this.transform.position.x > 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().PinkList[0].transform.position, this.transform.position) < 3)
                    {
                        if (Input.GetKeyDown(KeyCode.RightArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>().PinkList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>().PinkList.Remove(Object.transform.GetComponent<BlockSpawn>().PinkList[0]);
                            audioSource.Play();
                        }
                    }
                }
                else if (Object.transform.GetComponent<BlockSpawn>().PinkList[0].transform.position.x - this.transform.position.x < 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().PinkList[0].transform.position, this.transform.position) < 3)
                    {
                        if (Input.GetKeyDown(KeyCode.LeftArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>().PinkList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>().PinkList.Remove(Object.transform.GetComponent<BlockSpawn>().PinkList[0]);
                            audioSource.Play();
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
        if (other.CompareTag("PinkBlock"))
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
        if (other.CompareTag("GreenBlock"))
        {
            audioSource = gameObject.AddComponent<AudioSource>();

            audioSource.Stop();
            audioSource.clip = Clip;
            audioSource.loop = false;
            audioSource.time = 0;
            audioSource.Play();

            Object.transform.GetComponent<BlockSpawn>().GreenList.Remove(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}
