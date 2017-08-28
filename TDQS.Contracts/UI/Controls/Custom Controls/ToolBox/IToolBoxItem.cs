#region CLR�汾 4.0.30319.239
// IToolBoxItem �ӿ�
// ʱ�䣺2011-11-28 10:37:39
// ���ƣ���������Ŀ��
// ��٣���װ��������Ŀ
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
using System.Drawing;
using TDQS.Contracts;
using System.Reflection;

namespace TDQS.Contracts
{
    /// <summary>
    /// IToolBoxItem ��
    /// </summary>
    public interface IToolBoxItem : IDisposable, ICloneable
    {
        /// <summary>
        /// ���������¼�
        /// </summary>
        void DoClick();

        /// <summary>
        /// ����Drop�¼�
        /// </summary>
        void DoDrop();

        /// <summary>
        /// ����˫��
        /// </summary>
        void DoDoubleClick();

        /// <summary>
        /// ǿ��ˢ��ͼ��
        /// </summary>
        void RefreshIcon();

        /// <summary>
        /// �����¼�
        /// </summary>
        event EventHandler Click;

        /// <summary>
        /// ��ק�¼�
        /// </summary>
        event EventHandler Drop;

        /// <summary>
        /// ˫���¼�
        /// </summary>
        event EventHandler DoubleClick;

        /// <summary>
        /// ��ĿID
        /// </summary>
        string ID
        {
            get;
            set;
        }

        /// <summary>
        /// ��Ŀ�Ƿ���ʾ
        /// </summary>
        bool Visible
        {
            get;
            set;
        }

        /// <summary>
        /// ��Ŀλ��
        /// </summary>
        int Position
        {
            get;
            set;
        }

        /// <summary>
        /// ��Ŀ����
        /// </summary>
        string Name
        {
            get;
            set;
        }

        /// <summary>
        /// ��Ŀͼ��
        /// </summary>
        Image Icon
        {
            get;
        }

        /// <summary>
        /// ��Ŀ����
        /// </summary>
        Font Font
        {
            get;
            set;
        }

        /// <summary>
        /// ��Ŀ������ɫ
        /// </summary>
        Color ForeColor
        {
            get;
            set;
        }

        /// <summary>
        /// ��Ŀ�Ƿ�Ϊ������Ŀ
        /// </summary>
        bool IsBand
        {
            get;
            set;
        }

        /// <summary>
        /// ��Ŀ�Ƿ�Ϊ�շ���
        /// </summary>
        bool IsEmptyBand
        {
            get;
        }

        /// <summary>
        /// ��Ŀ�Ƿ�����Ҫ��ʾ������Ŀ
        /// </summary>
        bool HasVisibleItem();

        /// <summary>
        /// �շ�������
        /// </summary>
        string Description
        {
            get;
            set;
        }

        /// <summary>
        /// ��Ŀ���ࣨ����Ŀ��
        /// </summary>
        IToolBoxItem Category
        {
            get;
            set;
        }

        /// <summary>
        /// ����Ŀ
        /// </summary>
        ToolBoxItemCollection SubItems
        {
            get;
            set;
        }

        /// <summary>
        /// ��ʾ�ı�
        /// </summary>
        string Tooltip
        {
            get;
            set;
        }

        /// <summary>
        /// Ԫ������
        /// </summary>
        string TypeNo
        {
            get;
            set;
        }

        /// <summary>
        /// ��Ŀ����������
        /// </summary>
        IToolBox ToolBox
        {
            get;
            set;
        }


        /// <summary>
        /// �����䵼����Ŀ
        /// </summary>
        IToolBoxItemObject ItemObject
        {
            get;
            set;
        }

        /// <summary>
        /// �����¼�������
        /// </summary>
        string ClickHandler
        {
            get;
            set;
        }

        /// <summary>
        /// ˫���¼�������
        /// </summary>
        string DbClickHandler
        {
            get;
            set;
        }

        /// <summary>
        /// Drop�¼�������
        /// </summary>
        string DropHandler
        {
            get;
            set;
        }

        /// <summary>
        /// �Ƿ�����ͨ��Ԫ��
        /// </summary>
        bool IsUsually
        {
            get;
            set;
        }

        /// <summary>
        /// Ԫ����ͨ��Ԫ�������е�λ��
        /// </summary>
        int UsuallyBandPosition
        {
            get;
            set;
        }

        /// <summary>
        /// Ԫ����ͨ��Ԫ���������Ƿ���ʾ
        /// </summary>
        bool UsuallyVisible
        {
            get;
            set;
        }

        /// <summary>
        /// ��ѡ��Ŀ�Ƿ����Գ�����Ŀ����
        /// </summary>
        bool FromUsuallyBand
        {
            get;
            set;
        }

        /// <summary>
        /// ͼ������
        /// </summary>
        Font IconFont
        {
            get;
            set;
        }

        /// <summary>
        /// ͼ����ɫ
        /// </summary>
        Color IconColor
        {
            get;
            set;
        }

        /// <summary>
        /// ͼ������
        /// </summary>
        int IconIndex
        {
            get;
            set;
        }

        /// <summary>
        /// ״̬����ʾ��Ϣ
        /// </summary>
        string StatusBarTip
        {
            get;
            set;
        }

        /// <summary>
        /// Ԫ������
        /// </summary>
        ElementType ElementType
        {
            get;
            set;
        }

        /// <summary>
        /// �Ƿ񼤻�
        /// </summary>
        bool Enabled
        {
            get;
            set;
        }
    }
}