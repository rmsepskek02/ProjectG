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
        // ī�޶��� forward �������� ���� �Ÿ� ������ ��ġ ���
        Vector3 position = Camera.main.transform.position + Camera.main.transform.forward * distanceFromCamera;

        // ������ ����� �׸���
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireCube(position, new Vector3(sizeX, sizeY, sizeZ));

        // ������� �� �������� ��ǥ ���
        Vector3[] corners = CalculateGizmoCorners(position, sizeX, sizeY, sizeZ);
        for (int i = 0; i < 4; i++)
        {
            // �� ��ǥ�� �ʷϻ� ������ ǥ��
            Gizmos.color = pointColor;
            Gizmos.DrawSphere(corners[i], 0.1f);
        }
    }

    // ������� ������ ��ǥ ���
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
