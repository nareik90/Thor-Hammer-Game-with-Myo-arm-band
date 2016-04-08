#pragma strict

function Start () 
{
    //GetComponent.<Animation>().Play("orcattack");
   // yield WaitForSeconds(4.0);
    GetComponent.<Animation>().Play("orcwalk");
    yield WaitForSeconds(20.0);

   // GetComponent.<Animation>().Play("orcdamage");
    //yield WaitForSeconds(2.0);

    //GetComponent.<Animation>().Play("orcdie");
    //yield WaitForSeconds(2.0);
}
