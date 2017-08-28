#region CLR�汾 4.0.30319.269
// FunctionAction ��
// ʱ�䣺2012-5-16 17:03:49
// ���ƣ�FunctionAction
// ��٣�����ִ�ж���
//
// �����ˣ�����
// ��Ȩ��Copyright (C) 2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDQS.Contracts
{
    /// <summary>
    /// ����ִ�ж���
    /// </summary>
    public sealed class FunctionAction
    {
        #region ���������

        /// <summary>
        ///����
        /// </summary>
        /// <param name="funcStruct">���ܵ����ݽṹ</param>
        public FunctionAction(FunctionStruct funcStruct)
        {
            m_funcStruct = funcStruct;
        }
        
        #endregion // ���������

        #region ���з���
        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���
        /// <summary>
        /// �������ݽṹ
        /// </summary>
        private FunctionStruct m_funcStruct;

        /// <summary>
        /// �������ݽṹ
        /// </summary>
        public FunctionStruct FuncStruct
        {
            get
            {
                return m_funcStruct;
            }
        }
        #endregion // ���Լ���˽�б���

    }

    /// <summary>
    /// ��������ö��
    /// </summary>
    public enum FunctionType
    {
        Category,
        Item
    }
    
    #region  Struct
    /// <summary>
    /// �������ݽṹ
    /// </summary>
    public struct FunctionStruct
    {
        /// <summary>
        /// ����
        /// </summary>
        public Action<SubSystem> Action;
        /// <summary>
        /// ����
        /// </summary>
        public string Name;
        /// <summary>
        /// �����������к�
        /// </summary>
        public int Row;
        /// <summary>
        /// ����
        /// </summary>
        public FunctionType Type;

        /// <summary>
        /// ��ϵͳ
        /// </summary>
        public SubSystem SubSystem;

        /// <summary>
        /// ��������
        /// </summary>
        public string FuntionText;

        /// <summary>
        /// ������ (�˵����߹�������)
        /// </summary>
        public object Handler;

        /// <summary>
        /// Check��������
        /// </summary>
        public string CheckFunction;

        /// <summary>
        /// Enable��������
        /// </summary>
        public string EnableFunction;

        /// <summary>
        /// Visible��������
        /// </summary>
        public string VisibleFunction;

        /// <summary>
        /// ���������ڵ������ռ�
        /// </summary>
        public string Namespace;

        /// <summary>
        /// ˫����������
        /// </summary>
        public string DBClickFunction;

        /// <summary>
        /// ��ݼ�����
        /// </summary>
        public string ShortcutKey;

        /// <summary>
        /// ��������
        /// </summary>
        public string ShortcutCommand;

        /// <summary>
        /// �Ƿ�Ϊȫ�����ȼ�
        /// </summary>
        public bool GlobalShortcut;
    }

    #endregion
}