using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{

    public Vector3 center;
    public Vector3 size;



    private void Start()
    {
        GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject cube4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject cube5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject cube6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject cube7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject cube8 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject cube9 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject cube10 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject cube11 = GameObject.CreatePrimitive(PrimitiveType.Cube);


        cube1.transform.position = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.y / 2));
        cube2.transform.position = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.y / 2));
        cube3.transform.position = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.y / 2));
        cube4.transform.position = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.y / 2));
        cube5.transform.position = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.y / 2));
        cube6.transform.position = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.y / 2));
        cube7.transform.position = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.y / 2));
        cube8.transform.position = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.y / 2));
        cube9.transform.position = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.y / 2));
        cube10.transform.position = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.y / 2));
        cube11.transform.position = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.y / 2));

        cube1.transform.localScale = new Vector3(5, 5, 5);
        cube2.transform.localScale = new Vector3(5, 5, 5);
        cube3.transform.localScale = new Vector3(5, 5, 5);
        cube4.transform.localScale = new Vector3(5, 5, 5);
        cube5.transform.localScale = new Vector3(5, 5, 5);
        cube6.transform.localScale = new Vector3(5, 5, 5);
        cube7.transform.localScale = new Vector3(5, 5, 5);
        cube8.transform.localScale = new Vector3(5, 5, 5);
        cube9.transform.localScale = new Vector3(5, 5, 5);
        cube10.transform.localScale = new Vector3(5, 5, 5);
        cube11.transform.localScale = new Vector3(5, 5, 5);
    }


    /*
    public void Spawn()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.y / 2));
        Instantiate(sphere, pos, Quaternion.identity);
    }


    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Go()
    {
        Gizmos.DrawCube(center, size);
    }
   
    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 20; i++) {
            cube.transform.position = new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.y / 2));
        }   
    }
    */
}
