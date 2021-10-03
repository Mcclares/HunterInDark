using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

public static class Walking
    {
    static Vector3 direction;
    static int directionOfBullet;
    public static int DirectionBullet{get {return directionOfBullet;} set {directionOfBullet = value;}}
     public static void Walk(InputDevice inputDevice, Hunter hunter) {
       
        
        direction =  new Vector2(inputDevice.Direction.X, inputDevice.Direction.Y) ;
        
        
        if(inputDevice.Direction.Right) {
            
            directionOfBullet = 1;
            hunter.transform.rotation = Quaternion.Euler(0,0,-90);
           
            
        }
        else if(inputDevice.Direction.Left) {
            hunter.transform.rotation = Quaternion.Euler(0,0,90);
            directionOfBullet = 2;
            
        }
        if(inputDevice.Direction.Down) {
           
            hunter.transform.rotation = Quaternion.Euler(0,0,180);
            directionOfBullet = 3;
            
        }
         if(inputDevice.Direction.Up) {
           
          hunter.transform.rotation = Quaternion.Euler(0,0,0);
            directionOfBullet  = 4;
            
        }
        if(inputDevice.Direction.Angle >= 44 & inputDevice.Direction.Angle <= 46){
            hunter.transform.rotation = Quaternion.Euler(0,0,-45f);
            directionOfBullet  = 5;
        }
        else if(inputDevice.Direction.Angle >= 134 & inputDevice.Direction.Angle <= 136)
        {
           hunter.transform.rotation = Quaternion.Euler(0,0,-135f);
            directionOfBullet  = 6;
        }
      
        
         if(inputDevice.Direction.Angle >= 224 & inputDevice.Direction.Angle <= 226)
        {
            hunter.transform.rotation = Quaternion.Euler(0,0,-225f);
            directionOfBullet  = 7;
        }
       
           else if(inputDevice.Direction.Angle >= 314 & inputDevice.Direction.Angle <= 316)
        {
           hunter.transform.rotation = Quaternion.Euler(0,0,-315f);
            directionOfBullet  = 8;
        }  
    
    
           hunter.transform.position = Vector3.MoveTowards(hunter.transform.position, hunter.transform.position + direction, hunter.speed * Time.deltaTime);
          
      
    }
   
}

