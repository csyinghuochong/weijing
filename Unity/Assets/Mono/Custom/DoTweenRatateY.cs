using UnityEngine;

public class DoTweenRatateY: MonoBehaviour
{
    public float Speed = 100f;

    void LateUpdate()
    {
        float y = Speed * Time.deltaTime + this.transform.eulerAngles.y;
        if (y > 360)
        {
            y %= 360f;
        }

        this.transform.eulerAngles = new Vector3(0, y, 0);
    }
}