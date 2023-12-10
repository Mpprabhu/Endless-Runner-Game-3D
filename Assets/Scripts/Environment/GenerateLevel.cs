using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zpos = 58;
    public bool creatingsection = false;
    public int secnum;

    void Update()
    {
        if(creatingsection == false)
        {
            creatingsection = true;
            StartCoroutine(GenerateSection());
        }
    }
    IEnumerator GenerateSection ()
    {
        secnum = Random.Range(0,6);
        Instantiate(section[secnum],new Vector3(0,0,zpos),Quaternion.identity);
        zpos+=58;
        yield return new WaitForSeconds(2);
        creatingsection = false;
    }
}
