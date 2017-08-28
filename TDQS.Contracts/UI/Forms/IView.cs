#region CLR�汾 4.0.30319.239
// IWorkarea �ӿ�
// ʱ�䣺2011-11-23 15:17:16
// ���ƣ�IWorkarea
// ��٣��������ӿڣ����й�����ʵ�ָýӿ�
//
// �����ˣ� ����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDQS.Contracts
{
    /// <summary>
    /// ��ͼ�ӿڣ��ĵ���һ��չʾ����
    /// </summary>
    public interface IView : IDockWindow
    {
        #region ����

        /// <summary>
        /// ���ù������󶨵�һ���ĵ�������
        /// </summary>
        /// <param name="doc"></param>
        void BindDocument(IDocument doc);

        /// <summary>
        /// ���ص�ǰ�ĵ�����
        /// </summary>
        /// <returns></returns>
        IDocument GetDocument();

        /// <summary>
        /// Ӧ���ĵ�������¹���������
        /// </summary>
        void UpdateData();

        /// <summary>
        /// ����
        /// </summary>
        void Save();

        #endregion // ����

        #region ����

        /// <summary>
        /// �ĵ�
        /// </summary>
        IDocument Document
        {
            get;
            set;
        }

        /// <summary>
        /// �Ƿ�Ϊ�ĵ���Ĭ����ͼ
        /// </summary>
        bool IsDefaultView 
        { 
            get; 
        }

        /// <summary>
        /// ��ȡ��������ͼֻ������
        /// </summary>
        Boolean ReadOnly
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ��������ͼ�رշ�ʽ
        /// </summary>
        ViewCloseMode CloseMode
        {
            get;
            set;
        }


        /// <summary>
        /// �Ƿ񼤻���ͼ
        /// </summary>
        bool Active
        {
            get;
            set;
        }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

