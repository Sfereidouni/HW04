using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForThePrefab : MonoBehaviour {

    GameObject[] CubeArray;
    IEnumerator CreateArray;
    public Material cubeMaterial;
    public Camera camera;

	void Start () 
    {
        StartCoroutine(ChangeColor());
	}
    void Update()
    {
        RaycastHit objectInFront;
       
        Vector3 castedRayDirection = transform.TransformDirection(Vector3.forward);
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 10000))

        {
            string objectInFrontName = hit.transform.name;
            Debug.Log("There is an object in front of me! It's name is" + objectInFrontName);

            Destroy(hit.transform.gameObject);

        }
      

    }

    IEnumerator ChangeColor()
    {
        if (cubeMaterial.color != Color.grey){
            cubeMaterial.color = Color.grey;
        }
        else {
                cubeMaterial.color = Color.red;
        }
        yield return new WaitForSeconds(0.6f);
    }

}
