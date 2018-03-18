using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Session04_Homework : MonoBehaviour 
{
    public GameObject CubePrefab;
    IEnumerator MakeArray;

    void Start()
    {
        MakeArray = MakeArrayOfCubes(); 
        StartCoroutine(MakeArray);
    }



    IEnumerator MakeArrayOfCubes()
    {
        while (Time.time < 30)
        {
            Vector3 position = new Vector3(1.5f * Time.time, 2.5f * Time.time, 1.85f * Time.time);
            Quaternion rotation = new Quaternion(0, 0, 0, 1);
            GameObject newCubeArray = Instantiate(CubePrefab, position, rotation);
            yield return new WaitForSeconds(1);
        }
    }
}
