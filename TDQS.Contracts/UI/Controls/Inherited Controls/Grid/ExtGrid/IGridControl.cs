#region CLR�汾 4.0.30319.225
// IDataGridView �ӿ�
// ʱ�䣺2011-11-28 15:26:48
// ���ƣ�IDataGridView �ӿ�
// ��٣��������ݱ������ӿ�
//
// �����ˣ�����ΰ
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace TDQS.Contracts
{
    /// <summary>
    /// �������ݱ������ӿ�
    /// </summary>
    public interface IGridControl : IGridOperat
    {
        #region ����
        /// <summary>
        /// ������ʾ��
        /// </summary>
        void SetColumns();
        #endregion // ����
        #region ����
        /// <summary>
        /// ���ݿ����ӿ�
        /// </summary>
        IDatabase DB { get; set; }
        /// <summary>
        /// DataGridView��������
        /// </summary>
        Control Instance { get; }
        /// <summary>
        /// ���ݱ�
        /// </summary>
        DataTable DataTable { get; set; }
        /// <summary>
        /// ˵����
        /// </summary>
        IExplanationTable ExplanationTable { get; set; }
        /// <summary>
        /// �������ݶ���
        /// </summary>
        IObjectOperable ObjectOperable { get; set; }
        /// <summary>
        /// ָ����Ҫ��ֵ�ϲ�������
        /// </summary>
        List<string> MergeColumnNames { get; set; }

        /// <summary>
        /// ��ȡ����ʾ����
        /// </summary>
        DataTable FilterTable { get;  }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

