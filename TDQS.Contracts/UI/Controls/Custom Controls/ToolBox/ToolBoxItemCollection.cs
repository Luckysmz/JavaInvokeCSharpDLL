#region CLR�汾 4.0.30319.239
// ToolBoxItemCollection ��
// ʱ�䣺2011-11-28 10:37:39
// ���ƣ���������Ŀ������
// ��٣��洢��������Ŀ
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TDQS.Contracts
{
    /// <summary>
    /// ToolBoxItemCollection ��
    /// </summary>
    public class ToolBoxItemCollection : KeyedCollection<string, IToolBoxItem>
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public ToolBoxItemCollection()
        {
            //
            
            //
        }

        #endregion // ���������

        #region ���з���
        #endregion // ���з���

        #region ��������
        /// <summary>
        /// ��ȡ��������Ŀ��KEY
        /// </summary>
        /// <param name="item">��������Ŀ</param>
        /// <returns>��������Ŀ��KEY</returns>
        protected override string GetKeyForItem(IToolBoxItem item)
        {
            return item.ID;
        }
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���
        #endregion // ���Լ���˽�б���
    }
}