using UnityEngine;

public class MovementController : MonoBehaviour
{
    private Camera mainCamera;
    private bool isDragging;
    private Vector3 targetPosition;
    private float moveSpeed = 5f;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        // 마우스 왼쪽 버튼이 눌렸을 때
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            // 마우스 위치에서 레이를 쏴서 충돌하는 오브젝트 확인
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    // 오브젝트를 선택하여 이동할 위치를 설정
                    targetPosition = hit.point;
                    isDragging = true;
                }
            }
        }

        // 마우스 우클릭을 누르고 있는 동안
        if (Input.GetMouseButton(1) && isDragging)
        {
            // 오브젝트를 선택한 경우에만
            Vector3 direction = (targetPosition - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }

        // 마우스 우클릭이 떼졌을 때
        if (Input.GetMouseButtonUp(1))
        {
            isDragging = false;
        }
    }
}
