#region CLR�汾 4.0.30319.17379
// IFilterResult �ӿ�
// ʱ�䣺2012/07/10 17:03:49
// ���ƣ�IFilterResult
// ��٣�����ѡ����
//
// �����ˣ�������
// ��Ȩ��Copyright (C) 2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
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
    /// ����ѡ����
    /// </summary>
    public interface IFilterResult : IToolWindow
    {
        #region ����
        void DataBind(List<IElement> elements, IDocument document);
        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

