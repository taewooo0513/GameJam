using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawn : MonoBehaviour
{
    public Transform Cam;
    public Transform[] SpawnPos = new Transform[4];
    public GameObject NomalBlock;
    public GameObject GreenBlock;
    public GameObject PinkBlock;
    public GameObject BlueBlock;
    bool BlueStart = false;
    private float size = 5;
    private bool pinkStart;
    private float randSize;
    private bool GreenStart;
    private int Rand;
    private bool YellowStop;
    public float BlueCurTime,BlueSpawnStart,GameTime,SetTime, CurTime, GreenSpawnTime, GreenCurTime, GreenStartSpawnTime,CamRotStart,CamRotCurTime,PinkStartSpawn,PinkCurTime,ShakeStartTime;
    public List<GameObject> ObjectList = new List<GameObject>();
    public List<GameObject> GreenList = new List<GameObject>();
    public List<GameObject> PinkList = new List<GameObject>();
    public List<GameObject> BlueList = new List<GameObject>();


    private float Camrot;
    // Start is called before the first frame update
    void Start()
    {
        CurTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        BlueCurTime += Time.deltaTime;
        PinkCurTime += Time.deltaTime;
        GameTime += Time.deltaTime;
        CamRotCurTime += Time.deltaTime;
        GreenCurTime += Time.deltaTime;
        CurTime += Time.deltaTime;
        Rand = Random.Range(0, 4);
        if(GameTime > 33&&GameTime < 36)
        {
            YellowStop = true;
        }
        if(GameTime > 36&& GameTime < 53)
        {
            pinkStart = true;
        }
        if(Camrot < 360)
        {
        if(CamRotCurTime > CamRotStart)
        {
        Camrot += 0.15f   ;
            Cam.transform.rotation = Quaternion.EulerRotation(0,0,Camrot* Mathf.Deg2Rad);
        }

        }
        if (GreenCurTime > GreenStartSpawnTime&&GreenCurTime < GreenStartSpawnTime+4)
        {
            GreenStart = true;
        }
        
        if (GreenStart)
        {
            if(GreenCurTime>GreenSpawnTime)
            {
                GreenCurTime = 0;
                GreenList.Add(Instantiate(GreenBlock, SpawnPos[Rand].transform.position, Quaternion.Euler(0, 0, (Rand * 90))));
            }
        }
        if(YellowStop != true)
        if (CurTime > SetTime)
        {

            ObjectList.Add(Instantiate(NomalBlock, SpawnPos[Rand].transform.position, Quaternion.Euler(0, 0, (Rand * 90))));
            CurTime = 0;
        }
        if(pinkStart == true )
        {
            if(size< 7&& GameTime <47)
            {
            size += 0.01f;
            }

            Cam.GetComponent<Camera>().orthographicSize = size;
            if(PinkCurTime > PinkStartSpawn)
            {

                ObjectList.Add(Instantiate(PinkBlock, SpawnPos[Rand].transform.position, Quaternion.Euler(0, 0, (Rand * 90))));
                PinkCurTime = 0;
            }
        }
        if(GameTime< 46&&GameTime > 42)
        {
            randSize = Random.RandomRange(65f,70f)/10f;
            Cam.GetComponent<Camera>().orthographicSize = randSize;
        }
        if (GameTime >= 46 && GameTime <= 47)
        {
            GreenStart = false;
            pinkStart = false;
        }
            if (GameTime > 47 && GameTime < 48)
        {

            if(size  > -5)
            size -= 0.04f;
            Cam.GetComponent<Camera>().orthographicSize = size;

        }
        if (GameTime >= 48 && GameTime <= 49)
        {
            BlueStart = true;
        }
        if(BlueStart == true)
        {
            if(BlueCurTime > BlueSpawnStart)
            {
            BlueList.Add(Instantiate(BlueBlock, SpawnPos[Rand].transform.position, Quaternion.Euler(0, 0, (Rand * 90))));
                BlueCurTime = 0;
            }
        }
        Debug.Log(randSize);
        if(GameTime > 58)
        {
            Cam.GetComponent<Camera>().orthographicSize = 5;

        }
    }
}
