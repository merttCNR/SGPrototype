using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Inputs")]
    float xInput;
    float yInput;

    [Header("Direction")]
    Vector3 moveDirection;

    [Header("PlayerVariables")]
    float borderX = 14.2f;
    float borderY = 6.69f;
    const float playerSpeed = 10f;

    void Update(){
        InputDetect();
        PlayerMove();
        PlayerBorder();
    }
    private void PlayerMove(){
        this.transform.Translate(moveDirection * playerSpeed * Time.deltaTime);
    }
    private void InputDetect(){
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
        moveDirection = new Vector3(xInput,yInput,0);
    }
    private void PlayerBorder(){
        if(this.transform.position.x >= borderX){       // -> bu kod sağ tarafa giderse karakter soldan gelmesini sağlıyor.
            this.transform.position = new Vector3(-borderX,transform.position.y,0); // -> eğer pozisyon borderX'ten büyük ve eşitse -borderX yap.
        }
        else if(this.transform.position.x <= -borderX){
            this.transform.position = new Vector3(borderX,transform.position.y,0); // -> eğer pozisyon -borderX'ten küçük ve eşitse borderX yap.
        }
        if(this.transform.position.y >= borderY){
            this.transform.position = new Vector3(transform.position.x,-borderY,0); // -> eğer pozisyon borderY'ten büyük ve eşitse -borderY yap.
        }
        else if(this.transform.position.y <= -borderY){
            this.transform.position = new Vector3(transform.position.x,borderY,0); // -> eğer pozisyon -borderY'ten küçük ve eşitse borderY yap.
        }
       /* if(this.transform.position.x <= -borderX){
            this.transform.position = new Vector3(-borderX,transform.position.y,0); -> bu kod kenarları sınırlandırıyor.
        } */
    }
}
