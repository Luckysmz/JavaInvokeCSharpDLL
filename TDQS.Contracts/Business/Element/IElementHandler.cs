#region CLR�汾 4.0.30319.269
// IElementHandler �ӿ�
// ʱ�䣺2012-6-13 18:22:28
// ���ƣ�IElementHandler
// ��٣�Ԫ�������ӿڣ�������ǰ��ͼ�е�Ԫ�����ϡ�Ԫ�����ƶ��󼯺ϡ�ѡ�м��ϡ��ڴ滺�弯�ϵ�
//
// �����ˣ�����
// ��Ȩ��2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
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
    /// Ԫ�������ӿڣ�������ǰ��ͼ�е�Ԫ�����ϡ�Ԫ�����ƶ��󼯺ϡ�ѡ�м��ϡ��ڴ滺�弯�ϵ�
    /// </summary>
    public interface IElementHandler
    {
        #region ����
        #endregion // ����

        #region ����

        /// <summary>
        /// ���ƶ��󼯺�
        /// </summary>
        List<IDrawObject> GraphicsList { get; set; }

        /// <summary>
        /// ѡ�м���
        /// </summary>
        ICollection<string> SelectedElements { get; set; }

        /// <summary>
        /// Ԫ�����ϣ�����ͼ�иü���Ϊ�������ϡ���ͼ��Ϊ��ͼ���ϡ�
        /// </summary>
        IElementCollection ElementCollection { get; set; }

        /// <summary>
        /// �±���ʻ��ƶ���
        /// </summary>
        /// <param name="index">����</param>
        /// <returns></returns>
        IDrawObject this[int index] { get; }

        /// <summary>
        /// ѡ�и���
        /// </summary>
        int SelectionCount { get; }

        /// <summary>
        /// ���ƶ������
        /// </summary>
        int GraphicsListCount { get; }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

