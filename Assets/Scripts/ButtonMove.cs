using UnityEngine;
using UnityEngine.UI;

public class ButtonMove : MonoBehaviour
{
    public float moveSpeed = 2f; // 移动速度
    private Vector3 targetPosition; // 目标位置
    private bool isMoving = false; // 是否正在移动

    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                isMoving = false; // 到达目标后停止移动
            }
        }
    }

    public void MoveToPosition(Vector3 newPosition)
    {
        targetPosition = newPosition;
        isMoving = true; // 开始移动
    }

    public void OnButtonClick()
    {
        // 点击时移动到新位置
        MoveToPosition(new Vector3(3, 0, 0)); // 将目标位置替换为你想要的目标
    }
}
