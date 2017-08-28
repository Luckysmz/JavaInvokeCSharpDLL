#region CLR�汾 4.0.30319.239
// IDataView �ӿ�
// ʱ�䣺2012-5-11 14:04:17
// ���ƣ�IDataView 
// ��٣�����У�������ڽӿ�
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace TDQS.Contracts
{
    /// <summary>
    /// ����У�������ڽӿ�
    /// </summary>
    public interface IDataView
    {
        #region ����

        /// <summary>
        /// ��ʾ���
        /// </summary>
        /// <param name="formTitle">�������</param>
        /// <param name="treeTitle">�����ڵ�</param>
        /// <param name="view">��ͼ����</param>
        /// <param name="elements">Ԫ������</param>
        void BindData(string formTitle, string treeTitle,IView  view, ICollection<IElement> elements);

        /// <summary>
        /// ��ʾ���
        /// </summary>
        /// <param name="formTitle">�������</param>
        /// <param name="treeTitle">�����ڵ�</param>
        /// <param name="view">��ͼ����</param>
        /// <param name="tables">���ݱ���</param>
        void BindData(string formTitle, string treeTitle, IView view, IList<DataTable> tables);

        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

