﻿using System;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using EngineCore;
namespace SeekerGame
{
    public class GameSceneOtherCamera
    {
        private Transform m_cameraPointTrans = null;
        private GameObject m_boxPointObj = null;
        private BoxCollider m_boxPointCollider = null;
        private SceneCameraParams_New m_cameraParams = null;
        private SceneCameraPoint m_sceneCameraPoint = null;
        private string m_cameraName;
        public GameSceneOtherCamera(SceneCameraPoint cameraPoint,GameObject boxPointObj)
        {
            this.m_sceneCameraPoint = cameraPoint;
            this.m_cameraPointTrans = cameraPoint.m_cameraObj.transform;
            this.m_boxPointObj = boxPointObj;
            this.m_cameraName = boxPointObj.name;
            this.m_boxPointCollider = this.m_boxPointObj.GetComponent<BoxCollider>();
            this.m_cameraParams = this.m_cameraPointTrans.GetComponent<SceneCameraParams_New>();
        }

        public void PlayCameraTween(GameObject cameraObj,Action<SceneCameraParams_New, bool,string> callback = null)
        {
            Transform cameraTran = cameraObj.transform;
            Vector3[] wayPoint = new Vector3[2];
            wayPoint[0] = cameraTran.position;
            wayPoint[1] = m_cameraPointTrans.position;
            PlayCameraPointEffect(true);
            cameraTran.DOPath(wayPoint, 2f, PathType.CatmullRom, PathMode.Full3D).SetEase(Ease.InQuad).OnComplete(() => {
                if (callback != null)
                {
                    callback(m_cameraParams,m_sceneCameraPoint.m_canZoom,m_cameraName);
                }
            });
            cameraTran.DORotate(m_cameraPointTrans.eulerAngles,2f).SetEase(Ease.InCubic);
        }

        public void PlayCameraPointEffect(bool isMove)
        {
            m_sceneCameraPoint.m_normalParticle.SetActive(!isMove);
            m_sceneCameraPoint.m_playParticle.SetActive(isMove);
            this.m_boxPointCollider.enabled = !isMove;
            //this.m_boxPointObj.SetActive(!isMove);
        }


        public void SetEffectVisible(bool visible)
        {
            m_sceneCameraPoint.m_normalParticle.SetActive(visible);
            m_sceneCameraPoint.m_playParticle.SetActive(false);
            this.m_boxPointObj.SetActive(visible);
        }

        public void OnDestory()
        {

        }

        
    }
}
