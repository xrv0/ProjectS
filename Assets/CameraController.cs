using UnityEngine;

public class CameraController : MonoBehaviour {

    public float panSpeed = 20f;
    public float panBorderThickness = 10f;
    public float scrollSpeed = 10f;
    public float minY = 10f;
    public float maxY = 200f;

    // Update is called once per frame
    void Update(){

        Vector3 pos = transform.position;

        if  (Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            pos.z += panSpeed * Time.deltaTime;
        }
        if  (Input.mousePosition.y <= panBorderThickness)
        {
            pos.z -= panSpeed * Time.deltaTime;
        }
        if  (Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if  (Input.mousePosition.x <= panBorderThickness)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeed * 100f * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        transform.position = pos;

    }
}
