//----------------------------------------------
//            NGUI: Next-Gen UI kit
// Copyright © 2011-2014 Tasharen Entertainment
//----------------------------------------------

using UnityEngine;
using UnityEditor;
using System.Reflection;
using System.Collections.Generic;
using Entry = GOGUI.PropertyReferenceDrawer.Entry;

namespace GOGUI
{
    public static class EventDelegateEditor
    {

        /// <summary>
        /// 收集从指定游戏对象的委托列表。
        /// </summary>
        static public List<Entry> GetMethods(GameObject target)
        {
            MonoBehaviour[] comps = target.GetComponents<MonoBehaviour>();

            List<Entry> list = new List<Entry>();

            for (int i = 0, imax = comps.Length; i < imax; ++i)
            {
                MonoBehaviour mb = comps[i];
                if (mb == null) continue;

                MethodInfo[] methods = mb.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public);

                for (int b = 0; b < methods.Length; ++b)
                {
                    MethodInfo mi = methods[b];

                    if (mi.ReturnType == typeof(void))
                    {
                        string name = mi.Name;
                        if (name == "Invoke") continue;
                        if (name == "InvokeRepeating") continue;
                        if (name == "CancelInvoke") continue;
                        if (name == "StopCoroutine") continue;
                        if (name == "StopAllCoroutines") continue;
                        if (name == "BroadcastMessage") continue;
                        if (name.StartsWith("SendMessage")) continue;
                        if (name.StartsWith("set_")) continue;

                        Entry ent = new Entry();
                        ent.target = mb;
                        ent.name = mi.Name;
                        list.Add(ent);
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// 绘制一个编辑字段统一委派。
        /// </summary>

        static public bool Field(Object undoObject, EventDelegate del)
        {
            return Field(undoObject, del, true);
        }

        /// <summary>
        /// 绘制一个编辑字段统一委派。
        /// </summary>

        static public bool Field(Object undoObject, EventDelegate del, bool removeButton)
        {
            /*if (del == null) return false;
            bool prev = GUI.changed;
            GUI.changed = false;
            bool retVal = false;
            MonoBehaviour target = del.target;
            bool remove = false;

            if (removeButton && (del.target != null || del.isValid))
            {
                SUGUIEditorTools.SetLabelWidth(82f);

                if (del.target == null && del.isValid)
                {
                    EditorGUILayout.LabelField("Notify", del.ToString());
                }
                else
                {
                    target = EditorGUILayout.ObjectField("Notify", del.target, typeof(MonoBehaviour), true) as MonoBehaviour;
                }

                GUILayout.Space(-18f);
                GUILayout.BeginHorizontal();
                GUILayout.Space(70f);

                if (GUILayout.Button("", "ToggleMixed", GUILayout.Width(20f), GUILayout.Height(16f)))
                {
                    target = null;
                    remove = true;
                }
                GUILayout.EndHorizontal();
            }
            else target = EditorGUILayout.ObjectField("Notify", del.target, typeof(MonoBehaviour), true) as MonoBehaviour;

            if (remove)
            {
                SUGUIEditorTools.RegisterUndo("Delegate Selection", undoObject);
                del.Clear();
                EditorUtility.SetDirty(undoObject);
            }
            else if (del.target != target)
            {
                SUGUIEditorTools.RegisterUndo("Delegate Selection", undoObject);
                del.target = target;
                EditorUtility.SetDirty(undoObject);
            }

            if (del.target != null && del.target.gameObject != null)
            {
                GameObject go = del.target.gameObject;
                List<Entry> list = GetMethods(go);

                int index = 0;
                string[] names = PropertyReferenceDrawer.GetNames(list, del.ToString(), out index);
                int choice = 0;

                GUILayout.BeginHorizontal();
                choice = EditorGUILayout.Popup("Method", index, names);
                SUGUIEditorTools.DrawPadding();
                GUILayout.EndHorizontal();

                if (choice > 0 && choice != index)
                {
                    Entry entry = list[choice - 1];
                    SUGUIEditorTools.RegisterUndo("Delegate Selection", undoObject);
                    del.target = entry.target as MonoBehaviour;
                    del.methodName = entry.name;
                    EditorUtility.SetDirty(undoObject);
                    retVal = true;
                }

                GUI.changed = false;
                EventDelegate.Parameter[] ps = del.parameters;

                if (ps != null)
                {
                    for (int i = 0; i < ps.Length; ++i)
                    {
                        EventDelegate.Parameter param = ps[i];
                        Object obj = EditorGUILayout.ObjectField("   Arg " + i, param.obj, typeof(Object), true);

                        if (GUI.changed)
                        {
                            GUI.changed = false;
                            param.obj = obj;
                            EditorUtility.SetDirty(undoObject);
                        }

                        if (obj == null) continue;

                        GameObject selGO = null;
                        System.Type type = obj.GetType();
                        if (type == typeof(GameObject)) selGO = obj as GameObject;
                        else if (type.IsSubclassOf(typeof(Component))) selGO = (obj as Component).gameObject;

                        if (selGO != null)
                        {
                            // Parameters must be exact -- they can't be converted like property bindings
                            PropertyReferenceDrawer.filter = param.expectedType;
                            PropertyReferenceDrawer.canConvert = false;
                            List<PropertyReferenceDrawer.Entry> ents = PropertyReferenceDrawer.GetProperties(selGO, true, false);

                            int selection;
                            string[] props = GetNames(ents, GOGUITools.GetFuncName(param.obj, param.field), out selection);

                            GUILayout.BeginHorizontal();
                            int newSel = EditorGUILayout.Popup(" ", selection, props);
                            SUGUIEditorTools.DrawPadding();
                            GUILayout.EndHorizontal();

                            if (GUI.changed)
                            {
                                GUI.changed = false;

                                if (newSel == 0)
                                {
                                    param.obj = selGO;
                                    param.field = null;
                                }
                                else
                                {
                                    param.obj = ents[newSel - 1].target;
                                    param.field = ents[newSel - 1].name;
                                }
                                EditorUtility.SetDirty(undoObject);
                            }
                        }
                        else if (!string.IsNullOrEmpty(param.field))
                        {
                            param.field = null;
                            EditorUtility.SetDirty(undoObject);
                        }

                        PropertyReferenceDrawer.filter = typeof(void);
                        PropertyReferenceDrawer.canConvert = true;
                    }
                }
            }
            else retVal = GUI.changed;
            GUI.changed = prev;
            return retVal;*/
            return false;
        }

        /// <summary>
        /// 绘制一个编辑字段统一委派。
        /// </summary>

        static public void Field(Object undoObject, List<EventDelegate> list)
        {
            Field(undoObject, list, null, null);
        }

        /// <summary>
        /// 绘制一个编辑字段统一委派。
        /// </summary>

        static public void Field(Object undoObject, List<EventDelegate> list, string noTarget, string notValid)
        {
            bool targetPresent = false;
            bool isValid = false;

            // Draw existing delegates
            for (int i = 0; i < list.Count; )
            {
                EventDelegate del = list[i];

                if (del == null || (del.target == null && !del.isValid))
                {
                    list.RemoveAt(i);
                    continue;
                }

                Field(undoObject, del);
                EditorGUILayout.Space();

                if (del.target == null && !del.isValid)
                {
                    list.RemoveAt(i);
                    continue;
                }
                else
                {
                    if (del.target != null) targetPresent = true;
                    isValid = true;
                }
                ++i;
            }

            // Draw a new delegate
            EventDelegate newDel = new EventDelegate();
            Field(undoObject, newDel);

            if (newDel.target != null)
            {
                targetPresent = true;
                list.Add(newDel);
            }

            if (!targetPresent)
            {
                if (!string.IsNullOrEmpty(noTarget))
                {
                    GUILayout.Space(6f);
                    EditorGUILayout.HelpBox(noTarget, MessageType.Info, true);
                    GUILayout.Space(6f);
                }
            }
            else if (!isValid)
            {
                if (!string.IsNullOrEmpty(notValid))
                {
                    GUILayout.Space(6f);
                    EditorGUILayout.HelpBox(notValid, MessageType.Warning, true);
                    GUILayout.Space(6f);
                }
            }
        }

        /// <summary>
        /// 委托list转换为字符串数组
        /// </summary>

        static public string[] GetNames(List<Entry> list, string choice, out int index)
        {
            index = 0;
            string[] names = new string[list.Count + 1];
            names[0] = "<GameObject>";

            for (int i = 0; i < list.Count; )
            {
                Entry ent = list[i];
                string del = GOGUITools.GetFuncName(ent.target, ent.name);
                names[++i] = del;
                if (index == 0 && string.Equals(del, choice))
                    index = i;
            }
            return names;
        }

    }
}