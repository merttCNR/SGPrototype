using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [Header("Inputs")]
    float xInput;
    float yInput;

    [Header("Directions")]
    Vector3 moveDirection;
    Quaternion target;

    [Header("PlayerVariables")]
    float borderX = 14.2f;
    float borderY = 6.69f;
    const float playerSpeed = 10f;

    [Header("Booleans")]
    public bool isRight;
    public bool isLeft;
    public bool isDown;
    public bool isUp;
    
    void Update(){
        InputDetect();
        PlayerMove();
        PlayerBorder();
    }
    private void PlayerMove(){
        this.transform.Translate(Vector3.up * playerSpeed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            transform.localRotation = Quaternion.Euler(0,0,90);
            isLeft = true; isRight = false; isUp = false; isDown = false;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
            transform.localRotation = Quaternion.Euler(0,0,-90);
            isRight = true; isLeft = false; isUp = false; isDown = false;           
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)){
            transform.localRotation = Quaternion.Euler(0,0,0);
            isUp = true; isDown = false; isRight = false; isLeft = false;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            transform.localRotation = Quaternion.Euler(0,0,-180);
            isDown = true; isRight = false; isLeft = false; isUp = false;
        }
        
    }
    private void InputDetect(){
        xInput = Input.GetAxis("Horizontal") *2;
        target = Quaternion.Euler(0,0,xInput);
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
    }
}
