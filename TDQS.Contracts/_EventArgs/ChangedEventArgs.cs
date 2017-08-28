#region CLR�汾 4.0.30319.269
// ChangedEventArgs ��
// ʱ�䣺2012/6/5 14:43:10
// ���ƣ�Ԫ���ı��¼���������
// ��٣�Ԫ���ı��¼���������
//
// �����ˣ�������
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
    /// Ԫ���ı��¼���������
    /// </summary>
    public class ChangedEventArgs : EventArgs
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="propertyName">��������</param>
        /// <param name="explainTableColumn">����˵������</param>
        /// <param name="oldValue">���Ըı�ǰֵ</param>
        /// <param name="value">���Ըı��ֵ</param>
        public ChangedEventArgs(String propertyName, IXExplanationField explainTableColumn,Object oldValue, Object value)
        {
            m_PropertyName = propertyName;
            m_explainTableColumn = explainTableColumn;
            m_OldValue = oldValue;
            m_Value = value;
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="propertyName">��������</param>
        public ChangedEventArgs(String propertyName,object value, TriggerType trigType = TriggerType.PorperChange)
        {
            m_PropertyName = propertyName;
            m_Value = value;
            m_triggerType = trigType;
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="propertyName">��������</param>
        public ChangedEventArgs(String propertyName, TriggerType trigType = TriggerType.PorperChange)
        {
            m_PropertyName = propertyName;
            m_triggerType = trigType;
        }

        #endregion // ���������

        #region ���з���
        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���

        private IXExplanationField m_explainTableColumn;

        /// <summary>
        /// Ԫ�������ֶ�˵������
        /// </summary>
        public IXExplanationField ExplainTableColumn
        {
            get
            { 
                return m_explainTableColumn; 
            }
        }

        /// <summary>
        /// ��ȡ�ı�ֵ����������
        /// </summary>
        public String PropertyName
        {
            get
            {
                return m_PropertyName;
            }
        }
        private String m_PropertyName;


        /// <summary>
        /// ��ȡ���Ըı���ֵ
        /// </summary>
        public Object Value
        {
            get
            {
                return m_Value;
            }
        }
        /// <summary>
        /// ���Ըı���ֵ
        /// </summary>
        private Object m_Value;


        /// <summary>
        /// ��ȡ���Ըı�ǰ��ֵ
        /// </summary>
        public Object OldValue
        {
            get
            {
                return m_OldValue;
            }
        }
        /// <summary>
        /// ���Ըı���ֵ
        /// </summary>
        private TriggerType m_triggerType;

        /// <summary>
        /// ��ȡ���Ըı�ǰ��ֵ
        /// </summary>
        public TriggerType triggerType
        {
            get
            {
                return m_triggerType;
            }
        }
        /// <summary>
        /// ���Ըı���ֵ
        /// </summary>
        private Object m_OldValue;
        /// <summary>
        /// ָʾ�˴��¼��Ƿ���Ҫ������ͼ��ʾ
        ///  </summary>
        public bool NeedUpdateView = false;
        
        #endregion // ���Լ���˽�б���

    }

    /// <summary>
    /// ��������
    /// </summary>
    public enum TriggerType
    {
        PorperChange = 0,
        ParmsChange = 1,
        ToolLoad = 2,
        Command=3,
    }
}