using UnityEngine;

public class CameraControlExam06 : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public float offset;
    public Camera targetCamera;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 player1Pos = player1.transform.position;
        Vector3 player2Pos = player2.transform.position;

        Vector3 centerPoint = new Vector3(player1Pos.x, transform.position.y,+ player2Pos.z);
        transform.position = centerPoint;
        float distance = Vector3.Distance(player1Pos, player2Pos);
        targetCamera.orthographicSize = distance;
        
        
        
    }
}
