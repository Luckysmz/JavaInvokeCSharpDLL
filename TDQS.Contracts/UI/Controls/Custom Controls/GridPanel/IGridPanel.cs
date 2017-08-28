#region CLR�汾 4.0.30319.239
// IGridPanel �ӿ�
// ʱ�䣺2011/10/12 16:10:31
// ���ƣ�IGridPanel �ӿ�
// ��٣�����û��ؼ��������ӿ�
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
    /// ����û��ؼ��������ӿ�
    /// </summary>
    public interface IGridPanel
    {
        #region ����
        /// <summary>
        /// ���ݰ�
        /// </summary>
        void DataBind();
        #endregion // ����

        #region ����
        /// <summary>
        /// �û��ؼ�
        /// </summary>
        IGridControl GridContrl { get; }
        /// <summary>
        /// �����û��ؼ�
        /// </summary>
        UserControl View { get; }
        /// <summary>
        /// ֻ������
        /// </summary>
        bool ReadOnly { set; }
        /// <summary>
        /// �ײ���������ʽ
        /// </summary>
        ButtomPanelStyle ButtomPanelStyle { get; set; }
        #endregion // ����

        #region �¼�
        event EventHandler RefreshData;

        event EventHandler ExportData;

        event EventHandler ExportDataToCnpx;

        event Action<string> RelocateElement;
        #endregion // �¼�
              

    }

    /// <summary>
    /// �ײ���������ʽ
    /// </summary>
    public enum ButtomPanelStyle
    {
        Static = 0,
        Chart = 1,
        Hide = 9
    }
}

