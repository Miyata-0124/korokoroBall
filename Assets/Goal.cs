using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText; //���x���N���A�ƕ\������e�L�X�g���i�[
    public GameObject nextButton;//���̃��x���֕Έڂ���{�^�����i�[
    public AudioSource audioSource;//���y�Đ�����R���|�[�l���g
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("�S�[��!");

        clearText.SetActive(true);//�����ɂȂ��Ă����I�u�W�F�N�g�����̃^�C�~���O�ŗL���ɂ���
        nextButton.SetActive(true);
        audioSource.Play();//Play���\�b�h�̎��s�ŉ����Đ��\
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
