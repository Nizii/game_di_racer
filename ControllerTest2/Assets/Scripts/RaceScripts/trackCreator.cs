using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class trackCreator : MonoBehaviour
{

    private Vector3 inputVector = new Vector3(0, 0, 0);
    private float rollInput = 0f;

    Mesh mesh;
    List<Vector3> centerUpVectors = new List<Vector3>();
    List<Vector3> centerPositionVectors = new List<Vector3>();
    List<Vector3> centerForwardVectors = new List<Vector3>();
    List<Vector3> verticesList = new List<Vector3>();
    List<int> trianglesList = new List<int>();

    Queue<GameObject> trackBorders = new Queue<GameObject>();

    private GameObject trackBordersHolder;

    [SerializeField]
    private float trackWidth = 2f;

    [SerializeField]
    private float speed = 2f;

    private float effectiveSpeed;

    [SerializeField]
    private float rollSpeed = 1f;


    [SerializeField]
    private float pitchSpeed = .04f;


    [SerializeField]
    private float yawSpeed = .1f;

    [SerializeField]
    private GameObject trackHead;


    [SerializeField]
    private Material glowLineTopMaterial;

    [SerializeField]
    private Material glowLineSideMaterial;

    [SerializeField]
    private Material horizontalTrackLineMaterial;

    [SerializeField]
    private float horizontalTrackLineWidth = .4f;

    private GameObject horizontalTrackLines;

    private int physicUpdateCount = 0;

    private bool gameOver = false;

    private Mesh glowLineTL; // Top Left
    private Mesh glowLineTR; // Top Right
    private Mesh glowLineSL; // Side Left
    private Mesh glowLineSR; // Sider Right

    private List<Vector3> glowLineTLVerticesList = new List<Vector3>();
    private List<int> glowLineTLTrianglesList = new List<int>();

    private List<Vector3> glowLineTRVerticesList = new List<Vector3>();
    private List<int> glowLineTRTrianglesList = new List<int>();

    private List<Vector3> glowLineSLVerticesList = new List<Vector3>();
    private List<int> glowLineSLTrianglesList = new List<int>();

    private List<Vector3> glowLineSRVerticesList = new List<Vector3>();
    private List<int> glowLineSRTrianglesList = new List<int>();
    /*
    //GameOver Countdown
    float startingGameoverTime = 4f;
    float currentGameoverTime = 0f;

    //GameOver Sound
    public AudioSource applauseSound;
    public AudioClip applause;
    */

    // Start is called before the first frame update
    void Start()
    {
        effectiveSpeed = speed;

        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        this.AddVertices();

        glowLineTL = new Mesh();
        glowLineTR = new Mesh();
        glowLineSL = new Mesh();
        glowLineSR = new Mesh();

        GameObject glowLineTLGO = new GameObject("GlowLineTopLeft");
        glowLineTLGO.transform.parent = this.transform;
        glowLineTLGO.transform.position = new Vector3(0, 0.01f, 0);
        glowLineTLGO.AddComponent<MeshFilter>().mesh = glowLineTL;
        glowLineTLGO.AddComponent<MeshRenderer>().material = glowLineTopMaterial;
        GameObject glowLineTRGO = new GameObject("GlowLineTopRight");
        glowLineTRGO.transform.parent = this.transform;
        glowLineTRGO.AddComponent<MeshFilter>().mesh = glowLineTR;
        glowLineTRGO.AddComponent<MeshRenderer>().material = glowLineTopMaterial;
        glowLineTRGO.transform.position = new Vector3(0, 0.01f, 0);
        GameObject glowLineSLGO = new GameObject("GlowLineSideLeft");
        glowLineSLGO.transform.parent = this.transform;
        glowLineSLGO.AddComponent<MeshFilter>().mesh = glowLineSL;
        glowLineSLGO.AddComponent<MeshRenderer>().material = glowLineSideMaterial;
        GameObject glowLineSRGO = new GameObject("GlowLineSideRight");
        glowLineSRGO.transform.parent = this.transform;
        glowLineSRGO.AddComponent<MeshFilter>().mesh = glowLineSR;
        glowLineSRGO.AddComponent<MeshRenderer>().material = glowLineSideMaterial;


        horizontalTrackLines = new GameObject("horizontalTrackLines");
        horizontalTrackLines.transform.parent = this.transform;


        trackBordersHolder = new GameObject("trackBorders");
        trackBordersHolder.transform.parent = this.transform;

    }


    public void OnMoveTracker(InputAction.CallbackContext value)
    {
        inputVector = new Vector3(value.ReadValue<Vector2>().x * yawSpeed * effectiveSpeed, -value.ReadValue<Vector2>().y * pitchSpeed * effectiveSpeed, 0f);
        rollInput = -value.ReadValue<Vector2>().x;
    }


    // Update is called once per frame
    void Update()
    {


    }

    private void FixedUpdate()
    {
        if (!gameOver)
        {
            if (physicUpdateCount % 2 == 0)
            {
                Collider trackHeadCollider = trackHead.GetComponent<Collider>();
                foreach (Vector3 vertex in verticesList)
                {
                    if (trackHeadCollider.bounds.Contains(vertex))
                    {
                        if (ColliderContainsPoint(trackHeadCollider, vertex))
                        {
                            SceneManager.LoadScene("EndRacer");
                            //GameOver();
                            //this.gameOver = true;
                        }
                    }
                }
                BuildTrack();
            }
            physicUpdateCount++;
        }
    }

    /*
    private void GameOver()
    {
        currentGameoverTime -= 1 * Time.deltaTime;
        if (currentGameoverTime <= 0)
        {
            applauseSound.PlayOneShot(applause);
            SceneManager.LoadScene("End");
        }
    }
    */

    private void BuildTrack()
    {
        //Controller Inputs
        Vector3 inputVectorY = new Vector3(0f, inputVector.y, 0f);
        Vector3 newForward = trackHead.transform.rotation * inputVector + trackHead.transform.forward;

        Vector3 newUP = (trackHead.transform.rotation * inputVectorY + trackHead.transform.up).normalized;
        trackHead.transform.rotation = Quaternion.LookRotation(newForward, newUP);
        trackHead.transform.Rotate(0f, 0f, rollInput * rollSpeed * effectiveSpeed, Space.Self);
        trackHead.transform.position += trackHead.transform.forward * effectiveSpeed;

        centerUpVectors.Add(newUP);
        centerForwardVectors.Add(trackHead.transform.forward * effectiveSpeed);
        centerPositionVectors.Add(trackHead.transform.position);

        ////Create Mesh Parts////
        this.AddVertices();
        this.AddTriangles();
        this.AddColliderBoxes();
        if (physicUpdateCount % 8 == 0)
        {
            this.DrawHorizontalTrackLine();
        }
        UpdateMesh();
    }



    private void AddVertices()
    {
        //Build Vertices
        Vector3 vertex0 = trackHead.transform.position - trackHead.transform.right * trackWidth * .5f;
        Vector3 vertex1 = trackHead.transform.position + trackHead.transform.right * trackWidth * .5f;
        Vector3 vertex2 = vertex0 - trackHead.transform.right + trackHead.transform.up * 2;
        Vector3 vertex3 = vertex1 + trackHead.transform.right + trackHead.transform.up * 2;
        Vector3 vertex4 = vertex2 - trackHead.transform.right * .5f;
        Vector3 vertex5 = vertex3 + trackHead.transform.right * .5f;
        Vector3 vertex6 = vertex2 - trackHead.transform.up * 3.2f;
        Vector3 vertex7 = vertex3 - trackHead.transform.up * 3.2f;

        verticesList.Add(vertex0);
        verticesList.Add(vertex1);
        verticesList.Add(vertex2);
        verticesList.Add(vertex3);
        verticesList.Add(vertex4);
        verticesList.Add(vertex5);
        verticesList.Add(vertex6);
        verticesList.Add(vertex7);

        //TL Line
        glowLineTLVerticesList.Add(vertex2 - trackHead.transform.right * .3f);
        glowLineTLVerticesList.Add(vertex4);

        //TR Line
        glowLineTRVerticesList.Add(vertex5);
        glowLineTRVerticesList.Add(vertex3 + trackHead.transform.right * .3f);

        //SL Line
        glowLineSLVerticesList.Add(vertex0 + trackHead.transform.up * 0.01f);
        glowLineSLVerticesList.Add(vertex0 - trackHead.transform.right * 0.27f + trackHead.transform.up * 0.5f);

        //SR Line
        glowLineSRVerticesList.Add(vertex1 + trackHead.transform.right * 0.27f + trackHead.transform.up * 0.5f);
        glowLineSRVerticesList.Add(vertex1 + trackHead.transform.up * 0.01f);
    }


    private void AddTriangles()
    {
        int vertexCount = verticesList.Count;
        trianglesList.Add(vertexCount - 16); //0
        trianglesList.Add(vertexCount - 8); //8
        trianglesList.Add(vertexCount - 15); //1

        trianglesList.Add(vertexCount - 15); //1
        trianglesList.Add(vertexCount - 8); //8
        trianglesList.Add(vertexCount - 7); //9

        trianglesList.Add(vertexCount - 15); //1
        trianglesList.Add(vertexCount - 7); //9
        trianglesList.Add(vertexCount - 13); //3

        trianglesList.Add(vertexCount - 13); //3
        trianglesList.Add(vertexCount - 7); //9
        trianglesList.Add(vertexCount - 5); //11

        trianglesList.Add(vertexCount - 14); //2
        trianglesList.Add(vertexCount - 6); //10
        trianglesList.Add(vertexCount - 16); //0

        trianglesList.Add(vertexCount - 16); //0
        trianglesList.Add(vertexCount - 6); //10
        trianglesList.Add(vertexCount - 8); //8

        trianglesList.Add(vertexCount - 12); //4
        trianglesList.Add(vertexCount - 4); //12
        trianglesList.Add(vertexCount - 14); //2

        trianglesList.Add(vertexCount - 14); //2
        trianglesList.Add(vertexCount - 4); //12
        trianglesList.Add(vertexCount - 6); //10

        trianglesList.Add(vertexCount - 13); //3
        trianglesList.Add(vertexCount - 5); //11
        trianglesList.Add(vertexCount - 11); //5

        trianglesList.Add(vertexCount - 11); //5
        trianglesList.Add(vertexCount - 5); //11
        trianglesList.Add(vertexCount - 3); //13

        trianglesList.Add(vertexCount - 10); //6
        trianglesList.Add(vertexCount - 9); //7
        trianglesList.Add(vertexCount - 2); //14

        trianglesList.Add(vertexCount - 9); //7
        trianglesList.Add(vertexCount - 1); //15
        trianglesList.Add(vertexCount - 2); //14

        trianglesList.Add(vertexCount - 10); //6
        trianglesList.Add(vertexCount - 2); //14
        trianglesList.Add(vertexCount - 12); //4

        trianglesList.Add(vertexCount - 2); //14
        trianglesList.Add(vertexCount - 4); //12
        trianglesList.Add(vertexCount - 12); //4

        trianglesList.Add(vertexCount - 9); //7
        trianglesList.Add(vertexCount - 11); //5
        trianglesList.Add(vertexCount - 1); //15

        trianglesList.Add(vertexCount - 1); //15
        trianglesList.Add(vertexCount - 11); //5
        trianglesList.Add(vertexCount - 3); //13

        int vertexCountTL = glowLineTLVerticesList.Count;
        glowLineTLTrianglesList.Add(vertexCountTL - 4);
        glowLineTLTrianglesList.Add(vertexCountTL - 3);
        glowLineTLTrianglesList.Add(vertexCountTL - 1);

        glowLineTLTrianglesList.Add(vertexCountTL - 4);
        glowLineTLTrianglesList.Add(vertexCountTL - 1);
        glowLineTLTrianglesList.Add(vertexCountTL - 2);

        int vertexCountTR = glowLineTRVerticesList.Count;
        glowLineTRTrianglesList.Add(vertexCountTR - 4);
        glowLineTRTrianglesList.Add(vertexCountTR - 3);
        glowLineTRTrianglesList.Add(vertexCountTR - 1);

        glowLineTRTrianglesList.Add(vertexCountTR - 4);
        glowLineTRTrianglesList.Add(vertexCountTR - 1);
        glowLineTRTrianglesList.Add(vertexCountTR - 2);

        int vertexCountSL = glowLineSRVerticesList.Count;
        glowLineSLTrianglesList.Add(vertexCountSL - 4);
        glowLineSLTrianglesList.Add(vertexCountSL - 3);
        glowLineSLTrianglesList.Add(vertexCountSL - 1);

        glowLineSLTrianglesList.Add(vertexCountSL - 4);
        glowLineSLTrianglesList.Add(vertexCountSL - 1);
        glowLineSLTrianglesList.Add(vertexCountSL - 2);

        int vertexCountSR = glowLineSLVerticesList.Count;
        glowLineSRTrianglesList.Add(vertexCountSR - 4);
        glowLineSRTrianglesList.Add(vertexCountSR - 3);
        glowLineSRTrianglesList.Add(vertexCountSR - 1);

        glowLineSRTrianglesList.Add(vertexCountSR - 4);
        glowLineSRTrianglesList.Add(vertexCountSR - 1);
        glowLineSRTrianglesList.Add(vertexCountSR - 2);
    }

    private void DrawHorizontalTrackLine()
    {
        GameObject horizontalTrackLine = new GameObject("horizontalTrackLine");
        horizontalTrackLine.transform.parent = horizontalTrackLines.transform;
        Mesh horizontalTrackLineMesh = new Mesh();
        horizontalTrackLine.AddComponent<MeshFilter>().mesh = horizontalTrackLineMesh;
        horizontalTrackLine.AddComponent<MeshRenderer>().material = horizontalTrackLineMaterial;
        Vector3[] vertices = new[] { (verticesList[verticesList.Count - 8] - trackHead.transform.forward * horizontalTrackLineWidth + trackHead.transform.up * 0.01f), verticesList[verticesList.Count - 7] - trackHead.transform.forward * horizontalTrackLineWidth + trackHead.transform.up * 0.01f, verticesList[verticesList.Count - 8] + trackHead.transform.up * 0.01f, verticesList[verticesList.Count - 7] + trackHead.transform.up * 0.01f };
        int[] triangles = new[] { 0, 2, 1, 2, 3, 1 };
        horizontalTrackLineMesh.vertices = vertices;
        horizontalTrackLineMesh.triangles = triangles;
        horizontalTrackLineMesh.RecalculateNormals();
    }

    private void AddColliderBoxes()
    {
        int vertexCount = verticesList.Count;
        GameObject leftColliderGO, rightColliderGO;
        BoxCollider leftCollider, rightCollider;
        if (trackBorders.Count > 400)
        {
            leftColliderGO = trackBorders.Dequeue();
            rightColliderGO = trackBorders.Dequeue();
            leftCollider = leftColliderGO.GetComponent<BoxCollider>();
            rightCollider = rightColliderGO.GetComponent<BoxCollider>();

        }
        else
        {
            leftColliderGO = new GameObject("leftBorder");
            leftColliderGO.tag = "Track";
            rightColliderGO = new GameObject("rightBorder");
            rightColliderGO.tag = "Track";
            leftCollider = leftColliderGO.AddComponent<BoxCollider>();
            rightCollider = rightColliderGO.AddComponent<BoxCollider>();
        }
        //Box Left
        leftColliderGO.transform.parent = trackBordersHolder.transform;
        Vector3 leftColliderGOForward = verticesList[vertexCount - 8] - verticesList[vertexCount - 16];
        //Vector3 leftColliderGOUP = verticesList[vertexCount - 16] - verticesList[vertexCount - 14];
        Vector3 leftColliderGOUP = verticesList[vertexCount - 10] - verticesList[vertexCount - 14];
        leftColliderGO.transform.rotation = Quaternion.LookRotation(leftColliderGOForward, leftColliderGOUP);
        leftColliderGO.transform.position = verticesList[vertexCount - 6] + (verticesList[vertexCount - 16] - verticesList[vertexCount - 6]) * 0.5f;
        leftCollider.size = new Vector3(.1f, leftColliderGOUP.magnitude, leftColliderGOForward.magnitude);
        leftCollider.isTrigger = true;
        trackBorders.Enqueue(leftColliderGO);

        //Box Right
        rightColliderGO.transform.parent = trackBordersHolder.transform;
        Vector3 rightColliderGOForward = verticesList[vertexCount - 7] - verticesList[vertexCount - 15];
        //Vector3 rightColliderGOUP = verticesList[vertexCount - 15] - verticesList[vertexCount - 13];
        Vector3 rightColliderGOUP = verticesList[vertexCount - 9] - verticesList[vertexCount - 13];
        rightColliderGO.transform.rotation = Quaternion.LookRotation(rightColliderGOForward, rightColliderGOUP);
        rightColliderGO.transform.position = verticesList[vertexCount - 5] + (verticesList[vertexCount - 15] - verticesList[vertexCount - 5]) * 0.5f;
        rightCollider.size = new Vector3(.1f, rightColliderGOUP.magnitude, rightColliderGOForward.magnitude);
        rightCollider.isTrigger = true;
        trackBorders.Enqueue(rightColliderGO);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Track" && other.tag != "Player") // my Track head hit something
        {
            Destroy(other.gameObject);
        }
    }

    private void UpdateMesh()
    {
        mesh.Clear();

        mesh.vertices = verticesList.ToArray();
        mesh.triangles = trianglesList.ToArray();

        mesh.RecalculateNormals();

        glowLineTL.Clear();
        glowLineTL.vertices = glowLineTLVerticesList.ToArray();
        glowLineTL.triangles = glowLineTLTrianglesList.ToArray();
        glowLineTL.RecalculateNormals();

        glowLineTR.Clear();
        glowLineTR.vertices = glowLineTRVerticesList.ToArray();
        glowLineTR.triangles = glowLineTRTrianglesList.ToArray();
        glowLineTR.RecalculateNormals();

        glowLineSL.Clear();
        glowLineSL.vertices = glowLineSLVerticesList.ToArray();
        glowLineSL.triangles = glowLineSLTrianglesList.ToArray();
        glowLineSL.RecalculateNormals();

        glowLineSR.Clear();
        glowLineSR.vertices = glowLineSRVerticesList.ToArray();
        glowLineSR.triangles = glowLineSRTrianglesList.ToArray();
        glowLineSR.RecalculateNormals();
    }

    bool ColliderContainsPoint(Collider colliderToCheck, Vector3 posToCheck)
    {
        Vector3 offset = colliderToCheck.bounds.center - posToCheck;
        Ray inputRay = new Ray(posToCheck, offset.normalized);
        RaycastHit rHit;

        if (!colliderToCheck.Raycast(inputRay, out rHit, offset.magnitude * 1.1f))
            return true;
        else
            return false;
    }
    public float GetSpeed()
    {
        return this.speed;
    }
    public float GetEffectiveSpeed()
    {
        return this.effectiveSpeed;
    }
    public void CalculateEffectiveSpeed(float carTrackHeadDistance)
    {
        float newEffectiveSpeed = this.speed;

        if (carTrackHeadDistance > 150f)
        {
            newEffectiveSpeed *= .6f;
        }
        if (carTrackHeadDistance > 100f && carTrackHeadDistance <= 150f)
        {
            newEffectiveSpeed *= .7f;
        }
        if (carTrackHeadDistance > 50f && carTrackHeadDistance <= 100f)
        {
            newEffectiveSpeed *= .75f;
        }
        if (carTrackHeadDistance > 36f && carTrackHeadDistance <= 50f)
        {
            newEffectiveSpeed *= .8f;
        }
        if (carTrackHeadDistance > 0f && carTrackHeadDistance <= 30f)
        {
            newEffectiveSpeed *= 1.2f;
        }

        this.effectiveSpeed = newEffectiveSpeed;
    }

    public Vector3[] GetNearestCenterUp(Vector3 currentCarPos)
    {
        float lastDistance = float.MaxValue;
        float shortestDistance = float.MaxValue;
        int shortestDistanceIndex = centerPositionVectors.Count - 1;
        for (int i = centerPositionVectors.Count - 1; i >= 0; i--)
        {
            Vector3 centerPositionVector = centerPositionVectors[i];
            float currentDistance = (currentCarPos - centerPositionVector).magnitude;

            if (currentDistance < shortestDistance)
            {
                shortestDistance = currentDistance;
                shortestDistanceIndex = i;
            }
            //Optimze Break Condition!
            if (currentDistance > lastDistance)
            {
                break;
            }
            lastDistance = currentDistance;

        }
        float carTrackHeadDistance = 0f;
        for (int i = centerForwardVectors.Count - 1; i >= shortestDistanceIndex; i--)
        {
            carTrackHeadDistance += centerForwardVectors[i].magnitude;
        }
        CalculateEffectiveSpeed(carTrackHeadDistance);
        Debug.Log("carTrackHeadDistance: " + carTrackHeadDistance);

        return new[] { centerPositionVectors[shortestDistanceIndex], centerUpVectors[shortestDistanceIndex], centerForwardVectors[shortestDistanceIndex] };

    }
}
