var projectile : Rigidbody;
var speed = 1000;
var timelimit=5;

function Start () {
	
}

function Update () {
	
	 if (Input.GetKey("d")) {
		
		 clone = Instantiate(projectile,transform.position,transform.rotation);
		 clone.velocity = transform.TransformDirection(Vector3(0,0,-speed));
		 Destroy(clone.gameObject, 5 );
		
		
		 
	 }
	
	
}
