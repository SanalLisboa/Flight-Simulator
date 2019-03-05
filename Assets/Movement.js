var rotateSpeed = 2.5;
var speed = 5.0;
var flag = 0;

function Update() {
    var transAmount = speed * Time.deltaTime;
    var rotateAmount = rotateSpeed * Time.deltaTime;

    if (Input.GetKey("up")) {
        transform.Rotate(rotateAmount, 0, 0);

    }
    if (Input.GetKey("down")) {
        transform.Rotate(-rotateAmount, 0, 0);
    }
    if (Input.GetKey("left")) {
        transform.Rotate(0, -rotateAmount, 0);
    }
    if (Input.GetKey("right")) {
        transform.Rotate(0, rotateAmount, 0);
    }

    if (Input.GetKey("z")) {
        transform.Rotate(0, 0, rotateAmount);
    }

    if (Input.GetKey("x")) {
        transform.Rotate(0, 0, -rotateAmount);
    }

    if (Input.GetKey("a")) {
        transform.Translate(0, 0, -transAmount*1.5);
        flag = 1;
    }

    if (Input.GetKey("q")) {
        transform.Translate(0, 0, -(transAmount * 2));
        flag = 2;
    }
    if(flag>0)
    {
        transform.Translate(0, 0, -transAmount);
    }
    if(flag>1)
    {
        transform.Translate(0, 0, -(transAmount * 2));
    }
}