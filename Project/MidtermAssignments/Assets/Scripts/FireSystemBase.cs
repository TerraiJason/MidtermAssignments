using UnityEngine;
namespace TerraiJason
{
    /// <summary>
    /// �o�g�t�ΰ����O
    /// �ͦ��l�u
    /// </summary>
    public class FireSystemBase : MonoBehaviour
{
        [SerializeField, Header("�l�u�w�s��")]
        private GameObject prefabBullet;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointSpawn;

        protected void SpawnBullet()
        {
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        }
}

}
