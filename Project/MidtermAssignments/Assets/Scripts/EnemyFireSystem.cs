
using UnityEngine;
namespace TerraiJason
{
    /// <summary>
    /// �ĤH�o�g
    /// </summary>
public class EnemyFireSystem : FireSystemBase
{
        [SerializeField, Header("�ͦ����j"), Range(0, 3)]
        private float interval = 1.5f;
        private void Awake()
        {
            //�I�s�ۭq��k
            //SpawnBullet();

            //���𭫽ƩI�s��k(��k�W�� ����ɶ� ���j)
            InvokeRepeating("SpawnBullet", 0, interval);
        }
}

}
