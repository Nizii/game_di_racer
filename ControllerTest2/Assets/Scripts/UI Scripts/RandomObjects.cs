using UnityEngine;

public class RandomObjects : MonoBehaviour
{
    public GameObject hochhaus;
    public GameObject missrateneKugel;
    public GameObject pilzlis;
    public GameObject strassenlaterne;
    public GameObject alienhotel;
    public GameObject rundeStationen;
    public GameObject flames;

    private Vector3 center = new Vector3(50,50,50);
    private int xPos;
    private int zPos;
    private int yPos;

    private int objectToGenerate;
    private int index = 0;

    public int amountObjects= 50;
    public int streuungObjects = 1500;
    public int objectSize = 15;
    public int coliderSize = 15;


    private void Start()
    {
        while (index < amountObjects)
        {
            objectToGenerate = Random.Range(1, 7);
            xPos = Random.Range(streuungObjects, -streuungObjects);
            yPos = Random.Range(streuungObjects, -streuungObjects);
            zPos = Random.Range(streuungObjects, -streuungObjects);

            if (objectToGenerate == 1)
            {
                GameObject newObject = Instantiate(missrateneKugel, center + new Vector3(xPos, yPos, zPos), Quaternion.identity);
                BoxCollider collider1 = newObject.AddComponent<BoxCollider>();
                collider1.size = new Vector3(coliderSize, coliderSize, coliderSize);
                newObject.transform.localScale = new Vector3(objectSize, objectSize, objectSize);
                GameObject newObject2 = Instantiate(flames, center + new Vector3(xPos, yPos-115, zPos), Quaternion.identity);
                newObject2.transform.Rotate(90, 0, 0);
                newObject2.transform.localScale = new Vector3(objectSize, objectSize, objectSize);
            }
            
            if (objectToGenerate == 2)
            {
                GameObject newObject = Instantiate(hochhaus, center + new Vector3(xPos, yPos, zPos), Quaternion.identity);
                BoxCollider collider1 = newObject.AddComponent<BoxCollider>();
                collider1.size = new Vector3(coliderSize, coliderSize, coliderSize);
                newObject.transform.localScale = new Vector3(objectSize, objectSize, objectSize);
                GameObject newObject2 = Instantiate(flames, center + new Vector3(xPos, yPos - 115, zPos), Quaternion.identity);
                newObject2.transform.Rotate(90, 0, 0);
                newObject2.transform.localScale = new Vector3(objectSize, objectSize, objectSize);
            }
            
            if (objectToGenerate == 3)
            {
                GameObject newObject = Instantiate(pilzlis, center + new Vector3(xPos, yPos, zPos), Quaternion.identity);
                BoxCollider collider1 = newObject.AddComponent<BoxCollider>();
                collider1.size = new Vector3(coliderSize, coliderSize, coliderSize);
                newObject.transform.localScale = new Vector3(objectSize, objectSize, objectSize);
                GameObject newObject2 = Instantiate(flames, center + new Vector3(xPos, yPos - 115, zPos), Quaternion.identity);
                newObject2.transform.Rotate(90, 0, 0);
                newObject2.transform.localScale = new Vector3(objectSize, objectSize, objectSize);
            }

            if (objectToGenerate == 4)
            {
                GameObject newObject = Instantiate(strassenlaterne, center + new Vector3(xPos, yPos, zPos), Quaternion.identity);
                BoxCollider collider1 = newObject.AddComponent<BoxCollider>();
                collider1.size = new Vector3(coliderSize, coliderSize, coliderSize);
                newObject.transform.localScale = new Vector3(objectSize, objectSize, objectSize);
                GameObject newObject2 = Instantiate(flames, center + new Vector3(xPos, yPos - 115, zPos), Quaternion.identity);
                newObject2.transform.Rotate(90, 0, 0);
                newObject2.transform.localScale = new Vector3(objectSize, objectSize, objectSize);
            }

            if (objectToGenerate == 5)
            {
                GameObject newObject = Instantiate(alienhotel, center + new Vector3(xPos, yPos, zPos), Quaternion.identity);
                BoxCollider collider1 = newObject.AddComponent<BoxCollider>();
                collider1.size = new Vector3(coliderSize, coliderSize, coliderSize);
                newObject.transform.localScale = new Vector3(objectSize, objectSize, objectSize);
                GameObject newObject2 = Instantiate(flames, center + new Vector3(xPos, yPos - 115, zPos), Quaternion.identity);
                newObject2.transform.Rotate(90, 0, 0);
                newObject2.transform.localScale = new Vector3(objectSize, objectSize, objectSize);
            }

            if (objectToGenerate == 6)
            {
                GameObject newObject = Instantiate(rundeStationen, center + new Vector3(xPos, yPos, zPos), Quaternion.identity);
                BoxCollider collider1 = newObject.AddComponent<BoxCollider>();
                collider1.size = new Vector3(coliderSize, coliderSize, coliderSize);
                newObject.transform.localScale = new Vector3(objectSize, objectSize, objectSize);
                GameObject newObject2 = Instantiate(flames, center + new Vector3(xPos, yPos - 115, zPos), Quaternion.identity);
                newObject2.transform.Rotate(90, 0, 0);
                newObject2.transform.localScale = new Vector3(objectSize, objectSize, objectSize);
            }

            //yield return new WaitForSeconds(0.1f);
            index += 1;
        }
    }
}
