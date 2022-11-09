
using UnityEngine;
namespace TerraiJason
{
    /// <summary>
    /// ��������
    /// </summary>
    public class AirplaneController2D : MonoBehaviour
    {
        [Header("���ʳt��")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizental = 4f;
        [Header("�Ϥ�")]

        [SerializeField]
        private Sprite pictureUp;

        [SerializeField]
        private Sprite pictureMiddle;

        [SerializeField]
        private Sprite pictureDown;

        [SerializeField, Header("�Ϥ���V����")]
        private SpriteRenderer spr;

        private void Update()
        {
            //�W�U WS Vertical
            //���k AD Horizontal

            //�W W +1
            //�U S -1
            //�S�� 0

            float v = Input.GetAxis("Vertical");

            //�k D +1
            //�� A -1
            //�S�� 0

            float h = Input.GetAxis("Horizontal");

                
            transform.Translate(
                speedHorizental * Time.deltaTime * h,
                speedVertical * Time.deltaTime * v, 
                0);
        //�p�G v �j�� 0 �Ϥ� ���� �V�W
        if(v > 0)
            {
                print("�V�W");

                spr.sprite = pictureUp;
            }

        //�p�G v ���� 0 �Ϥ� ���� ����
        if(v == 0)
            {
                print("����");

                spr.sprite = pictureMiddle;
            }
        //�p�G v �p�� 0 �Ϥ� ���� �V�U
        if(v < 0)
            {
                print("�V�U");

                spr.sprite = pictureDown;

            }
        }
        
    }

}

