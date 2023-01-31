using UnityEngine;

public class DoTweenRatate : MonoBehaviour
{

    public float Speed = 100f;

    void LateUpdate()
    {
        float z = Speed * Time.deltaTime + this.transform.eulerAngles.z;
        if (z > 360)
        {
            z = z % 360f;
        }
        this.transform.eulerAngles = new Vector3(0, 0,z);
    }
}