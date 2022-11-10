
using UnityEngine;
namespace TerraiJason
{
    /// <summary>
    /// 敵人發射
    /// </summary>
public class EnemyFireSystem : FireSystemBase
{
        [SerializeField, Header("生成間隔"), Range(0, 3)]
        private float interval = 1.5f;
        private void Awake()
        {

            InvokeRepeating("SpawnBullet", 0, interval);
        }
}

}
