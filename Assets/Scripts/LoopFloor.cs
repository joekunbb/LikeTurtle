using UnityEngine;

public class LoopFloor : MonoBehaviour
{
    private Renderer rendererComponent; // MeshRenderer 또는 Renderer를 참조
    public float offsetSpeed = 0.5f; // UV 이동 속도

    void Start()
    {
        // Renderer 컴포넌트 가져오기
        rendererComponent = GetComponent<Renderer>();

        // 머티리얼이 올바르게 설정되었는지 확인
        if (rendererComponent == null || rendererComponent.material == null)
        {
            Debug.LogError("Renderer 또는 Material이 설정되지 않았습니다.");
        }
    }

    void Update()
    {
        if (rendererComponent != null && rendererComponent.material != null)
        {
            // 현재 UV 오프셋 값 가져오기
            Vector2 currentOffset = rendererComponent.material.GetTextureOffset("_BaseMap");

            // Y축 방향으로 UV 오프셋 이동
            float offset = offsetSpeed * Time.deltaTime;
            Vector2 newOffset = currentOffset + new Vector2(0f, -offset);

            // 업데이트된 UV 오프셋 설정
            rendererComponent.material.SetTextureOffset("_BaseMap", newOffset);
        }
    }
}