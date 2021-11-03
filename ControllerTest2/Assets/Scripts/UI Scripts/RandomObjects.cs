using UnityEngine;

public class RandomObjects : MonoBehaviour
{
    public GameObject hochhaus;
    private int xPos;
    private int zPos;
    private int yPos;
    public int objectToGenerate;
    public int objectQuantity;
    public int minStreuung = -400;
    public int maxStreuung = 400;


    private void Start()
    {
        while (objectQuantity < 50)
        {
            //objectToGenerate = Random.Range(1, 8);
            xPos = Random.Range(minStreuung, maxStreuung);
            yPos = Random.Range(minStreuung, maxStreuung);
            zPos = Random.Range(minStreuung, maxStreuung);
            GameObject newObject = Instantiate(hochhaus, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            newObject.transform.localScale = new Vector3(15, 15, 15);
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
