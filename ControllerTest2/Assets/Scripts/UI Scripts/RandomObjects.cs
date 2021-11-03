using UnityEngine;

public class RandomObjects : MonoBehaviour
{
    public GameObject hochhaus;
    private int xPos;
    private int zPos;
    private int yPos;
    public int objectToGenerate;
    public int objectQuantity;
    private int min = -200;
    private int max = 200;


    private void Start()
    {
        while (objectQuantity < 30)
        {
            //objectToGenerate = Random.Range(1, 8);
            xPos = Random.Range(min, max);
            yPos = Random.Range(min, max);
            zPos = Random.Range(min, max);
            GameObject newObject = Instantiate(hochhaus, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            newObject.transform.localScale = new Vector3(10, 10, 10);
            /*
            if (objectToGenerate == 1)
            {
                Instantiate(hochhaus, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            }
            */
            //yield return new WaitForSeconds(0.1f);
            objectQuantity += 1;
        }
    }
}
