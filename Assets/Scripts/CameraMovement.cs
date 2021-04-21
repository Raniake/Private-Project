using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] private Camera cam;
    [SerializeField] private Transform target;
    //[SerializeField] private float distanceToTarget = 10;

    private Vector3 previousPosition;
    public Vector3 cameraPosition;
    //public Vector2 panLimit;

    void Start()
    {
        cameraPosition = cam.transform.position;

        //print(cameraPosition.x);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);

            //cam.enabled = false;
            //print(cam.enabled);

        }
        else if (Input.GetMouseButton(2))
        {
            //print("that is it");
            Vector3 newPosition = cam.ScreenToViewportPoint(Input.mousePosition);
            Vector3 direction = previousPosition - newPosition;

            float rotationAroundYAxis = -direction.x * 180; // camera moves horizontally
            float rotationAroundXAxis = direction.y * 180; // camera moves vertically

            cam.transform.position = target.position;

            cam.transform.Rotate(new Vector3(1, 0, 0), rotationAroundXAxis);
            cam.transform.Rotate(new Vector3(0, 1, 0), rotationAroundYAxis, Space.World); // <— This is what makes it work!

            //Camera maincam = GameObject.Find("FocusCamera").GetComponent<Camera>();


            cam.transform.Translate(new Vector3(-cameraPosition.x, cameraPosition.y, -cameraPosition.z));
           
            //cameraPosition.y += 4f * Time.deltaTime;
            cameraPosition.z += 4f * Time.deltaTime;
            cameraPosition.x += 4f * Time.deltaTime;
            //cameraPosition.y -= 4f * Time.deltaTime;
            cameraPosition.z -= 4f * Time.deltaTime;
            cameraPosition.x -= 4f * Time.deltaTime;
            transform.position = cameraPosition;
            previousPosition = newPosition;
          
        }
        if (Input.GetKey("up"))
            cam.transform.position += Vector3.up * 10f * Time.deltaTime;
        if (Input.GetKey("down"))
            cam.transform.position += -Vector3.up * 10f * Time.deltaTime;
        if (Input.GetKey("right"))
            cam.transform.position += -Vector3.right * 10f * Time.deltaTime;
        if (Input.GetKey("left"))
            cam.transform.position += -Vector3.left * 10f * Time.deltaTime;
    }
}