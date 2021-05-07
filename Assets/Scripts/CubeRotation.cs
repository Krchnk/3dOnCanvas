using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 15f);
    }
}
