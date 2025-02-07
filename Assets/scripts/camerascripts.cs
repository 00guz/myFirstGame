
using UnityEngine;

public class camerascripts : MonoBehaviour
{
    public GameObject targetObject;

    public Vector3 cameraOffset;

    
    
    void LateUpdate()
    {
        transform.position = new Vector3(
        targetObject.transform.position.x + cameraOffset.x,
        0f,
        targetObject.transform.position.z + cameraOffset.z);
        
    }


}
