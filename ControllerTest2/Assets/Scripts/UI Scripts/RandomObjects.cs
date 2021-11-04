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

    private int xPos;
    private int zPos;
    private int yPos;

    private int objectToGenerate;
    private int index = 0;

    public int anzahlObjecte = 50;
    public int streuungObjecte = 400;
    public int objectGrösse = 15;


    private void Start()
    {
        while (index < anzahlObjecte)
        {
            objectToGenerate = Random.Range(1, 7);
            xPos = Random.Range(streuungObjecte, -streuungObjecte);
            yPos = Random.Range(streuungObjecte, -streuungObjecte);
            zPos = Random.Range(streuungObjecte, -streuungObjecte);

            if (objectToGenerate == 1)
            { 
                GameObject newObject = Instantiate(missrateneKugel, new Vector3(xPos, yPos, zPos), Quaternion.identity);
                newObject.transform.localScale = new Vector3(objectGrösse, objectGrösse, objectGrösse);
                GameObject newObject2 = Instantiate(flames, new Vector3(xPos, yPos-115, zPos), Quaternion.identity);
                newObject2.transform.Rotate(0, 90, 0);
                newObject2.transform.localScale = new Vector3(objectGrösse, objectGrösse, objectGrösse);
            }
            
            if (objectToGenerate == 2)
            {
                GameObject newObject = Instantiate(hochhaus, new Vector3(xPos, yPos, zPos), Quaternion.identity);
                newObject.transform.localScale = new Vector3(objectGrösse, objectGrösse, objectGrösse);
                GameObject newObject2 = Instantiate(flames, new Vector3(xPos, yPos - 115, zPos), Quaternion.identity);
                newObject2.transform.Rotate(0, 90, 0);
                newObject2.transform.localScale = new Vector3(objectGrösse, objectGrösse, objectGrösse);
            }
            
            if (objectToGenerate == 3)
            {
                GameObject newObject = Instantiate(pilzlis, new Vector3(xPos, yPos, zPos), Quaternion.identity);
                newObject.transform.localScale = new Vector3(objectGrösse, objectGrösse, objectGrösse);
                GameObject newObject2 = Instantiate(flames, new Vector3(xPos, yPos - 115, zPos), Quaternion.identity);
                newObject2.transform.Rotate(0, 90, 0);
                newObject2.transform.localScale = new Vector3(objectGrösse, objectGrösse, objectGrösse);
            }

            if (objectToGenerate == 4)
            {
                GameObject newObject = Instantiate(strassenlaterne, new Vector3(xPos, yPos, zPos), Quaternion.identity);
                newObject.transform.localScale = new Vector3(objectGrösse, objectGrösse, objectGrösse);
                GameObject newObject2 = Instantiate(flames, new Vector3(xPos, yPos - 115, zPos), Quaternion.identity);
                newObject2.transform.Rotate(0, 90, 0);
                newObject2.transform.localScale = new Vector3(objectGrösse, objectGrösse, objectGrösse);
            }

            if (objectToGenerate == 5)
            {
                GameObject newObject = Instantiate(alienhotel, new Vector3(xPos, yPos, zPos), Quaternion.identity);
                newObject.transform.localScale = new Vector3(objectGrösse, objectGrösse, objectGrösse);
                GameObject newObject2 = Instantiate(flames, new Vector3(xPos, yPos - 115, zPos), Quaternion.identity);
                newObject2.transform.Rotate(0, 90, 0);
                newObject2.transform.localScale = new Vector3(objectGrösse, objectGrösse, objectGrösse);
            }

            if (objectToGenerate == 6)
            {
                GameObject newObject = Instantiate(rundeStationen, new Vector3(xPos, yPos, zPos), Quaternion.identity);
                newObject.transform.localScale = new Vector3(objectGrösse, objectGrösse, objectGrösse);
                GameObject newObject2 = Instantiate(flames, new Vector3(xPos, yPos - 115, zPos), Quaternion.identity);
                newObject2.transform.Rotate(0, 90, 0);
                newObject2.transform.localScale = new Vector3(objectGrösse, objectGrösse, objectGrösse);
            }

            //yield return new WaitForSeconds(0.1f);
            index += 1;
        }
    }
}
