#region CLR�汾 4.0.30319.239
// IPropertyGrid �ӿ�
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�IPropertyGrid �ӿ�
// ��٣�PropertyGrid����ToolWindow
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
//  2013-5-24   ���      ��ӽӿ�[void ReadOnlyAllAttribute(ReadOnlyStatus readOnly = ReadOnlyStatus.Custom)]
// --------------------------------------------------------
//
//
//
//
// ========================================================
#endregion
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TDQS.Contracts
{
    /// <summary>
    /// PropertyGrid����ToolWindow
    /// </summary>
    public interface IPropertyGrid : IToolWindow
    {
        #region ����

        /// <summary>
        /// ��Ԫ��
        /// </summary>
        /// <param name="element">Ԫ������</param>
        void Bind(IElement element);

        /// <summary>
        /// ˢ��
        /// </summary>
        void Reload();

        /// <summary>
        /// ��������ҳ���Ƿ��������Կ���
        /// </summary>
        /// <param name="readOnly">ֻ��״̬</param>
        void ReadOnlyAllAttribute(ReadOnlyStatus readOnly = ReadOnlyStatus.Custom);

        #endregion // ����

        #region ����
        /// <summary>
        /// 
        /// </summary>
        bool Enable
        {
            set;
            get;
        }

        /// <summary>
        /// ��������
        /// </summary>
        PropertySort SortType
        {
            get;
            set;
        }

        /// <summary>
        /// �Ƿ�ˢ�����Կ�
        /// </summary>
        bool AutoRefresh
        {
            get;
            set;
        }

        #endregion // ����

        #region �¼�

        /// <summary>
        /// ����ֵ�ı���¼�
        /// </summary>
        event PropertyValueChangedEventHandler PropertyValueChanged;
        #endregion // �¼�
    }
}

