using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    float yatay=0;
    float dikey=0;
    
    public int hiz;
    int sayac=0;
    public int toplanilacakObjeSayisi;
    public Text sayacText;
    public Text oyunBittiText;

    void Start()
    {
        Rigidbody fizik= GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {
        Rigidbody fizik= GetComponent<Rigidbody>();
        Vector3 vec= new Vector3(yatay,0,dikey);

        fizik.AddForce(vec*hiz);
        yatay=0;
        dikey=0;
    }
    public void Sbas(){
        dikey-=1;
    }
    public void Wbas(){
        dikey+=1;
    }
    public void Abas(){
        yatay-=1;
    }
    public void Dbas(){
        yatay+=1;
    }
    public void YatayKalk(){
        yatay=0;
    }
    public void DikeyKalk(){
        dikey=0;
    }

    void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag=="engel"){
            Destroy(other.gameObject); 
            sayac++;
            sayacText.text="Sayac= "+ sayac;
            if(sayac==toplanilacakObjeSayisi){
                    oyunBittiText.text="OYUN BİTTİ";
            }
        }
         
        
    }
}
