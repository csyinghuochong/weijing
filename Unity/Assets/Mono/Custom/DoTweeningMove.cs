using DG.Tweening;
using UnityEngine;

public enum MoveTypeEnum
{ 
    None,
    MoveX,
    MoveY,
}

public class DoTweeningMove : MonoBehaviour
{

    private bool init = true;
    private bool front = true;
    private Vector2 oldPostition;
    private Vector2 startPosition;

    public MoveTypeEnum moveTypeEnum = MoveTypeEnum.None;
    public float moveDistance = 0f;
    public bool isLoop = false;

    private Vector2 curPostion;
    private float passTime = 0;
    public float MoveToTime;

    // Start is called before the first frame update
    void Start()
    {
        if (MoveToTime == 0)
        {
            MoveToTime = 0.15f;
        }
    }

    public void SetOldPosition(Vector2 vector2)
    {
        oldPostition = vector2;
    }

    private void OnEnable()
    {
        this.passTime = 0f;
        if (init)
        {
            init = false;
            this.oldPostition = this.gameObject.GetComponent<RectTransform>().anchoredPosition;
            this.startPosition = this.gameObject.GetComponent<RectTransform>().anchoredPosition;
        }

        if (moveTypeEnum == MoveTypeEnum.MoveX)
        {
            this.startPosition = this.oldPostition;
            this.startPosition.x += this.moveDistance;
            this.transform.localPosition = startPosition;
            this.gameObject.GetComponent<RectTransform>().anchoredPosition = startPosition;
        }

        if (moveTypeEnum == MoveTypeEnum.MoveY)
        {
            this.startPosition = this.oldPostition;
            this.startPosition.y += this.moveDistance;
            this.transform.localPosition = startPosition;
            this.gameObject.GetComponent<RectTransform>().anchoredPosition = startPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.deltaTime > 0.1f)
        {
            return;
        }

        if (this.passTime > MoveToTime)
        {
            if (!this.isLoop)
            {
                this.curPostion = this.oldPostition;
                this.enabled = false;
                return;
            }
            this.front = !this.front;
            this.passTime = 0f;
        }
        this.passTime += Time.deltaTime;
        if (this.front)
        {
            this.curPostion = (this.passTime / MoveToTime) * (this.oldPostition - this.startPosition) + this.startPosition;
        }
        else
        {
            this.curPostion = (this.passTime / MoveToTime) * (this.startPosition - this.oldPostition) + this.oldPostition;
        }
        if (this.passTime >= MoveToTime)
        {
            this.curPostion = this.front ? this.oldPostition : this.startPosition;
        }
       this.gameObject.GetComponent<RectTransform>().anchoredPosition = this.curPostion;
    }
}
