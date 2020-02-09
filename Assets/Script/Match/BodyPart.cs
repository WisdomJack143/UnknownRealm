using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnknownRealm.Network.Events;
namespace UnknownRealm.Match
{

    public abstract class BodyPart : MonoBehaviour
    {
        /*
        public enum Part
        {
            HEAD, NECK, BODY, PLEVIS, LEFT_HAND, LEFT_ARM, RIGHT_HAND, RIGHT_ARM, LEFT_LEG, LEFT_FOOT, RIGHT_LEG, RIGHT_FOOT, CUSTOM
        }
        //Client
        public Part part;
        */
        private RagDoll doll;
        private Sprite sprite;
        protected float minJointAngle;
        protected float maxJointAngle;
        protected HingeJoint2D joint;


        protected BodyPart() {
 
        }

        //同步服务器设置的冲击力、anglelimit

        //碰撞全部由服务器计算Client=Receiver&mover
        public  virtual void OnHit(RagDollHitEvent e) { }
        protected Vector2 calculateDirection(Rigidbody2D self,Rigidbody2D target) {
            Vector2 _interpol = target.position - self.position;
            
            float _tan = _interpol.y / _interpol.x;
            Mathf.Atan(_tan);
            float _sin = Mathf.Sin(Mathf.Atan(_tan));
            float _cos = Mathf.Cos(Mathf.Atan(_tan));
            return new Vector2(_cos, _sin);
        }
    }
}
