#pragma strict


var speed = 0.5;
var anim: Animator;



function Start () {
	anim = GetComponent("Animator");
}





function Update () {

if (Input.GetKey ("a"))
{
	//		print ("left arrow key is held down");
			transform.Translate(Vector2(-10,0) * Time.deltaTime * speed);
			anim.SetTrigger("walkingLeft");

}

if (Input.GetKey ("d"))
{
//			print ("right arrow key is held down");
			transform.Translate(Vector2(10,0) * Time.deltaTime * speed);
			anim.SetTrigger("walkingRight");
			}

//else
//{
//		anim.SetTrigger("idle");
//}



        if(Input.anyKey == false)
        {
        anim.SetTrigger("idle");
        }



}