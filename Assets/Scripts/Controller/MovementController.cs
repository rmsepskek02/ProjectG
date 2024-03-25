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
        // ���콺 ���� ��ư�� ������ ��
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            // ���콺 ��ġ���� ���̸� ���� �浹�ϴ� ������Ʈ Ȯ��
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    // ������Ʈ�� �����Ͽ� �̵��� ��ġ�� ����
                    targetPosition = hit.point;
                    isDragging = true;
                }
            }
        }

        // ���콺 ��Ŭ���� ������ �ִ� ����
        if (Input.GetMouseButton(1) && isDragging)
        {
            // ������Ʈ�� ������ ��쿡��
            Vector3 direction = (targetPosition - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }

        // ���콺 ��Ŭ���� ������ ��
        if (Input.GetMouseButtonUp(1))
        {
            isDragging = false;
        }
    }
}
