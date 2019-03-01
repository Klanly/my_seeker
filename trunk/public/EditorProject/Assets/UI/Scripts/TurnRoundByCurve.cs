﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.UI;

public class TurnRoundByCurve : MonoBehaviour
{
    #region 动画曲线实现轨迹
    public Transform m_begin_move_tf;
    //public Transform m_middle_tf;
    public Transform m_end_move_tf;
    public AnimationCurve m_H_curve;
    public AnimationCurve m_V_curve;
    public AnimationCurve m_scale_curve;
    public float m_dt_between_2_card;
    public float m_middle_time_factor;
    public AnimationCurve m_rotate_curve;
    public Transform m_begin_rotate_tf;
    public Transform m_end_rotate_tf;


    private float m_h_total_time = -1.0f;
    private float m_v_total_time = -1.0f;
    private float m_cur_time;
    private float m_middle_time;
    private float m_middle_local_pos_x;

    private float m_change_time_dt;

    private List<GameObject> m_location_itmes = new List<GameObject>();
    private List<GameObject> m_avatar_items = new List<GameObject>();

    private Coroutine m_change_time_coroutine = null;

    private float m_r_total_time = -1.0f;
    #endregion




    public RectTransform canvasRectTrans;

    private RectTransform transTurnTable;
    private Transform transLocation;
    private Transform transLocationItem;
    private Transform transAvatarManager;
    private Transform transAvatarItem;

    private Dictionary<GameObject, GameObject> dictAvater = new Dictionary<GameObject, GameObject>();

    public float minScale = 0.5f;       //最小缩放系数
    public int avaterCount = 2;         //个数

    private Vector2 originPos;          //圆心
    private Vector2 refDir;             //初始参考方向
    private float radius;               //圆半径
    private float beginPointerX;
    private float beginEulerZ = 0;

    private Vector3 m_vTuntableOriginAngel = Vector3.zero;
    void Awake()
    {
        InitUI();
    }

    private void InitUI()
    {
        transTurnTable = transform.Find("Turntable").GetComponent<RectTransform>();
        transLocation = transform.Find("Turntable/Location");
        transLocationItem = transform.Find("Turntable/Location/LocationItem");
        transAvatarManager = transform.Find("AvatarManager");
        transAvatarItem = transform.Find("AvatarManager/AvatarItem");

    }

    private void InitParam()
    {
        m_vTuntableOriginAngel = transTurnTable.localEulerAngles;
        originPos = GetPositionInCanvas(transTurnTable.gameObject);
        Vector2 refPoint = GetPositionInCanvas(transLocationItem.gameObject);
        refDir = (refPoint - originPos).normalized;
        //radius = transLocationItem.localPosition.y;
        radius = (refPoint - originPos).magnitude;

        this.m_location_itmes.Clear();
        this.m_avatar_items.Clear();
        this.m_h_total_time = this.m_H_curve[this.m_H_curve.length - 1].time;
        this.m_v_total_time = this.m_V_curve[this.m_V_curve.length - 1].time;
        this.m_cur_time = 0.0f;

        //float middle_factor = Mathf.Abs(this.m_end_tf.localPosition.x - this.m_begin_tf.localPosition.x) / Mathf.Abs(this.m_middle_tf.localPosition.x - this.m_begin_tf.localPosition.x);
        //this.m_middle_time = this.m_h_total_time * middle_factor;

        this.m_middle_time = this.m_h_total_time * this.m_middle_time_factor;
        this.m_middle_local_pos_x = this.GetCurveLocalPos(this.m_middle_time).x;

        this.m_change_time_dt = 0.0f;

        this.m_r_total_time = this.m_rotate_curve[this.m_rotate_curve.length - 1].time;

    }

    public void InitEvent()
    {
        UGUIDragHandler.Get(transTurnTable.gameObject).onDrag += OnTurntableDrag;
        UGUIDragHandler.Get(transTurnTable.gameObject).onBeginDrag += OnTurntableBeginDrag;
        UGUIDragHandler.Get(transTurnTable.gameObject).onEndDrag += OnTurntableEndDrag;
    }

    void Start()
    {
        InitParam();
        InitEvent();

        CreateAvater();
    }


    public void CreateAvater()
    {
        for (int i = 1; i <= avaterCount; i++)
        {
            //创建location
            var locationItem = GameObject.Instantiate(transLocationItem.gameObject) as GameObject;
            locationItem.SetActive(true);
            locationItem.transform.SetParent(transLocation);
            locationItem.transform.localScale = Vector3.one;
            locationItem.transform.rotation = Quaternion.identity;

            //从（0，r）开始旋转，结合旋转矩阵得到坐标
            //float rotateRadian = (2 * Mathf.PI / avaterCount) * (i - 1);
            //float x = -radius * Mathf.Sin(rotateRadian);
            //float y = radius * Mathf.Cos(rotateRadian);
            //locationItem.transform.localPosition = new Vector3(x, y, -10);
            locationItem.transform.localPosition = this.m_begin_move_tf.localPosition;

            this.m_location_itmes.Add(locationItem);

            //创建avater
            var avatarItem = GameObject.Instantiate(transAvatarItem.gameObject) as GameObject;
            avatarItem.SetActive(true);
            avatarItem.transform.SetParent(transAvatarManager);
            avatarItem.transform.localPosition = Vector3.one;
            avatarItem.transform.localScale = Vector3.one;
            //设置属性
            var tex = avatarItem.transform.Find("Text").GetComponent<Text>();
            tex.text = i.ToString();

            this.m_avatar_items.Add(avatarItem);

            dictAvater.Add(locationItem, avatarItem);
        }

        //UpdateAvaterTransform();
        //AdjustShowOrder();
        this.UpdateAllTransform();
    }


    //更新卡牌位置
    public void UpdateAvaterTransform()
    {
        //foreach (var item in dictAvater)
        //{
        //    var pos = GetPositionInCanvas(item.Key);
        //    var avaterRT = item.Value.GetComponent<RectTransform>();
        //    avaterRT.anchoredPosition = pos;

        //    ////计算向量点乘
        //    //Vector2 dir = (pos - originPos).normalized;
        //    //float cos = dir.x * refDir.x + dir.y * refDir.y;

        //    ////缩放
        //    //float scale = (cos + 1 + minScale) / 2;
        //    //scale *= scale;
        //    //scale = Mathf.Clamp(scale, minScale, 1);
        //    //avaterRT.localScale = new Vector3(scale, scale, scale);
        //}

        for (int i = 0; i < this.m_location_itmes.Count; ++i)
        {
            var pos = GetPositionInCanvas(this.m_location_itmes[i]);
            var avatarRT = this.m_avatar_items[i].GetComponent<RectTransform>();
            avatarRT.anchoredPosition = pos;
            avatarRT.rotation = this.m_location_itmes[i].transform.rotation;
        }
    }

    //获得canvas下坐标
    public Vector2 GetPositionInCanvas(GameObject obj)
    {
        Vector2 localPoint;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRectTrans, obj.transform.position, null, out localPoint))
        {
            return localPoint;
        }

        return Vector2.zero;
    }

    //调整视图上的显示顺序，保证近处遮挡远处
    public void AdjustShowOrder()
    {
        List<GameObject> avaters = new List<GameObject>(dictAvater.Values);
        avaters.Sort(delegate (GameObject a, GameObject b)
        {
            //if (a.transform.localPosition.y > b.transform.localPosition.y)
            //    return -1;

            if (a.transform.localPosition.x > b.transform.localPosition.x)
                return -1;

            return 0;
        });

        avaters.ForEach(p =>
        {
            p.transform.SetAsLastSibling();
        });
    }

    //旋转结束限制卡牌到每个分割点位置
    private void OnTurntableEndDrag(GameObject target, PointerEventData eventData)
    {
        //float endPointerX = eventData.position.x;
        //Vector3 eulerAng = Vector3.forward * (endPointerX - beginPointerX) / 3.1415f;

        //float n = eulerAng.z / (360 / avaterCount);
        //n = Mathf.RoundToInt(n);
        ////print("eulerAng : " + eulerAng + " n = " + n);

        //if (Mathf.Abs(eulerAng.z) > 180 / avaterCount)
        //{
        //    float z = 0;
        //    z = beginEulerZ + (360 / avaterCount) * n;
        //    if (Mathf.Abs(z) >= 360)
        //    {
        //        if (z > 0)
        //            z = z - 360;
        //        else
        //            z = z + 360;
        //    }
        //    beginEulerZ = z;        //更新z
        //    transTurnTable.DORotate(new Vector3(m_vTuntableOriginAngel.x, m_vTuntableOriginAngel.y, z), 0.2f)
        //             .OnUpdate(() => { UpdateAvaterTransform(); })
        //             .SetId("OnTurntableEndDrag DORotate");

        //}
        //else
        //{
        //    transTurnTable.DORotate(new Vector3(m_vTuntableOriginAngel.x, m_vTuntableOriginAngel.y, beginEulerZ), 0.2f)
        //             .OnUpdate(() => { UpdateAvaterTransform(); })
        //             .SetId("OnTurntableEndDrag DORotate");
        //}

        float min_delta_x = -1.0f;
        int min_index = 0;
        for (int i = 0; i < this.m_location_itmes.Count; ++i)
        {
            float cur_delta_x = this.m_location_itmes[i].transform.localPosition.x - this.m_middle_local_pos_x;
            float cur_delta_x_abs = Mathf.Abs(cur_delta_x);

            if (min_delta_x < 0.0f || cur_delta_x_abs < min_delta_x)
            {
                min_delta_x = cur_delta_x_abs;
                min_index = i;
            }
        }

        float min_index_item_time = this.m_cur_time - min_index * this.m_dt_between_2_card;
        float dt = this.m_middle_time - min_index_item_time;
        float aim_time = this.m_cur_time + dt;

        if (null != this.m_change_time_coroutine)
        {
            this.StopCoroutine(this.m_change_time_coroutine);
        }
        m_change_time_dt = 0.0f;
        this.m_change_time_coroutine = this.StartCoroutine(CoroutineChangeTime(this.m_cur_time, aim_time));
    }

    private IEnumerator CoroutineChangeTime(float begin_time_, float end_time_)
    {
        do
        {
            m_change_time_dt += Time.deltaTime;
            float dt_factor = Mathf.Clamp(m_change_time_dt, 0.0f, 1.0f);
            this.m_cur_time = Mathf.Lerp(begin_time_, end_time_, dt_factor);
            this.UpdateAllTransform();

            yield return new WaitForEndOfFrame();
        }
        while (m_change_time_dt < 1.0f);


    }


    private void OnTurntableBeginDrag(GameObject target, PointerEventData eventData)
    {
        if (null != this.m_change_time_coroutine)
        {
            this.StopCoroutine(this.m_change_time_coroutine);
        }

        beginPointerX = eventData.position.x;
    }

    private void OnTurntableDrag(GameObject target, PointerEventData eventData)
    {
        //Vector3 eulerAng = Vector3.forward * eventData.delta.x / 3.1415f;
        //transTurnTable.Rotate(eulerAng);

        float delta_time = 0.0f;

        //Debug.Log("滑动速度 " + eventData.delta.x);

        if (eventData.delta.x < -2.0f)
        {
            if (this.m_location_itmes[this.m_location_itmes.Count - 1].transform.localPosition.x <= this.m_middle_local_pos_x)
                return;

            float slide_factor = Mathf.Abs(eventData.delta.x) / 15.0f + 1.0f;
            //左滑动
            delta_time = Time.deltaTime * slide_factor;
        }
        else if (eventData.delta.x > 2.0f)
        {
            //右滑动
            if (this.m_location_itmes[0].transform.localPosition.x >= this.m_middle_local_pos_x)
                return;

            float slide_factor = Mathf.Abs(eventData.delta.x) / 15.0f + 1.0f;

            delta_time = -Time.deltaTime * slide_factor;
        }
        else
        {
            return;
        }

        this.m_cur_time += delta_time;

        this.UpdateAllTransform();
    }

    private void UpdateAllTransform()
    {
        this.UpdateLocateRotation();
        this.UpdateLocateTransform();
        this.UpdateAvaterTransform();
        this.AdjustShowOrder();
    }

    private void UpdateLocateRotation()
    {
        for (int i = 0; i < this.m_location_itmes.Count; ++i)
        {
            float cur_r_time;
            cur_r_time = this.m_cur_time - i * this.m_dt_between_2_card;
            cur_r_time = Mathf.Clamp(cur_r_time, 0.0f, this.m_r_total_time);
            float factor_r = this.m_rotate_curve.Evaluate(cur_r_time);
            Quaternion cur_r = Quaternion.Slerp(m_begin_rotate_tf.localRotation, m_end_rotate_tf.localRotation, factor_r);
            this.m_location_itmes[i].transform.localRotation = cur_r;
        }
    }

    private void UpdateLocateTransform()
    {
        for (int i = 0; i < this.m_location_itmes.Count; ++i)
        {
            float cur_h_time, cur_v_time;
            cur_h_time = cur_v_time = this.m_cur_time - i * this.m_dt_between_2_card;
            cur_h_time = Mathf.Clamp(cur_h_time, 0.0f, this.m_h_total_time);
            float factor_x = this.m_H_curve.Evaluate(cur_h_time);
            float _x = m_begin_move_tf.localPosition.x * (1f - factor_x) + m_end_move_tf.localPosition.x * factor_x;

            cur_v_time = Mathf.Clamp(cur_v_time, 0.0f, this.m_v_total_time);
            float factor_y = this.m_V_curve.Evaluate(cur_v_time);
            float _y = m_begin_move_tf.localPosition.y * (1f - factor_y) + m_end_move_tf.localPosition.y * factor_y;

            this.m_location_itmes[i].transform.localPosition = new Vector3(_x, _y, m_begin_move_tf.localPosition.z);
        }
    }


    private void GetCurveXY(int index_, float cur_t_, out float x_, out float y_)
    {
        float cur_h_time, cur_v_time;
        cur_h_time = cur_v_time = cur_t_ - index_ * this.m_dt_between_2_card;
        cur_h_time = Mathf.Clamp(cur_h_time, 0.0f, this.m_h_total_time);
        float factor_x = this.m_H_curve.Evaluate(cur_h_time);
        x_ = m_begin_move_tf.localPosition.x * (1f - factor_x) + m_end_move_tf.localPosition.x * factor_x;

        cur_v_time = Mathf.Clamp(cur_v_time, 0.0f, this.m_v_total_time);
        float factor_y = this.m_V_curve.Evaluate(cur_v_time);
        y_ = m_begin_move_tf.localPosition.y * (1f - factor_y) + m_end_move_tf.localPosition.y * factor_y;
    }

    private Vector3 GetCurveWorldPos(float cur_t_)
    {
        float cur_h_time, cur_v_time;
        cur_h_time = cur_v_time = cur_t_;
        cur_h_time = Mathf.Clamp(cur_h_time, 0.0f, this.m_h_total_time);
        float factor_x = this.m_H_curve.Evaluate(cur_h_time);
        float _x = m_begin_move_tf.position.x * (1f - factor_x) + m_end_move_tf.position.x * factor_x;

        cur_v_time = Mathf.Clamp(cur_v_time, 0.0f, this.m_v_total_time);
        float factor_y = this.m_V_curve.Evaluate(cur_v_time);
        float _y = m_begin_move_tf.position.y * (1f - factor_y) + m_end_move_tf.position.y * factor_y;

        return new Vector3(_x, _y, m_begin_move_tf.position.z);
    }

    private Vector3 GetCurveLocalPos(float cur_t_)
    {
        float cur_h_time, cur_v_time;
        cur_h_time = cur_v_time = cur_t_;
        cur_h_time = Mathf.Clamp(cur_h_time, 0.0f, this.m_h_total_time);
        float factor_x = this.m_H_curve.Evaluate(cur_h_time);
        float _x = m_begin_move_tf.localPosition.x * (1f - factor_x) + m_end_move_tf.localPosition.x * factor_x;

        cur_v_time = Mathf.Clamp(cur_v_time, 0.0f, this.m_v_total_time);
        float factor_y = this.m_V_curve.Evaluate(cur_v_time);
        float _y = m_begin_move_tf.localPosition.y * (1f - factor_y) + m_end_move_tf.localPosition.y * factor_y;

        return new Vector3(_x, _y, m_begin_move_tf.localPosition.z);
    }

    void OnDrawGizmos()
    {
        if (this.m_h_total_time < 0.0f || this.m_v_total_time < 0.0f)
        {
            this.m_h_total_time = 1.5f;
            this.m_v_total_time = 1.5f;
        }


        Vector3 line_begin = this.m_begin_move_tf.position;
        Color color = Color.red;


        for (float t = 0.0f; t <= 1.5f; t += 0.1f)
        {
            Vector3 vec = GetCurveWorldPos(t);
            Gizmos.color = color;
            Gizmos.DrawLine(line_begin, vec);

            line_begin = vec;
        }

        Gizmos.color = Color.green;
        Gizmos.DrawSphere(this.GetCurveWorldPos(this.m_middle_time), 0.3f);
    }

    //void OnGUI()
    //{
    //   if(GUILayout.Button("位置调整2->1"))
    //   {
    //       //把2号avater排到第一位置


    //   }
    //}

    ////循环左移
    //public void LeftShift(GameObject[] objs,int shiftCount,int len)
    //{
    //    Reverse(objs, 0, shiftCount - 1);
    //    Reverse(objs, shiftCount, len - 1);
    //    Reverse(objs, 0, len - 1);
    //}

    //// 逆序
    //public GameObject[] Reverse(GameObject[] objs, int i, int j)
    //{
    //    for (int begin = i, end = j; begin < end; begin++, end--)
    //    {
    //        GameObject temp = objs[begin];
    //        objs[begin] = objs[end];
    //        objs[end] = temp;
    //    }
    //    return objs;
    //}
}
