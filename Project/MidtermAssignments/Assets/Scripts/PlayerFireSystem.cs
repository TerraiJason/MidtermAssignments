
using UnityEngine;
namespace TerraiJason
{
    /// <summary>
    /// ���a�o�g
    /// </summary>
public class PlayerFireSystem : FireSystemBase
{
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }

        }
 
}

}

