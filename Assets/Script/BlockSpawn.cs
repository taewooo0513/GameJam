using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawn : MonoBehaviour
{
    public Transform[] SpawnPos = new Transform[4];
    public GameObject NomalBlock;
    private int Rand;
    public float SetTime, CurTime;
    public List<GameObject>ObjectList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        CurTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CurTime += Time.deltaTime;
        Rand = Random.Range(0, 4);
        if (CurTime > SetTime)
        {
            
            ObjectList.Add(Instantiate(NomalBlock, SpawnPos[Rand].transform.position,Quaternion.Euler(0,0,(Rand *90))));
            CurTime = 0;
        }
    }
}
