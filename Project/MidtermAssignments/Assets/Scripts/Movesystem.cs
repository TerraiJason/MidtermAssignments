
using UnityEngine;
namespace TerraiJason
{
    /// <summary>
    /// ���ʨt��
    /// </summary>
    public class Movesystem : MonoBehaviour
    {
        [Range(-10, 0), SerializeField, Header("���ʳt��")]
        private float speed = -3.5f;

        private void Update()
        {
            //transform ������transform ����
            //translate(x,y,z) �첾
            //Time.deltaTime �C�V�ƪ�O�ɶ�
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
    

    
}
