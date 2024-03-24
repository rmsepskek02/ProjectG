using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Color gizmoColor = Color.red;
    public Color pointColor = Color.green;
    public float distanceFromCamera = 10f;
    public float sizeX = 10f;
    public float sizeY = 1f;
    public float sizeZ = 10f;

    private void OnDrawGizmos()
    {
        // 카메라의 forward 방향으로 일정 거리 떨어진 위치 계산
        Vector3 position = Camera.main.transform.position + Camera.main.transform.forward * distanceFromCamera;

        // 빨간색 기즈모 그리기
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireCube(position, new Vector3(sizeX, sizeY, sizeZ));

        // 기즈모의 각 꼭지점의 좌표 계산
        Vector3[] corners = CalculateGizmoCorners(position, sizeX, sizeY, sizeZ);
        for (int i = 0; i < 4; i++)
        {
            // 각 좌표를 초록색 점으로 표시
            Gizmos.color = pointColor;
            Gizmos.DrawSphere(corners[i], 0.1f);
        }
    }

    // 기즈모의 꼭지점 좌표 계산
    private Vector3[] CalculateGizmoCorners(Vector3 center, float xSize, float ySize, float zSize)
    {
        Vector3[] corners = new Vector3[8];
        Vector3 halfExtents = new Vector3(xSize / 2f, ySize / 2f, zSize / 2f);

        corners[4] = center + new Vector3(-halfExtents.x, -halfExtents.y, -halfExtents.z);
        corners[5] = center + new Vector3(halfExtents.x, -halfExtents.y, -halfExtents.z);
        corners[6] = center + new Vector3(halfExtents.x, -halfExtents.y, halfExtents.z);
        corners[7] = center + new Vector3(-halfExtents.x, -halfExtents.y, halfExtents.z);
        corners[0] = center + new Vector3(-halfExtents.x, halfExtents.y, -halfExtents.z);
        corners[1] = center + new Vector3(halfExtents.x, halfExtents.y, -halfExtents.z);
        corners[2] = center + new Vector3(halfExtents.x, halfExtents.y, halfExtents.z);
        corners[3] = center + new Vector3(-halfExtents.x, halfExtents.y, halfExtents.z);

        return corners;
    }
}
