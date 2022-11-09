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

        //�ۭq��k
        //�ͦ��l�u
        //protected �O�@�ŧO:���\�l���O�s��
        protected void SpawnBullet()
        {
            //��Ҥ�(���� �y�� ����)
            //�ͦ� �l�u�w�s�� ���׻P�y�и�l�u�ͦ��I�ۦP
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        }
}

}
